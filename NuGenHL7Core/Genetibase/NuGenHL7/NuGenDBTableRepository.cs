/// <summary>The contents of this file are subject to the Mozilla Public License Version 1.1 
/// (the "License"); you may not use this file except in compliance with the License. 
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
/// Software distributed under the License is distributed on an "AS IS" basis, 
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
/// specific language governing rights and limitations under the License. 
/// The Original Code is "DBTableRepository.java".  Description: 
/// "Implements TableRepository by looking up values from the default HL7
/// normative database" 
/// The Initial Developer of the Original Code is University Health Network. Copyright (C) 
/// 2001.  All Rights Reserved. 
/// Contributor(s): ______________________________________. 
/// Alternatively, the contents of this file may be used under the terms of the 
/// GNU General Public License (the  �GPL�), in which case the provisions of the GPL are 
/// applicable instead of those above.  If you wish to allow use of your version of this 
/// file only under the terms of the GPL and not to allow others to use your version 
/// of this file under the MPL, indicate your decision by deleting  the provisions above 
/// and replace  them with the notice and other provisions required by the GPL License.  
/// If you do not delete the provisions above, a recipient may use your version of 
/// this file under either the MPL or the GPL. 
/// </summary>
using System;
namespace Genetibase.NuGenHL7
{
	
	/// <summary> Implements TableRepository by looking up values from the default HL7
	/// normative database.  Values are cached after they are looked up once.  
	/// </summary>
	/// <author>  Bryan Tripp (bryan_tripp@sourceforge.net)
	/// </author>
	public class NuGenDBTableRepository:NuGenTableRepository
	{
		/// <summary> Returns a list of HL7 lookup tables that are defined in the normative database.  </summary>
		override public int[] Tables
		{
			get
			{
				if (this.tableList == null)
				{
					try
					{						
						System.Data.OleDb.OleDbConnection conn = NuGenNormativeDatabase.Instance.Connection;						
						System.Data.OleDb.OleDbCommand stmt = SupportClass.TransactionManager.manager.CreateStatement(conn);
						System.Data.OleDb.OleDbCommand temp_OleDbCommand;
						temp_OleDbCommand = stmt;
						temp_OleDbCommand.CommandText = "select distinct table_id from TableValues";
						System.Data.OleDb.OleDbDataReader rs = temp_OleDbCommand.ExecuteReader();
						int[] roomyList = new int[bufferSize];
						int c = 0;
						while (rs.Read())
						{
							roomyList[c++] = rs.GetInt32(1 - 1);
						}

						NuGenNormativeDatabase.Instance.returnConnection(conn);
						
						this.tableList = new int[c];
						Array.Copy(roomyList, 0, this.tableList, 0, c);
					}
					catch (System.Data.OleDb.OleDbException sqle)
					{						
						throw new NuGenLookupException("Can't get table list from database: " + sqle.Message);
					}
				}
				return this.tableList;
			}
			
		}
		
		private int[] tableList;		
		private System.Collections.Hashtable tables;		
		private int bufferSize = 3000; //max # of tables or values that can be cached at a time
		
		protected internal NuGenDBTableRepository()
		{
			tableList = null;			
			tables = new System.Collections.Hashtable();
		}
		
		/// <summary> Returns true if the given value exists in the given table.</summary>
		public override bool checkValue(int table, System.String value_Renamed)
		{
			bool exists = false;
			
			System.String[] values = this.getValues(table);
			
			int c = 0;
			while (c < values.Length && !exists)
			{
				if (value_Renamed.Equals(values[c++]))
					exists = true;
			}
			
			return exists;
		}
		
		/// <summary> Returns a list of the values for the given table in the normative database. </summary>
		public override System.String[] getValues(int table)
		{
			System.Int32 key = (System.Int32) table;
			System.String[] values = null;
			
			//see if the value list exists in the cache			
			System.Object o = this.tables[key];
			
			if (o != null)
			{
				values = (System.String[]) o;
			}
			else
			{
				//not cached yet ...
				int c;
				System.String[] roomyValues = new System.String[bufferSize];
				
				try
				{					
					System.Data.OleDb.OleDbConnection conn = NuGenNormativeDatabase.Instance.Connection;					
					System.Data.OleDb.OleDbCommand stmt = SupportClass.TransactionManager.manager.CreateStatement(conn);
					System.Text.StringBuilder sql = new System.Text.StringBuilder("select table_value from TableValues where table_id = ");
					sql.Append(table);					
					System.Data.OleDb.OleDbCommand temp_OleDbCommand;
					temp_OleDbCommand = stmt;
					temp_OleDbCommand.CommandText = sql.ToString();
					System.Data.OleDb.OleDbDataReader rs = temp_OleDbCommand.ExecuteReader();
					
					c = 0;
					while (rs.Read())
					{
						roomyValues[c++] = System.Convert.ToString(rs[1 - 1]);
					}
					
					NuGenNormativeDatabase.Instance.returnConnection(conn);
				}
				catch (System.Data.OleDb.OleDbException sqle)
				{					
					throw new NuGenLookupException("Couldn't look up values for table " + table + ": " + sqle.Message);
				}
				
				if (c == 0)
					throw new NuGenUndefinedTableException("No values found for table " + table);
				
				values = new System.String[c];
				Array.Copy(roomyValues, 0, values, 0, c);
				
				tables[key] = values;
			}
			
			return values;
		}
		
		/// <summary> Returns the description matching the table and value given.  As currently implemented
		/// this method performs a database call each time - caching should probably be added,
		/// although this method will probably not be used very often.   
		/// </summary>
		public override System.String getDescription(int table, System.String value_Renamed)
		{
			System.String description = null;
			
			System.Text.StringBuilder sql = new System.Text.StringBuilder("select Description from TableValues where table_id = ");
			sql.Append(table);
			sql.Append(" and table_value = '");
			sql.Append(value_Renamed);
			sql.Append("'");
			
			try
			{				
				System.Data.OleDb.OleDbConnection conn = NuGenNormativeDatabase.Instance.Connection;				
				System.Data.OleDb.OleDbCommand stmt = SupportClass.TransactionManager.manager.CreateStatement(conn);				
				System.Data.OleDb.OleDbCommand temp_OleDbCommand;
				temp_OleDbCommand = stmt;
				temp_OleDbCommand.CommandText = sql.ToString();
				System.Data.OleDb.OleDbDataReader rs = temp_OleDbCommand.ExecuteReader();
				if (rs.Read())
				{
					description = System.Convert.ToString(rs[1 - 1]);
				}
				else
				{
					throw new NuGenUnknownValueException("The value " + value_Renamed + " could not be found in the table " + table + " - SQL: " + sql.ToString());
				}
				NuGenNormativeDatabase.Instance.returnConnection(conn);
			}
			catch (System.Data.OleDb.OleDbException e)
			{
				throw new NuGenLookupException("Can't find value " + value_Renamed + " in table " + table, e);
			}
			
			return description;
		}
		
		//test 
		/*
		public static void main(String args[]) {
		try {
		Class.forName("sun.jdbc.odbc.JdbcOdbcDriver");
		System.setProperty("ca.on.uhn.hl7.database.url", "jdbc:odbc:hl7");
		
		DBTableRepository rep = new DBTableRepository();
		
		int[] tables = rep.getTables();
		for (int i = 0; i < tables.length; i++) {
		//System.out.println("Table " + i + ": " + tables[i]);
		}
		
		for (int c = 0; c < 10; c++) {
		int table = 1;
		String val = "M";
		long before = System.currentTimeMillis();
		boolean yep = rep.checkValue(table, val);
		long after = System.currentTimeMillis();
		System.out.println(val + " exists in table " + table + "? " + yep + " - checking took " + (after-before) + " ms");
		
		}
		
		for (int h = 0; h < 2; h++) {
		int table = 1;
		long before = System.currentTimeMillis();
		String[] vals = rep.getValues(table);
		long after = System.currentTimeMillis();
		for (int i = 0; i < vals.length; i++) {
		System.out.println("Value " + i + ": " + vals[i] + ": " + rep.getDescription(table, vals[i]));
		}
		
		System.out.println("That took " + (after-before) + " ms");
		}
		
		
		} catch (ClassNotFoundException cne) {
		cne.printStackTrace();
		} catch (LookupException le) {
		le.printStackTrace();
		} catch (UnknownValueException uve) {
		uve.printStackTrace();
		}
		}*/
		static NuGenDBTableRepository()
		{
		}
	}
}