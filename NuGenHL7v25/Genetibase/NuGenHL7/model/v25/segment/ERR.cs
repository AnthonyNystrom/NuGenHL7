using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v25.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v25.segment
{
	
	/// <summary> <p>Represents an HL7 ERR message segment. 
	/// This segment has the following fields:</p><p>
	/// ERR-1: Error Code and Location (ELD)<br> 
	/// ERR-2: Error Location (ERL)<br> 
	/// ERR-3: HL7 Error Code (CWE)<br> 
	/// ERR-4: Severity (ID)<br> 
	/// ERR-5: Application Error Code (CWE)<br> 
	/// ERR-6: Application Error Parameter (ST)<br> 
	/// ERR-7: Diagnostic Information (TX)<br> 
	/// ERR-8: User Message (TX)<br> 
	/// ERR-9: Inform Person Indicator (IS)<br> 
	/// ERR-10: Override Type (CWE)<br> 
	/// ERR-11: Override Reason Code (CWE)<br> 
	/// ERR-12: Help Desk Contact Point (XTN)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class ERR:AbstractSegment
	{
		/// <summary> Returns HL7 Error Code (ERR-3).</summary>
		virtual public CWE HL7ErrorCode
		{
			get
			{
				CWE ret = null;
				try
				{
					Type t = this.getField(3, 0);
					ret = (CWE) t;
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
		/// <summary> Returns Severity (ERR-4).</summary>
		virtual public ID Severity
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(4, 0);
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
		/// <summary> Returns Application Error Code (ERR-5).</summary>
		virtual public CWE ApplicationErrorCode
		{
			get
			{
				CWE ret = null;
				try
				{
					Type t = this.getField(5, 0);
					ret = (CWE) t;
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
		/// <summary> Returns Diagnostic Information (ERR-7).</summary>
		virtual public TX DiagnosticInformation
		{
			get
			{
				TX ret = null;
				try
				{
					Type t = this.getField(7, 0);
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
		/// <summary> Returns User Message (ERR-8).</summary>
		virtual public TX UserMessage
		{
			get
			{
				TX ret = null;
				try
				{
					Type t = this.getField(8, 0);
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
		/// <summary> Returns Override Type (ERR-10).</summary>
		virtual public CWE OverrideType
		{
			get
			{
				CWE ret = null;
				try
				{
					Type t = this.getField(10, 0);
					ret = (CWE) t;
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
		
		/// <summary> Creates a ERR (Error) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public ERR(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(ELD), false, 0, 493, new System.Object[]{message});
				this.add(typeof(ERL), false, 0, 18, new System.Object[]{message});
				this.add(typeof(CWE), true, 1, 705, new System.Object[]{message});
				this.add(typeof(ID), true, 1, 2, new System.Object[]{message, 516});
				this.add(typeof(CWE), false, 1, 705, new System.Object[]{message});
				this.add(typeof(ST), false, 0, 80, new System.Object[]{message});
				this.add(typeof(TX), false, 1, 2048, new System.Object[]{message});
				this.add(typeof(TX), false, 1, 250, new System.Object[]{message});
				this.add(typeof(IS), false, 0, 20, new System.Object[]{message, 517});
				this.add(typeof(CWE), false, 1, 705, new System.Object[]{message});
				this.add(typeof(CWE), false, 0, 705, new System.Object[]{message});
				this.add(typeof(XTN), false, 0, 652, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Error Code and Location (ERR-1).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ELD getErrorCodeAndLocation(int rep)
		{
			ELD ret = null;
			try
			{
				Type t = this.getField(1, rep);
				ret = (ELD) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Error Code and Location (ERR-1).</summary>
		public virtual ELD[] getErrorCodeAndLocation()
		{
			ELD[] ret = null;
			try
			{
				Type[] t = this.getField(1);
				ret = new ELD[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (ELD) t[i];
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
		
		/// <summary> Returns a single repetition of Error Location (ERR-2).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ERL getErrorLocation(int rep)
		{
			ERL ret = null;
			try
			{
				Type t = this.getField(2, rep);
				ret = (ERL) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Error Location (ERR-2).</summary>
		public virtual ERL[] getErrorLocation()
		{
			ERL[] ret = null;
			try
			{
				Type[] t = this.getField(2);
				ret = new ERL[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (ERL) t[i];
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
		
		/// <summary> Returns a single repetition of Application Error Parameter (ERR-6).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ST getApplicationErrorParameter(int rep)
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
		
		/// <summary> Returns all repetitions of Application Error Parameter (ERR-6).</summary>
		public virtual ST[] getApplicationErrorParameter()
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
		
		/// <summary> Returns a single repetition of Inform Person Indicator (ERR-9).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual IS getInformPersonIndicator(int rep)
		{
			IS ret = null;
			try
			{
				Type t = this.getField(9, rep);
				ret = (IS) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Inform Person Indicator (ERR-9).</summary>
		public virtual IS[] getInformPersonIndicator()
		{
			IS[] ret = null;
			try
			{
				Type[] t = this.getField(9);
				ret = new IS[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (IS) t[i];
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
		
		/// <summary> Returns a single repetition of Override Reason Code (ERR-11).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CWE getOverrideReasonCode(int rep)
		{
			CWE ret = null;
			try
			{
				Type t = this.getField(11, rep);
				ret = (CWE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Override Reason Code (ERR-11).</summary>
		public virtual CWE[] getOverrideReasonCode()
		{
			CWE[] ret = null;
			try
			{
				Type[] t = this.getField(11);
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
		
		/// <summary> Returns a single repetition of Help Desk Contact Point (ERR-12).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XTN getHelpDeskContactPoint(int rep)
		{
			XTN ret = null;
			try
			{
				Type t = this.getField(12, rep);
				ret = (XTN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Help Desk Contact Point (ERR-12).</summary>
		public virtual XTN[] getHelpDeskContactPoint()
		{
			XTN[] ret = null;
			try
			{
				Type[] t = this.getField(12);
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
	}
}