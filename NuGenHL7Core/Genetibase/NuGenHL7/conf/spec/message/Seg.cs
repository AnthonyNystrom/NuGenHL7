using System;
using ProfileException = Genetibase.NuGenHL7.conf.NuGenProfileException;
namespace Genetibase.NuGenHL7.conf.spec.message
{
	
	/// <summary> A specification for a message segment in a conformance profile.  </summary>
	/// <author>  Bryan Tripp
	/// </author>
	public class Seg : ProfileStructure
	{
		[System.ComponentModel.Browsable(true)]


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
					SupportClass.PropertyChangingEventArgs ve28 = new SupportClass.PropertyChangingEventArgs("impNote", oldImpNote, value);


				}
				catch (System.Exception e)
				{
					throw new NuGenProfileException(null, e);
				}
				this.impNote = value;
				SupportClass.PropertyChangingEventArgs me28 = new SupportClass.PropertyChangingEventArgs("impNote", oldImpNote, value);


			}
			
		}

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
					SupportClass.PropertyChangingEventArgs ve29 = new SupportClass.PropertyChangingEventArgs("description", oldDescription, value);


				}
				catch (System.Exception e)
				{
					throw new NuGenProfileException(null, e);
				}
				this.description = value;
				SupportClass.PropertyChangingEventArgs me29 = new SupportClass.PropertyChangingEventArgs("description", oldDescription, value);


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
					SupportClass.PropertyChangingEventArgs ve30 = new SupportClass.PropertyChangingEventArgs("reference", oldReference, value);


				}
				catch (System.Exception e)
				{
					throw new NuGenProfileException(null, e);
				}
				this.reference = value;
				SupportClass.PropertyChangingEventArgs me30 = new SupportClass.PropertyChangingEventArgs("reference", oldReference, value);


			}
			
		}

		virtual public System.String Predicate
		{
			get
			{
				return this.predicate;
			}
			
			set
			{
				System.String oldPredicate = this.predicate;
				try
				{
					SupportClass.PropertyChangingEventArgs ve31 = new SupportClass.PropertyChangingEventArgs("predicate", oldPredicate, value);


				}
				catch (System.Exception e)
				{
					throw new NuGenProfileException(null, e);
				}
				this.predicate = value;
				SupportClass.PropertyChangingEventArgs me31 = new SupportClass.PropertyChangingEventArgs("predicate", oldPredicate, value);


			}
			
		}

		virtual public System.String Name
		{
			get
			{
				return this.name;
			}
			
			set
			{
				System.String oldName = this.name;
				try
				{
					SupportClass.PropertyChangingEventArgs ve33 = new SupportClass.PropertyChangingEventArgs("name", oldName, value);


				}
				catch (System.Exception e)
				{
					throw new NuGenProfileException(null, e);
				}
				this.name = value;
				SupportClass.PropertyChangingEventArgs me33 = new SupportClass.PropertyChangingEventArgs("name", oldName, value);


			}
			
		}

		virtual public System.String LongName
		{
			get
			{
				return this.longName;
			}
			
			set
			{
				System.String oldLongName = this.longName;
				try
				{
					SupportClass.PropertyChangingEventArgs ve34 = new SupportClass.PropertyChangingEventArgs("longName", oldLongName, value);


				}
				catch (System.Exception e)
				{
					throw new NuGenProfileException(null, e);
				}
				this.longName = value;
				SupportClass.PropertyChangingEventArgs me34 = new SupportClass.PropertyChangingEventArgs("longName", oldLongName, value);


			}
			
		}

		virtual public System.String Usage
		{
			get
			{
				return this.usage;
			}
			
			set
			{
				System.String oldUsage = this.usage;
				try
				{
					SupportClass.PropertyChangingEventArgs ve35 = new SupportClass.PropertyChangingEventArgs("usage", oldUsage, value);


				}
				catch (System.Exception e)
				{
					throw new NuGenProfileException(null, e);
				}
				this.usage = value;
				SupportClass.PropertyChangingEventArgs me35 = new SupportClass.PropertyChangingEventArgs("usage", oldUsage, value);


			}
			
		}

		virtual public short Min
		{
			get
			{
				return this.min;
			}
			
			set
			{
				short oldMin = this.min;
				try
				{
					SupportClass.PropertyChangingEventArgs ve36 = new SupportClass.PropertyChangingEventArgs("min", (short) oldMin, value);


				}
				catch (System.Exception e)
				{
					throw new NuGenProfileException(null, e);
				}
				this.min = value;
				SupportClass.PropertyChangingEventArgs me36 = new SupportClass.PropertyChangingEventArgs("min", (short) oldMin, value);


			}
			
		}

		virtual public short Max
		{
			get
			{
				return this.max;
			}
			
			set
			{
				short oldMax = this.max;
				try
				{
					SupportClass.PropertyChangingEventArgs ve37 = new SupportClass.PropertyChangingEventArgs("max", (short) oldMax, value);


				}
				catch (System.Exception e)
				{
					throw new NuGenProfileException(null, e);
				}
				this.max = value;
				SupportClass.PropertyChangingEventArgs me37 = new SupportClass.PropertyChangingEventArgs("max", (short) oldMax, value);


			}
			
		}
		/// <summary>Returns the number of fields in the segment </summary>
		virtual public int Fields
		{
			get
			{
				return this.fields.Length;
			}
			
		}

		private System.String impNote;
		private System.String description;
		private System.String reference;
		private System.String predicate;
		private Field[] fields;
		private System.String name;
		private System.String longName;
		private System.String usage;
		private short min;
		private short max;
		
		/// <summary>Indexed getter for property field (index starts at 1 following HL7 convention).</summary>
		/// <param name="index">Index of the property (starts at 1 following HL7 convention).
		/// </param>
		/// <returns> Value of the property at <CODE>index</CODE>.
		/// </returns>
		public virtual Field getField(int index)
		{
			return this.fields[index - 1];
		}
		
		/// <summary>Indexed setter for property field (index starts at 1 following HL7 convention).</summary>
		/// <param name="index">Index of the property (starts at 1 following HL7 convention).
		/// </param>
		/// <param name="field">New value of the property at <CODE>index</CODE>.
		/// 
		/// </param>
		/// <throws>  ProfileException </throws>
		public virtual void  setField(int index, Field field)
		{
			index--;
			extendChildList(index);
			Field oldField = this.fields[index];
			this.fields[index] = field;
			try
			{
				SupportClass.PropertyChangingEventArgs ve32 = new SupportClass.PropertyChangingEventArgs("fields", null, null);


			}
			catch (System.ArgumentOutOfRangeException vetoException)
			{
				this.fields[index] = oldField;
				throw new NuGenProfileException(null, vetoException);
			}
			SupportClass.PropertyChangingEventArgs me32 = new SupportClass.PropertyChangingEventArgs("fields", null, null);


		}
		
		/// <summary>Makes child list long enough to accommodate setter.  </summary>
		private void  extendChildList(int index)
		{
			if (index >= this.fields.Length)
			{
				Field[] newCopy = new Field[index + 1];
				Array.Copy(this.fields, 0, newCopy, 0, this.fields.Length);
				this.fields = newCopy;
			}
		}
	}
}