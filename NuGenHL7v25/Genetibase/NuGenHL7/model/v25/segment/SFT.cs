using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v25.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v25.segment
{
	
	/// <summary> <p>Represents an HL7 SFT message segment. 
	/// This segment has the following fields:</p><p>
	/// SFT-1: Software Vendor Organization (XON)<br> 
	/// SFT-2: Software Certified Version or Release Number (ST)<br> 
	/// SFT-3: Software Product Name (ST)<br> 
	/// SFT-4: Software Binary ID (ST)<br> 
	/// SFT-5: Software Product Information (TX)<br> 
	/// SFT-6: Software Install Date (TS)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class SFT:AbstractSegment
	{
		/// <summary> Returns Software Vendor Organization (SFT-1).</summary>
		virtual public XON SoftwareVendorOrganization
		{
			get
			{
				XON ret = null;
				try
				{
					Type t = this.getField(1, 0);
					ret = (XON) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Software Certified Version or Release Number (SFT-2).</summary>
		virtual public ST SoftwareCertifiedVersionOrReleaseNumber
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(2, 0);
					ret = (ST) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Software Product Name (SFT-3).</summary>
		virtual public ST SoftwareProductName
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(3, 0);
					ret = (ST) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Software Binary ID (SFT-4).</summary>
		virtual public ST SoftwareBinaryID
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(4, 0);
					ret = (ST) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Software Product Information (SFT-5).</summary>
		virtual public TX SoftwareProductInformation
		{
			get
			{
				TX ret = null;
				try
				{
					Type t = this.getField(5, 0);
					ret = (TX) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Software Install Date (SFT-6).</summary>
		virtual public TS SoftwareInstallDate
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(6, 0);
					ret = (TS) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		/// <summary> Creates a SFT (Software Segment) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public SFT(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(XON), true, 1, 567, new System.Object[]{message});
				this.add(typeof(ST), true, 1, 15, new System.Object[]{message});
				this.add(typeof(ST), true, 1, 20, new System.Object[]{message});
				this.add(typeof(ST), true, 1, 20, new System.Object[]{message});
				this.add(typeof(TX), false, 1, 1024, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}