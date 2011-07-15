using System;
namespace Genetibase.NuGenHL7.conf.store
{
	
	/// <summary> A repository for conformance profile documents.  </summary>
	/// <author>  Bryan Tripp
	/// </author>
	public interface ProfileStore
	{
		
		/// <summary> Retrieves profile from persistent storage (by ID). </summary>
		System.String getProfile(System.String ID);
		
		/// <summary> Stores profile in persistent storage with given ID. </summary>
		void  persistProfile(System.String ID, System.String profile);
	}
}