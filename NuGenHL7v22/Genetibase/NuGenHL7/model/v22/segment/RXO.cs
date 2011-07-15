using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v22.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v22.segment
{
	
	/// <summary> <p>Represents an HL7 RXO message segment. 
	/// This segment has the following fields:</p><p>
	/// RXO-1: Requested Give Code (CE)<br> 
	/// RXO-2: Requested Give Amount - Minimum (NM)<br> 
	/// RXO-3: Requested Give Amount - Maximum (NM)<br> 
	/// RXO-4: Requested Give Units (CE)<br> 
	/// RXO-5: Requested Dosage Form (CE)<br> 
	/// RXO-6: Provider's Pharmacy Instructions (CE)<br> 
	/// RXO-7: Provider's Administration Instructions (CE)<br> 
	/// RXO-8: Deliver-to location (CM_LA1)<br> 
	/// RXO-9: Allow Substitutions (ID)<br> 
	/// RXO-10: Requested Dispense Code (CE)<br> 
	/// RXO-11: Requested Dispense Amount (NM)<br> 
	/// RXO-12: Requested Dispense Units (CE)<br> 
	/// RXO-13: Number of Refills (NM)<br> 
	/// RXO-14: Ordering Provider's DEA Number (CN)<br> 
	/// RXO-15: Pharmacist Verifier ID (CN)<br> 
	/// RXO-16: Needs Human Review (ID)<br> 
	/// RXO-17: Requested Give Per (Time Unit) (ST)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class RXO:AbstractSegment
	{
		/// <summary> Returns Requested Give Code (RXO-1).</summary>
		virtual public CE RequestedGiveCode
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(1, 0);
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
		/// <summary> Returns Requested Give Amount - Minimum (RXO-2).</summary>
		virtual public NM RequestedGiveAmountMinimum
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(2, 0);
					ret = (NM) t;
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
		/// <summary> Returns Requested Give Amount - Maximum (RXO-3).</summary>
		virtual public NM RequestedGiveAmountMaximum
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(3, 0);
					ret = (NM) t;
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
		/// <summary> Returns Requested Give Units (RXO-4).</summary>
		virtual public CE RequestedGiveUnits
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(4, 0);
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
		/// <summary> Returns Requested Dosage Form (RXO-5).</summary>
		virtual public CE RequestedDosageForm
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(5, 0);
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
		/// <summary> Returns Deliver-to location (RXO-8).</summary>
		virtual public CM_LA1 DeliverToLocation
		{
			get
			{
				CM_LA1 ret = null;
				try
				{
					Type t = this.getField(8, 0);
					ret = (CM_LA1) t;
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
		/// <summary> Returns Allow Substitutions (RXO-9).</summary>
		virtual public ID AllowSubstitutions
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(9, 0);
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
		/// <summary> Returns Requested Dispense Code (RXO-10).</summary>
		virtual public CE RequestedDispenseCode
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(10, 0);
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
		/// <summary> Returns Requested Dispense Amount (RXO-11).</summary>
		virtual public NM RequestedDispenseAmount
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(11, 0);
					ret = (NM) t;
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
		/// <summary> Returns Requested Dispense Units (RXO-12).</summary>
		virtual public CE RequestedDispenseUnits
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(12, 0);
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
		/// <summary> Returns Number of Refills (RXO-13).</summary>
		virtual public NM NumberOfRefills
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(13, 0);
					ret = (NM) t;
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
		/// <summary> Returns Ordering Provider's DEA Number (RXO-14).</summary>
		virtual public CN OrderingProviderSDEANumber
		{
			get
			{
				CN ret = null;
				try
				{
					Type t = this.getField(14, 0);
					ret = (CN) t;
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
		/// <summary> Returns Pharmacist Verifier ID (RXO-15).</summary>
		virtual public CN PharmacistVerifierID
		{
			get
			{
				CN ret = null;
				try
				{
					Type t = this.getField(15, 0);
					ret = (CN) t;
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
		/// <summary> Returns Needs Human Review (RXO-16).</summary>
		virtual public ID NeedsHumanReview
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(16, 0);
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
		/// <summary> Returns Requested Give Per (Time Unit) (RXO-17).</summary>
		virtual public ST RequestedGivePerTimeUnit
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(17, 0);
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
		
		/// <summary> Creates a RXO (PHARMACY PRESCRIPTION ORDER) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public RXO(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(CE), true, 1, 100, new System.Object[]{message});
				this.add(typeof(NM), true, 1, 20, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 20, new System.Object[]{message});
				this.add(typeof(CE), true, 1, 60, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
				this.add(typeof(CE), false, 0, 200, new System.Object[]{message});
				this.add(typeof(CE), false, 0, 200, new System.Object[]{message});
				this.add(typeof(CM_LA1), false, 1, 12, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 161});
				this.add(typeof(CE), false, 1, 100, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 20, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 3, new System.Object[]{message});
				this.add(typeof(CN), false, 1, 60, new System.Object[]{message});
				this.add(typeof(CN), false, 1, 60, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 0});
				this.add(typeof(ST), false, 1, 20, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Provider's Pharmacy Instructions (RXO-6).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getProviderSPharmacyInstructions(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(6, rep);
				ret = (CE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Provider's Pharmacy Instructions (RXO-6).</summary>
		public virtual CE[] getProviderSPharmacyInstructions()
		{
			CE[] ret = null;
			try
			{
				Type[] t = this.getField(6);
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
		
		/// <summary> Returns a single repetition of Provider's Administration Instructions (RXO-7).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getProviderSAdministrationInstructions(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(7, rep);
				ret = (CE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Provider's Administration Instructions (RXO-7).</summary>
		public virtual CE[] getProviderSAdministrationInstructions()
		{
			CE[] ret = null;
			try
			{
				Type[] t = this.getField(7);
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
	}
}