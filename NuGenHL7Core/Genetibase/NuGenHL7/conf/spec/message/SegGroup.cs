using System;
using ProfileException = Genetibase.NuGenHL7.conf.NuGenProfileException;
namespace Genetibase.NuGenHL7.conf.spec.message
{
	
	/// <summary> A specification for a segment group in a conformance profile.  </summary>
	/// <author>  Bryan Tripp
	/// </author>
	public class SegGroup:AbstractSegmentContainer, ProfileStructure
	{
		[System.ComponentModel.Browsable(true)]


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
					SupportClass.PropertyChangingEventArgs ve38 = new SupportClass.PropertyChangingEventArgs("predicate", oldPredicate, value);


				}
				catch (System.Exception e)
				{
					throw new NuGenProfileException(null, e);
				}
				this.predicate = value;
				SupportClass.PropertyChangingEventArgs me38 = new SupportClass.PropertyChangingEventArgs("predicate", oldPredicate, value);


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
					SupportClass.PropertyChangingEventArgs ve39 = new SupportClass.PropertyChangingEventArgs("name", oldName, value);


				}
				catch (System.Exception e)
				{
					throw new NuGenProfileException(null, e);
				}
				this.name = value;
				SupportClass.PropertyChangingEventArgs me39 = new SupportClass.PropertyChangingEventArgs("name", oldName, value);


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
					SupportClass.PropertyChangingEventArgs ve40 = new SupportClass.PropertyChangingEventArgs("longName", oldLongName, value);


				}
				catch (System.Exception e)
				{
					throw new NuGenProfileException(null, e);
				}
				this.longName = value;
				SupportClass.PropertyChangingEventArgs me40 = new SupportClass.PropertyChangingEventArgs("longName", oldLongName, value);


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
					SupportClass.PropertyChangingEventArgs ve41 = new SupportClass.PropertyChangingEventArgs("usage", oldUsage, value);


				}
				catch (System.Exception e)
				{
					throw new NuGenProfileException(null, e);
				}
				this.usage = value;
				SupportClass.PropertyChangingEventArgs me41 = new SupportClass.PropertyChangingEventArgs("usage", oldUsage, value);


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
					SupportClass.PropertyChangingEventArgs ve42 = new SupportClass.PropertyChangingEventArgs("min", (short) oldMin, value);


				}
				catch (System.Exception e)
				{
					throw new NuGenProfileException(null, e);
				}
				this.min = value;
				SupportClass.PropertyChangingEventArgs me42 = new SupportClass.PropertyChangingEventArgs("min", (short) oldMin, value);


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
					SupportClass.PropertyChangingEventArgs ve43 = new SupportClass.PropertyChangingEventArgs("max", (short) oldMax, value);


				}
				catch (System.Exception e)
				{
					throw new NuGenProfileException(null, e);
				}
				this.max = value;
				SupportClass.PropertyChangingEventArgs me43 = new SupportClass.PropertyChangingEventArgs("max", (short) oldMax, value);


			}
			
		}
		
		private System.String predicate;
		private System.String name;
		private System.String longName;
		private System.String usage;
		private short min;
		private short max;
	}
}