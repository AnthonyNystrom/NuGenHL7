using System;

namespace Genetibase.NuGenHL7.util
{
	
	/// <summary> Used to access the hapi.home system property.  Note that the property 
	/// is only checked (at most) once per session.  
	/// </summary>
	/// <author>  Bryan Tripp
	/// </author>
	public class NuGenHome
	{
		
		private static System.IO.FileInfo home;

		/// <summary>Creates a new instance of Home </summary>
		public NuGenHome()
		{
		}
		
		/// <summary> Returns a File object corresponding to the directory specified in 
		/// the system property hapi.home.  The property is only checked the 
		/// first time this method is called, so changes will not take place 
		/// until a new VM is started.  
		/// This method is guaranteed to return a directory.  If hapi.home is 
		/// not set, or is set to a non-directory path, the current directory will 
		/// be used.  
		/// </summary>
		public static System.IO.FileInfo getHomeDirectory()
		{
			if (home == null)
				setHomeDirectory();
			
			return home;
		}
		
		private static void  setHomeDirectory()
		{
			lock (typeof(Genetibase.NuGenHL7.util.NuGenHome))
			{
				home = new System.IO.FileInfo(".");
			}
		}

		static NuGenHome()
		{
		}
	}
}