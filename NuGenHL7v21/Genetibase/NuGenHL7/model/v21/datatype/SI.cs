using System;
using Primitive = Genetibase.NuGenHL7.model.Primitive;
using DataTypeException = Genetibase.NuGenHL7.model.DataTypeException;
using Message = Genetibase.NuGenHL7.model.Message;
using Type = Genetibase.NuGenHL7.model.Type;
using AbstractPrimitive = Genetibase.NuGenHL7.model.AbstractPrimitive;
namespace Genetibase.NuGenHL7.model.v21.datatype
{
	
	/// <summary> <p>Represents the HL7 SI (SET ID) datatype.  A SI contains a single String value.</summary>
	[Serializable]
	public class SI:AbstractPrimitive
	{
		/// <returns> "2.1"
		/// </returns>
		virtual public System.String Version
		{
			get
			{
				return "2.1";
			}
			
		}
		
		/// <summary> Constructs an uninitialized SI.</summary>
		/// <param name="message">the Message to which this Type belongs
		/// </param>
		public SI(Message message):base(message)
		{
		}
	}
}