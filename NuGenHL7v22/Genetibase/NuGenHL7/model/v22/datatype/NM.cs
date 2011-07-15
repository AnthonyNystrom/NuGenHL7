using System;
using Primitive = Genetibase.NuGenHL7.model.Primitive;
using DataTypeException = Genetibase.NuGenHL7.model.DataTypeException;
using Message = Genetibase.NuGenHL7.model.Message;
using Type = Genetibase.NuGenHL7.model.Type;
using AbstractPrimitive = Genetibase.NuGenHL7.model.AbstractPrimitive;
namespace Genetibase.NuGenHL7.model.v22.datatype
{
	
	/// <summary> <p>Represents the HL7 NM (numeric) datatype.  A NM contains a single String value.</summary>
	[Serializable]
	public class NM:AbstractPrimitive
	{
		/// <returns> "2.2"
		/// </returns>
		virtual public System.String Version
		{
			get
			{
				return "2.2";
			}
			
		}
		
		/// <summary> Constructs an uninitialized NM.</summary>
		/// <param name="message">the Message to which this Type belongs
		/// </param>
		public NM(Message message):base(message)
		{
		}
	}
}