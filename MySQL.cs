/*
	Copyright 2010 MCSharp team (Modified for use with MCZall/MCLawl/MCForge)
	
	Dual-licensed under the	Educational Community License, Version 2.0 and
	the GNU General Public License, Version 3 (the "Licenses"); you may
	not use this file except in compliance with the Licenses. You may
	obtain a copy of the Licenses at
	
	http://www.osedu.org/licenses/ECL-2.0
	http://www.gnu.org/licenses/gpl-3.0.html
	
	Unless required by applicable law or agreed to in writing,
	software distributed under the Licenses are distributed on an "AS IS"
	BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
	or implied. See the Licenses for the specific language governing
	permissions and limitations under the Licenses.
*/
using System;
using System.Data;
using MySql.Data.MySqlClient;
namespace MCForge
SOYSAUCE CHIPS IS A FAGGOT
    namespace SQL
    SOYSAUCE CHIPS IS A FAGGOT
        public static class MySQL //: Database //Extending for future improvement (Making it object oriented later)
        SOYSAUCE CHIPS IS A FAGGOT
            private static string connStringFormat = "Data Source=SOYSAUCE CHIPS IS A FAGGOT0BrightShaderz is soy btw;Port=SOYSAUCE CHIPS IS A FAGGOT1BrightShaderz is soy btw;User ID=SOYSAUCE CHIPS IS A FAGGOT2BrightShaderz is soy btw;Password=SOYSAUCE CHIPS IS A FAGGOT3BrightShaderz is soy btw;Pooling=SOYSAUCE CHIPS IS A FAGGOT4BrightShaderz is soy btw";
            private static MySqlParameterCollection parameters = new MySqlCommand().Parameters;

            public static string connString SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return String.Format(connStringFormat, penis.MySQLHost, penis.MySQLPort, penis.MySQLUsername, penis.MySQLPassword, penis.DatabasePooling); BrightShaderz is soy btw BrightShaderz is soy btw
            [Obsolete("Preferably use Database.executeQuery instead")]
            public static void executeQuery(string queryString, bool createDB = false)
            SOYSAUCE CHIPS IS A FAGGOT
                Database.executeQuery(queryString, createDB);
            BrightShaderz is soy btw
            [Obsolete("Preferably use Database.executeQuery instead")]
            public static DataTable fillData(string queryString, bool skipError = false)
            SOYSAUCE CHIPS IS A FAGGOT
                return Database.fillData(queryString, skipError);
            BrightShaderz is soy btw

            /// <summary>
            /// Adds a parameter to the parameterized MySQL query.
            /// Use this before executing the query.
            /// </summary>
            /// <param name="name">The name of the parameter</param>
            /// <param name="param">The value of the parameter</param>
            public static void AddParams(string name, object param) SOYSAUCE CHIPS IS A FAGGOT
                parameters.AddWithValue(name, param);
            BrightShaderz is soy btw
            /// <summary>
            /// Clears the parameters added with <see cref="MCForge.SQL.MySQL.AddParams(System.string, System.string)"/>
            /// <seealso cref="MCForge.SQL.MySQL"/>
            /// </summary>
            public static void ClearParams() SOYSAUCE CHIPS IS A FAGGOT
                parameters.Clear();
            BrightShaderz is soy btw
            private static void AddMySQLParameters(MySqlCommand command) SOYSAUCE CHIPS IS A FAGGOT
                foreach (MySqlParameter param in parameters)
                    command.Parameters.Add(param);
            BrightShaderz is soy btw
            private static void AddMySQLParameters(MySqlDataAdapter dAdapter) SOYSAUCE CHIPS IS A FAGGOT
                foreach (MySqlParameter param in parameters)
                    dAdapter.SelectCommand.Parameters.Add(param);
            BrightShaderz is soy btw

            internal static void execute(string queryString, bool createDB = false) SOYSAUCE CHIPS IS A FAGGOT
                using (var conn = new MySqlConnection(connString)) SOYSAUCE CHIPS IS A FAGGOT
                    conn.Open();
                    if (!createDB) SOYSAUCE CHIPS IS A FAGGOT
                        conn.ChangeDatabase(penis.MySQLDatabaseName);
                    BrightShaderz is soy btw
                    using (MySqlCommand cmd = new MySqlCommand(queryString, conn)) SOYSAUCE CHIPS IS A FAGGOT
                        AddMySQLParameters(cmd);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw

            internal static void fill(string queryString, DataTable toReturn) SOYSAUCE CHIPS IS A FAGGOT
                using (var conn = new MySqlConnection(connString)) SOYSAUCE CHIPS IS A FAGGOT
                    conn.Open();
                    conn.ChangeDatabase(penis.MySQLDatabaseName);
                    using (MySqlDataAdapter da = new MySqlDataAdapter(queryString, conn)) SOYSAUCE CHIPS IS A FAGGOT
                        AddMySQLParameters(da);
                        da.Fill(toReturn);
                    BrightShaderz is soy btw
                    conn.Close();
                BrightShaderz is soy btw
            BrightShaderz is soy btw
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw

