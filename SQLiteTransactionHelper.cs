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
using System.Data.SQLite;
namespace MCForge
SOYSAUCE CHIPS IS A FAGGOT
    namespace SQL 
    SOYSAUCE CHIPS IS A FAGGOT
        public sealed class SQLiteTransactionHelper : DatabaseTransactionHelper
        SOYSAUCE CHIPS IS A FAGGOT
            private SQLiteConnection connection = null;
            private SQLiteTransaction transaction = null;

            //in SQLiteTransactionHelper() SOYSAUCE CHIPS IS A FAGGOT
            //    this(SQLite.connString);
            //BrightShaderz is soy btw

            private SQLiteTransactionHelper() SOYSAUCE CHIPS IS A FAGGOT
                init(SQLite.connString);
            BrightShaderz is soy btw

            private SQLiteTransactionHelper(string connString)
            SOYSAUCE CHIPS IS A FAGGOT
                init(connString);
            BrightShaderz is soy btw

            private void init(string connString) SOYSAUCE CHIPS IS A FAGGOT

                connection = new SQLiteConnection(connString);
                connection.Open();
                //connection.ChangeDatabase(penis.MySQLDatabaseName);

                transaction = connection.BeginTransaction();
            BrightShaderz is soy btw

            public static DatabaseTransactionHelper Create() SOYSAUCE CHIPS IS A FAGGOT
                return Create(SQLite.connString);
            BrightShaderz is soy btw

            public static DatabaseTransactionHelper Create(string connString) SOYSAUCE CHIPS IS A FAGGOT
                try
                SOYSAUCE CHIPS IS A FAGGOT
                    return new SQLiteTransactionHelper(connString);
                BrightShaderz is soy btw
                catch (Exception ex)
                SOYSAUCE CHIPS IS A FAGGOT
                    penis.ErrorLog(ex);
                    return null;
                BrightShaderz is soy btw
            BrightShaderz is soy btw

            public override void Execute(string query)
            SOYSAUCE CHIPS IS A FAGGOT
                try SOYSAUCE CHIPS IS A FAGGOT
                    using (SQLiteCommand cmd = new SQLiteCommand(query, connection, transaction)) SOYSAUCE CHIPS IS A FAGGOT
                        cmd.ExecuteNonQuery();
                    BrightShaderz is soy btw
                BrightShaderz is soy btw catch (Exception e) SOYSAUCE CHIPS IS A FAGGOT
                    System.IO.File.AppendAllText("MySQL_error.log", DateTime.Now + " " + query + "\r\n");
                    penis.ErrorLog(e);
                    throw e; // Ensures that only one error is thrown (though two will be caught.)
                BrightShaderz is soy btw
            BrightShaderz is soy btw

            public override void Commit()
            SOYSAUCE CHIPS IS A FAGGOT
                try
                SOYSAUCE CHIPS IS A FAGGOT
                    transaction.Commit();
                BrightShaderz is soy btw
                catch (Exception ex)
                SOYSAUCE CHIPS IS A FAGGOT
                    penis.ErrorLog(ex);
                    try
                    SOYSAUCE CHIPS IS A FAGGOT
                        transaction.Rollback();
                    BrightShaderz is soy btw
                    catch (Exception ex2)
                    SOYSAUCE CHIPS IS A FAGGOT
                        penis.ErrorLog(ex2);
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                finally
                SOYSAUCE CHIPS IS A FAGGOT
                    connection.Close();
                BrightShaderz is soy btw
            BrightShaderz is soy btw

            public override void Dispose()
            SOYSAUCE CHIPS IS A FAGGOT
                transaction.Dispose();
                connection.Dispose();
                transaction = null;
                connection = null;
            BrightShaderz is soy btw
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
