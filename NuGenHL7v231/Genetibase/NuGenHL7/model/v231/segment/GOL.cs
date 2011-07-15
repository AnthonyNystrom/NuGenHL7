using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v231.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v231.segment
{
	
	/// <summary> <p>Represents an HL7 GOL message segment. 
	/// This segment has the following fields:</p><p>
	/// GOL-1: Action Code (ID)<br> 
	/// GOL-2: Action Date/Time (TS)<br> 
	/// GOL-3: Goal ID (CE)<br> 
	/// GOL-4: Goal Instance ID (EI)<br> 
	/// GOL-5: Episode of Care ID (EI)<br> 
	/// GOL-6: Goal List Priority (NM)<br> 
	/// GOL-7: Goal Established Date/Time (TS)<br> 
	/// GOL-8: Expected Goal Achieve Date/Time (TS)<br> 
	/// GOL-9: Goal Classification (CE)<br> 
	/// GOL-10: Goal Management Discipline (CE)<br> 
	/// GOL-11: Current Goal Review Status (CE)<br> 
	/// GOL-12: Current Goal Review Date/Time (TS)<br> 
	/// GOL-13: Next Goal Review Date/Time (TS)<br> 
	/// GOL-14: Previous Goal Review Date/Time (TS)<br> 
	/// GOL-15: Goal Review Interval (TQ)<br> 
	/// GOL-16: Goal Evaluation (CE)<br> 
	/// GOL-17: Goal Evaluation Comment (ST)<br> 
	/// GOL-18: Goal Life Cycle Status (CE)<br> 
	/// GOL-19: Goal Life Cycle Status Date/Time (TS)<br> 
	/// GOL-20: Goal Target Type (CE)<br> 
	/// GOL-21: Goal Target Name (XPN)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class GOL:AbstractSegment
	{
		/// <summary> Returns Action Code (GOL-1).</summary>
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
		/// <summary> Returns Action Date/Time (GOL-2).</summary>
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
		/// <summary> Returns Goal ID (GOL-3).</summary>
		virtual public CE GoalID
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
		/// <summary> Returns Goal Instance ID (GOL-4).</summary>
		virtual public EI GoalInstanceID
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
		/// <summary> Returns Episode of Care ID (GOL-5).</summary>
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
		/// <summary> Returns Goal List Priority (GOL-6).</summary>
		virtual public NM GoalListPriority
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
		/// <summary> Returns Goal Established Date/Time (GOL-7).</summary>
		virtual public TS GoalEstablishedDateTime
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
		/// <summary> Returns Expected Goal Achieve Date/Time (GOL-8).</summary>
		virtual public TS ExpectedGoalAchieveDateTime
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
		/// <summary> Returns Goal Classification (GOL-9).</summary>
		virtual public CE GoalClassification
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(9, 0);
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
		/// <summary> Returns Goal Management Discipline (GOL-10).</summary>
		virtual public CE GoalManagementDiscipline
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
		/// <summary> Returns Current Goal Review Status (GOL-11).</summary>
		virtual public CE CurrentGoalReviewStatus
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(11, 0);
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
		/// <summary> Returns Current Goal Review Date/Time (GOL-12).</summary>
		virtual public TS CurrentGoalReviewDateTime
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(12, 0);
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
		/// <summary> Returns Next Goal Review Date/Time (GOL-13).</summary>
		virtual public TS NextGoalReviewDateTime
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(13, 0);
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
		/// <summary> Returns Previous Goal Review Date/Time (GOL-14).</summary>
		virtual public TS PreviousGoalReviewDateTime
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(14, 0);
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
		/// <summary> Returns Goal Review Interval (GOL-15).</summary>
		virtual public TQ GoalReviewInterval
		{
			get
			{
				TQ ret = null;
				try
				{
					Type t = this.getField(15, 0);
					ret = (TQ) t;
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
		/// <summary> Returns Goal Evaluation (GOL-16).</summary>
		virtual public CE GoalEvaluation
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(16, 0);
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
		/// <summary> Returns Goal Life Cycle Status (GOL-18).</summary>
		virtual public CE GoalLifeCycleStatus
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
		/// <summary> Returns Goal Life Cycle Status Date/Time (GOL-19).</summary>
		virtual public TS GoalLifeCycleStatusDateTime
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(19, 0);
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
		
		/// <summary> Creates a GOL (Goal Detail) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public GOL(Group parent, ModelClassFactory factory):base(parent, factory)
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
				this.add(typeof(CE), false, 1, 80, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 80, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 80, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(TQ), false, 1, 200, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 80, new System.Object[]{message});
				this.add(typeof(ST), false, 0, 300, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 80, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(CE), false, 0, 80, new System.Object[]{message});
				this.add(typeof(XPN), false, 0, 80, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Goal Evaluation Comment (GOL-17).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ST getGoalEvaluationComment(int rep)
		{
			ST ret = null;
			try
			{
				Type t = this.getField(17, rep);
				ret = (ST) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Goal Evaluation Comment (GOL-17).</summary>
		public virtual ST[] getGoalEvaluationComment()
		{
			ST[] ret = null;
			try
			{
				Type[] t = this.getField(17);
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
		
		/// <summary> Returns a single repetition of Goal Target Type (GOL-20).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getGoalTargetType(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(20, rep);
				ret = (CE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Goal Target Type (GOL-20).</summary>
		public virtual CE[] getGoalTargetType()
		{
			CE[] ret = null;
			try
			{
				Type[] t = this.getField(20);
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
		
		/// <summary> Returns a single repetition of Goal Target Name (GOL-21).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XPN getGoalTargetName(int rep)
		{
			XPN ret = null;
			try
			{
				Type t = this.getField(21, rep);
				ret = (XPN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Goal Target Name (GOL-21).</summary>
		public virtual XPN[] getGoalTargetName()
		{
			XPN[] ret = null;
			try
			{
				Type[] t = this.getField(21);
				ret = new XPN[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (XPN) t[i];
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