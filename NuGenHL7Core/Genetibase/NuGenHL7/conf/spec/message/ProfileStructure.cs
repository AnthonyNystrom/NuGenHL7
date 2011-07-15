using System;
using ProfileException = Genetibase.NuGenHL7.conf.NuGenProfileException;
namespace Genetibase.NuGenHL7.conf.spec.message
{
	
	/// <summary> A message profile Segment or SegGroup. </summary>
	/// <author>  Bryan Tripp
	/// </author>
	public interface ProfileStructure
	{
		/// <summary>Getter for property name.</summary>
		/// <returns> Value of property name.
		/// </returns>
		/// <summary>Setter for property name.</summary>
		/// <param name="name">New value of property name.
		/// 
		/// </param>
		/// <throws>  ProfileException </throws>
		System.String Name
		{
			get;
			
			set;
			
		}
		/// <summary>Getter for property longName.</summary>
		/// <returns> Value of property longName.
		/// </returns>
		/// <summary>Setter for property longName.</summary>
		/// <param name="longName">New value of property longName.
		/// 
		/// </param>
		/// <throws>  ProfileException </throws>
		System.String LongName
		{
			get;
			
			set;
			
		}
		/// <summary>Getter for property usage.</summary>
		/// <returns> Value of property usage.
		/// </returns>
		/// <summary>Setter for property usage.</summary>
		/// <param name="usage">New value of property usage.
		/// 
		/// </param>
		/// <throws>  ProfileException </throws>
		System.String Usage
		{
			get;
			
			set;
			
		}
		/// <summary>Getter for property min.</summary>
		/// <returns> Value of property min.
		/// </returns>
		/// <summary>Setter for property min.</summary>
		/// <param name="min">New value of property min.
		/// 
		/// </param>
		/// <throws>  ProfileException </throws>
		short Min
		{
			get;
			
			set;
			
		}
		/// <summary>Getter for property max.</summary>
		/// <returns> Value of property max.
		/// </returns>
		/// <summary>Setter for property max.</summary>
		/// <param name="max">New value of property max.
		/// 
		/// </param>
		/// <throws>  ProfileException </throws>
		short Max
		{
			get;
			
			set;
			
		}
		/// <summary>Getter for property impNote.</summary>
		/// <returns> Value of property impNote.
		/// </returns>
		/// <summary>Setter for property impNote.</summary>
		/// <param name="impNote">New value of property impNote.
		/// 
		/// </param>
		/// <throws>  ProfileException </throws>
		System.String ImpNote
		{
			get;
			
			set;
			
		}
		/// <summary>Getter for property description.</summary>
		/// <returns> Value of property description.
		/// </returns>
		/// <summary>Setter for property description.</summary>
		/// <param name="description">New value of property description.
		/// 
		/// </param>
		/// <throws>  ProfileException </throws>
		System.String Description
		{
			get;
			
			set;
			
		}
		/// <summary>Getter for property reference.</summary>
		/// <returns> Value of property reference.
		/// </returns>
		/// <summary>Setter for property reference.</summary>
		/// <param name="reference">New value of property reference.
		/// 
		/// </param>
		/// <throws>  ProfileException </throws>
		System.String Reference
		{
			get;
			
			set;
			
		}
		/// <summary>Getter for property predicate.</summary>
		/// <returns> Value of property predicate.
		/// </returns>
		/// <summary>Setter for property predicate.</summary>
		/// <param name="predicate">New value of property predicate.
		/// 
		/// </param>
		/// <throws>  ProfileException </throws>
		System.String Predicate
		{
			get;
			
			set;
			
		}
	}
}