using System;
namespace Genetibase.NuGenHL7.model
{
	
	/// <summary> An unspecified Composite datatype that has an undefined number of components, each 
	/// of which is a Varies.  
	/// This is used to store Varies data, when the data type is unknown.  It is also 
	/// used to store unrecognized message constituents.  
	/// </summary>
	/// <author>  Bryan Tripp
	/// </author>
	[Serializable]
	public class GenericComposite:AbstractType, Composite
	{
		/// <summary> Returns an array containing the components of this field.</summary>
		virtual public Type[] Components
		{
			get
			{
				Type[] ret = new Type[components.Count];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (Type) components[i];
				}
				return ret;
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
		
		private System.Collections.ArrayList components;
		private Message message;
		
		/// <summary>Creates a new instance of GenericComposite </summary>
		public GenericComposite(Message message):base(message)
		{
			this.message = message;
			components = new System.Collections.ArrayList(20);
		}
		
		/// <summary> Returns the single component of this composite at the specified position (starting at 0) - 
		/// Creates it (and any nonexistent components before it) if necessary.  
		/// </summary>
		public virtual Type getComponent(int number)
		{
			for (int i = components.Count; i <= number; i++)
			{
				components.Add(new Varies(message));
			}
			return (Type) components[number];
		}
	}
}