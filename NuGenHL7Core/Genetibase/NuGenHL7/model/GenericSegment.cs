using System;
namespace Genetibase.NuGenHL7.model
{
	
	/// <summary> An unspecified segment that has an undefined number of fields, each 
	/// of which is a Varies.  The primary intended use is to store data from 
	/// Z segments.  More precisely, any unknown segment that is encountered during
	/// parsing will be handled with this class.  This includes segments that do 
	/// not start with Z but nevertheless do not appear in the stated version 
	/// of HL7.  Also, this class is not used to handle Z segments that have been 
	/// explicitly defined and declared (see Parser.packageList() ).  
	/// </summary>
	/// <author>  Bryan Tripp
	/// </author>
	[Serializable]
	public class GenericSegment:AbstractSegment
	{
		
		private System.String name;
		
		/// <summary>Creates a new instance of GenericSegment </summary>
		public GenericSegment(Group parent, System.String name):base(parent, null)
		{
			this.name = name;
		}
		
		/// <summary> Returns the name specified at construction time. </summary>
		/// <seealso cref="Structure.getName()">
		/// </seealso>
		public override System.String getName()
		{
			return this.name;
		}
	}
}