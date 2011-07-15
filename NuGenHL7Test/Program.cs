using System;
using System.Collections.Generic;
using System.Text;
using Genetibase.NuGenHL7.parser;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.llp;
using Genetibase.NuGenHL7.app;
using Genetibase.NuGenHL7.model.v22.segment;

namespace NuGenHL7Test
{
    class Program
    {
        static void Main(string[] args)
        {
            NuGenParser p = new NuGenGenericParser();
            System.String msg = "MSH|^~\\&|LABMI1||DMCRES||19951010134000||ORU^R01|LABMI1199510101340007|D|2.2|||AL|\r\n" + "PID|||BB1127||LABHLVII^MICRO^A||19780625|F||||||||||001680\r\n" + "PV1|||CFLC|||||||MED||||||||P||||||||||||||||||||||||||19950303150000|19950311\r\n" + "OBR|1||09528307086003110|6003110^CULTURE BACTERIA UR INDWELL CA^^^C UR ICATH|||19951010131900|||||||19951010131900|S03593&URINE-INDWELLING CATHETER     &&&URI|||||0952830708||1995101013360000||600|P||^^^^^RT||^09528307086003110\r\n" + "OBX||CE|6000417^PRELIMINARY^^^R PRE|0002|I80013^^^^GE100,~I80013^^^^GE100,~I80013^^^^GE100,||||||F|||19951010133600||001\r\n";
            Message m = p.parse(msg);

            NuGenDefaultXMLParser xp = new NuGenDefaultXMLParser();
            System.Console.Out.WriteLine(xp.encode(m));

            TestNetworkOperations();
        }

        static void TestNetworkOperations()
        {
            NuGenLowerLayerProtocol llp = NuGenLowerLayerProtocol.makeLLP();
            NuGenPipeParser parser = new NuGenPipeParser();
            NuGenSimpleServer server = new NuGenSimpleServer(1011, llp, parser);

            NuGenApplication handler = new ExampleReceiverApplication();
            server.registerApplication("ADT", "A01", handler);
            server.registerApplication("ADT", "A02", handler);

            server.start();

            String msg = "MSH|^~\\&|HIS|RIH|EKG|EKG|199904140038||ADT^A01|12345|P|2.2\r"
                 //+ "EVN|A01|198808181123||\r"
                 + "PID|0001|00009874|00001122|A00977|SMITH^JOHN^M|MOM|19581119|F|NOTREAL^LINDA^M|C|564 SPRING ST^^NEEDHAM^MA^02494^US|0002|(818)565-1551|(425)828-3344|E|S|C|0000444444|252-00-4414||||SA|||SA||||NONE|V1|0001|I|D.ER^50A^M110^01|ER|P00055|11B^M011^02|070615^BATMAN^GEORGE^L|555888^NOTREAL^BOB^K^DR^MD|777889^NOTREAL^SAM^T^DR^MD^PHD|ER|D.WT^1A^M010^01|||ER|AMB|02|070615^NOTREAL^BILL^L|ER|000001916994|D||||||||||||||||GDD|WA|NORM|02|O|02|E.IN^02D^M090^01|E.IN^01D^M080^01|199904072124|199904101200|199904101200||||5555112333|||666097^NOTREAL^MANNY^P\r"
                 + "NK1|0222555|NOTREAL^JAMES^R|FA|STREET^OTHER STREET^CITY^ST^55566|(222)111-3333|(888)999-0000|||||||ORGANIZATION\r"
                 + "PV1|0001|I|D.ER^1F^M950^01|ER|P000998|11B^M011^02|070615^BATMAN^GEORGE^L|555888^OKNEL^BOB^K^DR^MD|777889^NOTREAL^SAM^T^DR^MD^PHD|ER|D.WT^1A^M010^01|||ER|AMB|02|070615^VOICE^BILL^L|ER|000001916994|D||||||||||||||||GDD|WA|NORM|02|O|02|E.IN^02D^M090^01|E.IN^01D^M080^01|199904072124|199904101200|||||5555112333|||666097^DNOTREAL^MANNY^P\r"
                 + "PV2|||0112^TESTING|55555^PATIENT IS NORMAL|NONE|||19990225|19990226|1|1|TESTING|555888^NOTREAL^BOB^K^DR^MD||||||||||PROD^003^099|02|ER||NONE|19990225|19990223|19990316|NONE\r"
                 + "AL1||SEV|001^POLLEN\r"
                 + "GT1||0222PL|NOTREAL^BOB^B||STREET^OTHER STREET^CITY^ST^77787|(444)999-3333|(222)777-5555||||MO|111-33-5555||||NOTREAL GILL N|STREET^OTHER STREET^CITY^ST^99999|(111)222-3333\r"
                 + "IN1||022254P|4558PD|BLUE CROSS|STREET^OTHER STREET^CITY^ST^00990||(333)333-6666||221K|LENIX|||19980515|19990515|||PATIENT01 TEST D||||||||||||||||||02LL|022LP554";
         
            NuGenParser p = new NuGenGenericParser();
            Message adt = p.parse(msg);

            NuGenConnectionHub hub = NuGenConnectionHub.Instance;

            NuGenConnection connection = hub.attach(System.Net.Dns.GetHostName(), 1011, new NuGenPipeParser(), new NuGenMinLowerLayerProtocol().GetType());

            NuGenInitiator init = connection.Initiator;

            Message response = init.sendAndReceive(adt);

            string responseStr = parser.encode(response);

            System.Console.WriteLine("Receieved response : " + responseStr);

            connection.close();

            server.stop();
        }

        private class ExampleReceiverApplication : NuGenApplication
        {
            public bool canProcess(Message msg)
            {
                return true;
            }

            public Message processMessage(Message msg)
            {
                string encodedMessage = new NuGenPipeParser().encode(msg);

                MSH msh = (MSH)msg.get_Renamed("MSH");

                return NuGenDefaultApplication.makeACK(msh);
            }
        }
    }
}
