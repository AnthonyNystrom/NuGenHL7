using System;
using ProfileException = Genetibase.NuGenHL7.conf.NuGenProfileException;
namespace Genetibase.NuGenHL7.conf.spec.message
{
	
	/// <summary> An abstraction of SegGroup and MessageProfile (both are containers for segment specs).  </summary>
	/// <author>  Bryan Tripp
	/// </author>
	public class AbstractSegmentContainer
	{
		[System.ComponentModel.Browsable(true)]


		virtual public System.String Description
		{
			get
			{
				return this.description;
			}
			
			set
			{
				System.String oldDescription = this.description;
				try
				{
					SupportClass.PropertyChangingEventArgs ve18 = new SupportClass.PropertyChangingEventArgs("description", oldDescription, value);


				}
				catch (System.Exception e)
				{
					throw new NuGenProfileException(null, e);
				}
				this.description = value;
				SupportClass.PropertyChangingEventArgs me18 = new SupportClass.PropertyChangingEventArgs("description", oldDescription, value);


			}
			
		}

		virtual public System.String Reference
		{
			get
			{
				return this.reference;
			}
			
			set
			{
				System.String oldReference = this.reference;
				try
				{
					SupportClass.PropertyChangingEventArgs ve19 = new SupportClass.PropertyChangingEventArgs("reference", oldReference, value);


				}
				catch (System.Exception e)
				{
					throw new NuGenProfileException(null, e);
				}
				this.reference = value;
				SupportClass.PropertyChangingEventArgs me19 = new SupportClass.PropertyChangingEventArgs("reference", oldReference, value);


			}
			
		}

		virtual public System.String ImpNote
		{
			get
			{
				return this.impNote;
			}
			
			set
			{
				System.String oldImpNote = this.impNote;
				try
				{
					SupportClass.PropertyChangingEventArgs ve20 = new SupportClass.PropertyChangingEventArgs("impNote", oldImpNote, value);


				}
				catch (System.Exception e)
				{
					throw new NuGenProfileException(null, e);
				}
				this.impNote = value;
				SupportClass.PropertyChangingEventArgs me20 = new SupportClass.PropertyChangingEventArgs("impNote", oldImpNote, value);


			}
			
		}
		/// <summary>Returns the number of children </summary>
		virtual public int Children
		{
			get
			{
				return this.children.Length;
			}
			
		}
		
		private System.String description;
		private System.String reference;
		private System.String impNote;
		private ProfileStructure[] children;
		
		/// <summary>Indexed getter for property structure (index starts at 1 following HL7 convention).</summary>
		/// <param name="index">Index of the property (starts at 1 following HL7 convention).
		/// </param>
		/// <returns> Value of the property at <CODE>index</CODE>.
		/// </returns>
		public virtual ProfileStructure getChild(int index)
		{
			return this.children[index - 1];
		}
		
		/// <summary>Indexed setter for property structure.  Lengthens child list if necessary.  </summary>
		/// <param name="index">Index of the property (starts at 1 following HL7 convention).
		/// </param>
		/// <param name="structure">New value of the property at <CODE>index</CODE>.
		/// 
		/// </param>
		/// <throws>  ProfileException </throws>
		public virtual void  setChild(int index, ProfileStructure structure)
		{
			index--;
			extendChildList(index);
			ProfileStructure oldStructure = this.children[index];
			this.children[index] = structure;
			try
			{
				SupportClass.PropertyChangingEventArgs ve21 = new SupportClass.PropertyChangingEventArgs("structure", null, null);


			}
			catch (System.ArgumentOutOfRangeException vetoException)
			{
				this.children[index] = oldStructure;
				throw new NuGenProfileException(null, vetoException);
			}
			SupportClass.PropertyChangingEventArgs me21 = new SupportClass.PropertyChangingEventArgs("structure", null, null);


		}
		
		/// <summary>Makes child list long enough to accommodate setter.  </summary>
		private void  extendChildList(int index)
		{
			if (index >= this.children.Length)
			{
				ProfileStructure[] newCopy = new ProfileStructure[index + 1];
				Array.Copy(this.children, 0, newCopy, 0, this.children.Length);
				this.children = newCopy;
			}
		}
	}
}