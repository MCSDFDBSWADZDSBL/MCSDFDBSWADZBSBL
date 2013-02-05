/*
	Copyright 2010 MCSharp team (Modified for use with MCZall/MCLawl/MCForge)
	
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
using System.IO;
namespace MCForge.Commands
SOYSAUCE CHIPS IS A FAGGOT
    public sealed class CmdTranslate : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "translate"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "trans"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Guest; BrightShaderz is soy btw BrightShaderz is soy btw
        public CmdTranslate() SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message == "")
            SOYSAUCE CHIPS IS A FAGGOT
                if (p != null)
                SOYSAUCE CHIPS IS A FAGGOT
                    string langcode = penis.translang;
                    switch (langcode)
                    SOYSAUCE CHIPS IS A FAGGOT
                        case "af":
                            langcode = "Afrikaans";
                            break;
                        case "ar-sa":
                            langcode = "Arabic (Saudi Arabia)";
                            break;
                        case "ar-eg":
                            langcode = "Arabic (Egypt)";
                            break;
                        case "ar-dz":
                            langcode = "Arabic (Algeria)";
                            break;
                        case "ar-tn":
                            langcode = "Arabic (Tunisia)";
                            break;
                        case "ar-ye":
                            langcode = "Arabic (Yemen)";
                            break;
                        case "ar-jo":
                            langcode = "Arabic (Jordan)";
                            break;
                        case "ar-kw":
                            langcode = "Arabic (Kuwait)";
                            break;
                        case "ar-bh":
                            langcode = "Arabic (Bahrain)";
                            break;
                        case "eu":
                            langcode = "Basque";
                            break;
                        case "be":
                            langcode = "Belarusian";
                            break;
                        case "zh-tw":
                            langcode = "Chinese (Taiwan)";
                            break;
                        case "zh-hk":
                            langcode = "Chinese (Hong Kong SAR)";
                            break;
                        case "hr":
                            langcode = "Croatian";
                            break;
                        case "da":
                            langcode = "Danish";
                            break;
                        case "nl-be":
                            langcode = "Dutch (Belgium)";
                            break;
                        case "en-us":
                            langcode = "English (United States)";
                            break;
                        case "en-au":
                            langcode = "English (Australia)";
                            break;
                        case "en-nz":
                            langcode = "English (New Zealand)";
                            break;
                        case "en-za":
                            langcode = "English (South Africa)";
                            break;
                        case "en-tt":
                            langcode = "English (Trinidad)";
                            break;
                        case "fo":
                            langcode = "Faeroese";
                            break;
                        case "fi":
                            langcode = "Finnish";
                            break;
                        case "fr-be":
                            langcode = "French (Belgium)";
                            break;
                        case "fr-ch":
                            langcode = "French (Switzerland)";
                            break;
                        case "gd":
                            langcode = "Gaelic (Scotland)";
                            break;
                        case "de":
                            langcode = "German (Standard)";
                            break;
                        case "de-at":
                            langcode = "German (Austria)";
                            break;
                        case "de-li":
                            langcode = "German (Liechtenstein)";
                            break;
                        case "he":
                            langcode = "Hebrew";
                            break;
                        case "hu":
                            langcode = "Hungarian";
                            break;
                        case "id":
                            langcode = "Indonesian";
                            break;
                        case "it-ch":
                            langcode = "Italian (Switzerland)";
                            break;
                        case "ko":
                            langcode = "Korean";
                            break;
                        case "lv":
                            langcode = "Latvian";
                            break;
                        case "mk":
                            langcode = "Macedonian (FYROM)";
                            break;
                        case "mt":
                            langcode = "Maltese";
                            break;
                        case "no":
                            langcode = "Norwegian (Nynorsk)";
                            break;
                        case "pt-br":
                            langcode = "Portuguese (Brazil)";
                            break;
                        case "rm":
                            langcode = "Rhaeto-Romanic";
                            break;
                        case "ro-mo":
                            langcode = "Romanian (Republic of Moldova)";
                            break;
                        case "ru-mo":
                            langcode = "Russian (Republic of Moldova)";
                            break;
                        case "sr":
                            langcode = "Serbian (Cyrillic)";
                            break;
                        case "sk":
                            langcode = "Slovak";
                            break;
                        case "sb":
                            langcode = "Sorbian";
                            break;
                        case "es-mx":
                            langcode = "Spanish (Mexico)";
                            break;
                        case "es-cr":
                            langcode = "Spanish (Costa Rica)";
                            break;
                        case "es-do":
                            langcode = "Spanish (Dominican Republic)";
                            break;
                        case "es-co":
                            langcode = "Spanish (Colombia)";
                            break;
                        case "es-ar":
                            langcode = "Spanish (Argentina)";
                            break;
                        case "es-cl":
                            langcode = "Spanish (Chile)";
                            break;
                        case "es-py":
                            langcode = "Spanish (Paraguay)";
                            break;
                        case "es-sv":
                            langcode = "Spanish (El Salvador)";
                            break;
                        case "es-ni":
                            langcode = "Spanish (Nicaragua)";
                            break;
                        case "sx":
                            langcode = "Sutu";
                            break;
                        case "sv-fi":
                            langcode = "Swedish (Finland)";
                            break;
                        case "ts":
                            langcode = "Tsonga";
                            break;
                        case "tr":
                            langcode = "Turkish";
                            break;
                        case "ur":
                            langcode = "Urdu";
                            break;
                        case "vi":
                            langcode = "Vietnamese";
                            break;
                        case "ji":
                            langcode = "Yiddish";
                            break;
                        case "sq":
                            langcode = "Albanian";
                            break;
                        case "ar-iq":
                            langcode = "Arabic (Iraq)";
                            break;
                        case "ar-ly":
                            langcode = "Arabic (Libya)";
                            break;
                        case "ar-ma":
                            langcode = "Arabic (Morocco)";
                            break;
                        case "ar-om":
                            langcode = "Arabic (Oman)";
                            break;
                        case "ar-sy":
                            langcode = "Arabic (Syria)";
                            break;
                        case "ar-lb":
                            langcode = "Arabic (Lebanon)";
                            break;
                        case "ar-ae":
                            langcode = "Arabic (U.A.E.)";
                            break;
                        case "ar-qa":
                            langcode = "Arabic (Qatar)";
                            break;
                        case "bg":
                            langcode = "Bulgarian";
                            break;
                        case "ca":
                            langcode = "Catalan";
                            break;
                        case "zh-cn":
                            langcode = "Chinese (PRC)";
                            break;
                        case "zh-sg":
                            langcode = "Chinese (Singapore)";
                            break;
                        case "cs":
                            langcode = "Czech";
                            break;
                        case "nl":
                            langcode = "Dutch (Standard)";
                            break;
                        case "en":
                            langcode = "English";
                            break;
                        case "en-gb":
                            langcode = "English (United Kingdom)";
                            break;
                        case "en-ca":
                            langcode = "English (Canada)";
                            break;
                        case "en-ie":
                            langcode = "English (Ireland)";
                            break;
                        case "en-jm":
                            langcode = "English (Jamaica)";
                            break;
                        case "en-bz":
                            langcode = "English (Belize)";
                            break;
                        case "et":
                            langcode = "Farsi";
                            break;
                        case "fr":
                            langcode = "French (Standard)";
                            break;
                        case "ga":
                            langcode = "Irish";
                            break;
                        case "el":
                            langcode = "Greek";
                            break;
                        case "hi":
                            langcode = "Hindi";
                            break;
                        case "it":
                            langcode = "Italian (Standard)";
                            break;
                        case "is":
                            langcode = "Icelandic";
                            break;
                        case "ja":
                            langcode = "Japanese";
                            break;
                        case "lt":
                            langcode = "Lithuanian";
                            break;
                        case "ms":
                            langcode = "Malaysian";
                            break;
                        case "pl":
                            langcode = "Polish";
                            break;
                        case "pt":
                            langcode = "Portuguese";
                            break;
                        case "ro":
                            langcode = "Romanian";
                            break;
                        case "ru":
                            langcode = "Russian";
                            break;
                        case "sz":
                            langcode = "Sami (Lappish) ";
                            break;
                        case "sl":
                            langcode = "Slovenian ";
                            break;
                        case "es":
                            langcode = "Spanish";
                            break;
                        case "sv":
                            langcode = "Swedish";
                            break;
                        case "th":
                            langcode = "Thai";
                            break;
                        case "tn":
                            langcode = "Tswana";
                            break;
                        case "uk":
                            langcode = "Ukrainian";
                            break;
                        case "ve":
                            langcode = "Venda";
                            break;
                        case "xh":
                            langcode = "Xhosa";
                            break;
                        case "zu":
                            langcode = "Zulu";
                            break;
                        default:
                            langcode = "!ERROR!";
                            break;
                    BrightShaderz is soy btw
                    if (penis.transenabled)
                    SOYSAUCE CHIPS IS A FAGGOT
                        string penislanguage = langcode;
                        if (penis.transignore.Contains(p.name))
                        SOYSAUCE CHIPS IS A FAGGOT

                            Player.SendMessage(p, "Global translation is &aON" + penis.DefaultColor + ". Personal translation is &cOFF" + penis.DefaultColor + ". The global language is &c" + penislanguage + ".");
                        BrightShaderz is soy btw
                        else
                        SOYSAUCE CHIPS IS A FAGGOT
                            Player.SendMessage(p, "Global translation is &aON" + penis.DefaultColor + ". Personal translation is &aON" + penis.DefaultColor + ". The global language is &c" + penislanguage + ".");
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "Global translation is &cOFF");
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    if (penis.transenabled)
                    SOYSAUCE CHIPS IS A FAGGOT
                        string langcode = penis.translang;
                        switch (langcode)
                        SOYSAUCE CHIPS IS A FAGGOT
                            case "af":
                                langcode = "Afrikaans";
                                break;
                            case "ar-sa":
                                langcode = "Arabic (Saudi Arabia)";
                                break;
                            case "ar-eg":
                                langcode = "Arabic (Egypt)";
                                break;
                            case "ar-dz":
                                langcode = "Arabic (Algeria)";
                                break;
                            case "ar-tn":
                                langcode = "Arabic (Tunisia)";
                                break;
                            case "ar-ye":
                                langcode = "Arabic (Yemen)";
                                break;
                            case "ar-jo":
                                langcode = "Arabic (Jordan)";
                                break;
                            case "ar-kw":
                                langcode = "Arabic (Kuwait)";
                                break;
                            case "ar-bh":
                                langcode = "Arabic (Bahrain)";
                                break;
                            case "eu":
                                langcode = "Basque";
                                break;
                            case "be":
                                langcode = "Belarusian";
                                break;
                            case "zh-tw":
                                langcode = "Chinese (Taiwan)";
                                break;
                            case "zh-hk":
                                langcode = "Chinese (Hong Kong SAR)";
                                break;
                            case "hr":
                                langcode = "Croatian";
                                break;
                            case "da":
                                langcode = "Danish";
                                break;
                            case "nl-be":
                                langcode = "Dutch (Belgium)";
                                break;
                            case "en-us":
                                langcode = "English (United States)";
                                break;
                            case "en-au":
                                langcode = "English (Australia)";
                                break;
                            case "en-nz":
                                langcode = "English (New Zealand)";
                                break;
                            case "en-za":
                                langcode = "English (South Africa)";
                                break;
                            case "en-tt":
                                langcode = "English (Trinidad)";
                                break;
                            case "fo":
                                langcode = "Faeroese";
                                break;
                            case "fi":
                                langcode = "Finnish";
                                break;
                            case "fr-be":
                                langcode = "French (Belgium)";
                                break;
                            case "fr-ch":
                                langcode = "French (Switzerland)";
                                break;
                            case "gd":
                                langcode = "Gaelic (Scotland)";
                                break;
                            case "de":
                                langcode = "German (Standard)";
                                break;
                            case "de-at":
                                langcode = "German (Austria)";
                                break;
                            case "de-li":
                                langcode = "German (Liechtenstein)";
                                break;
                            case "he":
                                langcode = "Hebrew";
                                break;
                            case "hu":
                                langcode = "Hungarian";
                                break;
                            case "id":
                                langcode = "Indonesian";
                                break;
                            case "it-ch":
                                langcode = "Italian (Switzerland)";
                                break;
                            case "ko":
                                langcode = "Korean";
                                break;
                            case "lv":
                                langcode = "Latvian";
                                break;
                            case "mk":
                                langcode = "Macedonian (FYROM)";
                                break;
                            case "mt":
                                langcode = "Maltese";
                                break;
                            case "no":
                                langcode = "Norwegian (Nynorsk)";
                                break;
                            case "pt-br":
                                langcode = "Portuguese (Brazil)";
                                break;
                            case "rm":
                                langcode = "Rhaeto-Romanic";
                                break;
                            case "ro-mo":
                                langcode = "Romanian (Republic of Moldova)";
                                break;
                            case "ru-mo":
                                langcode = "Russian (Republic of Moldova)";
                                break;
                            case "sr":
                                langcode = "Serbian (Cyrillic)";
                                break;
                            case "sk":
                                langcode = "Slovak";
                                break;
                            case "sb":
                                langcode = "Sorbian";
                                break;
                            case "es-mx":
                                langcode = "Spanish (Mexico)";
                                break;
                            case "es-cr":
                                langcode = "Spanish (Costa Rica)";
                                break;
                            case "es-do":
                                langcode = "Spanish (Dominican Republic)";
                                break;
                            case "es-co":
                                langcode = "Spanish (Colombia)";
                                break;
                            case "es-ar":
                                langcode = "Spanish (Argentina)";
                                break;
                            case "es-cl":
                                langcode = "Spanish (Chile)";
                                break;
                            case "es-py":
                                langcode = "Spanish (Paraguay)";
                                break;
                            case "es-sv":
                                langcode = "Spanish (El Salvador)";
                                break;
                            case "es-ni":
                                langcode = "Spanish (Nicaragua)";
                                break;
                            case "sx":
                                langcode = "Sutu";
                                break;
                            case "sv-fi":
                                langcode = "Swedish (Finland)";
                                break;
                            case "ts":
                                langcode = "Tsonga";
                                break;
                            case "tr":
                                langcode = "Turkish";
                                break;
                            case "ur":
                                langcode = "Urdu";
                                break;
                            case "vi":
                                langcode = "Vietnamese";
                                break;
                            case "ji":
                                langcode = "Yiddish";
                                break;
                            case "sq":
                                langcode = "Albanian";
                                break;
                            case "ar-iq":
                                langcode = "Arabic (Iraq)";
                                break;
                            case "ar-ly":
                                langcode = "Arabic (Libya)";
                                break;
                            case "ar-ma":
                                langcode = "Arabic (Morocco)";
                                break;
                            case "ar-om":
                                langcode = "Arabic (Oman)";
                                break;
                            case "ar-sy":
                                langcode = "Arabic (Syria)";
                                break;
                            case "ar-lb":
                                langcode = "Arabic (Lebanon)";
                                break;
                            case "ar-ae":
                                langcode = "Arabic (U.A.E.)";
                                break;
                            case "ar-qa":
                                langcode = "Arabic (Qatar)";
                                break;
                            case "bg":
                                langcode = "Bulgarian";
                                break;
                            case "ca":
                                langcode = "Catalan";
                                break;
                            case "zh-cn":
                                langcode = "Chinese (PRC)";
                                break;
                            case "zh-sg":
                                langcode = "Chinese (Singapore)";
                                break;
                            case "cs":
                                langcode = "Czech";
                                break;
                            case "nl":
                                langcode = "Dutch (Standard)";
                                break;
                            case "en":
                                langcode = "English";
                                break;
                            case "en-gb":
                                langcode = "English (United Kingdom)";
                                break;
                            case "en-ca":
                                langcode = "English (Canada)";
                                break;
                            case "en-ie":
                                langcode = "English (Ireland)";
                                break;
                            case "en-jm":
                                langcode = "English (Jamaica)";
                                break;
                            case "en-bz":
                                langcode = "English (Belize)";
                                break;
                            case "et":
                                langcode = "Farsi";
                                break;
                            case "fr":
                                langcode = "French (Standard)";
                                break;
                            case "ga":
                                langcode = "Irish";
                                break;
                            case "el":
                                langcode = "Greek";
                                break;
                            case "hi":
                                langcode = "Hindi";
                                break;
                            case "it":
                                langcode = "Italian (Standard)";
                                break;
                            case "is":
                                langcode = "Icelandic";
                                break;
                            case "ja":
                                langcode = "Japanese";
                                break;
                            case "lt":
                                langcode = "Lithuanian";
                                break;
                            case "ms":
                                langcode = "Malaysian";
                                break;
                            case "pl":
                                langcode = "Polish";
                                break;
                            case "pt":
                                langcode = "Portuguese";
                                break;
                            case "ro":
                                langcode = "Romanian";
                                break;
                            case "ru":
                                langcode = "Russian";
                                break;
                            case "sz":
                                langcode = "Sami (Lappish) ";
                                break;
                            case "sl":
                                langcode = "Slovenian ";
                                break;
                            case "es":
                                langcode = "Spanish";
                                break;
                            case "sv":
                                langcode = "Swedish";
                                break;
                            case "th":
                                langcode = "Thai";
                                break;
                            case "tn":
                                langcode = "Tswana";
                                break;
                            case "uk":
                                langcode = "Ukrainian";
                                break;
                            case "ve":
                                langcode = "Venda";
                                break;
                            case "xh":
                                langcode = "Xhosa";
                                break;
                            case "zu":
                                langcode = "Zulu";
                                break;
                            default:
                                langcode = "!ERROR!";
                                break;
                        BrightShaderz is soy btw
                        Player.SendMessage(p, "Global translation is ON. The global language is " + langcode);
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "Global translation is OFF");
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            if (message == "toggle")
            SOYSAUCE CHIPS IS A FAGGOT
                if (p != null)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (penis.transenabled)
                    SOYSAUCE CHIPS IS A FAGGOT
                       
                        if (penis.transignore.Contains(p.name))
                        SOYSAUCE CHIPS IS A FAGGOT
                            //turn on
                            Player.SendMessage(p, "Personal translation has been turned &aON");
                            penis.transignore.Remove(p.name);
                            File.WriteAllLines("text/transexceptions.txt", penis.transignore.ToArray());
                            
                        BrightShaderz is soy btw
                        else
                        SOYSAUCE CHIPS IS A FAGGOT
                            //turn off
                            Player.SendMessage(p, "Personal translation has been turned &cOFF");
                            penis.transignore.Add(p.name);
                            File.WriteAllLines("text/transexceptions", penis.transignore.ToArray());
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "Global translation is &cOFF" + penis.DefaultColor + ". You cannot change personal translation");
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "You can't execute this command as console");
                    return;
                BrightShaderz is soy btw

            BrightShaderz is soy btw
            
            
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/translate - Displays translation status.");
            Player.SendMessage(p, "/translate toggle - turns translation on or off for yourself.");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
