using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v25.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v25.segment
{
	
	/// <summary> <p>Represents an HL7 CTD message segment. 
	/// This segment has the following fields:</p><p>
	/// CTD-1: Contact Role (CE)<br> 
	/// CTD-2: Contact Name (XPN)<br> 
	/// CTD-3: Contact Address (XAD)<br> 
	/// CTD-4: Contact Location (PL)<br> 
	/// CTD-5: Contact Communication Information (XTN)<br> 
	/// CTD-6: Preferred Method of Contact (CE)<br> 
	/// CTD-7: Contact Identifiers (PLN)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class CTD:AbstractSegment
	{
		/// <summary> Returns Contact Location (CTD-4).</summary>
		virtual public PL ContactLocation
		{
			get
			{
				PL ret = null;
				try
				{
					Type t = this.getField(4, 0);
					ret = (PL) t;
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
		/// <summary> Returns Preferred Method of Contact (CTD-6).</summary>
		virtual public CE PreferredMethodOfContact
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(6, 0);
					ret = (CE) t;
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
		
		/// <summary> Creates a CTD (Contact Data) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public CTD(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(CE), true, 0, 250, new System.Object[]{message});
				this.add(typeof(XPN), false, 0, 250, new System.Object[]{message});
				this.add(typeof(XAD), false, 0, 250, new System.Object[]{message});
				this.add(typeof(PL), false, 1, 60, new System.Object[]{message});
				this.add(typeof(XTN), false, 0, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(PLN), false, 0, 100, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Contact Role (CTD-1).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getContactRole(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(1, rep);
				ret = (CE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Contact Role (CTD-1).</summary>
		public virtual CE[] getContactRole()
		{
			CE[] ret = null;
			try
			{
				Type[] t = this.getField(1);
				ret = new CE[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (CE) t[i];
				}
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
		
		/// <summary> Returns a single repetition of Contact Name (CTD-2).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XPN getContactName(int rep)
		{
			XPN ret = null;
			try
			{
				Type t = this.getField(2, rep);
				ret = (XPN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Contact Name (CTD-2).</summary>
		public virtual XPN[] getContactName()
		{
			XPN[] ret = null;
			try
			{
				Type[] t = this.getField(2);
				ret = new XPN[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (XPN) t[i];
				}
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
		
		/// <summary> Returns a single repetition of Contact Address (CTD-3).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XAD getContactAddress(int rep)
		{
			XAD ret = null;
			try
			{
				Type t = this.getField(3, rep);
				ret = (XAD) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Contact Address (CTD-3).</summary>
		public virtual XAD[] getContactAddress()
		{
			XAD[] ret = null;
			try
			{
				Type[] t = this.getField(3);
				ret = new XAD[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (XAD) t[i];
				}
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
		
		/// <summary> Returns a single repetition of Contact Communication Information (CTD-5).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XTN getContactCommunicationInformation(int rep)
		{
			XTN ret = null;
			try
			{
				Type t = this.getField(5, rep);
				ret = (XTN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Contact Communication Information (CTD-5).</summary>
		public virtual XTN[] getContactCommunicationInformation()
		{
			XTN[] ret = null;
			try
			{
				Type[] t = this.getField(5);
				ret = new XTN[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (XTN) t[i];
				}
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
		
		/// <summary> Returns a single repetition of Contact Identifiers (CTD-7).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual PLN getContactIdentifiers(int rep)
		{
			PLN ret = null;
			try
			{
				Type t = this.getField(7, rep);
				ret = (PLN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Contact Identifiers (CTD-7).</summary>
		public virtual PLN[] getContactIdentifiers()
		{
			PLN[] ret = null;
			try
			{
				Type[] t = this.getField(7);
				ret = new PLN[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (PLN) t[i];
				}
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
}