using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v231.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v231.segment
{
	
	/// <summary> <p>Represents an HL7 PRB message segment. 
	/// This segment has the following fields:</p><p>
	/// PRB-1: Action Code (ID)<br> 
	/// PRB-2: Action Date/Time (TS)<br> 
	/// PRB-3: Problem ID (CE)<br> 
	/// PRB-4: Problem Instance ID (EI)<br> 
	/// PRB-5: Episode of Care ID (EI)<br> 
	/// PRB-6: Problem List Priority (NM)<br> 
	/// PRB-7: Problem Established Date/Time (TS)<br> 
	/// PRB-8: Anticipated Problem Resolution Date/Time (TS)<br> 
	/// PRB-9: Actual Problem Resolution Date/Time (TS)<br> 
	/// PRB-10: Problem Classification (CE)<br> 
	/// PRB-11: Problem Management Discipline (CE)<br> 
	/// PRB-12: Problem Persistence (CE)<br> 
	/// PRB-13: Problem Confirmation Status (CE)<br> 
	/// PRB-14: Problem Life Cycle Status (CE)<br> 
	/// PRB-15: Problem Life Cycle Status Date/Time (TS)<br> 
	/// PRB-16: Problem Date of Onset (TS)<br> 
	/// PRB-17: Problem Onset Text (ST)<br> 
	/// PRB-18: Problem Ranking (CE)<br> 
	/// PRB-19: Certainty of Problem (CE)<br> 
	/// PRB-20: Probability of Problem (0-1) (NM)<br> 
	/// PRB-21: Individual Awareness of Problem (CE)<br> 
	/// PRB-22: Problem Prognosis (CE)<br> 
	/// PRB-23: Individual Awareness of Prognosis (CE)<br> 
	/// PRB-24: Family/Significant Other Awareness of Problem/Prognosis (ST)<br> 
	/// PRB-25: Security/Sensitivity (CE)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class PRB:AbstractSegment
	{
		/// <summary> Returns Action Code (PRB-1).</summary>
		virtual public ID ActionCode
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(1, 0);
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
		/// <summary> Returns Action Date/Time (PRB-2).</summary>
		virtual public TS ActionDateTime
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(2, 0);
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
		/// <summary> Returns Problem ID (PRB-3).</summary>
		virtual public CE ProblemID
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(3, 0);
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
		/// <summary> Returns Problem Instance ID (PRB-4).</summary>
		virtual public EI ProblemInstanceID
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
		/// <summary> Returns Episode of Care ID (PRB-5).</summary>
		virtual public EI EpisodeOfCareID
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
		/// <summary> Returns Problem List Priority (PRB-6).</summary>
		virtual public NM ProblemListPriority
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
		/// <summary> Returns Problem Established Date/Time (PRB-7).</summary>
		virtual public TS ProblemEstablishedDateTime
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(7, 0);
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
		/// <summary> Returns Anticipated Problem Resolution Date/Time (PRB-8).</summary>
		virtual public TS AnticipatedProblemResolutionDateTime
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
		/// <summary> Returns Actual Problem Resolution Date/Time (PRB-9).</summary>
		virtual public TS ActualProblemResolutionDateTime
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
		/// <summary> Returns Problem Classification (PRB-10).</summary>
		virtual public CE ProblemClassification
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
		/// <summary> Returns Problem Persistence (PRB-12).</summary>
		virtual public CE ProblemPersistence
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
		/// <summary> Returns Problem Confirmation Status (PRB-13).</summary>
		virtual public CE ProblemConfirmationStatus
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(13, 0);
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
		/// <summary> Returns Problem Life Cycle Status (PRB-14).</summary>
		virtual public CE ProblemLifeCycleStatus
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(14, 0);
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
		/// <summary> Returns Problem Life Cycle Status Date/Time (PRB-15).</summary>
		virtual public TS ProblemLifeCycleStatusDateTime
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(15, 0);
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
		/// <summary> Returns Problem Date of Onset (PRB-16).</summary>
		virtual public TS ProblemDateOfOnset
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(16, 0);
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
		/// <summary> Returns Problem Onset Text (PRB-17).</summary>
		virtual public ST ProblemOnsetText
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
		/// <summary> Returns Problem Ranking (PRB-18).</summary>
		virtual public CE ProblemRanking
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(18, 0);
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
		/// <summary> Returns Certainty of Problem (PRB-19).</summary>
		virtual public CE CertaintyOfProblem
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(19, 0);
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
		/// <summary> Returns Probability of Problem (0-1) (PRB-20).</summary>
		virtual public NM ProbabilityOfProblem
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(20, 0);
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
		/// <summary> Returns Individual Awareness of Problem (PRB-21).</summary>
		virtual public CE IndividualAwarenessOfProblem
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(21, 0);
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
		/// <summary> Returns Problem Prognosis (PRB-22).</summary>
		virtual public CE ProblemPrognosis
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(22, 0);
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
		/// <summary> Returns Individual Awareness of Prognosis (PRB-23).</summary>
		virtual public CE IndividualAwarenessOfPrognosis
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(23, 0);
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
		/// <summary> Returns Family/Significant Other Awareness of Problem/Prognosis (PRB-24).</summary>
		virtual public ST FamilySignificantOtherAwarenessOfProblemPrognosis
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(24, 0);
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
		/// <summary> Returns Security/Sensitivity (PRB-25).</summary>
		virtual public CE SecuritySensitivity
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(25, 0);
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
		
		/// <summary> Creates a PRB (Problem Detail) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public PRB(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(ID), true, 1, 2, new System.Object[]{message, 287});
				this.add(typeof(TS), true, 1, 26, new System.Object[]{message});
				this.add(typeof(CE), true, 1, 80, new System.Object[]{message});
				this.add(typeof(EI), true, 1, 60, new System.Object[]{message});
				this.add(typeof(EI), false, 1, 60, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 60, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 80, new System.Object[]{message});
				this.add(typeof(CE), false, 0, 80, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 80, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 80, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 80, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 80, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 80, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 5, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 80, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 80, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 80, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 200, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 80, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Problem Management Discipline (PRB-11).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getProblemManagementDiscipline(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(11, rep);
				ret = (CE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Problem Management Discipline (PRB-11).</summary>
		public virtual CE[] getProblemManagementDiscipline()
		{
			CE[] ret = null;
			try
			{
				Type[] t = this.getField(11);
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