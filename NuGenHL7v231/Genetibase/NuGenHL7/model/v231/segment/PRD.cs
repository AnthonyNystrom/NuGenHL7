using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v231.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v231.segment
{
	
	/// <summary> <p>Represents an HL7 PRD message segment. 
	/// This segment has the following fields:</p><p>
	/// PRD-1: Provider Role (CE)<br> 
	/// PRD-2: Provider Name (XPN)<br> 
	/// PRD-3: Provider Address (XAD)<br> 
	/// PRD-4: Provider Location (PL)<br> 
	/// PRD-5: Provider Communication Information (XTN)<br> 
	/// PRD-6: Preferred Method Of Contact (CE)<br> 
	/// PRD-7: Provider Identifiers (PI)<br> 
	/// PRD-8: Effective Start Date of Provider Role (TS)<br> 
	/// PRD-9: Effective End Date of Provider Role (TS)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class PRD:AbstractSegment
	{
		/// <summary> Returns Provider Location (PRD-4).</summary>
		virtual public PL ProviderLocation
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
		/// <summary> Returns Preferred Method Of Contact (PRD-6).</summary>
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
		/// <summary> Returns Effective Start Date of Provider Role (PRD-8).</summary>
		virtual public TS EffectiveStartDateOfProviderRole
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(8, 0);
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
		/// <summary> Returns Effective End Date of Provider Role (PRD-9).</summary>
		virtual public TS EffectiveEndDateOfProviderRole
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(9, 0);
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
		
		/// <summary> Creates a PRD (Provider Data) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public PRD(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(CE), true, 0, 200, new System.Object[]{message});
				this.add(typeof(XPN), false, 0, 106, new System.Object[]{message});
				this.add(typeof(XAD), false, 0, 60, new System.Object[]{message});
				this.add(typeof(PL), false, 1, 60, new System.Object[]{message});
				this.add(typeof(XTN), false, 0, 100, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 200, new System.Object[]{message});
				this.add(typeof(PI), false, 0, 100, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Provider Role (PRD-1).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getProviderRole(int rep)
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
		
		/// <summary> Returns all repetitions of Provider Role (PRD-1).</summary>
		public virtual CE[] getProviderRole()
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
		
		/// <summary> Returns a single repetition of Provider Name (PRD-2).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XPN getProviderName(int rep)
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
		
		/// <summary> Returns all repetitions of Provider Name (PRD-2).</summary>
		public virtual XPN[] getProviderName()
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
		
		/// <summary> Returns a single repetition of Provider Address (PRD-3).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XAD getProviderAddress(int rep)
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
		
		/// <summary> Returns all repetitions of Provider Address (PRD-3).</summary>
		public virtual XAD[] getProviderAddress()
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
		
		/// <summary> Returns a single repetition of Provider Communication Information (PRD-5).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XTN getProviderCommunicationInformation(int rep)
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
		
		/// <summary> Returns all repetitions of Provider Communication Information (PRD-5).</summary>
		public virtual XTN[] getProviderCommunicationInformation()
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
		
		/// <summary> Returns a single repetition of Provider Identifiers (PRD-7).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual PI getProviderIdentifiers(int rep)
		{
			PI ret = null;
			try
			{
				Type t = this.getField(7, rep);
				ret = (PI) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Provider Identifiers (PRD-7).</summary>
		public virtual PI[] getProviderIdentifiers()
		{
			PI[] ret = null;
			try
			{
				Type[] t = this.getField(7);
				ret = new PI[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (PI) t[i];
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