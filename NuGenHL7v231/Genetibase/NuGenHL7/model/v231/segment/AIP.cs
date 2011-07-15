using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v231.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v231.segment
{
	
	/// <summary> <p>Represents an HL7 AIP message segment. 
	/// This segment has the following fields:</p><p>
	/// AIP-1: Set ID - AIP (SI)<br> 
	/// AIP-2: Segment Action Code (ID)<br> 
	/// AIP-3: Personnel Resource ID (XCN)<br> 
	/// AIP-4: Resource Role (CE)<br> 
	/// AIP-5: Resource Group (CE)<br> 
	/// AIP-6: Start Date/Time (TS)<br> 
	/// AIP-7: Start Date/Time Offset (NM)<br> 
	/// AIP-8: Start Date/Time Offset Units (CE)<br> 
	/// AIP-9: Duration (NM)<br> 
	/// AIP-10: Duration Units (CE)<br> 
	/// AIP-11: Allow Substitution Code (IS)<br> 
	/// AIP-12: Filler Status Code (CE)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class AIP:AbstractSegment
	{
		/// <summary> Returns Set ID - AIP (AIP-1).</summary>
		virtual public SI SetIDAIP
		{
			get
			{
				SI ret = null;
				try
				{
					Type t = this.getField(1, 0);
					ret = (SI) t;
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
		/// <summary> Returns Segment Action Code (AIP-2).</summary>
		virtual public ID SegmentActionCode
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
		/// <summary> Returns Resource Role (AIP-4).</summary>
		virtual public CE ResourceRole
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
		/// <summary> Returns Resource Group (AIP-5).</summary>
		virtual public CE ResourceGroup
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
		/// <summary> Returns Start Date/Time (AIP-6).</summary>
		virtual public TS StartDateTime
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
		/// <summary> Returns Start Date/Time Offset (AIP-7).</summary>
		virtual public NM StartDateTimeOffset
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(7, 0);
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
		/// <summary> Returns Start Date/Time Offset Units (AIP-8).</summary>
		virtual public CE StartDateTimeOffsetUnits
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(8, 0);
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
		/// <summary> Returns Duration (AIP-9).</summary>
		virtual public NM Duration
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(9, 0);
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
		/// <summary> Returns Duration Units (AIP-10).</summary>
		virtual public CE DurationUnits
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
		/// <summary> Returns Allow Substitution Code (AIP-11).</summary>
		virtual public IS AllowSubstitutionCode
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(11, 0);
					ret = (IS) t;
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
		/// <summary> Returns Filler Status Code (AIP-12).</summary>
		virtual public CE FillerStatusCode
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
		
		/// <summary> Creates a AIP (AIP - appointment information - personnel resource segment) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public AIP(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(SI), true, 1, 4, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 3, new System.Object[]{message, 206});
				this.add(typeof(XCN), false, 0, 80, new System.Object[]{message});
				this.add(typeof(CE), true, 1, 200, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 200, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 20, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 200, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 20, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 200, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 10, new System.Object[]{message, 279});
				this.add(typeof(CE), false, 1, 200, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Personnel Resource ID (AIP-3).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XCN getPersonnelResourceID(int rep)
		{
			XCN ret = null;
			try
			{
				Type t = this.getField(3, rep);
				ret = (XCN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Personnel Resource ID (AIP-3).</summary>
		public virtual XCN[] getPersonnelResourceID()
		{
			XCN[] ret = null;
			try
			{
				Type[] t = this.getField(3);
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
	}
}