using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v231.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v231.group
{
	/// <summary> <p>Represents the SUR_P09_FACPDCNTE Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: FAC (FAC - facility segment) <b></b><br>
	/// 1: PDC (PDC - product detail country segment) <b></b><br>
	/// 2: NTE (NTE - notes and comments segment) <b></b><br>
	/// </summary>
	[Serializable]
	public class SUR_P09_FACPDCNTE:AbstractGroup
	{
		/// <summary> Returns FAC (FAC - facility segment) - creates it if necessary</summary>
		virtual public FAC FAC
		{
			get
			{
				FAC ret = null;
				try
				{
					ret = (FAC) this.get_Renamed("FAC");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns PDC (PDC - product detail country segment) - creates it if necessary</summary>
		virtual public PDC PDC
		{
			get
			{
				PDC ret = null;
				try
				{
					ret = (PDC) this.get_Renamed("PDC");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns NTE (NTE - notes and comments segment) - creates it if necessary</summary>
		virtual public NTE NTE
		{
			get
			{
				NTE ret = null;
				try
				{
					ret = (NTE) this.get_Renamed("NTE");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		/// <summary> Creates a new SUR_P09_FACPDCNTE Group.</summary>
		public SUR_P09_FACPDCNTE(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(FAC), true, false);
				this.add(typeof(PDC), true, false);
				this.add(typeof(NTE), true, false);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}