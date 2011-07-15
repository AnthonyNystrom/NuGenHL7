using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v21.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v21.segment
{
	
	/// <summary> <p>Represents an HL7 GT1 message segment. 
	/// This segment has the following fields:</p><p>
	/// GT1-1: SET ID - GUARANTOR (SI)<br> 
	/// GT1-2: GUARANTOR NUMBER (ID)<br> 
	/// GT1-3: GUARANTOR NAME (PN)<br> 
	/// GT1-4: GUARANTOR SPOUSE NAME (PN)<br> 
	/// GT1-5: GUARANTOR ADDRESS (AD)<br> 
	/// GT1-6: GUARANTOR PH. NUM.- HOME (TN)<br> 
	/// GT1-7: GUARANTOR PH. NUM-BUSINESS (TN)<br> 
	/// GT1-8: GUARANTOR DATE OF BIRTH (DT)<br> 
	/// GT1-9: GUARANTOR SEX (ID)<br> 
	/// GT1-10: GUARANTOR TYPE (ID)<br> 
	/// GT1-11: GUARANTOR RELATIONSHIP (ID)<br> 
	/// GT1-12: GUARANTOR SSN (ST)<br> 
	/// GT1-13: GUARANTOR DATE - BEGIN (DT)<br> 
	/// GT1-14: GUARANTOR DATE - END (DT)<br> 
	/// GT1-15: GUARANTOR PRIORITY (NM)<br> 
	/// GT1-16: GUARANTOR EMPLOYER NAME (ST)<br> 
	/// GT1-17: GUARANTOR EMPLOYER ADDRESS (AD)<br> 
	/// GT1-18: GUARANTOR EMPLOY PHONE # (TN)<br> 
	/// GT1-19: GUARANTOR EMPLOYEE ID NUM (ST)<br> 
	/// GT1-20: GUARANTOR EMPLOYMENT STATUS (ID)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class GT1:AbstractSegment
	{
		/// <summary> Returns SET ID - GUARANTOR (GT1-1).</summary>
		virtual public SI SETIDGUARANTOR
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
		/// <summary> Returns GUARANTOR NUMBER (GT1-2).</summary>
		virtual public ID GUARANTORNUMBER
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
		/// <summary> Returns GUARANTOR NAME (GT1-3).</summary>
		virtual public PN GUARANTORNAME
		{
			get
			{
				PN ret = null;
				try
				{
					Type t = this.getField(3, 0);
					ret = (PN) t;
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
		/// <summary> Returns GUARANTOR SPOUSE NAME (GT1-4).</summary>
		virtual public PN GUARANTORSPOUSENAME
		{
			get
			{
				PN ret = null;
				try
				{
					Type t = this.getField(4, 0);
					ret = (PN) t;
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
		/// <summary> Returns GUARANTOR ADDRESS (GT1-5).</summary>
		virtual public AD GUARANTORADDRESS
		{
			get
			{
				AD ret = null;
				try
				{
					Type t = this.getField(5, 0);
					ret = (AD) t;
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
		/// <summary> Returns GUARANTOR PH. NUM.- HOME (GT1-6).</summary>
		virtual public TN GUARANTORPHNUMHOME
		{
			get
			{
				TN ret = null;
				try
				{
					Type t = this.getField(6, 0);
					ret = (TN) t;
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
		/// <summary> Returns GUARANTOR PH. NUM-BUSINESS (GT1-7).</summary>
		virtual public TN GUARANTORPHNUMBUSINESS
		{
			get
			{
				TN ret = null;
				try
				{
					Type t = this.getField(7, 0);
					ret = (TN) t;
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
		/// <summary> Returns GUARANTOR DATE OF BIRTH (GT1-8).</summary>
		virtual public DT GUARANTORDATEOFBIRTH
		{
			get
			{
				DT ret = null;
				try
				{
					Type t = this.getField(8, 0);
					ret = (DT) t;
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
		/// <summary> Returns GUARANTOR SEX (GT1-9).</summary>
		virtual public ID GUARANTORSEX
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
		/// <summary> Returns GUARANTOR TYPE (GT1-10).</summary>
		virtual public ID GUARANTORTYPE
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(10, 0);
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
		/// <summary> Returns GUARANTOR RELATIONSHIP (GT1-11).</summary>
		virtual public ID GUARANTORRELATIONSHIP
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
		/// <summary> Returns GUARANTOR SSN (GT1-12).</summary>
		virtual public ST GUARANTORSSN
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(12, 0);
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
		/// <summary> Returns GUARANTOR DATE - BEGIN (GT1-13).</summary>
		virtual public DT GUARANTORDATEBEGIN
		{
			get
			{
				DT ret = null;
				try
				{
					Type t = this.getField(13, 0);
					ret = (DT) t;
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
		/// <summary> Returns GUARANTOR DATE - END (GT1-14).</summary>
		virtual public DT GUARANTORDATEEND
		{
			get
			{
				DT ret = null;
				try
				{
					Type t = this.getField(14, 0);
					ret = (DT) t;
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
		/// <summary> Returns GUARANTOR PRIORITY (GT1-15).</summary>
		virtual public NM GUARANTORPRIORITY
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(15, 0);
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
		/// <summary> Returns GUARANTOR EMPLOYER NAME (GT1-16).</summary>
		virtual public ST GUARANTOREMPLOYERNAME
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(16, 0);
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
		/// <summary> Returns GUARANTOR EMPLOYER ADDRESS (GT1-17).</summary>
		virtual public AD GUARANTOREMPLOYERADDRESS
		{
			get
			{
				AD ret = null;
				try
				{
					Type t = this.getField(17, 0);
					ret = (AD) t;
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
		/// <summary> Returns GUARANTOR EMPLOY PHONE # (GT1-18).</summary>
		virtual public TN GUARANTOREMPLOYPHONE
		{
			get
			{
				TN ret = null;
				try
				{
					Type t = this.getField(18, 0);
					ret = (TN) t;
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
		/// <summary> Returns GUARANTOR EMPLOYEE ID NUM (GT1-19).</summary>
		virtual public ST GUARANTOREMPLOYEEIDNUM
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(19, 0);
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
		/// <summary> Returns GUARANTOR EMPLOYMENT STATUS (GT1-20).</summary>
		virtual public ID GUARANTOREMPLOYMENTSTATUS
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(20, 0);
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
		
		/// <summary> Creates a GT1 (GUARANTOR) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public GT1(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(SI), true, 1, 4, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 20, new System.Object[]{message, 0});
				this.add(typeof(PN), true, 1, 48, new System.Object[]{message});
				this.add(typeof(PN), false, 1, 48, new System.Object[]{message});
				this.add(typeof(AD), false, 1, 106, new System.Object[]{message});
				this.add(typeof(TN), false, 1, 40, new System.Object[]{message});
				this.add(typeof(TN), false, 1, 40, new System.Object[]{message});
				this.add(typeof(DT), false, 1, 8, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 1});
				this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 68});
				this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 63});
				this.add(typeof(ST), false, 1, 11, new System.Object[]{message});
				this.add(typeof(DT), false, 1, 8, new System.Object[]{message});
				this.add(typeof(DT), false, 1, 8, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 2, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 45, new System.Object[]{message});
				this.add(typeof(AD), false, 1, 106, new System.Object[]{message});
				this.add(typeof(TN), false, 1, 40, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 20, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 66});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}