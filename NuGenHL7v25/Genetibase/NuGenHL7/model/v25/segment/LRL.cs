using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v25.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v25.segment
{
	
	/// <summary> <p>Represents an HL7 LRL message segment. 
	/// This segment has the following fields:</p><p>
	/// LRL-1: Primary Key Value - LRL (PL)<br> 
	/// LRL-2: Segment Action Code (ID)<br> 
	/// LRL-3: Segment Unique Key (EI)<br> 
	/// LRL-4: Location Relationship ID (CE)<br> 
	/// LRL-5: Organizational Location Relationship Value (XON)<br> 
	/// LRL-6: Patient Location Relationship Value (PL)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class LRL:AbstractSegment
	{
		/// <summary> Returns Primary Key Value - LRL (LRL-1).</summary>
		virtual public PL PrimaryKeyValueLRL
		{
			get
			{
				PL ret = null;
				try
				{
					Type t = this.getField(1, 0);
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
		/// <summary> Returns Segment Action Code (LRL-2).</summary>
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
		/// <summary> Returns Segment Unique Key (LRL-3).</summary>
		virtual public EI SegmentUniqueKey
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
		/// <summary> Returns Location Relationship ID (LRL-4).</summary>
		virtual public CE LocationRelationshipID
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
		/// <summary> Returns Patient Location Relationship Value (LRL-6).</summary>
		virtual public PL PatientLocationRelationshipValue
		{
			get
			{
				PL ret = null;
				try
				{
					Type t = this.getField(6, 0);
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
		
		/// <summary> Creates a LRL (Location Relationship) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public LRL(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(PL), true, 1, 200, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 3, new System.Object[]{message, 206});
				this.add(typeof(EI), false, 1, 80, new System.Object[]{message});
				this.add(typeof(CE), true, 1, 250, new System.Object[]{message});
				this.add(typeof(XON), false, 0, 250, new System.Object[]{message});
				this.add(typeof(PL), false, 1, 80, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Organizational Location Relationship Value (LRL-5).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XON getOrganizationalLocationRelationshipValue(int rep)
		{
			XON ret = null;
			try
			{
				Type t = this.getField(5, rep);
				ret = (XON) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Organizational Location Relationship Value (LRL-5).</summary>
		public virtual XON[] getOrganizationalLocationRelationshipValue()
		{
			XON[] ret = null;
			try
			{
				Type[] t = this.getField(5);
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
	}
}