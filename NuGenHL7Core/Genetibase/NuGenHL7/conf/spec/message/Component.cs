using System;
using ProfileException = Genetibase.NuGenHL7.conf.NuGenProfileException;
namespace Genetibase.NuGenHL7.conf.spec.message
{
	
	/// <summary> The specification for a particular field component in a message profile.  </summary>
	/// <author>  Bryan Tripp
	/// </author>
	public class Component:AbstractComponent
	{
		/// <summary>Returns the number of subcomponents in this component </summary>
		virtual public int SubComponents
		{
			get
			{
				return this.components.Length;
			}
			
		}
		
		private SubComponent[] components;
		
		/// <summary>Creates a new instance of Component </summary>
		public Component()
		{
			components = new SubComponent[0];
		}
		
		/// <summary>Indexed getter for property components (index starts at 1 following HL7 convention).</summary>
		/// <param name="index">Index of the property (starts at 1 following HL7 convention).
		/// </param>
		/// <returns> Value of the property at <CODE>index</CODE>.
		/// </returns>
		public virtual SubComponent getSubComponent(int index)
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
		public virtual void  setSubComponent(int index, SubComponent component)
		{
			index--;
			extendChildList(index);
			SubComponent oldComponent = this.components[index];
			this.components[index] = component;
			try
			{
				SupportClass.PropertyChangingEventArgs ve22 = new SupportClass.PropertyChangingEventArgs("components", null, null);


			}
			catch (System.ArgumentOutOfRangeException vetoException)
			{
				this.components[index] = oldComponent;
				throw new NuGenProfileException(null, vetoException);
			}
			SupportClass.PropertyChangingEventArgs me22 = new SupportClass.PropertyChangingEventArgs("components", null, null);


		}
		
		/// <summary>Makes child list long enough to accommodate setter.  </summary>
		private void  extendChildList(int index)
		{
			if (index >= this.components.Length)
			{
				SubComponent[] newCopy = new SubComponent[index + 1];
				Array.Copy(this.components, 0, newCopy, 0, this.components.Length);
				this.components = newCopy;
			}
		}
	}
}