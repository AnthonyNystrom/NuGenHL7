using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v25.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v25.segment
{
	
	/// <summary> <p>Represents an HL7 SAC message segment. 
	/// This segment has the following fields:</p><p>
	/// SAC-1: External Accession Identifier (EI)<br> 
	/// SAC-2: Accession Identifier (EI)<br> 
	/// SAC-3: Container Identifier (EI)<br> 
	/// SAC-4: Primary (parent) Container Identifier (EI)<br> 
	/// SAC-5: Equipment Container Identifier (EI)<br> 
	/// SAC-6: Specimen Source (SPS)<br> 
	/// SAC-7: Registration Date/Time (TS)<br> 
	/// SAC-8: Container Status (CE)<br> 
	/// SAC-9: Carrier Type (CE)<br> 
	/// SAC-10: Carrier Identifier (EI)<br> 
	/// SAC-11: Position in Carrier (NA)<br> 
	/// SAC-12: Tray Type - SAC (CE)<br> 
	/// SAC-13: Tray Identifier (EI)<br> 
	/// SAC-14: Position in Tray (NA)<br> 
	/// SAC-15: Location (CE)<br> 
	/// SAC-16: Container Height (NM)<br> 
	/// SAC-17: Container Diameter (NM)<br> 
	/// SAC-18: Barrier Delta (NM)<br> 
	/// SAC-19: Bottom Delta (NM)<br> 
	/// SAC-20: Container Height/Diameter/Delta Units (CE)<br> 
	/// SAC-21: Container Volume (NM)<br> 
	/// SAC-22: Available Specimen Volume (NM)<br> 
	/// SAC-23: Initial Specimen Volume (NM)<br> 
	/// SAC-24: Volume Units (CE)<br> 
	/// SAC-25: Separator Type (CE)<br> 
	/// SAC-26: Cap Type (CE)<br> 
	/// SAC-27: Additive (CWE)<br> 
	/// SAC-28: Specimen Component (CE)<br> 
	/// SAC-29: Dilution Factor (SN)<br> 
	/// SAC-30: Treatment (CE)<br> 
	/// SAC-31: Temperature (SN)<br> 
	/// SAC-32: Hemolysis Index (NM)<br> 
	/// SAC-33: Hemolysis Index Units (CE)<br> 
	/// SAC-34: Lipemia Index (NM)<br> 
	/// SAC-35: Lipemia Index Units (CE)<br> 
	/// SAC-36: Icterus Index (NM)<br> 
	/// SAC-37: Icterus Index Units (CE)<br> 
	/// SAC-38: Fibrin Index (NM)<br> 
	/// SAC-39: Fibrin Index Units (CE)<br> 
	/// SAC-40: System Induced Contaminants (CE)<br> 
	/// SAC-41: Drug Interference (CE)<br> 
	/// SAC-42: Artificial Blood (CE)<br> 
	/// SAC-43: Special Handling Code (CWE)<br> 
	/// SAC-44: Other Environmental Factors (CE)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class SAC:AbstractSegment
	{
		/// <summary> Returns External Accession Identifier (SAC-1).</summary>
		virtual public EI ExternalAccessionIdentifier
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
		/// <summary> Returns Accession Identifier (SAC-2).</summary>
		virtual public EI AccessionIdentifier
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
		/// <summary> Returns Container Identifier (SAC-3).</summary>
		virtual public EI ContainerIdentifier
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
		/// <summary> Returns Primary (parent) Container Identifier (SAC-4).</summary>
		virtual public EI PrimaryParentContainerIdentifier
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
		/// <summary> Returns Equipment Container Identifier (SAC-5).</summary>
		virtual public EI EquipmentContainerIdentifier
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
		/// <summary> Returns Specimen Source (SAC-6).</summary>
		virtual public SPS SpecimenSource
		{
			get
			{
				SPS ret = null;
				try
				{
					Type t = this.getField(6, 0);
					ret = (SPS) t;
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
		/// <summary> Returns Registration Date/Time (SAC-7).</summary>
		virtual public TS RegistrationDateTime
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
		/// <summary> Returns Container Status (SAC-8).</summary>
		virtual public CE ContainerStatus
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(8, 0);
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
		/// <summary> Returns Carrier Type (SAC-9).</summary>
		virtual public CE CarrierType
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
		/// <summary> Returns Carrier Identifier (SAC-10).</summary>
		virtual public EI CarrierIdentifier
		{
			get
			{
				EI ret = null;
				try
				{
					Type t = this.getField(10, 0);
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
		/// <summary> Returns Position in Carrier (SAC-11).</summary>
		virtual public NA PositionInCarrier
		{
			get
			{
				NA ret = null;
				try
				{
					Type t = this.getField(11, 0);
					ret = (NA) t;
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
		/// <summary> Returns Tray Type - SAC (SAC-12).</summary>
		virtual public CE TrayTypeSAC
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
		/// <summary> Returns Tray Identifier (SAC-13).</summary>
		virtual public EI TrayIdentifier
		{
			get
			{
				EI ret = null;
				try
				{
					Type t = this.getField(13, 0);
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
		/// <summary> Returns Position in Tray (SAC-14).</summary>
		virtual public NA PositionInTray
		{
			get
			{
				NA ret = null;
				try
				{
					Type t = this.getField(14, 0);
					ret = (NA) t;
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
		/// <summary> Returns Container Height (SAC-16).</summary>
		virtual public NM ContainerHeight
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(16, 0);
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
		/// <summary> Returns Container Diameter (SAC-17).</summary>
		virtual public NM ContainerDiameter
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(17, 0);
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
		/// <summary> Returns Barrier Delta (SAC-18).</summary>
		virtual public NM BarrierDelta
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(18, 0);
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
		/// <summary> Returns Bottom Delta (SAC-19).</summary>
		virtual public NM BottomDelta
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(19, 0);
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
		/// <summary> Returns Container Height/Diameter/Delta Units (SAC-20).</summary>
		virtual public CE ContainerHeightDiameterDeltaUnits
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(20, 0);
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
		/// <summary> Returns Container Volume (SAC-21).</summary>
		virtual public NM ContainerVolume
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(21, 0);
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
		/// <summary> Returns Available Specimen Volume (SAC-22).</summary>
		virtual public NM AvailableSpecimenVolume
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(22, 0);
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
		/// <summary> Returns Initial Specimen Volume (SAC-23).</summary>
		virtual public NM InitialSpecimenVolume
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(23, 0);
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
		/// <summary> Returns Volume Units (SAC-24).</summary>
		virtual public CE VolumeUnits
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(24, 0);
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
		/// <summary> Returns Separator Type (SAC-25).</summary>
		virtual public CE SeparatorType
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
		/// <summary> Returns Cap Type (SAC-26).</summary>
		virtual public CE CapType
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(26, 0);
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
		/// <summary> Returns Specimen Component (SAC-28).</summary>
		virtual public CE SpecimenComponent
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(28, 0);
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
		/// <summary> Returns Dilution Factor (SAC-29).</summary>
		virtual public SN DilutionFactor
		{
			get
			{
				SN ret = null;
				try
				{
					Type t = this.getField(29, 0);
					ret = (SN) t;
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
		/// <summary> Returns Treatment (SAC-30).</summary>
		virtual public CE Treatment
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(30, 0);
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
		/// <summary> Returns Temperature (SAC-31).</summary>
		virtual public SN Temperature
		{
			get
			{
				SN ret = null;
				try
				{
					Type t = this.getField(31, 0);
					ret = (SN) t;
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
		/// <summary> Returns Hemolysis Index (SAC-32).</summary>
		virtual public NM HemolysisIndex
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(32, 0);
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
		/// <summary> Returns Hemolysis Index Units (SAC-33).</summary>
		virtual public CE HemolysisIndexUnits
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(33, 0);
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
		/// <summary> Returns Lipemia Index (SAC-34).</summary>
		virtual public NM LipemiaIndex
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(34, 0);
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
		/// <summary> Returns Lipemia Index Units (SAC-35).</summary>
		virtual public CE LipemiaIndexUnits
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(35, 0);
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
		/// <summary> Returns Icterus Index (SAC-36).</summary>
		virtual public NM IcterusIndex
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(36, 0);
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
		/// <summary> Returns Icterus Index Units (SAC-37).</summary>
		virtual public CE IcterusIndexUnits
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(37, 0);
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
		/// <summary> Returns Fibrin Index (SAC-38).</summary>
		virtual public NM FibrinIndex
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(38, 0);
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
		/// <summary> Returns Fibrin Index Units (SAC-39).</summary>
		virtual public CE FibrinIndexUnits
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(39, 0);
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
		/// <summary> Returns Artificial Blood (SAC-42).</summary>
		virtual public CE ArtificialBlood
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(42, 0);
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
		
		/// <summary> Creates a SAC (Specimen Container detail) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public SAC(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(EI), false, 1, 80, new System.Object[]{message});
				this.add(typeof(EI), false, 1, 80, new System.Object[]{message});
				this.add(typeof(EI), false, 1, 80, new System.Object[]{message});
				this.add(typeof(EI), false, 1, 80, new System.Object[]{message});
				this.add(typeof(EI), false, 1, 80, new System.Object[]{message});
				this.add(typeof(SPS), false, 1, 300, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(EI), false, 1, 80, new System.Object[]{message});
				this.add(typeof(NA), false, 1, 80, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(EI), false, 1, 80, new System.Object[]{message});
				this.add(typeof(NA), false, 1, 80, new System.Object[]{message});
				this.add(typeof(CE), false, 0, 250, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 20, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 20, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 20, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 20, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 20, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 20, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 20, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CWE), false, 0, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(SN), false, 1, 20, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(SN), false, 1, 20, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 20, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 20, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 20, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 20, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 0, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 0, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CWE), false, 0, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 0, 250, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Location (SAC-15).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getLocation(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(15, rep);
				ret = (CE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Location (SAC-15).</summary>
		public virtual CE[] getLocation()
		{
			CE[] ret = null;
			try
			{
				Type[] t = this.getField(15);
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
		
		/// <summary> Returns a single repetition of Additive (SAC-27).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CWE getAdditive(int rep)
		{
			CWE ret = null;
			try
			{
				Type t = this.getField(27, rep);
				ret = (CWE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Additive (SAC-27).</summary>
		public virtual CWE[] getAdditive()
		{
			CWE[] ret = null;
			try
			{
				Type[] t = this.getField(27);
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
		
		/// <summary> Returns a single repetition of System Induced Contaminants (SAC-40).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getSystemInducedContaminants(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(40, rep);
				ret = (CE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of System Induced Contaminants (SAC-40).</summary>
		public virtual CE[] getSystemInducedContaminants()
		{
			CE[] ret = null;
			try
			{
				Type[] t = this.getField(40);
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
		
		/// <summary> Returns a single repetition of Drug Interference (SAC-41).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getDrugInterference(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(41, rep);
				ret = (CE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Drug Interference (SAC-41).</summary>
		public virtual CE[] getDrugInterference()
		{
			CE[] ret = null;
			try
			{
				Type[] t = this.getField(41);
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
		
		/// <summary> Returns a single repetition of Special Handling Code (SAC-43).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CWE getSpecialHandlingCode(int rep)
		{
			CWE ret = null;
			try
			{
				Type t = this.getField(43, rep);
				ret = (CWE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Special Handling Code (SAC-43).</summary>
		public virtual CWE[] getSpecialHandlingCode()
		{
			CWE[] ret = null;
			try
			{
				Type[] t = this.getField(43);
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
		
		/// <summary> Returns a single repetition of Other Environmental Factors (SAC-44).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getOtherEnvironmentalFactors(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(44, rep);
				ret = (CE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Other Environmental Factors (SAC-44).</summary>
		public virtual CE[] getOtherEnvironmentalFactors()
		{
			CE[] ret = null;
			try
			{
				Type[] t = this.getField(44);
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