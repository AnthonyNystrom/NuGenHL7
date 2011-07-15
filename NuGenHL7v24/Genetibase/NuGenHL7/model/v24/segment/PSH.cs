using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v24.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v24.segment
{
	
	/// <summary> <p>Represents an HL7 PSH message segment. 
	/// This segment has the following fields:</p><p>
	/// PSH-1: Report Type (ST)<br> 
	/// PSH-2: Report Form Identifier (ST)<br> 
	/// PSH-3: Report Date (TS)<br> 
	/// PSH-4: Report Interval Start Date (TS)<br> 
	/// PSH-5: Report Interval End Date (TS)<br> 
	/// PSH-6: Quantity Manufactured (CQ)<br> 
	/// PSH-7: Quantity Distributed (CQ)<br> 
	/// PSH-8: Quantity Distributed Method (ID)<br> 
	/// PSH-9: Quantity Distributed Comment (FT)<br> 
	/// PSH-10: Quantity in Use (CQ)<br> 
	/// PSH-11: Quantity in Use Method (ID)<br> 
	/// PSH-12: Quantity in Use Comment (FT)<br> 
	/// PSH-13: Number of Product Experience Reports Filed by Facility (NM)<br> 
	/// PSH-14: Number of Product Experience Reports Filed by Distributor (NM)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class PSH:AbstractSegment
	{
		/// <summary> Returns Report Type (PSH-1).</summary>
		virtual public ST ReportType
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(1, 0);
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
		/// <summary> Returns Report Form Identifier (PSH-2).</summary>
		virtual public ST ReportFormIdentifier
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
		/// <summary> Returns Report Date (PSH-3).</summary>
		virtual public TS ReportDate
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(3, 0);
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
		/// <summary> Returns Report Interval Start Date (PSH-4).</summary>
		virtual public TS ReportIntervalStartDate
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(4, 0);
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
		/// <summary> Returns Report Interval End Date (PSH-5).</summary>
		virtual public TS ReportIntervalEndDate
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(5, 0);
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
		/// <summary> Returns Quantity Manufactured (PSH-6).</summary>
		virtual public CQ QuantityManufactured
		{
			get
			{
				CQ ret = null;
				try
				{
					Type t = this.getField(6, 0);
					ret = (CQ) t;
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
		/// <summary> Returns Quantity Distributed (PSH-7).</summary>
		virtual public CQ QuantityDistributed
		{
			get
			{
				CQ ret = null;
				try
				{
					Type t = this.getField(7, 0);
					ret = (CQ) t;
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
		/// <summary> Returns Quantity Distributed Method (PSH-8).</summary>
		virtual public ID QuantityDistributedMethod
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(8, 0);
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
		/// <summary> Returns Quantity Distributed Comment (PSH-9).</summary>
		virtual public FT QuantityDistributedComment
		{
			get
			{
				FT ret = null;
				try
				{
					Type t = this.getField(9, 0);
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
		/// <summary> Returns Quantity in Use (PSH-10).</summary>
		virtual public CQ QuantityInUse
		{
			get
			{
				CQ ret = null;
				try
				{
					Type t = this.getField(10, 0);
					ret = (CQ) t;
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
		/// <summary> Returns Quantity in Use Method (PSH-11).</summary>
		virtual public ID QuantityInUseMethod
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(11, 0);
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
		/// <summary> Returns Quantity in Use Comment (PSH-12).</summary>
		virtual public FT QuantityInUseComment
		{
			get
			{
				FT ret = null;
				try
				{
					Type t = this.getField(12, 0);
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
		
		/// <summary> Creates a PSH (Product Summary Header) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public PSH(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(ST), true, 1, 60, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 60, new System.Object[]{message});
				this.add(typeof(TS), true, 1, 26, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(CQ), false, 1, 12, new System.Object[]{message});
				this.add(typeof(CQ), false, 1, 12, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 329});
				this.add(typeof(FT), false, 1, 600, new System.Object[]{message});
				this.add(typeof(CQ), false, 1, 12, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 329});
				this.add(typeof(FT), false, 1, 600, new System.Object[]{message});
				this.add(typeof(NM), false, 8, 2, new System.Object[]{message});
				this.add(typeof(NM), false, 8, 2, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Number of Product Experience Reports Filed by Facility (PSH-13).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual NM getNumberOfProductExperienceReportsFiledByFacility(int rep)
		{
			NM ret = null;
			try
			{
				Type t = this.getField(13, rep);
				ret = (NM) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Number of Product Experience Reports Filed by Facility (PSH-13).</summary>
		public virtual NM[] getNumberOfProductExperienceReportsFiledByFacility()
		{
			NM[] ret = null;
			try
			{
				Type[] t = this.getField(13);
				ret = new NM[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (NM) t[i];
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
		
		/// <summary> Returns a single repetition of Number of Product Experience Reports Filed by Distributor (PSH-14).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual NM getNumberOfProductExperienceReportsFiledByDistributor(int rep)
		{
			NM ret = null;
			try
			{
				Type t = this.getField(14, rep);
				ret = (NM) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Number of Product Experience Reports Filed by Distributor (PSH-14).</summary>
		public virtual NM[] getNumberOfProductExperienceReportsFiledByDistributor()
		{
			NM[] ret = null;
			try
			{
				Type[] t = this.getField(14);
				ret = new NM[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (NM) t[i];
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