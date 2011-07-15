using System;
using ProfileException = Genetibase.NuGenHL7.conf.NuGenProfileException;

namespace Genetibase.NuGenHL7.conf.store
{
	
	/// <summary> Stores profiles in a local directory.  Profiles are stored as text
	/// in files named ID.xml (where ID is the profile ID).
	/// </summary>
	/// <author>  Bryan Tripp
	/// </author>
	public class FileProfileStore : ProfileStore
	{
		
		private System.IO.FileInfo root;
		
		/// <summary>Creates a new instance of FileProfileStore </summary>
		public FileProfileStore(System.String file)
		{
			root = new System.IO.FileInfo(file);
			if (!System.IO.Directory.Exists(root.FullName))
			{
				if (!System.IO.Directory.CreateDirectory(root.FullName).Exists)
					throw new System.ArgumentException(file + " is not a directory");
			}
		}
		
		/// <summary> Retrieves profile from persistent storage (by ID).  Returns null
		/// if the profile isn't found.
		/// </summary>
		public virtual System.String getProfile(System.String ID)
		{
			System.String profile = null;
			
			System.IO.FileInfo source = new System.IO.FileInfo(getFileName(ID));
			if (System.IO.File.Exists(source.FullName))
			{
				System.IO.StreamReader in_Renamed = new System.IO.StreamReader(new System.IO.StreamReader(source.FullName, System.Text.Encoding.Default).BaseStream, new System.IO.StreamReader(source.FullName, System.Text.Encoding.Default).CurrentEncoding);
				char[] buf = new char[(int) SupportClass.FileLength(source)];
				int check = in_Renamed.Read(buf, 0, buf.Length);
				in_Renamed.Close();
				if (check != buf.Length)
					throw new System.IO.IOException("Only read " + check + " of " + buf.Length + " bytes of file " + source.FullName);
				profile = new System.String(buf);
			}
			return profile;
		}
		
		/// <summary> Stores profile in persistent storage with given ID.</summary>
		public virtual void  persistProfile(System.String ID, System.String profile)
		{
			System.IO.FileInfo dest = new System.IO.FileInfo(getFileName(ID));
			System.IO.StreamWriter out_Renamed = new System.IO.StreamWriter(new System.IO.StreamWriter(dest.FullName, false, System.Text.Encoding.Default).BaseStream, new System.IO.StreamWriter(dest.FullName, false, System.Text.Encoding.Default).Encoding);
			out_Renamed.Write(profile);
			out_Renamed.Flush();
			out_Renamed.Close();
		}
		
		private System.String getFileName(System.String ID)
		{
			return root.FullName + "/" + ID + ".xml";
		}
		static FileProfileStore()
		{
		}
	}
}