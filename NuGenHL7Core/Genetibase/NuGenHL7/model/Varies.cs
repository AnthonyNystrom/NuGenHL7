/// <summary>The contents of this file are subject to the Mozilla Public License Version 1.1 
/// (the "License"); you may not use this file except in compliance with the License. 
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
/// Software distributed under the License is distributed on an "AS IS" basis, 
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
/// specific language governing rights and limitations under the License. 
/// The Original Code is "Varies.java".  Description: 
/// "Varies is a Type used as a placeholder for another Type in cases where 
/// the appropriate Type is not known until run-time (e.g" 
/// The Initial Developer of the Original Code is University Health Network. Copyright (C) 
/// 2001.  All Rights Reserved. 
/// Contributor(s): ______________________________________. 
/// Alternatively, the contents of this file may be used under the terms of the 
/// GNU General Public License (the  “GPL”), in which case the provisions of the GPL are 
/// applicable instead of those above.  If you wish to allow use of your version of this 
/// file only under the terms of the GPL and not to allow others to use your version 
/// of this file under the MPL, indicate your decision by deleting  the provisions above 
/// and replace  them with the notice and other provisions required by the GPL License.  
/// If you do not delete the provisions above, a recipient may use your version of 
/// this file under either the MPL or the GPL. 
/// </summary>
using System;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
namespace Genetibase.NuGenHL7.model
{
	
	/// <summary> <p>Varies is a Type used as a placeholder for another Type in cases where 
	/// the appropriate Type is not known until run-time (e.g. OBX-5).  
	/// Parsers and validators may have logic that enforces restrictions on the 
	/// Type based on other features of a segment.</p>  
	/// <p>If you want to set both the type and the values of a Varies object, you should
	/// set the type first by calling setData(Type t), keeping a reference to your Type, 
	/// and then set values by calling methods on the Type.  Here is an example:</p>
	/// <p><code>CN cn = new CN();<br>
	/// variesObject.setData(cn);<br>
	/// cn.getIDNumber().setValue("foo");</code></p>
	/// </summary>
	/// <author>  Bryan Tripp (bryan_tripp@users.sourceforge.net) 
	/// </author>
	[Serializable]
	public class Varies : Type
	{

		virtual public Type Data
		{
			get
			{
				return this.data;
			}
			
			set
			{
				if (this.data != null)
				{
					if (!(this.data is Primitive) || ((Primitive) this.data).Value != null)
					{
						Genetibase.NuGenHL7.util.NuGenDeepCopy.copy(this.data, value);
					}
				}
				this.data = value;
			}
			
		}
		/// <seealso cref="Type.getName">
		/// </seealso>
		virtual public System.String Name
		{
			get
			{
				System.String name = "*";
				if (this.data != null)
				{
					name = this.data.Name;
				}
				return name;
			}
			
		}
		/// <summary>Returns extra components from the underlying Type </summary>
		virtual public ExtraComponents ExtraComponents
		{
			get
			{
				return this.data.ExtraComponents;
			}
			
		}
		/// <returns> the message to which this Type belongs
		/// </returns>
		virtual public Message Message
		{
			get
			{
				return message;
			}
			
		}
		
		private Type data;
		private Message message;
		
		/// <summary> Creates new Varies. 
		/// 
		/// </summary>
		/// <param name="message">message to which this type belongs
		/// </param>
		public Varies(Message message)
		{
			data = new GenericPrimitive(message);
			this.message = message;
		}
		
		/// <summary> Sets the data type of field 5 in the given OBX segment to the value of OBX-2.  The argument 
		/// is a Segment as opposed to a particular OBX because it is meant to work with any version.  
		/// </summary>
		public static void  fixOBX5(Segment segment, ModelClassFactory factory)
		{
			try
			{
				//get unqualified class name
				Primitive obx2 = (Primitive) segment.getField(2, 0);
				Type[] reps = segment.getField(5);
				for (int i = 0; i < reps.Length; i++)
				{
					Varies v = (Varies) reps[i];
					if (obx2.Value == null)
					{
						if (v.Data != null)
						{
							if (!(v.Data is Primitive) || ((Primitive) v.Data).Value != null)
							{
								throw new NuGenHL7Exception("OBX-5 is valued, but OBX-2 is not.  A datatype for OBX-5 must be specified using OBX-2.", NuGenHL7Exception.REQUIRED_FIELD_MISSING);
							}
						}
					}
					else
					{
						//set class
						System.Type c = factory.getTypeClass(obx2.Value, segment.Message.Version);
						//                    Class c = Genetibase.NuGenHL7.parser.Parser.findClass(obx2.getValue(), 
						//                                                    segment.getMessage().getVersion(), 
						//                                                    "datatype");
						v.Data = (Type) c.GetConstructor(new System.Type[]{typeof(Message)}).Invoke(new System.Object[]{v.Message});
					}
				} // for reps
			}
			catch (NuGenHL7Exception e)
			{
				throw e;
			}
			catch (System.Exception e)
			{
				throw new NuGenHL7Exception(e.GetType().FullName + " trying to set data type of OBX-5", NuGenHL7Exception.APPLICATION_INTERNAL_ERROR, e);
			}
		}
		static Varies()
		{
		}
	}
}