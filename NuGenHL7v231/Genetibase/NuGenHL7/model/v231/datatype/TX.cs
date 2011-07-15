using System;
using Primitive = Genetibase.NuGenHL7.model.Primitive;
using DataTypeException = Genetibase.NuGenHL7.model.DataTypeException;
using Message = Genetibase.NuGenHL7.model.Message;
using Type = Genetibase.NuGenHL7.model.Type;
using AbstractPrimitive = Genetibase.NuGenHL7.model.AbstractPrimitive;
namespace Genetibase.NuGenHL7.model.v231.datatype
{
	
	/// <summary> <p>Represents the HL7 TX (text data) datatype.  A TX contains a single String value.</summary>
	[Serializable]
	public class TX:AbstractPrimitive
	{
		/// <returns> "2.3.1"
		/// </returns>
		virtual public System.String Version
		{
			get
			{
				return "2.3.1";
			}
			
		}
		
		/// <summary> Constructs an uninitialized TX.</summary>
		/// <param name="message">the Message to which this Type belongs
		/// </param>
		public TX(Message message):base(message)
		{
		}
	}
}