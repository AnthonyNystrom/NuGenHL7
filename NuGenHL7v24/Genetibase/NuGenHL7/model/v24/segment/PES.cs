using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v24.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v24.segment
{
	
	/// <summary> <p>Represents an HL7 PES message segment. 
	/// This segment has the following fields:</p><p>
	/// PES-1: Sender Organization Name (XON)<br> 
	/// PES-2: Sender Individual Name (XCN)<br> 
	/// PES-3: Sender Address (XAD)<br> 
	/// PES-4: Sender Telephone (XTN)<br> 
	/// PES-5: Sender Event Identifier (EI)<br> 
	/// PES-6: Sender Sequence Number (NM)<br> 
	/// PES-7: Sender Event Description (FT)<br> 
	/// PES-8: Sender Comment (FT)<br> 
	/// PES-9: Sender Aware Date/Time (TS)<br> 
	/// PES-10: Event Report Date (TS)<br> 
	/// PES-11: Event Report Timing/Type (ID)<br> 
	/// PES-12: Event Report Source (ID)<br> 
	/// PES-13: Event Reported To (ID)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class PES:AbstractSegment
	{
		/// <summary> Returns Sender Event Identifier (PES-5).</summary>
		virtual public EI SenderEventIdentifier
		{
			get
			{
				EI ret = null;
				try
				{
					Type t = this.getField(5, 0);
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
		/// <summary> Returns Sender Sequence Number (PES-6).</summary>
		virtual public NM SenderSequenceNumber
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(6, 0);
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
		/// <summary> Returns Sender Comment (PES-8).</summary>
		virtual public FT SenderComment
		{
			get
			{
				FT ret = null;
				try
				{
					Type t = this.getField(8, 0);
					ret = (FT) t;
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
		/// <summary> Returns Sender Aware Date/Time (PES-9).</summary>
		virtual public TS SenderAwareDateTime
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
		/// <summary> Returns Event Report Date (PES-10).</summary>
		virtual public TS EventReportDate
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(10, 0);
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
		/// <summary> Returns Event Report Source (PES-12).</summary>
		virtual public ID EventReportSource
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(12, 0);
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
		
		/// <summary> Creates a PES (Product Experience Sender) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public PES(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(XON), false, 0, 250, new System.Object[]{message});
				this.add(typeof(XCN), false, 0, 250, new System.Object[]{message});
				this.add(typeof(XAD), false, 0, 250, new System.Object[]{message});
				this.add(typeof(XTN), false, 0, 250, new System.Object[]{message});
				this.add(typeof(EI), false, 1, 75, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 2, new System.Object[]{message});
				this.add(typeof(FT), false, 0, 600, new System.Object[]{message});
				this.add(typeof(FT), false, 1, 600, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(TS), true, 1, 26, new System.Object[]{message});
				this.add(typeof(ID), false, 2, 3, new System.Object[]{message, 234});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 235});
				this.add(typeof(ID), false, 0, 1, new System.Object[]{message, 236});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Sender Organization Name (PES-1).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XON getSenderOrganizationName(int rep)
		{
			XON ret = null;
			try
			{
				Type t = this.getField(1, rep);
				ret = (XON) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Sender Organization Name (PES-1).</summary>
		public virtual XON[] getSenderOrganizationName()
		{
			XON[] ret = null;
			try
			{
				Type[] t = this.getField(1);
				ret = new XON[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (XON) t[i];
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
		
		/// <summary> Returns a single repetition of Sender Individual Name (PES-2).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XCN getSenderIndividualName(int rep)
		{
			XCN ret = null;
			try
			{
				Type t = this.getField(2, rep);
				ret = (XCN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Sender Individual Name (PES-2).</summary>
		public virtual XCN[] getSenderIndividualName()
		{
			XCN[] ret = null;
			try
			{
				Type[] t = this.getField(2);
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
		
		/// <summary> Returns a single repetition of Sender Address (PES-3).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XAD getSenderAddress(int rep)
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
		
		/// <summary> Returns all repetitions of Sender Address (PES-3).</summary>
		public virtual XAD[] getSenderAddress()
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
		
		/// <summary> Returns a single repetition of Sender Telephone (PES-4).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XTN getSenderTelephone(int rep)
		{
			XTN ret = null;
			try
			{
				Type t = this.getField(4, rep);
				ret = (XTN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Sender Telephone (PES-4).</summary>
		public virtual XTN[] getSenderTelephone()
		{
			XTN[] ret = null;
			try
			{
				Type[] t = this.getField(4);
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
		
		/// <summary> Returns a single repetition of Sender Event Description (PES-7).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual FT getSenderEventDescription(int rep)
		{
			FT ret = null;
			try
			{
				Type t = this.getField(7, rep);
				ret = (FT) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Sender Event Description (PES-7).</summary>
		public virtual FT[] getSenderEventDescription()
		{
			FT[] ret = null;
			try
			{
				Type[] t = this.getField(7);
				ret = new FT[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (FT) t[i];
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
		
		/// <summary> Returns a single repetition of Event Report Timing/Type (PES-11).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ID getEventReportTimingType(int rep)
		{
			ID ret = null;
			try
			{
				Type t = this.getField(11, rep);
				ret = (ID) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Event Report Timing/Type (PES-11).</summary>
		public virtual ID[] getEventReportTimingType()
		{
			ID[] ret = null;
			try
			{
				Type[] t = this.getField(11);
				ret = new ID[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (ID) t[i];
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
		
		/// <summary> Returns a single repetition of Event Reported To (PES-13).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ID getEventReportedTo(int rep)
		{
			ID ret = null;
			try
			{
				Type t = this.getField(13, rep);
				ret = (ID) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Event Reported To (PES-13).</summary>
		public virtual ID[] getEventReportedTo()
		{
			ID[] ret = null;
			try
			{
				Type[] t = this.getField(13);
				ret = new ID[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (ID) t[i];
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