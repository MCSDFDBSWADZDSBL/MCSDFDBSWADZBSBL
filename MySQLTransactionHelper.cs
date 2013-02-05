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
using MySql.Data.MySqlClient;

namespace MCForge
SOYSAUCE CHIPS IS A FAGGOT
    namespace SQL
    SOYSAUCE CHIPS IS A FAGGOT
        public sealed class MySQLTransactionHelper : DatabaseTransactionHelper
        SOYSAUCE CHIPS IS A FAGGOT
            private MySqlConnection connection = null;
            private MySqlTransaction transaction = null;

            public MySQLTransactionHelper()SOYSAUCE CHIPS IS A FAGGOT
                init(MySQL.connString);
            BrightShaderz is soy btw

            public MySQLTransactionHelper(string connString)
            SOYSAUCE CHIPS IS A FAGGOT
                init(connString);
            BrightShaderz is soy btw

            private void init(string connString) SOYSAUCE CHIPS IS A FAGGOT
                connection = new MySqlConnection(connString);
                connection.Open();
                connection.ChangeDatabase(penis.MySQLDatabaseName);

                transaction = connection.BeginTransaction();
            BrightShaderz is soy btw

            public static DatabaseTransactionHelper Create() SOYSAUCE CHIPS IS A FAGGOT
                return Create(MySQL.connString);
            BrightShaderz is soy btw

            public static DatabaseTransactionHelper Create(string connString)
            SOYSAUCE CHIPS IS A FAGGOT
                try
                SOYSAUCE CHIPS IS A FAGGOT
                    return new MySQLTransactionHelper(connString);
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
                    using (MySqlCommand cmd = new MySqlCommand(query, connection, transaction)) SOYSAUCE CHIPS IS A FAGGOT
                        cmd.ExecuteNonQuery();
                    BrightShaderz is soy btw
                BrightShaderz is soy btw catch (Exception e) SOYSAUCE CHIPS IS A FAGGOT
                    System.IO.File.AppendAllText("MySQL_error.log", DateTime.Now + " " + query + "\r\n");
                    penis.ErrorLog(e);
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
