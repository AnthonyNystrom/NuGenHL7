using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v25.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v25.segment
{
	
	/// <summary> <p>Represents an HL7 IPC message segment. 
	/// This segment has the following fields:</p><p>
	/// IPC-1: Accession Identifier (EI)<br> 
	/// IPC-2: Requested Procedure ID (EI)<br> 
	/// IPC-3: Study Instance UID (EI)<br> 
	/// IPC-4: Scheduled Procedure Step ID (EI)<br> 
	/// IPC-5: Modality (CE)<br> 
	/// IPC-6: Protocol Code (CE)<br> 
	/// IPC-7: Scheduled Station Name (EI)<br> 
	/// IPC-8: Scheduled Procedure Step Location (CE)<br> 
	/// IPC-9: Scheduled AE Title (ST)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class IPC:AbstractSegment
	{
		/// <summary> Returns Accession Identifier (IPC-1).</summary>
		virtual public EI AccessionIdentifier
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
		/// <summary> Returns Requested Procedure ID (IPC-2).</summary>
		virtual public EI RequestedProcedureID
		{
			get
			{
				EI ret = null;
				try
				{
					Type t = this.getField(2, 0);
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
		/// <summary> Returns Study Instance UID (IPC-3).</summary>
		virtual public EI StudyInstanceUID
		{
			get
			{
				EI ret = null;
				try
				{
					Type t = this.getField(3, 0);
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
		/// <summary> Returns Scheduled Procedure Step ID (IPC-4).</summary>
		virtual public EI ScheduledProcedureStepID
		{
			get
			{
				EI ret = null;
				try
				{
					Type t = this.getField(4, 0);
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
		/// <summary> Returns Modality (IPC-5).</summary>
		virtual public CE Modality
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
		/// <summary> Returns Scheduled Station Name (IPC-7).</summary>
		virtual public EI ScheduledStationName
		{
			get
			{
				EI ret = null;
				try
				{
					Type t = this.getField(7, 0);
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
		/// <summary> Returns Scheduled AE Title (IPC-9).</summary>
		virtual public ST ScheduledAETitle
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(9, 0);
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
		
		/// <summary> Creates a IPC (Imaging Procedure Control Segment) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public IPC(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(EI), true, 1, 80, new System.Object[]{message});
				this.add(typeof(EI), true, 1, 22, new System.Object[]{message});
				this.add(typeof(EI), true, 1, 70, new System.Object[]{message});
				this.add(typeof(EI), true, 1, 22, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 16, new System.Object[]{message});
				this.add(typeof(CE), false, 0, 250, new System.Object[]{message});
				this.add(typeof(EI), false, 1, 22, new System.Object[]{message});
				this.add(typeof(CE), false, 0, 250, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 16, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Protocol Code (IPC-6).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getProtocolCode(int rep)
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
		
		/// <summary> Returns all repetitions of Protocol Code (IPC-6).</summary>
		public virtual CE[] getProtocolCode()
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
		
		/// <summary> Returns a single repetition of Scheduled Procedure Step Location (IPC-8).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getScheduledProcedureStepLocation(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(8, rep);
				ret = (CE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Scheduled Procedure Step Location (IPC-8).</summary>
		public virtual CE[] getScheduledProcedureStepLocation()
		{
			CE[] ret = null;
			try
			{
				Type[] t = this.getField(8);
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