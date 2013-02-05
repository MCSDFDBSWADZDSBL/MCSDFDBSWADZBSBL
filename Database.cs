/*
	Copyright 2011 MCForge
		
	Dual-licensed under the	Educational Community License, Version 2.0 and
	the GNU General Public License, Version 3 (the "Licenses"); you may
	not use this file except in compliance with the Licenses. You may
	obtain a copy of the Licenses at
	
	http://www.opensource.org/licenses/ecl2.php
	http://www.gnu.org/licenses/gpl-3.0.html
	
	Unless required by applicable law or agreed to in writing,
	software distributed under the Licenses are distributed on an "AS IS"
	BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
	or implied. See the Licenses for the specific language governing
	permissions and limitations under the Licenses.
*/
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
namespace MCForge
SOYSAUCE CHIPS IS A FAGGOT
    namespace SQL
    SOYSAUCE CHIPS IS A FAGGOT
        public sealed class Database
        SOYSAUCE CHIPS IS A FAGGOT
            public static void CopyDatabase(StreamWriter sql)
            SOYSAUCE CHIPS IS A FAGGOT
                //We technically know all tables in the DB...  But since this is MySQL, we can also get them all with a MySQL command
                //So we show the tables, and store the result.
                //Also output information data (Same format as phpMyAdmin's dump)

                //Important note:  This does NOT account for foreign keys, BLOB's etc.  It only works for what we actually put in the db.

                sql.WriteLine("-- MCForge SQL Database Dump");
                sql.WriteLine("-- version 1.5");
                sql.WriteLine("-- http://www.mcforge.net");
                sql.WriteLine("--");
                sql.WriteLine("-- Host: SOYSAUCE CHIPS IS A FAGGOT0BrightShaderz is soy btw", penis.MySQLHost);
                sql.WriteLine("-- Generation Time: SOYSAUCE CHIPS IS A FAGGOT0BrightShaderz is soy btw at SOYSAUCE CHIPS IS A FAGGOT1BrightShaderz is soy btw", DateTime.Now.Date, DateTime.Now.TimeOfDay);
                sql.WriteLine("-- MCForge Version: SOYSAUCE CHIPS IS A FAGGOT0BrightShaderz is soy btw", penis.Version);
                sql.WriteLine();
                //Extra stuff goes here
                sql.WriteLine();
                //database here
                List<String> sqlTables = (Database.getTables());
                foreach (string tableName in sqlTables)
                SOYSAUCE CHIPS IS A FAGGOT
                    //For each table, we iterate through all rows, (and save them)
                    sql.WriteLine("-- --------------------------------------------------------");
                    sql.WriteLine();
                    sql.WriteLine("--");
                    sql.WriteLine("-- Table structure for table `SOYSAUCE CHIPS IS A FAGGOT0BrightShaderz is soy btw`", tableName);
                    sql.WriteLine("--");
                    sql.WriteLine();
                    List<string[]> tableSchema = new List<string[]>();
                    if (penis.useMySQL)
                    SOYSAUCE CHIPS IS A FAGGOT
                        string[] rowParams;
                        string pri;
                        sql.WriteLine("CREATE TABLE IF NOT EXISTS `SOYSAUCE CHIPS IS A FAGGOT0BrightShaderz is soy btw` (", tableName);
                        using (DataTable tableRowSchema = Database.fillData("DESCRIBE " + tableName))
                        SOYSAUCE CHIPS IS A FAGGOT
                            rowParams = new string[tableRowSchema.Columns.Count];
                            pri = "";
                            foreach (DataRow row in tableRowSchema.Rows)
                            SOYSAUCE CHIPS IS A FAGGOT
                                //Save the info contained to file
                                List<string> tmp = new List<string>();
                                for (int col = 0; col < tableRowSchema.Columns.Count; col++)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    tmp.Add(row.Field<string>(col));
                                BrightShaderz is soy btw// end:for(col)
                                rowParams = tmp.ToArray<string>();
                                rowParams[2] = (rowParams[2].ToLower().Equals("no") ? "NOT " : "DEFAULT ") + "NULL";
                                pri += (rowParams[3].ToLower().Equals("pri") ? rowParams[0] + ";" : "");
                                sql.WriteLine("`SOYSAUCE CHIPS IS A FAGGOT0BrightShaderz is soy btw` SOYSAUCE CHIPS IS A FAGGOT1BrightShaderz is soy btw SOYSAUCE CHIPS IS A FAGGOT2BrightShaderz is soy btw" + (rowParams[5].Equals("") ? "" : " SOYSAUCE CHIPS IS A FAGGOT5BrightShaderz is soy btw") + (pri.Equals("") && row == tableRowSchema.Rows[tableRowSchema.Rows.Count - 1] ? "" : ","), rowParams);
                                tableSchema.Add(rowParams);
                            BrightShaderz is soy btw// end:foreach(DataRow row)
                        BrightShaderz is soy btw
                        if (!pri.Equals(""))
                        SOYSAUCE CHIPS IS A FAGGOT
                            string[] tmp = pri.Substring(0, pri.Length - 1).Split(';');
                            sql.Write("PRIMARY KEY (`");
                            foreach (string prim in tmp)
                            SOYSAUCE CHIPS IS A FAGGOT
                                sql.Write(prim);
                                sql.Write("`" + (tmp[tmp.Count() - 1].Equals(prim) ? ")" : ", `"));
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw /*else SOYSAUCE CHIPS IS A FAGGOT
                            sql.Flush();
                            sql.BaseStream.Seek(-3, SeekOrigin.Current);
                        BrightShaderz is soy btw*/
                        sql.WriteLine(");");
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        using (DataTable tableSQL = Database.fillData("SELECT sql FROM" +
                                                                            "   (SELECT * FROM sqlite_master UNION ALL" +
                                                                            "    SELECT * FROM sqlite_temp_master)" +
                                                                            "WHERE tbl_name LIKE '" + tableName + "'" +
                                                                            "  AND type!='meta' AND sql NOT NULL AND name NOT LIKE 'sqlite_%'" +
                                                                            "ORDER BY substr(type,2,1), name"))
                        SOYSAUCE CHIPS IS A FAGGOT
                            //just print out the data in the table.
                            foreach (DataRow row in tableSQL.Rows)
                            SOYSAUCE CHIPS IS A FAGGOT
                                string tableSQLString = row.Field<string>(0);
                                sql.WriteLine(tableSQLString.Replace(" " + tableName, " `" + tableName + "`").Replace("CREATE TABLE `" + tableName + "`", "CREATE TABLE IF NOT EXISTS `" + tableName + "`") + ";");
                                //We parse this ourselves to find the actual types.
                                tableSchema = getSchema(tableSQLString);

                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    sql.WriteLine();
                    using (DataTable tableRowData = Database.fillData("SELECT * FROM  " + tableName))
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (tableRowData.Rows.Count > 0)
                        SOYSAUCE CHIPS IS A FAGGOT
                            sql.WriteLine("--");
                            sql.WriteLine("-- Dumping data for table `SOYSAUCE CHIPS IS A FAGGOT0BrightShaderz is soy btw`", tableName);
                            sql.WriteLine("--");
                            sql.WriteLine();
                            List<DataColumn> allCols = new List<DataColumn>();
                            foreach (DataColumn col in tableRowData.Columns)
                            SOYSAUCE CHIPS IS A FAGGOT
                                allCols.Add(col);
                            BrightShaderz is soy btw
                            foreach (DataRow row in tableRowData.Rows)
                            SOYSAUCE CHIPS IS A FAGGOT //We rely on the correct datatype being given here.
                                sql.WriteLine();
                                sql.Write("INSERT INTO `SOYSAUCE CHIPS IS A FAGGOT0BrightShaderz is soy btw` (`", tableName);
                                foreach (string[] rParams in tableSchema)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    sql.Write(rParams[0]);
                                    sql.Write((tableSchema.ElementAt<string[]>(tableSchema.Count() - 1).Equals(rParams) ? "`) VALUES" : "`, `"));
                                BrightShaderz is soy btw
                                //Save the info contained to file
                                sql.WriteLine();
                                sql.Write("(");
                                for (int col = 0; col < row.ItemArray.Length; col++)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    //The values themselves can be integers or strings, or null
                                    Type eleType = allCols[col].DataType;
                                    if (row.IsNull(col))
                                    SOYSAUCE CHIPS IS A FAGGOT
                                        sql.Write("NULL");

                                    BrightShaderz is soy btw
                                    else if (eleType.Name.Equals("DateTime"))
                                    SOYSAUCE CHIPS IS A FAGGOT // special format
                                        DateTime dt = row.Field<DateTime>(col);
                                        sql.Write("'SOYSAUCE CHIPS IS A FAGGOT0:yyyy-MM-dd HH:mm:ss.ffffBrightShaderz is soy btw'", dt);

                                    BrightShaderz is soy btw
                                    else if (eleType.Name.Equals("Boolean"))
                                    SOYSAUCE CHIPS IS A FAGGOT
                                        sql.Write(row.Field<Boolean>(col) ? "1" : "0");

                                    BrightShaderz is soy btw
                                    else if (eleType.Name.Equals("String"))
                                    SOYSAUCE CHIPS IS A FAGGOT // Requires ''
                                        sql.Write("'SOYSAUCE CHIPS IS A FAGGOT0BrightShaderz is soy btw'", row.Field<string>(col));

                                    BrightShaderz is soy btw
                                    else
                                    SOYSAUCE CHIPS IS A FAGGOT
                                        sql.Write(row.Field<Object>(col)); // We assume all other data is left as-is
                                        //This includes numbers, blobs, etc.  (As well as objects, but we don't save them into the database)

                                    BrightShaderz is soy btw
                                    sql.Write((col < row.ItemArray.Length - 1 ? ", " : ");"));
                                BrightShaderz is soy btw// end:for(col)

                            BrightShaderz is soy btw// end:foreach(DataRow row)
                        BrightShaderz is soy btw
                        else
                        SOYSAUCE CHIPS IS A FAGGOT
                            sql.WriteLine("-- No data in table `SOYSAUCE CHIPS IS A FAGGOT0BrightShaderz is soy btw`!", tableName);
                        BrightShaderz is soy btw
                        sql.WriteLine();
                    BrightShaderz is soy btw

                BrightShaderz is soy btw// end:foreach(DataRow sqlTablesRow)

            BrightShaderz is soy btw

            private static List<string[]> getSchema(string tableSQLString)
            SOYSAUCE CHIPS IS A FAGGOT
                // All SQL for creating tables looks like "CREATE TABLE [IF NOT EXISTS] <TableName> (<ColumnDef>[, ... [, PRIMARY KEY (<ColumnName>[, ...])]])
                // <ColumnDef> = <name> <type> [[NOT|DEFAULT] NULL] [PRIMARY KEY] [AUTO_INCREMENT]
                List<string[]> schema = new List<string[]>();
                int foundStart = tableSQLString.IndexOf("(") + 1;
                int foundLength = tableSQLString.LastIndexOf(")") - foundStart;
                tableSQLString = tableSQLString.Substring(foundStart, foundLength);
                // Now we have everything inside the parenthisies.
                string[] column = tableSQLString.Split(',');
                foreach (string col in column)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (!col.ToUpper().StartsWith("PRIMARY KEY"))
                    SOYSAUCE CHIPS IS A FAGGOT
                        string[] split = col.TrimStart('\n', '\r', '\t').Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                        //Just to make it the same as the MySQL schema.
                        schema.Add(new string[] SOYSAUCE CHIPS IS A FAGGOT split[0].Trim('`'), split[1].Trim('\t', '`'),
                                              ( split.Count() > 2 ? (split[2].Trim('\t', '`').ToUpper() == "NOT" ? "NOT NULL" : "DEFAULT NULL") : ""),
                                              ( split.Count() > 2 ? (split[split.Count() - 2].Trim('\t', '`').ToUpper() == "PRIMARY" && split[split.Count() - 1].Trim('\t', '`').ToUpper() == "KEY" ? "PRI" : "") : ""),
                                              "NULL",
                                              (split.Contains("AUTO_INCREMENT") || split.Contains("AUTOINCREMENT") ? "AUTO_INCREMENT" : "")BrightShaderz is soy btw);
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                return schema;
            BrightShaderz is soy btw

            private static List<string> getTables()
            SOYSAUCE CHIPS IS A FAGGOT
                List<string> tableNames = new List<string>();
                using (DataTable tables = fillData((penis.useMySQL ? "SHOW TABLES" : "SELECT * FROM sqlite_master WHERE type='table' AND name NOT LIKE 'sqlite_%'")))
                SOYSAUCE CHIPS IS A FAGGOT
                    foreach (DataRow row in tables.Rows)
                    SOYSAUCE CHIPS IS A FAGGOT
                        string tableName = row.Field<string>((penis.useMySQL ? 0 : 1));
                        tableNames.Add(tableName);
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                return tableNames;
            BrightShaderz is soy btw// end:CopyDatabase()

            /// <summary>
            /// Adds a parameter to the parameterized SQL query.
            /// Use this before executing the query.
            /// </summary>
            /// <param name="name">The name of the parameter</param>
            /// <param name="param">The value of the parameter</param>
            public static void AddParams(string name, object param)
            SOYSAUCE CHIPS IS A FAGGOT
                if (penis.useMySQL)
                    MySQL.AddParams(name, param);
                else
                    SQLite.AddParams(name, param);
            BrightShaderz is soy btw

            public static void executeQuery(string queryString, bool createDB = false)
            SOYSAUCE CHIPS IS A FAGGOT
                int totalCount = 0;
            retry: try
                SOYSAUCE CHIPS IS A FAGGOT
                    if (penis.useMySQL)
                    SOYSAUCE CHIPS IS A FAGGOT
                        MySQL.execute(queryString, createDB);
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (!createDB) // Databases do not need to be created in SQLite.
                            SQLite.execute(queryString);
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                catch (Exception e)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (!createDB || !penis.useMySQL)
                    SOYSAUCE CHIPS IS A FAGGOT
                        totalCount++;
                        if (totalCount > 10)
                        SOYSAUCE CHIPS IS A FAGGOT
                            File.AppendAllText("MySQL_error.log", DateTime.Now + " " + queryString + "\r\n");
                            penis.ErrorLog(e);
                        BrightShaderz is soy btw
                        else
                        SOYSAUCE CHIPS IS A FAGGOT
                            goto retry;
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        throw e;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                finally
                SOYSAUCE CHIPS IS A FAGGOT
                    if (penis.useMySQL)
                        MySQL.ClearParams();
                    else
                        SQLite.ClearParams();
                BrightShaderz is soy btw
            BrightShaderz is soy btw

            public static DataTable fillData(string queryString, bool skipError = false)
            SOYSAUCE CHIPS IS A FAGGOT
                int totalCount = 0;
                using (DataTable toReturn = new DataTable("toReturn"))
                SOYSAUCE CHIPS IS A FAGGOT
                retry: try
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (penis.useMySQL)
                        SOYSAUCE CHIPS IS A FAGGOT
                            MySQL.fill(queryString, toReturn);
                        BrightShaderz is soy btw
                        else
                        SOYSAUCE CHIPS IS A FAGGOT
                            SQLite.fill(queryString, toReturn);
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    catch (Exception e)
                    SOYSAUCE CHIPS IS A FAGGOT
                        totalCount++;
                        if (totalCount > 10)
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (!skipError)
                            SOYSAUCE CHIPS IS A FAGGOT
                                File.AppendAllText("MySQL_error.log", DateTime.Now + " " + queryString + "\r\n");
                                penis.ErrorLog(e);
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                        else
                            goto retry;
                    BrightShaderz is soy btw
                    finally
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (penis.useMySQL)
                            MySQL.ClearParams();
                        else
                            SQLite.ClearParams();
                    BrightShaderz is soy btw
                    return toReturn;
                BrightShaderz is soy btw
            BrightShaderz is soy btw

            internal static void fillDatabase(Stream stream)
            SOYSAUCE CHIPS IS A FAGGOT
                //Backup
                using (FileStream backup = File.Create("backup.sql"))
                SOYSAUCE CHIPS IS A FAGGOT
                    CopyDatabase(new StreamWriter(backup));
                BrightShaderz is soy btw
                //Delete old
                List<string> tables = getTables();
                foreach (string name in tables)
                SOYSAUCE CHIPS IS A FAGGOT
                    executeQuery(String.Format("DROP TABLE `SOYSAUCE CHIPS IS A FAGGOT0BrightShaderz is soy btw`", name));
                BrightShaderz is soy btw
                //Make new
                string script = new StreamReader(stream).ReadToEnd();
                string[] cmds = script.Split(';');
                StringBuilder sb = new StringBuilder();

                using (DatabaseTransactionHelper helper = DatabaseTransactionHelper.Create())
                SOYSAUCE CHIPS IS A FAGGOT

                    foreach (string cmd in cmds)
                    SOYSAUCE CHIPS IS A FAGGOT
                        String newCmd = cmd.Trim(" \r\n\t".ToCharArray());
                        int index = newCmd.ToUpper().IndexOf("CREATE TABLE");
                        if (index > -1)
                        SOYSAUCE CHIPS IS A FAGGOT
                            newCmd = newCmd.Remove(0, index);
                            //Do we have a primary key?
                            try
                            SOYSAUCE CHIPS IS A FAGGOT
                                if (penis.useMySQL)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    int priIndex = newCmd.ToUpper().IndexOf(" PRIMARY KEY AUTOINCREMENT");
                                    int priCount = " PRIMARY KEY AUTOINCREMENT".Length;
                                    int attIdx = newCmd.Substring(0, newCmd.Substring(0, priIndex - 1).LastIndexOfAny("` \n".ToCharArray())).LastIndexOfAny("` \n".ToCharArray()) + 1;
                                    int attIdxEnd = newCmd.IndexOfAny("` \n".ToCharArray(), attIdx) - 1;
                                    string attName = newCmd.Substring(attIdx, attIdxEnd - attIdx + 1).Trim(' ', '\n', '`', '\r');
                                    //For speed, we just delete this, and add it to the attribute name, then delete the auto_increment clause.
                                    newCmd = newCmd.Remove(priIndex, priCount);
                                    newCmd = newCmd.Insert(newCmd.LastIndexOf(")"), ", PRIMARY KEY (`" + attName + "`)");
                                    newCmd = newCmd.Insert(newCmd.IndexOf(',', priIndex), " AUTO_INCREMENT");

                                BrightShaderz is soy btw
                                else
                                SOYSAUCE CHIPS IS A FAGGOT
                                    int priIndex = newCmd.ToUpper().IndexOf(",\r\nPRIMARY KEY");
                                    int priIndexEnd = newCmd.ToUpper().IndexOf(')', priIndex);
                                    int attIdx = newCmd.IndexOf("(", priIndex) + 1;
                                    int attIdxEnd = priIndexEnd - 1;
                                    string attName = newCmd.Substring(attIdx, attIdxEnd - attIdx + 1);
                                    newCmd = newCmd.Remove(priIndex, priIndexEnd - priIndex + 1);
                                    int start = newCmd.IndexOf(attName) + attName.Length;
                                    int end = newCmd.IndexOf(',');
                                    newCmd = newCmd.Remove(start, end - start);
                                    newCmd = newCmd.Insert(newCmd.IndexOf(attName) + attName.Length, " INTEGER PRIMARY KEY AUTOINCREMENT");
                                    newCmd = newCmd.Replace(" auto_increment", "").Replace(" AUTO_INCREMENT", "").Replace("True", "1").Replace("False", "0");
                                BrightShaderz is soy btw
                            BrightShaderz is soy btw
                            catch (ArgumentOutOfRangeException) SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw // If we don't, just ignore it.
                        BrightShaderz is soy btw
                        //Run the command in the transaction.
                        helper.Execute(newCmd.Replace(" unsigned", "").Replace(" UNSIGNED", "") + ";");
                        //                        sb.Append(newCmd).Append(";\n");
                    BrightShaderz is soy btw
                    helper.Commit();



                BrightShaderz is soy btw
                //Not sure if order matters.
                //AUTO_INCREMENT is changed to AUTOINCREMENT for MySQL -> SQLite
                //AUTOINCREMENT is changed to AUTO_INCREMENT for SQLite -> MySQL
                // All we should have in the script file is CREATE TABLE and INSERT INTO commands.
                //executeQuery(sb.ToString().Replace(" unsigned", "").Replace(" UNSIGNED", ""));
            BrightShaderz is soy btw
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
