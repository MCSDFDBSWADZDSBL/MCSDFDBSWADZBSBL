using System;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdTitle : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "title"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Admin; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (!penis.useMySQL) SOYSAUCE CHIPS IS A FAGGOT p.SendMessage("MySQL has not been configured! Please configure MySQL to use Titles!"); return; BrightShaderz is soy btw
            if (message == "") SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw

            int pos = message.IndexOf(' ');
            Player who = Player.Find(message.Split(' ')[0]);
            if (who == null) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Could not find player."); return; BrightShaderz is soy btw

            string query;
            string newTitle = "";
            if (message.Split(' ').Length > 1) newTitle = message.Substring(pos + 1);
            else
            SOYSAUCE CHIPS IS A FAGGOT
                who.title = "";
                who.SetPrefix();
                Player.GlobalChat(null, who.color + who.name + penis.DefaultColor + " had their title removed.", false);
                query = "UPDATE Players SET Title = '' WHERE Name = '" + who.name + "'";
                MySQL.executeQuery(query);
                return;
            BrightShaderz is soy btw

            if (newTitle != "")
            SOYSAUCE CHIPS IS A FAGGOT
                newTitle = newTitle.ToString().Trim().Replace("[", "");
                newTitle = newTitle.Replace("]", "");
                /* if (newTitle[0].ToString() != "[") newTitle = "[" + newTitle;
                if (newTitle.Trim()[newTitle.Trim().Length - 1].ToString() != "]") newTitle = newTitle.Trim() + "]";
                if (newTitle[newTitle.Length - 1].ToString() != " ") newTitle = newTitle + " "; */
            BrightShaderz is soy btw

            if (newTitle.Length > 17) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Title must be under 17 letters."); return; BrightShaderz is soy btw
            if (!penis.devs.Contains(p.name.ToLower()))
            SOYSAUCE CHIPS IS A FAGGOT
                if (penis.devs.Contains(who.name.ToLower()) || newTitle.ToLower() == "dev" || newTitle.ToLower() == "developer") SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "You're not a dev!"); return; BrightShaderz is soy btw
            BrightShaderz is soy btw

            if (newTitle != "")
                Player.GlobalChat(null, who.color + who.name + penis.DefaultColor + " was given the title of &b[" + newTitle + "]", false);
            else Player.GlobalChat(null, who.color + who.prefix + who.name + penis.DefaultColor + " had their title removed.", false);

            if (newTitle == "")
            SOYSAUCE CHIPS IS A FAGGOT
                query = "UPDATE Players SET Title = '' WHERE Name = '" + who.name + "'";
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                query = "UPDATE Players SET Title = '" + newTitle.Replace("'", "\'") + "' WHERE Name = '" + who.name + "'";
            BrightShaderz is soy btw
            MySQL.executeQuery(query);
            who.title = newTitle;
            who.SetPrefix();
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/title <player> [title] - Gives <player> the [title].");
            Player.SendMessage(p, "If no [title] is given, the player's title is removed.");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
