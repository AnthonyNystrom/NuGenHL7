using System;
using ProfileException = Genetibase.NuGenHL7.conf.NuGenProfileException;
namespace Genetibase.NuGenHL7.conf.spec.message
{
	
	/// <summary> An abstraction of the common features of Field, Component, and SubComponent.  </summary>
	/// <author>  Bryan Tripp
	/// </author>
	public class AbstractComponent
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
					SupportClass.PropertyChangingEventArgs ve7 = new SupportClass.PropertyChangingEventArgs("impNote", oldImpNote, value);


				}
				catch (System.Exception e)
				{
					throw new NuGenProfileException(null, e);
				}
				this.impNote = value;
				SupportClass.PropertyChangingEventArgs me7 = new SupportClass.PropertyChangingEventArgs("impNote", oldImpNote, value);


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
					SupportClass.PropertyChangingEventArgs ve8 = new SupportClass.PropertyChangingEventArgs("description", oldDescription, value);


				}
				catch (System.Exception e)
				{
					throw new NuGenProfileException(null, e);
				}
				this.description = value;
				SupportClass.PropertyChangingEventArgs me8 = new SupportClass.PropertyChangingEventArgs("description", oldDescription, value);


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
					SupportClass.PropertyChangingEventArgs ve9 = new SupportClass.PropertyChangingEventArgs("reference", oldReference, value);


				}
				catch (System.Exception e)
				{
					throw new NuGenProfileException(null, e);
				}
				this.reference = value;
				SupportClass.PropertyChangingEventArgs me9 = new SupportClass.PropertyChangingEventArgs("reference", oldReference, value);


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
					SupportClass.PropertyChangingEventArgs ve10 = new SupportClass.PropertyChangingEventArgs("predicate", oldPredicate, value);


				}
				catch (System.Exception e)
				{
					throw new NuGenProfileException(null, e);
				}
				this.predicate = value;
				SupportClass.PropertyChangingEventArgs me10 = new SupportClass.PropertyChangingEventArgs("predicate", oldPredicate, value);


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
					SupportClass.PropertyChangingEventArgs ve12 = new SupportClass.PropertyChangingEventArgs("name", oldName, value);


				}
				catch (System.Exception e)
				{
					throw new NuGenProfileException(null, e);
				}
				this.name = value;
				SupportClass.PropertyChangingEventArgs me12 = new SupportClass.PropertyChangingEventArgs("name", oldName, value);


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
					SupportClass.PropertyChangingEventArgs ve13 = new SupportClass.PropertyChangingEventArgs("usage", oldUsage, value);


				}
				catch (System.Exception e)
				{
					throw new NuGenProfileException(null, e);
				}
				this.usage = value;
				SupportClass.PropertyChangingEventArgs me13 = new SupportClass.PropertyChangingEventArgs("usage", oldUsage, value);


			}
			
		}

		virtual public System.String Datatype
		{
			get
			{
				return this.datatype;
			}
			
			set
			{
				System.String oldDatatype = this.datatype;
				try
				{
					SupportClass.PropertyChangingEventArgs ve14 = new SupportClass.PropertyChangingEventArgs("datatype", oldDatatype, value);


				}
				catch (System.Exception e)
				{
					throw new NuGenProfileException(null, e);
				}
				this.datatype = value;
				SupportClass.PropertyChangingEventArgs me14 = new SupportClass.PropertyChangingEventArgs("datatype", oldDatatype, value);


			}
			
		}

		virtual public long Length
		{
			get
			{
				return this.length;
			}
			
			set
			{
				long oldLength = this.length;
				try
				{
					SupportClass.PropertyChangingEventArgs ve15 = new SupportClass.PropertyChangingEventArgs("length", (long) oldLength, value);


				}
				catch (System.Exception e)
				{
					throw new NuGenProfileException(null, e);
				}
				this.length = value;
				SupportClass.PropertyChangingEventArgs me15 = new SupportClass.PropertyChangingEventArgs("length", (long) oldLength, value);


			}
			
		}

		virtual public System.String ConstantValue
		{
			get
			{
				return this.constantValue;
			}
			
			set
			{
				System.String oldConstantValue = this.constantValue;
				try
				{
					SupportClass.PropertyChangingEventArgs ve16 = new SupportClass.PropertyChangingEventArgs("constantValue", oldConstantValue, value);


				}
				catch (System.Exception e)
				{
					throw new NuGenProfileException(null, e);
				}
				this.constantValue = value;
				SupportClass.PropertyChangingEventArgs me16 = new SupportClass.PropertyChangingEventArgs("constantValue", oldConstantValue, value);


			}
			
		}

		virtual public System.String Table
		{
			get
			{
				return this.table;
			}
			
			set
			{
				System.String oldTable = this.table;
				try
				{
					SupportClass.PropertyChangingEventArgs ve17 = new SupportClass.PropertyChangingEventArgs("table", oldTable, value);


				}
				catch (System.Exception e)
				{
					throw new NuGenProfileException(null, e);
				}
				this.table = value;
				SupportClass.PropertyChangingEventArgs me17 = new SupportClass.PropertyChangingEventArgs("table", oldTable, value);


			}
			
		}
		
		/// <summary>Creates a new instance of AbstractComponent </summary>
		public AbstractComponent()
		{
			dataValues = new DataValue[0];
		}
		
		private System.String impNote;
		private System.String description;
		private System.String reference;
		private System.String predicate;
		private DataValue[] dataValues;
		private System.String name;
		private System.String usage;
		private System.String datatype;
		private long length;
		private System.String constantValue;
		private System.String table;
		
		/// <summary>Indexed getter for property dataValues.</summary>
		/// <param name="index">Index of the property.
		/// </param>
		/// <returns> Value of the property at <CODE>index</CODE>.
		/// </returns>
		public virtual DataValue getDataValues(int index)
		{
			return this.dataValues[index];
		}
		
		/// <summary>Indexed setter for property dataValues.</summary>
		/// <param name="index">Index of the property.
		/// </param>
		/// <param name="dataValues">New value of the property at <CODE>index</CODE>.
		/// 
		/// </param>
		/// <throws>  ProfileException </throws>
		public virtual void  setDataValues(int index, DataValue dataValue)
		{
			extendDataValuesList(index);
			DataValue oldDataValues = this.dataValues[index];
			this.dataValues[index] = dataValue;
			try
			{
				SupportClass.PropertyChangingEventArgs ve11 = new SupportClass.PropertyChangingEventArgs("dataValues", null, null);


			}
			catch (System.ArgumentOutOfRangeException vetoException)
			{
				this.dataValues[index] = oldDataValues;
				throw new NuGenProfileException(null, vetoException);
			}
			SupportClass.PropertyChangingEventArgs me11 = new SupportClass.PropertyChangingEventArgs("dataValues", null, null);


		}
		
		/// <summary>Makes data value list long enough to accommodate setter.  </summary>
		private void  extendDataValuesList(int index)
		{
			if (index >= this.dataValues.Length)
			{
				DataValue[] newCopy = new DataValue[index + 1];
				Array.Copy(this.dataValues, 0, newCopy, 0, this.dataValues.Length);
				this.dataValues = newCopy;
			}
		}
	}
}