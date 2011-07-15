using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v25.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v25.segment
{
	
	/// <summary> <p>Represents an HL7 EDU message segment. 
	/// This segment has the following fields:</p><p>
	/// EDU-1: Set ID _ EDU (SI)<br> 
	/// EDU-2: Academic Degree (IS)<br> 
	/// EDU-3: Academic Degree Program Date Range (DR)<br> 
	/// EDU-4: Academic Degree Program Participation Date Range (DR)<br> 
	/// EDU-5: Academic Degree Granted Date (DT)<br> 
	/// EDU-6: School (XON)<br> 
	/// EDU-7: School Type Code (CE)<br> 
	/// EDU-8: School Address (XAD)<br> 
	/// EDU-9: Major Field of Study (CWE)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class EDU:AbstractSegment
	{
		/// <summary> Returns Set ID _ EDU (EDU-1).</summary>
		virtual public SI SetIDEDU
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
		/// <summary> Returns Academic Degree (EDU-2).</summary>
		virtual public IS AcademicDegree
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(2, 0);
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
		/// <summary> Returns Academic Degree Program Date Range (EDU-3).</summary>
		virtual public DR AcademicDegreeProgramDateRange
		{
			get
			{
				DR ret = null;
				try
				{
					Type t = this.getField(3, 0);
					ret = (DR) t;
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
		/// <summary> Returns Academic Degree Program Participation Date Range (EDU-4).</summary>
		virtual public DR AcademicDegreeProgramParticipationDateRange
		{
			get
			{
				DR ret = null;
				try
				{
					Type t = this.getField(4, 0);
					ret = (DR) t;
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
		/// <summary> Returns Academic Degree Granted Date (EDU-5).</summary>
		virtual public DT AcademicDegreeGrantedDate
		{
			get
			{
				DT ret = null;
				try
				{
					Type t = this.getField(5, 0);
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
		/// <summary> Returns School (EDU-6).</summary>
		virtual public XON School
		{
			get
			{
				XON ret = null;
				try
				{
					Type t = this.getField(6, 0);
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
		/// <summary> Returns School Type Code (EDU-7).</summary>
		virtual public CE SchoolTypeCode
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(7, 0);
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
		/// <summary> Returns School Address (EDU-8).</summary>
		virtual public XAD SchoolAddress
		{
			get
			{
				XAD ret = null;
				try
				{
					Type t = this.getField(8, 0);
					ret = (XAD) t;
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
		
		/// <summary> Creates a EDU (Educational Detail) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public EDU(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(SI), true, 1, 60, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 10, new System.Object[]{message, 360});
				this.add(typeof(DR), false, 1, 52, new System.Object[]{message});
				this.add(typeof(DR), false, 1, 52, new System.Object[]{message});
				this.add(typeof(DT), false, 1, 8, new System.Object[]{message});
				this.add(typeof(XON), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(XAD), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CWE), false, 0, 250, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Major Field of Study (EDU-9).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CWE getMajorFieldOfStudy(int rep)
		{
			CWE ret = null;
			try
			{
				Type t = this.getField(9, rep);
				ret = (CWE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Major Field of Study (EDU-9).</summary>
		public virtual CWE[] getMajorFieldOfStudy()
		{
			CWE[] ret = null;
			try
			{
				Type[] t = this.getField(9);
				ret = new CWE[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (CWE) t[i];
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