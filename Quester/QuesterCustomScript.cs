using System;
using System.Linq;
using System.Threading;
using wManager.Wow.Enums;
using wManager.Wow.Helpers;
using wManager.Wow.ObjectManager;

public class Methods
{


    #region Properties
    #endregion Properties

    #region Meth
    //Methods.LuaPrint(Methods.FormatLua(@"RealmName:{0}", wManager.Wow.Helpers.Usefuls.RealmName));
    public static bool Realm()
    {
        if (wManager.Wow.Helpers.Usefuls.RealmName == "Single Player Project")
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    #endregion Meth

    #region LuaVars
    public static bool GetLuaBool(string LuaVar)
    {
        string s = "return " + LuaVar + ";";
        return Lua.LuaDoString<bool>(s);
    }
    public static void SetLuaBool(string LuaVar, bool BoolVar)
    {
        string s;
        if (BoolVar)
        {
            s = LuaVar + " = true;";
        }
        else
        {
            s = LuaVar + " = false;";
        }
        Lua.LuaDoString(s);
    }

    public static void SetLuaInt(string LuaVar, int IntVar)
    {
        string s;
        s = LuaVar + " = " + IntVar + ";";
        // JGP DEBUG
        //Methods.LuaPrint(Methods.FormatLua(@"setting wr_range to: {0}", IntVar));
        Lua.LuaDoString(s);
    }

    public static List<string> GetLuaList(string LuaList)
    {
        string s = "return unpack(" + LuaList + ");";
        var mylist = Lua.LuaDoString<List<string>>(s);
        return mylist;
    }

    #endregion LuaVars

    #region Logging
    // Logging
    public static string FormatLua(string str, params object[] names)
    {
        return string.Format(str, names.Select(s => s.ToString().Replace("'", "\\'").Replace("\"", "\\\"")).ToArray());
    }
    //public static void LuaPrint(string Text)
    //{
    //    Lua.LuaDoString("print(\"|cff69ccf0[WR] |cffffffff" + Text + "\")");
    //    //Lua.LuaDoString("/script DEFAULT_CHAT_FRAME: AddMessage(\"|cff69ccf0[WR] |cffffffff\" .. " + Text + "\")");
    //}

    public static void LuaPrint(string text, string color = "|cffffffff")
    {
        Lua.LuaDoString("print(\"|cff69ccf0[WR] " + color + text + "\")");
        //Lua.LuaDoString("print(\"|cff69ccf0[WR] " + text + "\")");
        //Lua.LuaDoString("/script DEFAULT_CHAT_FRAME: AddMessage(\"|cff69ccf0[WR] |cffffffff\" .. " + Text + "\")");
    }

    public static void LuaPrintWL(string text, string type = "reg")
    {
        string color = "|cffffffff";
        Lua.LuaDoString("ChatFrame4:AddMessage(\"|cff69ccf0[WR] " + color + text + "\");");
        /*
        switch (type)
        {
            case "com":
                Lua.LuaDoString("ChatFrame4:AddMessage(\"|cff00DDDD" + text + "\");");
                break;
            case "exec":
                Lua.LuaDoString("ChatFrame4:AddMessage(\"|cff00DD00" + text + "\");");
                break;
            case "warn":
                Lua.LuaDoString("ChatFrame4:AddMessage(\"|cffDDDD00" + text + "\");");
                break;
            case "reg":
                Lua.LuaDoString("ChatFrame4:AddMessage(\"|cffFFFFFF" + text + "\");");
                break;
            default:
                Lua.LuaDoString("ChatFrame4:AddMessage(\"|cff69ccf0[WR] " + color + text + "\");");
                break;
        }
        */
    }
    #endregion Logging

    
}