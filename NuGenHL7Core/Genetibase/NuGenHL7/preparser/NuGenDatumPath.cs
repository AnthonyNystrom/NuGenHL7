using System;
namespace Genetibase.NuGenHL7.preparser
{
	
	/// <summary>An object of this class represents a variable-size path for identifying
	/// the location of a datum within an HL7 message, which we can use for
	/// maintaining parser state and for generating a suitable string key (in the
	/// ZYX[a]-b[c]-d-e style) for a piece of data in the message (see toString()).
	/// The elements are: 
	/// segmentID / segmentRepIdx / fieldIdx / fieldRepIdx / compIdx / subcompIdx 
	/// ("rep" means "repetition")
	/// segmentID is a String, the rest are Integers.
	/// It is variable-size path-style in that if it has a size of 1, the one element
	/// will be the segmentID; if it has a size of two, element 0 will be the segmentID
	/// and element 1 will be the segmentRepIdx, etc.  This class can't represent a
	/// fieldIdx without having segmentID / segmentRepIdx, etc. etc. 
	/// possible sizes: 0 to 6 inclusive
	/// As toString() simply converts this's integer values to strings (1 => "1"), and
	/// since for some reason the ZYX[a]-b[c]-d-e style counts b, d, e starting from 1
	/// and a, c from 0 -- it is intended that one store the numeric values in this
	/// class starting from 1 for fieldIdx (element 2), compIdx (4) and subcompIdx
	/// (5), and from 0 for segmentRepIdx (1) and fieldRepIdx (3).  default values
	/// provided by setSize() and by toString() do this.
	/// </summary>
	public class NuGenDatumPath : System.ICloneable
	{
		
		public const int s_maxSize = 6;
		
		protected internal System.Collections.ArrayList m_path = null;
		
		public NuGenDatumPath()
		{
			m_path = System.Collections.ArrayList.Synchronized(new System.Collections.ArrayList(s_maxSize));
		}
		
		/// <summary>copy constructor </summary>
		public NuGenDatumPath(NuGenDatumPath other):this()
		{
			
			copy(other);
		}
		
		public  override bool Equals(System.Object otherObject)
		{
			bool ret = false;
			NuGenDatumPath other = (NuGenDatumPath) otherObject;
			if (this.size() == other.size())
			{
				ret = true;
				for (int i = 0; i < this.size(); ++i)
					ret &= this.get_Renamed(i).Equals(other.get_Renamed(i));
			}
			
			return ret;
		}
		
		/// <summary>Works like String.startsWith: 
		/// returns true iff prefix.size() <= this.size()
		/// AND if, for 0 <= i < prefix.size(), this.get(i).equals(prefix.get(i))
		/// </summary>
		public virtual bool startsWith(NuGenDatumPath prefix)
		{
			bool ret = false;
			if (prefix.size() <= this.size())
			{
				ret = true;
				for (int i = 0; i < prefix.size(); ++i)
					ret &= this.get_Renamed(i).Equals(prefix.get_Renamed(i));
			}
			return ret;
		}
		
		/// <summary>like a copy constructor without the constructor </summary>
		public virtual void  copy(NuGenDatumPath other)
		{
			setSize(0);
			for (int i = 0; i < other.size(); ++i)
				add(other.get_Renamed(i));
		}
		
		/// <summary>set() sets an element of the path.  </summary>
		/// <summary>idx must be in [0, size()). else => IndexOutOfBoundsException. 
		/// </summary>
		/// <summary>(new_value == null) => NullPointerException  
		/// new_value must be either a String or an Integer depending on what part 
		/// of the path you're setting:  
		/// (idx == 0) => String
		/// (idx >= 1) => Integer
		/// If new_value can't be cast to the appropriate type, a ClassCastException 
		/// is thrown before new_value is stored.
		/// Of course, on success, this will discard it's reference that used to be at
		/// position idx.
		/// </summary>
		public virtual void  set_Renamed(int idx, System.Object new_value)
		{
			if ((0 <= idx) && (idx < m_path.Count))
			{
				if (new_value != null)
				{
					if (idx == 0)
						m_path[idx] = (System.String) new_value;
					else if (idx >= 1)
						m_path[idx] = (System.Int32) new_value;
				}
				else
					throw new System.NullReferenceException();
			}
			else
				throw new System.IndexOutOfRangeException();
		}
		
		/// <summary>get() returns an element, which will be either a String or an Integer.
		/// ((idx == 0) => String
		/// (idx >= 1) => Integer
		/// ((idx < 0) || (idx >= size())) => IndexOutOfBoundsException
		/// We will attempt to cast the gotten object to the appropriate type before
		/// returning it as an Object.  That way, if there's an object of the wrong type
		/// in the wrong place in here (that got past set() somehow), then a
		/// ClassCastException will be thrown even if the caller of this function
		/// doesn't try to cast it.  (consider System.out.println("val: " + path.get(n))
		/// nothing would barf it this get() wasn't vigilant.)
		/// </summary>
		public virtual System.Object get_Renamed(int idx)
		{
			System.Object gottenObj = m_path[idx];
			if (idx == 0)
				return (System.String) gottenObj;
			else
				return (System.Object) gottenObj;
		}
		
		public virtual int size()
		{
			return m_path.Count;
		}
		
		/// <summary>toString() outputs the path (from segmentID onward) in the ZYX[a]-b[c]-d-e
		/// style (TODO: give it a name), suitable for a key in a map of 
		/// message datum paths to values. 
		/// </summary>
		/// <summary>Integer values are converted to strings directly (1 => "1") so when you
		/// constructed this you should have started counting from 1 for everything but
		/// the "repeat" fields, if you truly want the ZYX[a]-b[c]-d-e style.
		/// If toString() is called when this has a size in [1, 6) (=> missing numeric
		/// elments), then we act as though the elements in [size(), 6) are 0 or 1 as
		/// appropriate for each element.  We don't provide a default for the element 0
		/// (the String element): will throw an IndexOutOfBoundsException if (size() ==
		/// 1).
		/// eg. a (new DatumPath()).add(new String("ZYX")).add(2).add(6).toString() 
		/// would yield "ZYX[2]-6[0]-1-1"
		/// </summary>
		public override System.String ToString()
		{
			System.Text.StringBuilder strbuf = new System.Text.StringBuilder(15);
			
			if (m_path.Count >= 1)
			{
				NuGenDatumPath extendedCopy = (NuGenDatumPath) this.Clone();
				extendedCopy.setSize(s_maxSize);
				
				for (int i = 0; i < extendedCopy.size(); ++i)
				{
					if (i == 0)
						strbuf.Append("" + ((System.String) extendedCopy.get_Renamed(0)));
					else if ((i == 1) || (i == 3))
						strbuf.Append("[" + ((System.Int32) extendedCopy.get_Renamed(i)) + "]");
					else if ((i == 2) || (i == 4) || (i == 5))
						strbuf.Append("-" + (((System.Int32) extendedCopy.get_Renamed(i))));
				}
			}
			else
				throw new System.IndexOutOfRangeException();
			
			return "" + strbuf;
		}
		
		/// <summary>add() grows this by 1, inserting newValue at the end.
		/// newValue must be a String or an Integer depending on the index where it will
		/// be inserted, as noted at DatumPath.set().  
		/// returns this.
		/// (newValue == null) => NullPointerException 
		/// </summary>
		public virtual NuGenDatumPath add(System.Object newValue)
		{
			SupportClass.SetCapacity(m_path, m_path.Count + 1);
			set_Renamed(m_path.Count - 1, newValue);
			return this;
		}
		
		/// <summary>Like add(String).  convenient wrapper for add(Object), when the object
		/// to be added must be an Integer anyway (size() > 0 on entry).  
		/// For the user, it turns 
		/// path.add(new Integer(i)).add(new Integer(j)).add(new Integer(k)) 
		/// into 
		/// path.add(i).add(j).add(k), that's all.  
		/// size() == 0 on entry throws a ClassCastException (which it is, kindof), 
		/// otherwise calls add(new Integer(new_value)).
		/// </summary>
		public virtual NuGenDatumPath add(int new_value)
		{
			if (size() > 0)
				add((System.Object) new_value);
			else
				throw new System.InvalidCastException();
			
			return this;
		}
		
		/// <summary>convenience!  Like add(int), but the other way around. </summary>
		public virtual NuGenDatumPath add(System.String new_value)
		{
			if (size() == 0)
				add((System.Object) new_value);
			else
				throw new System.InvalidCastException();
			
			return this;
		}
		
		/// <summary>setSize(): resize.  If this will grow the object, then we put default
		/// values into the new elements: "" into the String element, Integer(1) into the
		/// elements 2, 4, and 5, and Integer(0) into elements 1 and 3.
		/// returns this.
		/// </summary>
		public virtual NuGenDatumPath setSize(int newSize)
		{
			int oldSize = m_path.Count;
			
			SupportClass.SetCapacity(m_path, newSize);
			
			if (newSize > oldSize)
			{
				// give the new elements some default values: 
				for (int i = oldSize; i < newSize; ++i)
				{
					if (i == 0)
						set_Renamed(i, "");
					else
						set_Renamed(i, (System.Object) ((i == 1 || i == 3)?0:1));
				}
			}
			
			return this;
		}
		
		/// <summary>setSize(0).  returns this. </summary>
		public virtual NuGenDatumPath clear()
		{
			setSize(0);
			return this;
		}
		
		public virtual System.Object Clone()
		{
			return new NuGenDatumPath(this);
		}
		
		/* Compare the numeric parts of "this" and "other".  string-style, start from
		the left: if this[1] < other[1], then return true, if this[1] > other[1] then
		return false, else repeat with [2] ... if we compare all elements, then return
		false (they're the same.)
		
		What are actually compared are copies of this and other that have been grown
		to s_maxSize (default values in effect), so they'll have the same size.
		
		This is just a little thing that gets used in the class XML.  Look there for 
		a justification of it's existence.
		
		ex. [1, 1, 1, 1] < [1, 1, 1, 2] 
		[1, 2, 1, 1] < [1, 2, 1, 2]
		[1, 1, 5, 5] < [1, 2]
		[1, 1] < [1, 1, 5, 5] 
		*/
		public virtual bool numbersLessThan(NuGenDatumPath other)
		{
			NuGenDatumPath extendedCopyThis = new NuGenDatumPath(this);
			extendedCopyThis.setSize(s_maxSize);
			
			NuGenDatumPath extendedCopyOther = new NuGenDatumPath(other);
			extendedCopyOther.setSize(s_maxSize);
			
			bool lessThan = false;
			for (int i = 1; !lessThan && (i < s_maxSize); ++i)
			{
				int this_i = ((System.Int32) extendedCopyThis.get_Renamed(i));
				int other_i = ((System.Int32) extendedCopyOther.get_Renamed(i));
				lessThan |= (this_i < other_i);
			}
			
			return lessThan;
		}
		
		[STAThread]
		public static void  Main(System.String[] args)
		{
			NuGenDatumPath dp = new NuGenDatumPath();
			dp.add(new System.Text.StringBuilder("ZYX").ToString());
			dp.add((System.Object) 42);
			
			NuGenDatumPath dp2 = (new NuGenDatumPath()).add(new System.Text.StringBuilder().ToString()).add(- 42);
			
			System.Console.Out.WriteLine(dp);
		}
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}
	}
}