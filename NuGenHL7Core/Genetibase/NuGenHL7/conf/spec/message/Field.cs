using System;
using ProfileException = Genetibase.NuGenHL7.conf.NuGenProfileException;
namespace Genetibase.NuGenHL7.conf.spec.message
{
	
	/// <summary> The specification for a specific field in a message profile.  </summary>
	/// <author>  Bryan Tripp
	/// </author>
	public class Field:AbstractComponent
	{
		[System.ComponentModel.Browsable(true)]


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
					SupportClass.PropertyChangingEventArgs ve24 = new SupportClass.PropertyChangingEventArgs("min", (short) oldMin, value);


				}
				catch (System.Exception e)
				{
					throw new NuGenProfileException(null, e);
				}
				this.min = value;
				SupportClass.PropertyChangingEventArgs me24 = new SupportClass.PropertyChangingEventArgs("min", (short) oldMin, value);

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
					SupportClass.PropertyChangingEventArgs ve25 = new SupportClass.PropertyChangingEventArgs("max", (short) oldMax, value);


				}
				catch (System.Exception e)
				{
					throw new NuGenProfileException(null, e);
				}
				this.max = value;
				SupportClass.PropertyChangingEventArgs me25 = new SupportClass.PropertyChangingEventArgs("max", (short) oldMax, value);

			}
			
		}

		virtual public short ItemNo
		{
			get
			{
				return this.itemNo;
			}
			
			set
			{
				short oldItemNo = this.itemNo;
				try
				{
					SupportClass.PropertyChangingEventArgs ve26 = new SupportClass.PropertyChangingEventArgs("itemNo", (short) oldItemNo, value);


				}
				catch (System.Exception e)
				{
					throw new NuGenProfileException(null, e);
				}
				this.itemNo = value;
				SupportClass.PropertyChangingEventArgs me26 = new SupportClass.PropertyChangingEventArgs("itemNo", (short) oldItemNo, value);


			}
			
		}
		/// <summary>Returns the number of components </summary>
		virtual public int Components
		{
			get
			{
				return this.components.Length;
			}
			
		}
		
		private short min;
		private short max;
		private short itemNo;
		
		private Component[] components;
		
		/// <summary>Indexed getter for property components (index starts at 1 following HL7 convention).</summary>
		/// <param name="index">Index of the property (starts at 1 following HL7 convention).
		/// </param>
		/// <returns> Value of the property at <CODE>index</CODE>.
		/// </returns>
		public virtual Component getComponent(int index)
		{
			return this.components[index - 1];
		}
		
		/// <summary>Indexed setter for property components (index starts at 1 following HL7 convention).</summary>
		/// <param name="index">Index of the property (starts at 1 following HL7 convention).
		/// </param>
		/// <param name="component">New value of the property at <CODE>index</CODE>.
		/// 
		/// </param>
		/// <throws>  ProfileException </throws>
		public virtual void  setComponent(int index, Component component)
		{
			index--;
			extendChildList(index);
			Component oldComponent = this.components[index];
			this.components[index] = component;
			try
			{
				SupportClass.PropertyChangingEventArgs ve27 = new SupportClass.PropertyChangingEventArgs("components", null, null);


			}
			catch (System.ArgumentOutOfRangeException vetoException)
			{
				this.components[index] = oldComponent;
				throw new NuGenProfileException(null, vetoException);
			}
			SupportClass.PropertyChangingEventArgs me27 = new SupportClass.PropertyChangingEventArgs("components", null, null);


		}
		
		/// <summary>Makes child list long enough to accommodate setter.  </summary>
		private void  extendChildList(int index)
		{
			if (index >= this.components.Length)
			{
				Component[] newCopy = new Component[index + 1];
				Array.Copy(this.components, 0, newCopy, 0, this.components.Length);
				this.components = newCopy;
			}
		}
	}
}