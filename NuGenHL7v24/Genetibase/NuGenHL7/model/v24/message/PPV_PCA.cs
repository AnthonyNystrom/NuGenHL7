using System;
using Genetibase.NuGenHL7.model.v24.group;
using Genetibase.NuGenHL7.model.v24.segment;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using DefaultModelClassFactory = Genetibase.NuGenHL7.parser.NuGenDefaultModelClassFactory;
using AbstractMessage = Genetibase.NuGenHL7.model.AbstractMessage;
namespace Genetibase.NuGenHL7.model.v24.message
{
	
	/// <summary> <p>Represents a PPV_PCA message structure (see chapter 12). This structure contains the 
	/// following elements: </p>
	/// 0: MSH (Message Header) <b></b><br>
	/// 1: MSA (Message Acknowledgment) <b></b><br>
	/// 2: ERR (Error) <b>optional </b><br>
	/// 3: QAK (Query Acknowledgment) <b>optional </b><br>
	/// 4: QRD (Original-Style Query Definition) <b></b><br>
	/// 5: PPV_PCA_PATIENT (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class PPV_PCA:AbstractMessage
	{
		/// <summary> Returns MSH (Message Header) - creates it if necessary</summary>
		virtual public MSH MSH
		{
			get
			{
				MSH ret = null;
				try
				{
					ret = (MSH) this.get_Renamed("MSH");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns MSA (Message Acknowledgment) - creates it if necessary</summary>
		virtual public MSA MSA
		{
			get
			{
				MSA ret = null;
				try
				{
					ret = (MSA) this.get_Renamed("MSA");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns ERR (Error) - creates it if necessary</summary>
		virtual public ERR ERR
		{
			get
			{
				ERR ret = null;
				try
				{
					ret = (ERR) this.get_Renamed("ERR");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns QAK (Query Acknowledgment) - creates it if necessary</summary>
		virtual public QAK QAK
		{
			get
			{
				QAK ret = null;
				try
				{
					ret = (QAK) this.get_Renamed("QAK");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns QRD (Original-Style Query Definition) - creates it if necessary</summary>
		virtual public QRD QRD
		{
			get
			{
				QRD ret = null;
				try
				{
					ret = (QRD) this.get_Renamed("QRD");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of PPV_PCA_PATIENT </summary>
		virtual public int PATIENTReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("PATIENT").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new PPV_PCA Group with custom ModelClassFactory.</summary>
		public PPV_PCA(ModelClassFactory factory):base(factory)
		{
			init(factory);
		}
		
		/// <summary> Creates a new PPV_PCA Group with DefaultModelClassFactory. </summary>
		public PPV_PCA():base(new DefaultModelClassFactory())
		{
			init(new DefaultModelClassFactory());
		}
		
		private void  init(ModelClassFactory factory)
		{
			try
			{
				this.add(typeof(MSH), true, false);
				this.add(typeof(MSA), true, false);
				this.add(typeof(ERR), false, false);
				this.add(typeof(QAK), false, false);
				this.add(typeof(QRD), true, false);
				this.add(typeof(PPV_PCA_PATIENT), true, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of PPV_PCA_PATIENT (a Group object) - creates it if necessary</summary>
		public virtual PPV_PCA_PATIENT getPATIENT()
		{
			PPV_PCA_PATIENT ret = null;
			try
			{
				ret = (PPV_PCA_PATIENT) this.get_Renamed("PATIENT");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of PPV_PCA_PATIENT
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual PPV_PCA_PATIENT getPATIENT(int rep)
		{
			return (PPV_PCA_PATIENT) this.get_Renamed("PATIENT", rep);
		}
	}
}