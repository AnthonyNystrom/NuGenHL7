using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v24.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v24.group
{
	/// <summary> <p>Represents the SUR_P09_FACILITY_DETAIL Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: FAC (Facility) <b></b><br>
	/// 1: PDC (Product Detail Country) <b></b><br>
	/// 2: NTE (Notes and Comments) <b></b><br>
	/// </summary>
	[Serializable]
	public class SUR_P09_FACILITY_DETAIL:AbstractGroup
	{
		/// <summary> Returns FAC (Facility) - creates it if necessary</summary>
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
		/// <summary> Returns PDC (Product Detail Country) - creates it if necessary</summary>
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
		/// <summary> Returns NTE (Notes and Comments) - creates it if necessary</summary>
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
		
		/// <summary> Creates a new SUR_P09_FACILITY_DETAIL Group.</summary>
		public SUR_P09_FACILITY_DETAIL(Group parent, ModelClassFactory factory):base(parent, factory)
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