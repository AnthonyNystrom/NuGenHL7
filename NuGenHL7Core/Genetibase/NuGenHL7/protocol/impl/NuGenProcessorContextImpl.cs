/*
* Created on 19-Apr-2004
*/
using System;
using AcceptValidator = Genetibase.NuGenHL7.protocol.NuGenAcceptValidator;
using ApplicationRouter = Genetibase.NuGenHL7.protocol.NuGenApplicationRouter;
using ProcessorContext = Genetibase.NuGenHL7.protocol.NuGenProcessorContext;
using SafeStorage = Genetibase.NuGenHL7.protocol.NuGenSafeStorage;
using TransportLayer = Genetibase.NuGenHL7.protocol.NuGenTransportLayer;
namespace Genetibase.NuGenHL7.protocol.impl
{
	
	/// <summary> Default implementation of <code>ProcessorContext</code>. 
	/// 
	/// </summary>
	/// <author>  <a href="mailto:bryan.tripp@uhn.on.ca">Bryan Tripp</a>
	/// </author>
	/// <version>  $Revision: 1.2 $ updated on $Date: 2004/05/17 19:37:27 $ by $Author: bryan_tripp $
	/// </version>
	public class NuGenProcessorContextImpl : NuGenProcessorContext
	{
		/// <seealso cref="Genetibase.NuGenHL7.protocol.ProcessorContext.getRouter()">
		/// </seealso>
		virtual public NuGenApplicationRouter Router
		{
			get
			{
				return myRouter;
			}
			
		}
		/// <seealso cref="Genetibase.NuGenHL7.protocol.ProcessorContext.getRemotelyDrivenTransportLayer()">
		/// </seealso>
		virtual public NuGenTransportLayer RemotelyDrivenTransportLayer
		{
			get
			{
				return myRemotelyDrivenTransport;
			}
			
		}
		/// <seealso cref="Genetibase.NuGenHL7.protocol.ProcessorContext.getLocallyDrivenTransportLayer()">
		/// </seealso>
		virtual public NuGenTransportLayer LocallyDrivenTransportLayer
		{
			get
			{
				return myLocallyDrivenTransport;
			}
			
		}
		/// <seealso cref="Genetibase.NuGenHL7.protocol.ProcessorContext.getValidators()">
		/// </seealso>
		virtual public NuGenAcceptValidator[] Validators
		{
			get
			{
                NuGenAcceptValidator[] retVal = new NuGenAcceptValidator[myValidators.Count];
                myValidators.CopyTo(retVal, 0);

                return retVal;
			}
			
		}
		/// <seealso cref="Genetibase.NuGenHL7.protocol.ProcessorContext.getSafeStorage()">
		/// </seealso>
		virtual public NuGenSafeStorage SafeStorage
		{
			get
			{
				return mySafeStorage;
			}
			
		}
		/// <seealso cref="Genetibase.NuGenHL7.protocol.ProcessorContext.getMetadataFields()">
		/// </seealso>
		virtual public System.Collections.IList MetadataFields
		{
			get
			{
				return myMetadataFields;
			}
			
		}
		
		private NuGenApplicationRouter myRouter;
		private NuGenTransportLayer myLocallyDrivenTransport;
		private NuGenTransportLayer myRemotelyDrivenTransport;
		private NuGenSafeStorage mySafeStorage;
		private System.Collections.IList myValidators;
		private System.Collections.IList myMetadataFields;
		
		/// <summary> Creates a new instance that uses the given resources.  
		/// 
		/// </summary>
		/// <param name="theRouter">
		/// </param>
		/// <param name="theTransport">a <code>TransportLayer</code> used for both locally-initiated
		/// and remotely-initiated message exchanges 
		/// </param>
		/// <param name="theStorage">
		/// </param>
		public NuGenProcessorContextImpl(NuGenApplicationRouter theRouter, NuGenTransportLayer theTransport, NuGenSafeStorage theStorage)
		{
			
			myRouter = theRouter;
			myRemotelyDrivenTransport = theTransport;
			myLocallyDrivenTransport = theTransport;
			mySafeStorage = theStorage;
			
			myValidators = new System.Collections.ArrayList(8);
			myMetadataFields = new System.Collections.ArrayList(30);
		}
		
		/// <summary> Creates a new instance that uses the given resources.  
		/// 
		/// </summary>
		/// <param name="theRouter">
		/// </param>
		/// <param name="theLocallyDrivenTransport">a <code>TransportLayer</code> used for locally-initiated
		/// and message exchanges 
		/// </param>
		/// <param name="theRemotelyDrivenTransport">a <code>TransportLayer</code> used for remotely-initiated
		/// and message exchanges 
		/// </param>
		/// <param name="theStorage">
		/// </param>
		public NuGenProcessorContextImpl(NuGenApplicationRouter theRouter, NuGenTransportLayer theLocallyDrivenTransport, NuGenTransportLayer theRemotelyDrivenTransport, NuGenSafeStorage theStorage)
		{
			
			myRouter = theRouter;
			myRemotelyDrivenTransport = theRemotelyDrivenTransport;
			myLocallyDrivenTransport = theLocallyDrivenTransport;
			mySafeStorage = theStorage;
			
			myValidators = new System.Collections.ArrayList(8);
			myMetadataFields = new System.Collections.ArrayList(30);
		}
		
		/// <summary> Adds a new validator to the list of those returned by 
		/// <code>getValidators()</code>.  
		/// 
		/// </summary>
		/// <param name="theValidator">the validator to add 
		/// </param>
		public virtual void  addValidator(NuGenAcceptValidator theValidator)
		{
			myValidators.Add(theValidator);
		}
	}
}