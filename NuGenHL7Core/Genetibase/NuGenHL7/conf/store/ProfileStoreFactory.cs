using System;
using Home = Genetibase.NuGenHL7.util.NuGenHome;
namespace Genetibase.NuGenHL7.conf.store
{
	
	/// <summary> Provides access to a (configurable) ProfileStore.  </summary>
	/// <author>  Bryan Tripp
	/// </author>
	public class ProfileStoreFactory
	{
		/// <summary> Returns a single configurable instance of a ProfileStore.   
		/// Configurable by calling setStore().  Defaults to FileProfileStore
		/// using the current <hapi.home>/profiles as a base directory
		/// Note: not a singleton (by design) in that nothing prevents creation 
		/// of profile stores by other means.  
		/// </summary>
		public static ProfileStore ProfileStore
		{
			get
			{
				lock (typeof(Genetibase.NuGenHL7.conf.store.ProfileStoreFactory))
				{
					if (instance == null)
						instance = new FileProfileStore(Home.getHomeDirectory().FullName + "/profiles");
					
					return instance;
				}
			}
			
		}
		/// <summary> Sets the profile store that will be returned in subsequent calls 
		/// to getProfileStore(). 
		/// </summary>
		public static ProfileStore Store
		{
			set
			{
				lock (typeof(Genetibase.NuGenHL7.conf.store.ProfileStoreFactory))
				{
					instance = value;
				}
			}
			
		}
		
		private static ProfileStore instance;
		private static System.Collections.ArrayList codeStores = new System.Collections.ArrayList();
		
		/// <summary> Returns the first code store that knows the codes in the given code 
		/// system (as per CodeStore.knowsCodes) and is registered for the given profile.  
		/// Code stores are checked in the order in which they are added (with addCodeStore()).  
		/// </summary>
		/// <returns> null if none are found 
		/// </returns>
		public static CodeStore getCodeStore(System.String profileID, System.String codeSystem)
		{
			CodeStore store = null;
			return store;
		}
	}
}