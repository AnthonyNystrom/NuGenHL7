using System;
using Genetibase.NuGenHL7.model.v231.group;
using Genetibase.NuGenHL7.model.v231.segment;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using DefaultModelClassFactory = Genetibase.NuGenHL7.parser.NuGenDefaultModelClassFactory;
using AbstractMessage = Genetibase.NuGenHL7.model.AbstractMessage;
namespace Genetibase.NuGenHL7.model.v231.message
{
	
	/// <summary> <p>Represents a ADT_A41 message structure (see chapter ?). This structure contains the 
	/// following elements: </p>
	/// 0: MSH (MSH - message header segment) <b></b><br>
	/// 1: EVN (EVN - event type segment) <b></b><br>
	/// 2: ADT_A41_PIDPD1MRGPV1 (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class ADT_A41:AbstractMessage
	{
		/// <summary> Returns MSH (MSH - message header segment) - creates it if necessary</summary>
		virtual public MSH MSH
		{
			get
			{
				MSH ret = null;
				try
				{
					ret = (MSH) this.get_Renamed("MSH");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns EVN (EVN - event type segment) - creates it if necessary</summary>
		virtual public EVN EVN
		{
			get
			{
				EVN ret = null;
				try
				{
					ret = (EVN) this.get_Renamed("EVN");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of ADT_A41_PIDPD1MRGPV1 </summary>
		virtual public int PIDPD1MRGPV1Reps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("PIDPD1MRGPV1").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new ADT_A41 Group with custom ModelClassFactory.</summary>
		public ADT_A41(ModelClassFactory factory):base(factory)
		{
			init(factory);
		}
		
		/// <summary> Creates a new ADT_A41 Group with DefaultModelClassFactory. </summary>
		public ADT_A41():base(new DefaultModelClassFactory())
		{
			init(new DefaultModelClassFactory());
		}
		
		private void  init(ModelClassFactory factory)
		{
			try
			{
				this.add(typeof(MSH), true, false);
				this.add(typeof(EVN), true, false);
				this.add(typeof(ADT_A41_PIDPD1MRGPV1), true, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of ADT_A41_PIDPD1MRGPV1 (a Group object) - creates it if necessary</summary>
		public virtual ADT_A41_PIDPD1MRGPV1 getPIDPD1MRGPV1()
		{
			ADT_A41_PIDPD1MRGPV1 ret = null;
			try
			{
				ret = (ADT_A41_PIDPD1MRGPV1) this.get_Renamed("PIDPD1MRGPV1");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of ADT_A41_PIDPD1MRGPV1
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual ADT_A41_PIDPD1MRGPV1 getPIDPD1MRGPV1(int rep)
		{
			return (ADT_A41_PIDPD1MRGPV1) this.get_Renamed("PIDPD1MRGPV1", rep);
		}
	}
}