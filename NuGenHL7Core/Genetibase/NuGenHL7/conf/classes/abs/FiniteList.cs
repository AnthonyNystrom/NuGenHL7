/// <summary>The contents of this file are subject to the Mozilla Public License Version 1.1 
/// (the "License"); you may not use this file except in compliance with the License. 
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
/// Software distributed under the License is distributed on an "AS IS" basis, 
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
/// specific language governing rights and limitations under the License. 
/// The Original Code is "FiniteList.java".  Description: 
/// "Holds a group of repetitions for a given Profile and exercises cardinality constraints" 
/// The Initial Developer of the Original Code is University Health Network. Copyright (C) 
/// 2001.  All Rights Reserved. 
/// Contributor(s): James Agnew
/// Paul Brohman
/// Mitch Delachevrotiere
/// Shawn Dyck
/// Cory Metcalf 
/// </summary>
/// <summary>Alternatively, the contents of this file may be used under the terms of the 
/// GNU General Public License (the  ?GPL?), in which case the provisions of the GPL are 
/// applicable instead of those above.  If you wish to allow use of your version of this 
/// file only under the terms of the GPL and not to allow others to use your version 
/// of this file under the MPL, indicate your decision by deleting  the provisions above 
/// and replace  them with the notice and other provisions required by the GPL License.  
/// If you do not delete the provisions above, a recipient may use your version of 
/// this file under either the MPL or the GPL. 
/// </summary>
using System;
using Genetibase.NuGenHL7.conf.classes.exceptions;
namespace Genetibase.NuGenHL7.conf.classes.abs
{
	
	/// <summary>Holds a group of repetitions for a given Profile and exercises cardinality constraints</summary>
	/// <author>  <table><tr>James Agnew</tr>
	/// <tr>Paul Brohman</tr>
	/// <tr>Mitch Delachevrotiere</tr>
	/// <tr>Shawn Dyck</tr>
	/// <tr>Cory Metcalf</tr></table>
	/// </author>
	public class FiniteList
	{
		
		private System.Collections.ArrayList reps; // Stores the reps
		private int maxReps; // The maximum allowable number of reps	
		private int minReps; // The minimum allowable number of reps	
		private System.Type repType; // The type of repetition being stored here
		private System.Object underlyingObject; // The underlying HAPI object
		
		/// <summary>Constructor for FiniteList</summary>
		/// <param name="repType">the Class which is repeating
		/// </param>
		/// <param name="underlyingObject">the underlying object that the extending class represents
		/// </param>
		public FiniteList(System.Type repType, System.Object underlyingObject)
		{
			this.repType = repType;
			this.underlyingObject = underlyingObject;
			
			Repeatable firstRep = createRep(0);
			this.maxReps = firstRep.MaxReps;
			this.minReps = firstRep.MinReps;
			
			reps = new System.Collections.ArrayList();
			reps.Add(firstRep);
			createNewReps(maxReps);
		}
		
		/// <summary>Creates a new repetition</summary>
		/// <param name="rep">the number representing the number of repetitions
		/// </param>
		private void  createNewReps(int rep)
		{
			while (reps.Count <= rep)
				reps.Add(createRep(reps.Count));
		}
		
		/// <summary>Creates the repition</summary>
		/// <param name="rep">the number representing which repition
		/// </param>
		private Repeatable createRep(int rep)
		{
			try
			{
				System.Reflection.ConstructorInfo theCon = repType.GetConstructors()[0];
				Repeatable thisRep = (Repeatable) theCon.Invoke(new System.Object[]{underlyingObject, (System.Int32) rep});
				return thisRep;
			}
			catch (System.Reflection.TargetInvocationException e)
			{
				throw new ConformanceError("Error creating underlying repetition. This is a bug.\nError is: " + e.ToString() + "\n" + e.InnerException.Message);
			}
			catch (System.Exception e)
			{
				throw new ConformanceError("Error creating underlying repetition. This is a bug. Error is: " + e.ToString());
			}
		}
		
		/// <summary> Returns the desired repetition</summary>
		/// <param name="rep">The desired repetition number. Note that in accordance with the HL7 standard
		/// </param>
		/// <returns> The desired repetition
		/// </returns>
		/// <throws>  ConformanceException if repetition is not accessible </throws>
		public virtual Repeatable getRep(int rep)
		{
			if (rep < 1 || (maxReps != - 1 && maxReps < rep))
				throw new ConfRepException(maxReps, rep);
			
			rep--; // Decremented because HL7 standard wants 1-offset arrays
			createNewReps(rep); // Create new reps if needed
			
			return (Repeatable) reps[rep];
		}
	}
}