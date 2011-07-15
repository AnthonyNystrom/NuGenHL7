using System;
using DataTypeException = Genetibase.NuGenHL7.model.DataTypeException;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.util
{
	
	/// <summary> Tools for copying data recurvisely from one message element into another.  Currently only Types are 
	/// supported.  
	/// </summary>
	/// <author>  Bryan Tripp
	/// </author>
	public class NuGenDeepCopy
	{
		
		/// <summary> Copies data from the "from" Type into the "to" Type.  Either Type may be 
		/// a Primitive, Composite, or Varies.  If a Varies is provided, the operation is 
		/// performed on the result of calling its getData() method.  A Primitive may be 
		/// copied into a Composite, in which case the value is copied into the first 
		/// component of the Composite.  A Composite may be copied into a Primitive, 
		/// in which case the first component is copied.  Given Composites with different 
		/// numbers of components, the first components are copied, up to the length 
		/// of the smaller one.  
		/// </summary>
        public static void copy(Genetibase.NuGenHL7.model.Type from, Genetibase.NuGenHL7.model.Type to)
		{
			for (int i = 1; i <= NuGenTerser.numComponents(from); i++)
			{
				for (int j = 1; j <= NuGenTerser.numSubComponents(from, i); j++)
				{
					System.String val = NuGenTerser.getPrimitive(from, i, j).Value;
					NuGenTerser.getPrimitive(to, i, j).Value = val;
				}
			}
		}
		
		/*    if (from instanceof Varies) {
		from = ((Varies) from).getData();
		}        
		if (to instanceof Varies) {
		to = ((Varies) to).getData();
		}
		if (from instanceof Primitive) {
		if (to instanceof Primitive) {
		copy((Primitive) from, (Primitive) to);
		} else {
		copy((Primitive) from, (Composite) to);                
		}
		} else {
		if (to instanceof Primitive) {
		copy((Composite) from, (Primitive) to);                
		} else {
		copy((Composite) from, (Composite) to);                
		}            
		}
		}*/
		
		/// <summary>Copies a primitive to a primitive </summary>
		/*private static void copy(Primitive from, Primitive to) throws DataTypeException {
		to.setValue(from.getValue());
		}*/
		
		/// <summary>Copies composite to composite - could be different # of components (extras either way are ignored) </summary>
		/*private static void copy(Composite from, Composite to) throws DataTypeException {
		Type[] froms = from.getComponents();
		Type[] tos = to.getComponents();
		int limit = Math.min(froms.length, tos.length);
		for (int i = 0; i < limit; i++) {
		copy(froms[i], tos[i]);
		}
		}*/
		
		/// <summary>Copies primitive to first component of composite.  </summary>
		/*private static void copy(Primitive from, Composite to) throws DataTypeException {
		Type firstComponent = to.getComponent(0);
		copy(from, firstComponent);
		}*/
		
		/// <summary>Copies first component of composite to a primitive </summary>
		/*private static void copy(Composite from, Primitive to) throws DataTypeException {
		Type firstComponent = from.getComponent(0);
		copy(firstComponent, to);
		}*/
		
		/// <summary> Copies contents from the source segment to the destination segment.  This 
		/// method calls copy(Type, Type) on each repetition of each field (see additional 
		/// behavioural description there).  An attempt is made to copy each repetition of 
		/// each field in the source segment, regardless of whether the corresponding 
		/// destination field is repeating or even exists.  
		/// </summary>
		/// <param name="from">the segment from which data are copied 
		/// </param>
		/// <param name="to">the segment into which data are copied
		/// </param>
		public static void  copy(Segment from, Segment to)
		{
			int n = from.numFields();
			for (int i = 1; i <= n; i++)
			{
				Genetibase.NuGenHL7.model.Type[] reps = from.getField(i);
				for (int j = 0; j < reps.Length; j++)
				{
					copy(reps[j], to.getField(i, j));
				}
			}
		}
	}
}