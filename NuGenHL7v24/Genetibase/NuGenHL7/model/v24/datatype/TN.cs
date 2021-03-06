using System;
using Primitive = Genetibase.NuGenHL7.model.Primitive;
using DataTypeException = Genetibase.NuGenHL7.model.DataTypeException;
using Message = Genetibase.NuGenHL7.model.Message;
using Type = Genetibase.NuGenHL7.model.Type;
using AbstractPrimitive = Genetibase.NuGenHL7.model.AbstractPrimitive;
namespace Genetibase.NuGenHL7.model.v24.datatype
{
	
	/// <summary> <p>Represents the HL7 TN (telephone number) datatype.  A TN contains a single String value.</summary>
	[Serializable]
	public class TN:AbstractPrimitive
	{
		/// <returns> "2.4"
		/// </returns>
		virtual public System.String Version
		{
			get
			{
				return "2.4";
			}
			
		}
		
		/// <summary> Constructs an uninitialized TN.</summary>
		/// <param name="message">the Message to which this Type belongs
		/// </param>
		public TN(Message message):base(message)
		{
		}
	}
}