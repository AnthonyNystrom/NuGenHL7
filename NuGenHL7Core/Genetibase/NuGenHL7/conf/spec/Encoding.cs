using System;
namespace Genetibase.NuGenHL7.conf.spec
{
	
	/// <summary> A class that indicated an HL7 encoding acceptable within a 
	/// specification. 
	/// </summary>
	/// <author>  Bryan Tripp
	/// </author>
	public class Encoding
	{
		
		/// <summary>Creates a new instance of Encoding </summary>
		public Encoding()
		{
		}
		
		public class ER7:Encoding
		{
		}
		public class XML:Encoding
		{
		}
	}
}