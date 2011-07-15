using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v25.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v25.segment
{
	
	/// <summary> <p>Represents an HL7 FAC message segment. 
	/// This segment has the following fields:</p><p>
	/// FAC-1: Facility ID-FAC (EI)<br> 
	/// FAC-2: Facility Type (ID)<br> 
	/// FAC-3: Facility Address (XAD)<br> 
	/// FAC-4: Facility Telecommunication (XTN)<br> 
	/// FAC-5: Contact Person (XCN)<br> 
	/// FAC-6: Contact Title (ST)<br> 
	/// FAC-7: Contact Address (XAD)<br> 
	/// FAC-8: Contact Telecommunication (XTN)<br> 
	/// FAC-9: Signature Authority (XCN)<br> 
	/// FAC-10: Signature Authority Title (ST)<br> 
	/// FAC-11: Signature Authority Address (XAD)<br> 
	/// FAC-12: Signature Authority Telecommunication (XTN)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class FAC:AbstractSegment
	{
		/// <summary> Returns Facility ID-FAC (FAC-1).</summary>
		virtual public EI FacilityIDFAC
		{
			get
			{
				EI ret = null;
				try
				{
					Type t = this.getField(1, 0);
					ret = (EI) t;
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
		/// <summary> Returns Facility Type (FAC-2).</summary>
		virtual public ID FacilityType
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(2, 0);
					ret = (ID) t;
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
		/// <summary> Returns Facility Telecommunication (FAC-4).</summary>
		virtual public XTN FacilityTelecommunication
		{
			get
			{
				XTN ret = null;
				try
				{
					Type t = this.getField(4, 0);
					ret = (XTN) t;
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
		/// <summary> Returns Signature Authority Title (FAC-10).</summary>
		virtual public ST SignatureAuthorityTitle
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(10, 0);
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
		/// <summary> Returns Signature Authority Telecommunication (FAC-12).</summary>
		virtual public XTN SignatureAuthorityTelecommunication
		{
			get
			{
				XTN ret = null;
				try
				{
					Type t = this.getField(12, 0);
					ret = (XTN) t;
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
		
		/// <summary> Creates a FAC (Facility) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public FAC(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(EI), true, 1, 20, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 331});
				this.add(typeof(XAD), true, 0, 250, new System.Object[]{message});
				this.add(typeof(XTN), true, 1, 250, new System.Object[]{message});
				this.add(typeof(XCN), false, 0, 250, new System.Object[]{message});
				this.add(typeof(ST), false, 0, 60, new System.Object[]{message});
				this.add(typeof(XAD), false, 0, 250, new System.Object[]{message});
				this.add(typeof(XTN), false, 0, 250, new System.Object[]{message});
				this.add(typeof(XCN), true, 0, 250, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 60, new System.Object[]{message});
				this.add(typeof(XAD), false, 0, 250, new System.Object[]{message});
				this.add(typeof(XTN), false, 1, 250, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Facility Address (FAC-3).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XAD getFacilityAddress(int rep)
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
		
		/// <summary> Returns all repetitions of Facility Address (FAC-3).</summary>
		public virtual XAD[] getFacilityAddress()
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
		
		/// <summary> Returns a single repetition of Contact Person (FAC-5).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XCN getContactPerson(int rep)
		{
			XCN ret = null;
			try
			{
				Type t = this.getField(5, rep);
				ret = (XCN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Contact Person (FAC-5).</summary>
		public virtual XCN[] getContactPerson()
		{
			XCN[] ret = null;
			try
			{
				Type[] t = this.getField(5);
				ret = new XCN[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (XCN) t[i];
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
		
		/// <summary> Returns a single repetition of Contact Title (FAC-6).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ST getContactTitle(int rep)
		{
			ST ret = null;
			try
			{
				Type t = this.getField(6, rep);
				ret = (ST) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Contact Title (FAC-6).</summary>
		public virtual ST[] getContactTitle()
		{
			ST[] ret = null;
			try
			{
				Type[] t = this.getField(6);
				ret = new ST[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (ST) t[i];
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
		
		/// <summary> Returns a single repetition of Contact Address (FAC-7).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XAD getContactAddress(int rep)
		{
			XAD ret = null;
			try
			{
				Type t = this.getField(7, rep);
				ret = (XAD) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Contact Address (FAC-7).</summary>
		public virtual XAD[] getContactAddress()
		{
			XAD[] ret = null;
			try
			{
				Type[] t = this.getField(7);
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
		
		/// <summary> Returns a single repetition of Contact Telecommunication (FAC-8).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XTN getContactTelecommunication(int rep)
		{
			XTN ret = null;
			try
			{
				Type t = this.getField(8, rep);
				ret = (XTN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Contact Telecommunication (FAC-8).</summary>
		public virtual XTN[] getContactTelecommunication()
		{
			XTN[] ret = null;
			try
			{
				Type[] t = this.getField(8);
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
		
		/// <summary> Returns a single repetition of Signature Authority (FAC-9).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XCN getSignatureAuthority(int rep)
		{
			XCN ret = null;
			try
			{
				Type t = this.getField(9, rep);
				ret = (XCN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Signature Authority (FAC-9).</summary>
		public virtual XCN[] getSignatureAuthority()
		{
			XCN[] ret = null;
			try
			{
				Type[] t = this.getField(9);
				ret = new XCN[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (XCN) t[i];
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
		
		/// <summary> Returns a single repetition of Signature Authority Address (FAC-11).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XAD getSignatureAuthorityAddress(int rep)
		{
			XAD ret = null;
			try
			{
				Type t = this.getField(11, rep);
				ret = (XAD) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Signature Authority Address (FAC-11).</summary>
		public virtual XAD[] getSignatureAuthorityAddress()
		{
			XAD[] ret = null;
			try
			{
				Type[] t = this.getField(11);
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
	}
}