using System;
namespace Genetibase.NuGenHL7.model
{
	
	/// <summary> An unspecified Primitive datatype that imposes no constraints on its string 
	/// value.  This is used to store Varies data, when the data type is unknown.  It is also 
	/// used to store unrecognized message constituents.  
	/// </summary>
	/// <author>  Bryan Tripp
	/// </author>
	[Serializable]
	public class GenericPrimitive:AbstractPrimitive, Primitive
	{
		/// <summary> Returns a String representation of the value of this field.</summary>
		/// <summary> Sets the value of this field if the given value is legal in the context of the
		/// implementing class.
		/// </summary>
		/// <throws>  DataTypeException if the given value is not valid in this context. </throws>
		override public System.String Value
		{
			get
			{
				return this.value_Renamed;
			}
			
			set
			{
				this.value_Renamed = value;
			}
			
		}
		/// <summary>Returns the name of the type (used in XML encoding and profile checking)  </summary>
		override public System.String Name
		{
			get
			{
				return "UNKNOWN";
			}
			
		}
		/// <seealso cref="Genetibase.NuGenHL7.model.Primitive.getVersion()">
		/// </seealso>
		virtual public System.String Version
		{
			get
			{
				return null;
			}
			
		}
		
		internal System.String value_Renamed = null;
		
		/// <summary> Creates a new instance of GenericPrimitive </summary>
		public GenericPrimitive(Message message):base(message)
		{
		}
	}
}