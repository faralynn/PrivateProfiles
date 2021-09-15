
using System.Linq;
using robotManager.Helpful;
using wManager.Wow.Class;
using wManager.Wow.Enums;
using wManager.Wow.Helpers;
using wManager.Wow.ObjectManager;
using System.Collections.Generic;
using System.Threading;
using System;
using wManager.Wow.Bot.Tasks;

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


public sealed class ExcavationToIronbeardsTomb : QuestFollowPathClass
{
    public ExcavationToIronbeardsTomb()
    {
        Name = "ExcavationToIronbeardsTomb";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-3216.692 , -1756.255 , 9.146247 , "None"));
Path.Add(new Vector3(-3214.21 , -1764.646 , 9.146247 , "None"));
Path.Add(new Vector3(-3212.224 , -1771.358 , 9.146247 , "None"));
Path.Add(new Vector3(-3210.239 , -1778.071 , 9.152467 , "None"));
Path.Add(new Vector3(-3208.193 , -1784.985 , 9.146335 , "None"));
Path.Add(new Vector3(-3206.267 , -1791.496 , 9.146335 , "None"));
Path.Add(new Vector3(-3204.282 , -1798.208 , 9.146335 , "None"));
Path.Add(new Vector3(-3202.423 , -1804.491 , 9.138843 , "None"));
Path.Add(new Vector3(-3200.251 , -1811.835 , 9.145029 , "None"));
Path.Add(new Vector3(-3198.325 , -1818.346 , 9.145029 , "None"));
Path.Add(new Vector3(-3196.28 , -1825.26 , 9.145473 , "None"));
Path.Add(new Vector3(-3194.294 , -1831.972 , 9.147656 , "None"));
Path.Add(new Vector3(-3192.309 , -1838.684 , 9.146568 , "None"));
Path.Add(new Vector3(-3190.323 , -1845.397 , 9.146568 , "None"));
Path.Add(new Vector3(-3188.337 , -1852.109 , 9.146568 , "None"));
Path.Add(new Vector3(-3186.633 , -1858.895 , 9.146568 , "None"));
Path.Add(new Vector3(-3185.776 , -1865.84 , 9.698972 , "None"));
Path.Add(new Vector3(-3185.148 , -1872.151 , 10.63945 , "None"));
Path.Add(new Vector3(-3184.459 , -1879.342 , 11.97176 , "None"));
Path.Add(new Vector3(-3183.983 , -1886.325 , 13.24472 , "None"));
Path.Add(new Vector3(-3183.754 , -1893.756 , 13.99231 , "None"));
Path.Add(new Vector3(-3183.555 , -1900.753 , 14.03722 , "None"));
Path.Add(new Vector3(-3183.356 , -1907.75 , 14.06414 , "None"));
Path.Add(new Vector3(-3183.156 , -1914.747 , 14.07344 , "None"));
Path.Add(new Vector3(-3182.899 , -1921.742 , 13.98045 , "None"));
Path.Add(new Vector3(-3182.617 , -1928.737 , 13.66039 , "None"));
Path.Add(new Vector3(-3182.391 , -1935.299 , 13.37348 , "None"));
Path.Add(new Vector3(-3182.151 , -1942.295 , 13.6544 , "None"));
Path.Add(new Vector3(-3181.961 , -1949.292 , 14.09333 , "None"));
Path.Add(new Vector3(-3181.789 , -1956.29 , 14.22629 , "None"));
Path.Add(new Vector3(-3181.618 , -1963.288 , 14.5962 , "None"));
Path.Add(new Vector3(-3181.446 , -1970.286 , 14.3575 , "None"));
Path.Add(new Vector3(-3181.275 , -1977.284 , 14.92676 , "None"));
Path.Add(new Vector3(-3181.103 , -1984.281 , 15.43638 , "None"));
Path.Add(new Vector3(-3180.932 , -1991.28 , 15.59459 , "None"));
Path.Add(new Vector3(-3180.76 , -1998.277 , 15.62623 , "None"));
Path.Add(new Vector3(-3180.589 , -2005.275 , 15.54733 , "None"));
Path.Add(new Vector3(-3180.417 , -2012.273 , 15.68883 , "None"));
Path.Add(new Vector3(-3180.246 , -2019.271 , 15.71166 , "None"));
Path.Add(new Vector3(-3180.074 , -2026.269 , 15.80569 , "None"));
Path.Add(new Vector3(-3179.903 , -2033.267 , 15.79061 , "None"));
Path.Add(new Vector3(-3179.731 , -2040.265 , 15.80507 , "None"));
Path.Add(new Vector3(-3179.56 , -2047.263 , 15.80507 , "None"));
Path.Add(new Vector3(-3179.388 , -2054.26 , 15.80507 , "None"));
Path.Add(new Vector3(-3179.217 , -2061.259 , 15.80507 , "None"));
Path.Add(new Vector3(-3179.045 , -2068.256 , 15.80507 , "None"));
Path.Add(new Vector3(-3178.874 , -2075.254 , 15.80507 , "None"));
Path.Add(new Vector3(-3178.702 , -2082.252 , 15.80507 , "None"));
Path.Add(new Vector3(-3178.531 , -2089.25 , 15.80507 , "None"));
Path.Add(new Vector3(-3178.359 , -2096.248 , 15.80013 , "None"));
Path.Add(new Vector3(-3178.182 , -2103.47 , 15.80513 , "None"));
Path.Add(new Vector3(-3178.01 , -2110.468 , 15.80392 , "None"));
Path.Add(new Vector3(-3177.844 , -2117.242 , 15.68079 , "None"));
Path.Add(new Vector3(-3177.667 , -2124.463 , 15.58368 , "None"));
Path.Add(new Vector3(-3177.928 , -2131.451 , 15.47667 , "None"));
Path.Add(new Vector3(-3178.94 , -2138.146 , 15.59945 , "None"));
Path.Add(new Vector3(-3180.29 , -2145.014 , 15.75436 , "None"));
Path.Add(new Vector3(-3181.752 , -2151.86 , 15.80509 , "None"));
Path.Add(new Vector3(-3183.304 , -2158.685 , 15.80442 , "None"));
Path.Add(new Vector3(-3185.037 , -2165.698 , 15.80218 , "None"));
Path.Add(new Vector3(-3186.801 , -2172.24 , 15.80401 , "None"));
Path.Add(new Vector3(-3188.765 , -2178.959 , 15.80401 , "None"));
Path.Add(new Vector3(-3190.856 , -2185.874 , 15.80401 , "None"));
Path.Add(new Vector3(-3192.817 , -2192.36 , 15.80401 , "None"));
Path.Add(new Vector3(-3195.025 , -2199.237 , 15.80401 , "None"));
Path.Add(new Vector3(-3197.643 , -2205.728 , 15.80401 , "None"));
Path.Add(new Vector3(-3200.328 , -2212.193 , 15.80256 , "None"));
Path.Add(new Vector3(-3203.013 , -2218.657 , 15.80328 , "None"));
Path.Add(new Vector3(-3205.655 , -2225.14 , 15.80376 , "None"));
Path.Add(new Vector3(-3208.289 , -2231.625 , 15.80376 , "None"));
Path.Add(new Vector3(-3210.871 , -2238.132 , 15.80376 , "None"));
Path.Add(new Vector3(-3213.397 , -2244.66 , 15.80376 , "None"));
Path.Add(new Vector3(-3215.817 , -2251.228 , 15.80376 , "None"));
Path.Add(new Vector3(-3217.723 , -2257.958 , 15.80376 , "None"));
Path.Add(new Vector3(-3218.767 , -2264.878 , 15.80376 , "None"));
Path.Add(new Vector3(-3219.312 , -2271.856 , 15.80376 , "None"));
Path.Add(new Vector3(-3219.731 , -2278.843 , 15.80376 , "None"));
Path.Add(new Vector3(-3220.15 , -2285.831 , 15.80376 , "None"));
Path.Add(new Vector3(-3220.57 , -2292.818 , 15.80449 , "None"));
Path.Add(new Vector3(-3220.989 , -2299.805 , 15.80449 , "None"));
Path.Add(new Vector3(-3221.408 , -2306.793 , 15.77674 , "None"));
Path.Add(new Vector3(-3221.827 , -2313.78 , 15.7621 , "None"));
Path.Add(new Vector3(-3222.247 , -2320.768 , 15.83842 , "None"));
Path.Add(new Vector3(-3222.666 , -2327.755 , 15.87028 , "None"));
Path.Add(new Vector3(-3223.085 , -2334.743 , 15.79092 , "None"));
Path.Add(new Vector3(-3223.504 , -2341.73 , 15.80502 , "None"));
Path.Add(new Vector3(-3223.923 , -2348.718 , 15.80502 , "None"));
Path.Add(new Vector3(-3224.29 , -2355.708 , 15.80514 , "None"));
Path.Add(new Vector3(-3224.227 , -2362.707 , 15.80644 , "None"));
Path.Add(new Vector3(-3224.137 , -2369.707 , 15.80625 , "None"));
Path.Add(new Vector3(-3224.048 , -2376.706 , 15.80528 , "None"));
Path.Add(new Vector3(-3223.959 , -2383.706 , 15.80491 , "None"));
Path.Add(new Vector3(-3223.87 , -2390.705 , 15.80491 , "None"));
Path.Add(new Vector3(-3223.781 , -2397.705 , 15.80491 , "None"));
Path.Add(new Vector3(-3223.674 , -2404.704 , 15.80491 , "None"));
Path.Add(new Vector3(-3223.519 , -2411.702 , 15.80491 , "None"));
Path.Add(new Vector3(-3223.094 , -2418.685 , 15.80491 , "None"));
Path.Add(new Vector3(-3221.435 , -2425.46 , 15.80491 , "None"));
Path.Add(new Vector3(-3217.637 , -2431.321 , 15.61071 , "None"));
Path.Add(new Vector3(-3212.618 , -2436.172 , 13.50846 , "None"));
Path.Add(new Vector3(-3206.639 , -2439.805 , 13.34154 , "None"));
Path.Add(new Vector3(-3200.556 , -2443.268 , 11.03988 , "None"));
Path.Add(new Vector3(-3194.447 , -2446.685 , 9.500797 , "None"));
Path.Add(new Vector3(-3187.933 , -2449.231 , 9.007001 , "None"));
Path.Add(new Vector3(-3181.032 , -2449.89 , 8.929312 , "None"));
Path.Add(new Vector3(-3174.125 , -2448.811 , 9.524594 , "None"));
Path.Add(new Vector3(-3167.412 , -2446.833 , 9.488213 , "None"));
Path.Add(new Vector3(-3161.205 , -2444.735 , 8.930125 , "None"));
Path.Add(new Vector3(-3153.709 , -2443.543 , 9.176472 , "None"));
Path.Add(new Vector3(-3146.788 , -2444.561 , 9.161931 , "None"));
Path.Add(new Vector3(-3139.958 , -2446.088 , 9.18679 , "None"));
Path.Add(new Vector3(-3133.14 , -2447.675 , 9.490989 , "None"));
Path.Add(new Vector3(-3126.323 , -2449.263 , 9.34905 , "None"));
Path.Add(new Vector3(-3119.505 , -2450.85 , 9.400955 , "None"));
Path.Add(new Vector3(-3113.084 , -2452.217 , 9.451357 , "None"));
Path.Add(new Vector3(-3106.322 , -2452.265 , 9.343373 , "None"));
Path.Add(new Vector3(-3099.362 , -2450.443 , 9.176968 , "None"));
Path.Add(new Vector3(-3093.282 , -2446.999 , 9.205517 , "None"));
Path.Add(new Vector3(-3087.643 , -2442.853 , 9.310475 , "None"));
Path.Add(new Vector3(-3081.879 , -2438.159 , 9.715223 , "None"));
Path.Add(new Vector3(-3076.307 , -2433.935 , 10.29585 , "None"));
Path.Add(new Vector3(-3070.474 , -2430.938 , 10.62443 , "None"));
Path.Add(new Vector3(-3063.415 , -2428.617 , 10.89406 , "None"));
Path.Add(new Vector3(-3057.077 , -2426.899 , 10.94714 , "None"));
Path.Add(new Vector3(-3049.882 , -2425.029 , 10.8941 , "None"));
Path.Add(new Vector3(-3043.094 , -2423.32 , 10.8941 , "None"));
Path.Add(new Vector3(-3036.669 , -2421.969 , 10.8941 , "None"));
Path.Add(new Vector3(-3029.744 , -2420.96 , 10.75419 , "None"));
Path.Add(new Vector3(-3022.771 , -2420.348 , 10.79262 , "None"));
Path.Add(new Vector3(-3015.345 , -2420.007 , 10.81487 , "None"));
Path.Add(new Vector3(-3008.785 , -2419.717 , 10.88098 , "None"));
Path.Add(new Vector3(-3001.8 , -2419.267 , 11.35846 , "None"));
Path.Add(new Vector3(-2994.842 , -2418.515 , 12.00027 , "None"));
Path.Add(new Vector3(-2987.915 , -2417.509 , 12.99568 , "None"));
Path.Add(new Vector3(-2980.593 , -2416.238 , 14.05537 , "None"));
Path.Add(new Vector3(-2974.179 , -2414.829 , 14.85158 , "None"));
Path.Add(new Vector3(-2966.935 , -2413.165 , 15.56583 , "None"));
Path.Add(new Vector3(-2960.213 , -2411.216 , 16.25823 , "None"));
Path.Add(new Vector3(-2953.978 , -2409.159 , 16.84492 , "None"));
Path.Add(new Vector3(-2947.589 , -2406.305 , 17.92736 , "None"));
Path.Add(new Vector3(-2941.5 , -2402.865 , 18.99733 , "None"));
Path.Add(new Vector3(-2935.82 , -2398.781 , 19.61482 , "None"));
Path.Add(new Vector3(-2930.841 , -2393.869 , 21.6998 , "None"));
Path.Add(new Vector3(-2926.271 , -2388.566 , 23.31904 , "None"));
Path.Add(new Vector3(-2921.779 , -2383.198 , 24.32816 , "None"));
Path.Add(new Vector3(-2917.398 , -2377.739 , 24.37116 , "None"));
Path.Add(new Vector3(-2913.037 , -2372.263 , 24.48476 , "None"));
Path.Add(new Vector3(-2908.436 , -2366.991 , 24.99598 , "None"));
Path.Add(new Vector3(-2903.515 , -2362.015 , 26.47909 , "None"));
Path.Add(new Vector3(-2898.344 , -2357.298 , 28.90283 , "None"));
Path.Add(new Vector3(-2892.84 , -2352.3 , 30.04879 , "None"));
Path.Add(new Vector3(-2887.766 , -2347.479 , 30.91222 , "None"));
Path.Add(new Vector3(-2882.875 , -2342.473 , 31.84936 , "None"));
Path.Add(new Vector3(-2878.212 , -2336.967 , 32.88983 , "None"));
Path.Add(new Vector3(-2874.109 , -2331.297 , 33.54672 , "None"));
Path.Add(new Vector3(-2870.339 , -2325.4 , 33.95383 , "None"));
Path.Add(new Vector3(-2866.74 , -2319.396 , 34.48119 , "None"));
Path.Add(new Vector3(-2863.777 , -2313.54 , 35.41304 , "None"));
Path.Add(new Vector3(-2861.024 , -2307.104 , 37.0097 , "None"));
Path.Add(new Vector3(-2858.447 , -2300.132 , 38.33644 , "None"));
Path.Add(new Vector3(-2856.553 , -2293.399 , 38.4397 , "None"));
Path.Add(new Vector3(-2855.525 , -2286.479 , 37.17018 , "None"));
Path.Add(new Vector3(-2855.256 , -2279.922 , 35.51164 , "None"));
Path.Add(new Vector3(-2856.205 , -2272.575 , 34.58923 , "None"));
Path.Add(new Vector3(-2857.696 , -2267.093 , 34.64188 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

        








public override bool HasQuest() { return true; }


}


public sealed class GatherArathiHighlands : QuestFollowPathClass
{
    public GatherArathiHighlands()
    {
        Name = "GatherArathiHighlands";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-1939.332 , -2452.153 , 71.233 , "None"));
Path.Add(new Vector3(-1928.541 , -2445.318 , 68.77911 , "None"));
Path.Add(new Vector3(-1921.013 , -2438.026 , 67.22712 , "None"));
Path.Add(new Vector3(-1914.918 , -2430.292 , 66.13615 , "None"));
Path.Add(new Vector3(-1908.365 , -2421.274 , 63.72243 , "None"));
Path.Add(new Vector3(-1903.177 , -2412.158 , 61.47598 , "None"));
Path.Add(new Vector3(-1899.276 , -2403.119 , 59.5858 , "None"));
Path.Add(new Vector3(-1896.038 , -2393.135 , 56.20697 , "None"));
Path.Add(new Vector3(-1893.475 , -2382.954 , 52.98027 , "None"));
Path.Add(new Vector3(-1891.129 , -2372.719 , 50.35453 , "None"));
Path.Add(new Vector3(-1888.896 , -2361.794 , 48.78471 , "None"));
Path.Add(new Vector3(-1887.508 , -2352.049 , 49.21394 , "None"));
Path.Add(new Vector3(-1887.444 , -2341.558 , 51.50206 , "None"));
Path.Add(new Vector3(-1888.007 , -2331.073 , 54.49863 , "None"));
Path.Add(new Vector3(-1889.281 , -2320.653 , 56.9092 , "None"));
Path.Add(new Vector3(-1887.547 , -2310.447 , 58.05587 , "None"));
Path.Add(new Vector3(-1883.937 , -2304.592 , 58.10184 , "None"));
Path.Add(new Vector3(-1879.526 , -2295.147 , 60.02483 , "None"));
Path.Add(new Vector3(-1870.5 , -2293.64 , 60.20409 , "None"));
Path.Add(new Vector3(-1865.062 , -2294.915 , 57.02797 , "None"));
Path.Add(new Vector3(-1854.86 , -2297.395 , 52.473 , "None"));
Path.Add(new Vector3(-1848.988 , -2299.486 , 50.53186 , "None"));
Path.Add(new Vector3(-1844.369 , -2301.218 , 49.61332 , "None"));
Path.Add(new Vector3(-1839.63 , -2302.595 , 48.40867 , "None"));
Path.Add(new Vector3(-1829.191 , -2303.719 , 43.0057 , "None"));
Path.Add(new Vector3(-1818.757 , -2304.897 , 36.96827 , "None"));
Path.Add(new Vector3(-1808.292 , -2305.72 , 33.67197 , "None"));
Path.Add(new Vector3(-1797.807 , -2305.299 , 33.19494 , "None"));
Path.Add(new Vector3(-1787.062 , -2304.073 , 35.89987 , "None"));
Path.Add(new Vector3(-1777.098 , -2302.006 , 39.59129 , "None"));
Path.Add(new Vector3(-1766.992 , -2299.16 , 41.07098 , "None"));
Path.Add(new Vector3(-1756.885 , -2296.323 , 41.28017 , "None"));
Path.Add(new Vector3(-1746.223 , -2294.585 , 40.32864 , "None"));
Path.Add(new Vector3(-1741.636 , -2294.381 , 39.66042 , "None"));
Path.Add(new Vector3(-1736.734 , -2294.681 , 39.04318 , "None"));
Path.Add(new Vector3(-1733.141 , -2295.051 , 38.70067 , "None"));
Path.Add(new Vector3(-1727.602 , -2295.589 , 38.28953 , "None"));
Path.Add(new Vector3(-1727.025 , -2287.736 , 37.61256 , "None"));
Path.Add(new Vector3(-1727.205 , -2277.25 , 36.49335 , "None"));
Path.Add(new Vector3(-1728.625 , -2266.849 , 36.37694 , "None"));
Path.Add(new Vector3(-1730.365 , -2256.497 , 38.67324 , "None"));
Path.Add(new Vector3(-1733.63 , -2246.528 , 40.71067 , "None"));
Path.Add(new Vector3(-1737.433 , -2236.741 , 43.54847 , "None"));
Path.Add(new Vector3(-1741.228 , -2226.95 , 47.38115 , "None"));
Path.Add(new Vector3(-1744.145 , -2216.874 , 47.39347 , "None"));
Path.Add(new Vector3(-1745.652 , -2206.501 , 46.09765 , "None"));
Path.Add(new Vector3(-1744.538 , -2196.074 , 46.02285 , "None"));
Path.Add(new Vector3(-1742.55 , -2188.456 , 46.51046 , "None"));
Path.Add(new Vector3(-1740.613 , -2181.497 , 46.42731 , "None"));
Path.Add(new Vector3(-1738.614 , -2173.187 , 46.99417 , "None"));
Path.Add(new Vector3(-1737.617 , -2169.042 , 47.56306 , "None"));
Path.Add(new Vector3(-1736.916 , -2161.863 , 48.64976 , "None"));
Path.Add(new Vector3(-1736.749 , -2157.582 , 48.9447 , "None"));
Path.Add(new Vector3(-1736.293 , -2148.753 , 48.71989 , "None"));
Path.Add(new Vector3(-1736.072 , -2144.496 , 48.33434 , "None"));
Path.Add(new Vector3(-1734.362 , -2134.165 , 46.93864 , "None"));
Path.Add(new Vector3(-1729.517 , -2124.889 , 45.32154 , "None"));
Path.Add(new Vector3(-1727.562 , -2121.852 , 45.14532 , "None"));
Path.Add(new Vector3(-1722.231 , -2113.57 , 46.1914 , "None"));
Path.Add(new Vector3(-1717.981 , -2113.898 , 45.59397 , "None"));
Path.Add(new Vector3(-1707.64 , -2115.609 , 43.79807 , "None"));
Path.Add(new Vector3(-1698.449 , -2118.046 , 41.73242 , "None"));
Path.Add(new Vector3(-1688.151 , -2123.091 , 37.88845 , "None"));
Path.Add(new Vector3(-1679.904 , -2129.568 , 34.51805 , "None"));
Path.Add(new Vector3(-1672.27 , -2136.278 , 32.44402 , "None"));
Path.Add(new Vector3(-1664.131 , -2143.432 , 29.97801 , "None"));
Path.Add(new Vector3(-1656.31 , -2150.437 , 28.16755 , "None"));
Path.Add(new Vector3(-1649.281 , -2157.336 , 27.58321 , "None"));
Path.Add(new Vector3(-1641.559 , -2165.376 , 28.75214 , "None"));
Path.Add(new Vector3(-1635.651 , -2173.24 , 30.43056 , "None"));
Path.Add(new Vector3(-1630.629 , -2182.451 , 31.09027 , "None"));
Path.Add(new Vector3(-1625.748 , -2192.477 , 31.83411 , "None"));
Path.Add(new Vector3(-1621.152 , -2201.918 , 32.78141 , "None"));
Path.Add(new Vector3(-1615.998 , -2211.058 , 32.42977 , "None"));
Path.Add(new Vector3(-1612.989 , -2215.764 , 32.10995 , "None"));
Path.Add(new Vector3(-1608.632 , -2221.526 , 31.97988 , "None"));
Path.Add(new Vector3(-1605.668 , -2225.446 , 32.0997 , "None"));
Path.Add(new Vector3(-1603.028 , -2228.373 , 32.30038 , "None"));
Path.Add(new Vector3(-1596.093 , -2235.362 , 32.81384 , "None"));
Path.Add(new Vector3(-1585.848 , -2236.952 , 33.68071 , "None"));
Path.Add(new Vector3(-1575.348 , -2236.939 , 34.347 , "None"));
Path.Add(new Vector3(-1564.849 , -2236.862 , 34.73308 , "None"));
Path.Add(new Vector3(-1554.349 , -2236.785 , 34.90075 , "None"));
Path.Add(new Vector3(-1543.852 , -2236.565 , 34.75352 , "None"));
Path.Add(new Vector3(-1533.358 , -2236.195 , 33.82728 , "None"));
Path.Add(new Vector3(-1522.89 , -2235.434 , 32.07534 , "None"));
Path.Add(new Vector3(-1512.597 , -2233.378 , 29.41994 , "None"));
Path.Add(new Vector3(-1503.4 , -2228.476 , 25.43807 , "None"));
Path.Add(new Vector3(-1496.013 , -2221.017 , 22.66607 , "None"));
Path.Add(new Vector3(-1488.38 , -2213.806 , 21.71441 , "None"));
Path.Add(new Vector3(-1480.68 , -2206.669 , 21.56138 , "None"));
Path.Add(new Vector3(-1472.842 , -2199.682 , 20.95253 , "None"));
Path.Add(new Vector3(-1465.383 , -2192.298 , 19.67207 , "None"));
Path.Add(new Vector3(-1459.757 , -2183.483 , 19.46903 , "None"));
Path.Add(new Vector3(-1455.813 , -2173.807 , 19.51167 , "None"));
Path.Add(new Vector3(-1454.392 , -2163.422 , 19.52512 , "None"));
Path.Add(new Vector3(-1453.42 , -2152.968 , 20.40391 , "None"));
Path.Add(new Vector3(-1451.839 , -2142.608 , 18.65366 , "None"));
Path.Add(new Vector3(-1449.716 , -2136.419 , 18.12473 , "None"));
Path.Add(new Vector3(-1445.802 , -2130.756 , 18.75669 , "None"));
Path.Add(new Vector3(-1450.565 , -2124.506 , 17.94966 , "None"));
Path.Add(new Vector3(-1458.511 , -2117.666 , 18.30764 , "None"));
Path.Add(new Vector3(-1467.112 , -2111.655 , 19.8562 , "None"));
Path.Add(new Vector3(-1476.158 , -2106.326 , 20.74908 , "None"));
Path.Add(new Vector3(-1485.535 , -2101.606 , 19.97356 , "None"));
Path.Add(new Vector3(-1495.007 , -2097.075 , 18.95672 , "None"));
Path.Add(new Vector3(-1504.479 , -2092.544 , 20.88482 , "None"));
Path.Add(new Vector3(-1513.951 , -2088.012 , 22.64264 , "None"));
Path.Add(new Vector3(-1523.423 , -2083.481 , 24.61755 , "None"));
Path.Add(new Vector3(-1532.879 , -2078.957 , 28.39757 , "None"));
Path.Add(new Vector3(-1542.351 , -2074.426 , 31.37833 , "None"));
Path.Add(new Vector3(-1551.774 , -2069.802 , 31.96988 , "None"));
Path.Add(new Vector3(-1557.685 , -2061.215 , 31.53823 , "None"));
Path.Add(new Vector3(-1567.059 , -2056.89 , 32.19324 , "None"));
Path.Add(new Vector3(-1577.547 , -2056.952 , 33.48449 , "None"));
Path.Add(new Vector3(-1587.44 , -2053.81 , 33.77562 , "None"));
Path.Add(new Vector3(-1590.129 , -2051.407 , 33.93919 , "None"));
Path.Add(new Vector3(-1600.664 , -2044.223 , 35.96518 , "None"));
Path.Add(new Vector3(-1609.272 , -2039.437 , 34.46284 , "None"));
Path.Add(new Vector3(-1619.03 , -2034.041 , 32.69453 , "None"));
Path.Add(new Vector3(-1623.919 , -2031.338 , 32.03114 , "None"));
Path.Add(new Vector3(-1627.079 , -2029.589 , 31.76672 , "None"));
Path.Add(new Vector3(-1627.597 , -2025.337 , 31.27814 , "None"));
Path.Add(new Vector3(-1628.272 , -2019.792 , 31.02586 , "None"));
Path.Add(new Vector3(-1617.871 , -2016.777 , 31.33527 , "None"));
Path.Add(new Vector3(-1607.841 , -2015.162 , 31.54874 , "None"));
Path.Add(new Vector3(-1597.428 , -2013.822 , 31.93263 , "None"));
Path.Add(new Vector3(-1586.659 , -2012.617 , 33.55309 , "None"));
Path.Add(new Vector3(-1576.546 , -2011.628 , 34.88602 , "None"));
Path.Add(new Vector3(-1566.068 , -2010.953 , 35.87334 , "None"));
Path.Add(new Vector3(-1555.254 , -2010.257 , 34.47841 , "None"));
Path.Add(new Vector3(-1545.133 , -2009.357 , 32.71199 , "None"));
Path.Add(new Vector3(-1534.734 , -2007.911 , 33.35055 , "None"));
Path.Add(new Vector3(-1524.536 , -2005.474 , 34.3341 , "None"));
Path.Add(new Vector3(-1514.731 , -2001.725 , 34.64741 , "None"));
Path.Add(new Vector3(-1505.061 , -1997.636 , 33.48906 , "None"));
Path.Add(new Vector3(-1495.48 , -1993.339 , 32.96493 , "None"));
Path.Add(new Vector3(-1486.295 , -1988.271 , 34.31467 , "None"));
Path.Add(new Vector3(-1477.143 , -1982.469 , 36.96919 , "None"));
Path.Add(new Vector3(-1468.559 , -1977.027 , 39.46097 , "None"));
Path.Add(new Vector3(-1459.15 , -1971.682 , 42.02984 , "None"));
Path.Add(new Vector3(-1449.563 , -1967.405 , 43.55516 , "None"));
Path.Add(new Vector3(-1439.806 , -1963.526 , 44.4239 , "None"));
Path.Add(new Vector3(-1430.049 , -1959.646 , 44.85421 , "None"));
Path.Add(new Vector3(-1420.307 , -1955.772 , 45.56695 , "None"));
Path.Add(new Vector3(-1410.55 , -1951.893 , 46.77856 , "None"));
Path.Add(new Vector3(-1400.793 , -1948.013 , 48.21832 , "None"));
Path.Add(new Vector3(-1391.437 , -1943.307 , 49.62993 , "None"));
Path.Add(new Vector3(-1382.986 , -1938.248 , 50.93132 , "None"));
Path.Add(new Vector3(-1373.978 , -1932.855 , 53.30993 , "None"));
Path.Add(new Vector3(-1364.605 , -1926.827 , 56.75033 , "None"));
Path.Add(new Vector3(-1357.044 , -1919.582 , 58.22727 , "None"));
Path.Add(new Vector3(-1351.083 , -1910.95 , 58.41346 , "None"));
Path.Add(new Vector3(-1346.214 , -1901.651 , 58.82207 , "None"));
Path.Add(new Vector3(-1341.973 , -1892.766 , 59.52618 , "None"));
Path.Add(new Vector3(-1338.015 , -1883.058 , 60.3211 , "None"));
Path.Add(new Vector3(-1334.621 , -1873.125 , 61.07536 , "None"));
Path.Add(new Vector3(-1331.861 , -1862.996 , 61.78364 , "None"));
Path.Add(new Vector3(-1330.793 , -1851.952 , 62.30489 , "None"));
Path.Add(new Vector3(-1334.526 , -1842.346 , 62.3595 , "None"));
Path.Add(new Vector3(-1343.359 , -1836.755 , 61.7465 , "None"));
Path.Add(new Vector3(-1352.259 , -1832.539 , 61.04483 , "None"));
Path.Add(new Vector3(-1361.955 , -1828.512 , 60.22789 , "None"));
Path.Add(new Vector3(-1371.728 , -1824.672 , 59.36511 , "None"));
Path.Add(new Vector3(-1381.503 , -1820.84 , 58.98392 , "None"));
Path.Add(new Vector3(-1391.279 , -1817.008 , 59.15366 , "None"));
Path.Add(new Vector3(-1401.055 , -1813.176 , 59.61092 , "None"));
Path.Add(new Vector3(-1410.836 , -1809.359 , 60.25523 , "None"));
Path.Add(new Vector3(-1420.716 , -1805.806 , 60.63306 , "None"));
Path.Add(new Vector3(-1430.847 , -1803.063 , 61.34155 , "None"));
Path.Add(new Vector3(-1441.168 , -1801.188 , 62.14353 , "None"));
Path.Add(new Vector3(-1451.643 , -1800.52 , 65.02753 , "None"));
Path.Add(new Vector3(-1462.008 , -1802.016 , 67.46202 , "None"));
Path.Add(new Vector3(-1472.01 , -1805.156 , 68.00174 , "None"));
Path.Add(new Vector3(-1481.549 , -1809.544 , 68.07361 , "None"));
Path.Add(new Vector3(-1486.614 , -1811.852 , 68.07361 , "None"));
Path.Add(new Vector3(-1492.344 , -1811.588 , 68.0738 , "None"));
Path.Add(new Vector3(-1501.894 , -1807.224 , 67.84064 , "None"));
Path.Add(new Vector3(-1511.884 , -1804.062 , 66.26582 , "None"));
Path.Add(new Vector3(-1522.236 , -1802.353 , 65.85659 , "None"));
Path.Add(new Vector3(-1532.725 , -1801.942 , 65.95686 , "None"));
Path.Add(new Vector3(-1543.225 , -1801.938 , 66.88584 , "None"));
Path.Add(new Vector3(-1553.631 , -1800.667 , 67.84087 , "None"));
Path.Add(new Vector3(-1563.219 , -1796.508 , 67.87286 , "None"));
Path.Add(new Vector3(-1570.336 , -1788.944 , 67.43546 , "None"));
Path.Add(new Vector3(-1574.968 , -1779.528 , 67.3207 , "None"));
Path.Add(new Vector3(-1577.806 , -1769.119 , 67.33001 , "None"));
Path.Add(new Vector3(-1579.592 , -1759.091 , 66.74574 , "None"));
Path.Add(new Vector3(-1581.55 , -1748.455 , 66.58977 , "None"));
Path.Add(new Vector3(-1583.432 , -1738.125 , 67.25616 , "None"));
Path.Add(new Vector3(-1584.733 , -1727.714 , 67.44019 , "None"));
Path.Add(new Vector3(-1584.587 , -1717.226 , 67.15185 , "None"));
Path.Add(new Vector3(-1583.269 , -1706.814 , 66.68272 , "None"));
Path.Add(new Vector3(-1579.751 , -1696.962 , 66.13791 , "None"));
Path.Add(new Vector3(-1571.112 , -1692.185 , 66.11845 , "None"));
Path.Add(new Vector3(-1561.082 , -1695.139 , 66.81654 , "None"));
Path.Add(new Vector3(-1551.487 , -1699.366 , 66.29533 , "None"));
Path.Add(new Vector3(-1543.416 , -1706.054 , 66.39282 , "None"));
Path.Add(new Vector3(-1537.276 , -1714.548 , 66.45941 , "None"));
Path.Add(new Vector3(-1532.725 , -1723.998 , 66.17202 , "None"));
Path.Add(new Vector3(-1529.891 , -1734.099 , 66.38459 , "None"));
Path.Add(new Vector3(-1528.084 , -1744.437 , 66.79071 , "None"));
Path.Add(new Vector3(-1527.38 , -1754.908 , 66.91999 , "None"));
Path.Add(new Vector3(-1527.499 , -1765.407 , 67.24513 , "None"));
Path.Add(new Vector3(-1527.985 , -1775.895 , 67.64439 , "None"));
Path.Add(new Vector3(-1528.481 , -1786.383 , 68.34038 , "None"));
Path.Add(new Vector3(-1528.603 , -1796.872 , 70.95975 , "None"));
Path.Add(new Vector3(-1528.636 , -1807.372 , 71.49751 , "None"));
Path.Add(new Vector3(-1529.183 , -1817.855 , 69.50985 , "None"));
Path.Add(new Vector3(-1530.547 , -1828.266 , 68.06273 , "None"));
Path.Add(new Vector3(-1531.977 , -1838.667 , 68.00365 , "None"));
Path.Add(new Vector3(-1533.686 , -1849.019 , 67.95566 , "None"));
Path.Add(new Vector3(-1535.598 , -1853.532 , 67.67252 , "None"));
Path.Add(new Vector3(-1541.492 , -1858.234 , 67.11871 , "None"));
Path.Add(new Vector3(-1548.674 , -1863.98 , 67.36057 , "None"));
Path.Add(new Vector3(-1548.669 , -1869.545 , 67.42828 , "None"));
Path.Add(new Vector3(-1548.558 , -1880.043 , 67.64896 , "None"));
Path.Add(new Vector3(-1548.609 , -1884.978 , 67.63257 , "None"));
Path.Add(new Vector3(-1548.718 , -1895.478 , 67.81415 , "None"));
Path.Add(new Vector3(-1548.769 , -1900.412 , 67.92966 , "None"));
Path.Add(new Vector3(-1548.805 , -1905.326 , 67.7524 , "None"));
Path.Add(new Vector3(-1548.609 , -1908.933 , 67.84216 , "None"));
Path.Add(new Vector3(-1547.265 , -1918.687 , 68.47002 , "None"));
Path.Add(new Vector3(-1546.518 , -1923.224 , 69.02402 , "None"));
Path.Add(new Vector3(-1549.228 , -1915.14 , 68.08608 , "None"));
Path.Add(new Vector3(-1542.148 , -1909.49 , 68.25141 , "None"));
Path.Add(new Vector3(-1538.054 , -1908.304 , 68.80315 , "None"));
Path.Add(new Vector3(-1532.681 , -1906.854 , 68.937 , "None"));
Path.Add(new Vector3(-1528.427 , -1907.126 , 68.51865 , "None"));
Path.Add(new Vector3(-1523.084 , -1908.568 , 68.49252 , "None"));
Path.Add(new Vector3(-1519.345 , -1910.616 , 68.45189 , "None"));
Path.Add(new Vector3(-1514.446 , -1913.3 , 68.57787 , "None"));
Path.Add(new Vector3(-1510.735 , -1904.277 , 68.59251 , "None"));
Path.Add(new Vector3(-1508.539 , -1897.749 , 68.5789 , "None"));
Path.Add(new Vector3(-1507.206 , -1893.715 , 68.50085 , "None"));
Path.Add(new Vector3(-1505.411 , -1887.764 , 68.54372 , "None"));
Path.Add(new Vector3(-1504.082 , -1883.361 , 68.26273 , "None"));
Path.Add(new Vector3(-1502.662 , -1878.657 , 68.3631 , "None"));
Path.Add(new Vector3(-1500.011 , -1869.871 , 68.50385 , "None"));
Path.Add(new Vector3(-1498.189 , -1863.229 , 68.65321 , "None"));
Path.Add(new Vector3(-1497.066 , -1857.779 , 68.48206 , "None"));
Path.Add(new Vector3(-1496.208 , -1853.603 , 68.43817 , "None"));
Path.Add(new Vector3(-1495.51 , -1850.081 , 68.45155 , "None"));
Path.Add(new Vector3(-1495.633 , -1844.496 , 68.53676 , "None"));
Path.Add(new Vector3(-1497.838 , -1850.071 , 68.72512 , "None"));
Path.Add(new Vector3(-1499.577 , -1860.426 , 68.62373 , "None"));
Path.Add(new Vector3(-1501.406 , -1870.765 , 68.54111 , "None"));
Path.Add(new Vector3(-1503.778 , -1880.99 , 68.29391 , "None"));
Path.Add(new Vector3(-1506.875 , -1891.009 , 68.65588 , "None"));
Path.Add(new Vector3(-1511.864 , -1900.209 , 68.60504 , "None"));
Path.Add(new Vector3(-1519.355 , -1907.548 , 68.5722 , "None"));
Path.Add(new Vector3(-1527.646 , -1913.976 , 68.25368 , "None"));
Path.Add(new Vector3(-1533.363 , -1916.49 , 68.74263 , "None"));
Path.Add(new Vector3(-1536.595 , -1914.884 , 68.57716 , "None"));
Path.Add(new Vector3(-1544.67 , -1908.226 , 68.09983 , "None"));
Path.Add(new Vector3(-1547.339 , -1904.101 , 67.86377 , "None"));
Path.Add(new Vector3(-1548.921 , -1899.452 , 67.95963 , "None"));
Path.Add(new Vector3(-1549.301 , -1890.289 , 67.55047 , "None"));
Path.Add(new Vector3(-1549.099 , -1879.791 , 67.63819 , "None"));
Path.Add(new Vector3(-1548.892 , -1869.293 , 67.43395 , "None"));
Path.Add(new Vector3(-1548.842 , -1864.358 , 67.37892 , "None"));
Path.Add(new Vector3(-1537.64 , -1856.345 , 67.47043 , "None"));
Path.Add(new Vector3(-1530.187 , -1849.058 , 67.69201 , "None"));
Path.Add(new Vector3(-1526.54 , -1839.296 , 67.95102 , "None"));
Path.Add(new Vector3(-1526.1 , -1831.437 , 68.08517 , "None"));
Path.Add(new Vector3(-1527.295 , -1823.09 , 68.34061 , "None"));
Path.Add(new Vector3(-1527.991 , -1809.774 , 71.31177 , "None"));
Path.Add(new Vector3(-1528.221 , -1798.94 , 71.11962 , "None"));
Path.Add(new Vector3(-1528.319 , -1788.441 , 68.34035 , "None"));
Path.Add(new Vector3(-1528.171 , -1778.278 , 67.7431 , "None"));
Path.Add(new Vector3(-1527.694 , -1767.454 , 67.40662 , "None"));
Path.Add(new Vector3(-1527.382 , -1756.96 , 66.92882 , "None"));
Path.Add(new Vector3(-1527.223 , -1746.461 , 66.9656 , "None"));
Path.Add(new Vector3(-1528.273 , -1736.055 , 66.51151 , "None"));
Path.Add(new Vector3(-1532.031 , -1726.268 , 66.17902 , "None"));
Path.Add(new Vector3(-1537.422 , -1718.461 , 66.27945 , "None"));
Path.Add(new Vector3(-1545.461 , -1710.282 , 66.2619 , "None"));
Path.Add(new Vector3(-1553.36 , -1704.404 , 66.12136 , "None"));
Path.Add(new Vector3(-1562.289 , -1698.888 , 66.46239 , "None"));
Path.Add(new Vector3(-1571.69 , -1694.219 , 66.09975 , "None"));
Path.Add(new Vector3(-1581.997 , -1689.971 , 66.06237 , "None"));
Path.Add(new Vector3(-1586.687 , -1688.503 , 66.20357 , "None"));
Path.Add(new Vector3(-1586.629 , -1696.378 , 66.53511 , "None"));
Path.Add(new Vector3(-1586.556 , -1706.206 , 66.94128 , "None"));
Path.Add(new Vector3(-1586.358 , -1716.704 , 67.18297 , "None"));
Path.Add(new Vector3(-1585.66 , -1727.179 , 67.42371 , "None"));
Path.Add(new Vector3(-1584.305 , -1737.59 , 67.29077 , "None"));
Path.Add(new Vector3(-1582.719 , -1747.969 , 66.61203 , "None"));
Path.Add(new Vector3(-1580.914 , -1758.313 , 66.68691 , "None"));
Path.Add(new Vector3(-1579.094 , -1768.654 , 67.1473 , "None"));
Path.Add(new Vector3(-1576.838 , -1778.905 , 67.26022 , "None"));
Path.Add(new Vector3(-1572.941 , -1788.634 , 67.24954 , "None"));
Path.Add(new Vector3(-1566.487 , -1796.835 , 67.61594 , "None"));
Path.Add(new Vector3(-1557.479 , -1802.117 , 67.62701 , "None"));
Path.Add(new Vector3(-1547.341 , -1804.759 , 67.27238 , "None"));
Path.Add(new Vector3(-1543.112 , -1805.291 , 66.80565 , "None"));
Path.Add(new Vector3(-1532.644 , -1806.009 , 65.96679 , "None"));
Path.Add(new Vector3(-1522.144 , -1806.05 , 65.87478 , "None"));
Path.Add(new Vector3(-1511.645 , -1805.973 , 66.33599 , "None"));
Path.Add(new Vector3(-1501.148 , -1805.73 , 67.92857 , "None"));
Path.Add(new Vector3(-1490.657 , -1805.3 , 68.06653 , "None"));
Path.Add(new Vector3(-1480.173 , -1804.723 , 68.07377 , "None"));
Path.Add(new Vector3(-1469.689 , -1804.131 , 67.89751 , "None"));
Path.Add(new Vector3(-1461.177 , -1803.657 , 67.34571 , "None"));
Path.Add(new Vector3(-1456.919 , -1803.442 , 66.63884 , "None"));
Path.Add(new Vector3(-1446.428 , -1803.026 , 63.26028 , "None"));
Path.Add(new Vector3(-1435.969 , -1803.677 , 61.56701 , "None"));
Path.Add(new Vector3(-1425.647 , -1805.599 , 60.87788 , "None"));
Path.Add(new Vector3(-1415.474 , -1808.186 , 60.44846 , "None"));
Path.Add(new Vector3(-1405.499 , -1811.463 , 60.04363 , "None"));
Path.Add(new Vector3(-1395.594 , -1814.948 , 59.10091 , "None"));
Path.Add(new Vector3(-1385.799 , -1818.727 , 58.87819 , "None"));
Path.Add(new Vector3(-1376.079 , -1822.698 , 59.04937 , "None"));
Path.Add(new Vector3(-1366.437 , -1826.856 , 59.83099 , "None"));
Path.Add(new Vector3(-1356.891 , -1831.227 , 60.6454 , "None"));
Path.Add(new Vector3(-1347.463 , -1835.849 , 61.3948 , "None"));
Path.Add(new Vector3(-1335.683 , -1841.638 , 62.27619 , "None"));
Path.Add(new Vector3(-1327.782 , -1842.762 , 62.93369 , "None"));
Path.Add(new Vector3(-1319.416 , -1836.664 , 63.84645 , "None"));
Path.Add(new Vector3(-1313.157 , -1828.235 , 64.58307 , "None"));
Path.Add(new Vector3(-1306.098 , -1820.043 , 65.32594 , "None"));
Path.Add(new Vector3(-1298.289 , -1813.545 , 65.96403 , "None"));
Path.Add(new Vector3(-1289.952 , -1807.163 , 66.79652 , "None"));
Path.Add(new Vector3(-1280.992 , -1801.071 , 67.36 , "None"));
Path.Add(new Vector3(-1272.425 , -1795.602 , 67.22544 , "None"));
Path.Add(new Vector3(-1268.262 , -1792.951 , 67.10535 , "None"));
Path.Add(new Vector3(-1264.666 , -1790.662 , 66.89095 , "None"));
Path.Add(new Vector3(-1255.809 , -1785.023 , 66.29389 , "None"));
Path.Add(new Vector3(-1247.501 , -1779.733 , 65.56613 , "None"));
Path.Add(new Vector3(-1238.644 , -1774.094 , 64.48743 , "None"));
Path.Add(new Vector3(-1229.741 , -1768.527 , 63.09557 , "None"));
Path.Add(new Vector3(-1219.738 , -1763.638 , 61.67693 , "None"));
Path.Add(new Vector3(-1210.139 , -1761.472 , 59.82367 , "None"));
Path.Add(new Vector3(-1199.728 , -1760.117 , 58.22136 , "None"));
Path.Add(new Vector3(-1188.592 , -1759.635 , 57.82061 , "None"));
Path.Add(new Vector3(-1178.748 , -1759.892 , 57.4249 , "None"));
Path.Add(new Vector3(-1168.268 , -1760.52 , 55.78714 , "None"));
Path.Add(new Vector3(-1162.746 , -1761.21 , 54.72216 , "None"));
Path.Add(new Vector3(-1156.338 , -1765.567 , 54.32025 , "None"));
Path.Add(new Vector3(-1153.986 , -1771.975 , 55.12957 , "None"));
Path.Add(new Vector3(-1150.484 , -1782.562 , 55.36606 , "None"));
Path.Add(new Vector3(-1147.39 , -1792.594 , 55.16105 , "None"));
Path.Add(new Vector3(-1144.808 , -1802.771 , 55.13465 , "None"));
Path.Add(new Vector3(-1142.432 , -1813.321 , 56.00771 , "None"));
Path.Add(new Vector3(-1140.842 , -1823.378 , 57.68523 , "None"));
Path.Add(new Vector3(-1139.996 , -1833.842 , 61.57363 , "None"));
Path.Add(new Vector3(-1139.907 , -1842.361 , 65.19886 , "None"));
Path.Add(new Vector3(-1140.413 , -1847.922 , 66.81023 , "None"));
Path.Add(new Vector3(-1141.796 , -1858.331 , 69.69749 , "None"));
Path.Add(new Vector3(-1142.666 , -1865.477 , 72.57974 , "None"));
Path.Add(new Vector3(-1142.574 , -1869.739 , 74.13161 , "None"));
Path.Add(new Vector3(-1141.782 , -1882.84 , 75.65466 , "None"));
Path.Add(new Vector3(-1141.484 , -1887.766 , 76.01521 , "None"));
Path.Add(new Vector3(-1141.146 , -1893.32 , 77.77204 , "None"));
Path.Add(new Vector3(-1139.627 , -1897.302 , 77.97528 , "None"));
Path.Add(new Vector3(-1136.325 , -1903.344 , 78.13866 , "None"));
Path.Add(new Vector3(-1132.195 , -1911.539 , 78.28587 , "None"));
Path.Add(new Vector3(-1128.793 , -1918.29 , 77.52177 , "None"));
Path.Add(new Vector3(-1124.068 , -1927.667 , 75.77463 , "None"));
Path.Add(new Vector3(-1120.524 , -1934.699 , 73.88487 , "None"));
Path.Add(new Vector3(-1113.366 , -1935.44 , 73.37098 , "None"));
Path.Add(new Vector3(-1106.457 , -1935.44 , 72.02715 , "None"));
Path.Add(new Vector3(-1097.932 , -1935.378 , 69.79343 , "None"));
Path.Add(new Vector3(-1087.432 , -1935.267 , 68.19326 , "None"));
Path.Add(new Vector3(-1076.935 , -1935.048 , 66.8401 , "None"));
Path.Add(new Vector3(-1066.461 , -1934.316 , 65.87709 , "None"));
Path.Add(new Vector3(-1055.993 , -1933.495 , 65.07092 , "None"));
Path.Add(new Vector3(-1045.545 , -1932.454 , 63.50026 , "None"));
Path.Add(new Vector3(-1035.061 , -1931.894 , 61.52106 , "None"));
Path.Add(new Vector3(-1024.569 , -1931.501 , 62.27378 , "None"));
Path.Add(new Vector3(-1014.076 , -1931.115 , 62.99491 , "None"));
Path.Add(new Vector3(-1003.579 , -1930.882 , 64.00451 , "None"));
Path.Add(new Vector3(-993.0795 , -1930.763 , 64.04752 , "None"));
Path.Add(new Vector3(-982.5802 , -1930.645 , 62.73726 , "None"));
Path.Add(new Vector3(-974.3698 , -1930.552 , 61.39711 , "None"));
Path.Add(new Vector3(-977.5693 , -1925.223 , 63.34392 , "None"));
Path.Add(new Vector3(-982.9236 , -1916.191 , 65.45248 , "None"));
Path.Add(new Vector3(-988.2462 , -1907.14 , 63.48034 , "None"));
Path.Add(new Vector3(-990.4127 , -1903.444 , 62.4189 , "None"));
Path.Add(new Vector3(-992.7903 , -1899.144 , 61.70086 , "None"));
Path.Add(new Vector3(-994.1031 , -1894.408 , 61.36481 , "None"));
Path.Add(new Vector3(-994.0103 , -1890.147 , 61.15116 , "None"));
Path.Add(new Vector3(-989.0995 , -1890.316 , 61.189 , "None"));
Path.Add(new Vector3(-978.6375 , -1891.195 , 62.46739 , "None"));
Path.Add(new Vector3(-968.1698 , -1892.012 , 65.16299 , "None"));
Path.Add(new Vector3(-957.6811 , -1892.495 , 66.4882 , "None"));
Path.Add(new Vector3(-949.6277 , -1891.067 , 67.05667 , "None"));
Path.Add(new Vector3(-945.452 , -1890.11 , 67.35135 , "None"));
Path.Add(new Vector3(-940.0082 , -1880.412 , 68.08894 , "None"));
Path.Add(new Vector3(-935.9256 , -1870.738 , 68.07701 , "None"));
Path.Add(new Vector3(-932.8152 , -1862.083 , 67.10771 , "None"));
Path.Add(new Vector3(-933.2945 , -1856.201 , 65.53665 , "None"));
Path.Add(new Vector3(-934.1664 , -1846.075 , 61.52842 , "None"));
Path.Add(new Vector3(-935.0128 , -1835.609 , 56.60302 , "None"));
Path.Add(new Vector3(-935.6115 , -1825.779 , 53.07732 , "None"));
Path.Add(new Vector3(-936.2594 , -1814.31 , 51.31692 , "None"));
Path.Add(new Vector3(-936.7782 , -1805.126 , 50.47065 , "None"));
Path.Add(new Vector3(-937.8007 , -1796.027 , 50.06501 , "None"));
Path.Add(new Vector3(-941.6246 , -1786.255 , 50.54456 , "None"));
Path.Add(new Vector3(-946.6006 , -1777.016 , 49.98194 , "None"));
Path.Add(new Vector3(-951.9088 , -1767.956 , 49.19303 , "None"));
Path.Add(new Vector3(-957.3252 , -1758.962 , 49.58652 , "None"));
Path.Add(new Vector3(-964.3607 , -1750.344 , 49.88309 , "None"));
Path.Add(new Vector3(-972.2747 , -1742.489 , 47.24921 , "None"));
Path.Add(new Vector3(-978.8831 , -1735.187 , 43.32518 , "None"));
Path.Add(new Vector3(-985.0923 , -1726.734 , 40.03248 , "None"));
Path.Add(new Vector3(-990.1202 , -1716.792 , 38.41655 , "None"));
Path.Add(new Vector3(-994.4555 , -1707.228 , 36.96806 , "None"));
Path.Add(new Vector3(-999.0217 , -1697.778 , 36.75256 , "None"));
Path.Add(new Vector3(-1003.368 , -1688.94 , 37.05249 , "None"));
Path.Add(new Vector3(-1008.001 , -1679.517 , 37.16676 , "None"));
Path.Add(new Vector3(-1010.671 , -1673.168 , 37.32215 , "None"));
Path.Add(new Vector3(-1012.584 , -1668.619 , 36.03436 , "None"));
Path.Add(new Vector3(-1013.723 , -1664.511 , 34.99048 , "None"));
Path.Add(new Vector3(-1014.981 , -1659.761 , 34.94628 , "None"));
Path.Add(new Vector3(-1007.389 , -1649.055 , 35.31444 , "None"));
Path.Add(new Vector3(-1002.015 , -1641.618 , 36.40403 , "None"));
Path.Add(new Vector3(-997.0626 , -1636.839 , 37.40247 , "None"));
Path.Add(new Vector3(-992.2073 , -1634.184 , 37.86248 , "None"));
Path.Add(new Vector3(-985.1177 , -1632.849 , 38.70789 , "None"));
Path.Add(new Vector3(-976.9336 , -1633.467 , 40.28797 , "None"));
Path.Add(new Vector3(-970.9227 , -1634.996 , 41.53154 , "None"));
Path.Add(new Vector3(-965.8931 , -1637.408 , 42.20498 , "None"));
Path.Add(new Vector3(-960.8228 , -1641.021 , 42.68048 , "None"));
Path.Add(new Vector3(-957.9742 , -1643.242 , 42.95581 , "None"));
Path.Add(new Vector3(-955.1257 , -1645.463 , 43.25128 , "None"));
Path.Add(new Vector3(-952.2936 , -1647.671 , 43.56582 , "None"));
Path.Add(new Vector3(-943.9768 , -1654.08 , 44.59422 , "None"));
Path.Add(new Vector3(-935.4923 , -1660.265 , 43.72535 , "None"));
Path.Add(new Vector3(-926.9766 , -1666.408 , 43.79106 , "None"));
Path.Add(new Vector3(-918.4608 , -1672.551 , 45.07615 , "None"));
Path.Add(new Vector3(-909.9451 , -1678.693 , 49.4996 , "None"));
Path.Add(new Vector3(-901.4241 , -1684.828 , 51.06489 , "None"));
Path.Add(new Vector3(-892.4854 , -1690.314 , 53.52519 , "None"));
Path.Add(new Vector3(-882.5749 , -1693.75 , 55.58596 , "None"));
Path.Add(new Vector3(-872.5652 , -1696.921 , 56.16882 , "None"));
Path.Add(new Vector3(-862.5555 , -1700.092 , 54.1936 , "None"));
Path.Add(new Vector3(-852.6225 , -1703.46 , 54.35961 , "None"));
Path.Add(new Vector3(-842.7747 , -1707.103 , 56.5293 , "None"));
Path.Add(new Vector3(-833.1424 , -1711.274 , 56.55094 , "None"));
Path.Add(new Vector3(-823.7098 , -1715.887 , 56.10241 , "None"));
Path.Add(new Vector3(-814.8459 , -1721.49 , 57.25594 , "None"));
Path.Add(new Vector3(-806.465 , -1727.815 , 56.3116 , "None"));
Path.Add(new Vector3(-802.6725 , -1730.939 , 55.06522 , "None"));
Path.Add(new Vector3(-794.5341 , -1737.572 , 52.25965 , "None"));
Path.Add(new Vector3(-786.2542 , -1744.029 , 52.99084 , "None"));
Path.Add(new Vector3(-777.9734 , -1750.485 , 57.05243 , "None"));
Path.Add(new Vector3(-769.6927 , -1756.941 , 60.40458 , "None"));
Path.Add(new Vector3(-761.722 , -1763.759 , 57.70685 , "None"));
Path.Add(new Vector3(-755.0304 , -1771.832 , 55.4537 , "None"));
Path.Add(new Vector3(-749.76 , -1780.905 , 57.10583 , "None"));
Path.Add(new Vector3(-744.9072 , -1790.216 , 58.57833 , "None"));
Path.Add(new Vector3(-740.7899 , -1799.866 , 58.25668 , "None"));
Path.Add(new Vector3(-738.428 , -1810.089 , 58.76016 , "None"));
Path.Add(new Vector3(-736.2015 , -1820.35 , 60.67527 , "None"));
Path.Add(new Vector3(-733.7354 , -1830.556 , 60.91053 , "None"));
Path.Add(new Vector3(-731.3727 , -1840.786 , 59.78919 , "None"));
Path.Add(new Vector3(-729.0873 , -1851.035 , 54.89185 , "None"));
Path.Add(new Vector3(-726.3572 , -1861.166 , 51.66229 , "None"));
Path.Add(new Vector3(-722.218 , -1870.814 , 50.57909 , "None"));
Path.Add(new Vector3(-717.996 , -1880.427 , 49.07495 , "None"));
Path.Add(new Vector3(-713.8599 , -1890.078 , 47.95213 , "None"));
Path.Add(new Vector3(-709.9891 , -1899.828 , 48.69273 , "None"));
Path.Add(new Vector3(-706.0643 , -1909.567 , 50.42294 , "None"));
Path.Add(new Vector3(-701.0075 , -1919.139 , 52.88663 , "None"));
Path.Add(new Vector3(-697.3454 , -1924.177 , 54.48019 , "None"));
Path.Add(new Vector3(-692.4973 , -1929.95 , 55.95958 , "None"));
Path.Add(new Vector3(-688.9094 , -1934.223 , 56.80466 , "None"));
Path.Add(new Vector3(-677.7152 , -1933.907 , 58.78971 , "None"));
Path.Add(new Vector3(-668.7338 , -1930.811 , 59.82101 , "None"));
Path.Add(new Vector3(-664.8041 , -1929.159 , 60.15228 , "None"));
Path.Add(new Vector3(-661.2305 , -1927.484 , 60.4 , "None"));
Path.Add(new Vector3(-655.6401 , -1923.46 , 60.67841 , "None"));
Path.Add(new Vector3(-650.578 , -1919.816 , 60.6733 , "None"));
Path.Add(new Vector3(-650.6459 , -1930.811 , 60.58828 , "None"));
Path.Add(new Vector3(-651.6118 , -1941.266 , 59.54376 , "None"));
Path.Add(new Vector3(-652.523 , -1951.727 , 57.81755 , "None"));
Path.Add(new Vector3(-653.4343 , -1962.187 , 55.78271 , "None"));
Path.Add(new Vector3(-654.3456 , -1972.647 , 55.29704 , "None"));
Path.Add(new Vector3(-655.2569 , -1983.108 , 56.64197 , "None"));
Path.Add(new Vector3(-657.2924 , -1991.339 , 57.85193 , "None"));
Path.Add(new Vector3(-657.6604 , -1998.148 , 59.07598 , "None"));
Path.Add(new Vector3(-656.4109 , -2008.573 , 60.2002 , "None"));
Path.Add(new Vector3(-655.1423 , -2018.996 , 59.38178 , "None"));
Path.Add(new Vector3(-656.3978 , -2024.416 , 58.81983 , "None"));
Path.Add(new Vector3(-661.8907 , -2031.37 , 58.53766 , "None"));
Path.Add(new Vector3(-664.6103 , -2034.653 , 58.38259 , "None"));
Path.Add(new Vector3(-670.3121 , -2040.982 , 57.49283 , "None"));
Path.Add(new Vector3(-675.2486 , -2043.542 , 57.03281 , "None"));
Path.Add(new Vector3(-680.1442 , -2043.296 , 56.4686 , "None"));
Path.Add(new Vector3(-684.3574 , -2042.647 , 54.8173 , "None"));
Path.Add(new Vector3(-683.8444 , -2054.929 , 53.34711 , "None"));
Path.Add(new Vector3(-681.4384 , -2065.15 , 52.18457 , "None"));
Path.Add(new Vector3(-679.4152 , -2073.778 , 52.3847 , "None"));
Path.Add(new Vector3(-680.7292 , -2078.534 , 52.21401 , "None"));
Path.Add(new Vector3(-681.5566 , -2082.712 , 52.40723 , "None"));
Path.Add(new Vector3(-682.9966 , -2093.098 , 53.47625 , "None"));
Path.Add(new Vector3(-684.642 , -2103.462 , 53.90066 , "None"));
Path.Add(new Vector3(-689.1949 , -2112.807 , 52.24412 , "None"));
Path.Add(new Vector3(-695.99 , -2120.811 , 50.91968 , "None"));
Path.Add(new Vector3(-700.0096 , -2125.58 , 51.60009 , "None"));
Path.Add(new Vector3(-703.2937 , -2130.871 , 51.62997 , "None"));
Path.Add(new Vector3(-705.8918 , -2136.518 , 51.32085 , "None"));
Path.Add(new Vector3(-709.8944 , -2146.219 , 50.19384 , "None"));
Path.Add(new Vector3(-712.3673 , -2153.695 , 50.90085 , "None"));
Path.Add(new Vector3(-714.5273 , -2160.236 , 52.70469 , "None"));
Path.Add(new Vector3(-716.2971 , -2164.816 , 53.28224 , "None"));
Path.Add(new Vector3(-719.7164 , -2170.79 , 54.00795 , "None"));
Path.Add(new Vector3(-724.2484 , -2176.41 , 54.42698 , "None"));
Path.Add(new Vector3(-730.4692 , -2183.155 , 52.30873 , "None"));
Path.Add(new Vector3(-738.2906 , -2190.103 , 49.55536 , "None"));
Path.Add(new Vector3(-745.0225 , -2192.622 , 48.44026 , "None"));
Path.Add(new Vector3(-749.2188 , -2191.875 , 48.2702 , "None"));
Path.Add(new Vector3(-759.5161 , -2189.822 , 46.75223 , "None"));
Path.Add(new Vector3(-768.8245 , -2186.71 , 44.84241 , "None"));
Path.Add(new Vector3(-773.3745 , -2184.854 , 44.24932 , "None"));
Path.Add(new Vector3(-775.4885 , -2188.556 , 45.02055 , "None"));
Path.Add(new Vector3(-780.4455 , -2197.066 , 47.14674 , "None"));
Path.Add(new Vector3(-785.822 , -2205.691 , 49.00129 , "None"));
Path.Add(new Vector3(-792.3581 , -2215.137 , 48.15574 , "None"));
Path.Add(new Vector3(-798.3492 , -2223.76 , 47.86496 , "None"));
Path.Add(new Vector3(-804.2314 , -2232.457 , 49.24112 , "None"));
Path.Add(new Vector3(-808.9584 , -2241.096 , 50.70977 , "None"));
Path.Add(new Vector3(-815.337 , -2250.223 , 52.72332 , "None"));
Path.Add(new Vector3(-820.9429 , -2258.319 , 54.34197 , "None"));
Path.Add(new Vector3(-826.2593 , -2267.355 , 54.734 , "None"));
Path.Add(new Vector3(-830.736 , -2276.853 , 53.97473 , "None"));
Path.Add(new Vector3(-835.0804 , -2286.412 , 53.69633 , "None"));
Path.Add(new Vector3(-839.7317 , -2295.822 , 53.69807 , "None"));
Path.Add(new Vector3(-844.7041 , -2305.07 , 54.09445 , "None"));
Path.Add(new Vector3(-850.4869 , -2314.568 , 55.05639 , "None"));
Path.Add(new Vector3(-858.4243 , -2320.252 , 55.40921 , "None"));
Path.Add(new Vector3(-868.454 , -2323.349 , 54.60473 , "None"));
Path.Add(new Vector3(-878.6741 , -2325.758 , 53.6823 , "None"));
Path.Add(new Vector3(-888.9019 , -2328.132 , 51.71472 , "None"));
Path.Add(new Vector3(-899.1411 , -2330.453 , 49.38342 , "None"));
Path.Add(new Vector3(-909.0392 , -2333.935 , 47.28265 , "None"));
Path.Add(new Vector3(-918.5923 , -2339.66 , 46.85368 , "None"));
Path.Add(new Vector3(-926.5632 , -2345.444 , 47.38308 , "None"));
Path.Add(new Vector3(-934.4357 , -2352.264 , 47.28856 , "None"));
Path.Add(new Vector3(-937.859 , -2362.832 , 47.20587 , "None"));
Path.Add(new Vector3(-940.3693 , -2372.355 , 46.97511 , "None"));
Path.Add(new Vector3(-943.1996 , -2382.466 , 46.87023 , "None"));
Path.Add(new Vector3(-946.3983 , -2392.467 , 47.0288 , "None"));
Path.Add(new Vector3(-950.0518 , -2402.309 , 47.57151 , "None"));
Path.Add(new Vector3(-954.2972 , -2411.912 , 47.11211 , "None"));
Path.Add(new Vector3(-958.6849 , -2421.451 , 47.77936 , "None"));
Path.Add(new Vector3(-963.0956 , -2430.957 , 49.78402 , "None"));
Path.Add(new Vector3(-967.515 , -2440.482 , 52.89871 , "None"));
Path.Add(new Vector3(-972.2609 , -2449.838 , 54.79725 , "None"));
Path.Add(new Vector3(-977.7163 , -2458.809 , 54.75896 , "None"));
Path.Add(new Vector3(-983.1718 , -2467.781 , 54.02771 , "None"));
Path.Add(new Vector3(-988.6273 , -2476.752 , 53.03865 , "None"));
Path.Add(new Vector3(-994.0192 , -2485.761 , 53.245 , "None"));
Path.Add(new Vector3(-999.1037 , -2494.948 , 54.44846 , "None"));
Path.Add(new Vector3(-1003.798 , -2504.338 , 55.30873 , "None"));
Path.Add(new Vector3(-1006.409 , -2508.872 , 55.019 , "None"));
Path.Add(new Vector3(-1012.377 , -2517.511 , 54.234 , "None"));
Path.Add(new Vector3(-1018.613 , -2525.133 , 53.92048 , "None"));
Path.Add(new Vector3(-1025.68 , -2533.758 , 53.34838 , "None"));
Path.Add(new Vector3(-1031.048 , -2542.763 , 54.65832 , "None"));
Path.Add(new Vector3(-1035.636 , -2552.208 , 55.63163 , "None"));
Path.Add(new Vector3(-1040.057 , -2561.731 , 56.12018 , "None"));
Path.Add(new Vector3(-1044.458 , -2571.265 , 56.18132 , "None"));
Path.Add(new Vector3(-1048.586 , -2580.207 , 55.84472 , "None"));
Path.Add(new Vector3(-1052.986 , -2589.74 , 55.09384 , "None"));
Path.Add(new Vector3(-1057.387 , -2599.274 , 53.82107 , "None"));
Path.Add(new Vector3(-1061.788 , -2608.807 , 52.39735 , "None"));
Path.Add(new Vector3(-1066.169 , -2618.349 , 51.76754 , "None"));
Path.Add(new Vector3(-1070.514 , -2627.908 , 51.84252 , "None"));
Path.Add(new Vector3(-1075.119 , -2638.064 , 51.47603 , "None"));
Path.Add(new Vector3(-1079.141 , -2647.054 , 50.73264 , "None"));
Path.Add(new Vector3(-1083.46 , -2656.625 , 49.837 , "None"));
Path.Add(new Vector3(-1088.879 , -2665.587 , 49.3251 , "None"));
Path.Add(new Vector3(-1095.992 , -2673.288 , 50.27054 , "None"));
Path.Add(new Vector3(-1103.882 , -2680.216 , 50.94588 , "None"));
Path.Add(new Vector3(-1112.064 , -2687.79 , 52.45319 , "None"));
Path.Add(new Vector3(-1118.729 , -2695.037 , 53.44265 , "None"));
Path.Add(new Vector3(-1125.209 , -2703.296 , 53.71772 , "None"));
Path.Add(new Vector3(-1130.514 , -2712.346 , 52.76966 , "None"));
Path.Add(new Vector3(-1134.819 , -2721.919 , 50.26067 , "None"));
Path.Add(new Vector3(-1137.652 , -2732.009 , 47.01725 , "None"));
Path.Add(new Vector3(-1139.646 , -2742.318 , 44.38513 , "None"));
Path.Add(new Vector3(-1141.621 , -2752.63 , 43.47518 , "None"));
Path.Add(new Vector3(-1143.51 , -2762.958 , 43.76062 , "None"));
Path.Add(new Vector3(-1145.137 , -2773.332 , 43.8674 , "None"));
Path.Add(new Vector3(-1146.907 , -2783.68 , 44.21117 , "None"));
Path.Add(new Vector3(-1149.019 , -2793.966 , 45.02176 , "None"));
Path.Add(new Vector3(-1151.133 , -2804.251 , 47.13972 , "None"));
Path.Add(new Vector3(-1153.904 , -2814.366 , 50.49239 , "None"));
Path.Add(new Vector3(-1157.193 , -2824.337 , 53.04602 , "None"));
Path.Add(new Vector3(-1160.357 , -2834.348 , 52.75168 , "None"));
Path.Add(new Vector3(-1163.151 , -2844.469 , 50.1979 , "None"));
Path.Add(new Vector3(-1164.371 , -2854.878 , 47.59222 , "None"));
Path.Add(new Vector3(-1163.879 , -2865.354 , 45.65588 , "None"));
Path.Add(new Vector3(-1162.36 , -2875.74 , 45.32789 , "None"));
Path.Add(new Vector3(-1160.58 , -2886.088 , 46.48902 , "None"));
Path.Add(new Vector3(-1158.707 , -2896.739 , 48.50999 , "None"));
Path.Add(new Vector3(-1156.944 , -2906.753 , 50.93659 , "None"));
Path.Add(new Vector3(-1155.123 , -2917.094 , 52.49364 , "None"));
Path.Add(new Vector3(-1153.376 , -2927.448 , 52.48251 , "None"));
Path.Add(new Vector3(-1151.7 , -2937.813 , 51.17487 , "None"));
Path.Add(new Vector3(-1150.176 , -2948.52 , 49.02813 , "None"));
Path.Add(new Vector3(-1147.745 , -2955.576 , 46.98172 , "None"));
Path.Add(new Vector3(-1142.822 , -2964.845 , 44.39441 , "None"));
Path.Add(new Vector3(-1137.689 , -2974.005 , 42.43372 , "None"));
Path.Add(new Vector3(-1132.282 , -2983.006 , 40.4282 , "None"));
Path.Add(new Vector3(-1127.16 , -2992.17 , 39.08611 , "None"));
Path.Add(new Vector3(-1122.35 , -3001.502 , 38.20514 , "None"));
Path.Add(new Vector3(-1118.217 , -3011.153 , 38.23294 , "None"));
Path.Add(new Vector3(-1114.991 , -3021.14 , 40.48325 , "None"));
Path.Add(new Vector3(-1113.799 , -3028.26 , 41.65427 , "None"));
Path.Add(new Vector3(-1113.135 , -3033.15 , 42.20803 , "None"));
Path.Add(new Vector3(-1112.572 , -3040.352 , 42.8371 , "None"));
Path.Add(new Vector3(-1112.291 , -3043.953 , 43.07777 , "None"));
Path.Add(new Vector3(-1108.717 , -3048.583 , 43.86452 , "None"));
Path.Add(new Vector3(-1100.871 , -3048.429 , 45.46556 , "None"));
Path.Add(new Vector3(-1093.207 , -3056.689 , 45.58242 , "None"));
Path.Add(new Vector3(-1086.874 , -3065.063 , 44.54683 , "None"));
Path.Add(new Vector3(-1081.226 , -3073.912 , 43.76867 , "None"));
Path.Add(new Vector3(-1075.815 , -3082.91 , 43.01363 , "None"));
Path.Add(new Vector3(-1070.404 , -3091.908 , 43.87369 , "None"));
Path.Add(new Vector3(-1064.994 , -3100.905 , 48.02026 , "None"));
Path.Add(new Vector3(-1059.409 , -3110.191 , 50.80245 , "None"));
Path.Add(new Vector3(-1054.222 , -3118.931 , 52.49499 , "None"));
Path.Add(new Vector3(-1048.756 , -3128.287 , 53.25555 , "None"));
Path.Add(new Vector3(-1043.653 , -3137.077 , 52.51303 , "None"));
Path.Add(new Vector3(-1037.383 , -3145.49 , 49.90857 , "None"));
Path.Add(new Vector3(-1030.242 , -3153.186 , 45.41529 , "None"));
Path.Add(new Vector3(-1022.469 , -3160.244 , 42.01511 , "None"));
Path.Add(new Vector3(-1014.953 , -3167.572 , 41.5889 , "None"));
Path.Add(new Vector3(-1007.816 , -3175.27 , 43.35398 , "None"));
Path.Add(new Vector3(-1000.898 , -3183.608 , 45.94518 , "None"));
Path.Add(new Vector3(-994.1765 , -3191.672 , 49.52476 , "None"));
Path.Add(new Vector3(-987.5189 , -3199.352 , 53.49795 , "None"));
Path.Add(new Vector3(-980.421 , -3207.54 , 57.13225 , "None"));
Path.Add(new Vector3(-974.1946 , -3214.732 , 60.06204 , "None"));
Path.Add(new Vector3(-966.1193 , -3222.87 , 62.28683 , "None"));
Path.Add(new Vector3(-958.6585 , -3229.3 , 63.99656 , "None"));
Path.Add(new Vector3(-954.6751 , -3233.157 , 65.51874 , "None"));
Path.Add(new Vector3(-955.3595 , -3239.616 , 65.58614 , "None"));
Path.Add(new Vector3(-960.2352 , -3248.902 , 65.11317 , "None"));
Path.Add(new Vector3(-963.8718 , -3258.051 , 64.27538 , "None"));
Path.Add(new Vector3(-964.5377 , -3266.133 , 65.57072 , "None"));
Path.Add(new Vector3(-962.8697 , -3269.312 , 66.89024 , "None"));
Path.Add(new Vector3(-955.0106 , -3276.275 , 70.74115 , "None"));
Path.Add(new Vector3(-947.1589 , -3283.246 , 73.6619 , "None"));
Path.Add(new Vector3(-939.8752 , -3290.79 , 74.83995 , "None"));
Path.Add(new Vector3(-933.9081 , -3300.186 , 73.88055 , "None"));
Path.Add(new Vector3(-929.7227 , -3309.1 , 72.76952 , "None"));
Path.Add(new Vector3(-925.5231 , -3318.724 , 71.87151 , "None"));
Path.Add(new Vector3(-922.7913 , -3328.843 , 72.89884 , "None"));
Path.Add(new Vector3(-921.9544 , -3339.296 , 73.23913 , "None"));
Path.Add(new Vector3(-922.2009 , -3349.787 , 72.44015 , "None"));
Path.Add(new Vector3(-923.7137 , -3360.171 , 70.24697 , "None"));
Path.Add(new Vector3(-924.8373 , -3366.306 , 68.52088 , "None"));
Path.Add(new Vector3(-925.6697 , -3371.806 , 67.13332 , "None"));
Path.Add(new Vector3(-925.7477 , -3377.37 , 66.74408 , "None"));
Path.Add(new Vector3(-934.3662 , -3372.575 , 64.98479 , "None"));
Path.Add(new Vector3(-941.8603 , -3365.234 , 63.84703 , "None"));
Path.Add(new Vector3(-948.9232 , -3357.465 , 63.06223 , "None"));
Path.Add(new Vector3(-956.1979 , -3349.462 , 62.65567 , "None"));
Path.Add(new Vector3(-963.2607 , -3341.692 , 62.67852 , "None"));
Path.Add(new Vector3(-970.1118 , -3334.156 , 62.79791 , "None"));
Path.Add(new Vector3(-977.1746 , -3326.386 , 62.62503 , "None"));
Path.Add(new Vector3(-984.4493 , -3318.384 , 62.22601 , "None"));
Path.Add(new Vector3(-991.5274 , -3310.628 , 61.37755 , "None"));
Path.Add(new Vector3(-998.6395 , -3303.339 , 59.71403 , "None"));
Path.Add(new Vector3(-1006.576 , -3295.994 , 56.45326 , "None"));
Path.Add(new Vector3(-1014.767 , -3289.426 , 53.57063 , "None"));
Path.Add(new Vector3(-1022.972 , -3282.873 , 50.33744 , "None"));
Path.Add(new Vector3(-1031.046 , -3276.16 , 46.57323 , "None"));
Path.Add(new Vector3(-1039.108 , -3269.434 , 43.35632 , "None"));
Path.Add(new Vector3(-1042.827 , -3266.19 , 41.96165 , "None"));
Path.Add(new Vector3(-1048.272 , -3261.442 , 40.06776 , "None"));
Path.Add(new Vector3(-1054.093 , -3257.204 , 38.5427 , "None"));
Path.Add(new Vector3(-1063.683 , -3253.045 , 37.44751 , "None"));
Path.Add(new Vector3(-1074.097 , -3251.88 , 36.86985 , "None"));
Path.Add(new Vector3(-1082.705 , -3254.428 , 37.20824 , "None"));
Path.Add(new Vector3(-1092.319 , -3258.65 , 38.25518 , "None"));
Path.Add(new Vector3(-1101.937 , -3262.862 , 40.01926 , "None"));
Path.Add(new Vector3(-1113.018 , -3262.235 , 40.40633 , "None"));
Path.Add(new Vector3(-1122.971 , -3258.928 , 39.77146 , "None"));
Path.Add(new Vector3(-1132.571 , -3254.703 , 38.17141 , "None"));
Path.Add(new Vector3(-1137.837 , -3251.365 , 36.58733 , "None"));
Path.Add(new Vector3(-1140.508 , -3248.933 , 35.52139 , "None"));
Path.Add(new Vector3(-1145.6 , -3244.295 , 33.74228 , "None"));
Path.Add(new Vector3(-1149.248 , -3240.971 , 32.63263 , "None"));
Path.Add(new Vector3(-1153.38 , -3244.315 , 32.53284 , "None"));
Path.Add(new Vector3(-1155.972 , -3254.474 , 35.04482 , "None"));
Path.Add(new Vector3(-1157.446 , -3262.208 , 37.83128 , "None"));
Path.Add(new Vector3(-1157.413 , -3265.799 , 39.1909 , "None"));
Path.Add(new Vector3(-1157.367 , -3270.734 , 40.77606 , "None"));
Path.Add(new Vector3(-1165.001 , -3280.215 , 39.95551 , "None"));
Path.Add(new Vector3(-1173.698 , -3286.65 , 36.03312 , "None"));
Path.Add(new Vector3(-1182.422 , -3291.866 , 32.35774 , "None"));
Path.Add(new Vector3(-1191.871 , -3296.431 , 29.17682 , "None"));
Path.Add(new Vector3(-1202.457 , -3300.889 , 28.60664 , "None"));
Path.Add(new Vector3(-1211.588 , -3304.582 , 29.61924 , "None"));
Path.Add(new Vector3(-1221.925 , -3308.763 , 31.05528 , "None"));
Path.Add(new Vector3(-1231.659 , -3312.7 , 31.32427 , "None"));
Path.Add(new Vector3(-1241.393 , -3316.638 , 31.64845 , "None"));
Path.Add(new Vector3(-1251.106 , -3320.619 , 32.64239 , "None"));
Path.Add(new Vector3(-1259.997 , -3324.857 , 33.43816 , "None"));
Path.Add(new Vector3(-1270.079 , -3329.621 , 34.43552 , "None"));
Path.Add(new Vector3(-1279.399 , -3334.447 , 37.07616 , "None"));
Path.Add(new Vector3(-1288.408 , -3339.839 , 40.05158 , "None"));
Path.Add(new Vector3(-1297.353 , -3345.338 , 39.8359 , "None"));
Path.Add(new Vector3(-1306.297 , -3350.837 , 39.94846 , "None"));
Path.Add(new Vector3(-1314.773 , -3355.853 , 39.92044 , "None"));
Path.Add(new Vector3(-1323.995 , -3360.867 , 39.95804 , "None"));
Path.Add(new Vector3(-1333.62 , -3365.053 , 41.11128 , "None"));
Path.Add(new Vector3(-1343.514 , -3368.568 , 42.28138 , "None"));
Path.Add(new Vector3(-1354.411 , -3370.823 , 43.02252 , "None"));
Path.Add(new Vector3(-1364.174 , -3372.12 , 43.80587 , "None"));
Path.Add(new Vector3(-1374.631 , -3373.052 , 44.55159 , "None"));
Path.Add(new Vector3(-1385.114 , -3373.645 , 45.29487 , "None"));
Path.Add(new Vector3(-1395.612 , -3373.83 , 45.42631 , "None"));
Path.Add(new Vector3(-1406.098 , -3373.397 , 44.67195 , "None"));
Path.Add(new Vector3(-1416.495 , -3371.94 , 43.97704 , "None"));
Path.Add(new Vector3(-1426.723 , -3369.604 , 43.17535 , "None"));
Path.Add(new Vector3(-1436.055 , -3364.833 , 42.22111 , "None"));
Path.Add(new Vector3(-1445.107 , -3359.512 , 41.65172 , "None"));
Path.Add(new Vector3(-1454.164 , -3354.2 , 42.04178 , "None"));
Path.Add(new Vector3(-1463.189 , -3348.833 , 42.06984 , "None"));
Path.Add(new Vector3(-1469.669 , -3344.979 , 40.92009 , "None"));
Path.Add(new Vector3(-1480.39 , -3338.604 , 37.74462 , "None"));
Path.Add(new Vector3(-1489.291 , -3333.041 , 35.7928 , "None"));
Path.Add(new Vector3(-1497.62 , -3326.65 , 35.26955 , "None"));
Path.Add(new Vector3(-1505.862 , -3320.145 , 36.27403 , "None"));
Path.Add(new Vector3(-1513.911 , -3313.406 , 35.49642 , "None"));
Path.Add(new Vector3(-1521.703 , -3306.368 , 33.03045 , "None"));
Path.Add(new Vector3(-1529.493 , -3299.328 , 30.118 , "None"));
Path.Add(new Vector3(-1537.287 , -3292.292 , 29.86875 , "None"));
Path.Add(new Vector3(-1545.133 , -3285.314 , 30.62444 , "None"));
Path.Add(new Vector3(-1553.214 , -3278.126 , 30.12832 , "None"));
Path.Add(new Vector3(-1561.059 , -3271.147 , 30.21203 , "None"));
Path.Add(new Vector3(-1568.905 , -3264.169 , 29.48219 , "None"));
Path.Add(new Vector3(-1575.526 , -3258.279 , 27.733 , "None"));
Path.Add(new Vector3(-1581.41 , -3253.045 , 27.41534 , "None"));
Path.Add(new Vector3(-1589.256 , -3246.067 , 27.6711 , "None"));
Path.Add(new Vector3(-1597.101 , -3239.089 , 29.01218 , "None"));
Path.Add(new Vector3(-1604.947 , -3232.11 , 31.41492 , "None"));
Path.Add(new Vector3(-1612.792 , -3225.132 , 31.55637 , "None"));
Path.Add(new Vector3(-1620.638 , -3218.154 , 31.24596 , "None"));
Path.Add(new Vector3(-1628.483 , -3211.175 , 32.16432 , "None"));
Path.Add(new Vector3(-1636.323 , -3204.202 , 33.30825 , "None"));
Path.Add(new Vector3(-1644.168 , -3197.224 , 33.18468 , "None"));
Path.Add(new Vector3(-1652.014 , -3190.246 , 33.56704 , "None"));
Path.Add(new Vector3(-1659.859 , -3183.267 , 34.73857 , "None"));
Path.Add(new Vector3(-1667.705 , -3176.289 , 33.80078 , "None"));
Path.Add(new Vector3(-1675.55 , -3169.31 , 32.79618 , "None"));
Path.Add(new Vector3(-1679.238 , -3166.031 , 32.64714 , "None"));
Path.Add(new Vector3(-1682.423 , -3163.197 , 32.25339 , "None"));
Path.Add(new Vector3(-1691.084 , -3157.369 , 31.04815 , "None"));
Path.Add(new Vector3(-1700.375 , -3152.478 , 30.88465 , "None"));
Path.Add(new Vector3(-1709.517 , -3147.32 , 31.43976 , "None"));
Path.Add(new Vector3(-1717.215 , -3142.285 , 30.56044 , "None"));
Path.Add(new Vector3(-1723.693 , -3137.282 , 28.71572 , "None"));
Path.Add(new Vector3(-1731.438 , -3130.194 , 26.31782 , "None"));
Path.Add(new Vector3(-1738.66 , -3122.579 , 26.72605 , "None"));
Path.Add(new Vector3(-1745.015 , -3114.226 , 26.80506 , "None"));
Path.Add(new Vector3(-1750.425 , -3105.234 , 26.28235 , "None"));
Path.Add(new Vector3(-1754.203 , -3096.155 , 25.94281 , "None"));
Path.Add(new Vector3(-1756.823 , -3085.991 , 26.68407 , "None"));
Path.Add(new Vector3(-1758.522 , -3078.302 , 28.48926 , "None"));
Path.Add(new Vector3(-1760.648 , -3068.685 , 31.65824 , "None"));
Path.Add(new Vector3(-1763.085 , -3057.46 , 34.83057 , "None"));
Path.Add(new Vector3(-1764.796 , -3048.103 , 36.18668 , "None"));
Path.Add(new Vector3(-1766.853 , -3036.813 , 37.81079 , "None"));
Path.Add(new Vector3(-1768.734 , -3026.483 , 39.93036 , "None"));
Path.Add(new Vector3(-1770.616 , -3016.153 , 43.20975 , "None"));
Path.Add(new Vector3(-1772.198 , -3006.433 , 45.00379 , "None"));
Path.Add(new Vector3(-1773.243 , -2998.628 , 45.81332 , "None"));
Path.Add(new Vector3(-1774.243 , -2991.156 , 46.15341 , "None"));
Path.Add(new Vector3(-1774.808 , -2986.93 , 46.214 , "None"));
Path.Add(new Vector3(-1765.163 , -2984.938 , 42.90799 , "None"));
Path.Add(new Vector3(-1754.88 , -2982.813 , 38.29343 , "None"));
Path.Add(new Vector3(-1744.582 , -2980.774 , 34.72849 , "None"));
Path.Add(new Vector3(-1734.758 , -2980.919 , 33.81916 , "None"));
Path.Add(new Vector3(-1725.663 , -2982.124 , 35.3886 , "None"));
Path.Add(new Vector3(-1717.937 , -2983.648 , 37.25118 , "None"));
Path.Add(new Vector3(-1713.426 , -2984.542 , 37.74867 , "None"));
Path.Add(new Vector3(-1705.925 , -2979.918 , 38.22579 , "None"));
Path.Add(new Vector3(-1699.227 , -2972.697 , 38.53317 , "None"));
Path.Add(new Vector3(-1694.032 , -2967.234 , 39.06474 , "None"));
Path.Add(new Vector3(-1689.47 , -2962.531 , 38.48151 , "None"));
Path.Add(new Vector3(-1686.502 , -2959.471 , 37.92881 , "None"));
Path.Add(new Vector3(-1690.506 , -2954.692 , 37.41829 , "None"));
Path.Add(new Vector3(-1697.863 , -2947.232 , 36.75277 , "None"));
Path.Add(new Vector3(-1704.818 , -2939.366 , 36.46477 , "None"));
Path.Add(new Vector3(-1711.809 , -2931.532 , 37.62004 , "None"));
Path.Add(new Vector3(-1718.97 , -2923.853 , 37.2452 , "None"));
Path.Add(new Vector3(-1726.661 , -2916.72 , 36.19863 , "None"));
Path.Add(new Vector3(-1735.547 , -2911.14 , 37.29078 , "None"));
Path.Add(new Vector3(-1744.683 , -2905.965 , 39.39463 , "None"));
Path.Add(new Vector3(-1749.401 , -2903.02 , 40.40311 , "None"));
Path.Add(new Vector3(-1753.245 , -2899.963 , 40.97714 , "None"));
Path.Add(new Vector3(-1756.206 , -2893.76 , 41.2052 , "None"));
Path.Add(new Vector3(-1756.625 , -2888.299 , 41.34738 , "None"));
Path.Add(new Vector3(-1749.105 , -2888.771 , 41.33652 , "None"));
Path.Add(new Vector3(-1742.265 , -2887.974 , 41.66866 , "None"));
Path.Add(new Vector3(-1733.921 , -2884.32 , 42.08502 , "None"));
Path.Add(new Vector3(-1728.706 , -2880.898 , 41.67729 , "None"));
Path.Add(new Vector3(-1719.751 , -2874.835 , 38.71732 , "None"));
Path.Add(new Vector3(-1720.952 , -2871.283 , 38.57072 , "None"));
Path.Add(new Vector3(-1723.544 , -2868.306 , 38.57917 , "None"));
Path.Add(new Vector3(-1721.561 , -2855.331 , 36.25239 , "None"));
Path.Add(new Vector3(-1719.975 , -2844.952 , 37.75397 , "None"));
Path.Add(new Vector3(-1718.389 , -2834.573 , 39.23862 , "None"));
Path.Add(new Vector3(-1716.802 , -2824.193 , 40.40549 , "None"));
Path.Add(new Vector3(-1715.226 , -2813.812 , 42.17361 , "None"));
Path.Add(new Vector3(-1713.701 , -2803.423 , 44.5343 , "None"));
Path.Add(new Vector3(-1712.176 , -2793.034 , 47.36707 , "None"));
Path.Add(new Vector3(-1710.938 , -2782.612 , 49.44213 , "None"));
Path.Add(new Vector3(-1710.473 , -2775.74 , 50.04049 , "None"));
Path.Add(new Vector3(-1709.782 , -2765.262 , 50.49012 , "None"));
Path.Add(new Vector3(-1710.241 , -2755.434 , 50.04382 , "None"));
Path.Add(new Vector3(-1710.975 , -2750.575 , 49.26708 , "None"));
Path.Add(new Vector3(-1712.04 , -2743.749 , 47.31421 , "None"));
Path.Add(new Vector3(-1713.261 , -2735.969 , 44.69699 , "None"));
Path.Add(new Vector3(-1701.269 , -2740.93 , 45.56611 , "None"));
Path.Add(new Vector3(-1693.108 , -2746.408 , 46.91304 , "None"));
Path.Add(new Vector3(-1683.521 , -2752.096 , 47.53053 , "None"));
Path.Add(new Vector3(-1675.222 , -2756.745 , 45.99822 , "None"));
Path.Add(new Vector3(-1664.96 , -2761.898 , 43.44563 , "None"));
Path.Add(new Vector3(-1655.461 , -2766.373 , 42.80722 , "None"));
Path.Add(new Vector3(-1648.073 , -2769.955 , 43.96579 , "None"));
Path.Add(new Vector3(-1640.104 , -2774.506 , 44.09348 , "None"));
Path.Add(new Vector3(-1630.986 , -2779.712 , 40.14996 , "None"));
Path.Add(new Vector3(-1621.885 , -2784.949 , 36.28296 , "None"));
Path.Add(new Vector3(-1612.844 , -2790.288 , 35.5061 , "None"));
Path.Add(new Vector3(-1604.369 , -2795.305 , 38.60624 , "None"));
Path.Add(new Vector3(-1594.577 , -2800.636 , 40.43698 , "None"));
Path.Add(new Vector3(-1585.648 , -2804.781 , 40.93146 , "None"));
Path.Add(new Vector3(-1575.187 , -2808.639 , 40.93587 , "None"));
Path.Add(new Vector3(-1565.783 , -2811.564 , 40.45118 , "None"));
Path.Add(new Vector3(-1555.634 , -2814.25 , 38.3512 , "None"));
Path.Add(new Vector3(-1545.188 , -2815.055 , 36.64828 , "None"));
Path.Add(new Vector3(-1540.284 , -2815.374 , 36.44042 , "None"));
Path.Add(new Vector3(-1534.061 , -2815.778 , 36.81017 , "None"));
Path.Add(new Vector3(-1529.807 , -2816.054 , 37.37669 , "None"));
Path.Add(new Vector3(-1520.628 , -2816.651 , 38.74817 , "None"));
Path.Add(new Vector3(-1514.404 , -2817.055 , 39.51388 , "None"));
Path.Add(new Vector3(-1505.19 , -2813.638 , 41.2259 , "None"));
Path.Add(new Vector3(-1495.127 , -2810.693 , 43.3178 , "None"));
Path.Add(new Vector3(-1484.941 , -2808.147 , 45.08241 , "None"));
Path.Add(new Vector3(-1474.755 , -2805.601 , 46.04424 , "None"));
Path.Add(new Vector3(-1464.568 , -2803.054 , 46.08059 , "None"));
Path.Add(new Vector3(-1454.381 , -2800.507 , 45.14993 , "None"));
Path.Add(new Vector3(-1444.195 , -2797.961 , 43.86148 , "None"));
Path.Add(new Vector3(-1438.796 , -2796.611 , 43.32597 , "None"));
Path.Add(new Vector3(-1428.609 , -2794.065 , 42.83208 , "None"));
Path.Add(new Vector3(-1418.423 , -2791.518 , 42.32212 , "None"));
Path.Add(new Vector3(-1408.211 , -2789.091 , 40.27475 , "None"));
Path.Add(new Vector3(-1398.507 , -2792.608 , 41.72232 , "None"));
Path.Add(new Vector3(-1389.158 , -2797.385 , 43.15329 , "None"));
Path.Add(new Vector3(-1379.318 , -2800.988 , 44.65636 , "None"));
Path.Add(new Vector3(-1369.087 , -2803.296 , 46.77347 , "None"));
Path.Add(new Vector3(-1358.616 , -2803.965 , 48.74801 , "None"));
Path.Add(new Vector3(-1348.15 , -2804.482 , 49.38662 , "None"));
Path.Add(new Vector3(-1338.215 , -2807.871 , 50.64757 , "None"));
Path.Add(new Vector3(-1328.023 , -2810.292 , 53.89808 , "None"));
Path.Add(new Vector3(-1317.579 , -2809.708 , 54.43273 , "None"));
Path.Add(new Vector3(-1307.759 , -2806.085 , 54.64124 , "None"));
Path.Add(new Vector3(-1298.334 , -2801.466 , 53.21759 , "None"));
Path.Add(new Vector3(-1289.077 , -2796.51 , 51.52905 , "None"));
Path.Add(new Vector3(-1283.492 , -2789.792 , 51.43802 , "None"));
Path.Add(new Vector3(-1279.601 , -2780.065 , 51.92141 , "None"));
Path.Add(new Vector3(-1280.733 , -2771.854 , 52.36478 , "None"));
Path.Add(new Vector3(-1284.258 , -2761.964 , 53.74321 , "None"));
Path.Add(new Vector3(-1287.693 , -2752.042 , 55.61665 , "None"));
Path.Add(new Vector3(-1289.992 , -2741.807 , 55.94258 , "None"));
Path.Add(new Vector3(-1290.736 , -2733.97 , 53.90816 , "None"));
Path.Add(new Vector3(-1290.059 , -2729.761 , 52.31387 , "None"));
Path.Add(new Vector3(-1289.068 , -2723.604 , 50.37308 , "None"));
Path.Add(new Vector3(-1288.288 , -2718.752 , 49.55508 , "None"));
Path.Add(new Vector3(-1288.329 , -2713.169 , 49.44921 , "None"));
Path.Add(new Vector3(-1275.939 , -2709.917 , 47.06593 , "None"));
Path.Add(new Vector3(-1265.783 , -2707.25 , 45.337 , "None"));
Path.Add(new Vector3(-1255.627 , -2704.584 , 44.90878 , "None"));
Path.Add(new Vector3(-1244.842 , -2701.752 , 45.48032 , "None"));
Path.Add(new Vector3(-1234.686 , -2699.086 , 46.43323 , "None"));
Path.Add(new Vector3(-1224.53 , -2696.42 , 47.54915 , "None"));
Path.Add(new Vector3(-1219.127 , -2695.001 , 47.76011 , "None"));
Path.Add(new Vector3(-1211.667 , -2687.613 , 46.52955 , "None"));
Path.Add(new Vector3(-1205.776 , -2678.969 , 45.01994 , "None"));
Path.Add(new Vector3(-1200.858 , -2669.692 , 44.5172 , "None"));
Path.Add(new Vector3(-1195.987 , -2659.663 , 44.8825 , "None"));
Path.Add(new Vector3(-1192.687 , -2650.396 , 46.22989 , "None"));
Path.Add(new Vector3(-1191.329 , -2639.997 , 46.04439 , "None"));
Path.Add(new Vector3(-1192.635 , -2629.628 , 44.01247 , "None"));
Path.Add(new Vector3(-1197.11 , -2620.234 , 42.31844 , "None"));
Path.Add(new Vector3(-1203.907 , -2612.233 , 39.87636 , "None"));
Path.Add(new Vector3(-1210.759 , -2603.45 , 36.82818 , "None"));
Path.Add(new Vector3(-1215.839 , -2595.013 , 34.49701 , "None"));
Path.Add(new Vector3(-1221.164 , -2585.963 , 31.51851 , "None"));
Path.Add(new Vector3(-1226.216 , -2576.759 , 28.66146 , "None"));
Path.Add(new Vector3(-1230.889 , -2567.357 , 25.93664 , "None"));
Path.Add(new Vector3(-1235.216 , -2557.79 , 23.02756 , "None"));
Path.Add(new Vector3(-1239.495 , -2548.201 , 21.36562 , "None"));
Path.Add(new Vector3(-1243.703 , -2538.582 , 20.96622 , "None"));
Path.Add(new Vector3(-1246.592 , -2528.521 , 20.59318 , "None"));
Path.Add(new Vector3(-1246.637 , -2523.611 , 20.58582 , "None"));
Path.Add(new Vector3(-1245.128 , -2518.937 , 20.8851 , "None"));
Path.Add(new Vector3(-1241.759 , -2516.324 , 21.60887 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

        








public override bool HasQuest() { return true; }


}


public sealed class GatherIronbeardsTomb : QuestGathererClass
{
    public GatherIronbeardsTomb()
    {
        Name = "GatherIronbeardsTomb";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(1628);
HotSpots.Add(new Vector3(-2847.899 , -2220.876 , 31.38409 , "None"));

    }

        








public override bool HasQuest() { return true; }


}


public sealed class GatherpathStonardFadeleaf : QuestFollowPathClass
{
    public GatherpathStonardFadeleaf()
    {
        Name = "GatherpathStonardFadeleaf";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-10456.97 , -3279.25 , 21.35 , "None"));
Path.Add(new Vector3(-10453.05 , -3279.762 , 21.27469 , "None"));
Path.Add(new Vector3(-10439.17 , -3281.58 , 20.17914 , "None"));
Path.Add(new Vector3(-10425.29 , -3283.397 , 20.77394 , "None"));
Path.Add(new Vector3(-10412.26 , -3284.05 , 20.91203 , "None"));
Path.Add(new Vector3(-10399.11 , -3279.455 , 20.51553 , "None"));
Path.Add(new Vector3(-10387.1 , -3272.389 , 20.22956 , "None"));
Path.Add(new Vector3(-10382.95 , -3264.206 , 20.18728 , "None"));
Path.Add(new Vector3(-10379.64 , -3254.246 , 20.17851 , "None"));
Path.Add(new Vector3(-10375.55 , -3249.158 , 20.16027 , "None"));
Path.Add(new Vector3(-10370.62 , -3246.331 , 19.13111 , "None"));
Path.Add(new Vector3(-10357.54 , -3241.435 , 16.74555 , "None"));
Path.Add(new Vector3(-10344.15 , -3237.326 , 17.12103 , "None"));
Path.Add(new Vector3(-10337.89 , -3235.403 , 18.15829 , "None"));
Path.Add(new Vector3(-10333.12 , -3235.958 , 18.98515 , "None"));
Path.Add(new Vector3(-10319.82 , -3240.328 , 20.16326 , "None"));
Path.Add(new Vector3(-10316.55 , -3243.702 , 18.98126 , "None"));
Path.Add(new Vector3(-10307.89 , -3254.701 , 17.19213 , "None"));
Path.Add(new Vector3(-10298.15 , -3264.707 , 19.28144 , "None"));
Path.Add(new Vector3(-10294.62 , -3267.984 , 19.34884 , "None"));
Path.Add(new Vector3(-10284.79 , -3275.997 , 17.74124 , "None"));
Path.Add(new Vector3(-10273.94 , -3284.843 , 17.6708 , "None"));
Path.Add(new Vector3(-10267.17 , -3290.362 , 20.77569 , "None"));
Path.Add(new Vector3(-10261.08 , -3302.961 , 22.25856 , "None"));
Path.Add(new Vector3(-10256.79 , -3316.278 , 23.21873 , "None"));
Path.Add(new Vector3(-10252.34 , -3329.477 , 22.3369 , "None"));
Path.Add(new Vector3(-10249.69 , -3333.492 , 22.57682 , "None"));
Path.Add(new Vector3(-10245.34 , -3343.998 , 21.97534 , "None"));
Path.Add(new Vector3(-10239.99 , -3356.935 , 22.32587 , "None"));
Path.Add(new Vector3(-10234.85 , -3369.017 , 22.16488 , "None"));
Path.Add(new Vector3(-10228.35 , -3382.391 , 21.66495 , "None"));
Path.Add(new Vector3(-10225.85 , -3387.496 , 21.31286 , "None"));
Path.Add(new Vector3(-10230.67 , -3400.643 , 17.42239 , "None"));
Path.Add(new Vector3(-10235.63 , -3413.736 , 18.27764 , "None"));
Path.Add(new Vector3(-10239.64 , -3424.37 , 22.14876 , "None"));
Path.Add(new Vector3(-10238.75 , -3427.753 , 22.3735 , "None"));
Path.Add(new Vector3(-10235.17 , -3441.288 , 22.43732 , "None"));
Path.Add(new Vector3(-10233.94 , -3445.944 , 21.93462 , "None"));
Path.Add(new Vector3(-10232.15 , -3456.745 , 23.65189 , "None"));
Path.Add(new Vector3(-10230.85 , -3466.284 , 23.93786 , "None"));
Path.Add(new Vector3(-10230.7 , -3470.65 , 22.93457 , "None"));
Path.Add(new Vector3(-10226.38 , -3475.253 , 23.00371 , "None"));
Path.Add(new Vector3(-10214.28 , -3473.239 , 23.32103 , "None"));
Path.Add(new Vector3(-10200.96 , -3468.946 , 23.97779 , "None"));
Path.Add(new Vector3(-10196.48 , -3467.188 , 24.18272 , "None"));
Path.Add(new Vector3(-10194.31 , -3463.363 , 23.52143 , "None"));
Path.Add(new Vector3(-10186.98 , -3451.449 , 21.63983 , "None"));
Path.Add(new Vector3(-10178.45 , -3440.346 , 20.26408 , "None"));
Path.Add(new Vector3(-10169.91 , -3429.255 , 17.6903 , "None"));
Path.Add(new Vector3(-10161.45 , -3418.101 , 18.77971 , "None"));
Path.Add(new Vector3(-10153.43 , -3408.284 , 20.23228 , "None"));
Path.Add(new Vector3(-10144.95 , -3398.857 , 20.2105 , "None"));
Path.Add(new Vector3(-10136.35 , -3387.265 , 17.37506 , "None"));
Path.Add(new Vector3(-10130.53 , -3373.676 , 17.62216 , "None"));
Path.Add(new Vector3(-10129.19 , -3366.376 , 18.73076 , "None"));
Path.Add(new Vector3(-10131.15 , -3359.191 , 21.3553 , "None"));
Path.Add(new Vector3(-10133.33 , -3352.068 , 22.77618 , "None"));
Path.Add(new Vector3(-10139.79 , -3339.652 , 22.44931 , "None"));
Path.Add(new Vector3(-10148.73 , -3325.625 , 23.09163 , "None"));
Path.Add(new Vector3(-10154.85 , -3316.047 , 22.22314 , "None"));
Path.Add(new Vector3(-10156.57 , -3312.03 , 22.45876 , "None"));
Path.Add(new Vector3(-10159.14 , -3306.005 , 21.99246 , "None"));
Path.Add(new Vector3(-10163.95 , -3291.936 , 17.91627 , "None"));
Path.Add(new Vector3(-10168.48 , -3278.688 , 18.40998 , "None"));
Path.Add(new Vector3(-10171.92 , -3266.938 , 22.56648 , "None"));
Path.Add(new Vector3(-10172.5 , -3263.034 , 23.12041 , "None"));
Path.Add(new Vector3(-10174.57 , -3249.188 , 22.80866 , "None"));
Path.Add(new Vector3(-10175.54 , -3242.708 , 21.72822 , "None"));
Path.Add(new Vector3(-10176.91 , -3233.626 , 20.44133 , "None"));
Path.Add(new Vector3(-10177.08 , -3227.048 , 20.43814 , "None"));
Path.Add(new Vector3(-10177.24 , -3221.366 , 21.09804 , "None"));
Path.Add(new Vector3(-10177.46 , -3213.053 , 22.70176 , "None"));
Path.Add(new Vector3(-10177.59 , -3208.239 , 22.85763 , "None"));
Path.Add(new Vector3(-10183.75 , -3215.052 , 21.73838 , "None"));
Path.Add(new Vector3(-10194.3 , -3224.846 , 20.42064 , "None"));
Path.Add(new Vector3(-10201.37 , -3229.206 , 20.88786 , "None"));
Path.Add(new Vector3(-10206.81 , -3230.853 , 19.85845 , "None"));
Path.Add(new Vector3(-10219.38 , -3234.658 , 16.84719 , "None"));
Path.Add(new Vector3(-10232.91 , -3238.229 , 20.67166 , "None"));
Path.Add(new Vector3(-10239.35 , -3239.457 , 22.90133 , "None"));
Path.Add(new Vector3(-10247.57 , -3240.683 , 22.68683 , "None"));
Path.Add(new Vector3(-10251.07 , -3240.744 , 22.49326 , "None"));
Path.Add(new Vector3(-10247.27 , -3238.532 , 22.60704 , "None"));
Path.Add(new Vector3(-10240.14 , -3226.745 , 21.05784 , "None"));
Path.Add(new Vector3(-10236.47 , -3213.293 , 20.68888 , "None"));
Path.Add(new Vector3(-10239.02 , -3199.648 , 19.93148 , "None"));
Path.Add(new Vector3(-10242.84 , -3188.023 , 21.51927 , "None"));
Path.Add(new Vector3(-10246.8 , -3175.973 , 22.65982 , "None"));
Path.Add(new Vector3(-10251.31 , -3162.259 , 23.04044 , "None"));
Path.Add(new Vector3(-10255.8 , -3148.09 , 24.11954 , "None"));
Path.Add(new Vector3(-10254.22 , -3136.627 , 21.95404 , "None"));
Path.Add(new Vector3(-10248.3 , -3125 , 23.82903 , "None"));
Path.Add(new Vector3(-10241.67 , -3118.69 , 24.70619 , "None"));
Path.Add(new Vector3(-10234.54 , -3112.91 , 22.69675 , "None"));
Path.Add(new Vector3(-10222.24 , -3108.812 , 21.61728 , "None"));
Path.Add(new Vector3(-10211.75 , -3108.402 , 23.22097 , "None"));
Path.Add(new Vector3(-10206.97 , -3107.764 , 24.00904 , "None"));
Path.Add(new Vector3(-10200.48 , -3106.896 , 23.81802 , "None"));
Path.Add(new Vector3(-10192.35 , -3095.516 , 21.75142 , "None"));
Path.Add(new Vector3(-10186.82 , -3085.585 , 22.12285 , "None"));
Path.Add(new Vector3(-10184.91 , -3082.158 , 22.23543 , "None"));
Path.Add(new Vector3(-10198.14 , -3092.648 , 22.1067 , "None"));
Path.Add(new Vector3(-10212.11 , -3092.392 , 22.46131 , "None"));
Path.Add(new Vector3(-10225.97 , -3094.104 , 22.3725 , "None"));
Path.Add(new Vector3(-10239.79 , -3096.341 , 21.98409 , "None"));
Path.Add(new Vector3(-10243.24 , -3096.9 , 22.11378 , "None"));
Path.Add(new Vector3(-10252.31 , -3098.367 , 22.87643 , "None"));
Path.Add(new Vector3(-10266.05 , -3101.009 , 21.82633 , "None"));
Path.Add(new Vector3(-10279.68 , -3104.202 , 22.44265 , "None"));
Path.Add(new Vector3(-10291.97 , -3110.811 , 21.85978 , "None"));
Path.Add(new Vector3(-10300.15 , -3119.242 , 21.99768 , "None"));
Path.Add(new Vector3(-10308.5 , -3130.249 , 21.15413 , "None"));
Path.Add(new Vector3(-10321.83 , -3124.723 , 21.3802 , "None"));
Path.Add(new Vector3(-10333.63 , -3117.193 , 21.96753 , "None"));
Path.Add(new Vector3(-10345.74 , -3110.174 , 22.55749 , "None"));
Path.Add(new Vector3(-10353.18 , -3105.614 , 22.15658 , "None"));
Path.Add(new Vector3(-10358.28 , -3098.012 , 21.67872 , "None"));
Path.Add(new Vector3(-10361.87 , -3091.039 , 21.87053 , "None"));
Path.Add(new Vector3(-10365.41 , -3082.112 , 22.48524 , "None"));
Path.Add(new Vector3(-10367.12 , -3076.692 , 22.31659 , "None"));
Path.Add(new Vector3(-10369.23 , -3068.686 , 22.35484 , "None"));
Path.Add(new Vector3(-10367.33 , -3051.744 , 23.35193 , "None"));
Path.Add(new Vector3(-10368.15 , -3040.85 , 23.49192 , "None"));
Path.Add(new Vector3(-10371.26 , -3028.091 , 21.16933 , "None"));
Path.Add(new Vector3(-10373.23 , -3020.011 , 18.36359 , "None"));
Path.Add(new Vector3(-10376.54 , -3006.409 , 18.36776 , "None"));
Path.Add(new Vector3(-10377.89 , -3000.887 , 19.98405 , "None"));
Path.Add(new Vector3(-10375.58 , -2997.179 , 20.61916 , "None"));
Path.Add(new Vector3(-10371.58 , -2991.991 , 21.49088 , "None"));
Path.Add(new Vector3(-10385.16 , -2995.412 , 21.29363 , "None"));
Path.Add(new Vector3(-10398.9 , -2998.016 , 20.58398 , "None"));
Path.Add(new Vector3(-10403.7 , -2997.801 , 20.31357 , "None"));
Path.Add(new Vector3(-10408.65 , -2993.494 , 20.88681 , "None"));
Path.Add(new Vector3(-10403.93 , -2980.804 , 21.91879 , "None"));
Path.Add(new Vector3(-10398.35 , -2972.986 , 21.92167 , "None"));
Path.Add(new Vector3(-10393.96 , -2968.125 , 22.63917 , "None"));
Path.Add(new Vector3(-10405.94 , -2958.039 , 22.0718 , "None"));
Path.Add(new Vector3(-10418.34 , -2951.531 , 22.27392 , "None"));
Path.Add(new Vector3(-10428.44 , -2944.599 , 23.04475 , "None"));
Path.Add(new Vector3(-10436.84 , -2936.941 , 21.72913 , "None"));
Path.Add(new Vector3(-10441.25 , -2932.068 , 21.35769 , "None"));
Path.Add(new Vector3(-10449.52 , -2931.28 , 19.6186 , "None"));
Path.Add(new Vector3(-10463.46 , -2929.955 , 17.82855 , "None"));
Path.Add(new Vector3(-10473.91 , -2928.961 , 21.03576 , "None"));
Path.Add(new Vector3(-10483.92 , -2928.009 , 22.72357 , "None"));
Path.Add(new Vector3(-10492.65 , -2927.179 , 22.12345 , "None"));
Path.Add(new Vector3(-10507.35 , -2925.01 , 22.28537 , "None"));
Path.Add(new Vector3(-10510.72 , -2923.01 , 21.71279 , "None"));
Path.Add(new Vector3(-10515.34 , -2918.385 , 21.67803 , "None"));
Path.Add(new Vector3(-10519.41 , -2913.216 , 21.67803 , "None"));
Path.Add(new Vector3(-10528.07 , -2902.216 , 22.09034 , "None"));
Path.Add(new Vector3(-10536.22 , -2890.836 , 23.47464 , "None"));
Path.Add(new Vector3(-10542.76 , -2878.484 , 22.10402 , "None"));
Path.Add(new Vector3(-10548.51 , -2865.721 , 22.1138 , "None"));
Path.Add(new Vector3(-10550.02 , -2862.565 , 22.51974 , "None"));
Path.Add(new Vector3(-10556.08 , -2849.941 , 24.23164 , "None"));
Path.Add(new Vector3(-10558.91 , -2844.033 , 23.14075 , "None"));
Path.Add(new Vector3(-10556.3 , -2836.136 , 22.51699 , "None"));
Path.Add(new Vector3(-10551.92 , -2822.849 , 22.78276 , "None"));
Path.Add(new Vector3(-10547.54 , -2809.554 , 23.71787 , "None"));
Path.Add(new Vector3(-10545.75 , -2804.156 , 24.09586 , "None"));
Path.Add(new Vector3(-10548.81 , -2798.33 , 24.37112 , "None"));
Path.Add(new Vector3(-10556.31 , -2786.512 , 23.33957 , "None"));
Path.Add(new Vector3(-10563.94 , -2774.774 , 26.07393 , "None"));
Path.Add(new Vector3(-10568.7 , -2767.45 , 28.08808 , "None"));
Path.Add(new Vector3(-10576.67 , -2754.87 , 26.12271 , "None"));
Path.Add(new Vector3(-10577.62 , -2746.82 , 26.17871 , "None"));
Path.Add(new Vector3(-10579.31 , -2732.7 , 26.61574 , "None"));
Path.Add(new Vector3(-10579.25 , -2727.187 , 26.01097 , "None"));
Path.Add(new Vector3(-10570.18 , -2724.046 , 26.38267 , "None"));
Path.Add(new Vector3(-10562.89 , -2722.809 , 26.10578 , "None"));
Path.Add(new Vector3(-10555.61 , -2724.381 , 26.60349 , "None"));
Path.Add(new Vector3(-10541.96 , -2727.487 , 27.09516 , "None"));
Path.Add(new Vector3(-10538.03 , -2727.822 , 26.25635 , "None"));
Path.Add(new Vector3(-10523.16 , -2727.889 , 26.70776 , "None"));
Path.Add(new Vector3(-10510.03 , -2727.948 , 24.72615 , "None"));
Path.Add(new Vector3(-10501.72 , -2727.986 , 22.9301 , "None"));
Path.Add(new Vector3(-10489.48 , -2728.041 , 23.48058 , "None"));
Path.Add(new Vector3(-10482.04 , -2728.074 , 22.41201 , "None"));
Path.Add(new Vector3(-10473.05 , -2724.773 , 21.95304 , "None"));
Path.Add(new Vector3(-10468.93 , -2719.656 , 21.70651 , "None"));
Path.Add(new Vector3(-10467.18 , -2716.624 , 21.67783 , "None"));
Path.Add(new Vector3(-10460.19 , -2704.494 , 22.62028 , "None"));
Path.Add(new Vector3(-10453.53 , -2690.71 , 22.59583 , "None"));
Path.Add(new Vector3(-10447.75 , -2677.962 , 23.4419 , "None"));
Path.Add(new Vector3(-10455.66 , -2671.717 , 23.30222 , "None"));
Path.Add(new Vector3(-10465.82 , -2662.168 , 22.02079 , "None"));
Path.Add(new Vector3(-10472.83 , -2650.132 , 21.67878 , "None"));
Path.Add(new Vector3(-10478.62 , -2637.389 , 21.67807 , "None"));
Path.Add(new Vector3(-10485.32 , -2627.167 , 21.68311 , "None"));
Path.Add(new Vector3(-10487.49 , -2624.424 , 22.30341 , "None"));
Path.Add(new Vector3(-10497.06 , -2614.247 , 22.23455 , "None"));
Path.Add(new Vector3(-10501.62 , -2609.539 , 23.77794 , "None"));
Path.Add(new Vector3(-10512.81 , -2597.849 , 23.07867 , "None"));
Path.Add(new Vector3(-10516.88 , -2592.719 , 22.0831 , "None"));
Path.Add(new Vector3(-10521.4 , -2586.796 , 23.61243 , "None"));
Path.Add(new Vector3(-10522.4 , -2578.541 , 22.94221 , "None"));
Path.Add(new Vector3(-10526.24 , -2579.445 , 22.97543 , "None"));
Path.Add(new Vector3(-10539.91 , -2582.49 , 22.63819 , "None"));
Path.Add(new Vector3(-10553.77 , -2584.457 , 22.84098 , "None"));
Path.Add(new Vector3(-10561.15 , -2585.415 , 22.261 , "None"));
Path.Add(new Vector3(-10570.12 , -2580.895 , 22.50774 , "None"));
Path.Add(new Vector3(-10581.68 , -2574.662 , 22.37032 , "None"));
Path.Add(new Vector3(-10589.87 , -2573.227 , 22.51637 , "None"));
Path.Add(new Vector3(-10603.5 , -2570.068 , 23.07988 , "None"));
Path.Add(new Vector3(-10616.67 , -2565.353 , 22.25932 , "None"));
Path.Add(new Vector3(-10621.74 , -2562.785 , 21.73517 , "None"));
Path.Add(new Vector3(-10621.28 , -2547.062 , 23.65067 , "None"));
Path.Add(new Vector3(-10621.46 , -2534.8 , 23.32036 , "None"));
Path.Add(new Vector3(-10621.91 , -2524.762 , 22.44111 , "None"));
Path.Add(new Vector3(-10624.14 , -2516.286 , 22.73953 , "None"));
Path.Add(new Vector3(-10628.24 , -2502.9 , 26.21975 , "None"));
Path.Add(new Vector3(-10629.9 , -2497.465 , 26.92666 , "None"));
Path.Add(new Vector3(-10622.7 , -2484.686 , 26.13333 , "None"));
Path.Add(new Vector3(-10615.27 , -2481.021 , 24.61482 , "None"));
Path.Add(new Vector3(-10610.85 , -2479.111 , 23.6576 , "None"));
Path.Add(new Vector3(-10597.36 , -2472.816 , 22.92213 , "None"));
Path.Add(new Vector3(-10587.14 , -2469.051 , 22.17264 , "None"));
Path.Add(new Vector3(-10572.32 , -2467.659 , 22.635 , "None"));
Path.Add(new Vector3(-10558.39 , -2466.688 , 23.3794 , "None"));
Path.Add(new Vector3(-10544.82 , -2469.956 , 23.59437 , "None"));
Path.Add(new Vector3(-10534.46 , -2474.578 , 24.72522 , "None"));
Path.Add(new Vector3(-10526.26 , -2482.491 , 24.72391 , "None"));
Path.Add(new Vector3(-10516.39 , -2492.428 , 24.52004 , "None"));
Path.Add(new Vector3(-10506.05 , -2501.817 , 24.42039 , "None"));
Path.Add(new Vector3(-10492.37 , -2509.566 , 24.10399 , "None"));
Path.Add(new Vector3(-10480.47 , -2512.275 , 23.80753 , "None"));
Path.Add(new Vector3(-10464.05 , -2510.02 , 23.82073 , "None"));
Path.Add(new Vector3(-10450.79 , -2505.537 , 25.6256 , "None"));
Path.Add(new Vector3(-10437.6 , -2500.842 , 27.16032 , "None"));
Path.Add(new Vector3(-10424.11 , -2497.146 , 30.01471 , "None"));
Path.Add(new Vector3(-10409.9 , -2494.674 , 32.51203 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = true;
IsHotSpots = false;
IsLoop = false;

    }

        








public override bool HasQuest() { return true; }


}


public sealed class GatherStromgarde : QuestFollowPathClass
{
    public GatherStromgarde()
    {
        Name = "GatherStromgarde";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-1528.579 , -1837.988 , 67.93433 , "None"));
Path.Add(new Vector3(-1528.857 , -1842.025 , 67.81441 , "None"));
Path.Add(new Vector3(-1531.028 , -1848.593 , 67.76672 , "None"));
Path.Add(new Vector3(-1535.378 , -1854.029 , 67.63757 , "None"));
Path.Add(new Vector3(-1538.221 , -1856.064 , 67.4071 , "None"));
Path.Add(new Vector3(-1541.204 , -1857.894 , 67.13642 , "None"));
Path.Add(new Vector3(-1544.185 , -1859.729 , 67.07172 , "None"));
Path.Add(new Vector3(-1549.296 , -1864.427 , 67.41545 , "None"));
Path.Add(new Vector3(-1549.451 , -1870.732 , 67.44006 , "None"));
Path.Add(new Vector3(-1549.346 , -1874.23 , 67.50634 , "None"));
Path.Add(new Vector3(-1549.273 , -1878.171 , 67.63442 , "None"));
Path.Add(new Vector3(-1549.219 , -1881.67 , 67.60561 , "None"));
Path.Add(new Vector3(-1549.208 , -1885.17 , 67.63085 , "None"));
Path.Add(new Vector3(-1549.201 , -1888.67 , 67.59502 , "None"));
Path.Add(new Vector3(-1549.199 , -1892.17 , 67.55808 , "None"));
Path.Add(new Vector3(-1549.202 , -1895.67 , 67.82452 , "None"));
Path.Add(new Vector3(-1549.214 , -1899.17 , 67.95377 , "None"));
Path.Add(new Vector3(-1549.225 , -1902.67 , 67.7879 , "None"));
Path.Add(new Vector3(-1547.35 , -1907.502 , 67.87897 , "None"));
Path.Add(new Vector3(-1544.366 , -1909.331 , 68.07983 , "None"));
Path.Add(new Vector3(-1539.568 , -1914.331 , 68.12869 , "None"));
Path.Add(new Vector3(-1539.169 , -1921.229 , 68.60386 , "None"));
Path.Add(new Vector3(-1539.995 , -1924.74 , 68.55503 , "None"));
Path.Add(new Vector3(-1537.574 , -1921.692 , 68.70413 , "None"));
Path.Add(new Vector3(-1534.714 , -1919.045 , 68.73629 , "None"));
Path.Add(new Vector3(-1528.132 , -1916.736 , 68.30914 , "None"));
Path.Add(new Vector3(-1521.756 , -1914.53 , 68.43571 , "None"));
Path.Add(new Vector3(-1516.697 , -1909.746 , 68.43688 , "None"));
Path.Add(new Vector3(-1514.508 , -1907.015 , 68.64666 , "None"));
Path.Add(new Vector3(-1511.132 , -1900.901 , 68.5667 , "None"));
Path.Add(new Vector3(-1509.693 , -1897.71 , 68.6372 , "None"));
Path.Add(new Vector3(-1507.087 , -1891.217 , 68.67247 , "None"));
Path.Add(new Vector3(-1505.147 , -1884.493 , 68.40249 , "None"));
Path.Add(new Vector3(-1504.305 , -1881.096 , 68.32684 , "None"));
Path.Add(new Vector3(-1503.463 , -1877.698 , 68.45582 , "None"));
Path.Add(new Vector3(-1502.556 , -1874.318 , 68.66903 , "None"));
Path.Add(new Vector3(-1501.608 , -1870.949 , 68.55853 , "None"));
Path.Add(new Vector3(-1500.188 , -1864.102 , 68.65388 , "None"));
Path.Add(new Vector3(-1499.998 , -1857.11 , 68.59426 , "None"));
Path.Add(new Vector3(-1500 , -1853.61 , 68.69976 , "None"));
Path.Add(new Vector3(-1500.002 , -1850.11 , 69.00396 , "None"));
Path.Add(new Vector3(-1500.004 , -1846.61 , 68.99181 , "None"));
Path.Add(new Vector3(-1500.006 , -1843.11 , 68.90698 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

        








public override bool HasQuest() { return true; }


}


public sealed class GatherTranquilGardens : QuestGathererClass
{
    public GatherTranquilGardens()
    {
        Name = "GatherTranquilGardens";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(1628);
HotSpots.Add(new Vector3(-10970.18 , -1275.866 , 52.69971 , "None"));

    }

        








public override bool HasQuest() { return true; }


}


public sealed class GatherTranquilGardensBetter : QuestFollowPathClass
{
    public GatherTranquilGardensBetter()
    {
        Name = "GatherTranquilGardensBetter";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-10960.67 , -1291.6 , 53.07221 , "None"));
Path.Add(new Vector3(-10959.56 , -1297.528 , 53.15327 , "None"));
Path.Add(new Vector3(-10963.8 , -1302.699 , 52.97549 , "None"));
Path.Add(new Vector3(-10966.54 , -1304.876 , 52.82097 , "None"));
Path.Add(new Vector3(-10970.84 , -1310.084 , 52.50373 , "None"));
Path.Add(new Vector3(-10972.39 , -1313.218 , 52.37527 , "None"));
Path.Add(new Vector3(-10974.1 , -1319.968 , 52.2585 , "None"));
Path.Add(new Vector3(-10975.13 , -1327.017 , 52.32108 , "None"));
Path.Add(new Vector3(-10981.53 , -1328.227 , 51.98895 , "None"));
Path.Add(new Vector3(-10988.35 , -1326.743 , 51.85539 , "None"));
Path.Add(new Vector3(-10995.08 , -1324.814 , 51.98035 , "None"));
Path.Add(new Vector3(-10998.66 , -1323.787 , 52.13345 , "None"));
Path.Add(new Vector3(-11005.19 , -1321.976 , 52.51411 , "None"));
Path.Add(new Vector3(-11008.83 , -1321.176 , 52.72614 , "None"));
Path.Add(new Vector3(-11015.52 , -1320.15 , 53.01484 , "None"));
Path.Add(new Vector3(-11022.28 , -1318.41 , 53.16945 , "None"));
Path.Add(new Vector3(-11028.93 , -1316.205 , 53.21222 , "None"));
Path.Add(new Vector3(-11032.4 , -1315.243 , 53.26012 , "None"));
Path.Add(new Vector3(-11032.74 , -1310.103 , 52.95774 , "None"));
Path.Add(new Vector3(-11030.92 , -1307.006 , 52.66729 , "None"));
Path.Add(new Vector3(-11028.75 , -1304.265 , 52.46503 , "None"));
Path.Add(new Vector3(-11026.57 , -1301.526 , 52.38689 , "None"));
Path.Add(new Vector3(-11024.39 , -1298.787 , 52.40628 , "None"));
Path.Add(new Vector3(-11021.8 , -1296.146 , 52.54734 , "None"));
Path.Add(new Vector3(-11016.11 , -1292.458 , 52.93981 , "None"));
Path.Add(new Vector3(-11012.99 , -1290.437 , 53.04602 , "None"));
Path.Add(new Vector3(-11007.32 , -1286.721 , 53.02055 , "None"));
Path.Add(new Vector3(-11004.47 , -1284.687 , 52.91816 , "None"));
Path.Add(new Vector3(-11001.62 , -1282.65 , 52.78202 , "None"));
Path.Add(new Vector3(-10998.78 , -1280.611 , 52.64573 , "None"));
Path.Add(new Vector3(-10995.9 , -1278.286 , 52.54074 , "None"));
Path.Add(new Vector3(-10992.34 , -1272.547 , 52.39029 , "None"));
Path.Add(new Vector3(-10990.94 , -1269.339 , 52.33052 , "None"));
Path.Add(new Vector3(-10989.55 , -1266.129 , 52.28399 , "None"));
Path.Add(new Vector3(-10984.78 , -1262.071 , 52.57495 , "None"));
Path.Add(new Vector3(-10981.31 , -1262.518 , 53.05236 , "None"));
Path.Add(new Vector3(-10977.84 , -1262.965 , 53.47606 , "None"));
Path.Add(new Vector3(-10974.37 , -1263.412 , 53.75136 , "None"));
Path.Add(new Vector3(-10967.42 , -1264.305 , 53.60004 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

        








public override bool HasQuest() { return true; }


}


public sealed class GatherWitchHill : QuestFollowPathClass
{
    public GatherWitchHill()
    {
        Name = "GatherWitchHill";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-10590.24 , 295.5923 , 31.15828 , "None"));
Path.Add(new Vector3(-10590.79 , 305.6285 , 30.4188 , "None"));
Path.Add(new Vector3(-10591.09 , 319.6251 , 31.57409 , "None"));
Path.Add(new Vector3(-10590.33 , 333.6031 , 31.5923 , "None"));
Path.Add(new Vector3(-10589.43 , 345.8331 , 30.03881 , "None"));
Path.Add(new Vector3(-10588.55 , 354.1015 , 29.16683 , "None"));
Path.Add(new Vector3(-10586.57 , 363.0678 , 29.80329 , "None"));
Path.Add(new Vector3(-10584.48 , 370.216 , 31.19277 , "None"));
Path.Add(new Vector3(-10581.85 , 376.2173 , 32.55931 , "None"));
Path.Add(new Vector3(-10579.22 , 382.2187 , 32.80131 , "None"));
Path.Add(new Vector3(-10577.02 , 386.9639 , 32.05279 , "None"));
Path.Add(new Vector3(-10570.46 , 394.5926 , 30.09378 , "None"));
Path.Add(new Vector3(-10566.57 , 398.7338 , 30.55733 , "None"));
Path.Add(new Vector3(-10557.06 , 408.9965 , 34.53726 , "None"));
Path.Add(new Vector3(-10550.02 , 412.5726 , 35.63514 , "None"));
Path.Add(new Vector3(-10545.89 , 413.9479 , 35.66294 , "None"));
Path.Add(new Vector3(-10534.02 , 416.981 , 35.82154 , "None"));
Path.Add(new Vector3(-10523.29 , 419.02 , 36.65933 , "None"));
Path.Add(new Vector3(-10519.35 , 418.8971 , 36.58399 , "None"));
Path.Add(new Vector3(-10511.93 , 418.6597 , 36.42019 , "None"));
Path.Add(new Vector3(-10502.37 , 415.4642 , 35.89626 , "None"));
Path.Add(new Vector3(-10489.1 , 411.0259 , 35.86069 , "None"));
Path.Add(new Vector3(-10483.71 , 409.2239 , 36.18929 , "None"));
Path.Add(new Vector3(-10473.75 , 405.8759 , 36.68049 , "None"));
Path.Add(new Vector3(-10459.5 , 397.3133 , 39.84581 , "None"));
Path.Add(new Vector3(-10445.14 , 390.9483 , 43.8273 , "None"));
Path.Add(new Vector3(-10430.75 , 387.1046 , 44.60954 , "None"));
Path.Add(new Vector3(-10420.52 , 384.7245 , 45.0024 , "None"));
Path.Add(new Vector3(-10413.56 , 382.0605 , 45.75528 , "None"));
Path.Add(new Vector3(-10402.95 , 377.9944 , 46.70599 , "None"));
Path.Add(new Vector3(-10399.68 , 376.7425 , 46.77499 , "None"));
Path.Add(new Vector3(-10386.63 , 371.698 , 47.35466 , "None"));
Path.Add(new Vector3(-10383.51 , 365.0159 , 48.81152 , "None"));
Path.Add(new Vector3(-10379.95 , 356.0959 , 49.33488 , "None"));
Path.Add(new Vector3(-10373.92 , 342.997 , 48.94987 , "None"));
Path.Add(new Vector3(-10371.07 , 335.6636 , 47.90328 , "None"));
Path.Add(new Vector3(-10367.32 , 323.5583 , 47.05016 , "None"));
Path.Add(new Vector3(-10366.01 , 314.8933 , 46.13474 , "None"));
Path.Add(new Vector3(-10364.78 , 306.2438 , 43.53977 , "None"));
Path.Add(new Vector3(-10362.94 , 293.2417 , 40.43674 , "None"));
Path.Add(new Vector3(-10360.97 , 279.3803 , 38.24142 , "None"));
Path.Add(new Vector3(-10359.93 , 272.006 , 37.18296 , "None"));
Path.Add(new Vector3(-10359 , 257.1669 , 37.00208 , "None"));
Path.Add(new Vector3(-10358.4 , 253.2647 , 36.784 , "None"));
Path.Add(new Vector3(-10362.15 , 245.2507 , 35.28752 , "None"));
Path.Add(new Vector3(-10369.47 , 234.3493 , 32.75666 , "None"));
Path.Add(new Vector3(-10374.22 , 228.6222 , 32.90486 , "None"));
Path.Add(new Vector3(-10384.54 , 219.186 , 33.58093 , "None"));
Path.Add(new Vector3(-10394.7 , 212.338 , 33.37762 , "None"));
Path.Add(new Vector3(-10404.09 , 208.9933 , 33.90617 , "None"));
Path.Add(new Vector3(-10420.72 , 209.3122 , 35.06493 , "None"));
Path.Add(new Vector3(-10430.35 , 209.4689 , 35.0404 , "None"));
Path.Add(new Vector3(-10433.85 , 209.5259 , 34.52293 , "None"));
Path.Add(new Vector3(-10447.85 , 209.7536 , 32.89771 , "None"));
Path.Add(new Vector3(-10452.19 , 208.0422 , 33.24049 , "None"));
Path.Add(new Vector3(-10461.08 , 197.27 , 32.81737 , "None"));
Path.Add(new Vector3(-10471.95 , 188.4582 , 32.14913 , "None"));
Path.Add(new Vector3(-10475.9 , 185.7128 , 32.56319 , "None"));
Path.Add(new Vector3(-10486.71 , 195.9584 , 32.34115 , "None"));
Path.Add(new Vector3(-10497.01 , 205.4393 , 32.36118 , "None"));
Path.Add(new Vector3(-10507.36 , 214.8673 , 33.00723 , "None"));
Path.Add(new Vector3(-10516.27 , 221.2201 , 33.23941 , "None"));
Path.Add(new Vector3(-10522.85 , 221.291 , 33.3984 , "None"));
Path.Add(new Vector3(-10536.74 , 223.0146 , 32.25466 , "None"));
Path.Add(new Vector3(-10543.97 , 224.7874 , 31.5522 , "None"));
Path.Add(new Vector3(-10547.63 , 226.1449 , 31.17135 , "None"));
Path.Add(new Vector3(-10553.81 , 232.8932 , 30.59018 , "None"));
Path.Add(new Vector3(-10552.28 , 236.0415 , 31.16018 , "None"));
Path.Add(new Vector3(-10545.98 , 249.0123 , 32.11532 , "None"));
Path.Add(new Vector3(-10538.15 , 265.1314 , 30.01156 , "None"));
Path.Add(new Vector3(-10531.19 , 277.26 , 30.68726 , "None"));
Path.Add(new Vector3(-10528.03 , 282.5138 , 31.55919 , "None"));
Path.Add(new Vector3(-10532.72 , 292.8497 , 31.11402 , "None"));
Path.Add(new Vector3(-10536.57 , 293.5864 , 30.8941 , "None"));
Path.Add(new Vector3(-10549.44 , 296.1625 , 30.3359 , "None"));
Path.Add(new Vector3(-10562.88 , 302.5052 , 30.03604 , "None"));
Path.Add(new Vector3(-10574.78 , 308.0252 , 30.17184 , "None"));
Path.Add(new Vector3(-10578.99 , 309.1833 , 29.7772 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

        








public override bool HasQuest() { return true; }


}


public sealed class GatherWitchHillBetter : QuestFollowPathClass
{
    public GatherWitchHillBetter()
    {
        Name = "GatherWitchHillBetter";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-10595.34 , 325.719 , 32.31208 , "None"));
Path.Add(new Vector3(-10595.3 , 333.1637 , 32.29135 , "None"));
Path.Add(new Vector3(-10595.64 , 340.5891 , 31.82856 , "None"));
Path.Add(new Vector3(-10596.07 , 347.1405 , 31.19879 , "None"));
Path.Add(new Vector3(-10596.54 , 354.125 , 30.51785 , "None"));
Path.Add(new Vector3(-10596.8 , 361.1184 , 30.44106 , "None"));
Path.Add(new Vector3(-10597 , 368.115 , 30.94995 , "None"));
Path.Add(new Vector3(-10597.24 , 375.1101 , 31.76963 , "None"));
Path.Add(new Vector3(-10597.26 , 382.1098 , 32.51144 , "None"));
Path.Add(new Vector3(-10596.87 , 389.0988 , 33.00351 , "None"));
Path.Add(new Vector3(-10595.35 , 395.8933 , 32.88388 , "None"));
Path.Add(new Vector3(-10591.37 , 401.6319 , 31.94657 , "None"));
Path.Add(new Vector3(-10584.79 , 406.961 , 30.61594 , "None"));
Path.Add(new Vector3(-10578.25 , 409.435 , 30.02526 , "None"));
Path.Add(new Vector3(-10571.64 , 411.7552 , 31.79664 , "None"));
Path.Add(new Vector3(-10564.84 , 413.2815 , 33.96472 , "None"));
Path.Add(new Vector3(-10557.88 , 414.0405 , 35.50234 , "None"));
Path.Add(new Vector3(-10550.92 , 414.7062 , 35.99606 , "None"));
Path.Add(new Vector3(-10543.99 , 415.7174 , 35.86898 , "None"));
Path.Add(new Vector3(-10537.23 , 417.5394 , 35.91319 , "None"));
Path.Add(new Vector3(-10530.54 , 419.5911 , 36.68277 , "None"));
Path.Add(new Vector3(-10523.93 , 421.173 , 37.21534 , "None"));
Path.Add(new Vector3(-10518.09 , 422.8998 , 37.53425 , "None"));
Path.Add(new Vector3(-10511.87 , 426.1054 , 37.80418 , "None"));
Path.Add(new Vector3(-10506.06 , 430.001 , 38.17195 , "None"));
Path.Add(new Vector3(-10500.46 , 434.2032 , 38.09718 , "None"));
Path.Add(new Vector3(-10496.68 , 435.8236 , 37.7709 , "None"));
Path.Add(new Vector3(-10491.03 , 431.8432 , 37.92601 , "None"));
Path.Add(new Vector3(-10487.67 , 425.707 , 37.70384 , "None"));
Path.Add(new Vector3(-10483.87 , 419.827 , 36.9473 , "None"));
Path.Add(new Vector3(-10479.89 , 414.0714 , 36.3974 , "None"));
Path.Add(new Vector3(-10475.58 , 408.5553 , 36.62086 , "None"));
Path.Add(new Vector3(-10471.17 , 403.1194 , 37.09711 , "None"));
Path.Add(new Vector3(-10466.41 , 397.9969 , 37.81635 , "None"));
Path.Add(new Vector3(-10461.06 , 393.4788 , 39.09925 , "None"));
Path.Add(new Vector3(-10455.44 , 389.3126 , 40.2894 , "None"));
Path.Add(new Vector3(-10449.8 , 385.1669 , 41.77153 , "None"));
Path.Add(new Vector3(-10444.07 , 381.1438 , 44.15244 , "None"));
Path.Add(new Vector3(-10438.01 , 377.634 , 45.05506 , "None"));
Path.Add(new Vector3(-10431.7 , 374.614 , 44.238 , "None"));
Path.Add(new Vector3(-10424.83 , 373.4239 , 44.08329 , "None"));
Path.Add(new Vector3(-10416.44 , 375.4776 , 45.07125 , "None"));
Path.Add(new Vector3(-10410.31 , 378.864 , 45.96096 , "None"));
Path.Add(new Vector3(-10404.14 , 382.1634 , 46.78873 , "None"));
Path.Add(new Vector3(-10397.76 , 385.5449 , 46.84839 , "None"));
Path.Add(new Vector3(-10391.49 , 388.0756 , 46.8606 , "None"));
Path.Add(new Vector3(-10385.72 , 383.9147 , 47.06578 , "None"));
Path.Add(new Vector3(-10382.22 , 378.8785 , 47.55305 , "None"));
Path.Add(new Vector3(-10380.92 , 370.0055 , 49.24118 , "None"));
Path.Add(new Vector3(-10380.28 , 363.0376 , 49.52046 , "None"));
Path.Add(new Vector3(-10379.87 , 356.0499 , 49.35326 , "None"));
Path.Add(new Vector3(-10379.45 , 349.0622 , 48.94873 , "None"));
Path.Add(new Vector3(-10379.06 , 342.5077 , 47.36298 , "None"));
Path.Add(new Vector3(-10378.65 , 335.52 , 45.39577 , "None"));
Path.Add(new Vector3(-10378.23 , 328.5323 , 44.73621 , "None"));
Path.Add(new Vector3(-10377.78 , 321.5472 , 44.70055 , "None"));
Path.Add(new Vector3(-10377.11 , 314.5801 , 43.9482 , "None"));
Path.Add(new Vector3(-10376.07 , 307.2185 , 42.49718 , "None"));
Path.Add(new Vector3(-10375.11 , 300.724 , 41.48579 , "None"));
Path.Add(new Vector3(-10374.08 , 293.8001 , 40.58556 , "None"));
Path.Add(new Vector3(-10372.51 , 286.5357 , 39.25484 , "None"));
Path.Add(new Vector3(-10370.6 , 280.2547 , 37.96627 , "None"));
Path.Add(new Vector3(-10368.53 , 273.569 , 37.20051 , "None"));
Path.Add(new Vector3(-10366.83 , 266.7826 , 37.23859 , "None"));
Path.Add(new Vector3(-10365.37 , 259.9371 , 37.60214 , "None"));
Path.Add(new Vector3(-10363.91 , 253.0916 , 36.46542 , "None"));
Path.Add(new Vector3(-10362.54 , 246.6841 , 35.51489 , "None"));
Path.Add(new Vector3(-10360.92 , 240.7688 , 34.51355 , "None"));
Path.Add(new Vector3(-10358.79 , 234.1036 , 33.459 , "None"));
Path.Add(new Vector3(-10355.38 , 228.0138 , 32.70335 , "None"));
Path.Add(new Vector3(-10351.61 , 223.1974 , 32.54724 , "None"));
Path.Add(new Vector3(-10348.91 , 220.6513 , 32.75811 , "None"));
Path.Add(new Vector3(-10359.11 , 219.4623 , 32.72678 , "None"));
Path.Add(new Vector3(-10365.69 , 217.1603 , 32.99662 , "None"));
Path.Add(new Vector3(-10369.45 , 215.3885 , 33.09187 , "None"));
Path.Add(new Vector3(-10375.78 , 212.3941 , 33.31862 , "None"));
Path.Add(new Vector3(-10381.58 , 208.5125 , 33.26102 , "None"));
Path.Add(new Vector3(-10386.98 , 204.0688 , 33.80918 , "None"));
Path.Add(new Vector3(-10392.12 , 199.3278 , 34.23915 , "None"));
Path.Add(new Vector3(-10396 , 193.5208 , 34.46921 , "None"));
Path.Add(new Vector3(-10398.48 , 186.9772 , 34.79715 , "None"));
Path.Add(new Vector3(-10402.33 , 178.4316 , 35.25019 , "None"));
Path.Add(new Vector3(-10405.77 , 172.3363 , 35.34937 , "None"));
Path.Add(new Vector3(-10409.21 , 166.2411 , 35.2237 , "None"));
Path.Add(new Vector3(-10414.16 , 168.9365 , 35.53895 , "None"));
Path.Add(new Vector3(-10418.92 , 174.0752 , 35.95712 , "None"));
Path.Add(new Vector3(-10424.11 , 178.7629 , 36.01801 , "None"));
Path.Add(new Vector3(-10429.94 , 182.6362 , 35.86459 , "None"));
Path.Add(new Vector3(-10435.82 , 186.4252 , 35.09647 , "None"));
Path.Add(new Vector3(-10441.04 , 189.6477 , 34.08156 , "None"));
Path.Add(new Vector3(-10448.41 , 194.3553 , 33.09705 , "None"));
Path.Add(new Vector3(-10454.04 , 198.5131 , 32.99748 , "None"));
Path.Add(new Vector3(-10459.68 , 202.6588 , 33.24089 , "None"));
Path.Add(new Vector3(-10465.33 , 206.8032 , 33.21819 , "None"));
Path.Add(new Vector3(-10471.35 , 210.3425 , 32.62908 , "None"));
Path.Add(new Vector3(-10477.84 , 212.9469 , 31.73454 , "None"));
Path.Add(new Vector3(-10484.52 , 215.0552 , 31.35662 , "None"));
Path.Add(new Vector3(-10491.19 , 217.1635 , 31.78293 , "None"));
Path.Add(new Vector3(-10497.98 , 218.8422 , 32.29345 , "None"));
Path.Add(new Vector3(-10504.9 , 219.903 , 32.876 , "None"));
Path.Add(new Vector3(-10511.83 , 220.914 , 33.19334 , "None"));
Path.Add(new Vector3(-10518.78 , 221.6014 , 33.31098 , "None"));
Path.Add(new Vector3(-10525.78 , 221.6793 , 33.33036 , "None"));
Path.Add(new Vector3(-10532.78 , 221.7318 , 32.5195 , "None"));
Path.Add(new Vector3(-10539.77 , 221.5567 , 31.62264 , "None"));
Path.Add(new Vector3(-10546.73 , 220.7823 , 30.62654 , "None"));
Path.Add(new Vector3(-10553.73 , 220.7212 , 29.71688 , "None"));
Path.Add(new Vector3(-10558.47 , 221.2743 , 29.71626 , "None"));
Path.Add(new Vector3(-10562.73 , 228.4518 , 29.24548 , "None"));
Path.Add(new Vector3(-10563.07 , 234.7728 , 28.83257 , "None"));
Path.Add(new Vector3(-10563.09 , 241.9968 , 29.04406 , "None"));
Path.Add(new Vector3(-10561.99 , 249.2925 , 29.74827 , "None"));
Path.Add(new Vector3(-10558.9 , 255.5536 , 29.70901 , "None"));
Path.Add(new Vector3(-10555.71 , 261.2961 , 28.96461 , "None"));
Path.Add(new Vector3(-10552.19 , 267.339 , 28.42683 , "None"));
Path.Add(new Vector3(-10548.13 , 273.5698 , 28.50993 , "None"));
Path.Add(new Vector3(-10544.61 , 279.1091 , 28.74697 , "None"));
Path.Add(new Vector3(-10544.43 , 287.2974 , 29.20808 , "None"));
Path.Add(new Vector3(-10547.05 , 293.6385 , 30.40738 , "None"));
Path.Add(new Vector3(-10553.25 , 297.7386 , 30.23889 , "None"));
Path.Add(new Vector3(-10559.2 , 301.4129 , 30.1426 , "None"));
Path.Add(new Vector3(-10565.24 , 304.9546 , 29.94366 , "None"));
Path.Add(new Vector3(-10571.19 , 308.197 , 30.46804 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

        








public override bool HasQuest() { return true; }


}


public sealed class HammerfallToIronbeard : QuestFollowPathClass
{
    public HammerfallToIronbeard()
    {
        Name = "HammerfallToIronbeard";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-916.29 , -3496.89 , 70.45 , "None"));
Path.Add(new Vector3(-919.1621 , -3506.269 , 70.45 , "None"));
Path.Add(new Vector3(-925.8811 , -3513.125 , 70.53065 , "None"));
Path.Add(new Vector3(-934.3562 , -3513.482 , 67.63388 , "None"));
Path.Add(new Vector3(-941.34 , -3513.006 , 63.28228 , "None"));
Path.Add(new Vector3(-948.3238 , -3512.53 , 58.90116 , "None"));
Path.Add(new Vector3(-955.3076 , -3512.054 , 56.96426 , "None"));
Path.Add(new Vector3(-962.3006 , -3511.769 , 56.752 , "None"));
Path.Add(new Vector3(-969.3003 , -3511.837 , 56.77309 , "None"));
Path.Add(new Vector3(-976.2968 , -3512.009 , 57.18972 , "None"));
Path.Add(new Vector3(-988.7518 , -3517.784 , 56.94635 , "None"));
Path.Add(new Vector3(-994.0982 , -3522.302 , 57.10392 , "None"));
Path.Add(new Vector3(-999.4446 , -3526.821 , 57.6427 , "None"));
Path.Add(new Vector3(-1004.791 , -3531.339 , 57.26414 , "None"));
Path.Add(new Vector3(-1010.137 , -3535.858 , 56.74603 , "None"));
Path.Add(new Vector3(-1015.516 , -3540.338 , 56.44502 , "None"));
Path.Add(new Vector3(-1027.552 , -3547.384 , 56.30444 , "None"));
Path.Add(new Vector3(-1034.117 , -3549.8 , 55.827 , "None"));
Path.Add(new Vector3(-1040.911 , -3551.479 , 55.16485 , "None"));
Path.Add(new Vector3(-1047.818 , -3552.596 , 54.54091 , "None"));
Path.Add(new Vector3(-1054.79 , -3553.223 , 53.61242 , "None"));
Path.Add(new Vector3(-1061.771 , -3553.733 , 52.77653 , "None"));
Path.Add(new Vector3(-1068.76 , -3554.122 , 51.86382 , "None"));
Path.Add(new Vector3(-1075.754 , -3554.415 , 51.05767 , "None"));
Path.Add(new Vector3(-1082.748 , -3554.709 , 50.36667 , "None"));
Path.Add(new Vector3(-1089.746 , -3554.872 , 49.50359 , "None"));
Path.Add(new Vector3(-1096.969 , -3555.005 , 48.87704 , "None"));
Path.Add(new Vector3(-1110.693 , -3554.543 , 48.9955 , "None"));
Path.Add(new Vector3(-1117.676 , -3552.701 , 49.14631 , "None"));
Path.Add(new Vector3(-1130.87 , -3548.043 , 50.42533 , "None"));
Path.Add(new Vector3(-1143.463 , -3541.952 , 50.71502 , "None"));
Path.Add(new Vector3(-1149.42 , -3538.285 , 49.64735 , "None"));
Path.Add(new Vector3(-1154.75 , -3533.75 , 47.84555 , "None"));
Path.Add(new Vector3(-1159.585 , -3528.693 , 46.49662 , "None"));
Path.Add(new Vector3(-1163.835 , -3523.145 , 44.67911 , "None"));
Path.Add(new Vector3(-1167.075 , -3516.944 , 42.39146 , "None"));
Path.Add(new Vector3(-1169.609 , -3510.427 , 40.5037 , "None"));
Path.Add(new Vector3(-1171.816 , -3503.784 , 38.87998 , "None"));
Path.Add(new Vector3(-1174.023 , -3497.141 , 37.49886 , "None"));
Path.Add(new Vector3(-1176.168 , -3490.479 , 36.55481 , "None"));
Path.Add(new Vector3(-1177.337 , -3483.58 , 35.76188 , "None"));
Path.Add(new Vector3(-1175.981 , -3469.711 , 33.92322 , "None"));
Path.Add(new Vector3(-1174.472 , -3462.876 , 32.96367 , "None"));
Path.Add(new Vector3(-1172.829 , -3456.071 , 32.60601 , "None"));
Path.Add(new Vector3(-1171.186 , -3449.267 , 32.82819 , "None"));
Path.Add(new Vector3(-1169.549 , -3442.461 , 32.50489 , "None"));
Path.Add(new Vector3(-1168.267 , -3435.581 , 31.94055 , "None"));
Path.Add(new Vector3(-1167.562 , -3428.617 , 31.59041 , "None"));
Path.Add(new Vector3(-1166.977 , -3421.642 , 31.35507 , "None"));
Path.Add(new Vector3(-1166.391 , -3414.666 , 30.93157 , "None"));
Path.Add(new Vector3(-1165.806 , -3407.691 , 30.26777 , "None"));
Path.Add(new Vector3(-1165.419 , -3400.704 , 29.29159 , "None"));
Path.Add(new Vector3(-1165.406 , -3393.704 , 28.13451 , "None"));
Path.Add(new Vector3(-1165.535 , -3386.705 , 27.22149 , "None"));
Path.Add(new Vector3(-1165.76 , -3379.709 , 26.52027 , "None"));
Path.Add(new Vector3(-1166.054 , -3372.715 , 26.10566 , "None"));
Path.Add(new Vector3(-1167.538 , -3358.812 , 26.20461 , "None"));
Path.Add(new Vector3(-1168.489 , -3351.877 , 26.44617 , "None"));
Path.Add(new Vector3(-1169.462 , -3344.945 , 26.85402 , "None"));
Path.Add(new Vector3(-1170.744 , -3338.066 , 27.03924 , "None"));
Path.Add(new Vector3(-1174.639 , -3324.629 , 27.80789 , "None"));
Path.Add(new Vector3(-1177.387 , -3318.194 , 28.16632 , "None"));
Path.Add(new Vector3(-1184.898 , -3306.434 , 28.88163 , "None"));
Path.Add(new Vector3(-1189.132 , -3300.86 , 29.05122 , "None"));
Path.Add(new Vector3(-1193.502 , -3295.392 , 29.06533 , "None"));
Path.Add(new Vector3(-1197.872 , -3289.923 , 29.35631 , "None"));
Path.Add(new Vector3(-1202.242 , -3284.455 , 29.4034 , "None"));
Path.Add(new Vector3(-1206.649 , -3279.017 , 29.24776 , "None"));
Path.Add(new Vector3(-1211.356 , -3273.836 , 29.06576 , "None"));
Path.Add(new Vector3(-1216.139 , -3268.725 , 28.96918 , "None"));
Path.Add(new Vector3(-1220.92 , -3263.612 , 29.38164 , "None"));
Path.Add(new Vector3(-1225.586 , -3258.116 , 30.65238 , "None"));
Path.Add(new Vector3(-1234.469 , -3247.57 , 33.23177 , "None"));
Path.Add(new Vector3(-1239.231 , -3242.155 , 34.05569 , "None"));
Path.Add(new Vector3(-1243.853 , -3236.899 , 34.54979 , "None"));
Path.Add(new Vector3(-1248.476 , -3231.642 , 34.67366 , "None"));
Path.Add(new Vector3(-1257.434 , -3221.455 , 34.64182 , "None"));
Path.Add(new Vector3(-1262.343 , -3215.872 , 34.79515 , "None"));
Path.Add(new Vector3(-1271.154 , -3205.853 , 34.54258 , "None"));
Path.Add(new Vector3(-1276.211 , -3200.102 , 34.5646 , "None"));
Path.Add(new Vector3(-1285.456 , -3189.589 , 35.5685 , "None"));
Path.Add(new Vector3(-1290.06 , -3184.316 , 35.66957 , "None"));
Path.Add(new Vector3(-1296.936 , -3172.219 , 35.43972 , "None"));
Path.Add(new Vector3(-1298.815 , -3158.859 , 35.04046 , "None"));
Path.Add(new Vector3(-1297.329 , -3144.954 , 35.17944 , "None"));
Path.Add(new Vector3(-1296.061 , -3138.07 , 34.82437 , "None"));
Path.Add(new Vector3(-1294.741 , -3131.195 , 34.63971 , "None"));
Path.Add(new Vector3(-1293.421 , -3124.321 , 34.11082 , "None"));
Path.Add(new Vector3(-1292.1 , -3117.447 , 33.87931 , "None"));
Path.Add(new Vector3(-1290.78 , -3110.572 , 33.69555 , "None"));
Path.Add(new Vector3(-1289.443 , -3103.701 , 33.50009 , "None"));
Path.Add(new Vector3(-1288.096 , -3096.832 , 33.6381 , "None"));
Path.Add(new Vector3(-1286.749 , -3089.963 , 34.05016 , "None"));
Path.Add(new Vector3(-1286.24 , -3075.994 , 34.39207 , "None"));
Path.Add(new Vector3(-1285.87 , -3069.006 , 35.2606 , "None"));
Path.Add(new Vector3(-1282.908 , -3055.335 , 35.41442 , "None"));
Path.Add(new Vector3(-1281.238 , -3048.537 , 35.75576 , "None"));
Path.Add(new Vector3(-1277.929 , -3034.94 , 36.09583 , "None"));
Path.Add(new Vector3(-1276.731 , -3028.047 , 36.36738 , "None"));
Path.Add(new Vector3(-1276.235 , -3021.065 , 35.96445 , "None"));
Path.Add(new Vector3(-1275.938 , -3014.072 , 36.21292 , "None"));
Path.Add(new Vector3(-1275.769 , -3007.074 , 36.40834 , "None"));
Path.Add(new Vector3(-1277.038 , -2993.151 , 36.2532 , "None"));
Path.Add(new Vector3(-1278.47 , -2986.302 , 35.54363 , "None"));
Path.Add(new Vector3(-1283.49 , -2973.248 , 35.4488 , "None"));
Path.Add(new Vector3(-1291.407 , -2961.759 , 35.69801 , "None"));
Path.Add(new Vector3(-1296.958 , -2957.531 , 36.36012 , "None"));
Path.Add(new Vector3(-1309.686 , -2951.725 , 37.43722 , "None"));
Path.Add(new Vector3(-1316.451 , -2949.19 , 38.07985 , "None"));
Path.Add(new Vector3(-1326.624 , -2940.475 , 38.97898 , "None"));
Path.Add(new Vector3(-1331.942 , -2927.297 , 39.36203 , "None"));
Path.Add(new Vector3(-1334.672 , -2920.858 , 40.71162 , "None"));
Path.Add(new Vector3(-1338.482 , -2914.993 , 41.90018 , "None"));
Path.Add(new Vector3(-1342.935 , -2909.597 , 42.20167 , "None"));
Path.Add(new Vector3(-1348.049 , -2904.82 , 41.1388 , "None"));
Path.Add(new Vector3(-1353.395 , -2900.304 , 38.5452 , "None"));
Path.Add(new Vector3(-1359.034 , -2896.156 , 34.81016 , "None"));
Path.Add(new Vector3(-1364.433 , -2891.715 , 32.81231 , "None"));
Path.Add(new Vector3(-1368.886 , -2886.327 , 32.2437 , "None"));
Path.Add(new Vector3(-1372.66 , -2880.433 , 32.42616 , "None"));
Path.Add(new Vector3(-1376.065 , -2874.317 , 33.01846 , "None"));
Path.Add(new Vector3(-1379.408 , -2868.167 , 34.05661 , "None"));
Path.Add(new Vector3(-1382.732 , -2862.007 , 34.82781 , "None"));
Path.Add(new Vector3(-1386.345 , -2856.015 , 35.35519 , "None"));
Path.Add(new Vector3(-1390.181 , -2850.159 , 35.95758 , "None"));
Path.Add(new Vector3(-1394.017 , -2844.304 , 36.78801 , "None"));
Path.Add(new Vector3(-1397.757 , -2838.389 , 37.20454 , "None"));
Path.Add(new Vector3(-1402.352 , -2825.227 , 37.84598 , "None"));
Path.Add(new Vector3(-1403.844 , -2818.388 , 38.02163 , "None"));
Path.Add(new Vector3(-1405.335 , -2811.549 , 38.36405 , "None"));
Path.Add(new Vector3(-1406.827 , -2804.709 , 39.07079 , "None"));
Path.Add(new Vector3(-1408.33 , -2797.873 , 39.6506 , "None"));
Path.Add(new Vector3(-1409.927 , -2791.058 , 40.46935 , "None"));
Path.Add(new Vector3(-1411.725 , -2784.293 , 40.65482 , "None"));
Path.Add(new Vector3(-1417.298 , -2771.465 , 39.89883 , "None"));
Path.Add(new Vector3(-1420.467 , -2765.223 , 38.69176 , "None"));
Path.Add(new Vector3(-1423.661 , -2758.995 , 37.22633 , "None"));
Path.Add(new Vector3(-1426.905 , -2752.792 , 36.48979 , "None"));
Path.Add(new Vector3(-1433.669 , -2740.536 , 36.51399 , "None"));
Path.Add(new Vector3(-1440.602 , -2728.373 , 36.60206 , "None"));
Path.Add(new Vector3(-1444.177 , -2722.355 , 35.92829 , "None"));
Path.Add(new Vector3(-1447.827 , -2716.382 , 35.21247 , "None"));
Path.Add(new Vector3(-1451.477 , -2710.408 , 35.26592 , "None"));
Path.Add(new Vector3(-1455.112 , -2704.426 , 35.76187 , "None"));
Path.Add(new Vector3(-1458.627 , -2698.373 , 36.80884 , "None"));
Path.Add(new Vector3(-1461.848 , -2692.16 , 38.11651 , "None"));
Path.Add(new Vector3(-1464.622 , -2685.735 , 39.73356 , "None"));
Path.Add(new Vector3(-1466.72 , -2679.061 , 40.7585 , "None"));
Path.Add(new Vector3(-1474.964 , -2677.341 , 43.33506 , "None"));
Path.Add(new Vector3(-1480.857 , -2681.495 , 43.34288 , "None"));
Path.Add(new Vector3(-1492.67 , -2688.109 , 42.90252 , "None"));
Path.Add(new Vector3(-1499.591 , -2690.815 , 42.40522 , "None"));
Path.Add(new Vector3(-1513.268 , -2693.659 , 41.22359 , "None"));
Path.Add(new Vector3(-1520.201 , -2694.62 , 40.4938 , "None"));
Path.Add(new Vector3(-1534.159 , -2694.623 , 38.55917 , "None"));
Path.Add(new Vector3(-1541.011 , -2693.224 , 37.31206 , "None"));
Path.Add(new Vector3(-1552.92 , -2687.032 , 36.13868 , "None"));
Path.Add(new Vector3(-1558.109 , -2674.356 , 36.42931 , "None"));
Path.Add(new Vector3(-1558.141 , -2667.364 , 36.88313 , "None"));
Path.Add(new Vector3(-1557.586 , -2659.951 , 37.62524 , "None"));
Path.Add(new Vector3(-1556.558 , -2646.431 , 40.09586 , "None"));
Path.Add(new Vector3(-1556.035 , -2639.451 , 41.66201 , "None"));
Path.Add(new Vector3(-1555.756 , -2632.458 , 42.88876 , "None"));
Path.Add(new Vector3(-1555.903 , -2625.46 , 43.99896 , "None"));
Path.Add(new Vector3(-1556.247 , -2618.469 , 45.45079 , "None"));
Path.Add(new Vector3(-1557.157 , -2611.532 , 46.81415 , "None"));
Path.Add(new Vector3(-1558.674 , -2604.702 , 47.7149 , "None"));
Path.Add(new Vector3(-1560.3 , -2597.893 , 48.19654 , "None"));
Path.Add(new Vector3(-1561.925 , -2591.084 , 48.55321 , "None"));
Path.Add(new Vector3(-1563.551 , -2584.276 , 48.7369 , "None"));
Path.Add(new Vector3(-1565.176 , -2577.467 , 49.00044 , "None"));
Path.Add(new Vector3(-1566.608 , -2570.617 , 49.3594 , "None"));
Path.Add(new Vector3(-1567.342 , -2563.658 , 49.74727 , "None"));
Path.Add(new Vector3(-1567.426 , -2556.662 , 50.22723 , "None"));
Path.Add(new Vector3(-1566.81 , -2549.691 , 50.84684 , "None"));
Path.Add(new Vector3(-1562.466 , -2536.436 , 51.70933 , "None"));
Path.Add(new Vector3(-1559.577 , -2530.06 , 52.26573 , "None"));
Path.Add(new Vector3(-1556.047 , -2520.869 , 52.9364 , "None"));
Path.Add(new Vector3(-1557.16 , -2507.419 , 54.48349 , "None"));
Path.Add(new Vector3(-1561.415 , -2501.902 , 55.44958 , "None"));
Path.Add(new Vector3(-1573.959 , -2496.041 , 56.69813 , "None"));
Path.Add(new Vector3(-1580.782 , -2494.478 , 57.69371 , "None"));
Path.Add(new Vector3(-1587.605 , -2492.916 , 58.68787 , "None"));
Path.Add(new Vector3(-1594.429 , -2491.353 , 59.54132 , "None"));
Path.Add(new Vector3(-1601.252 , -2489.791 , 60.25507 , "None"));
Path.Add(new Vector3(-1608.076 , -2488.228 , 60.75821 , "None"));
Path.Add(new Vector3(-1614.864 , -2486.57 , 62.04049 , "None"));
Path.Add(new Vector3(-1621.486 , -2484.314 , 62.69116 , "None"));
Path.Add(new Vector3(-1627.888 , -2481.483 , 63.09669 , "None"));
Path.Add(new Vector3(-1634.287 , -2478.644 , 63.45752 , "None"));
Path.Add(new Vector3(-1640.685 , -2475.806 , 63.498 , "None"));
Path.Add(new Vector3(-1653.352 , -2469.844 , 63.52427 , "None"));
Path.Add(new Vector3(-1659.67 , -2466.831 , 63.54288 , "None"));
Path.Add(new Vector3(-1672.306 , -2460.804 , 63.32257 , "None"));
Path.Add(new Vector3(-1678.625 , -2457.791 , 63.30448 , "None"));
Path.Add(new Vector3(-1691.261 , -2451.764 , 63.30448 , "None"));
Path.Add(new Vector3(-1697.579 , -2448.75 , 63.30448 , "None"));
Path.Add(new Vector3(-1710.216 , -2442.724 , 63.56349 , "None"));
Path.Add(new Vector3(-1716.534 , -2439.711 , 63.28949 , "None"));
Path.Add(new Vector3(-1722.852 , -2436.697 , 62.85564 , "None"));
Path.Add(new Vector3(-1729.17 , -2433.684 , 62.21512 , "None"));
Path.Add(new Vector3(-1735.494 , -2430.682 , 61.73464 , "None"));
Path.Add(new Vector3(-1742.047 , -2428.226 , 61.27211 , "None"));
Path.Add(new Vector3(-1748.659 , -2425.926 , 60.96414 , "None"));
Path.Add(new Vector3(-1755.303 , -2423.723 , 60.59243 , "None"));
Path.Add(new Vector3(-1761.957 , -2421.551 , 59.86161 , "None"));
Path.Add(new Vector3(-1768.612 , -2419.379 , 58.78611 , "None"));
Path.Add(new Vector3(-1775.266 , -2417.208 , 58.26575 , "None"));
Path.Add(new Vector3(-1781.921 , -2415.036 , 57.91067 , "None"));
Path.Add(new Vector3(-1788.576 , -2412.865 , 57.31013 , "None"));
Path.Add(new Vector3(-1795.23 , -2410.693 , 56.50686 , "None"));
Path.Add(new Vector3(-1801.885 , -2408.522 , 55.85891 , "None"));
Path.Add(new Vector3(-1808.562 , -2406.421 , 55.67831 , "None"));
Path.Add(new Vector3(-1822.328 , -2404.061 , 55.89621 , "None"));
Path.Add(new Vector3(-1829.317 , -2404.266 , 56.44304 , "None"));
Path.Add(new Vector3(-1836.251 , -2405.216 , 57.09729 , "None"));
Path.Add(new Vector3(-1843.11 , -2406.61 , 57.60425 , "None"));
Path.Add(new Vector3(-1850.084 , -2408.435 , 58.19534 , "None"));
Path.Add(new Vector3(-1856.665 , -2410.815 , 58.81098 , "None"));
Path.Add(new Vector3(-1863.152 , -2413.443 , 59.28101 , "None"));
Path.Add(new Vector3(-1869.537 , -2416.312 , 59.85308 , "None"));
Path.Add(new Vector3(-1881.819 , -2422.073 , 60.95909 , "None"));
Path.Add(new Vector3(-1888.458 , -2425.417 , 61.52693 , "None"));
Path.Add(new Vector3(-1894.651 , -2428.68 , 62.32223 , "None"));
Path.Add(new Vector3(-1906.648 , -2435.012 , 64.1779 , "None"));
Path.Add(new Vector3(-1913.222 , -2438.483 , 65.43159 , "None"));
Path.Add(new Vector3(-1925.219 , -2444.815 , 67.99377 , "None"));
Path.Add(new Vector3(-1931.407 , -2448.082 , 69.42335 , "None"));
Path.Add(new Vector3(-1937.598 , -2451.349 , 70.82336 , "None"));
Path.Add(new Vector3(-1944.251 , -2454.66 , 72.52524 , "None"));
Path.Add(new Vector3(-1956.863 , -2459.65 , 75.77437 , "None"));
Path.Add(new Vector3(-1963.48 , -2461.932 , 76.77869 , "None"));
Path.Add(new Vector3(-1970.162 , -2464.018 , 77.55637 , "None"));
Path.Add(new Vector3(-1976.909 , -2465.882 , 78.02876 , "None"));
Path.Add(new Vector3(-1983.69 , -2467.619 , 78.34392 , "None"));
Path.Add(new Vector3(-1990.559 , -2468.942 , 78.6147 , "None"));
Path.Add(new Vector3(-1997.524 , -2469.633 , 78.87845 , "None"));
Path.Add(new Vector3(-2004.515 , -2469.954 , 79.02722 , "None"));
Path.Add(new Vector3(-2018.438 , -2468.667 , 78.2714 , "None"));
Path.Add(new Vector3(-2025.284 , -2467.213 , 77.794 , "None"));
Path.Add(new Vector3(-2032.073 , -2465.508 , 77.32345 , "None"));
Path.Add(new Vector3(-2038.853 , -2463.763 , 76.9681 , "None"));
Path.Add(new Vector3(-2045.63 , -2462.014 , 76.40454 , "None"));
Path.Add(new Vector3(-2052.408 , -2460.265 , 75.9385 , "None"));
Path.Add(new Vector3(-2059.186 , -2458.515 , 75.44844 , "None"));
Path.Add(new Vector3(-2066.385 , -2456.659 , 74.95243 , "None"));
Path.Add(new Vector3(-2079.674 , -2453.969 , 73.94748 , "None"));
Path.Add(new Vector3(-2086.6 , -2452.947 , 74.05953 , "None"));
Path.Add(new Vector3(-2093.55 , -2452.147 , 75.83368 , "None"));
Path.Add(new Vector3(-2100.547 , -2451.94 , 79.99439 , "None"));
Path.Add(new Vector3(-2107.546 , -2451.821 , 81.47214 , "None"));
Path.Add(new Vector3(-2114.769 , -2451.699 , 81.28078 , "None"));
Path.Add(new Vector3(-2121.544 , -2451.584 , 79.37576 , "None"));
Path.Add(new Vector3(-2128.543 , -2451.465 , 78.022 , "None"));
Path.Add(new Vector3(-2135.542 , -2451.346 , 78.6282 , "None"));
Path.Add(new Vector3(-2142.541 , -2451.227 , 79.3489 , "None"));
Path.Add(new Vector3(-2149.541 , -2451.134 , 80.06481 , "None"));
Path.Add(new Vector3(-2156.541 , -2451.107 , 80.67818 , "None"));
Path.Add(new Vector3(-2163.54 , -2451.149 , 80.98609 , "None"));
Path.Add(new Vector3(-2170.54 , -2451.223 , 81.03721 , "None"));
Path.Add(new Vector3(-2177.54 , -2451.297 , 81.08344 , "None"));
Path.Add(new Vector3(-2191.539 , -2451.444 , 81.12867 , "None"));
Path.Add(new Vector3(-2198.755 , -2451.52 , 81.20097 , "None"));
Path.Add(new Vector3(-2205.754 , -2451.593 , 81.27708 , "None"));
Path.Add(new Vector3(-2219.752 , -2451.74 , 81.35869 , "None"));
Path.Add(new Vector3(-2233.229 , -2454.545 , 81.44727 , "None"));
Path.Add(new Vector3(-2241.228 , -2465.789 , 80.97246 , "None"));
Path.Add(new Vector3(-2244.226 , -2472.115 , 80.59452 , "None"));
Path.Add(new Vector3(-2247.214 , -2478.445 , 80.33839 , "None"));
Path.Add(new Vector3(-2250.203 , -2484.775 , 80.27402 , "None"));
Path.Add(new Vector3(-2259.074 , -2495.425 , 79.95345 , "None"));
Path.Add(new Vector3(-2264.651 , -2499.651 , 79.54922 , "None"));
Path.Add(new Vector3(-2270.663 , -2503.227 , 78.95648 , "None"));
Path.Add(new Vector3(-2277.244 , -2505.577 , 78.50729 , "None"));
Path.Add(new Vector3(-2290.964 , -2508.33 , 78.50729 , "None"));
Path.Add(new Vector3(-2304.856 , -2509.841 , 79.16288 , "None"));
Path.Add(new Vector3(-2311.856 , -2509.738 , 80.50413 , "None"));
Path.Add(new Vector3(-2318.838 , -2509.252 , 81.84218 , "None"));
Path.Add(new Vector3(-2325.789 , -2508.432 , 83.17432 , "None"));
Path.Add(new Vector3(-2332.72 , -2507.451 , 84.50271 , "None"));
Path.Add(new Vector3(-2339.65 , -2506.464 , 85.83226 , "None"));
Path.Add(new Vector3(-2346.589 , -2505.544 , 87.16222 , "None"));
Path.Add(new Vector3(-2353.557 , -2504.885 , 88.34418 , "None"));
Path.Add(new Vector3(-2367.548 , -2505.033 , 88.34418 , "None"));
Path.Add(new Vector3(-2381.417 , -2506.874 , 88.34418 , "None"));
Path.Add(new Vector3(-2395.243 , -2509.03 , 87.36542 , "None"));
Path.Add(new Vector3(-2402.231 , -2509.42 , 86.02628 , "None"));
Path.Add(new Vector3(-2409.231 , -2509.408 , 84.68466 , "None"));
Path.Add(new Vector3(-2416.226 , -2509.147 , 83.34438 , "None"));
Path.Add(new Vector3(-2423.223 , -2508.957 , 82.00363 , "None"));
Path.Add(new Vector3(-2430.223 , -2508.974 , 80.66228 , "None"));
Path.Add(new Vector3(-2437.22 , -2508.803 , 79.32104 , "None"));
Path.Add(new Vector3(-2444.205 , -2508.338 , 78.50723 , "None"));
Path.Add(new Vector3(-2457.994 , -2506.023 , 78.50723 , "None"));
Path.Add(new Vector3(-2471.035 , -2501.054 , 78.50723 , "None"));
Path.Add(new Vector3(-2477.178 , -2497.698 , 78.45605 , "None"));
Path.Add(new Vector3(-2483.322 , -2494.344 , 78.81235 , "None"));
Path.Add(new Vector3(-2489.739 , -2491.058 , 79.23773 , "None"));
Path.Add(new Vector3(-2502.709 , -2485.872 , 80.25728 , "None"));
Path.Add(new Vector3(-2516.408 , -2483.08 , 81.42005 , "None"));
Path.Add(new Vector3(-2529.966 , -2483.084 , 81.4442 , "None"));
Path.Add(new Vector3(-2537.389 , -2483.481 , 81.42165 , "None"));
Path.Add(new Vector3(-2550.844 , -2485.112 , 81.43071 , "None"));
Path.Add(new Vector3(-2558.125 , -2486.608 , 81.43002 , "None"));
Path.Add(new Vector3(-2571.416 , -2489.327 , 81.31487 , "None"));
Path.Add(new Vector3(-2578.804 , -2490.068 , 80.88449 , "None"));
Path.Add(new Vector3(-2585.795 , -2489.76 , 80.38377 , "None"));
Path.Add(new Vector3(-2599.314 , -2488.64 , 79.67736 , "None"));
Path.Add(new Vector3(-2606.29 , -2488.054 , 79.54573 , "None"));
Path.Add(new Vector3(-2613.265 , -2487.469 , 79.46046 , "None"));
Path.Add(new Vector3(-2620.242 , -2486.894 , 79.3637 , "None"));
Path.Add(new Vector3(-2634.239 , -2486.669 , 79.33643 , "None"));
Path.Add(new Vector3(-2641.238 , -2486.605 , 79.31601 , "None"));
Path.Add(new Vector3(-2648.238 , -2486.541 , 79.15563 , "None"));
Path.Add(new Vector3(-2655.238 , -2486.477 , 78.71307 , "None"));
Path.Add(new Vector3(-2662.236 , -2486.572 , 78.1882 , "None"));
Path.Add(new Vector3(-2669.232 , -2486.811 , 77.30154 , "None"));
Path.Add(new Vector3(-2676.228 , -2487.049 , 76.72812 , "None"));
Path.Add(new Vector3(-2683.222 , -2487.33 , 76.12915 , "None"));
Path.Add(new Vector3(-2690.152 , -2488.283 , 74.64025 , "None"));
Path.Add(new Vector3(-2696.969 , -2489.863 , 72.80933 , "None"));
Path.Add(new Vector3(-2703.675 , -2491.872 , 71.13564 , "None"));
Path.Add(new Vector3(-2710.376 , -2493.896 , 69.83389 , "None"));
Path.Add(new Vector3(-2717.076 , -2495.924 , 68.62174 , "None"));
Path.Add(new Vector3(-2723.75 , -2498.035 , 67.36807 , "None"));
Path.Add(new Vector3(-2730.452 , -2500.055 , 66.45019 , "None"));
Path.Add(new Vector3(-2737.264 , -2501.657 , 65.55228 , "None"));
Path.Add(new Vector3(-2744.156 , -2502.883 , 64.60304 , "None"));
Path.Add(new Vector3(-2751.078 , -2503.919 , 63.47506 , "None"));
Path.Add(new Vector3(-2758.028 , -2504.747 , 62.59004 , "None"));
Path.Add(new Vector3(-2765.007 , -2505.293 , 62.00834 , "None"));
Path.Add(new Vector3(-2771.996 , -2505.681 , 61.27565 , "None"));
Path.Add(new Vector3(-2778.986 , -2506.049 , 60.82156 , "None"));
Path.Add(new Vector3(-2785.983 , -2506.25 , 60.26381 , "None"));
Path.Add(new Vector3(-2792.979 , -2506.094 , 59.46681 , "None"));
Path.Add(new Vector3(-2799.844 , -2504.788 , 58.78769 , "None"));
Path.Add(new Vector3(-2806.357 , -2502.241 , 57.96099 , "None"));
Path.Add(new Vector3(-2812.535 , -2498.956 , 56.8441 , "None"));
Path.Add(new Vector3(-2818.434 , -2495.192 , 55.66579 , "None"));
Path.Add(new Vector3(-2823.923 , -2490.855 , 54.6486 , "None"));
Path.Add(new Vector3(-2829.049 , -2485.771 , 53.3766 , "None"));
Path.Add(new Vector3(-2835.048 , -2473.55 , 50.60778 , "None"));
Path.Add(new Vector3(-2836.966 , -2466.818 , 49.80373 , "None"));
Path.Add(new Vector3(-2838.884 , -2460.086 , 49.69218 , "None"));
Path.Add(new Vector3(-2840.864 , -2453.138 , 51.38525 , "None"));
Path.Add(new Vector3(-2842.799 , -2446.411 , 51.92913 , "None"));
Path.Add(new Vector3(-2845.163 , -2439.824 , 52.34034 , "None"));
Path.Add(new Vector3(-2847.864 , -2433.367 , 51.87702 , "None"));
Path.Add(new Vector3(-2850.611 , -2426.928 , 50.97498 , "None"));
Path.Add(new Vector3(-2851.461 , -2416.763 , 50.86966 , "None"));
Path.Add(new Vector3(-2860.245 , -2410.67 , 47.76084 , "None"));
Path.Add(new Vector3(-2866.48 , -2407.487 , 45.25879 , "None"));
Path.Add(new Vector3(-2872.708 , -2404.292 , 42.65171 , "None"));
Path.Add(new Vector3(-2877.349 , -2399.173 , 40.64822 , "None"));
Path.Add(new Vector3(-2879.298 , -2392.496 , 39.35937 , "None"));
Path.Add(new Vector3(-2879.495 , -2385.506 , 38.69389 , "None"));
Path.Add(new Vector3(-2879.105 , -2378.517 , 37.77911 , "None"));
Path.Add(new Vector3(-2878.62 , -2371.534 , 37.44387 , "None"));
Path.Add(new Vector3(-2877.215 , -2364.698 , 36.52866 , "None"));
Path.Add(new Vector3(-2874.973 , -2358.067 , 36.23672 , "None"));
Path.Add(new Vector3(-2872.723 , -2351.438 , 36.45878 , "None"));
Path.Add(new Vector3(-2868.26 , -2338.169 , 35.74322 , "None"));
Path.Add(new Vector3(-2866.037 , -2331.531 , 35.26722 , "None"));
Path.Add(new Vector3(-2863.813 , -2324.894 , 35.24882 , "None"));
Path.Add(new Vector3(-2861.589 , -2318.257 , 35.58533 , "None"));
Path.Add(new Vector3(-2859.374 , -2311.616 , 36.80244 , "None"));
Path.Add(new Vector3(-2857.268 , -2304.941 , 38.14814 , "None"));
Path.Add(new Vector3(-2855.441 , -2298.186 , 38.77046 , "None"));
Path.Add(new Vector3(-2854.107 , -2284.287 , 36.97058 , "None"));
Path.Add(new Vector3(-2854.477 , -2277.305 , 35.46458 , "None"));
Path.Add(new Vector3(-2855.921 , -2270.462 , 34.7322 , "None"));
Path.Add(new Vector3(-2858.373 , -2263.907 , 34.2703 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

        








public override bool HasQuest() { return true; }


}


public sealed class MenethilFPToBridge : QuestFollowPathClass
{
    public MenethilFPToBridge()
    {
        Name = "MenethilFPToBridge";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-3788.251 , -790.8489 , 9.415371 , "None"));
Path.Add(new Vector3(-3784.259 , -798.3981 , 8.702815 , "None"));
Path.Add(new Vector3(-3780.975 , -804.5798 , 8.688527 , "None"));
Path.Add(new Vector3(-3777.395 , -810.5939 , 9.753436 , "None"));
Path.Add(new Vector3(-3773.271 , -816.244 , 11.43316 , "None"));
Path.Add(new Vector3(-3768.528 , -821.3821 , 12.15846 , "None"));
Path.Add(new Vector3(-3763.185 , -825.9017 , 11.98395 , "None"));
Path.Add(new Vector3(-3757.537 , -830.0335 , 11.05032 , "None"));
Path.Add(new Vector3(-3751.495 , -833.5621 , 10.14937 , "None"));
Path.Add(new Vector3(-3745.118 , -836.4454 , 10.68095 , "None"));
Path.Add(new Vector3(-3738.582 , -838.9501 , 11.6882 , "None"));
Path.Add(new Vector3(-3732.035 , -841.4276 , 11.68562 , "None"));
Path.Add(new Vector3(-3725.536 , -844.023 , 12.00259 , "None"));
Path.Add(new Vector3(-3719.24 , -847.0816 , 10.84661 , "None"));
Path.Add(new Vector3(-3712.974 , -850.2029 , 10.48669 , "None"));
Path.Add(new Vector3(-3706.281 , -852.1141 , 10.74629 , "None"));
Path.Add(new Vector3(-3699.3 , -851.8999 , 10.25869 , "None"));
Path.Add(new Vector3(-3692.584 , -849.996 , 10.01375 , "None"));
Path.Add(new Vector3(-3686.309 , -846.9028 , 10.13295 , "None"));
Path.Add(new Vector3(-3680.562 , -842.9114 , 10.07307 , "None"));
Path.Add(new Vector3(-3674.667 , -839.1524 , 9.902261 , "None"));
Path.Add(new Vector3(-3667.942 , -837.4294 , 9.899677 , "None"));
Path.Add(new Vector3(-3661.001 , -838.1056 , 9.899677 , "None"));
Path.Add(new Vector3(-3654.452 , -840.5608 , 9.874403 , "None"));
Path.Add(new Vector3(-3648.205 , -843.718 , 9.410329 , "None"));
Path.Add(new Vector3(-3641.963 , -846.8867 , 8.885152 , "None"));
Path.Add(new Vector3(-3635.727 , -850.0529 , 9.608871 , "None"));
Path.Add(new Vector3(-3629.485 , -853.2216 , 10.70258 , "None"));
Path.Add(new Vector3(-3623.243 , -856.3903 , 11.51309 , "None"));
Path.Add(new Vector3(-3617.001 , -859.5589 , 12.08179 , "None"));
Path.Add(new Vector3(-3610.753 , -862.7153 , 12.58208 , "None"));
Path.Add(new Vector3(-3604.489 , -865.8383 , 12.81552 , "None"));
Path.Add(new Vector3(-3598.153 , -868.8157 , 12.96615 , "None"));
Path.Add(new Vector3(-3591.817 , -871.7919 , 12.98456 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

        








public override bool HasQuest() { return true; }


}


public sealed class PathIronbeardToHammelfall : QuestFollowPathClass
{
    public PathIronbeardToHammelfall()
    {
        Name = "PathIronbeardToHammelfall";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-2855.401 , -2263.675 , 34.87457 , "None"));
Path.Add(new Vector3(-2854.897 , -2268.464 , 35.07525 , "None"));
Path.Add(new Vector3(-2853.561 , -2282.399 , 36.65162 , "None"));
Path.Add(new Vector3(-2854.729 , -2296.333 , 38.86949 , "None"));
Path.Add(new Vector3(-2856.557 , -2310.208 , 37.64487 , "None"));
Path.Add(new Vector3(-2859.521 , -2323.889 , 36.19606 , "None"));
Path.Add(new Vector3(-2862.999 , -2337.438 , 36.38045 , "None"));
Path.Add(new Vector3(-2868.06 , -2350.491 , 37.51826 , "None"));
Path.Add(new Vector3(-2873.158 , -2363.53 , 37.08799 , "None"));
Path.Add(new Vector3(-2877.102 , -2376.945 , 38.05983 , "None"));
Path.Add(new Vector3(-2877.67 , -2390.838 , 39.3729 , "None"));
Path.Add(new Vector3(-2872.301 , -2403.574 , 42.64401 , "None"));
Path.Add(new Vector3(-2861.617 , -2412.612 , 47.1735 , "None"));
Path.Add(new Vector3(-2850.753 , -2421.442 , 51.0039 , "None"));
Path.Add(new Vector3(-2840.041 , -2430.452 , 54.85825 , "None"));
Path.Add(new Vector3(-2830.043 , -2440.809 , 58.41766 , "None"));
Path.Add(new Vector3(-2821.68 , -2451.507 , 58.58305 , "None"));
Path.Add(new Vector3(-2812.969 , -2462.999 , 62.01885 , "None"));
Path.Add(new Vector3(-2804.921 , -2473.937 , 62.50267 , "None"));
Path.Add(new Vector3(-2797.234 , -2484.549 , 63.01999 , "None"));
Path.Add(new Vector3(-2787.543 , -2496.367 , 61.45069 , "None"));
Path.Add(new Vector3(-2776.277 , -2502.997 , 60.99099 , "None"));
Path.Add(new Vector3(-2762.934 , -2504.219 , 62.2192 , "None"));
Path.Add(new Vector3(-2748.984 , -2503.03 , 63.8306 , "None"));
Path.Add(new Vector3(-2735.054 , -2501.664 , 65.81364 , "None"));
Path.Add(new Vector3(-2721.384 , -2498.673 , 67.77536 , "None"));
Path.Add(new Vector3(-2707.178 , -2492.989 , 70.39848 , "None"));
Path.Add(new Vector3(-2694.334 , -2487.433 , 73.4648 , "None"));
Path.Add(new Vector3(-2681.356 , -2486.04 , 76.26852 , "None"));
Path.Add(new Vector3(-2666.499 , -2486.523 , 77.67825 , "None"));
Path.Add(new Vector3(-2653.382 , -2487.138 , 78.74999 , "None"));
Path.Add(new Vector3(-2639.382 , -2487.212 , 79.29302 , "None"));
Path.Add(new Vector3(-2625.383 , -2487.286 , 79.33181 , "None"));
Path.Add(new Vector3(-2611.529 , -2489.151 , 79.71046 , "None"));
Path.Add(new Vector3(-2597.75 , -2491.631 , 79.92899 , "None"));
Path.Add(new Vector3(-2582.936 , -2492.225 , 80.44638 , "None"));
Path.Add(new Vector3(-2569.97 , -2490.218 , 81.34111 , "None"));
Path.Add(new Vector3(-2556.265 , -2487.359 , 81.42156 , "None"));
Path.Add(new Vector3(-2542.566 , -2484.472 , 81.4266 , "None"));
Path.Add(new Vector3(-2528.669 , -2482.931 , 81.44847 , "None"));
Path.Add(new Vector3(-2514.682 , -2483.224 , 81.3396 , "None"));
Path.Add(new Vector3(-2501.137 , -2486.686 , 80.12881 , "None"));
Path.Add(new Vector3(-2488.051 , -2491.658 , 79.10694 , "None"));
Path.Add(new Vector3(-2475.6 , -2498.043 , 78.49107 , "None"));
Path.Add(new Vector3(-2463.28 , -2504.281 , 78.50713 , "None"));
Path.Add(new Vector3(-2450.074 , -2508.841 , 78.50713 , "None"));
Path.Add(new Vector3(-2436.311 , -2511.396 , 79.49493 , "None"));
Path.Add(new Vector3(-2422.356 , -2512.446 , 82.16921 , "None"));
Path.Add(new Vector3(-2408.367 , -2512.548 , 84.85005 , "None"));
Path.Add(new Vector3(-2394.446 , -2511.083 , 87.51786 , "None"));
Path.Add(new Vector3(-2380.71 , -2508.406 , 88.34425 , "None"));
Path.Add(new Vector3(-2367.009 , -2505.532 , 88.34425 , "None"));
Path.Add(new Vector3(-2353.168 , -2503.451 , 88.34425 , "None"));
Path.Add(new Vector3(-2339.245 , -2501.989 , 85.75365 , "None"));
Path.Add(new Vector3(-2325.322 , -2500.527 , 83.08492 , "None"));
Path.Add(new Vector3(-2311.342 , -2499.907 , 80.40591 , "None"));
Path.Add(new Vector3(-2297.344 , -2500.081 , 78.50725 , "None"));
Path.Add(new Vector3(-2283.345 , -2500.266 , 78.50725 , "None"));
Path.Add(new Vector3(-2269.635 , -2498.01 , 79.04325 , "None"));
Path.Add(new Vector3(-2257.994 , -2490.449 , 80.12817 , "None"));
Path.Add(new Vector3(-2250.109 , -2478.972 , 80.33366 , "None"));
Path.Add(new Vector3(-2243.519 , -2466.625 , 80.79937 , "None"));
Path.Add(new Vector3(-2234.084 , -2456.425 , 81.47249 , "None"));
Path.Add(new Vector3(-2221.017 , -2451.579 , 81.34121 , "None"));
Path.Add(new Vector3(-2207.082 , -2450.558 , 81.2659 , "None"));
Path.Add(new Vector3(-2193.082 , -2450.522 , 81.13235 , "None"));
Path.Add(new Vector3(-2179.082 , -2450.487 , 81.09573 , "None"));
Path.Add(new Vector3(-2165.082 , -2450.451 , 81.00043 , "None"));
Path.Add(new Vector3(-2151.082 , -2450.422 , 80.21716 , "None"));
Path.Add(new Vector3(-2137.083 , -2450.558 , 78.86587 , "None"));
Path.Add(new Vector3(-2123.089 , -2450.944 , 78.74653 , "None"));
Path.Add(new Vector3(-2109.094 , -2451.348 , 81.58095 , "None"));
Path.Add(new Vector3(-2094.659 , -2451.931 , 76.65452 , "None"));
Path.Add(new Vector3(-2080.743 , -2453.429 , 73.96037 , "None"));
Path.Add(new Vector3(-2067.01 , -2456.137 , 74.98412 , "None"));
Path.Add(new Vector3(-2053.321 , -2459.072 , 75.84311 , "None"));
Path.Add(new Vector3(-2039.71 , -2462.349 , 76.83633 , "None"));
Path.Add(new Vector3(-2026.052 , -2465.413 , 77.67106 , "None"));
Path.Add(new Vector3(-2012.134 , -2466.805 , 78.81941 , "None"));
Path.Add(new Vector3(-1998.152 , -2466.393 , 78.90131 , "None"));
Path.Add(new Vector3(-1984.233 , -2464.894 , 78.40784 , "None"));
Path.Add(new Vector3(-1970.542 , -2462.005 , 77.54775 , "None"));
Path.Add(new Vector3(-1957.119 , -2458.043 , 75.73643 , "None"));
Path.Add(new Vector3(-1944.076 , -2452.966 , 72.3891 , "None"));
Path.Add(new Vector3(-1931.374 , -2447.08 , 69.41946 , "None"));
Path.Add(new Vector3(-1918.722 , -2441.087 , 66.59554 , "None"));
Path.Add(new Vector3(-1906.053 , -2435.128 , 64.04774 , "None"));
Path.Add(new Vector3(-1893.377 , -2429.184 , 62.04826 , "None"));
Path.Add(new Vector3(-1880.701 , -2423.241 , 60.83442 , "None"));
Path.Add(new Vector3(-1868.026 , -2417.298 , 59.80396 , "None"));
Path.Add(new Vector3(-1855.273 , -2411.525 , 58.89204 , "None"));
Path.Add(new Vector3(-1841.83 , -2407.779 , 57.57938 , "None"));
Path.Add(new Vector3(-1827.931 , -2406.152 , 56.34152 , "None"));
Path.Add(new Vector3(-1813.963 , -2406.796 , 55.65169 , "None"));
Path.Add(new Vector3(-1800.301 , -2409.748 , 55.98399 , "None"));
Path.Add(new Vector3(-1787.035 , -2414.22 , 57.43256 , "None"));
Path.Add(new Vector3(-1773.612 , -2418.173 , 58.36569 , "None"));
Path.Add(new Vector3(-1760.043 , -2421.62 , 60.12625 , "None"));
Path.Add(new Vector3(-1746.656 , -2425.693 , 60.98417 , "None"));
Path.Add(new Vector3(-1733.703 , -2430.958 , 61.82975 , "None"));
Path.Add(new Vector3(-1720.84 , -2436.485 , 62.89708 , "None"));
Path.Add(new Vector3(-1708.148 , -2442.392 , 63.49047 , "None"));
Path.Add(new Vector3(-1695.512 , -2448.42 , 63.3046 , "None"));
Path.Add(new Vector3(-1683.004 , -2454.705 , 63.3046 , "None"));
Path.Add(new Vector3(-1670.717 , -2461.415 , 63.37139 , "None"));
Path.Add(new Vector3(-1658.443 , -2468.148 , 63.56493 , "None"));
Path.Add(new Vector3(-1646.001 , -2474.567 , 63.48526 , "None"));
Path.Add(new Vector3(-1633.266 , -2480.37 , 63.47407 , "None"));
Path.Add(new Vector3(-1620.041 , -2484.952 , 62.59398 , "None"));
Path.Add(new Vector3(-1606.694 , -2489.178 , 60.59793 , "None"));
Path.Add(new Vector3(-1593.768 , -2494.437 , 59.25628 , "None"));
Path.Add(new Vector3(-1582.5 , -2502.691 , 57.54273 , "None"));
Path.Add(new Vector3(-1574.559 , -2514.092 , 57.44458 , "None"));
Path.Add(new Vector3(-1569.369 , -2527.072 , 52.85103 , "None"));
Path.Add(new Vector3(-1567.969 , -2541.389 , 51.02942 , "None"));
Path.Add(new Vector3(-1567.551 , -2554.962 , 50.31462 , "None"));
Path.Add(new Vector3(-1566.902 , -2569.367 , 49.41599 , "None"));
Path.Add(new Vector3(-1566.088 , -2582.922 , 48.76375 , "None"));
Path.Add(new Vector3(-1564.821 , -2596.864 , 48.10403 , "None"));
Path.Add(new Vector3(-1563.371 , -2611.211 , 46.5052 , "None"));
Path.Add(new Vector3(-1561.963 , -2625.14 , 43.88258 , "None"));
Path.Add(new Vector3(-1560.718 , -2637.763 , 41.78916 , "None"));
Path.Add(new Vector3(-1559.563 , -2653.035 , 39.01556 , "None"));
Path.Add(new Vector3(-1559.282 , -2667.028 , 36.84658 , "None"));
Path.Add(new Vector3(-1559.399 , -2671.423 , 36.46245 , "None"));
Path.Add(new Vector3(-1559.579 , -2676.235 , 36.24718 , "None"));
Path.Add(new Vector3(-1557.518 , -2689.976 , 35.44842 , "None"));
Path.Add(new Vector3(-1550.961 , -2702.303 , 35.65171 , "None"));
Path.Add(new Vector3(-1540.863 , -2711.94 , 36.10618 , "None"));
Path.Add(new Vector3(-1528.61 , -2718.595 , 34.70767 , "None"));
Path.Add(new Vector3(-1514.606 , -2723.571 , 33.68498 , "None"));
Path.Add(new Vector3(-1501.909 , -2726.916 , 32.43534 , "None"));
Path.Add(new Vector3(-1488.263 , -2730.039 , 31.49434 , "None"));
Path.Add(new Vector3(-1474.536 , -2732.789 , 32.42559 , "None"));
Path.Add(new Vector3(-1460.714 , -2734.979 , 35.42368 , "None"));
Path.Add(new Vector3(-1447.546 , -2739.217 , 38.15229 , "None"));
Path.Add(new Vector3(-1436.341 , -2747.572 , 37.49507 , "None"));
Path.Add(new Vector3(-1426.575 , -2757.593 , 36.92249 , "None"));
Path.Add(new Vector3(-1418.12 , -2768.737 , 39.36481 , "None"));
Path.Add(new Vector3(-1412.427 , -2781.5 , 40.70002 , "None"));
Path.Add(new Vector3(-1407.975 , -2794.77 , 39.86302 , "None"));
Path.Add(new Vector3(-1404.507 , -2808.333 , 38.62683 , "None"));
Path.Add(new Vector3(-1401.291 , -2821.958 , 38.05979 , "None"));
Path.Add(new Vector3(-1397.687 , -2836.38 , 37.38858 , "None"));
Path.Add(new Vector3(-1392.75 , -2849.461 , 36.06817 , "None"));
Path.Add(new Vector3(-1386.056 , -2861.754 , 35.44378 , "None"));
Path.Add(new Vector3(-1378.629 , -2873.62 , 33.59492 , "None"));
Path.Add(new Vector3(-1370.956 , -2885.33 , 32.21708 , "None"));
Path.Add(new Vector3(-1362.679 , -2896.613 , 33.81195 , "None"));
Path.Add(new Vector3(-1353.046 , -2906.752 , 39.74166 , "None"));
Path.Add(new Vector3(-1348.165 , -2911.123 , 41.65464 , "None"));
Path.Add(new Vector3(-1344.305 , -2914.659 , 42.64074 , "None"));
Path.Add(new Vector3(-1335.032 , -2925.137 , 40.41282 , "None"));
Path.Add(new Vector3(-1326.165 , -2935.972 , 38.93404 , "None"));
Path.Add(new Vector3(-1317.299 , -2946.806 , 38.28139 , "None"));
Path.Add(new Vector3(-1308.777 , -2957.907 , 37.45211 , "None"));
Path.Add(new Vector3(-1300.963 , -2969.523 , 38.85049 , "None"));
Path.Add(new Vector3(-1293.759 , -2981.521 , 38.96351 , "None"));
Path.Add(new Vector3(-1288.364 , -2994.422 , 37.92369 , "None"));
Path.Add(new Vector3(-1284.508 , -3007.86 , 37.34895 , "None"));
Path.Add(new Vector3(-1281.717 , -3022.034 , 37.02897 , "None"));
Path.Add(new Vector3(-1279.586 , -3035.869 , 36.25681 , "None"));
Path.Add(new Vector3(-1278.372 , -3049.812 , 35.85347 , "None"));
Path.Add(new Vector3(-1279.048 , -3063.761 , 36.1935 , "None"));
Path.Add(new Vector3(-1281.547 , -3077.534 , 34.71751 , "None"));
Path.Add(new Vector3(-1284.189 , -3091.283 , 34.06442 , "None"));
Path.Add(new Vector3(-1287.372 , -3104.916 , 33.63178 , "None"));
Path.Add(new Vector3(-1290.583 , -3118.542 , 34.10199 , "None"));
Path.Add(new Vector3(-1293.176 , -3132.3 , 35.09946 , "None"));
Path.Add(new Vector3(-1295.373 , -3146.119 , 35.66908 , "None"));
Path.Add(new Vector3(-1294.983 , -3160.09 , 36.31346 , "None"));
Path.Add(new Vector3(-1291.75 , -3173.631 , 36.22139 , "None"));
Path.Add(new Vector3(-1285.6 , -3186.198 , 35.77126 , "None"));
Path.Add(new Vector3(-1278.206 , -3198.08 , 34.74136 , "None"));
Path.Add(new Vector3(-1269.94 , -3209.375 , 34.53948 , "None"));
Path.Add(new Vector3(-1260.873 , -3220.039 , 34.64159 , "None"));
Path.Add(new Vector3(-1251.629 , -3230.553 , 34.64472 , "None"));
Path.Add(new Vector3(-1242.385 , -3241.067 , 34.33806 , "None"));
Path.Add(new Vector3(-1233.417 , -3251.808 , 32.90232 , "None"));
Path.Add(new Vector3(-1226.034 , -3263.703 , 30.12804 , "None"));
Path.Add(new Vector3(-1218.353 , -3275.401 , 28.15852 , "None"));
Path.Add(new Vector3(-1208.834 , -3285.657 , 27.92919 , "None"));
Path.Add(new Vector3(-1198.761 , -3295.379 , 28.15401 , "None"));
Path.Add(new Vector3(-1188.88 , -3305.293 , 29.30552 , "None"));
Path.Add(new Vector3(-1180.275 , -3316.319 , 28.48885 , "None"));
Path.Add(new Vector3(-1173.97 , -3328.8 , 27.57651 , "None"));
Path.Add(new Vector3(-1169.229 , -3341.967 , 26.9254 , "None"));
Path.Add(new Vector3(-1165.535 , -3355.469 , 26.43707 , "None"));
Path.Add(new Vector3(-1162.653 , -3369.168 , 26.21639 , "None"));
Path.Add(new Vector3(-1160.463 , -3382.97 , 26.33911 , "None"));
Path.Add(new Vector3(-1158.884 , -3396.879 , 27.30482 , "None"));
Path.Add(new Vector3(-1158.846 , -3410.865 , 29.3023 , "None"));
Path.Add(new Vector3(-1160.932 , -3424.696 , 30.68677 , "None"));
Path.Add(new Vector3(-1164.691 , -3438.178 , 31.52906 , "None"));
Path.Add(new Vector3(-1169.375 , -3451.366 , 32.2639 , "None"));
Path.Add(new Vector3(-1174.485 , -3464.399 , 33.18235 , "None"));
Path.Add(new Vector3(-1177.1 , -3478.082 , 35.4208 , "None"));
Path.Add(new Vector3(-1176.283 , -3492.018 , 36.84254 , "None"));
Path.Add(new Vector3(-1172.751 , -3505.987 , 39.25714 , "None"));
Path.Add(new Vector3(-1167.749 , -3518.605 , 42.82734 , "None"));
Path.Add(new Vector3(-1160.425 , -3530.482 , 46.86177 , "None"));
Path.Add(new Vector3(-1150.076 , -3539.79 , 50.01675 , "None"));
Path.Add(new Vector3(-1137.476 , -3546.761 , 51.21711 , "None"));
Path.Add(new Vector3(-1124.37 , -3551.664 , 49.4263 , "None"));
Path.Add(new Vector3(-1110.78 , -3555.011 , 48.94717 , "None"));
Path.Add(new Vector3(-1096.875 , -3556.48 , 48.82037 , "None"));
Path.Add(new Vector3(-1082.883 , -3556.732 , 50.41263 , "None"));
Path.Add(new Vector3(-1068.894 , -3556.257 , 52.00502 , "None"));
Path.Add(new Vector3(-1055.034 , -3554.338 , 53.69425 , "None"));
Path.Add(new Vector3(-1042.72 , -3551.452 , 55.0181 , "None"));
Path.Add(new Vector3(-1033.553 , -3548.626 , 55.95018 , "None"));
Path.Add(new Vector3(-1021.202 , -3542.058 , 56.48507 , "None"));
Path.Add(new Vector3(-1015.681 , -3538.479 , 56.64457 , "None"));
Path.Add(new Vector3(-1009.479 , -3534.406 , 56.8534 , "None"));
Path.Add(new Vector3(-998.4172 , -3525.829 , 57.63042 , "None"));
Path.Add(new Vector3(-987.5007 , -3517.108 , 57.02176 , "None"));
Path.Add(new Vector3(-977.9993 , -3511.972 , 57.30338 , "None"));
Path.Add(new Vector3(-964.9007 , -3511.737 , 56.72158 , "None"));
Path.Add(new Vector3(-950.9501 , -3512.378 , 57.26593 , "None"));
Path.Add(new Vector3(-938.1314 , -3513.658 , 65.2981 , "None"));
Path.Add(new Vector3(-934.6487 , -3514.006 , 67.47227 , "None"));
Path.Add(new Vector3(-923.7367 , -3514.493 , 70.72923 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

        








public override bool HasQuest() { return true; }


}


public sealed class PathIronbreardsTombToRefugePointe : QuestFollowPathClass
{
    public PathIronbreardsTombToRefugePointe()
    {
        Name = "PathIronbreardsTombToRefugePointe";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-2839.162 , -2280.782 , 41.94557 , "None"));
Path.Add(new Vector3(-2846.058 , -2288.404 , 40.26551 , "None"));
Path.Add(new Vector3(-2849.275 , -2294.594 , 39.34534 , "None"));
Path.Add(new Vector3(-2851.702 , -2301.16 , 39.01473 , "None"));
Path.Add(new Vector3(-2854.128 , -2307.726 , 38.33181 , "None"));
Path.Add(new Vector3(-2856.555 , -2314.292 , 37.18388 , "None"));
Path.Add(new Vector3(-2858.981 , -2320.858 , 36.20234 , "None"));
Path.Add(new Vector3(-2861.408 , -2327.424 , 35.87855 , "None"));
Path.Add(new Vector3(-2863.907 , -2334.187 , 35.88377 , "None"));
Path.Add(new Vector3(-2866.261 , -2340.556 , 36.61083 , "None"));
Path.Add(new Vector3(-2868.687 , -2347.122 , 37.0786 , "None"));
Path.Add(new Vector3(-2871.187 , -2353.885 , 37.10696 , "None"));
Path.Add(new Vector3(-2873.547 , -2360.475 , 36.72013 , "None"));
Path.Add(new Vector3(-2875.463 , -2367.206 , 37.13302 , "None"));
Path.Add(new Vector3(-2876.891 , -2374.058 , 37.90736 , "None"));
Path.Add(new Vector3(-2877.991 , -2380.97 , 38.21585 , "None"));
Path.Add(new Vector3(-2878.56 , -2387.944 , 39.13599 , "None"));
Path.Add(new Vector3(-2877.954 , -2394.885 , 39.61595 , "None"));
Path.Add(new Vector3(-2874.973 , -2401.167 , 41.46658 , "None"));
Path.Add(new Vector3(-2870.408 , -2406.471 , 43.582 , "None"));
Path.Add(new Vector3(-2865.626 , -2411.582 , 45.59875 , "None"));
Path.Add(new Vector3(-2860.699 , -2416.554 , 47.26928 , "None"));
Path.Add(new Vector3(-2855.771 , -2421.526 , 48.97308 , "None"));
Path.Add(new Vector3(-2850.844 , -2426.498 , 50.88313 , "None"));
Path.Add(new Vector3(-2845.914 , -2431.468 , 52.76415 , "None"));
Path.Add(new Vector3(-2840.892 , -2436.344 , 54.55582 , "None"));
Path.Add(new Vector3(-2835.723 , -2441.064 , 56.33986 , "None"));
Path.Add(new Vector3(-2830.502 , -2445.727 , 57.49331 , "None"));
Path.Add(new Vector3(-2825.281 , -2450.39 , 57.60922 , "None"));
Path.Add(new Vector3(-2820.042 , -2455.03 , 58.93294 , "None"));
Path.Add(new Vector3(-2814.784 , -2459.65 , 61.07777 , "None"));
Path.Add(new Vector3(-2809.49 , -2464.23 , 62.84239 , "None"));
Path.Add(new Vector3(-2804.018 , -2468.592 , 63.11226 , "None"));
Path.Add(new Vector3(-2798.265 , -2472.58 , 64.01757 , "None"));
Path.Add(new Vector3(-2792.156 , -2475.988 , 65.17239 , "None"));
Path.Add(new Vector3(-2785.552 , -2478.272 , 66.32575 , "None"));
Path.Add(new Vector3(-2778.71 , -2479.75 , 67.20396 , "None"));
Path.Add(new Vector3(-2771.833 , -2481.052 , 67.93801 , "None"));
Path.Add(new Vector3(-2764.955 , -2482.354 , 68.57946 , "None"));
Path.Add(new Vector3(-2758.077 , -2483.656 , 69.09476 , "None"));
Path.Add(new Vector3(-2751.199 , -2484.959 , 68.80654 , "None"));
Path.Add(new Vector3(-2744.324 , -2486.274 , 68.6265 , "None"));
Path.Add(new Vector3(-2737.534 , -2487.967 , 69.94592 , "None"));
Path.Add(new Vector3(-2730.782 , -2489.817 , 69.51484 , "None"));
Path.Add(new Vector3(-2724.031 , -2491.668 , 68.61542 , "None"));
Path.Add(new Vector3(-2717.278 , -2493.509 , 68.68344 , "None"));
Path.Add(new Vector3(-2710.382 , -2494.641 , 69.8057 , "None"));
Path.Add(new Vector3(-2703.474 , -2493.595 , 71.08551 , "None"));
Path.Add(new Vector3(-2696.665 , -2491.973 , 72.88699 , "None"));
Path.Add(new Vector3(-2689.814 , -2490.54 , 75.06573 , "None"));
Path.Add(new Vector3(-2682.854 , -2489.838 , 76.83564 , "None"));
Path.Add(new Vector3(-2675.868 , -2489.403 , 77.08399 , "None"));
Path.Add(new Vector3(-2668.881 , -2488.968 , 77.54992 , "None"));
Path.Add(new Vector3(-2661.669 , -2488.551 , 78.16813 , "None"));
Path.Add(new Vector3(-2654.679 , -2488.179 , 78.57914 , "None"));
Path.Add(new Vector3(-2647.687 , -2487.853 , 79.08874 , "None"));
Path.Add(new Vector3(-2641.347 , -2487.688 , 79.29819 , "None"));
Path.Add(new Vector3(-2633.69 , -2487.555 , 79.33842 , "None"));
Path.Add(new Vector3(-2626.691 , -2487.663 , 79.36149 , "None"));
Path.Add(new Vector3(-2620.139 , -2488.078 , 79.46455 , "None"));
Path.Add(new Vector3(-2612.741 , -2488.809 , 79.67318 , "None"));
Path.Add(new Vector3(-2606.43 , -2489.434 , 79.69968 , "None"));
Path.Add(new Vector3(-2599.235 , -2490.082 , 79.76687 , "None"));
Path.Add(new Vector3(-2592.252 , -2490.543 , 80.14358 , "None"));
Path.Add(new Vector3(-2585.252 , -2490.57 , 80.38309 , "None"));
Path.Add(new Vector3(-2578.26 , -2490.274 , 80.89339 , "None"));
Path.Add(new Vector3(-2570.848 , -2489.698 , 81.33319 , "None"));
Path.Add(new Vector3(-2563.877 , -2489.071 , 81.4217 , "None"));
Path.Add(new Vector3(-2557.337 , -2488.482 , 81.42168 , "None"));
Path.Add(new Vector3(-2550.365 , -2487.855 , 81.50103 , "None"));
Path.Add(new Vector3(-2543.393 , -2487.227 , 81.48261 , "None"));
Path.Add(new Vector3(-2536.421 , -2486.608 , 81.42881 , "None"));
Path.Add(new Vector3(-2528.989 , -2486.496 , 81.89763 , "None"));
Path.Add(new Vector3(-2522.423 , -2486.499 , 81.87108 , "None"));
Path.Add(new Vector3(-2515.425 , -2486.588 , 81.93856 , "None"));
Path.Add(new Vector3(-2508.455 , -2487.223 , 81.15979 , "None"));
Path.Add(new Vector3(-2501.584 , -2488.531 , 80.30506 , "None"));
Path.Add(new Vector3(-2494.944 , -2490.743 , 79.69243 , "None"));
Path.Add(new Vector3(-2488.422 , -2493.284 , 79.16167 , "None"));
Path.Add(new Vector3(-2481.978 , -2496.016 , 78.72664 , "None"));
Path.Add(new Vector3(-2475.438 , -2498.506 , 78.48795 , "None"));
Path.Add(new Vector3(-2468.742 , -2500.545 , 78.50763 , "None"));
Path.Add(new Vector3(-2461.824 , -2501.46 , 78.50763 , "None"));
Path.Add(new Vector3(-2454.824 , -2501.505 , 78.50763 , "None"));
Path.Add(new Vector3(-2447.824 , -2501.55 , 78.50763 , "None"));
Path.Add(new Vector3(-2440.824 , -2501.595 , 78.63042 , "None"));
Path.Add(new Vector3(-2433.824 , -2501.641 , 79.97153 , "None"));
Path.Add(new Vector3(-2426.824 , -2501.646 , 81.313 , "None"));
Path.Add(new Vector3(-2419.825 , -2501.533 , 82.65428 , "None"));
Path.Add(new Vector3(-2412.826 , -2501.414 , 83.9955 , "None"));
Path.Add(new Vector3(-2405.828 , -2501.28 , 85.33681 , "None"));
Path.Add(new Vector3(-2398.829 , -2501.137 , 86.67803 , "None"));
Path.Add(new Vector3(-2391.831 , -2500.98 , 88.0191 , "None"));
Path.Add(new Vector3(-2384.838 , -2500.669 , 88.34397 , "None"));
Path.Add(new Vector3(-2377.845 , -2500.35 , 88.34397 , "None"));
Path.Add(new Vector3(-2370.876 , -2499.732 , 88.34397 , "None"));
Path.Add(new Vector3(-2363.994 , -2498.453 , 88.34397 , "None"));
Path.Add(new Vector3(-2357.123 , -2497.118 , 88.34397 , "None"));
Path.Add(new Vector3(-2350.248 , -2495.801 , 87.86224 , "None"));
Path.Add(new Vector3(-2343.323 , -2494.779 , 86.53458 , "None"));
Path.Add(new Vector3(-2336.346 , -2494.251 , 84.93006 , "None"));
Path.Add(new Vector3(-2329.347 , -2494.233 , 83.85622 , "None"));
Path.Add(new Vector3(-2322.357 , -2494.587 , 82.51667 , "None"));
Path.Add(new Vector3(-2315.381 , -2495.163 , 81.17985 , "None"));
Path.Add(new Vector3(-2308.418 , -2495.888 , 79.84557 , "None"));
Path.Add(new Vector3(-2301.248 , -2496.641 , 78.50715 , "None"));
Path.Add(new Vector3(-2294.495 , -2497.35 , 78.50715 , "None"));
Path.Add(new Vector3(-2287.321 , -2498.068 , 78.50715 , "None"));
Path.Add(new Vector3(-2280.332 , -2498.453 , 78.50715 , "None"));
Path.Add(new Vector3(-2273.547 , -2498.394 , 78.59663 , "None"));
Path.Add(new Vector3(-2266.407 , -2497.435 , 79.42278 , "None"));
Path.Add(new Vector3(-2259.969 , -2494.757 , 79.93398 , "None"));
Path.Add(new Vector3(-2254.863 , -2490.016 , 80.20641 , "None"));
Path.Add(new Vector3(-2250.941 , -2484.226 , 80.28578 , "None"));
Path.Add(new Vector3(-2247.42 , -2478.176 , 80.34475 , "None"));
Path.Add(new Vector3(-2243.966 , -2472.101 , 80.60506 , "None"));
Path.Add(new Vector3(-2240.461 , -2466.042 , 80.99985 , "None"));
Path.Add(new Vector3(-2236.455 , -2460.305 , 81.41825 , "None"));
Path.Add(new Vector3(-2231.538 , -2455.355 , 81.45741 , "None"));
Path.Add(new Vector3(-2225.34 , -2452.177 , 81.40514 , "None"));
Path.Add(new Vector3(-2218.451 , -2451.014 , 81.33624 , "None"));
Path.Add(new Vector3(-2211.471 , -2450.497 , 81.28221 , "None"));
Path.Add(new Vector3(-2204.475 , -2450.276 , 81.24197 , "None"));
Path.Add(new Vector3(-2197.476 , -2450.159 , 81.15244 , "None"));
Path.Add(new Vector3(-2190.477 , -2450.081 , 81.1076 , "None"));
Path.Add(new Vector3(-2183.477 , -2450.002 , 81.11273 , "None"));
Path.Add(new Vector3(-2176.477 , -2449.937 , 81.07837 , "None"));
Path.Add(new Vector3(-2169.477 , -2449.913 , 81.03194 , "None"));
Path.Add(new Vector3(-2162.477 , -2449.934 , 80.98371 , "None"));
Path.Add(new Vector3(-2155.478 , -2450.021 , 80.68058 , "None"));
Path.Add(new Vector3(-2148.478 , -2450.107 , 79.99636 , "None"));
Path.Add(new Vector3(-2141.479 , -2450.203 , 79.3126 , "None"));
Path.Add(new Vector3(-2134.48 , -2450.329 , 78.62289 , "None"));
Path.Add(new Vector3(-2127.481 , -2450.457 , 77.93303 , "None"));
Path.Add(new Vector3(-2120.482 , -2450.585 , 79.80485 , "None"));
Path.Add(new Vector3(-2113.484 , -2450.734 , 81.40726 , "None"));
Path.Add(new Vector3(-2106.492 , -2451.07 , 81.2942 , "None"));
Path.Add(new Vector3(-2099.51 , -2451.573 , 79.62244 , "None"));
Path.Add(new Vector3(-2092.529 , -2452.086 , 75.08326 , "None"));
Path.Add(new Vector3(-2085.551 , -2452.633 , 74.0244 , "None"));
Path.Add(new Vector3(-2078.619 , -2453.592 , 74.00239 , "None"));
Path.Add(new Vector3(-2071.538 , -2455.022 , 74.62815 , "None"));
Path.Add(new Vector3(-2064.953 , -2456.619 , 75.03202 , "None"));
Path.Add(new Vector3(-2058.189 , -2458.425 , 75.51131 , "None"));
Path.Add(new Vector3(-2051.451 , -2460.32 , 76.00349 , "None"));
Path.Add(new Vector3(-2044.715 , -2462.223 , 76.46795 , "None"));
Path.Add(new Vector3(-2037.979 , -2464.127 , 77.01689 , "None"));
Path.Add(new Vector3(-2031.231 , -2465.988 , 77.39878 , "None"));
Path.Add(new Vector3(-2024.397 , -2467.496 , 77.85667 , "None"));
Path.Add(new Vector3(-2017.486 , -2468.611 , 78.33087 , "None"));
Path.Add(new Vector3(-2010.304 , -2469.371 , 78.99623 , "None"));
Path.Add(new Vector3(-2003.309 , -2469.537 , 79.01295 , "None"));
Path.Add(new Vector3(-1996.546 , -2469.133 , 78.84265 , "None"));
Path.Add(new Vector3(-1989.594 , -2468.317 , 78.58023 , "None"));
Path.Add(new Vector3(-1982.689 , -2467.17 , 78.30228 , "None"));
Path.Add(new Vector3(-1975.615 , -2465.71 , 77.9591 , "None"));
Path.Add(new Vector3(-1968.836 , -2463.968 , 77.42785 , "None"));
Path.Add(new Vector3(-1962.12 , -2461.995 , 76.61211 , "None"));
Path.Add(new Vector3(-1956.076 , -2460.074 , 75.65903 , "None"));
Path.Add(new Vector3(-1948.917 , -2457.36 , 73.94268 , "None"));
Path.Add(new Vector3(-1942.532 , -2454.493 , 72.09706 , "None"));
Path.Add(new Vector3(-1936.66 , -2451.555 , 70.61309 , "None"));
Path.Add(new Vector3(-1930.47 , -2448.287 , 69.20112 , "None"));
Path.Add(new Vector3(-1923.919 , -2444.773 , 67.69942 , "None"));
Path.Add(new Vector3(-1917.75 , -2441.465 , 66.31464 , "None"));
Path.Add(new Vector3(-1911.581 , -2438.157 , 65.07055 , "None"));
Path.Add(new Vector3(-1905.412 , -2434.848 , 63.94346 , "None"));
Path.Add(new Vector3(-1899.243 , -2431.54 , 63.04247 , "None"));
Path.Add(new Vector3(-1893.457 , -2428.437 , 62.09742 , "None"));
Path.Add(new Vector3(-1887.288 , -2425.129 , 61.40952 , "None"));
Path.Add(new Vector3(-1880.737 , -2421.615 , 60.84598 , "None"));
Path.Add(new Vector3(-1874.933 , -2418.545 , 60.35147 , "None"));
Path.Add(new Vector3(-1868.651 , -2415.457 , 59.77818 , "None"));
Path.Add(new Vector3(-1861.946 , -2412.246 , 59.14286 , "None"));
Path.Add(new Vector3(-1855.925 , -2409.63 , 58.73728 , "None"));
Path.Add(new Vector3(-1849.313 , -2407.342 , 58.15106 , "None"));
Path.Add(new Vector3(-1842.571 , -2405.462 , 57.57789 , "None"));
Path.Add(new Vector3(-1835.272 , -2404.066 , 57.0299 , "None"));
Path.Add(new Vector3(-1828.725 , -2403.687 , 56.44367 , "None"));
Path.Add(new Vector3(-1821.735 , -2404.018 , 55.86507 , "None"));
Path.Add(new Vector3(-1814.78 , -2404.799 , 55.71587 , "None"));
Path.Add(new Vector3(-1807.894 , -2406.05 , 55.70623 , "None"));
Path.Add(new Vector3(-1801.149 , -2407.911 , 55.92691 , "None"));
Path.Add(new Vector3(-1794.562 , -2410.277 , 56.58634 , "None"));
Path.Add(new Vector3(-1788.12 , -2413.013 , 57.3844 , "None"));
Path.Add(new Vector3(-1781.701 , -2415.805 , 57.83479 , "None"));
Path.Add(new Vector3(-1775.113 , -2418.167 , 58.27824 , "None"));
Path.Add(new Vector3(-1768.429 , -2420.245 , 58.79941 , "None"));
Path.Add(new Vector3(-1761.74 , -2422.307 , 59.92452 , "None"));
Path.Add(new Vector3(-1755.05 , -2424.37 , 60.62327 , "None"));
Path.Add(new Vector3(-1748.361 , -2426.432 , 61.00274 , "None"));
Path.Add(new Vector3(-1741.713 , -2428.624 , 61.31413 , "None"));
Path.Add(new Vector3(-1735.097 , -2430.909 , 61.76799 , "None"));
Path.Add(new Vector3(-1728.486 , -2433.21 , 62.23491 , "None"));
Path.Add(new Vector3(-1721.942 , -2435.693 , 62.81361 , "None"));
Path.Add(new Vector3(-1715.564 , -2438.576 , 63.16692 , "None"));
Path.Add(new Vector3(-1709.094 , -2441.758 , 63.47329 , "None"));
Path.Add(new Vector3(-1702.838 , -2444.898 , 63.32862 , "None"));
Path.Add(new Vector3(-1696.771 , -2447.948 , 63.30441 , "None"));
Path.Add(new Vector3(-1690.518 , -2451.093 , 63.30441 , "None"));
Path.Add(new Vector3(-1684.264 , -2454.238 , 63.30441 , "None"));
Path.Add(new Vector3(-1677.815 , -2457.461 , 63.30441 , "None"));
Path.Add(new Vector3(-1671.703 , -2460.421 , 63.34544 , "None"));
Path.Add(new Vector3(-1665.401 , -2463.467 , 63.50431 , "None"));
Path.Add(new Vector3(-1659.098 , -2466.513 , 63.54844 , "None"));
Path.Add(new Vector3(-1652.593 , -2469.622 , 63.51504 , "None"));
Path.Add(new Vector3(-1646.258 , -2472.599 , 63.48537 , "None"));
Path.Add(new Vector3(-1639.902 , -2475.531 , 63.49994 , "None"));
Path.Add(new Vector3(-1633.696 , -2478.287 , 63.45367 , "None"));
Path.Add(new Vector3(-1627.051 , -2481.084 , 62.99207 , "None"));
Path.Add(new Vector3(-1620.506 , -2483.564 , 62.54917 , "None"));
Path.Add(new Vector3(-1613.888 , -2485.845 , 61.84267 , "None"));
Path.Add(new Vector3(-1607.208 , -2487.938 , 60.64257 , "None"));
Path.Add(new Vector3(-1600.492 , -2489.91 , 60.22649 , "None"));
Path.Add(new Vector3(-1593.725 , -2491.701 , 59.43979 , "None"));
Path.Add(new Vector3(-1586.899 , -2493.247 , 58.57167 , "None"));
Path.Add(new Vector3(-1580.019 , -2494.538 , 57.60631 , "None"));
Path.Add(new Vector3(-1573.096 , -2495.573 , 56.62056 , "None"));
Path.Add(new Vector3(-1566.124 , -2496.173 , 55.85427 , "None"));
Path.Add(new Vector3(-1559.126 , -2496.169 , 55.24327 , "None"));
Path.Add(new Vector3(-1552.254 , -2494.986 , 54.67964 , "None"));
Path.Add(new Vector3(-1545.885 , -2492.092 , 54.26113 , "None"));
Path.Add(new Vector3(-1539.79 , -2488.651 , 53.66648 , "None"));
Path.Add(new Vector3(-1533.797 , -2485.033 , 53.54547 , "None"));
Path.Add(new Vector3(-1527.957 , -2481.176 , 53.45085 , "None"));
Path.Add(new Vector3(-1522.234 , -2477.146 , 53.33228 , "None"));
Path.Add(new Vector3(-1516.681 , -2472.884 , 53.26488 , "None"));
Path.Add(new Vector3(-1511.301 , -2468.408 , 53.11921 , "None"));
Path.Add(new Vector3(-1506.079 , -2463.747 , 53.01736 , "None"));
Path.Add(new Vector3(-1500.871 , -2459.069 , 52.93372 , "None"));
Path.Add(new Vector3(-1495.663 , -2454.392 , 53.06684 , "None"));
Path.Add(new Vector3(-1490.456 , -2449.714 , 53.82039 , "None"));
Path.Add(new Vector3(-1485.243 , -2445.042 , 54.66602 , "None"));
Path.Add(new Vector3(-1479.795 , -2440.651 , 55.49122 , "None"));
Path.Add(new Vector3(-1473.663 , -2437.333 , 56.3752 , "None"));
Path.Add(new Vector3(-1466.846 , -2435.93 , 57.5454 , "None"));
Path.Add(new Vector3(-1459.897 , -2436.695 , 58.14394 , "None"));
Path.Add(new Vector3(-1453.046 , -2438.123 , 58.40154 , "None"));
Path.Add(new Vector3(-1446.392 , -2440.289 , 58.60481 , "None"));
Path.Add(new Vector3(-1439.947 , -2443.016 , 58.81088 , "None"));
Path.Add(new Vector3(-1433.188 , -2444.835 , 58.85948 , "None"));
Path.Add(new Vector3(-1426.423 , -2446.633 , 59.4329 , "None"));
Path.Add(new Vector3(-1419.658 , -2448.431 , 59.8541 , "None"));
Path.Add(new Vector3(-1412.875 , -2450.161 , 60.12151 , "None"));
Path.Add(new Vector3(-1406.049 , -2451.71 , 59.7382 , "None"));
Path.Add(new Vector3(-1399.152 , -2452.901 , 58.93641 , "None"));
Path.Add(new Vector3(-1392.196 , -2453.662 , 57.7248 , "None"));
Path.Add(new Vector3(-1385.199 , -2453.779 , 56.3199 , "None"));
Path.Add(new Vector3(-1378.21 , -2453.403 , 54.54289 , "None"));
Path.Add(new Vector3(-1371.234 , -2452.831 , 53.2027 , "None"));
Path.Add(new Vector3(-1364.264 , -2452.181 , 51.9852 , "None"));
Path.Add(new Vector3(-1357.115 , -2451.151 , 50.69741 , "None"));
Path.Add(new Vector3(-1350.51 , -2449.666 , 49.67646 , "None"));
Path.Add(new Vector3(-1343.461 , -2448.114 , 48.02159 , "None"));
Path.Add(new Vector3(-1336.486 , -2448.294 , 46.56782 , "None"));
Path.Add(new Vector3(-1330.106 , -2449.827 , 45.13478 , "None"));
Path.Add(new Vector3(-1323.229 , -2452.644 , 43.8078 , "None"));
Path.Add(new Vector3(-1316.902 , -2455.639 , 42.96082 , "None"));
Path.Add(new Vector3(-1311.113 , -2458.732 , 41.53688 , "None"));
Path.Add(new Vector3(-1305.268 , -2462.16 , 39.46126 , "None"));
Path.Add(new Vector3(-1299.133 , -2465.975 , 37.07019 , "None"));
Path.Add(new Vector3(-1293.005 , -2470.181 , 34.63111 , "None"));
Path.Add(new Vector3(-1287.772 , -2474.146 , 32.36233 , "None"));
Path.Add(new Vector3(-1282.411 , -2478.646 , 29.59474 , "None"));
Path.Add(new Vector3(-1276.895 , -2483.629 , 26.82098 , "None"));
Path.Add(new Vector3(-1272.364 , -2488.377 , 24.54409 , "None"));
Path.Add(new Vector3(-1267.743 , -2493.636 , 22.50966 , "None"));
Path.Add(new Vector3(-1263.009 , -2498.791 , 21.32222 , "None"));
Path.Add(new Vector3(-1257.779 , -2504.07 , 20.8599 , "None"));
Path.Add(new Vector3(-1252.318 , -2508.445 , 20.92699 , "None"));
Path.Add(new Vector3(-1246.705 , -2511.836 , 20.46532 , "None"));
Path.Add(new Vector3(-1242.851 , -2513.393 , 21.25591 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

        








public override bool HasQuest() { return true; }


}


public sealed class PathMenethilToIronbeardsTomb : QuestFollowPathClass
{
    public PathMenethilToIronbeardsTomb()
    {
        Name = "PathMenethilToIronbeardsTomb";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-3788.639 , -789.1033 , 9.436183 , "None"));
Path.Add(new Vector3(-3784.865 , -795.9969 , 8.777211 , "None"));
Path.Add(new Vector3(-3783.901 , -806.3575 , 8.820148 , "None"));
Path.Add(new Vector3(-3784.277 , -816.8479 , 9.237641 , "None"));
Path.Add(new Vector3(-3782.89 , -827.2349 , 9.896059 , "None"));
Path.Add(new Vector3(-3779.635 , -837.2073 , 9.900434 , "None"));
Path.Add(new Vector3(-3775.142 , -846.6914 , 9.900434 , "None"));
Path.Add(new Vector3(-3768.881 , -855.064 , 9.900434 , "None"));
Path.Add(new Vector3(-3760.652 , -861.5692 , 9.900202 , "None"));
Path.Add(new Vector3(-3751.465 , -866.5872 , 9.900202 , "None"));
Path.Add(new Vector3(-3741.259 , -868.8796 , 9.900202 , "None"));
Path.Add(new Vector3(-3730.778 , -868.8006 , 9.900202 , "None"));
Path.Add(new Vector3(-3720.427 , -867.0508 , 9.900202 , "None"));
Path.Add(new Vector3(-3710.457 , -863.8506 , 9.899196 , "None"));
Path.Add(new Vector3(-3701.455 , -858.454 , 9.979119 , "None"));
Path.Add(new Vector3(-3692.969 , -852.2738 , 9.908154 , "None"));
Path.Add(new Vector3(-3684.439 , -846.1555 , 10.10042 , "None"));
Path.Add(new Vector3(-3675.275 , -841.0464 , 9.920004 , "None"));
Path.Add(new Vector3(-3665.068 , -838.9194 , 9.89926 , "None"));
Path.Add(new Vector3(-3654.695 , -840.3421 , 9.878592 , "None"));
Path.Add(new Vector3(-3644.801 , -843.8242 , 8.885144 , "None"));
Path.Add(new Vector3(-3635.296 , -848.2831 , 9.53571 , "None"));
Path.Add(new Vector3(-3625.915 , -853.0004 , 11.05911 , "None"));
Path.Add(new Vector3(-3616.602 , -857.849 , 12.05021 , "None"));
Path.Add(new Vector3(-3607.3 , -862.7194 , 12.68397 , "None"));
Path.Add(new Vector3(-3597.998 , -867.5898 , 12.95865 , "None"));
Path.Add(new Vector3(-3588.695 , -872.4602 , 12.9857 , "None"));
Path.Add(new Vector3(-3579.393 , -877.3306 , 12.95697 , "None"));
Path.Add(new Vector3(-3570.091 , -882.201 , 12.67497 , "None"));
Path.Add(new Vector3(-3560.789 , -887.0714 , 12.02745 , "None"));
Path.Add(new Vector3(-3551.487 , -891.9418 , 11.02413 , "None"));
Path.Add(new Vector3(-3542.185 , -896.8122 , 9.484025 , "None"));
Path.Add(new Vector3(-3532.883 , -901.6826 , 8.917088 , "None"));
Path.Add(new Vector3(-3523.581 , -906.553 , 9.147478 , "None"));
Path.Add(new Vector3(-3514.281 , -911.4279 , 8.866069 , "None"));
Path.Add(new Vector3(-3505.094 , -916.5121 , 8.865852 , "None"));
Path.Add(new Vector3(-3495.949 , -921.6735 , 8.865852 , "None"));
Path.Add(new Vector3(-3486.892 , -926.9843 , 8.865852 , "None"));
Path.Add(new Vector3(-3478.011 , -932.5834 , 8.865853 , "None"));
Path.Add(new Vector3(-3469.482 , -938.7052 , 8.865853 , "None"));
Path.Add(new Vector3(-3461.348 , -945.3426 , 8.865853 , "None"));
Path.Add(new Vector3(-3454.029 , -951.9324 , 8.865853 , "None"));
Path.Add(new Vector3(-3445.797 , -959.9417 , 8.865853 , "None"));
Path.Add(new Vector3(-3438.662 , -967.18 , 8.865853 , "None"));
Path.Add(new Vector3(-3431.86 , -974.3008 , 8.865853 , "None"));
Path.Add(new Vector3(-3424.932 , -983.4539 , 8.865853 , "None"));
Path.Add(new Vector3(-3418.854 , -992.0164 , 8.862968 , "None"));
Path.Add(new Vector3(-3412.816 , -1000.524 , 8.886712 , "None"));
Path.Add(new Vector3(-3406.739 , -1009.087 , 9.581855 , "None"));
Path.Add(new Vector3(-3400.662 , -1017.649 , 8.871438 , "None"));
Path.Add(new Vector3(-3394.855 , -1026.389 , 8.740342 , "None"));
Path.Add(new Vector3(-3390.087 , -1035.743 , 9.161364 , "None"));
Path.Add(new Vector3(-3385.551 , -1044.461 , 9.146324 , "None"));
Path.Add(new Vector3(-3379.69 , -1053.971 , 9.146324 , "None"));
Path.Add(new Vector3(-3373.906 , -1062.733 , 9.146324 , "None"));
Path.Add(new Vector3(-3368.407 , -1070.88 , 9.146324 , "None"));
Path.Add(new Vector3(-3362.946 , -1079.837 , 9.146324 , "None"));
Path.Add(new Vector3(-3358.643 , -1090.14 , 9.146324 , "None"));
Path.Add(new Vector3(-3356.062 , -1099.617 , 9.146324 , "None"));
Path.Add(new Vector3(-3354.183 , -1110.628 , 9.146324 , "None"));
Path.Add(new Vector3(-3352.696 , -1120.343 , 9.146324 , "None"));
Path.Add(new Vector3(-3351.305 , -1130.749 , 9.146324 , "None"));
Path.Add(new Vector3(-3350.525 , -1141.217 , 9.146324 , "None"));
Path.Add(new Vector3(-3350.106 , -1151.708 , 9.146324 , "None"));
Path.Add(new Vector3(-3349.686 , -1162.2 , 9.146324 , "None"));
Path.Add(new Vector3(-3349.267 , -1172.691 , 9.146324 , "None"));
Path.Add(new Vector3(-3348.847 , -1183.183 , 9.104311 , "None"));
Path.Add(new Vector3(-3348.427 , -1193.675 , 9.14622 , "None"));
Path.Add(new Vector3(-3348.008 , -1204.166 , 9.146606 , "None"));
Path.Add(new Vector3(-3347.396 , -1214.648 , 9.146606 , "None"));
Path.Add(new Vector3(-3346.507 , -1225.109 , 9.146606 , "None"));
Path.Add(new Vector3(-3345.511 , -1235.562 , 9.146606 , "None"));
Path.Add(new Vector3(-3344.516 , -1246.015 , 9.146606 , "None"));
Path.Add(new Vector3(-3343.522 , -1256.468 , 9.146606 , "None"));
Path.Add(new Vector3(-3342.819 , -1266.943 , 9.146606 , "None"));
Path.Add(new Vector3(-3342.89 , -1277.439 , 8.902915 , "None"));
Path.Add(new Vector3(-3344.017 , -1287.59 , 8.088106 , "None"));
Path.Add(new Vector3(-3346.021 , -1297.897 , 8.775851 , "None"));
Path.Add(new Vector3(-3348.099 , -1308.189 , 8.113364 , "None"));
Path.Add(new Vector3(-3349.66 , -1318.567 , 8.162743 , "None"));
Path.Add(new Vector3(-3349.645 , -1329.044 , 9.102009 , "None"));
Path.Add(new Vector3(-3348.282 , -1339.455 , 9.146716 , "None"));
Path.Add(new Vector3(-3346.717 , -1349.832 , 9.146716 , "None"));
Path.Add(new Vector3(-3343.449 , -1359.806 , 9.146716 , "None"));
Path.Add(new Vector3(-3339.963 , -1369.711 , 9.146716 , "None"));
Path.Add(new Vector3(-3336.357 , -1379.572 , 9.146716 , "None"));
Path.Add(new Vector3(-3332.735 , -1389.427 , 9.146716 , "None"));
Path.Add(new Vector3(-3329.078 , -1399.27 , 9.177387 , "None"));
Path.Add(new Vector3(-3324.887 , -1408.897 , 9.146207 , "None"));
Path.Add(new Vector3(-3320.382 , -1418.381 , 9.146275 , "None"));
Path.Add(new Vector3(-3315.665 , -1428.136 , 9.146275 , "None"));
Path.Add(new Vector3(-3311.657 , -1437.466 , 9.146275 , "None"));
Path.Add(new Vector3(-3308.66 , -1447.877 , 9.146275 , "None"));
Path.Add(new Vector3(-3306.087 , -1457.71 , 9.146275 , "None"));
Path.Add(new Vector3(-3303.429 , -1467.868 , 9.177467 , "None"));
Path.Add(new Vector3(-3300.686 , -1478.351 , 9.146195 , "None"));
Path.Add(new Vector3(-3298.112 , -1488.183 , 10.31218 , "None"));
Path.Add(new Vector3(-3295.369 , -1498.666 , 10.2119 , "None"));
Path.Add(new Vector3(-3292.711 , -1508.824 , 9.146224 , "None"));
Path.Add(new Vector3(-3290.052 , -1518.982 , 9.146224 , "None"));
Path.Add(new Vector3(-3287.394 , -1529.14 , 9.146224 , "None"));
Path.Add(new Vector3(-3284.736 , -1539.298 , 9.146224 , "None"));
Path.Add(new Vector3(-3282.078 , -1549.456 , 9.146224 , "None"));
Path.Add(new Vector3(-3279.419 , -1559.614 , 9.146224 , "None"));
Path.Add(new Vector3(-3276.757 , -1569.771 , 9.146224 , "None"));
Path.Add(new Vector3(-3273.937 , -1579.885 , 9.185244 , "None"));
Path.Add(new Vector3(-3271.09 , -1589.992 , 9.33602 , "None"));
Path.Add(new Vector3(-3268.04 , -1600.039 , 9.257178 , "None"));
Path.Add(new Vector3(-3264.82 , -1610.033 , 9.172869 , "None"));
Path.Add(new Vector3(-3261.568 , -1620.017 , 9.146347 , "None"));
Path.Add(new Vector3(-3258.316 , -1630.001 , 9.146347 , "None"));
Path.Add(new Vector3(-3255.065 , -1639.984 , 9.146347 , "None"));
Path.Add(new Vector3(-3251.813 , -1649.968 , 9.146347 , "None"));
Path.Add(new Vector3(-3248.562 , -1659.952 , 9.154195 , "None"));
Path.Add(new Vector3(-3245.31 , -1669.936 , 9.146221 , "None"));
Path.Add(new Vector3(-3242.058 , -1679.92 , 9.146221 , "None"));
Path.Add(new Vector3(-3238.684 , -1689.862 , 9.146221 , "None"));
Path.Add(new Vector3(-3235.043 , -1699.71 , 9.146221 , "None"));
Path.Add(new Vector3(-3231.402 , -1709.559 , 9.146221 , "None"));
Path.Add(new Vector3(-3227.76 , -1719.407 , 9.143139 , "None"));
Path.Add(new Vector3(-3224.119 , -1729.256 , 9.164406 , "None"));
Path.Add(new Vector3(-3220.547 , -1739.129 , 9.146964 , "None"));
Path.Add(new Vector3(-3217.157 , -1749.067 , 9.146964 , "None"));
Path.Add(new Vector3(-3214.019 , -1759.087 , 9.146964 , "None"));
Path.Add(new Vector3(-3211.072 , -1769.165 , 9.146964 , "None"));
Path.Add(new Vector3(-3208.136 , -1779.246 , 9.146964 , "None"));
Path.Add(new Vector3(-3205.223 , -1789.333 , 9.146964 , "None"));
Path.Add(new Vector3(-3202.444 , -1799.459 , 9.146964 , "None"));
Path.Add(new Vector3(-3199.705 , -1809.595 , 9.145394 , "None"));
Path.Add(new Vector3(-3197.007 , -1819.743 , 9.145394 , "None"));
Path.Add(new Vector3(-3194.528 , -1829.946 , 9.145394 , "None"));
Path.Add(new Vector3(-3192.07 , -1840.154 , 9.146143 , "None"));
Path.Add(new Vector3(-3189.611 , -1850.362 , 9.146143 , "None"));
Path.Add(new Vector3(-3187.523 , -1860.64 , 9.240343 , "None"));
Path.Add(new Vector3(-3185.965 , -1871.021 , 10.43927 , "None"));
Path.Add(new Vector3(-3185.163 , -1881.491 , 12.39779 , "None"));
Path.Add(new Vector3(-3184.414 , -1891.964 , 13.94431 , "None"));
Path.Add(new Vector3(-3183.665 , -1902.437 , 14.03729 , "None"));
Path.Add(new Vector3(-3182.897 , -1913.246 , 14.1058 , "None"));
Path.Add(new Vector3(-3181.978 , -1923.368 , 13.88529 , "None"));
Path.Add(new Vector3(-3180.833 , -1934.143 , 13.39422 , "None"));
Path.Add(new Vector3(-3180.151 , -1944.619 , 13.66097 , "None"));
Path.Add(new Vector3(-3179.878 , -1955.115 , 13.89084 , "None"));
Path.Add(new Vector3(-3179.634 , -1965.613 , 14.08051 , "None"));
Path.Add(new Vector3(-3179.47 , -1975.124 , 14.3488 , "None"));
Path.Add(new Vector3(-3179.355 , -1985.624 , 14.96498 , "None"));
Path.Add(new Vector3(-3179.232 , -1997.11 , 15.28042 , "None"));
Path.Add(new Vector3(-3179.081 , -2007.609 , 15.54843 , "None"));
Path.Add(new Vector3(-3178.929 , -2018.108 , 15.75222 , "None"));
Path.Add(new Vector3(-3178.787 , -2027.935 , 15.80514 , "None"));
Path.Add(new Vector3(-3178.642 , -2038.433 , 15.80514 , "None"));
Path.Add(new Vector3(-3178.686 , -2049.605 , 15.80514 , "None"));
Path.Add(new Vector3(-3179.062 , -2059.426 , 15.80514 , "None"));
Path.Add(new Vector3(-3179.842 , -2069.896 , 15.80514 , "None"));
Path.Add(new Vector3(-3180.72 , -2080.359 , 15.80514 , "None"));
Path.Add(new Vector3(-3181.598 , -2090.823 , 15.80514 , "None"));
Path.Add(new Vector3(-3182.476 , -2101.286 , 15.80514 , "None"));
Path.Add(new Vector3(-3183.214 , -2112.433 , 15.80514 , "None"));
Path.Add(new Vector3(-3183.591 , -2122.253 , 15.80514 , "None"));
Path.Add(new Vector3(-3183.975 , -2132.747 , 15.80514 , "None"));
Path.Add(new Vector3(-3184.421 , -2143.237 , 15.80514 , "None"));
Path.Add(new Vector3(-3185.202 , -2154.379 , 15.80514 , "None"));
Path.Add(new Vector3(-3186.493 , -2164.121 , 15.80514 , "None"));
Path.Add(new Vector3(-3188.549 , -2174.415 , 15.80514 , "None"));
Path.Add(new Vector3(-3191.192 , -2184.576 , 15.80514 , "None"));
Path.Add(new Vector3(-3194.283 , -2194.609 , 15.80514 , "None"));
Path.Add(new Vector3(-3197.783 , -2204.508 , 15.80514 , "None"));
Path.Add(new Vector3(-3201.294 , -2214.404 , 15.80221 , "None"));
Path.Add(new Vector3(-3204.805 , -2224.3 , 15.80355 , "None"));
Path.Add(new Vector3(-3208.316 , -2234.195 , 15.80355 , "None"));
Path.Add(new Vector3(-3211.827 , -2244.091 , 15.80355 , "None"));
Path.Add(new Vector3(-3215.217 , -2254.028 , 15.80355 , "None"));
Path.Add(new Vector3(-3217.663 , -2264.232 , 15.80355 , "None"));
Path.Add(new Vector3(-3219.144 , -2274.622 , 15.80355 , "None"));
Path.Add(new Vector3(-3220.042 , -2285.083 , 15.80355 , "None"));
Path.Add(new Vector3(-3220.901 , -2295.548 , 15.80355 , "None"));
Path.Add(new Vector3(-3221.635 , -2306.022 , 15.78878 , "None"));
Path.Add(new Vector3(-3222.321 , -2316.5 , 15.78479 , "None"));
Path.Add(new Vector3(-3222.936 , -2326.982 , 15.88873 , "None"));
Path.Add(new Vector3(-3223.567 , -2337.463 , 15.79053 , "None"));
Path.Add(new Vector3(-3224.18 , -2347.945 , 15.80416 , "None"));
Path.Add(new Vector3(-3224.539 , -2358.438 , 15.80366 , "None"));
Path.Add(new Vector3(-3224.604 , -2368.937 , 15.80567 , "None"));
Path.Add(new Vector3(-3224.281 , -2379.431 , 15.80515 , "None"));
Path.Add(new Vector3(-3223.781 , -2389.92 , 15.80515 , "None"));
Path.Add(new Vector3(-3223.123 , -2400.399 , 15.80515 , "None"));
Path.Add(new Vector3(-3222.079 , -2410.846 , 15.80515 , "None"));
Path.Add(new Vector3(-3220.429 , -2421.211 , 15.80515 , "None"));
Path.Add(new Vector3(-3216.807 , -2431.026 , 15.48006 , "None"));
Path.Add(new Vector3(-3210.603 , -2439.46 , 13.36556 , "None"));
Path.Add(new Vector3(-3201.972 , -2445.34 , 10.58181 , "None"));
Path.Add(new Vector3(-3191.723 , -2448.747 , 9.302706 , "None"));
Path.Add(new Vector3(-3181.646 , -2449.256 , 8.927621 , "None"));
Path.Add(new Vector3(-3171.373 , -2447.192 , 9.68623 , "None"));
Path.Add(new Vector3(-3160.924 , -2444.324 , 8.927918 , "None"));
Path.Add(new Vector3(-3150.487 , -2443.504 , 9.175673 , "None"));
Path.Add(new Vector3(-3140.015 , -2444.135 , 9.163527 , "None"));
Path.Add(new Vector3(-3129.535 , -2444.492 , 9.430575 , "None"));
Path.Add(new Vector3(-3119.237 , -2442.496 , 11.51772 , "None"));
Path.Add(new Vector3(-3109.114 , -2439.711 , 12.45714 , "None"));
Path.Add(new Vector3(-3099.072 , -2436.652 , 12.8838 , "None"));
Path.Add(new Vector3(-3089.296 , -2432.82 , 12.39172 , "None"));
Path.Add(new Vector3(-3079.337 , -2429.504 , 10.91452 , "None"));
Path.Add(new Vector3(-3069.117 , -2427.106 , 10.89411 , "None"));
Path.Add(new Vector3(-3058.782 , -2425.255 , 10.89411 , "None"));
Path.Add(new Vector3(-3048.411 , -2423.619 , 10.89499 , "None"));
Path.Add(new Vector3(-3038.018 , -2422.122 , 10.89499 , "None"));
Path.Add(new Vector3(-3027.606 , -2420.766 , 10.71033 , "None"));
Path.Add(new Vector3(-3017.183 , -2419.519 , 10.84752 , "None"));
Path.Add(new Vector3(-3006.746 , -2418.366 , 11.0197 , "None"));
Path.Add(new Vector3(-2996.3 , -2417.304 , 11.83993 , "None"));
Path.Add(new Vector3(-2985.86 , -2416.184 , 13.34904 , "None"));
Path.Add(new Vector3(-2975.518 , -2414.385 , 14.74515 , "None"));
Path.Add(new Vector3(-2965.332 , -2411.848 , 15.74737 , "None"));
Path.Add(new Vector3(-2955.372 , -2408.532 , 16.6419 , "None"));
Path.Add(new Vector3(-2945.825 , -2404.215 , 18.22285 , "None"));
Path.Add(new Vector3(-2937.352 , -2398.079 , 19.57209 , "None"));
Path.Add(new Vector3(-2929.619 , -2390.976 , 22.2515 , "None"));
Path.Add(new Vector3(-2922.278 , -2383.471 , 24.19126 , "None"));
Path.Add(new Vector3(-2915.358 , -2375.574 , 24.2823 , "None"));
Path.Add(new Vector3(-2908.246 , -2367.852 , 24.96844 , "None"));
Path.Add(new Vector3(-2901.003 , -2360.249 , 27.43758 , "None"));
Path.Add(new Vector3(-2894.288 , -2352.185 , 29.43269 , "None"));
Path.Add(new Vector3(-2887.903 , -2343.849 , 30.3029 , "None"));
Path.Add(new Vector3(-2881.607 , -2335.446 , 31.58632 , "None"));
Path.Add(new Vector3(-2875.609 , -2326.828 , 32.75585 , "None"));
Path.Add(new Vector3(-2869.813 , -2318.073 , 33.65961 , "None"));
Path.Add(new Vector3(-2864.366 , -2309.098 , 35.76714 , "None"));
Path.Add(new Vector3(-2860.033 , -2299.547 , 37.76241 , "None"));
Path.Add(new Vector3(-2857.183 , -2289.457 , 37.38295 , "None"));
Path.Add(new Vector3(-2856.669 , -2279.001 , 34.93749 , "None"));
Path.Add(new Vector3(-2859.112 , -2268.803 , 34.27789 , "None"));
Path.Add(new Vector3(-2860.863 , -2262.468 , 33.49307 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

        








public override bool HasQuest() { return true; }


}


public sealed class PathSwampOfSorrrowsToTranquilGardens : QuestFollowPathClass
{
    public PathSwampOfSorrrowsToTranquilGardens()
    {
        Name = "PathSwampOfSorrrowsToTranquilGardens";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-10409.02 , -2494.527 , 32.64363 , "None"));
Path.Add(new Vector3(-10400.65 , -2482.235 , 35.24656 , "None"));
Path.Add(new Vector3(-10393.32 , -2470.321 , 39.15376 , "None"));
Path.Add(new Vector3(-10389.13 , -2457.05 , 43.79581 , "None"));
Path.Add(new Vector3(-10386.83 , -2443.247 , 47.43877 , "None"));
Path.Add(new Vector3(-10388.16 , -2429.377 , 51.45663 , "None"));
Path.Add(new Vector3(-10396.67 , -2418.521 , 55.77573 , "None"));
Path.Add(new Vector3(-10409.3 , -2412.591 , 60.5154 , "None"));
Path.Add(new Vector3(-10423.11 , -2410.422 , 64.9773 , "None"));
Path.Add(new Vector3(-10437.07 , -2409.307 , 67.73402 , "None"));
Path.Add(new Vector3(-10451.02 , -2408.201 , 69.38489 , "None"));
Path.Add(new Vector3(-10464.76 , -2405.898 , 71.67212 , "None"));
Path.Add(new Vector3(-10476.59 , -2398.432 , 74.57702 , "None"));
Path.Add(new Vector3(-10488.25 , -2390.686 , 76.51527 , "None"));
Path.Add(new Vector3(-10500.44 , -2383.856 , 77.76172 , "None"));
Path.Add(new Vector3(-10513.93 , -2378.762 , 80.14987 , "None"));
Path.Add(new Vector3(-10527.33 , -2374.714 , 82.07172 , "None"));
Path.Add(new Vector3(-10539.5 , -2368.748 , 83.03942 , "None"));
Path.Add(new Vector3(-10549.35 , -2358.475 , 85.31879 , "None"));
Path.Add(new Vector3(-10553.05 , -2345.513 , 87.14002 , "None"));
Path.Add(new Vector3(-10553.4 , -2331.118 , 88.51716 , "None"));
Path.Add(new Vector3(-10553.36 , -2317.118 , 89.75444 , "None"));
Path.Add(new Vector3(-10555.7 , -2303.355 , 91.08154 , "None"));
Path.Add(new Vector3(-10559.12 , -2289.801 , 92.28997 , "None"));
Path.Add(new Vector3(-10562.54 , -2276.225 , 93.74784 , "None"));
Path.Add(new Vector3(-10565.96 , -2262.649 , 94.26613 , "None"));
Path.Add(new Vector3(-10569.55 , -2249.118 , 93.7678 , "None"));
Path.Add(new Vector3(-10573.52 , -2235.696 , 93.1581 , "None"));
Path.Add(new Vector3(-10577.87 , -2222.391 , 92.75472 , "None"));
Path.Add(new Vector3(-10581.85 , -2208.971 , 91.70831 , "None"));
Path.Add(new Vector3(-10585.01 , -2195.335 , 90.52056 , "None"));
Path.Add(new Vector3(-10587.41 , -2181.545 , 89.96545 , "None"));
Path.Add(new Vector3(-10589.53 , -2167.705 , 90.79192 , "None"));
Path.Add(new Vector3(-10590.92 , -2153.783 , 92.72074 , "None"));
Path.Add(new Vector3(-10591.5 , -2139.804 , 92.79482 , "None"));
Path.Add(new Vector3(-10587.76 , -2126.459 , 91.08714 , "None"));
Path.Add(new Vector3(-10578.01 , -2116.504 , 90.98991 , "None"));
Path.Add(new Vector3(-10565.8 , -2109.719 , 91.08801 , "None"));
Path.Add(new Vector3(-10553.11 , -2103.813 , 91.89768 , "None"));
Path.Add(new Vector3(-10542.34 , -2094.907 , 91.46806 , "None"));
Path.Add(new Vector3(-10532.12 , -2085.337 , 91.54077 , "None"));
Path.Add(new Vector3(-10523.51 , -2074.345 , 91.70005 , "None"));
Path.Add(new Vector3(-10516.56 , -2062.19 , 91.99497 , "None"));
Path.Add(new Vector3(-10508.52 , -2050.804 , 92.16058 , "None"));
Path.Add(new Vector3(-10497 , -2042.953 , 92.96391 , "None"));
Path.Add(new Vector3(-10483.34 , -2040.25 , 93.32825 , "None"));
Path.Add(new Vector3(-10469.35 , -2039.764 , 93.27083 , "None"));
Path.Add(new Vector3(-10455.36 , -2039.216 , 93.55611 , "None"));
Path.Add(new Vector3(-10441.91 , -2035.668 , 94.66716 , "None"));
Path.Add(new Vector3(-10432.51 , -2025.648 , 95.81368 , "None"));
Path.Add(new Vector3(-10428.62 , -2012.251 , 97.63042 , "None"));
Path.Add(new Vector3(-10430.69 , -1998.587 , 99.16944 , "None"));
Path.Add(new Vector3(-10436.53 , -1985.874 , 100.4396 , "None"));
Path.Add(new Vector3(-10441.18 , -1972.74 , 102.051 , "None"));
Path.Add(new Vector3(-10442.18 , -1958.835 , 103.1311 , "None"));
Path.Add(new Vector3(-10440.43 , -1944.945 , 103.9288 , "None"));
Path.Add(new Vector3(-10439.5 , -1930.987 , 104.6196 , "None"));
Path.Add(new Vector3(-10440.12 , -1917.004 , 104.1246 , "None"));
Path.Add(new Vector3(-10441.26 , -1903.051 , 103.4014 , "None"));
Path.Add(new Vector3(-10442.55 , -1889.112 , 103.6164 , "None"));
Path.Add(new Vector3(-10444.1 , -1875.198 , 104.6845 , "None"));
Path.Add(new Vector3(-10443.26 , -1861.252 , 104.7094 , "None"));
Path.Add(new Vector3(-10440.33 , -1847.581 , 102.9729 , "None"));
Path.Add(new Vector3(-10436.12 , -1834.229 , 101.6751 , "None"));
Path.Add(new Vector3(-10431.97 , -1820.861 , 100.1538 , "None"));
Path.Add(new Vector3(-10430.71 , -1806.518 , 98.33176 , "None"));
Path.Add(new Vector3(-10431.86 , -1793.905 , 97.30898 , "None"));
Path.Add(new Vector3(-10438.24 , -1780.074 , 95.58724 , "None"));
Path.Add(new Vector3(-10445.81 , -1768.299 , 92.84554 , "None"));
Path.Add(new Vector3(-10452.26 , -1757.386 , 90.18324 , "None"));
Path.Add(new Vector3(-10457.64 , -1743.064 , 87.99573 , "None"));
Path.Add(new Vector3(-10460.67 , -1730.297 , 86.02325 , "None"));
Path.Add(new Vector3(-10462.84 , -1716.467 , 83.46396 , "None"));
Path.Add(new Vector3(-10464.66 , -1702.587 , 82.06194 , "None"));
Path.Add(new Vector3(-10465.81 , -1688.636 , 80.51287 , "None"));
Path.Add(new Vector3(-10466.35 , -1674.649 , 79.38334 , "None"));
Path.Add(new Vector3(-10466.01 , -1660.654 , 77.30669 , "None"));
Path.Add(new Vector3(-10465.02 , -1645.819 , 75.90509 , "None"));
Path.Add(new Vector3(-10464.14 , -1632.717 , 74.40034 , "None"));
Path.Add(new Vector3(-10463.14 , -1617.882 , 73.40982 , "None"));
Path.Add(new Vector3(-10462.06 , -1603.926 , 73.34184 , "None"));
Path.Add(new Vector3(-10460.55 , -1590.881 , 73.3291 , "None"));
Path.Add(new Vector3(-10458.23 , -1577.081 , 73.58039 , "None"));
Path.Add(new Vector3(-10455.38 , -1563.373 , 73.52541 , "None"));
Path.Add(new Vector3(-10452.58 , -1549.656 , 74.00983 , "None"));
Path.Add(new Vector3(-10450.41 , -1535.83 , 75.02601 , "None"));
Path.Add(new Vector3(-10448.79 , -1521.077 , 74.64199 , "None"));
Path.Add(new Vector3(-10448.22 , -1507.96 , 74.61072 , "None"));
Path.Add(new Vector3(-10448.59 , -1493.972 , 74.5521 , "None"));
Path.Add(new Vector3(-10450.4 , -1480.097 , 73.32829 , "None"));
Path.Add(new Vector3(-10453.56 , -1466.46 , 71.39506 , "None"));
Path.Add(new Vector3(-10458.16 , -1453.257 , 69.52462 , "None"));
Path.Add(new Vector3(-10465.17 , -1441.164 , 67.25961 , "None"));
Path.Add(new Vector3(-10473.87 , -1430.208 , 66.45821 , "None"));
Path.Add(new Vector3(-10484.38 , -1420.973 , 64.56174 , "None"));
Path.Add(new Vector3(-10495.72 , -1412.766 , 64.16556 , "None"));
Path.Add(new Vector3(-10507.32 , -1404.929 , 63.52863 , "None"));
Path.Add(new Vector3(-10519.23 , -1397.58 , 62.16619 , "None"));
Path.Add(new Vector3(-10529.18 , -1387.804 , 59.11444 , "None"));
Path.Add(new Vector3(-10536.68 , -1375.993 , 55.95689 , "None"));
Path.Add(new Vector3(-10542.25 , -1363.177 , 53.30524 , "None"));
Path.Add(new Vector3(-10544.91 , -1354.39 , 51.32645 , "None"));
Path.Add(new Vector3(-10543.78 , -1347.032 , 50.09692 , "None"));
Path.Add(new Vector3(-10543.77 , -1340.485 , 48.68515 , "None"));
Path.Add(new Vector3(-10546.12 , -1333.428 , 47.31665 , "None"));
Path.Add(new Vector3(-10549.95 , -1328.088 , 45.88357 , "None"));
Path.Add(new Vector3(-10559.5 , -1317.893 , 46.22679 , "None"));
Path.Add(new Vector3(-10567.7 , -1309.983 , 48.12704 , "None"));
Path.Add(new Vector3(-10571.63 , -1304.216 , 47.79294 , "None"));
Path.Add(new Vector3(-10576.52 , -1299.864 , 46.98676 , "None"));
Path.Add(new Vector3(-10582.94 , -1301.185 , 47.25165 , "None"));
Path.Add(new Vector3(-10596.77 , -1303.055 , 48.03793 , "None"));
Path.Add(new Vector3(-10606.43 , -1298.971 , 48.93068 , "None"));
Path.Add(new Vector3(-10615.54 , -1301.431 , 51.64338 , "None"));
Path.Add(new Vector3(-10619.59 , -1305.438 , 52.48167 , "None"));
Path.Add(new Vector3(-10621.77 , -1309.701 , 53.33997 , "None"));
Path.Add(new Vector3(-10626.6 , -1317.539 , 53.59409 , "None"));
Path.Add(new Vector3(-10629.4 , -1319.633 , 52.51736 , "None"));
Path.Add(new Vector3(-10640.82 , -1327.733 , 48.42774 , "None"));
Path.Add(new Vector3(-10651.19 , -1331.133 , 47.89729 , "None"));
Path.Add(new Vector3(-10663.11 , -1334.022 , 47.57439 , "None"));
Path.Add(new Vector3(-10674.01 , -1333.828 , 47.17602 , "None"));
Path.Add(new Vector3(-10680.63 , -1330.6 , 46.53294 , "None"));
Path.Add(new Vector3(-10683.11 , -1326.089 , 44.47202 , "None"));
Path.Add(new Vector3(-10685.35 , -1318.521 , 42.81417 , "None"));
Path.Add(new Vector3(-10687.73 , -1312.434 , 41.90765 , "None"));
Path.Add(new Vector3(-10691.72 , -1305.625 , 41.15594 , "None"));
Path.Add(new Vector3(-10696.52 , -1298.863 , 39.52489 , "None"));
Path.Add(new Vector3(-10704.69 , -1287.5 , 35.0293 , "None"));
Path.Add(new Vector3(-10712.87 , -1276.136 , 32.55043 , "None"));
Path.Add(new Vector3(-10716.21 , -1271.5 , 31.62249 , "None"));
Path.Add(new Vector3(-10720.94 , -1265.773 , 30.04888 , "None"));
Path.Add(new Vector3(-10731.62 , -1256.725 , 29.79586 , "None"));
Path.Add(new Vector3(-10741.9 , -1248.557 , 30.50115 , "None"));
Path.Add(new Vector3(-10752.14 , -1241.861 , 30.76899 , "None"));
Path.Add(new Vector3(-10764.82 , -1236.24 , 31.56597 , "None"));
Path.Add(new Vector3(-10769.55 , -1236.895 , 31.18473 , "None"));
Path.Add(new Vector3(-10775.7 , -1239.144 , 31.41772 , "None"));
Path.Add(new Vector3(-10785.79 , -1241.891 , 33.40311 , "None"));
Path.Add(new Vector3(-10793.23 , -1241.594 , 34.2551 , "None"));
Path.Add(new Vector3(-10806.29 , -1240.346 , 34.10823 , "None"));
Path.Add(new Vector3(-10820.14 , -1238.286 , 33.87834 , "None"));
Path.Add(new Vector3(-10834.01 , -1236.401 , 35.10547 , "None"));
Path.Add(new Vector3(-10848 , -1236.664 , 35.68762 , "None"));
Path.Add(new Vector3(-10861.9 , -1238.281 , 35.51206 , "None"));
Path.Add(new Vector3(-10875.8 , -1240.002 , 36.61869 , "None"));
Path.Add(new Vector3(-10889.67 , -1241.724 , 38.1423 , "None"));
Path.Add(new Vector3(-10903.52 , -1243.716 , 41.70126 , "None"));
Path.Add(new Vector3(-10917.19 , -1246.674 , 45.87835 , "None"));
Path.Add(new Vector3(-10930.51 , -1250.984 , 48.64611 , "None"));
Path.Add(new Vector3(-10943.34 , -1256.552 , 50.95235 , "None"));
Path.Add(new Vector3(-10955.04 , -1264.19 , 51.5952 , "None"));
Path.Add(new Vector3(-10966.27 , -1272.551 , 52.45756 , "None"));
Path.Add(new Vector3(-10969.4 , -1274.903 , 52.61997 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

        








public override bool HasQuest() { return true; }


}


public sealed class PathToArathiHighlands : QuestFollowPathClass
{
    public PathToArathiHighlands()
    {
        Name = "PathToArathiHighlands";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-2859.652 , -2261.731 , 33.66325 , "None"));
Path.Add(new Vector3(-2859.146 , -2269.927 , 34.18415 , "None"));
Path.Add(new Vector3(-2858.39 , -2280.399 , 34.52062 , "None"));
Path.Add(new Vector3(-2858.359 , -2290.861 , 37.39058 , "None"));
Path.Add(new Vector3(-2859.509 , -2301.296 , 37.94314 , "None"));
Path.Add(new Vector3(-2861.604 , -2311.584 , 36.21365 , "None"));
Path.Add(new Vector3(-2863.787 , -2321.854 , 35.16295 , "None"));
Path.Add(new Vector3(-2866.093 , -2332.097 , 35.3134 , "None"));
Path.Add(new Vector3(-2868.477 , -2342.323 , 36.55331 , "None"));
Path.Add(new Vector3(-2870.861 , -2352.549 , 37.08105 , "None"));
Path.Add(new Vector3(-2873.245 , -2362.775 , 37.04775 , "None"));
Path.Add(new Vector3(-2875.493 , -2373.031 , 37.95693 , "None"));
Path.Add(new Vector3(-2876.994 , -2383.406 , 38.88447 , "None"));
Path.Add(new Vector3(-2876.932 , -2393.884 , 39.53779 , "None"));
Path.Add(new Vector3(-2873.208 , -2403.573 , 42.35993 , "None"));
Path.Add(new Vector3(-2865.905 , -2411.116 , 45.48917 , "None"));
Path.Add(new Vector3(-2858.578 , -2418.637 , 47.98353 , "None"));
Path.Add(new Vector3(-2851.25 , -2426.158 , 50.71816 , "None"));
Path.Add(new Vector3(-2844.378 , -2433.213 , 53.30902 , "None"));
Path.Add(new Vector3(-2836.582 , -2441.183 , 56.00219 , "None"));
Path.Add(new Vector3(-2828.942 , -2448.866 , 57.07968 , "None"));
Path.Add(new Vector3(-2821.606 , -2455.902 , 58.30449 , "None"));
Path.Add(new Vector3(-2813.99 , -2463.129 , 61.60968 , "None"));
Path.Add(new Vector3(-2806.058 , -2470.511 , 62.64184 , "None"));
Path.Add(new Vector3(-2798.003 , -2476.703 , 63.90141 , "None"));
Path.Add(new Vector3(-2788.823 , -2482.434 , 65.06374 , "None"));
Path.Add(new Vector3(-2778.961 , -2485.96 , 65.78677 , "None"));
Path.Add(new Vector3(-2768.573 , -2487.425 , 67.13339 , "None"));
Path.Add(new Vector3(-2758.131 , -2488.529 , 67.99709 , "None"));
Path.Add(new Vector3(-2747.689 , -2489.634 , 66.7246 , "None"));
Path.Add(new Vector3(-2738.257 , -2490.864 , 68.57987 , "None"));
Path.Add(new Vector3(-2727.906 , -2492.625 , 68.26617 , "None"));
Path.Add(new Vector3(-2717.258 , -2494.515 , 68.63987 , "None"));
Path.Add(new Vector3(-2706.798 , -2495.134 , 70.38727 , "None"));
Path.Add(new Vector3(-2696.321 , -2494.45 , 73.30601 , "None"));
Path.Add(new Vector3(-2685.844 , -2493.742 , 77.19302 , "None"));
Path.Add(new Vector3(-2675.368 , -2493.034 , 77.92097 , "None"));
Path.Add(new Vector3(-2664.903 , -2492.197 , 78.08586 , "None"));
Path.Add(new Vector3(-2654.46 , -2491.101 , 78.55012 , "None"));
Path.Add(new Vector3(-2644.016 , -2490.019 , 79.13314 , "None"));
Path.Add(new Vector3(-2633.551 , -2489.18 , 79.46634 , "None"));
Path.Add(new Vector3(-2623.055 , -2488.901 , 79.46714 , "None"));
Path.Add(new Vector3(-2612.556 , -2489.015 , 79.71287 , "None"));
Path.Add(new Vector3(-2602.062 , -2489.355 , 79.65903 , "None"));
Path.Add(new Vector3(-2591.568 , -2489.698 , 80.20177 , "None"));
Path.Add(new Vector3(-2581.073 , -2490.042 , 80.66321 , "None"));
Path.Add(new Vector3(-2570.578 , -2490.303 , 81.33308 , "None"));
Path.Add(new Vector3(-2560.113 , -2489.495 , 81.43615 , "None"));
Path.Add(new Vector3(-2549.709 , -2488.078 , 81.56453 , "None"));
Path.Add(new Vector3(-2539.306 , -2486.653 , 81.44176 , "None"));
Path.Add(new Vector3(-2528.878 , -2485.443 , 81.74677 , "None"));
Path.Add(new Vector3(-2518.393 , -2485.042 , 81.57985 , "None"));
Path.Add(new Vector3(-2508.081 , -2486.857 , 81.03394 , "None"));
Path.Add(new Vector3(-2498.07 , -2490.016 , 80.00896 , "None"));
Path.Add(new Vector3(-2488.296 , -2493.852 , 79.17465 , "None"));
Path.Add(new Vector3(-2478.562 , -2497.787 , 78.49708 , "None"));
Path.Add(new Vector3(-2468.934 , -2501.12 , 78.50761 , "None"));
Path.Add(new Vector3(-2458.567 , -2502.744 , 78.50761 , "None"));
Path.Add(new Vector3(-2448.105 , -2503.637 , 78.50761 , "None"));
Path.Add(new Vector3(-2437.617 , -2504.123 , 79.24447 , "None"));
Path.Add(new Vector3(-2427.123 , -2504.476 , 81.25552 , "None"));
Path.Add(new Vector3(-2416.311 , -2505.073 , 83.32773 , "None"));
Path.Add(new Vector3(-2406.223 , -2506.318 , 85.26086 , "None"));
Path.Add(new Vector3(-2395.771 , -2507.314 , 87.26374 , "None"));
Path.Add(new Vector3(-2385.285 , -2506.955 , 88.34431 , "None"));
Path.Add(new Vector3(-2374.804 , -2506.329 , 88.34431 , "None"));
Path.Add(new Vector3(-2364.317 , -2505.808 , 88.34431 , "None"));
Path.Add(new Vector3(-2353.51 , -2506.457 , 88.34416 , "None"));
Path.Add(new Vector3(-2343.42 , -2507.684 , 86.55581 , "None"));
Path.Add(new Vector3(-2332.949 , -2508.333 , 84.547 , "None"));
Path.Add(new Vector3(-2322.449 , -2508.305 , 82.53443 , "None"));
Path.Add(new Vector3(-2311.952 , -2508.127 , 80.52275 , "None"));
Path.Add(new Vector3(-2301.141 , -2507.392 , 78.50782 , "None"));
Path.Add(new Vector3(-2291.004 , -2506.648 , 78.50782 , "None"));
Path.Add(new Vector3(-2280.283 , -2505.172 , 78.50782 , "None"));
Path.Add(new Vector3(-2270.685 , -2501.907 , 78.94363 , "None"));
Path.Add(new Vector3(-2261.608 , -2496.049 , 79.82346 , "None"));
Path.Add(new Vector3(-2254.599 , -2488.257 , 80.23889 , "None"));
Path.Add(new Vector3(-2249.025 , -2479.363 , 80.32466 , "None"));
Path.Add(new Vector3(-2243.637 , -2470.36 , 80.66026 , "None"));
Path.Add(new Vector3(-2237.707 , -2461.709 , 81.34653 , "None"));
Path.Add(new Vector3(-2229.614 , -2455.165 , 81.45539 , "None"));
Path.Add(new Vector3(-2219.469 , -2452.568 , 81.38422 , "None"));
Path.Add(new Vector3(-2209.038 , -2451.405 , 81.28956 , "None"));
Path.Add(new Vector3(-2198.548 , -2450.968 , 81.18479 , "None"));
Path.Add(new Vector3(-2188.051 , -2450.734 , 81.11266 , "None"));
Path.Add(new Vector3(-2177.553 , -2450.5 , 81.08517 , "None"));
Path.Add(new Vector3(-2167.056 , -2450.266 , 81.01465 , "None"));
Path.Add(new Vector3(-2156.557 , -2450.224 , 80.76507 , "None"));
Path.Add(new Vector3(-2146.057 , -2450.279 , 79.75138 , "None"));
Path.Add(new Vector3(-2135.557 , -2450.334 , 78.72708 , "None"));
Path.Add(new Vector3(-2125.058 , -2450.417 , 77.73043 , "None"));
Path.Add(new Vector3(-2114.56 , -2450.616 , 81.3527 , "None"));
Path.Add(new Vector3(-2104.062 , -2450.826 , 80.90507 , "None"));
Path.Add(new Vector3(-2093.584 , -2451.502 , 75.87478 , "None"));
Path.Add(new Vector3(-2083.157 , -2452.713 , 73.94514 , "None"));
Path.Add(new Vector3(-2072.846 , -2454.692 , 74.53935 , "None"));
Path.Add(new Vector3(-2062.555 , -2456.774 , 75.19177 , "None"));
Path.Add(new Vector3(-2052.271 , -2458.854 , 75.90596 , "None"));
Path.Add(new Vector3(-2041.979 , -2460.936 , 76.55869 , "None"));
Path.Add(new Vector3(-2031.688 , -2463.018 , 77.22803 , "None"));
Path.Add(new Vector3(-2021.396 , -2465.098 , 77.90677 , "None"));
Path.Add(new Vector3(-2011.003 , -2466.538 , 78.86685 , "None"));
Path.Add(new Vector3(-2000.52 , -2466.908 , 78.96262 , "None"));
Path.Add(new Vector3(-1990.063 , -2465.998 , 78.61121 , "None"));
Path.Add(new Vector3(-1979.713 , -2464.238 , 78.23321 , "None"));
Path.Add(new Vector3(-1969.518 , -2461.743 , 77.43407 , "None"));
Path.Add(new Vector3(-1960.706 , -2459.112 , 76.32767 , "None"));
Path.Add(new Vector3(-1948.267 , -2454.925 , 73.56818 , "None"));
Path.Add(new Vector3(-1939.549 , -2451.991 , 71.27936 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

        








public override bool HasQuest() { return true; }


}


public sealed class PathToStromgarde : QuestFollowPathClass
{
    public PathToStromgarde()
    {
        Name = "PathToStromgarde";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-2825.813 , -2280.14 , 44.67561 , "None"));
Path.Add(new Vector3(-2819.667 , -2289.447 , 47.63619 , "None"));
Path.Add(new Vector3(-2812.501 , -2301.446 , 51.61691 , "None"));
Path.Add(new Vector3(-2806.669 , -2314.172 , 52.41652 , "None"));
Path.Add(new Vector3(-2801.314 , -2327.106 , 56.33899 , "None"));
Path.Add(new Vector3(-2797.37 , -2340.529 , 60.14451 , "None"));
Path.Add(new Vector3(-2796.142 , -2354.416 , 62.55835 , "None"));
Path.Add(new Vector3(-2801.112 , -2367.43 , 64.52229 , "None"));
Path.Add(new Vector3(-2807.599 , -2379.833 , 62.97766 , "None"));
Path.Add(new Vector3(-2811.306 , -2393.253 , 62.83635 , "None"));
Path.Add(new Vector3(-2811.927 , -2407.232 , 63.11789 , "None"));
Path.Add(new Vector3(-2811.204 , -2421.208 , 63.4779 , "None"));
Path.Add(new Vector3(-2809.658 , -2435.12 , 63.54213 , "None"));
Path.Add(new Vector3(-2807.474 , -2448.947 , 62.96262 , "None"));
Path.Add(new Vector3(-2804.103 , -2462.518 , 63.43484 , "None"));
Path.Add(new Vector3(-2797.508 , -2474.782 , 64.13652 , "None"));
Path.Add(new Vector3(-2785.95 , -2481.441 , 65.74718 , "None"));
Path.Add(new Vector3(-2771.476 , -2483.659 , 67.5223 , "None"));
Path.Add(new Vector3(-2757.631 , -2485.733 , 68.71021 , "None"));
Path.Add(new Vector3(-2743.85 , -2488.178 , 68.31639 , "None"));
Path.Add(new Vector3(-2730.248 , -2491.492 , 68.74201 , "None"));
Path.Add(new Vector3(-2716.907 , -2493.879 , 68.74174 , "None"));
Path.Add(new Vector3(-2702.974 , -2493.268 , 71.21272 , "None"));
Path.Add(new Vector3(-2689.129 , -2491.187 , 75.41806 , "None"));
Path.Add(new Vector3(-2675.257 , -2489.299 , 77.11295 , "None"));
Path.Add(new Vector3(-2661.332 , -2487.86 , 78.21085 , "None"));
Path.Add(new Vector3(-2647.39 , -2486.59 , 79.19658 , "None"));
Path.Add(new Vector3(-2633.448 , -2485.319 , 79.33443 , "None"));
Path.Add(new Vector3(-2619.509 , -2484.012 , 79.33083 , "None"));
Path.Add(new Vector3(-2605.591 , -2482.496 , 79.37234 , "None"));
Path.Add(new Vector3(-2591.674 , -2480.979 , 81.53839 , "None"));
Path.Add(new Vector3(-2577.752 , -2479.498 , 83.14861 , "None"));
Path.Add(new Vector3(-2563.785 , -2479.774 , 82.0929 , "None"));
Path.Add(new Vector3(-2549.935 , -2481.797 , 81.48154 , "None"));
Path.Add(new Vector3(-2536.186 , -2484.433 , 81.42238 , "None"));
Path.Add(new Vector3(-2522.458 , -2487.156 , 82.05205 , "None"));
Path.Add(new Vector3(-2508.725 , -2489.88 , 82.05789 , "None"));
Path.Add(new Vector3(-2495.056 , -2492.887 , 79.88729 , "None"));
Path.Add(new Vector3(-2481.46 , -2496.228 , 78.69193 , "None"));
Path.Add(new Vector3(-2467.745 , -2498.992 , 78.50737 , "None"));
Path.Add(new Vector3(-2453.831 , -2500.521 , 78.50737 , "None"));
Path.Add(new Vector3(-2439.895 , -2501.856 , 78.80822 , "None"));
Path.Add(new Vector3(-2425.6 , -2503.831 , 81.54758 , "None"));
Path.Add(new Vector3(-2412.204 , -2505.972 , 84.11472 , "None"));
Path.Add(new Vector3(-2398.103 , -2507.793 , 86.81693 , "None"));
Path.Add(new Vector3(-2384.133 , -2507.131 , 88.34412 , "None"));
Path.Add(new Vector3(-2370.209 , -2505.674 , 88.34412 , "None"));
Path.Add(new Vector3(-2356.262 , -2504.46 , 88.34412 , "None"));
Path.Add(new Vector3(-2342.276 , -2503.822 , 86.33537 , "None"));
Path.Add(new Vector3(-2328.313 , -2502.819 , 83.658 , "None"));
Path.Add(new Vector3(-2314.354 , -2501.739 , 80.9832 , "None"));
Path.Add(new Vector3(-2300.389 , -2500.753 , 78.50723 , "None"));
Path.Add(new Vector3(-2286.419 , -2499.839 , 78.50723 , "None"));
Path.Add(new Vector3(-2272.471 , -2498.656 , 78.7177 , "None"));
Path.Add(new Vector3(-2259.496 , -2493.864 , 79.98032 , "None"));
Path.Add(new Vector3(-2251.111 , -2482.78 , 80.2989 , "None"));
Path.Add(new Vector3(-2244.086 , -2470.67 , 80.63091 , "None"));
Path.Add(new Vector3(-2236.342 , -2459.033 , 81.44456 , "None"));
Path.Add(new Vector3(-2224.558 , -2451.812 , 81.39593 , "None"));
Path.Add(new Vector3(-2210.698 , -2450.013 , 81.2693 , "None"));
Path.Add(new Vector3(-2196.706 , -2450.316 , 81.15414 , "None"));
Path.Add(new Vector3(-2182.71 , -2450.666 , 81.11246 , "None"));
Path.Add(new Vector3(-2168.712 , -2450.906 , 81.02122 , "None"));
Path.Add(new Vector3(-2154.715 , -2451.146 , 80.55608 , "None"));
Path.Add(new Vector3(-2140.717 , -2451.386 , 79.1655 , "None"));
Path.Add(new Vector3(-2126.719 , -2451.625 , 77.74699 , "None"));
Path.Add(new Vector3(-2112.721 , -2451.865 , 81.39869 , "None"));
Path.Add(new Vector3(-2098.513 , -2452.109 , 79.17031 , "None"));
Path.Add(new Vector3(-2091.724 , -2452.225 , 74.48678 , "None"));
Path.Add(new Vector3(-2078.015 , -2453.438 , 74.06662 , "None"));
Path.Add(new Vector3(-2063.812 , -2456.008 , 75.09708 , "None"));
Path.Add(new Vector3(-2050.677 , -2458.427 , 75.99834 , "None"));
Path.Add(new Vector3(-2036.847 , -2461.613 , 77.01101 , "None"));
Path.Add(new Vector3(-2023.421 , -2465.582 , 77.82594 , "None"));
Path.Add(new Vector3(-2009.717 , -2468.369 , 79.00043 , "None"));
Path.Add(new Vector3(-1995.751 , -2468.497 , 78.81271 , "None"));
Path.Add(new Vector3(-1982.032 , -2465.761 , 78.28117 , "None"));
Path.Add(new Vector3(-1968.593 , -2461.868 , 77.34307 , "None"));
Path.Add(new Vector3(-1955.604 , -2456.648 , 75.41245 , "None"));
Path.Add(new Vector3(-1942.688 , -2451.246 , 71.98093 , "None"));
Path.Add(new Vector3(-1929.81 , -2445.755 , 69.06387 , "None"));
Path.Add(new Vector3(-1916.932 , -2440.264 , 66.17243 , "None"));
Path.Add(new Vector3(-1904.124 , -2434.612 , 63.71983 , "None"));
Path.Add(new Vector3(-1891.544 , -2428.47 , 61.73648 , "None"));
Path.Add(new Vector3(-1879.012 , -2422.23 , 60.6854 , "None"));
Path.Add(new Vector3(-1866.479 , -2415.99 , 59.62807 , "None"));
Path.Add(new Vector3(-1853.743 , -2410.193 , 58.70419 , "None"));
Path.Add(new Vector3(-1840.421 , -2405.921 , 57.42372 , "None"));
Path.Add(new Vector3(-1826.54 , -2404.458 , 56.1861 , "None"));
Path.Add(new Vector3(-1812.689 , -2406.329 , 55.67184 , "None"));
Path.Add(new Vector3(-1799.179 , -2409.996 , 56.06924 , "None"));
Path.Add(new Vector3(-1785.696 , -2413.762 , 57.61055 , "None"));
Path.Add(new Vector3(-1772.212 , -2417.531 , 58.53938 , "None"));
Path.Add(new Vector3(-1758.869 , -2421.753 , 60.28941 , "None"));
Path.Add(new Vector3(-1745.49 , -2426.582 , 61.08049 , "None"));
Path.Add(new Vector3(-1732.439 , -2431.575 , 61.91495 , "None"));
Path.Add(new Vector3(-1719.614 , -2437.154 , 62.9474 , "None"));
Path.Add(new Vector3(-1706.974 , -2443.173 , 63.46378 , "None"));
Path.Add(new Vector3(-1694.339 , -2449.201 , 63.30455 , "None"));
Path.Add(new Vector3(-1681.713 , -2455.25 , 63.30455 , "None"));
Path.Add(new Vector3(-1669.298 , -2461.721 , 63.39934 , "None"));
Path.Add(new Vector3(-1656.856 , -2468.138 , 63.53889 , "None"));
Path.Add(new Vector3(-1644.248 , -2474.225 , 63.48721 , "None"));
Path.Add(new Vector3(-1631.475 , -2479.955 , 63.34853 , "None"));
Path.Add(new Vector3(-1618.61 , -2485.476 , 62.47861 , "None"));
Path.Add(new Vector3(-1605.437 , -2490.208 , 60.48891 , "None"));
Path.Add(new Vector3(-1591.981 , -2494.058 , 59.07396 , "None"));
Path.Add(new Vector3(-1578.189 , -2496.417 , 57.14332 , "None"));
Path.Add(new Vector3(-1564.214 , -2496.918 , 55.65621 , "None"));
Path.Add(new Vector3(-1550.442 , -2494.655 , 54.56956 , "None"));
Path.Add(new Vector3(-1538.14 , -2488.031 , 53.6134 , "None"));
Path.Add(new Vector3(-1526.725 , -2479.937 , 53.42015 , "None"));
Path.Add(new Vector3(-1515.82 , -2471.157 , 53.21114 , "None"));
Path.Add(new Vector3(-1504.95 , -2462.334 , 52.99829 , "None"));
Path.Add(new Vector3(-1494.081 , -2453.51 , 53.28585 , "None"));
Path.Add(new Vector3(-1483.219 , -2444.678 , 54.88689 , "None"));
Path.Add(new Vector3(-1472.928 , -2435.193 , 56.52254 , "None"));
Path.Add(new Vector3(-1463.64 , -2424.732 , 58.02515 , "None"));
Path.Add(new Vector3(-1456.617 , -2412.437 , 59.69966 , "None"));
Path.Add(new Vector3(-1453.479 , -2399.271 , 60.88999 , "None"));
Path.Add(new Vector3(-1452.316 , -2385.321 , 61.35239 , "None"));
Path.Add(new Vector3(-1451.647 , -2371.548 , 61.46235 , "None"));
Path.Add(new Vector3(-1450.957 , -2357.354 , 61.54702 , "None"));
Path.Add(new Vector3(-1450.246 , -2343.373 , 61.62497 , "None"));
Path.Add(new Vector3(-1449.043 , -2329.425 , 61.70598 , "None"));
Path.Add(new Vector3(-1447.759 , -2315.484 , 61.79409 , "None"));
Path.Add(new Vector3(-1446.165 , -2301.575 , 61.91788 , "None"));
Path.Add(new Vector3(-1443.09 , -2287.94 , 62.30642 , "None"));
Path.Add(new Vector3(-1437.558 , -2275.093 , 62.94284 , "None"));
Path.Add(new Vector3(-1430.687 , -2262.897 , 63.30102 , "None"));
Path.Add(new Vector3(-1423.639 , -2250.801 , 63.59768 , "None"));
Path.Add(new Vector3(-1416.959 , -2238.5 , 63.75105 , "None"));
Path.Add(new Vector3(-1410.989 , -2225.838 , 63.80105 , "None"));
Path.Add(new Vector3(-1405.869 , -2212.811 , 63.83661 , "None"));
Path.Add(new Vector3(-1401.879 , -2199.394 , 63.87181 , "None"));
Path.Add(new Vector3(-1398.633 , -2185.778 , 63.94614 , "None"));
Path.Add(new Vector3(-1395.835 , -2172.062 , 64.03139 , "None"));
Path.Add(new Vector3(-1393.464 , -2158.272 , 64.11134 , "None"));
Path.Add(new Vector3(-1391.158 , -2144.463 , 64.21835 , "None"));
Path.Add(new Vector3(-1389.004 , -2130.642 , 64.30102 , "None"));
Path.Add(new Vector3(-1387.43 , -2116.732 , 64.3931 , "None"));
Path.Add(new Vector3(-1386.188 , -2102.788 , 63.95219 , "None"));
Path.Add(new Vector3(-1385.125 , -2088.828 , 63.34343 , "None"));
Path.Add(new Vector3(-1384.044 , -2074.645 , 62.62963 , "None"));
Path.Add(new Vector3(-1382.948 , -2060.253 , 62.02136 , "None"));
Path.Add(new Vector3(-1381.917 , -2046.726 , 61.42912 , "None"));
Path.Add(new Vector3(-1380.853 , -2032.767 , 60.8229 , "None"));
Path.Add(new Vector3(-1379.79 , -2018.807 , 60.22066 , "None"));
Path.Add(new Vector3(-1378.726 , -2004.848 , 59.47509 , "None"));
Path.Add(new Vector3(-1377.166 , -1990.938 , 58.86492 , "None"));
Path.Add(new Vector3(-1374.284 , -1977.253 , 58.52798 , "None"));
Path.Add(new Vector3(-1369.809 , -1963.991 , 58.47888 , "None"));
Path.Add(new Vector3(-1364.945 , -1950.863 , 58.45677 , "None"));
Path.Add(new Vector3(-1360.08 , -1937.735 , 58.40742 , "None"));
Path.Add(new Vector3(-1355.202 , -1924.613 , 58.37688 , "None"));
Path.Add(new Vector3(-1350.183 , -1911.543 , 58.41954 , "None"));
Path.Add(new Vector3(-1345.164 , -1898.474 , 59.02239 , "None"));
Path.Add(new Vector3(-1340.146 , -1885.404 , 60.045 , "None"));
Path.Add(new Vector3(-1335.157 , -1872.332 , 61.07542 , "None"));
Path.Add(new Vector3(-1331.622 , -1858.837 , 61.98339 , "None"));
Path.Add(new Vector3(-1335.561 , -1845.935 , 62.14365 , "None"));
Path.Add(new Vector3(-1347.614 , -1838.939 , 61.13086 , "None"));
Path.Add(new Vector3(-1360.297 , -1833.01 , 60.28428 , "None"));
Path.Add(new Vector3(-1373.006 , -1827.141 , 59.21026 , "None"));
Path.Add(new Vector3(-1385.873 , -1821.623 , 58.69799 , "None"));
Path.Add(new Vector3(-1398.767 , -1816.171 , 59.21353 , "None"));
Path.Add(new Vector3(-1412.026 , -1811.067 , 60.33992 , "None"));
Path.Add(new Vector3(-1425.251 , -1806.477 , 60.80526 , "None"));
Path.Add(new Vector3(-1438.138 , -1803.017 , 61.75116 , "None"));
Path.Add(new Vector3(-1445.728 , -1802.16 , 63.05574 , "None"));
Path.Add(new Vector3(-1459.068 , -1802.442 , 67.0513 , "None"));
Path.Add(new Vector3(-1473.184 , -1804.08 , 68.02084 , "None"));
Path.Add(new Vector3(-1487.146 , -1805.052 , 68.07496 , "None"));
Path.Add(new Vector3(-1501.126 , -1805.615 , 67.93165 , "None"));
Path.Add(new Vector3(-1515.126 , -1805.588 , 66.01373 , "None"));
Path.Add(new Vector3(-1529.125 , -1805.509 , 65.92139 , "None"));
Path.Add(new Vector3(-1543.125 , -1805.402 , 66.80713 , "None"));
Path.Add(new Vector3(-1557.083 , -1804.618 , 67.48686 , "None"));
Path.Add(new Vector3(-1568.703 , -1797.547 , 67.40915 , "None"));
Path.Add(new Vector3(-1573.838 , -1784.586 , 67.17627 , "None"));
Path.Add(new Vector3(-1577.778 , -1771.164 , 67.40095 , "None"));
Path.Add(new Vector3(-1581.426 , -1757.647 , 66.64188 , "None"));
Path.Add(new Vector3(-1584.924 , -1744.093 , 66.84241 , "None"));
Path.Add(new Vector3(-1586.345 , -1730.176 , 67.45988 , "None"));
Path.Add(new Vector3(-1585.949 , -1716.191 , 67.14865 , "None"));
Path.Add(new Vector3(-1583.264 , -1702.511 , 66.45325 , "None"));
Path.Add(new Vector3(-1572.792 , -1695.072 , 66.05949 , "None"));
Path.Add(new Vector3(-1559.656 , -1699.562 , 66.31269 , "None"));
Path.Add(new Vector3(-1547.781 , -1706.965 , 66.21711 , "None"));
Path.Add(new Vector3(-1537.083 , -1715.798 , 66.37109 , "None"));
Path.Add(new Vector3(-1530.237 , -1727.856 , 66.14631 , "None"));
Path.Add(new Vector3(-1527.626 , -1741.543 , 66.83067 , "None"));
Path.Add(new Vector3(-1527.935 , -1755.526 , 66.92046 , "None"));
Path.Add(new Vector3(-1527.946 , -1769.749 , 67.53851 , "None"));
Path.Add(new Vector3(-1528.076 , -1783.749 , 68.34061 , "None"));
Path.Add(new Vector3(-1528.202 , -1797.311 , 70.99393 , "None"));
Path.Add(new Vector3(-1528.332 , -1811.311 , 71.19363 , "None"));
Path.Add(new Vector3(-1528.462 , -1825.305 , 68.34039 , "None"));
Path.Add(new Vector3(-1528.579 , -1837.988 , 67.93433 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

        








public override bool HasQuest() { return true; }


}


public sealed class PathTranquilGardensToWitchHill : QuestFollowPathClass
{
    public PathTranquilGardensToWitchHill()
    {
        Name = "PathTranquilGardensToWitchHill";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-10969.4 , -1274.903 , 52.61997 , "None"));
Path.Add(new Vector3(-10959.41 , -1269.423 , 51.94542 , "None"));
Path.Add(new Vector3(-10946.69 , -1263.568 , 51.14415 , "None"));
Path.Add(new Vector3(-10934.09 , -1257.485 , 50.47977 , "None"));
Path.Add(new Vector3(-10930.77 , -1255.398 , 49.62144 , "None"));
Path.Add(new Vector3(-10922.4 , -1249.779 , 47.44185 , "None"));
Path.Add(new Vector3(-10906.62 , -1244.793 , 42.58665 , "None"));
Path.Add(new Vector3(-10892.9 , -1242.012 , 38.75978 , "None"));
Path.Add(new Vector3(-10879.18 , -1239.235 , 37.29835 , "None"));
Path.Add(new Vector3(-10865.76 , -1235.411 , 36.79888 , "None"));
Path.Add(new Vector3(-10856.6 , -1231.274 , 36.69265 , "None"));
Path.Add(new Vector3(-10844.21 , -1224.82 , 37.80376 , "None"));
Path.Add(new Vector3(-10832.87 , -1216.62 , 39.18159 , "None"));
Path.Add(new Vector3(-10825.6 , -1210.341 , 39.22149 , "None"));
Path.Add(new Vector3(-10820.84 , -1202.487 , 38.49442 , "None"));
Path.Add(new Vector3(-10814.26 , -1190.143 , 35.90007 , "None"));
Path.Add(new Vector3(-10808.45 , -1177.404 , 33.26373 , "None"));
Path.Add(new Vector3(-10803.13 , -1164.453 , 32.38728 , "None"));
Path.Add(new Vector3(-10797.93 , -1151.455 , 28.52408 , "None"));
Path.Add(new Vector3(-10793.76 , -1138.114 , 27.13336 , "None"));
Path.Add(new Vector3(-10791.12 , -1124.366 , 26.65032 , "None"));
Path.Add(new Vector3(-10788.95 , -1110.537 , 30.07421 , "None"));
Path.Add(new Vector3(-10787.73 , -1096.178 , 33.50483 , "None"));
Path.Add(new Vector3(-10788.59 , -1082.637 , 35.93988 , "None"));
Path.Add(new Vector3(-10791.45 , -1068.954 , 38.94182 , "None"));
Path.Add(new Vector3(-10795.5 , -1055.116 , 42.24165 , "None"));
Path.Add(new Vector3(-10799.87 , -1041.816 , 45.02034 , "None"));
Path.Add(new Vector3(-10803.31 , -1029.618 , 47.16801 , "None"));
Path.Add(new Vector3(-10805.08 , -1015.741 , 49.97972 , "None"));
Path.Add(new Vector3(-10806.1 , -1000.459 , 52.46423 , "None"));
Path.Add(new Vector3(-10806.5 , -986.4707 , 54.75355 , "None"));
Path.Add(new Vector3(-10804.83 , -973.4672 , 55.97716 , "None"));
Path.Add(new Vector3(-10801.17 , -959.0582 , 56.23895 , "None"));
Path.Add(new Vector3(-10797.98 , -945.4316 , 56.5718 , "None"));
Path.Add(new Vector3(-10796.16 , -932.4291 , 56.10737 , "None"));
Path.Add(new Vector3(-10796.42 , -917.5916 , 55.77111 , "None"));
Path.Add(new Vector3(-10799.15 , -904.7603 , 56.12677 , "None"));
Path.Add(new Vector3(-10802.94 , -891.2838 , 55.71952 , "None"));
Path.Add(new Vector3(-10806.81 , -877.8286 , 55.78865 , "None"));
Path.Add(new Vector3(-10811.91 , -863.8668 , 55.89487 , "None"));
Path.Add(new Vector3(-10816.99 , -851.7587 , 55.82015 , "None"));
Path.Add(new Vector3(-10822.84 , -839.0413 , 55.80517 , "None"));
Path.Add(new Vector3(-10829.06 , -825.5354 , 55.64845 , "None"));
Path.Add(new Vector3(-10834.57 , -813.6321 , 56.29857 , "None"));
Path.Add(new Vector3(-10841.59 , -801.5275 , 56.2333 , "None"));
Path.Add(new Vector3(-10849.59 , -790.055 , 56.08099 , "None"));
Path.Add(new Vector3(-10858.95 , -779.646 , 56.09438 , "None"));
Path.Add(new Vector3(-10868.5 , -769.4044 , 55.59824 , "None"));
Path.Add(new Vector3(-10878.42 , -759.5309 , 55.56905 , "None"));
Path.Add(new Vector3(-10888.34 , -749.6489 , 55.42933 , "None"));
Path.Add(new Vector3(-10897.89 , -739.4259 , 55.34035 , "None"));
Path.Add(new Vector3(-10905.93 , -727.965 , 54.84474 , "None"));
Path.Add(new Vector3(-10913.2 , -716.0066 , 55.18702 , "None"));
Path.Add(new Vector3(-10920.18 , -703.8691 , 55.68905 , "None"));
Path.Add(new Vector3(-10927.03 , -691.6606 , 55.59989 , "None"));
Path.Add(new Vector3(-10934.29 , -679.7096 , 55.52721 , "None"));
Path.Add(new Vector3(-10942.9 , -668.6649 , 55.74879 , "None"));
Path.Add(new Vector3(-10951.11 , -657.3459 , 55.34469 , "None"));
Path.Add(new Vector3(-10956.57 , -644.4903 , 55.1225 , "None"));
Path.Add(new Vector3(-10958.12 , -630.6301 , 55.12992 , "None"));
Path.Add(new Vector3(-10956.72 , -616.726 , 54.98449 , "None"));
Path.Add(new Vector3(-10952.25 , -603.502 , 55.28158 , "None"));
Path.Add(new Vector3(-10945.12 , -591.4609 , 54.68903 , "None"));
Path.Add(new Vector3(-10937.11 , -579.9805 , 53.86988 , "None"));
Path.Add(new Vector3(-10929.09 , -568.5066 , 54.16261 , "None"));
Path.Add(new Vector3(-10923.03 , -555.9086 , 53.93018 , "None"));
Path.Add(new Vector3(-10917.99 , -542.8665 , 53.91078 , "None"));
Path.Add(new Vector3(-10914.92 , -529.2101 , 53.8296 , "None"));
Path.Add(new Vector3(-10912.03 , -515.5126 , 52.80671 , "None"));
Path.Add(new Vector3(-10909.96 , -501.6687 , 51.3997 , "None"));
Path.Add(new Vector3(-10908.87 , -487.7137 , 49.72508 , "None"));
Path.Add(new Vector3(-10907.98 , -473.7418 , 47.84707 , "None"));
Path.Add(new Vector3(-10907.09 , -459.77 , 46.34694 , "None"));
Path.Add(new Vector3(-10906.21 , -445.7977 , 43.98807 , "None"));
Path.Add(new Vector3(-10905.4 , -431.8212 , 42.72616 , "None"));
Path.Add(new Vector3(-10904.62 , -417.8428 , 41.99437 , "None"));
Path.Add(new Vector3(-10903.85 , -403.8644 , 41.2024 , "None"));
Path.Add(new Vector3(-10902.38 , -389.9548 , 40.85693 , "None"));
Path.Add(new Vector3(-10899.5 , -376.2538 , 39.99209 , "None"));
Path.Add(new Vector3(-10895.88 , -362.2826 , 39.01939 , "None"));
Path.Add(new Vector3(-10890.93 , -349.1851 , 39.20688 , "None"));
Path.Add(new Vector3(-10885.41 , -336.3218 , 38.28898 , "None"));
Path.Add(new Vector3(-10879.65 , -323.5655 , 37.81094 , "None"));
Path.Add(new Vector3(-10873.88 , -310.8091 , 38.13797 , "None"));
Path.Add(new Vector3(-10868.38 , -297.9362 , 37.86411 , "None"));
Path.Add(new Vector3(-10864.29 , -284.5548 , 38.13663 , "None"));
Path.Add(new Vector3(-10860.58 , -271.0531 , 38.32185 , "None"));
Path.Add(new Vector3(-10856.99 , -257.5243 , 38.08074 , "None"));
Path.Add(new Vector3(-10853.77 , -243.8979 , 38.60611 , "None"));
Path.Add(new Vector3(-10850.87 , -230.2033 , 38.7186 , "None"));
Path.Add(new Vector3(-10847.95 , -216.5117 , 37.85178 , "None"));
Path.Add(new Vector3(-10844.65 , -202.9064 , 36.46262 , "None"));
Path.Add(new Vector3(-10841.26 , -189.3213 , 35.13636 , "None"));
Path.Add(new Vector3(-10837.88 , -175.7361 , 33.99261 , "None"));
Path.Add(new Vector3(-10834.41 , -162.1733 , 33.59708 , "None"));
Path.Add(new Vector3(-10830.49 , -148.7359 , 31.7848 , "None"));
Path.Add(new Vector3(-10825.98 , -135.4812 , 31.77402 , "None"));
Path.Add(new Vector3(-10821.28 , -122.2931 , 30.30672 , "None"));
Path.Add(new Vector3(-10816.59 , -109.1049 , 29.82942 , "None"));
Path.Add(new Vector3(-10811.89 , -95.91676 , 29.21787 , "None"));
Path.Add(new Vector3(-10807.19 , -82.72861 , 29.35608 , "None"));
Path.Add(new Vector3(-10802.49 , -69.54047 , 29.20164 , "None"));
Path.Add(new Vector3(-10797.93 , -56.30632 , 29.11734 , "None"));
Path.Add(new Vector3(-10793.62 , -42.98611 , 29.51296 , "None"));
Path.Add(new Vector3(-10789.33 , -29.65689 , 29.41846 , "None"));
Path.Add(new Vector3(-10785.07 , -16.32142 , 29.68903 , "None"));
Path.Add(new Vector3(-10781 , -2.926597 , 29.86701 , "None"));
Path.Add(new Vector3(-10776.56 , 10.34709 , 29.15405 , "None"));
Path.Add(new Vector3(-10771.61 , 23.44045 , 28.87199 , "None"));
Path.Add(new Vector3(-10766.68 , 36.5435 , 28.23023 , "None"));
Path.Add(new Vector3(-10761.91 , 49.70783 , 28.19634 , "None"));
Path.Add(new Vector3(-10757.51 , 62.97068 , 28.65335 , "None"));
Path.Add(new Vector3(-10754.25 , 76.57466 , 28.38924 , "None"));
Path.Add(new Vector3(-10752.3 , 90.43161 , 28.52304 , "None"));
Path.Add(new Vector3(-10751.54 , 104.4084 , 28.41058 , "None"));
Path.Add(new Vector3(-10751.93 , 118.3981 , 28.65638 , "None"));
Path.Add(new Vector3(-10754.46 , 132.1248 , 28.65724 , "None"));
Path.Add(new Vector3(-10760.22 , 144.8518 , 29.46858 , "None"));
Path.Add(new Vector3(-10766.42 , 157.4035 , 29.53873 , "None"));
Path.Add(new Vector3(-10772.62 , 169.9552 , 29.65094 , "None"));
Path.Add(new Vector3(-10778.51 , 182.6528 , 29.91026 , "None"));
Path.Add(new Vector3(-10783.58 , 195.6989 , 30.35866 , "None"));
Path.Add(new Vector3(-10787.91 , 208.9909 , 30.62958 , "None"));
Path.Add(new Vector3(-10791.51 , 222.5157 , 30.37782 , "None"));
Path.Add(new Vector3(-10794.18 , 236.2585 , 30.48023 , "None"));
Path.Add(new Vector3(-10796.87 , 250.4246 , 30.48659 , "None"));
Path.Add(new Vector3(-10799.57 , 264.1631 , 30.48087 , "None"));
Path.Add(new Vector3(-10802.03 , 276.6048 , 30.55902 , "None"));
Path.Add(new Vector3(-10803.84 , 291.7603 , 31.05604 , "None"));
Path.Add(new Vector3(-10801.25 , 304.5421 , 31.59523 , "None"));
Path.Add(new Vector3(-10799.13 , 308.3403 , 32.0034 , "None"));
Path.Add(new Vector3(-10793.51 , 309.1432 , 33.11192 , "None"));
Path.Add(new Vector3(-10780.38 , 309.5071 , 35.33385 , "None"));
Path.Add(new Vector3(-10768.16 , 308.6327 , 36.61969 , "None"));
Path.Add(new Vector3(-10754.78 , 304.8637 , 38.66055 , "None"));
Path.Add(new Vector3(-10743.06 , 293.2189 , 40.10176 , "None"));
Path.Add(new Vector3(-10737.72 , 286.8469 , 40.57726 , "None"));
Path.Add(new Vector3(-10731.62 , 282.6003 , 41.09513 , "None"));
Path.Add(new Vector3(-10720.38 , 281.5225 , 41.8022 , "None"));
Path.Add(new Vector3(-10706.47 , 283.0054 , 40.80471 , "None"));
Path.Add(new Vector3(-10692.57 , 284.6364 , 40.29446 , "None"));
Path.Add(new Vector3(-10686.92 , 284.0974 , 40.26571 , "None"));
Path.Add(new Vector3(-10677.92 , 282.3005 , 39.92421 , "None"));
Path.Add(new Vector3(-10664.1 , 280.1978 , 40.11538 , "None"));
Path.Add(new Vector3(-10658.42 , 280.1768 , 40.43036 , "None"));
Path.Add(new Vector3(-10645.08 , 284.0156 , 38.74414 , "None"));
Path.Add(new Vector3(-10632.34 , 289.8195 , 35.42305 , "None"));
Path.Add(new Vector3(-10619.05 , 294.0429 , 32.78038 , "None"));
Path.Add(new Vector3(-10605.11 , 295.1922 , 31.81615 , "None"));
Path.Add(new Vector3(-10591.11 , 295.5689 , 31.19666 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

        








public override bool HasQuest() { return true; }


}


public sealed class PathWitchHillToStonardFP : QuestFollowPathClass
{
    public PathWitchHillToStonardFP()
    {
        Name = "PathWitchHillToStonardFP";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-10583.55 , 311.2133 , 29.93674 , "None"));
Path.Add(new Vector3(-10595.19 , 314.2639 , 31.31096 , "None"));
Path.Add(new Vector3(-10602.06 , 315.0548 , 32.61116 , "None"));
Path.Add(new Vector3(-10608.87 , 313.4622 , 33.1628 , "None"));
Path.Add(new Vector3(-10615.29 , 310.6913 , 34.11583 , "None"));
Path.Add(new Vector3(-10621.39 , 307.2708 , 33.83844 , "None"));
Path.Add(new Vector3(-10627.41 , 303.7183 , 34.33669 , "None"));
Path.Add(new Vector3(-10633.62 , 300.0539 , 35.96313 , "None"));
Path.Add(new Vector3(-10645.5 , 293.0811 , 38.15468 , "None"));
Path.Add(new Vector3(-10651.77 , 289.9552 , 40.28091 , "None"));
Path.Add(new Vector3(-10658.42 , 287.8364 , 40.97777 , "None"));
Path.Add(new Vector3(-10665.36 , 286.9381 , 40.25232 , "None"));
Path.Add(new Vector3(-10672.33 , 286.2858 , 39.50333 , "None"));
Path.Add(new Vector3(-10679.51 , 285.614 , 39.68889 , "None"));
Path.Add(new Vector3(-10686.48 , 284.9618 , 40.15549 , "None"));
Path.Add(new Vector3(-10693.45 , 284.3095 , 40.32672 , "None"));
Path.Add(new Vector3(-10700.42 , 283.6556 , 40.42468 , "None"));
Path.Add(new Vector3(-10707.38 , 282.9044 , 40.88485 , "None"));
Path.Add(new Vector3(-10714.33 , 282.1154 , 41.61295 , "None"));
Path.Add(new Vector3(-10721.29 , 281.3265 , 41.82302 , "None"));
Path.Add(new Vector3(-10734.25 , 284.567 , 40.80243 , "None"));
Path.Add(new Vector3(-10743.54 , 294.9984 , 40.05497 , "None"));
Path.Add(new Vector3(-10753.96 , 304.1274 , 38.81322 , "None"));
Path.Add(new Vector3(-10760.45 , 306.7313 , 37.8175 , "None"));
Path.Add(new Vector3(-10767.32 , 308.002 , 36.73224 , "None"));
Path.Add(new Vector3(-10774.29 , 308.6589 , 36.07851 , "None"));
Path.Add(new Vector3(-10781.27 , 309.1968 , 35.21249 , "None"));
Path.Add(new Vector3(-10788.26 , 309.1174 , 34.08382 , "None"));
Path.Add(new Vector3(-10795.16 , 308.0312 , 32.75478 , "None"));
Path.Add(new Vector3(-10801.29 , 304.8192 , 31.59273 , "None"));
Path.Add(new Vector3(-10805.91 , 292.1075 , 30.98672 , "None"));
Path.Add(new Vector3(-10803.38 , 278.3445 , 30.57402 , "None"));
Path.Add(new Vector3(-10801.96 , 271.4886 , 30.48056 , "None"));
Path.Add(new Vector3(-10800.55 , 264.6327 , 30.4909 , "None"));
Path.Add(new Vector3(-10799.14 , 257.7768 , 30.4806 , "None"));
Path.Add(new Vector3(-10796.31 , 244.065 , 30.48937 , "None"));
Path.Add(new Vector3(-10794.9 , 237.2091 , 30.48066 , "None"));
Path.Add(new Vector3(-10793.49 , 230.3532 , 30.5087 , "None"));
Path.Add(new Vector3(-10792.07 , 223.4973 , 30.40017 , "None"));
Path.Add(new Vector3(-10790.66 , 216.6414 , 30.50392 , "None"));
Path.Add(new Vector3(-10789.25 , 209.7855 , 30.64244 , "None"));
Path.Add(new Vector3(-10784.5 , 196.6588 , 30.26897 , "None"));
Path.Add(new Vector3(-10781.72 , 190.2319 , 30.42802 , "None"));
Path.Add(new Vector3(-10778.95 , 183.8049 , 30.01123 , "None"));
Path.Add(new Vector3(-10776.15 , 177.3869 , 29.56106 , "None"));
Path.Add(new Vector3(-10773.25 , 171.0183 , 29.686 , "None"));
Path.Add(new Vector3(-10770.05 , 164.7925 , 29.46677 , "None"));
Path.Add(new Vector3(-10766.73 , 158.6298 , 29.43376 , "None"));
Path.Add(new Vector3(-10763.31 , 152.5224 , 29.80556 , "None"));
Path.Add(new Vector3(-10759.87 , 146.4252 , 29.45189 , "None"));
Path.Add(new Vector3(-10756.58 , 140.247 , 29.12446 , "None"));
Path.Add(new Vector3(-10754.09 , 133.7071 , 28.70047 , "None"));
Path.Add(new Vector3(-10751.76 , 119.7065 , 28.65923 , "None"));
Path.Add(new Vector3(-10751.24 , 105.7194 , 28.46956 , "None"));
Path.Add(new Vector3(-10751.54 , 98.72655 , 28.33346 , "None"));
Path.Add(new Vector3(-10752.5 , 84.76237 , 28.34401 , "None"));
Path.Add(new Vector3(-10754.54 , 71.35205 , 29.21157 , "None"));
Path.Add(new Vector3(-10756.23 , 64.11759 , 28.56484 , "None"));
Path.Add(new Vector3(-10760.9 , 51.38592 , 28.08712 , "None"));
Path.Add(new Vector3(-10763.67 , 44.48734 , 28.53533 , "None"));
Path.Add(new Vector3(-10768.73 , 31.8984 , 28.25178 , "None"));
Path.Add(new Vector3(-10771.5 , 25.00145 , 28.74176 , "None"));
Path.Add(new Vector3(-10774.11 , 18.50561 , 29.34203 , "None"));
Path.Add(new Vector3(-10779.16 , 5.916676 , 29.41983 , "None"));
Path.Add(new Vector3(-10781.62 , -0.6299977 , 29.89092 , "None"));
Path.Add(new Vector3(-10783.66 , -7.32505 , 30.10584 , "None"));
Path.Add(new Vector3(-10787.36 , -20.81444 , 29.20065 , "None"));
Path.Add(new Vector3(-10789.21 , -27.56462 , 29.30659 , "None"));
Path.Add(new Vector3(-10791.07 , -34.31479 , 29.56109 , "None"));
Path.Add(new Vector3(-10792.92 , -41.06496 , 29.45811 , "None"));
Path.Add(new Vector3(-10796.68 , -54.55111 , 29.20774 , "None"));
Path.Add(new Vector3(-10798.56 , -61.29395 , 29.16982 , "None"));
Path.Add(new Vector3(-10800.5 , -68.02024 , 29.23103 , "None"));
Path.Add(new Vector3(-10802.73 , -74.65257 , 28.89398 , "None"));
Path.Add(new Vector3(-10805.22 , -81.1945 , 29.32761 , "None"));
Path.Add(new Vector3(-10807.78 , -87.71063 , 29.07386 , "None"));
Path.Add(new Vector3(-10810.34 , -94.22677 , 29.09975 , "None"));
Path.Add(new Vector3(-10812.89 , -100.7429 , 29.42056 , "None"));
Path.Add(new Vector3(-10815.45 , -107.259 , 29.7183 , "None"));
Path.Add(new Vector3(-10818.01 , -113.7752 , 29.76732 , "None"));
Path.Add(new Vector3(-10820.57 , -120.2913 , 30.03966 , "None"));
Path.Add(new Vector3(-10823.2 , -127.0029 , 30.88476 , "None"));
Path.Add(new Vector3(-10827.94 , -139.9431 , 31.99711 , "None"));
Path.Add(new Vector3(-10830.03 , -146.6218 , 31.86274 , "None"));
Path.Add(new Vector3(-10832.13 , -153.3023 , 32.36333 , "None"));
Path.Add(new Vector3(-10834.22 , -159.9827 , 33.09061 , "None"));
Path.Add(new Vector3(-10836.31 , -166.6632 , 33.97144 , "None"));
Path.Add(new Vector3(-10840.14 , -180.1254 , 33.96921 , "None"));
Path.Add(new Vector3(-10841.75 , -186.9369 , 34.79897 , "None"));
Path.Add(new Vector3(-10843.41 , -193.9527 , 35.92988 , "None"));
Path.Add(new Vector3(-10846.56 , -207.3792 , 36.95969 , "None"));
Path.Add(new Vector3(-10847.99 , -214.4447 , 37.75063 , "None"));
Path.Add(new Vector3(-10850.72 , -228.1759 , 38.54681 , "None"));
Path.Add(new Vector3(-10851.86 , -235.0823 , 38.69447 , "None"));
Path.Add(new Vector3(-10852.98 , -241.9917 , 38.61379 , "None"));
Path.Add(new Vector3(-10854.21 , -248.8831 , 38.44607 , "None"));
Path.Add(new Vector3(-10855.6 , -255.7433 , 38.11175 , "None"));
Path.Add(new Vector3(-10858.94 , -269.3281 , 38.34516 , "None"));
Path.Add(new Vector3(-10861.16 , -275.9667 , 38.27163 , "None"));
Path.Add(new Vector3(-10863.38 , -282.6049 , 38.10885 , "None"));
Path.Add(new Vector3(-10865.61 , -289.243 , 38.09375 , "None"));
Path.Add(new Vector3(-10867.83 , -295.8806 , 37.90644 , "None"));
Path.Add(new Vector3(-10872.92 , -308.9226 , 38.24641 , "None"));
Path.Add(new Vector3(-10875.5 , -315.4286 , 37.82956 , "None"));
Path.Add(new Vector3(-10878.08 , -321.9347 , 37.84631 , "None"));
Path.Add(new Vector3(-10880.74 , -328.41 , 37.7704 , "None"));
Path.Add(new Vector3(-10883.5 , -334.8433 , 38.15487 , "None"));
Path.Add(new Vector3(-10886.26 , -341.2758 , 38.90472 , "None"));
Path.Add(new Vector3(-10889.08 , -347.6848 , 39.18756 , "None"));
Path.Add(new Vector3(-10891.92 , -354.0844 , 38.88936 , "None"));
Path.Add(new Vector3(-10894.75 , -360.484 , 38.95513 , "None"));
Path.Add(new Vector3(-10897.54 , -366.9059 , 39.12847 , "None"));
Path.Add(new Vector3(-10899.46 , -373.6245 , 39.8583 , "None"));
Path.Add(new Vector3(-10901.67 , -387.4286 , 40.68086 , "None"));
Path.Add(new Vector3(-10902.4 , -394.3909 , 40.95833 , "None"));
Path.Add(new Vector3(-10903.12 , -401.3538 , 41.15732 , "None"));
Path.Add(new Vector3(-10903.79 , -408.3207 , 41.37323 , "None"));
Path.Add(new Vector3(-10904.4 , -415.294 , 41.89079 , "None"));
Path.Add(new Vector3(-10905.02 , -422.2674 , 42.01638 , "None"));
Path.Add(new Vector3(-10905.63 , -429.2407 , 42.4398 , "None"));
Path.Add(new Vector3(-10906.24 , -436.214 , 42.65885 , "None"));
Path.Add(new Vector3(-10906.85 , -443.1873 , 43.95096 , "None"));
Path.Add(new Vector3(-10907.46 , -450.1606 , 44.59887 , "None"));
Path.Add(new Vector3(-10907.8 , -457.1513 , 45.8189 , "None"));
Path.Add(new Vector3(-10908 , -464.1484 , 47.03293 , "None"));
Path.Add(new Vector3(-10908.19 , -471.1456 , 47.62885 , "None"));
Path.Add(new Vector3(-10908.39 , -478.1428 , 48.24843 , "None"));
Path.Add(new Vector3(-10908.59 , -485.14 , 49.22887 , "None"));
Path.Add(new Vector3(-10908.8 , -492.361 , 50.33223 , "None"));
Path.Add(new Vector3(-10909.31 , -506.1261 , 51.56392 , "None"));
Path.Add(new Vector3(-10911.31 , -519.9583 , 53.13906 , "None"));
Path.Add(new Vector3(-10913.03 , -526.7435 , 53.82993 , "None"));
Path.Add(new Vector3(-10914.81 , -533.5123 , 53.74757 , "None"));
Path.Add(new Vector3(-10916.86 , -540.2062 , 54.08066 , "None"));
Path.Add(new Vector3(-10919.07 , -547.0834 , 53.90422 , "None"));
Path.Add(new Vector3(-10924.64 , -559.8741 , 53.96432 , "None"));
Path.Add(new Vector3(-10932.42 , -571.5122 , 54.07226 , "None"));
Path.Add(new Vector3(-10936.31 , -577.3289 , 53.76851 , "None"));
Path.Add(new Vector3(-10943.81 , -588.6363 , 54.34514 , "None"));
Path.Add(new Vector3(-10947.71 , -594.9634 , 55.09805 , "None"));
Path.Add(new Vector3(-10953.2 , -607.3295 , 55.33577 , "None"));
Path.Add(new Vector3(-10955.15 , -614.5013 , 54.9733 , "None"));
Path.Add(new Vector3(-10956.97 , -627.9266 , 55.10911 , "None"));
Path.Add(new Vector3(-10956.83 , -641.9052 , 55.12485 , "None"));
Path.Add(new Vector3(-10951.69 , -654.7612 , 55.36164 , "None"));
Path.Add(new Vector3(-10947.54 , -660.3974 , 55.31936 , "None"));
Path.Add(new Vector3(-10943.37 , -666.0157 , 55.61565 , "None"));
Path.Add(new Vector3(-10939.19 , -671.6339 , 55.72588 , "None"));
Path.Add(new Vector3(-10935.02 , -677.2521 , 55.64077 , "None"));
Path.Add(new Vector3(-10928.25 , -689.4377 , 55.56466 , "None"));
Path.Add(new Vector3(-10925.38 , -695.8205 , 55.78044 , "None"));
Path.Add(new Vector3(-10918.87 , -708.2067 , 55.70109 , "None"));
Path.Add(new Vector3(-10915.37 , -714.2661 , 55.3623 , "None"));
Path.Add(new Vector3(-10911.52 , -720.1139 , 54.96227 , "None"));
Path.Add(new Vector3(-10907.53 , -725.8615 , 54.74637 , "None"));
Path.Add(new Vector3(-10903.35 , -731.4758 , 55.01896 , "None"));
Path.Add(new Vector3(-10894.35 , -742.1887 , 55.42904 , "None"));
Path.Add(new Vector3(-10889.74 , -747.4609 , 55.528 , "None"));
Path.Add(new Vector3(-10885 , -752.6133 , 55.59052 , "None"));
Path.Add(new Vector3(-10875.15 , -762.5623 , 55.40505 , "None"));
Path.Add(new Vector3(-10865.07 , -772.553 , 55.8359 , "None"));
Path.Add(new Vector3(-10855.36 , -782.3421 , 56.26292 , "None"));
Path.Add(new Vector3(-10846.88 , -793.462 , 56.15101 , "None"));
Path.Add(new Vector3(-10839.44 , -805.3179 , 56.18318 , "None"));
Path.Add(new Vector3(-10832.7 , -817.5927 , 56.31877 , "None"));
Path.Add(new Vector3(-10829.58 , -823.8545 , 55.78439 , "None"));
Path.Add(new Vector3(-10826.58 , -830.1794 , 55.56265 , "None"));
Path.Add(new Vector3(-10823.62 , -836.521 , 55.69216 , "None"));
Path.Add(new Vector3(-10820.61 , -843.0615 , 55.91319 , "None"));
Path.Add(new Vector3(-10815.05 , -855.9099 , 55.88387 , "None"));
Path.Add(new Vector3(-10810.08 , -868.9987 , 55.98205 , "None"));
Path.Add(new Vector3(-10808.03 , -875.6923 , 55.8516 , "None"));
Path.Add(new Vector3(-10806.11 , -882.4238 , 55.69737 , "None"));
Path.Add(new Vector3(-10804.19 , -889.1553 , 55.73876 , "None"));
Path.Add(new Vector3(-10802.27 , -895.8863 , 55.9021 , "None"));
Path.Add(new Vector3(-10800.56 , -902.6745 , 56.09891 , "None"));
Path.Add(new Vector3(-10797.27 , -916.2802 , 55.7619 , "None"));
Path.Add(new Vector3(-10796.02 , -930.1852 , 55.98792 , "None"));
Path.Add(new Vector3(-10796.81 , -937.1326 , 56.36152 , "None"));
Path.Add(new Vector3(-10800.77 , -950.5292 , 56.57196 , "None"));
Path.Add(new Vector3(-10803.24 , -957.0789 , 56.46983 , "None"));
Path.Add(new Vector3(-10806.21 , -970.7258 , 56.19364 , "None"));
Path.Add(new Vector3(-10806.77 , -977.6998 , 55.6549 , "None"));
Path.Add(new Vector3(-10806.9 , -984.6983 , 55.01755 , "None"));
Path.Add(new Vector3(-10806.91 , -991.6982 , 53.9193 , "None"));
Path.Add(new Vector3(-10806.75 , -998.6964 , 52.75804 , "None"));
Path.Add(new Vector3(-10806.57 , -1005.694 , 51.7021 , "None"));
Path.Add(new Vector3(-10806.35 , -1012.69 , 50.62872 , "None"));
Path.Add(new Vector3(-10805.92 , -1019.676 , 49.13815 , "None"));
Path.Add(new Vector3(-10805.03 , -1026.619 , 47.7883 , "None"));
Path.Add(new Vector3(-10803.96 , -1033.534 , 46.55675 , "None"));
Path.Add(new Vector3(-10802.27 , -1040.326 , 45.36312 , "None"));
Path.Add(new Vector3(-10800.19 , -1047.01 , 44.05797 , "None"));
Path.Add(new Vector3(-10797.61 , -1053.514 , 42.72097 , "None"));
Path.Add(new Vector3(-10794.66 , -1059.863 , 41.20879 , "None"));
Path.Add(new Vector3(-10791.7 , -1066.204 , 39.51092 , "None"));
Path.Add(new Vector3(-10788.85 , -1072.597 , 38.19308 , "None"));
Path.Add(new Vector3(-10786.58 , -1079.216 , 36.65488 , "None"));
Path.Add(new Vector3(-10784.82 , -1085.99 , 35.3282 , "None"));
Path.Add(new Vector3(-10783.08 , -1092.772 , 34.00377 , "None"));
Path.Add(new Vector3(-10781.35 , -1099.553 , 32.96006 , "None"));
Path.Add(new Vector3(-10779.62 , -1106.335 , 31.54744 , "None"));
Path.Add(new Vector3(-10777.87 , -1113.114 , 30.26653 , "None"));
Path.Add(new Vector3(-10775.49 , -1119.69 , 29.39451 , "None"));
Path.Add(new Vector3(-10772.23 , -1125.88 , 28.52782 , "None"));
Path.Add(new Vector3(-10768.31 , -1131.675 , 27.59319 , "None"));
Path.Add(new Vector3(-10759.19 , -1142.289 , 26.97419 , "None"));
Path.Add(new Vector3(-10748.2 , -1151.283 , 26.6297 , "None"));
Path.Add(new Vector3(-10742.43 , -1155.248 , 26.36947 , "None"));
Path.Add(new Vector3(-10736.66 , -1159.21 , 26.48281 , "None"));
Path.Add(new Vector3(-10730.89 , -1163.173 , 26.88071 , "None"));
Path.Add(new Vector3(-10725.12 , -1167.136 , 26.46873 , "None"));
Path.Add(new Vector3(-10713.93 , -1174.816 , 26.40019 , "None"));
Path.Add(new Vector3(-10707.8 , -1179.025 , 26.42396 , "None"));
Path.Add(new Vector3(-10702.03 , -1182.988 , 26.75728 , "None"));
Path.Add(new Vector3(-10690.49 , -1190.913 , 27.47161 , "None"));
Path.Add(new Vector3(-10683.27 , -1201.834 , 26.2325 , "None"));
Path.Add(new Vector3(-10684.98 , -1215.67 , 27.44633 , "None"));
Path.Add(new Vector3(-10686.16 , -1222.57 , 28.14828 , "None"));
Path.Add(new Vector3(-10686.97 , -1229.522 , 28.66082 , "None"));
Path.Add(new Vector3(-10687.72 , -1236.479 , 28.96823 , "None"));
Path.Add(new Vector3(-10688.44 , -1243.442 , 29.19411 , "None"));
Path.Add(new Vector3(-10689 , -1250.419 , 29.4036 , "None"));
Path.Add(new Vector3(-10689.56 , -1257.397 , 29.61996 , "None"));
Path.Add(new Vector3(-10690.11 , -1264.375 , 29.75314 , "None"));
Path.Add(new Vector3(-10690.82 , -1271.337 , 30.44051 , "None"));
Path.Add(new Vector3(-10692.02 , -1278.233 , 31.45089 , "None"));
Path.Add(new Vector3(-10693.31 , -1285.113 , 33.44131 , "None"));
Path.Add(new Vector3(-10693.86 , -1292.073 , 36.77934 , "None"));
Path.Add(new Vector3(-10693.39 , -1299.057 , 39.88181 , "None"));
Path.Add(new Vector3(-10691.57 , -1305.793 , 41.17534 , "None"));
Path.Add(new Vector3(-10688.77 , -1312.206 , 41.89799 , "None"));
Path.Add(new Vector3(-10685.53 , -1318.41 , 42.78997 , "None"));
Path.Add(new Vector3(-10682.47 , -1324.698 , 44.17202 , "None"));
Path.Add(new Vector3(-10680.13 , -1331.294 , 46.69195 , "None"));
Path.Add(new Vector3(-10674.64 , -1335.677 , 47.18778 , "None"));
Path.Add(new Vector3(-10668.09 , -1338.127 , 47.73183 , "None"));
Path.Add(new Vector3(-10660.43 , -1340.755 , 48.17798 , "None"));
Path.Add(new Vector3(-10651.38 , -1350.896 , 49.0847 , "None"));
Path.Add(new Vector3(-10648.61 , -1357.323 , 51.37437 , "None"));
Path.Add(new Vector3(-10645.03 , -1363.314 , 53.55733 , "None"));
Path.Add(new Vector3(-10640.04 , -1368.202 , 54.93797 , "None"));
Path.Add(new Vector3(-10629.13 , -1371.14 , 56.22229 , "None"));
Path.Add(new Vector3(-10622.16 , -1370.554 , 58.32283 , "None"));
Path.Add(new Vector3(-10615.28 , -1369.293 , 61.10996 , "None"));
Path.Add(new Vector3(-10606.22 , -1368.215 , 65.39593 , "None"));
Path.Add(new Vector3(-10595.36 , -1369.386 , 65.23596 , "None"));
Path.Add(new Vector3(-10588.38 , -1369.848 , 67.52631 , "None"));
Path.Add(new Vector3(-10581.38 , -1370.05 , 69.0422 , "None"));
Path.Add(new Vector3(-10574.39 , -1369.903 , 70.35572 , "None"));
Path.Add(new Vector3(-10574.39 , -1369.903 , 70.35572 , "None"));
Path.Add(new Vector3(-10564.34 , -1373.594 , 68.42603 , "None"));
Path.Add(new Vector3(-10557.61 , -1375.529 , 65.75767 , "None"));
Path.Add(new Vector3(-10550.88 , -1377.462 , 60.67395 , "None"));
Path.Add(new Vector3(-10544.15 , -1379.395 , 57.05686 , "None"));
Path.Add(new Vector3(-10531.67 , -1385.71 , 58.48385 , "None"));
Path.Add(new Vector3(-10526.64 , -1390.583 , 59.96566 , "None"));
Path.Add(new Vector3(-10521.57 , -1395.404 , 61.73318 , "None"));
Path.Add(new Vector3(-10510.99 , -1404.565 , 63.41494 , "None"));
Path.Add(new Vector3(-10499.83 , -1411.876 , 64.05482 , "None"));
Path.Add(new Vector3(-10493.39 , -1416.011 , 64.38708 , "None"));
Path.Add(new Vector3(-10482.18 , -1423.644 , 64.97076 , "None"));
Path.Add(new Vector3(-10476.54 , -1428.472 , 66.19786 , "None"));
Path.Add(new Vector3(-10467.39 , -1438.487 , 66.8727 , "None"));
Path.Add(new Vector3(-10462.77 , -1444.308 , 67.82414 , "None"));
Path.Add(new Vector3(-10455.07 , -1455.461 , 69.91501 , "None"));
Path.Add(new Vector3(-10452.06 , -1462.247 , 70.82496 , "None"));
Path.Add(new Vector3(-10448.64 , -1475.36 , 72.76468 , "None"));
Path.Add(new Vector3(-10447.77 , -1482.3 , 73.56863 , "None"));
Path.Add(new Vector3(-10447.97 , -1489.29 , 74.21313 , "None"));
Path.Add(new Vector3(-10448.58 , -1496.263 , 74.6602 , "None"));
Path.Add(new Vector3(-10449.23 , -1503.668 , 74.67494 , "None"));
Path.Add(new Vector3(-10450.42 , -1517.183 , 74.68623 , "None"));
Path.Add(new Vector3(-10451.03 , -1524.156 , 74.77227 , "None"));
Path.Add(new Vector3(-10451.64 , -1531.129 , 74.78747 , "None"));
Path.Add(new Vector3(-10452.25 , -1538.103 , 75.14329 , "None"));
Path.Add(new Vector3(-10452.86 , -1545.076 , 74.4138 , "None"));
Path.Add(new Vector3(-10453.47 , -1552.049 , 73.91109 , "None"));
Path.Add(new Vector3(-10454.08 , -1559.023 , 73.62659 , "None"));
Path.Add(new Vector3(-10454.71 , -1565.994 , 73.44485 , "None"));
Path.Add(new Vector3(-10456.77 , -1579.839 , 73.51289 , "None"));
Path.Add(new Vector3(-10457.92 , -1586.743 , 73.39847 , "None"));
Path.Add(new Vector3(-10459.08 , -1593.647 , 73.32437 , "None"));
Path.Add(new Vector3(-10460.23 , -1600.551 , 73.33636 , "None"));
Path.Add(new Vector3(-10461.39 , -1607.455 , 73.29923 , "None"));
Path.Add(new Vector3(-10463.69 , -1621.265 , 73.60232 , "None"));
Path.Add(new Vector3(-10464.29 , -1628.233 , 73.96618 , "None"));
Path.Add(new Vector3(-10464.52 , -1635.23 , 74.69818 , "None"));
Path.Add(new Vector3(-10464.74 , -1642.226 , 75.47429 , "None"));
Path.Add(new Vector3(-10464.97 , -1649.222 , 76.24207 , "None"));
Path.Add(new Vector3(-10465.16 , -1656.22 , 76.78248 , "None"));
Path.Add(new Vector3(-10465.28 , -1663.219 , 77.61604 , "None"));
Path.Add(new Vector3(-10465.28 , -1670.218 , 78.7217 , "None"));
Path.Add(new Vector3(-10464.79 , -1677.199 , 79.70679 , "None"));
Path.Add(new Vector3(-10463.92 , -1684.144 , 80.26496 , "None"));
Path.Add(new Vector3(-10462.94 , -1691.075 , 80.71409 , "None"));
Path.Add(new Vector3(-10461.93 , -1698.214 , 81.65346 , "None"));
Path.Add(new Vector3(-10460.95 , -1705.145 , 82.35224 , "None"));
Path.Add(new Vector3(-10459.97 , -1712.076 , 83.04924 , "None"));
Path.Add(new Vector3(-10458.99 , -1719.007 , 83.84663 , "None"));
Path.Add(new Vector3(-10458.01 , -1725.938 , 85.24797 , "None"));
Path.Add(new Vector3(-10457.03 , -1732.869 , 86.70553 , "None"));
Path.Add(new Vector3(-10455.53 , -1739.7 , 87.69343 , "None"));
Path.Add(new Vector3(-10453.28 , -1746.327 , 88.64534 , "None"));
Path.Add(new Vector3(-10450.52 , -1752.757 , 89.91909 , "None"));
Path.Add(new Vector3(-10447.41 , -1759.026 , 91.20367 , "None"));
Path.Add(new Vector3(-10444.23 , -1765.266 , 92.61639 , "None"));
Path.Add(new Vector3(-10441.06 , -1771.506 , 94.05219 , "None"));
Path.Add(new Vector3(-10437.94 , -1777.771 , 95.31729 , "None"));
Path.Add(new Vector3(-10434.96 , -1784.103 , 96.27821 , "None"));
Path.Add(new Vector3(-10432.37 , -1790.605 , 97.0274 , "None"));
Path.Add(new Vector3(-10430.45 , -1797.334 , 97.62689 , "None"));
Path.Add(new Vector3(-10429.58 , -1804.269 , 98.02079 , "None"));
Path.Add(new Vector3(-10429.63 , -1811.267 , 99.04467 , "None"));
Path.Add(new Vector3(-10430.43 , -1818.216 , 99.78102 , "None"));
Path.Add(new Vector3(-10431.73 , -1825.095 , 100.7477 , "None"));
Path.Add(new Vector3(-10433.24 , -1831.929 , 101.3418 , "None"));
Path.Add(new Vector3(-10434.84 , -1838.744 , 101.9164 , "None"));
Path.Add(new Vector3(-10436.58 , -1845.524 , 102.6468 , "None"));
Path.Add(new Vector3(-10438.41 , -1852.282 , 103.4645 , "None"));
Path.Add(new Vector3(-10440.23 , -1859.04 , 104.3643 , "None"));
Path.Add(new Vector3(-10441.91 , -1865.832 , 104.7533 , "None"));
Path.Add(new Vector3(-10443.31 , -1879.746 , 104.0601 , "None"));
Path.Add(new Vector3(-10441.91 , -1893.645 , 103.2577 , "None"));
Path.Add(new Vector3(-10440.9 , -1900.572 , 103.1966 , "None"));
Path.Add(new Vector3(-10439.93 , -1907.504 , 103.7857 , "None"));
Path.Add(new Vector3(-10439.24 , -1914.469 , 104.1187 , "None"));
Path.Add(new Vector3(-10438.84 , -1921.457 , 104.1292 , "None"));
Path.Add(new Vector3(-10438.43 , -1928.446 , 104.2609 , "None"));
Path.Add(new Vector3(-10438.68 , -1942.432 , 104.0578 , "None"));
Path.Add(new Vector3(-10439.07 , -1949.421 , 103.7087 , "None"));
Path.Add(new Vector3(-10439.47 , -1956.41 , 103.1815 , "None"));
Path.Add(new Vector3(-10439.86 , -1963.399 , 102.8817 , "None"));
Path.Add(new Vector3(-10440.02 , -1970.394 , 102.3928 , "None"));
Path.Add(new Vector3(-10439.21 , -1977.339 , 101.4739 , "None"));
Path.Add(new Vector3(-10437.26 , -1984.056 , 100.6571 , "None"));
Path.Add(new Vector3(-10434.69 , -1990.569 , 99.8463 , "None"));
Path.Add(new Vector3(-10432.02 , -1997.039 , 99.23627 , "None"));
Path.Add(new Vector3(-10429.67 , -2003.622 , 98.57803 , "None"));
Path.Add(new Vector3(-10428.58 , -2010.524 , 97.88329 , "None"));
Path.Add(new Vector3(-10428.97 , -2017.499 , 96.93607 , "None"));
Path.Add(new Vector3(-10431.05 , -2024.396 , 95.87921 , "None"));
Path.Add(new Vector3(-10439.83 , -2034.278 , 94.93896 , "None"));
Path.Add(new Vector3(-10446.68 , -2037.667 , 94.10696 , "None"));
Path.Add(new Vector3(-10459.86 , -2039.397 , 93.3656 , "None"));
Path.Add(new Vector3(-10467.07 , -2039.929 , 93.26935 , "None"));
Path.Add(new Vector3(-10474.05 , -2040.444 , 93.26727 , "None"));
Path.Add(new Vector3(-10481.46 , -2040.991 , 93.23229 , "None"));
Path.Add(new Vector3(-10494.79 , -2043.356 , 92.97888 , "None"));
Path.Add(new Vector3(-10506.88 , -2050.055 , 92.46706 , "None"));
Path.Add(new Vector3(-10511.39 , -2055.4 , 91.99387 , "None"));
Path.Add(new Vector3(-10515.47 , -2061.613 , 91.99387 , "None"));
Path.Add(new Vector3(-10523.04 , -2072.862 , 91.71464 , "None"));
Path.Add(new Vector3(-10527.64 , -2078.698 , 91.55272 , "None"));
Path.Add(new Vector3(-10536.67 , -2088.81 , 91.4191 , "None"));
Path.Add(new Vector3(-10541.58 , -2093.806 , 91.39758 , "None"));
Path.Add(new Vector3(-10546.73 , -2098.539 , 91.83285 , "None"));
Path.Add(new Vector3(-10558.7 , -2105.74 , 91.40408 , "None"));
Path.Add(new Vector3(-10565 , -2108.788 , 91.11993 , "None"));
Path.Add(new Vector3(-10575.05 , -2113.648 , 91.04017 , "None"));
Path.Add(new Vector3(-10583.73 , -2119.762 , 90.9438 , "None"));
Path.Add(new Vector3(-10588.09 , -2125.48 , 90.93319 , "None"));
Path.Add(new Vector3(-10591.35 , -2138.717 , 92.70715 , "None"));
Path.Add(new Vector3(-10591.37 , -2145.717 , 93.03255 , "None"));
Path.Add(new Vector3(-10590.87 , -2152.698 , 92.79084 , "None"));
Path.Add(new Vector3(-10589.98 , -2159.64 , 91.91784 , "None"));
Path.Add(new Vector3(-10588.92 , -2166.559 , 90.89903 , "None"));
Path.Add(new Vector3(-10587.83 , -2173.686 , 90.30688 , "None"));
Path.Add(new Vector3(-10585.73 , -2187.316 , 89.97469 , "None"));
Path.Add(new Vector3(-10584.67 , -2194.236 , 90.47262 , "None"));
Path.Add(new Vector3(-10583.46 , -2201.342 , 91.09032 , "None"));
Path.Add(new Vector3(-10581.83 , -2208.147 , 91.67463 , "None"));
Path.Add(new Vector3(-10580.01 , -2214.909 , 92.29349 , "None"));
Path.Add(new Vector3(-10578.2 , -2221.67 , 92.71043 , "None"));
Path.Add(new Vector3(-10576.38 , -2228.43 , 92.90756 , "None"));
Path.Add(new Vector3(-10574.57 , -2235.191 , 93.17564 , "None"));
Path.Add(new Vector3(-10572.76 , -2241.952 , 93.46722 , "None"));
Path.Add(new Vector3(-10570.94 , -2248.713 , 93.71767 , "None"));
Path.Add(new Vector3(-10569.13 , -2255.474 , 93.98624 , "None"));
Path.Add(new Vector3(-10567.31 , -2262.235 , 94.27279 , "None"));
Path.Add(new Vector3(-10565.5 , -2268.996 , 94.27359 , "None"));
Path.Add(new Vector3(-10563.69 , -2275.756 , 93.83041 , "None"));
Path.Add(new Vector3(-10561.87 , -2282.517 , 93.12574 , "None"));
Path.Add(new Vector3(-10560.06 , -2289.278 , 92.33414 , "None"));
Path.Add(new Vector3(-10558.24 , -2296.039 , 91.69121 , "None"));
Path.Add(new Vector3(-10556.51 , -2302.819 , 91.12518 , "None"));
Path.Add(new Vector3(-10555.79 , -2309.78 , 90.4995 , "None"));
Path.Add(new Vector3(-10555.17 , -2316.752 , 89.82348 , "None"));
Path.Add(new Vector3(-10554.54 , -2323.724 , 89.21591 , "None"));
Path.Add(new Vector3(-10553.92 , -2330.696 , 88.55752 , "None"));
Path.Add(new Vector3(-10553.28 , -2337.667 , 87.7994 , "None"));
Path.Add(new Vector3(-10552.48 , -2344.62 , 87.21302 , "None"));
Path.Add(new Vector3(-10550.9 , -2351.434 , 86.45975 , "None"));
Path.Add(new Vector3(-10548.36 , -2357.95 , 85.25717 , "None"));
Path.Add(new Vector3(-10544.83 , -2363.979 , 83.96088 , "None"));
Path.Add(new Vector3(-10539.73 , -2368.717 , 83.06618 , "None"));
Path.Add(new Vector3(-10526.83 , -2374.094 , 81.99754 , "None"));
Path.Add(new Vector3(-10520.33 , -2376.679 , 81.1 , "None"));
Path.Add(new Vector3(-10513.79 , -2379.186 , 80.12244 , "None"));
Path.Add(new Vector3(-10507.26 , -2381.692 , 78.62669 , "None"));
Path.Add(new Vector3(-10500.72 , -2384.198 , 77.79626 , "None"));
Path.Add(new Vector3(-10494.19 , -2386.705 , 77.08975 , "None"));
Path.Add(new Vector3(-10487.65 , -2389.211 , 76.373 , "None"));
Path.Add(new Vector3(-10481.12 , -2391.718 , 75.19592 , "None"));
Path.Add(new Vector3(-10474.37 , -2394.304 , 73.93392 , "None"));
Path.Add(new Vector3(-10461.4 , -2398.917 , 71.26559 , "None"));
Path.Add(new Vector3(-10454.63 , -2400.71 , 69.99739 , "None"));
Path.Add(new Vector3(-10447.85 , -2402.449 , 69.39394 , "None"));
Path.Add(new Vector3(-10440.8 , -2404.043 , 68.6805 , "None"));
Path.Add(new Vector3(-10427.29 , -2406.692 , 66.08148 , "None"));
Path.Add(new Vector3(-10420.42 , -2408.038 , 64.30355 , "None"));
Path.Add(new Vector3(-10413.6 , -2409.634 , 62.30423 , "None"));
Path.Add(new Vector3(-10407.09 , -2412.181 , 59.94821 , "None"));
Path.Add(new Vector3(-10400.58 , -2415.307 , 57.66367 , "None"));
Path.Add(new Vector3(-10394.72 , -2419.097 , 55.1362 , "None"));
Path.Add(new Vector3(-10390.34 , -2424.529 , 52.91036 , "None"));
Path.Add(new Vector3(-10387.27 , -2430.813 , 51.00355 , "None"));
Path.Add(new Vector3(-10385.24 , -2437.484 , 49.13183 , "None"));
Path.Add(new Vector3(-10385.17 , -2444.461 , 47.08361 , "None"));
Path.Add(new Vector3(-10386.6 , -2451.303 , 45.49527 , "None"));
Path.Add(new Vector3(-10388.96 , -2457.889 , 43.53575 , "None"));
Path.Add(new Vector3(-10391.91 , -2464.239 , 41.38989 , "None"));
Path.Add(new Vector3(-10395.02 , -2470.51 , 38.9827 , "None"));
Path.Add(new Vector3(-10398.13 , -2476.781 , 36.75267 , "None"));
Path.Add(new Vector3(-10401.24 , -2483.052 , 35.08366 , "None"));
Path.Add(new Vector3(-10404.35 , -2489.323 , 33.85363 , "None"));
Path.Add(new Vector3(-10407.46 , -2495.594 , 32.61215 , "None"));
Path.Add(new Vector3(-10410.56 , -2501.869 , 30.96326 , "None"));
Path.Add(new Vector3(-10413.44 , -2508.251 , 29.35386 , "None"));
Path.Add(new Vector3(-10415.92 , -2514.794 , 28.02916 , "None"));
Path.Add(new Vector3(-10417.85 , -2521.522 , 26.71769 , "None"));
Path.Add(new Vector3(-10419.2 , -2528.388 , 25.65605 , "None"));
Path.Add(new Vector3(-10419.92 , -2535.349 , 25.02409 , "None"));
Path.Add(new Vector3(-10419.78 , -2542.34 , 24.6057 , "None"));
Path.Add(new Vector3(-10418.78 , -2549.266 , 24.14818 , "None"));
Path.Add(new Vector3(-10416.65 , -2555.922 , 23.67611 , "None"));
Path.Add(new Vector3(-10409.32 , -2567.808 , 23.33401 , "None"));
Path.Add(new Vector3(-10400.46 , -2578.635 , 22.96542 , "None"));
Path.Add(new Vector3(-10395.85 , -2583.909 , 22.59624 , "None"));
Path.Add(new Vector3(-10391.25 , -2589.182 , 22.10205 , "None"));
Path.Add(new Vector3(-10386.73 , -2594.521 , 21.77405 , "None"));
Path.Add(new Vector3(-10379.9 , -2606.71 , 21.68284 , "None"));
Path.Add(new Vector3(-10376.69 , -2620.276 , 21.68757 , "None"));
Path.Add(new Vector3(-10377.87 , -2634.168 , 21.75184 , "None"));
Path.Add(new Vector3(-10382.25 , -2647.463 , 21.68066 , "None"));
Path.Add(new Vector3(-10385.26 , -2661.109 , 21.6881 , "None"));
Path.Add(new Vector3(-10385.4 , -2675.076 , 21.67888 , "None"));
Path.Add(new Vector3(-10384.76 , -2689.05 , 21.67888 , "None"));
Path.Add(new Vector3(-10389.91 , -2701.843 , 21.67888 , "None"));
Path.Add(new Vector3(-10400 , -2711.872 , 21.67888 , "None"));
Path.Add(new Vector3(-10409.71 , -2721.015 , 21.67888 , "None"));
Path.Add(new Vector3(-10415.3 , -2726.251 , 21.67888 , "None"));
Path.Add(new Vector3(-10420.41 , -2731.039 , 21.67888 , "None"));
Path.Add(new Vector3(-10430.3 , -2740.306 , 21.67888 , "None"));
Path.Add(new Vector3(-10435.73 , -2745.399 , 21.67888 , "None"));
Path.Add(new Vector3(-10445.4 , -2754.887 , 21.67888 , "None"));
Path.Add(new Vector3(-10454.01 , -2765.907 , 21.67878 , "None"));
Path.Add(new Vector3(-10460.93 , -2778.564 , 21.68062 , "None"));
Path.Add(new Vector3(-10466.42 , -2790.953 , 21.67808 , "None"));
Path.Add(new Vector3(-10469.33 , -2797.32 , 21.67808 , "None"));
Path.Add(new Vector3(-10476.43 , -2809.385 , 21.69379 , "None"));
Path.Add(new Vector3(-10483.72 , -2821.339 , 21.67792 , "None"));
Path.Add(new Vector3(-10489.98 , -2833.797 , 21.68462 , "None"));
Path.Add(new Vector3(-10491.96 , -2840.512 , 21.6785 , "None"));
Path.Add(new Vector3(-10495.6 , -2854.027 , 21.67795 , "None"));
Path.Add(new Vector3(-10497.29 , -2860.819 , 21.67795 , "None"));
Path.Add(new Vector3(-10498.98 , -2867.611 , 21.67795 , "None"));
Path.Add(new Vector3(-10502.75 , -2881.08 , 21.67795 , "None"));
Path.Add(new Vector3(-10508.4 , -2893.889 , 21.67858 , "None"));
Path.Add(new Vector3(-10513.6 , -2906.861 , 21.67858 , "None"));
Path.Add(new Vector3(-10514.31 , -2920.766 , 21.6859 , "None"));
Path.Add(new Vector3(-10510.96 , -2934.357 , 21.67798 , "None"));
Path.Add(new Vector3(-10507.92 , -2948.019 , 21.67798 , "None"));
Path.Add(new Vector3(-10507.44 , -2961.941 , 21.67865 , "None"));
Path.Add(new Vector3(-10510.44 , -2975.599 , 21.61419 , "None"));
Path.Add(new Vector3(-10512.42 , -2982.312 , 21.54235 , "None"));
Path.Add(new Vector3(-10516.39 , -2995.73 , 21.56461 , "None"));
Path.Add(new Vector3(-10518.43 , -3002.663 , 21.68052 , "None"));
Path.Add(new Vector3(-10520.86 , -3016.33 , 21.69353 , "None"));
Path.Add(new Vector3(-10516.37 , -3029.505 , 22.15784 , "None"));
Path.Add(new Vector3(-10513.02 , -3035.653 , 21.3838 , "None"));
Path.Add(new Vector3(-10509.63 , -3041.778 , 20.85918 , "None"));
Path.Add(new Vector3(-10506.25 , -3047.894 , 21.7156 , "None"));
Path.Add(new Vector3(-10502.85 , -3054.018 , 22.2391 , "None"));
Path.Add(new Vector3(-10499.46 , -3060.142 , 21.99069 , "None"));
Path.Add(new Vector3(-10496.12 , -3066.29 , 21.70046 , "None"));
Path.Add(new Vector3(-10492.8 , -3072.454 , 21.56371 , "None"));
Path.Add(new Vector3(-10489.48 , -3078.617 , 21.07899 , "None"));
Path.Add(new Vector3(-10486.16 , -3084.782 , 20.60288 , "None"));
Path.Add(new Vector3(-10482.99 , -3091.023 , 20.46561 , "None"));
Path.Add(new Vector3(-10476.9 , -3103.625 , 20.73485 , "None"));
Path.Add(new Vector3(-10473.85 , -3109.927 , 20.17852 , "None"));
Path.Add(new Vector3(-10470.8 , -3116.228 , 20.17852 , "None"));
Path.Add(new Vector3(-10465.27 , -3129.078 , 20.17871 , "None"));
Path.Add(new Vector3(-10461.11 , -3142.432 , 20.17814 , "None"));
Path.Add(new Vector3(-10458.62 , -3156.201 , 20.17884 , "None"));
Path.Add(new Vector3(-10458.42 , -3170.183 , 20.17884 , "None"));
Path.Add(new Vector3(-10459.66 , -3184.124 , 20.17884 , "None"));
Path.Add(new Vector3(-10461.16 , -3198.044 , 20.17842 , "None"));
Path.Add(new Vector3(-10461.89 , -3205.005 , 19.8513 , "None"));
Path.Add(new Vector3(-10462.26 , -3211.993 , 20.17905 , "None"));
Path.Add(new Vector3(-10460.28 , -3225.813 , 20.17905 , "None"));
Path.Add(new Vector3(-10455.91 , -3239.11 , 20.31703 , "None"));
Path.Add(new Vector3(-10453.62 , -3245.725 , 20.46025 , "None"));
Path.Add(new Vector3(-10451.33 , -3252.341 , 20.23141 , "None"));
Path.Add(new Vector3(-10448.55 , -3265.979 , 20.17937 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

        








public override bool HasQuest() { return true; }


}


public sealed class StromgardeToRefugePointeFP : QuestFollowPathClass
{
    public StromgardeToRefugePointeFP()
    {
        Name = "StromgardeToRefugePointeFP";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-1500.007 , -1841.031 , 68.83358 , "None"));
Path.Add(new Vector3(-1501.011 , -1855.444 , 68.597 , "None"));
Path.Add(new Vector3(-1501.98 , -1868.75 , 68.48596 , "None"));
Path.Add(new Vector3(-1503.01 , -1876.336 , 68.54757 , "None"));
Path.Add(new Vector3(-1506.429 , -1889.893 , 68.60764 , "None"));
Path.Add(new Vector3(-1513.122 , -1902.147 , 68.63001 , "None"));
Path.Add(new Vector3(-1522.608 , -1911.753 , 68.44246 , "None"));
Path.Add(new Vector3(-1535.967 , -1916.385 , 68.53126 , "None"));
Path.Add(new Vector3(-1543.383 , -1908.249 , 68.2023 , "None"));
Path.Add(new Vector3(-1548.771 , -1899.493 , 67.96335 , "None"));
Path.Add(new Vector3(-1549.445 , -1889.678 , 67.57204 , "None"));
Path.Add(new Vector3(-1549.266 , -1875.681 , 67.58386 , "None"));
Path.Add(new Vector3(-1549.128 , -1865.84 , 67.42178 , "None"));
Path.Add(new Vector3(-1541.377 , -1859.232 , 67.17288 , "None"));
Path.Add(new Vector3(-1530.991 , -1850.05 , 67.71951 , "None"));
Path.Add(new Vector3(-1527.672 , -1836.542 , 67.98078 , "None"));
Path.Add(new Vector3(-1527.367 , -1822.546 , 68.34055 , "None"));
Path.Add(new Vector3(-1527.206 , -1808.688 , 71.39508 , "None"));
Path.Add(new Vector3(-1527.043 , -1794.689 , 70.09043 , "None"));
Path.Add(new Vector3(-1526.88 , -1780.69 , 67.96616 , "None"));
Path.Add(new Vector3(-1526.717 , -1766.691 , 67.32414 , "None"));
Path.Add(new Vector3(-1526.592 , -1752.691 , 66.87602 , "None"));
Path.Add(new Vector3(-1527.231 , -1738.717 , 66.72062 , "None"));
Path.Add(new Vector3(-1531.382 , -1725.454 , 66.14977 , "None"));
Path.Add(new Vector3(-1540.071 , -1714.261 , 66.35016 , "None"));
Path.Add(new Vector3(-1551.048 , -1705.622 , 66.20171 , "None"));
Path.Add(new Vector3(-1563.181 , -1698.652 , 66.4565 , "None"));
Path.Add(new Vector3(-1575.942 , -1692.902 , 65.96554 , "None"));
Path.Add(new Vector3(-1589.167 , -1688.351 , 66.42841 , "None"));
Path.Add(new Vector3(-1600.073 , -1686.153 , 66.18781 , "None"));
Path.Add(new Vector3(-1597.108 , -1697.718 , 67.71628 , "None"));
Path.Add(new Vector3(-1590.534 , -1710.077 , 67.87794 , "None"));
Path.Add(new Vector3(-1585.829 , -1723.218 , 67.29311 , "None"));
Path.Add(new Vector3(-1583.487 , -1737.021 , 67.30994 , "None"));
Path.Add(new Vector3(-1581.159 , -1750.826 , 66.59427 , "None"));
Path.Add(new Vector3(-1578.832 , -1764.631 , 67.00871 , "None"));
Path.Add(new Vector3(-1576.371 , -1778.411 , 67.28176 , "None"));
Path.Add(new Vector3(-1571.05 , -1791.264 , 67.36511 , "None"));
Path.Add(new Vector3(-1560.547 , -1800.361 , 67.64596 , "None"));
Path.Add(new Vector3(-1547.153 , -1804.231 , 67.25523 , "None"));
Path.Add(new Vector3(-1533.278 , -1806.075 , 65.9798 , "None"));
Path.Add(new Vector3(-1519.319 , -1807.132 , 65.89921 , "None"));
Path.Add(new Vector3(-1505.323 , -1807.217 , 67.31161 , "None"));
Path.Add(new Vector3(-1491.361 , -1806.209 , 68.06625 , "None"));
Path.Add(new Vector3(-1477.187 , -1805.014 , 68.07362 , "None"));
Path.Add(new Vector3(-1463.233 , -1803.887 , 67.55972 , "None"));
Path.Add(new Vector3(-1449.722 , -1802.822 , 64.53913 , "None"));
Path.Add(new Vector3(-1442.286 , -1802.479 , 62.23566 , "None"));
Path.Add(new Vector3(-1428.521 , -1804.793 , 61.18166 , "None"));
Path.Add(new Vector3(-1415.206 , -1809.113 , 60.47956 , "None"));
Path.Add(new Vector3(-1402.375 , -1813.475 , 59.73458 , "None"));
Path.Add(new Vector3(-1389.12 , -1817.982 , 58.91996 , "None"));
Path.Add(new Vector3(-1375.953 , -1822.712 , 59.05567 , "None"));
Path.Add(new Vector3(-1363.125 , -1828.315 , 60.11941 , "None"));
Path.Add(new Vector3(-1350.353 , -1834.05 , 61.1839 , "None"));
Path.Add(new Vector3(-1338.088 , -1840.75 , 62.09229 , "None"));
Path.Add(new Vector3(-1331.021 , -1852.425 , 62.26453 , "None"));
Path.Add(new Vector3(-1333.122 , -1866.155 , 61.5278 , "None"));
Path.Add(new Vector3(-1337.523 , -1879.444 , 60.55792 , "None"));
Path.Add(new Vector3(-1342.088 , -1892.678 , 59.52382 , "None"));
Path.Add(new Vector3(-1346.746 , -1905.881 , 58.65199 , "None"));
Path.Add(new Vector3(-1351.435 , -1919.072 , 58.38379 , "None"));
Path.Add(new Vector3(-1356.12 , -1932.254 , 58.4241 , "None"));
Path.Add(new Vector3(-1360.808 , -1945.445 , 58.45612 , "None"));
Path.Add(new Vector3(-1365.497 , -1958.637 , 58.46436 , "None"));
Path.Add(new Vector3(-1370.185 , -1971.828 , 58.48717 , "None"));
Path.Add(new Vector3(-1374.874 , -1985.02 , 58.62468 , "None"));
Path.Add(new Vector3(-1379.563 , -1998.211 , 59.18382 , "None"));
Path.Add(new Vector3(-1383.839 , -2011.521 , 59.68422 , "None"));
Path.Add(new Vector3(-1385.793 , -2025.584 , 60.46524 , "None"));
Path.Add(new Vector3(-1386.443 , -2039.568 , 61.03573 , "None"));
Path.Add(new Vector3(-1386.827 , -2053.563 , 61.72959 , "None"));
Path.Add(new Vector3(-1387.21 , -2067.558 , 62.33254 , "None"));
Path.Add(new Vector3(-1387.593 , -2081.553 , 62.93093 , "None"));
Path.Add(new Vector3(-1387.975 , -2095.548 , 63.67511 , "None"));
Path.Add(new Vector3(-1388.358 , -2109.542 , 64.24782 , "None"));
Path.Add(new Vector3(-1388.947 , -2123.525 , 64.35702 , "None"));
Path.Add(new Vector3(-1390.754 , -2137.407 , 64.25545 , "None"));
Path.Add(new Vector3(-1392.753 , -2151.263 , 64.16055 , "None"));
Path.Add(new Vector3(-1395.301 , -2165.025 , 64.08207 , "None"));
Path.Add(new Vector3(-1398.637 , -2178.622 , 63.98153 , "None"));
Path.Add(new Vector3(-1402.173 , -2192.167 , 63.89639 , "None"));
Path.Add(new Vector3(-1406 , -2205.634 , 63.85497 , "None"));
Path.Add(new Vector3(-1410.202 , -2218.984 , 63.82958 , "None"));
Path.Add(new Vector3(-1415.357 , -2231.999 , 63.72665 , "None"));
Path.Add(new Vector3(-1421.442 , -2244.603 , 63.65688 , "None"));
Path.Add(new Vector3(-1428.299 , -2256.807 , 63.41727 , "None"));
Path.Add(new Vector3(-1435.39 , -2268.877 , 63.24225 , "None"));
Path.Add(new Vector3(-1441.329 , -2281.55 , 62.58836 , "None"));
Path.Add(new Vector3(-1446.039 , -2294.728 , 62.08896 , "None"));
Path.Add(new Vector3(-1449.083 , -2308.378 , 61.82643 , "None"));
Path.Add(new Vector3(-1450.072 , -2322.337 , 61.74801 , "None"));
Path.Add(new Vector3(-1450.565 , -2336.553 , 61.66403 , "None"));
Path.Add(new Vector3(-1451.022 , -2350.321 , 61.58483 , "None"));
Path.Add(new Vector3(-1451.488 , -2364.313 , 61.50957 , "None"));
Path.Add(new Vector3(-1451.945 , -2378.082 , 61.42575 , "None"));
Path.Add(new Vector3(-1450.154 , -2392.217 , 61.26353 , "None"));
Path.Add(new Vector3(-1443.877 , -2404.705 , 61.50349 , "None"));
Path.Add(new Vector3(-1435.753 , -2415.545 , 60.53214 , "None"));
Path.Add(new Vector3(-1426.814 , -2426.317 , 60.1596 , "None"));
Path.Add(new Vector3(-1417.56 , -2436.823 , 59.5114 , "None"));
Path.Add(new Vector3(-1407.866 , -2446.905 , 60.31533 , "None"));
Path.Add(new Vector3(-1395.618 , -2453.388 , 58.3299 , "None"));
Path.Add(new Vector3(-1381.725 , -2453.318 , 55.4278 , "None"));
Path.Add(new Vector3(-1367.92 , -2450.99 , 52.55039 , "None"));
Path.Add(new Vector3(-1354.04 , -2449.215 , 50.41625 , "None"));
Path.Add(new Vector3(-1340.061 , -2448.821 , 47.12666 , "None"));
Path.Add(new Vector3(-1326.39 , -2451.626 , 44.3143 , "None"));
Path.Add(new Vector3(-1313.477 , -2457.023 , 42.36923 , "None"));
Path.Add(new Vector3(-1301.122 , -2463.589 , 38.20375 , "None"));
Path.Add(new Vector3(-1289.639 , -2471.587 , 33.54353 , "None"));
Path.Add(new Vector3(-1278.547 , -2480.127 , 28.08754 , "None"));
Path.Add(new Vector3(-1267.964 , -2489.291 , 23.71507 , "None"));
Path.Add(new Vector3(-1257.406 , -2498.486 , 21.36499 , "None"));
Path.Add(new Vector3(-1246.904 , -2507.743 , 21.18916 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

        








public override bool HasQuest() { return true; }


}


public sealed class GatherBurningSteppes : QuestFollowPathClass
{
    public GatherBurningSteppes()
    {
        Name = "GatherBurningSteppes";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-7504.03 , -2187.54 , 165.53 , "None"));
Path.Add(new Vector3(-7518.305 , -2183.384 , 162.5703 , "None"));
Path.Add(new Vector3(-7531.733 , -2179.424 , 159.591 , "None"));
Path.Add(new Vector3(-7544.919 , -2174.725 , 158.487 , "None"));
Path.Add(new Vector3(-7557.996 , -2169.727 , 156.8753 , "None"));
Path.Add(new Vector3(-7570.626 , -2163.694 , 153.6231 , "None"));
Path.Add(new Vector3(-7582.797 , -2156.78 , 151.2342 , "None"));
Path.Add(new Vector3(-7593.819 , -2149.64 , 148.4918 , "None"));
Path.Add(new Vector3(-7606.871 , -2142.546 , 142.4838 , "None"));
Path.Add(new Vector3(-7618.877 , -2137.254 , 137.0243 , "None"));
Path.Add(new Vector3(-7634.012 , -2135.572 , 135.54 , "None"));
Path.Add(new Vector3(-7647.486 , -2139.037 , 135.54 , "None"));
Path.Add(new Vector3(-7659.642 , -2144.008 , 132.9063 , "None"));
Path.Add(new Vector3(-7673.545 , -2149.195 , 132.5321 , "None"));
Path.Add(new Vector3(-7677.022 , -2149.597 , 133.6863 , "None"));
Path.Add(new Vector3(-7684.465 , -2149.395 , 134.0248 , "None"));
Path.Add(new Vector3(-7693.189 , -2148.944 , 132.9135 , "None"));
Path.Add(new Vector3(-7696.607 , -2152.324 , 132.3858 , "None"));
Path.Add(new Vector3(-7703.098 , -2166.981 , 132.31 , "None"));
Path.Add(new Vector3(-7707.059 , -2178.052 , 131.896 , "None"));
Path.Add(new Vector3(-7705.602 , -2189.296 , 135.1568 , "None"));
Path.Add(new Vector3(-7702.724 , -2202.992 , 137.3575 , "None"));
Path.Add(new Vector3(-7701.808 , -2213.872 , 137.6782 , "None"));
Path.Add(new Vector3(-7703.265 , -2221.176 , 137.3261 , "None"));
Path.Add(new Vector3(-7705.659 , -2233.175 , 138.143 , "None"));
Path.Add(new Vector3(-7707.689 , -2244.384 , 139.5955 , "None"));
Path.Add(new Vector3(-7706.799 , -2250.026 , 140.1601 , "None"));
Path.Add(new Vector3(-7705.192 , -2257.246 , 140.5209 , "None"));
Path.Add(new Vector3(-7702.554 , -2263.274 , 140.7964 , "None"));
Path.Add(new Vector3(-7698.269 , -2270.361 , 141.2377 , "None"));
Path.Add(new Vector3(-7693.273 , -2278.101 , 141.5548 , "None"));
Path.Add(new Vector3(-7688.56 , -2284.917 , 141.7529 , "None"));
Path.Add(new Vector3(-7681.577 , -2293.92 , 142.239 , "None"));
Path.Add(new Vector3(-7673.449 , -2301.116 , 142.4931 , "None"));
Path.Add(new Vector3(-7669.25 , -2303.473 , 142.4951 , "None"));
Path.Add(new Vector3(-7664.709 , -2305.075 , 141.8556 , "None"));
Path.Add(new Vector3(-7654.687 , -2306.121 , 140.0852 , "None"));
Path.Add(new Vector3(-7643.32 , -2306.179 , 139.988 , "None"));
Path.Add(new Vector3(-7632.479 , -2307.457 , 139.8016 , "None"));
Path.Add(new Vector3(-7621.405 , -2315.471 , 139.8619 , "None"));
Path.Add(new Vector3(-7617.313 , -2328.808 , 139.9908 , "None"));
Path.Add(new Vector3(-7613.333 , -2342.194 , 139.7965 , "None"));
Path.Add(new Vector3(-7607.646 , -2354.966 , 139.5758 , "None"));
Path.Add(new Vector3(-7604.652 , -2368.635 , 138.7095 , "None"));
Path.Add(new Vector3(-7603.921 , -2382.957 , 138.6223 , "None"));
Path.Add(new Vector3(-7607.933 , -2395.901 , 140.6743 , "None"));
Path.Add(new Vector3(-7617.468 , -2406.61 , 144.3375 , "None"));
Path.Add(new Vector3(-7625.103 , -2419.239 , 144.7456 , "None"));
Path.Add(new Vector3(-7629.535 , -2427.268 , 144.7678 , "None"));
Path.Add(new Vector3(-7632.676 , -2430.917 , 144.795 , "None"));
Path.Add(new Vector3(-7643.038 , -2440.31 , 145.5415 , "None"));
Path.Add(new Vector3(-7650.296 , -2444.364 , 146.1368 , "None"));
Path.Add(new Vector3(-7659.441 , -2449.521 , 147.8368 , "None"));
Path.Add(new Vector3(-7663.03 , -2451.964 , 147.8946 , "None"));
Path.Add(new Vector3(-7669.07 , -2456.275 , 146.8852 , "None"));
Path.Add(new Vector3(-7675.202 , -2460.499 , 146.5681 , "None"));
Path.Add(new Vector3(-7683.639 , -2462.766 , 146.1169 , "None"));
Path.Add(new Vector3(-7689.108 , -2464.307 , 147.6412 , "None"));
Path.Add(new Vector3(-7694.431 , -2466.376 , 148.8891 , "None"));
Path.Add(new Vector3(-7698.525 , -2468.908 , 148.0975 , "None"));
Path.Add(new Vector3(-7699.002 , -2475.826 , 146.1255 , "None"));
Path.Add(new Vector3(-7695.166 , -2482.928 , 144.1774 , "None"));
Path.Add(new Vector3(-7691.214 , -2486.406 , 143.7855 , "None"));
Path.Add(new Vector3(-7684.437 , -2490.388 , 142.1249 , "None"));
Path.Add(new Vector3(-7677.052 , -2491.355 , 140.2399 , "None"));
Path.Add(new Vector3(-7672.717 , -2491.888 , 138.5382 , "None"));
Path.Add(new Vector3(-7658.772 , -2492.908 , 134.6671 , "None"));
Path.Add(new Vector3(-7644.887 , -2491.192 , 133.4308 , "None"));
Path.Add(new Vector3(-7631.217 , -2488.175 , 133.3383 , "None"));
Path.Add(new Vector3(-7617.642 , -2484.76 , 133.3336 , "None"));
Path.Add(new Vector3(-7604.315 , -2480.475 , 133.5329 , "None"));
Path.Add(new Vector3(-7596.451 , -2476.626 , 135.3137 , "None"));
Path.Add(new Vector3(-7590.115 , -2472 , 136.0624 , "None"));
Path.Add(new Vector3(-7588.69 , -2459.402 , 136.1362 , "None"));
Path.Add(new Vector3(-7588.002 , -2444.98 , 136.2354 , "None"));
Path.Add(new Vector3(-7588.645 , -2430.996 , 136.3471 , "None"));
Path.Add(new Vector3(-7590.916 , -2418.084 , 137.7582 , "None"));
Path.Add(new Vector3(-7595.325 , -2404.8 , 138.917 , "None"));
Path.Add(new Vector3(-7600.188 , -2390.749 , 138.8512 , "None"));
Path.Add(new Vector3(-7603.373 , -2378.038 , 138.5295 , "None"));
Path.Add(new Vector3(-7603.993 , -2363.234 , 138.7999 , "None"));
Path.Add(new Vector3(-7603.96 , -2349.271 , 140.3167 , "None"));
Path.Add(new Vector3(-7605.214 , -2343.268 , 140.3937 , "None"));
Path.Add(new Vector3(-7609.417 , -2329.935 , 140.591 , "None"));
Path.Add(new Vector3(-7612.508 , -2323.18 , 140.4409 , "None"));
Path.Add(new Vector3(-7622.085 , -2313.036 , 139.883 , "None"));
Path.Add(new Vector3(-7627.594 , -2309.522 , 139.8036 , "None"));
Path.Add(new Vector3(-7632.974 , -2307.741 , 139.8022 , "None"));
Path.Add(new Vector3(-7639.464 , -2306.85 , 139.8784 , "None"));
Path.Add(new Vector3(-7645.172 , -2306.676 , 139.9984 , "None"));
Path.Add(new Vector3(-7655.67 , -2306.744 , 140.0867 , "None"));
Path.Add(new Vector3(-7664.296 , -2305.527 , 141.6527 , "None"));
Path.Add(new Vector3(-7672.102 , -2299.237 , 142.4906 , "None"));
Path.Add(new Vector3(-7679.493 , -2291.779 , 142.225 , "None"));
Path.Add(new Vector3(-7681.978 , -2289.314 , 142.0705 , "None"));
Path.Add(new Vector3(-7687.64 , -2283.267 , 141.7138 , "None"));
Path.Add(new Vector3(-7692.076 , -2278.447 , 141.5832 , "None"));
Path.Add(new Vector3(-7700.38 , -2271.321 , 141.2 , "None"));
Path.Add(new Vector3(-7710.046 , -2266.212 , 140.9149 , "None"));
Path.Add(new Vector3(-7718.091 , -2264.115 , 140.6547 , "None"));
Path.Add(new Vector3(-7732.221 , -2261.243 , 137.3933 , "None"));
Path.Add(new Vector3(-7745.511 , -2258.46 , 134.1665 , "None"));
Path.Add(new Vector3(-7758.959 , -2254.578 , 133.4403 , "None"));
Path.Add(new Vector3(-7772.325 , -2250.461 , 133.5941 , "None"));
Path.Add(new Vector3(-7778.723 , -2249.069 , 133.4395 , "None"));
Path.Add(new Vector3(-7792.614 , -2247.472 , 133.4395 , "None"));
Path.Add(new Vector3(-7807.018 , -2247.703 , 133.4395 , "None"));
Path.Add(new Vector3(-7820.577 , -2248.406 , 133.4395 , "None"));
Path.Add(new Vector3(-7834.473 , -2246.805 , 133.4395 , "None"));
Path.Add(new Vector3(-7848.138 , -2243.776 , 133.44 , "None"));
Path.Add(new Vector3(-7862.151 , -2240.407 , 133.8921 , "None"));
Path.Add(new Vector3(-7873.059 , -2239.58 , 134.1485 , "None"));
Path.Add(new Vector3(-7882.689 , -2239.693 , 133.8307 , "None"));
Path.Add(new Vector3(-7890.108 , -2240.314 , 133.4622 , "None"));
Path.Add(new Vector3(-7895.737 , -2241.106 , 132.9374 , "None"));
Path.Add(new Vector3(-7901.031 , -2243.175 , 128.8245 , "None"));
Path.Add(new Vector3(-7906.326 , -2245.244 , 127.9797 , "None"));
Path.Add(new Vector3(-7914.88 , -2248.586 , 127.9306 , "None"));
Path.Add(new Vector3(-7920.174 , -2250.655 , 127.8358 , "None"));
Path.Add(new Vector3(-7925.468 , -2252.723 , 127.5975 , "None"));
Path.Add(new Vector3(-7932.988 , -2260.679 , 127.3617 , "None"));
Path.Add(new Vector3(-7942.093 , -2271.314 , 127.5491 , "None"));
Path.Add(new Vector3(-7949.391 , -2281.13 , 127.999 , "None"));
Path.Add(new Vector3(-7951.416 , -2283.984 , 128.1219 , "None"));
Path.Add(new Vector3(-7959 , -2294.671 , 128.4411 , "None"));
Path.Add(new Vector3(-7963.31 , -2300.745 , 128.5397 , "None"));
Path.Add(new Vector3(-7969.198 , -2309.438 , 129.2927 , "None"));
Path.Add(new Vector3(-7972.341 , -2314.174 , 131.9058 , "None"));
Path.Add(new Vector3(-7976.671 , -2320.71 , 128.8829 , "None"));
Path.Add(new Vector3(-7980.462 , -2326.053 , 127.6301 , "None"));
Path.Add(new Vector3(-7987.669 , -2332.386 , 127.5605 , "None"));
Path.Add(new Vector3(-7993.55 , -2334.118 , 130.7734 , "None"));
Path.Add(new Vector3(-8003.676 , -2331.558 , 131.3111 , "None"));
Path.Add(new Vector3(-8008.735 , -2329.008 , 130.8603 , "None"));
Path.Add(new Vector3(-8012.689 , -2316.209 , 129.9922 , "None"));
Path.Add(new Vector3(-8009.618 , -2308.613 , 129.9922 , "None"));
Path.Add(new Vector3(-8006.23 , -2304.049 , 129.9922 , "None"));
Path.Add(new Vector3(-7997.415 , -2293.174 , 129.9922 , "None"));
Path.Add(new Vector3(-7988.421 , -2282.445 , 129.9922 , "None"));
Path.Add(new Vector3(-7983.625 , -2276.746 , 129.9922 , "None"));
Path.Add(new Vector3(-7974.61 , -2266.035 , 129.9922 , "None"));
Path.Add(new Vector3(-7970.392 , -2261.022 , 130.0065 , "None"));
Path.Add(new Vector3(-7961.558 , -2250.163 , 128.3512 , "None"));
Path.Add(new Vector3(-7954.77 , -2237.432 , 126.7513 , "None"));
Path.Add(new Vector3(-7952.153 , -2229.539 , 126.0582 , "None"));
Path.Add(new Vector3(-7948.922 , -2215.488 , 125.1224 , "None"));
Path.Add(new Vector3(-7950.168 , -2206.893 , 126.0919 , "None"));
Path.Add(new Vector3(-7957.338 , -2193.848 , 125.379 , "None"));
Path.Add(new Vector3(-7960.229 , -2189.505 , 125.5646 , "None"));
Path.Add(new Vector3(-7969.006 , -2178.606 , 126.0285 , "None"));
Path.Add(new Vector3(-7971.701 , -2175.721 , 126.252 , "None"));
Path.Add(new Vector3(-7980.132 , -2168.737 , 126.4222 , "None"));
Path.Add(new Vector3(-7983.173 , -2166.219 , 126.3814 , "None"));
Path.Add(new Vector3(-7994.272 , -2156.97 , 126.3257 , "None"));
Path.Add(new Vector3(-8001.97 , -2149.249 , 126.7742 , "None"));
Path.Add(new Vector3(-8005.096 , -2145.585 , 126.7852 , "None"));
Path.Add(new Vector3(-8011.62 , -2137.938 , 126.3631 , "None"));
Path.Add(new Vector3(-8018.707 , -2129.63 , 127.4513 , "None"));
Path.Add(new Vector3(-8026.734 , -2122.273 , 124.8052 , "None"));
Path.Add(new Vector3(-8030.383 , -2119.823 , 123.3256 , "None"));
Path.Add(new Vector3(-8036.657 , -2118.11 , 122.7525 , "None"));
Path.Add(new Vector3(-8046.686 , -2120.974 , 123.8441 , "None"));
Path.Add(new Vector3(-8053.112 , -2124.642 , 129.0681 , "None"));
Path.Add(new Vector3(-8060.444 , -2130.141 , 131.187 , "None"));
Path.Add(new Vector3(-8067.343 , -2132.947 , 132.4391 , "None"));
Path.Add(new Vector3(-8073.813 , -2134.147 , 133.208 , "None"));
Path.Add(new Vector3(-8082.953 , -2133.747 , 133.5879 , "None"));
Path.Add(new Vector3(-8091.087 , -2132.136 , 133.902 , "None"));
Path.Add(new Vector3(-8099.371 , -2129.41 , 134.1658 , "None"));
Path.Add(new Vector3(-8106.672 , -2125.428 , 133.9671 , "None"));
Path.Add(new Vector3(-8112.875 , -2121.319 , 133.6257 , "None"));
Path.Add(new Vector3(-8119.9 , -2115.424 , 133.1631 , "None"));
Path.Add(new Vector3(-8124.748 , -2109.77 , 133.3349 , "None"));
Path.Add(new Vector3(-8127.91 , -2105.053 , 133.5177 , "None"));
Path.Add(new Vector3(-8132.416 , -2094.616 , 131.9842 , "None"));
Path.Add(new Vector3(-8134.549 , -2088.422 , 131.6253 , "None"));
Path.Add(new Vector3(-8135.823 , -2081.996 , 131.4464 , "None"));
Path.Add(new Vector3(-8136.05 , -2065.027 , 131.2541 , "None"));
Path.Add(new Vector3(-8131.577 , -2053.22 , 130.8597 , "None"));
Path.Add(new Vector3(-8122.422 , -2042.672 , 130.2104 , "None"));
Path.Add(new Vector3(-8114.445 , -2035.852 , 129.8194 , "None"));
Path.Add(new Vector3(-8103.685 , -2028.378 , 130.846 , "None"));
Path.Add(new Vector3(-8090.301 , -2021.915 , 129.7591 , "None"));
Path.Add(new Vector3(-8077.56 , -2016.111 , 130.2081 , "None"));
Path.Add(new Vector3(-8065.65 , -2010.631 , 131.9257 , "None"));
Path.Add(new Vector3(-8052.333 , -2004.023 , 133.2714 , "None"));
Path.Add(new Vector3(-8045.88 , -2000.361 , 133.3268 , "None"));
Path.Add(new Vector3(-8041.705 , -1997.961 , 134.5566 , "None"));
Path.Add(new Vector3(-8029.567 , -1990.984 , 136.1913 , "None"));
Path.Add(new Vector3(-8017.429 , -1984.007 , 137.0858 , "None"));
Path.Add(new Vector3(-8005.293 , -1977.027 , 138.5641 , "None"));
Path.Add(new Vector3(-7999.642 , -1973.657 , 139.0279 , "None"));
Path.Add(new Vector3(-7989.29 , -1967.137 , 139.7798 , "None"));
Path.Add(new Vector3(-7976.458 , -1957.979 , 137.5086 , "None"));
Path.Add(new Vector3(-7965.298 , -1951.063 , 135.7841 , "None"));
Path.Add(new Vector3(-7953.883 , -1944.63 , 133.9545 , "None"));
Path.Add(new Vector3(-7948.648 , -1942.344 , 133.3259 , "None"));
Path.Add(new Vector3(-7935.642 , -1937.185 , 132.3209 , "None"));
Path.Add(new Vector3(-7921.771 , -1935.389 , 132.4799 , "None"));
Path.Add(new Vector3(-7907.855 , -1933.876 , 132.4823 , "None"));
Path.Add(new Vector3(-7894.673 , -1929.268 , 133.7823 , "None"));
Path.Add(new Vector3(-7890.45 , -1927.016 , 134.3468 , "None"));
Path.Add(new Vector3(-7884.838 , -1923.581 , 135.9516 , "None"));
Path.Add(new Vector3(-7879.979 , -1920.633 , 138.004 , "None"));
Path.Add(new Vector3(-7874.339 , -1919.979 , 142.5921 , "None"));
Path.Add(new Vector3(-7869.569 , -1920.485 , 145.4524 , "None"));
Path.Add(new Vector3(-7865.783 , -1922.674 , 145.5872 , "None"));
Path.Add(new Vector3(-7862.586 , -1924.943 , 146.1148 , "None"));
Path.Add(new Vector3(-7857.743 , -1927.84 , 144.3371 , "None"));
Path.Add(new Vector3(-7855.008 , -1929.195 , 142.5105 , "None"));
Path.Add(new Vector3(-7850.976 , -1930.868 , 141.4041 , "None"));
Path.Add(new Vector3(-7846.42 , -1932.43 , 140.3195 , "None"));
Path.Add(new Vector3(-7842.289 , -1933.848 , 138.9994 , "None"));
Path.Add(new Vector3(-7838.457 , -1934.668 , 137.0956 , "None"));
Path.Add(new Vector3(-7833.761 , -1933.812 , 135.137 , "None"));
Path.Add(new Vector3(-7825.167 , -1927.779 , 134.459 , "None"));
Path.Add(new Vector3(-7814.089 , -1919.258 , 135.2396 , "None"));
Path.Add(new Vector3(-7804.155 , -1909.396 , 134.0387 , "None"));
Path.Add(new Vector3(-7795.943 , -1898.109 , 135.6056 , "None"));
Path.Add(new Vector3(-7789.629 , -1885.614 , 136.3525 , "None"));
Path.Add(new Vector3(-7783.214 , -1873.171 , 135.2691 , "None"));
Path.Add(new Vector3(-7774.667 , -1862.188 , 134.0318 , "None"));
Path.Add(new Vector3(-7764.307 , -1852.772 , 134.4592 , "None"));
Path.Add(new Vector3(-7758.777 , -1847.783 , 134.7003 , "None"));
Path.Add(new Vector3(-7746.922 , -1840.335 , 133.3315 , "None"));
Path.Add(new Vector3(-7743.633 , -1839.139 , 133.2066 , "None"));
Path.Add(new Vector3(-7730.051 , -1834.212 , 133.6296 , "None"));
Path.Add(new Vector3(-7715.817 , -1829.941 , 136.4991 , "None"));
Path.Add(new Vector3(-7710.697 , -1828.845 , 136.6219 , "None"));
Path.Add(new Vector3(-7706.828 , -1828.062 , 136.2164 , "None"));
Path.Add(new Vector3(-7692.986 , -1826.611 , 133.6979 , "None"));
Path.Add(new Vector3(-7679.154 , -1828.664 , 133.0708 , "None"));
Path.Add(new Vector3(-7671.535 , -1831.922 , 133.7839 , "None"));
Path.Add(new Vector3(-7660.079 , -1839.825 , 137.5225 , "None"));
Path.Add(new Vector3(-7657.819 , -1843.047 , 138.2776 , "None"));
Path.Add(new Vector3(-7652.745 , -1856.078 , 139.6123 , "None"));
Path.Add(new Vector3(-7651.114 , -1862.449 , 139.8911 , "None"));
Path.Add(new Vector3(-7647.616 , -1874.144 , 139.9455 , "None"));
Path.Add(new Vector3(-7645.041 , -1879.24 , 140.1016 , "None"));
Path.Add(new Vector3(-7642.236 , -1883.113 , 140.1433 , "None"));
Path.Add(new Vector3(-7636.651 , -1886.585 , 140.4496 , "None"));
Path.Add(new Vector3(-7631.907 , -1888.866 , 141.5139 , "None"));
Path.Add(new Vector3(-7626.012 , -1890.555 , 143.3274 , "None"));
Path.Add(new Vector3(-7620.411 , -1891.511 , 145.1354 , "None"));
Path.Add(new Vector3(-7610.826 , -1892.46 , 150.4963 , "None"));
Path.Add(new Vector3(-7600.815 , -1891.569 , 155.6317 , "None"));
Path.Add(new Vector3(-7596.014 , -1891.274 , 158.2669 , "None"));
Path.Add(new Vector3(-7590.896 , -1892.38 , 161.1609 , "None"));
Path.Add(new Vector3(-7586.806 , -1894.885 , 164.6837 , "None"));
Path.Add(new Vector3(-7580.725 , -1900.558 , 167.4085 , "None"));
Path.Add(new Vector3(-7575.606 , -1905.333 , 170.3505 , "None"));
Path.Add(new Vector3(-7565.69 , -1914.611 , 177.0545 , "None"));
Path.Add(new Vector3(-7562.992 , -1917.965 , 179.2419 , "None"));
Path.Add(new Vector3(-7561.769 , -1925.545 , 181.6855 , "None"));
Path.Add(new Vector3(-7556.057 , -1928.794 , 185.7357 , "None"));
Path.Add(new Vector3(-7550.022 , -1931.343 , 188.4364 , "None"));
Path.Add(new Vector3(-7541.358 , -1935.552 , 186.7777 , "None"));
Path.Add(new Vector3(-7538.21 , -1937.081 , 186.3509 , "None"));
Path.Add(new Vector3(-7532.588 , -1941.92 , 184.759 , "None"));
Path.Add(new Vector3(-7529.604 , -1945.665 , 183.8321 , "None"));
Path.Add(new Vector3(-7534.271 , -1951.396 , 182.03 , "None"));
Path.Add(new Vector3(-7543.211 , -1956.837 , 179.0584 , "None"));
Path.Add(new Vector3(-7550.519 , -1957.792 , 176.7878 , "None"));
Path.Add(new Vector3(-7556.792 , -1955.906 , 175.7434 , "None"));
Path.Add(new Vector3(-7560.583 , -1952.716 , 175.8013 , "None"));
Path.Add(new Vector3(-7563.448 , -1945.842 , 177.4429 , "None"));
Path.Add(new Vector3(-7564.875 , -1940.34 , 178.8395 , "None"));
Path.Add(new Vector3(-7564.556 , -1933.796 , 180.2649 , "None"));
Path.Add(new Vector3(-7563.705 , -1928.177 , 181.2856 , "None"));
Path.Add(new Vector3(-7563.943 , -1924.686 , 180.3369 , "None"));
Path.Add(new Vector3(-7565.467 , -1920.117 , 178.2238 , "None"));
Path.Add(new Vector3(-7567.66 , -1915.332 , 175.9796 , "None"));
Path.Add(new Vector3(-7571.012 , -1910.707 , 173.5402 , "None"));
Path.Add(new Vector3(-7574.475 , -1906.743 , 171.0896 , "None"));
Path.Add(new Vector3(-7577.483 , -1903.576 , 169.3551 , "None"));
Path.Add(new Vector3(-7580.627 , -1900.544 , 167.4396 , "None"));
Path.Add(new Vector3(-7584.4 , -1896.913 , 165.7445 , "None"));
Path.Add(new Vector3(-7587.284 , -1894.218 , 164.4377 , "None"));
Path.Add(new Vector3(-7592.153 , -1891.314 , 160.3789 , "None"));
Path.Add(new Vector3(-7598.001 , -1890.07 , 157.5077 , "None"));
Path.Add(new Vector3(-7603.578 , -1891.257 , 153.9299 , "None"));
Path.Add(new Vector3(-7607.765 , -1892.596 , 151.9322 , "None"));
Path.Add(new Vector3(-7611.253 , -1892.845 , 150.2085 , "None"));
Path.Add(new Vector3(-7615.609 , -1892.52 , 147.7075 , "None"));
Path.Add(new Vector3(-7618.583 , -1891.717 , 146.0405 , "None"));
Path.Add(new Vector3(-7628.921 , -1888.235 , 142.6068 , "None"));
Path.Add(new Vector3(-7639.518 , -1883.074 , 140.7787 , "None"));
Path.Add(new Vector3(-7648.096 , -1876.299 , 139.7184 , "None"));
Path.Add(new Vector3(-7655.573 , -1867.7 , 139.64 , "None"));
Path.Add(new Vector3(-7659.423 , -1862.4 , 139.4381 , "None"));
Path.Add(new Vector3(-7660.781 , -1856.42 , 137.3364 , "None"));
Path.Add(new Vector3(-7662.866 , -1847.476 , 135.8591 , "None"));
Path.Add(new Vector3(-7664.166 , -1844.226 , 135.4844 , "None"));
Path.Add(new Vector3(-7665.976 , -1840.752 , 134.9239 , "None"));
Path.Add(new Vector3(-7678.979 , -1830.394 , 133.1435 , "None"));
Path.Add(new Vector3(-7690.506 , -1822.47 , 133.0798 , "None"));
Path.Add(new Vector3(-7702.137 , -1814.678 , 134.436 , "None"));
Path.Add(new Vector3(-7713.804 , -1806.939 , 134.883 , "None"));
Path.Add(new Vector3(-7725.444 , -1799.161 , 133.4059 , "None"));
Path.Add(new Vector3(-7736.969 , -1791.213 , 133.0574 , "None"));
Path.Add(new Vector3(-7747.774 , -1782.35 , 133.2052 , "None"));
Path.Add(new Vector3(-7757.409 , -1772.193 , 131.7519 , "None"));
Path.Add(new Vector3(-7767.315 , -1761.714 , 133.2692 , "None"));
Path.Add(new Vector3(-7776.644 , -1751.845 , 133.4107 , "None"));
Path.Add(new Vector3(-7786.55 , -1741.367 , 133.1994 , "None"));
Path.Add(new Vector3(-7788.974 , -1738.803 , 133.0188 , "None"));
Path.Add(new Vector3(-7793.475 , -1734.042 , 132.6789 , "None"));
Path.Add(new Vector3(-7799.097 , -1729.215 , 132.5356 , "None"));
Path.Add(new Vector3(-7809.65 , -1725.018 , 133.3525 , "None"));
Path.Add(new Vector3(-7823.237 , -1721.649 , 135.4126 , "None"));
Path.Add(new Vector3(-7833.463 , -1719.314 , 138.0769 , "None"));
Path.Add(new Vector3(-7838.991 , -1717.993 , 139.6237 , "None"));
Path.Add(new Vector3(-7845.003 , -1713.659 , 140.2422 , "None"));
Path.Add(new Vector3(-7849.667 , -1709.063 , 139.8878 , "None"));
Path.Add(new Vector3(-7852.87 , -1702.383 , 139.4713 , "None"));
Path.Add(new Vector3(-7855.635 , -1692.253 , 138.8799 , "None"));
Path.Add(new Vector3(-7856.779 , -1688.038 , 139.9195 , "None"));
Path.Add(new Vector3(-7857.436 , -1684.173 , 139.9387 , "None"));
Path.Add(new Vector3(-7858.164 , -1679.866 , 139.9395 , "None"));
Path.Add(new Vector3(-7859.294 , -1667.656 , 140.0588 , "None"));
Path.Add(new Vector3(-7860.271 , -1661.177 , 139.5075 , "None"));
Path.Add(new Vector3(-7861.135 , -1655.559 , 139.6678 , "None"));
Path.Add(new Vector3(-7861.943 , -1651.723 , 139.997 , "None"));
Path.Add(new Vector3(-7862.756 , -1647.86 , 140.0331 , "None"));
Path.Add(new Vector3(-7863.266 , -1636.476 , 139.9539 , "None"));
Path.Add(new Vector3(-7862.901 , -1624.249 , 139.8763 , "None"));
Path.Add(new Vector3(-7860.702 , -1613.553 , 139.4753 , "None"));
Path.Add(new Vector3(-7858.302 , -1601.527 , 139.5853 , "None"));
Path.Add(new Vector3(-7855.444 , -1595.6 , 139.7303 , "None"));
Path.Add(new Vector3(-7851.929 , -1589.066 , 139.938 , "None"));
Path.Add(new Vector3(-7849.147 , -1584.11 , 139.9785 , "None"));
Path.Add(new Vector3(-7846.799 , -1576.6 , 140.3543 , "None"));
Path.Add(new Vector3(-7842.713 , -1572.651 , 140.4347 , "None"));
Path.Add(new Vector3(-7838.789 , -1569.877 , 138.4283 , "None"));
Path.Add(new Vector3(-7835.476 , -1568.803 , 136.0478 , "None"));
Path.Add(new Vector3(-7828.979 , -1567.953 , 132.9828 , "None"));
Path.Add(new Vector3(-7823.474 , -1566.663 , 131.5888 , "None"));
Path.Add(new Vector3(-7819.207 , -1564.431 , 131.9341 , "None"));
Path.Add(new Vector3(-7811.853 , -1560.547 , 132.597 , "None"));
Path.Add(new Vector3(-7805.76 , -1560.256 , 132.8122 , "None"));
Path.Add(new Vector3(-7801.241 , -1563.688 , 132.6281 , "None"));
Path.Add(new Vector3(-7797.932 , -1569.342 , 132.7767 , "None"));
Path.Add(new Vector3(-7794.42 , -1573.846 , 132.9437 , "None"));
Path.Add(new Vector3(-7789.352 , -1577.975 , 133.2739 , "None"));
Path.Add(new Vector3(-7785.768 , -1579.563 , 133.3513 , "None"));
Path.Add(new Vector3(-7782.381 , -1580.448 , 133.3746 , "None"));
Path.Add(new Vector3(-7764.928 , -1584.503 , 133.4482 , "None"));
Path.Add(new Vector3(-7751.125 , -1586.833 , 132.5811 , "None"));
Path.Add(new Vector3(-7737.291 , -1588.986 , 131.8022 , "None"));
Path.Add(new Vector3(-7723.44 , -1591.021 , 132.3657 , "None"));
Path.Add(new Vector3(-7709.588 , -1593.057 , 132.1228 , "None"));
Path.Add(new Vector3(-7695.715 , -1594.903 , 131.7979 , "None"));
Path.Add(new Vector3(-7682.199 , -1592 , 132.0213 , "None"));
Path.Add(new Vector3(-7676.793 , -1586.974 , 133.7436 , "None"));
Path.Add(new Vector3(-7673.394 , -1574.409 , 133.9409 , "None"));
Path.Add(new Vector3(-7672.045 , -1560.478 , 134.6358 , "None"));
Path.Add(new Vector3(-7670.828 , -1546.531 , 135.129 , "None"));
Path.Add(new Vector3(-7670.336 , -1532.54 , 134.5401 , "None"));
Path.Add(new Vector3(-7669.897 , -1518.547 , 134.2892 , "None"));
Path.Add(new Vector3(-7667.303 , -1504.871 , 134.6119 , "None"));
Path.Add(new Vector3(-7661.593 , -1492.088 , 136.1109 , "None"));
Path.Add(new Vector3(-7657.549 , -1482.856 , 137.0657 , "None"));
Path.Add(new Vector3(-7654.535 , -1474.181 , 137.8155 , "None"));
Path.Add(new Vector3(-7652.09 , -1467.145 , 138.6188 , "None"));
Path.Add(new Vector3(-7649.368 , -1460.215 , 138.2166 , "None"));
Path.Add(new Vector3(-7645.881 , -1452.665 , 137.5725 , "None"));
Path.Add(new Vector3(-7642.423 , -1447.105 , 137.3211 , "None"));
Path.Add(new Vector3(-7635.771 , -1439.569 , 139.2691 , "None"));
Path.Add(new Vector3(-7632.382 , -1436.82 , 140.1802 , "None"));
Path.Add(new Vector3(-7627.392 , -1434.57 , 141.8533 , "None"));
Path.Add(new Vector3(-7623.974 , -1433.115 , 142.9418 , "None"));
Path.Add(new Vector3(-7617.041 , -1432.808 , 145.1132 , "None"));
Path.Add(new Vector3(-7613.783 , -1433.985 , 147.569 , "None"));
Path.Add(new Vector3(-7610.838 , -1436.244 , 149.9317 , "None"));
Path.Add(new Vector3(-7608.21 , -1438.555 , 151.4398 , "None"));
Path.Add(new Vector3(-7605.702 , -1440.674 , 152.7265 , "None"));
Path.Add(new Vector3(-7603.034 , -1442.938 , 154.5208 , "None"));
Path.Add(new Vector3(-7599.559 , -1447.461 , 158.2144 , "None"));
Path.Add(new Vector3(-7597.304 , -1449.962 , 160.363 , "None"));
Path.Add(new Vector3(-7593.393 , -1449.816 , 161.9294 , "None"));
Path.Add(new Vector3(-7588.707 , -1448.797 , 164.4615 , "None"));
Path.Add(new Vector3(-7586.523 , -1445.611 , 166.2372 , "None"));
Path.Add(new Vector3(-7585.408 , -1441.381 , 166.2808 , "None"));
Path.Add(new Vector3(-7584.441 , -1437.792 , 166.8858 , "None"));
Path.Add(new Vector3(-7583.411 , -1433.662 , 167.938 , "None"));
Path.Add(new Vector3(-7582.391 , -1429.632 , 167.0294 , "None"));
Path.Add(new Vector3(-7579.984 , -1426.516 , 166.2229 , "None"));
Path.Add(new Vector3(-7576.676 , -1420.391 , 166.113 , "None"));
Path.Add(new Vector3(-7575.598 , -1416.953 , 166.113 , "None"));
Path.Add(new Vector3(-7575.332 , -1412.248 , 166.2318 , "None"));
Path.Add(new Vector3(-7578.199 , -1409.97 , 166.2667 , "None"));
Path.Add(new Vector3(-7583.02 , -1408.776 , 166.2261 , "None"));
Path.Add(new Vector3(-7587.695 , -1408.665 , 165.5999 , "None"));
Path.Add(new Vector3(-7588.72 , -1404.956 , 164.7299 , "None"));
Path.Add(new Vector3(-7588.449 , -1401.467 , 163.3689 , "None"));
Path.Add(new Vector3(-7587.965 , -1397.894 , 161.9049 , "None"));
Path.Add(new Vector3(-7584.791 , -1393.304 , 161.5844 , "None"));
Path.Add(new Vector3(-7582.275 , -1390.637 , 160.2822 , "None"));
Path.Add(new Vector3(-7583.25 , -1387.709 , 158.0886 , "None"));
Path.Add(new Vector3(-7587.081 , -1382.515 , 151.0275 , "None"));
Path.Add(new Vector3(-7588.614 , -1382.128 , 147.5089 , "None"));
Path.Add(new Vector3(-7591.322 , -1379.933 , 146.1292 , "None"));
Path.Add(new Vector3(-7595.688 , -1378.947 , 143.4743 , "None"));
Path.Add(new Vector3(-7598.914 , -1378.339 , 142.0453 , "None"));
Path.Add(new Vector3(-7603.659 , -1377.057 , 139.9872 , "None"));
Path.Add(new Vector3(-7607.051 , -1376.196 , 137.9138 , "None"));
Path.Add(new Vector3(-7610.397 , -1375.17 , 135.608 , "None"));
Path.Add(new Vector3(-7613.717 , -1374.063 , 133.7134 , "None"));
Path.Add(new Vector3(-7617.014 , -1372.889 , 132.606 , "None"));
Path.Add(new Vector3(-7620.357 , -1371.853 , 131.9407 , "None"));
Path.Add(new Vector3(-7623.768 , -1371.077 , 132.2679 , "None"));
Path.Add(new Vector3(-7627.263 , -1370.992 , 133.3449 , "None"));
Path.Add(new Vector3(-7630.677 , -1371.685 , 134.3545 , "None"));
Path.Add(new Vector3(-7633.743 , -1373.362 , 134.8074 , "None"));
Path.Add(new Vector3(-7638.897 , -1378.065 , 134.4203 , "None"));
Path.Add(new Vector3(-7641.044 , -1380.826 , 134.0383 , "None"));
Path.Add(new Vector3(-7643.446 , -1387.345 , 133.8006 , "None"));
Path.Add(new Vector3(-7643.575 , -1394.318 , 133.9007 , "None"));
Path.Add(new Vector3(-7642.891 , -1397.749 , 134.0607 , "None"));
Path.Add(new Vector3(-7641.996 , -1401.131 , 134.3091 , "None"));
Path.Add(new Vector3(-7640.982 , -1404.481 , 134.7314 , "None"));
Path.Add(new Vector3(-7639.968 , -1407.831 , 135.689 , "None"));
Path.Add(new Vector3(-7638.996 , -1411.194 , 136.8659 , "None"));
Path.Add(new Vector3(-7638.035 , -1414.559 , 138.0442 , "None"));
Path.Add(new Vector3(-7637.073 , -1417.925 , 139.0563 , "None"));
Path.Add(new Vector3(-7636.115 , -1421.291 , 139.6981 , "None"));
Path.Add(new Vector3(-7635.384 , -1424.713 , 139.23 , "None"));
Path.Add(new Vector3(-7634.832 , -1428.169 , 138.4209 , "None"));
Path.Add(new Vector3(-7634.797 , -1431.659 , 138.1102 , "None"));
Path.Add(new Vector3(-7635.321 , -1435.115 , 138.713 , "None"));
Path.Add(new Vector3(-7637.917 , -1441.577 , 138.4704 , "None"));
Path.Add(new Vector3(-7639.897 , -1444.46 , 137.924 , "None"));
Path.Add(new Vector3(-7642.102 , -1447.322 , 137.5788 , "None"));
Path.Add(new Vector3(-7645.889 , -1453.198 , 137.804 , "None"));
Path.Add(new Vector3(-7647.596 , -1456.253 , 137.9762 , "None"));
Path.Add(new Vector3(-7650.187 , -1462.751 , 138.5466 , "None"));
Path.Add(new Vector3(-7651.301 , -1466.069 , 138.8869 , "None"));
Path.Add(new Vector3(-7653.401 , -1472.519 , 138.2498 , "None"));
Path.Add(new Vector3(-7654.551 , -1476.053 , 137.9138 , "None"));
Path.Add(new Vector3(-7656.721 , -1482.709 , 137.3472 , "None"));
Path.Add(new Vector3(-7659.09 , -1489.064 , 136.7738 , "None"));
Path.Add(new Vector3(-7660.492 , -1492.271 , 136.4471 , "None"));
Path.Add(new Vector3(-7661.896 , -1495.476 , 136.2833 , "None"));
Path.Add(new Vector3(-7663.527 , -1499.179 , 136.2105 , "None"));
Path.Add(new Vector3(-7666.273 , -1505.381 , 135.2494 , "None"));
Path.Add(new Vector3(-7667.596 , -1508.621 , 134.5946 , "None"));
Path.Add(new Vector3(-7668.853 , -1511.888 , 134.6576 , "None"));
Path.Add(new Vector3(-7669.881 , -1515.232 , 133.9713 , "None"));
Path.Add(new Vector3(-7670.293 , -1522.205 , 134.4057 , "None"));
Path.Add(new Vector3(-7670.336 , -1525.705 , 134.5445 , "None"));
Path.Add(new Vector3(-7670.38 , -1529.205 , 134.6501 , "None"));
Path.Add(new Vector3(-7670.423 , -1532.704 , 134.5022 , "None"));
Path.Add(new Vector3(-7670.475 , -1536.204 , 134.3158 , "None"));
Path.Add(new Vector3(-7670.589 , -1539.702 , 134.4083 , "None"));
Path.Add(new Vector3(-7670.743 , -1543.199 , 134.7387 , "None"));
Path.Add(new Vector3(-7670.896 , -1546.695 , 135.0903 , "None"));
Path.Add(new Vector3(-7671.1 , -1550.189 , 135.2902 , "None"));
Path.Add(new Vector3(-7671.363 , -1553.679 , 135.2048 , "None"));
Path.Add(new Vector3(-7671.63 , -1557.169 , 135.0518 , "None"));
Path.Add(new Vector3(-7671.95 , -1560.649 , 134.6736 , "None"));
Path.Add(new Vector3(-7672.295 , -1564.131 , 134.3818 , "None"));
Path.Add(new Vector3(-7672.64 , -1567.615 , 134.1949 , "None"));
Path.Add(new Vector3(-7672.985 , -1571.097 , 134.1119 , "None"));
Path.Add(new Vector3(-7673.33 , -1574.58 , 134.0035 , "None"));
Path.Add(new Vector3(-7673.771 , -1578.052 , 134.162 , "None"));
Path.Add(new Vector3(-7674.369 , -1581.5 , 134.3265 , "None"));
Path.Add(new Vector3(-7676.357 , -1588.191 , 133.9092 , "None"));
Path.Add(new Vector3(-7678.336 , -1591.195 , 133.194 , "None"));
Path.Add(new Vector3(-7683.861 , -1595.218 , 131.8484 , "None"));
Path.Add(new Vector3(-7687.433 , -1596.565 , 131.7042 , "None"));
Path.Add(new Vector3(-7693.552 , -1596.706 , 131.8125 , "None"));
Path.Add(new Vector3(-7697.052 , -1596.771 , 131.7134 , "None"));
Path.Add(new Vector3(-7700.552 , -1596.823 , 131.4364 , "None"));
Path.Add(new Vector3(-7707.543 , -1596.599 , 131.5219 , "None"));
Path.Add(new Vector3(-7711.02 , -1596.199 , 131.7634 , "None"));
Path.Add(new Vector3(-7714.48 , -1595.674 , 131.9963 , "None"));
Path.Add(new Vector3(-7717.913 , -1594.993 , 132.1417 , "None"));
Path.Add(new Vector3(-7721.337 , -1594.268 , 132.1246 , "None"));
Path.Add(new Vector3(-7724.748 , -1593.489 , 131.9722 , "None"));
Path.Add(new Vector3(-7730.746 , -1591.811 , 131.7882 , "None"));
Path.Add(new Vector3(-7737.276 , -1589.293 , 131.8134 , "None"));
Path.Add(new Vector3(-7740.503 , -1587.939 , 131.844 , "None"));
Path.Add(new Vector3(-7743.706 , -1586.529 , 131.9313 , "None"));
Path.Add(new Vector3(-7746.863 , -1585.018 , 132.0798 , "None"));
Path.Add(new Vector3(-7749.958 , -1583.385 , 132.3159 , "None"));
Path.Add(new Vector3(-7753.003 , -1581.661 , 132.5928 , "None"));
Path.Add(new Vector3(-7764.347 , -1575.241 , 133.3116 , "None"));
Path.Add(new Vector3(-7775.081 , -1568.494 , 133.4812 , "None"));
Path.Add(new Vector3(-7779.444 , -1565.55 , 133.4525 , "None"));
Path.Add(new Vector3(-7792.141 , -1556.983 , 133.2278 , "None"));
Path.Add(new Vector3(-7803.026 , -1549.638 , 133.8783 , "None"));
Path.Add(new Vector3(-7814.631 , -1541.807 , 132.9388 , "None"));
Path.Add(new Vector3(-7825.952 , -1533.589 , 134.2071 , "None"));
Path.Add(new Vector3(-7832.684 , -1528.707 , 137.0996 , "None"));
Path.Add(new Vector3(-7837.371 , -1525.493 , 137.7539 , "None"));
Path.Add(new Vector3(-7842.238 , -1522.559 , 139.1594 , "None"));
Path.Add(new Vector3(-7847.122 , -1519.651 , 138.7427 , "None"));
Path.Add(new Vector3(-7859.084 , -1514.274 , 138.5031 , "None"));
Path.Add(new Vector3(-7863.691 , -1512.87 , 139.134 , "None"));
Path.Add(new Vector3(-7873.278 , -1509.855 , 141.0916 , "None"));
Path.Add(new Vector3(-7879.036 , -1506.72 , 141.9831 , "None"));
Path.Add(new Vector3(-7881.363 , -1502.516 , 142.9476 , "None"));
Path.Add(new Vector3(-7880.017 , -1498.821 , 143.9779 , "None"));
Path.Add(new Vector3(-7876.327 , -1495.106 , 145.2662 , "None"));
Path.Add(new Vector3(-7872.462 , -1492.232 , 145.2519 , "None"));
Path.Add(new Vector3(-7867.895 , -1488.848 , 144.7948 , "None"));
Path.Add(new Vector3(-7861.661 , -1484.824 , 144.8292 , "None"));
Path.Add(new Vector3(-7858.11 , -1481.577 , 144.6804 , "None"));
Path.Add(new Vector3(-7856.027 , -1476.3 , 143.8951 , "None"));
Path.Add(new Vector3(-7856.877 , -1471.568 , 144.3226 , "None"));
Path.Add(new Vector3(-7859.838 , -1465.691 , 145.7084 , "None"));
Path.Add(new Vector3(-7866.144 , -1453.192 , 144.7948 , "None"));
Path.Add(new Vector3(-7873.687 , -1441.426 , 144.5306 , "None"));
Path.Add(new Vector3(-7884.105 , -1432.189 , 144.7868 , "None"));
Path.Add(new Vector3(-7895.114 , -1426.952 , 148.0047 , "None"));
Path.Add(new Vector3(-7899.471 , -1426.648 , 150.1161 , "None"));
Path.Add(new Vector3(-7902.945 , -1427.077 , 150.0066 , "None"));
Path.Add(new Vector3(-7915.974 , -1428.714 , 143.4603 , "None"));
Path.Add(new Vector3(-7929.936 , -1429.686 , 139.6291 , "None"));
Path.Add(new Vector3(-7943.929 , -1430.117 , 137.4571 , "None"));
Path.Add(new Vector3(-7957.914 , -1430.728 , 137.3195 , "None"));
Path.Add(new Vector3(-7963.552 , -1431.447 , 137.8046 , "None"));
Path.Add(new Vector3(-7971.801 , -1432.499 , 138.6251 , "None"));
Path.Add(new Vector3(-7976.605 , -1432.845 , 139.1444 , "None"));
Path.Add(new Vector3(-7981.365 , -1433.572 , 140.2439 , "None"));
Path.Add(new Vector3(-7986.4 , -1434.933 , 140.0593 , "None"));
Path.Add(new Vector3(-7997.948 , -1441.169 , 141.3673 , "None"));
Path.Add(new Vector3(-8003.641 , -1444.412 , 142.4616 , "None"));
Path.Add(new Vector3(-8006.682 , -1446.144 , 141.9421 , "None"));
Path.Add(new Vector3(-8012.271 , -1449.611 , 142.4872 , "None"));
Path.Add(new Vector3(-8019.543 , -1458.324 , 141.2411 , "None"));
Path.Add(new Vector3(-8022.652 , -1464.089 , 139.6225 , "None"));
Path.Add(new Vector3(-8029.162 , -1476.483 , 136.1915 , "None"));
Path.Add(new Vector3(-8035.254 , -1488.084 , 134.107 , "None"));
Path.Add(new Vector3(-8037.494 , -1492.348 , 134.2771 , "None"));
Path.Add(new Vector3(-8044.657 , -1505.36 , 134.0686 , "None"));
Path.Add(new Vector3(-8051.404 , -1517.626 , 133.7355 , "None"));
Path.Add(new Vector3(-8054.922 , -1524.191 , 135.6745 , "None"));
Path.Add(new Vector3(-8058.389 , -1530.751 , 137.8851 , "None"));
Path.Add(new Vector3(-8065.334 , -1538.625 , 138.8908 , "None"));
Path.Add(new Vector3(-8067.809 , -1541.7 , 137.4671 , "None"));
Path.Add(new Vector3(-8074.134 , -1551.144 , 135.7408 , "None"));
Path.Add(new Vector3(-8077.254 , -1555.928 , 137.88 , "None"));
Path.Add(new Vector3(-8081.308 , -1562.144 , 136.3522 , "None"));
Path.Add(new Vector3(-8088.712 , -1574.021 , 136.2014 , "None"));
Path.Add(new Vector3(-8094.466 , -1583.825 , 137.951 , "None"));
Path.Add(new Vector3(-8097.188 , -1588.815 , 135.6435 , "None"));
Path.Add(new Vector3(-8103.73 , -1600.715 , 133.4595 , "None"));
Path.Add(new Vector3(-8107.877 , -1607.891 , 133.3993 , "None"));
Path.Add(new Vector3(-8112.302 , -1613.314 , 133.3368 , "None"));
Path.Add(new Vector3(-8124.019 , -1623.091 , 133.2385 , "None"));
Path.Add(new Vector3(-8131.188 , -1627.139 , 133.2371 , "None"));
Path.Add(new Vector3(-8138.938 , -1630.149 , 133.619 , "None"));
Path.Add(new Vector3(-8147.073 , -1631.657 , 135.616 , "None"));
Path.Add(new Vector3(-8159.334 , -1631.455 , 133.5588 , "None"));
Path.Add(new Vector3(-8165.721 , -1630.108 , 134.3855 , "None"));
Path.Add(new Vector3(-8170.103 , -1628.115 , 134.4969 , "None"));
Path.Add(new Vector3(-8175.829 , -1624.874 , 134.8234 , "None"));
Path.Add(new Vector3(-8181.807 , -1620.499 , 136.3039 , "None"));
Path.Add(new Vector3(-8186.929 , -1616.415 , 138.311 , "None"));
Path.Add(new Vector3(-8193.2 , -1610.294 , 139.8147 , "None"));
Path.Add(new Vector3(-8201.468 , -1601.952 , 142.536 , "None"));
Path.Add(new Vector3(-8203.332 , -1598.474 , 142.5569 , "None"));
Path.Add(new Vector3(-8205.294 , -1594.075 , 142.5358 , "None"));
Path.Add(new Vector3(-8206.524 , -1589.42 , 142.3682 , "None"));
Path.Add(new Vector3(-8208.24 , -1580.531 , 140.4663 , "None"));
Path.Add(new Vector3(-8205.109 , -1575.291 , 137.2369 , "None"));
Path.Add(new Vector3(-8203.051 , -1572.461 , 135.7582 , "None"));
Path.Add(new Vector3(-8199.196 , -1567.162 , 134.0245 , "None"));
Path.Add(new Vector3(-8194.305 , -1560.437 , 133.5204 , "None"));
Path.Add(new Vector3(-8190.43 , -1555.154 , 133.5204 , "None"));
Path.Add(new Vector3(-8186.782 , -1549.677 , 133.5204 , "None"));
Path.Add(new Vector3(-8184.539 , -1544.457 , 133.5204 , "None"));
Path.Add(new Vector3(-8184.906 , -1537.91 , 133.555 , "None"));
Path.Add(new Vector3(-8186.216 , -1533.276 , 134.5292 , "None"));
Path.Add(new Vector3(-8187.791 , -1530.153 , 136.2134 , "None"));
Path.Add(new Vector3(-8191.61 , -1529.279 , 138.6568 , "None"));
Path.Add(new Vector3(-8195.103 , -1529.116 , 139.55 , "None"));
Path.Add(new Vector3(-8202.944 , -1529.582 , 141.9032 , "None"));
Path.Add(new Vector3(-8209.465 , -1529.007 , 142.5567 , "None"));
Path.Add(new Vector3(-8216.688 , -1523.635 , 142.5567 , "None"));
Path.Add(new Vector3(-8218.22 , -1518.176 , 142.5567 , "None"));
Path.Add(new Vector3(-8218.53 , -1514.27 , 142.5567 , "None"));
Path.Add(new Vector3(-8217.084 , -1500.372 , 142.4883 , "None"));
Path.Add(new Vector3(-8216.348 , -1496.067 , 142.481 , "None"));
Path.Add(new Vector3(-8214.211 , -1484.904 , 142.5571 , "None"));
Path.Add(new Vector3(-8212.5 , -1477.683 , 142.5575 , "None"));
Path.Add(new Vector3(-8209.294 , -1465.874 , 142.6125 , "None"));
Path.Add(new Vector3(-8207.478 , -1460.489 , 142.5601 , "None"));
Path.Add(new Vector3(-8203.048 , -1450.023 , 142.7124 , "None"));
Path.Add(new Vector3(-8200.633 , -1444.846 , 142.6421 , "None"));
Path.Add(new Vector3(-8198.658 , -1441.066 , 142.4438 , "None"));
Path.Add(new Vector3(-8196.816 , -1438.09 , 142.2625 , "None"));
Path.Add(new Vector3(-8194.944 , -1435.134 , 142.1458 , "None"));
Path.Add(new Vector3(-8192.955 , -1432.254 , 142.0695 , "None"));
Path.Add(new Vector3(-8190.908 , -1429.416 , 141.9943 , "None"));
Path.Add(new Vector3(-8188.7 , -1426.701 , 142.0933 , "None"));
Path.Add(new Vector3(-8183.88 , -1421.633 , 141.9716 , "None"));
Path.Add(new Vector3(-8180.917 , -1419.596 , 141.384 , "None"));
Path.Add(new Vector3(-8174.789 , -1416.449 , 140.4869 , "None"));
Path.Add(new Vector3(-8171.604 , -1414.999 , 140.0543 , "None"));
Path.Add(new Vector3(-8168.455 , -1413.473 , 139.4867 , "None"));
Path.Add(new Vector3(-8165.491 , -1411.618 , 138.7638 , "None"));
Path.Add(new Vector3(-8162.933 , -1409.251 , 137.9049 , "None"));
Path.Add(new Vector3(-8160.996 , -1406.34 , 137.1511 , "None"));
Path.Add(new Vector3(-8159.273 , -1403.293 , 136.6201 , "None"));
Path.Add(new Vector3(-8157.631 , -1400.202 , 135.9733 , "None"));
Path.Add(new Vector3(-8155.992 , -1397.11 , 134.9424 , "None"));
Path.Add(new Vector3(-8154.303 , -1393.925 , 134.2953 , "None"));
Path.Add(new Vector3(-8150.98 , -1387.883 , 133.5059 , "None"));
Path.Add(new Vector3(-8149.226 , -1384.856 , 133.2926 , "None"));
Path.Add(new Vector3(-8147.31 , -1381.927 , 133.1815 , "None"));
Path.Add(new Vector3(-8143.417 , -1376.109 , 133.1648 , "None"));
Path.Add(new Vector3(-8141.471 , -1373.2 , 133.2915 , "None"));
Path.Add(new Vector3(-8139.467 , -1370.204 , 133.3936 , "None"));
Path.Add(new Vector3(-8137.521 , -1367.295 , 133.2775 , "None"));
Path.Add(new Vector3(-8133.628 , -1361.477 , 133.2477 , "None"));
Path.Add(new Vector3(-8131.682 , -1358.568 , 133.2746 , "None"));
Path.Add(new Vector3(-8129.735 , -1355.659 , 133.3039 , "None"));
Path.Add(new Vector3(-8125.843 , -1349.841 , 133.3639 , "None"));
Path.Add(new Vector3(-8123.897 , -1346.932 , 133.5865 , "None"));
Path.Add(new Vector3(-8121.951 , -1344.023 , 133.5967 , "None"));
Path.Add(new Vector3(-8119.998 , -1341.118 , 133.4337 , "None"));
Path.Add(new Vector3(-8117.924 , -1338.299 , 133.4483 , "None"));
Path.Add(new Vector3(-8113.646 , -1332.759 , 133.4768 , "None"));
Path.Add(new Vector3(-8109.318 , -1327.263 , 133.5014 , "None"));
Path.Add(new Vector3(-8105.417 , -1321.469 , 133.6849 , "None"));
Path.Add(new Vector3(-8103.877 , -1318.326 , 133.9784 , "None"));
Path.Add(new Vector3(-8102.385 , -1315.16 , 134.9633 , "None"));
Path.Add(new Vector3(-8100.928 , -1311.978 , 135.4659 , "None"));
Path.Add(new Vector3(-8099.68 , -1308.709 , 135.0856 , "None"));
Path.Add(new Vector3(-8098.671 , -1305.359 , 134.2945 , "None"));
Path.Add(new Vector3(-8097.904 , -1301.944 , 133.856 , "None"));
Path.Add(new Vector3(-8097.041 , -1295.01 , 134.2083 , "None"));
Path.Add(new Vector3(-8097.084 , -1291.51 , 135.1812 , "None"));
Path.Add(new Vector3(-8097.255 , -1288.015 , 136.4467 , "None"));
Path.Add(new Vector3(-8097.517 , -1283.206 , 136.8214 , "None"));
Path.Add(new Vector3(-8097.706 , -1279.711 , 136.0592 , "None"));
Path.Add(new Vector3(-8097.538 , -1276.217 , 134.8109 , "None"));
Path.Add(new Vector3(-8097.057 , -1272.752 , 133.916 , "None"));
Path.Add(new Vector3(-8096.461 , -1269.303 , 133.4798 , "None"));
Path.Add(new Vector3(-8095.804 , -1265.866 , 133.4562 , "None"));
Path.Add(new Vector3(-8098.248 , -1261.087 , 133.4173 , "None"));
Path.Add(new Vector3(-8100.37 , -1258.303 , 133.3807 , "None"));
Path.Add(new Vector3(-8102.491 , -1255.52 , 133.3439 , "None"));
Path.Add(new Vector3(-8104.613 , -1252.736 , 133.2981 , "None"));
Path.Add(new Vector3(-8108.925 , -1247.08 , 133.2032 , "None"));
Path.Add(new Vector3(-8111.046 , -1244.297 , 133.1594 , "None"));
Path.Add(new Vector3(-8113.168 , -1241.513 , 133.1186 , "None"));
Path.Add(new Vector3(-8115.298 , -1238.735 , 133.0801 , "None"));
Path.Add(new Vector3(-8120.762 , -1232.458 , 133.0099 , "None"));
Path.Add(new Vector3(-8128.848 , -1223.275 , 132.9395 , "None"));
Path.Add(new Vector3(-8136.083 , -1215.059 , 132.9181 , "None"));
Path.Add(new Vector3(-8139.819 , -1210.775 , 132.922 , "None"));
Path.Add(new Vector3(-8144.9 , -1203.685 , 133.1825 , "None"));
Path.Add(new Vector3(-8147.121 , -1199.891 , 133.8434 , "None"));
Path.Add(new Vector3(-8150.325 , -1191.814 , 137.3851 , "None"));
Path.Add(new Vector3(-8151.365 , -1188.472 , 135.8553 , "None"));
Path.Add(new Vector3(-8154.3 , -1179.298 , 135.124 , "None"));
Path.Add(new Vector3(-8155.377 , -1175.968 , 135.5982 , "None"));
Path.Add(new Vector3(-8157.079 , -1171.017 , 136.5149 , "None"));
Path.Add(new Vector3(-8160.093 , -1162.341 , 138.3656 , "None"));
Path.Add(new Vector3(-8162.47 , -1157.18 , 139.2371 , "None"));
Path.Add(new Vector3(-8166.743 , -1150.075 , 140.6428 , "None"));
Path.Add(new Vector3(-8171.689 , -1141.81 , 142.767 , "None"));
Path.Add(new Vector3(-8174.464 , -1136.849 , 143.3858 , "None"));
Path.Add(new Vector3(-8178.173 , -1132.543 , 144.382 , "None"));
Path.Add(new Vector3(-8182.33 , -1128.666 , 146.7795 , "None"));
Path.Add(new Vector3(-8186.158 , -1125.094 , 147.9357 , "None"));
Path.Add(new Vector3(-8192.25 , -1119.433 , 146.8158 , "None"));
Path.Add(new Vector3(-8202.554 , -1109.962 , 147.815 , "None"));
Path.Add(new Vector3(-8209.01 , -1104.036 , 148.2609 , "None"));
Path.Add(new Vector3(-8214.051 , -1099.813 , 147.9829 , "None"));
Path.Add(new Vector3(-8221.872 , -1094.999 , 146.6222 , "None"));
Path.Add(new Vector3(-8234.895 , -1087.875 , 144.0637 , "None"));
Path.Add(new Vector3(-8248.542 , -1085.479 , 142.7592 , "None"));
Path.Add(new Vector3(-8262.43 , -1087.074 , 143.1057 , "None"));
Path.Add(new Vector3(-8272.774 , -1088.839 , 143.1707 , "None"));
Path.Add(new Vector3(-8277.234 , -1087.194 , 143.1774 , "None"));
Path.Add(new Vector3(-8279.224 , -1081.871 , 143.3009 , "None"));
Path.Add(new Vector3(-8277.006 , -1072.501 , 144.0048 , "None"));
Path.Add(new Vector3(-8262.164 , -1073.009 , 144.045 , "None"));
Path.Add(new Vector3(-8249.198 , -1075.078 , 143.2495 , "None"));
Path.Add(new Vector3(-8236.036 , -1079.622 , 143.2552 , "None"));
Path.Add(new Vector3(-8222.703 , -1086.203 , 145.5618 , "None"));
Path.Add(new Vector3(-8216.833 , -1089.175 , 146.7125 , "None"));
Path.Add(new Vector3(-8203.945 , -1096.579 , 148.5802 , "None"));
Path.Add(new Vector3(-8198.458 , -1100.161 , 148.8552 , "None"));
Path.Add(new Vector3(-8193.771 , -1103.377 , 148.6131 , "None"));
Path.Add(new Vector3(-8189.352 , -1106.951 , 148.2355 , "None"));
Path.Add(new Vector3(-8184.957 , -1107.057 , 147.8845 , "None"));
Path.Add(new Vector3(-8180.148 , -1106.795 , 146.2952 , "None"));
Path.Add(new Vector3(-8175.339 , -1106.533 , 143.6782 , "None"));
Path.Add(new Vector3(-8170.576 , -1105.82 , 141.9673 , "None"));
Path.Add(new Vector3(-8166.755 , -1104.963 , 140.521 , "None"));
Path.Add(new Vector3(-8160.702 , -1102.404 , 138.59 , "None"));
Path.Add(new Vector3(-8152.921 , -1097.473 , 135.855 , "None"));
Path.Add(new Vector3(-8146.909 , -1093.134 , 133.6072 , "None"));
Path.Add(new Vector3(-8143.451 , -1088.594 , 132.4759 , "None"));
Path.Add(new Vector3(-8136.804 , -1076.278 , 131.3423 , "None"));
Path.Add(new Vector3(-8131.61 , -1063.289 , 130.8113 , "None"));
Path.Add(new Vector3(-8126.634 , -1047.423 , 131.004 , "None"));
Path.Add(new Vector3(-8125.59 , -1042.75 , 131.5407 , "None"));
Path.Add(new Vector3(-8124.468 , -1031.86 , 133.6922 , "None"));
Path.Add(new Vector3(-8123.719 , -1026.226 , 133.3642 , "None"));
Path.Add(new Vector3(-8119.242 , -1020.645 , 132.8639 , "None"));
Path.Add(new Vector3(-8109.593 , -1013.084 , 133.406 , "None"));
Path.Add(new Vector3(-8098.663 , -1006.657 , 133.7995 , "None"));
Path.Add(new Vector3(-8091.414 , -1002.64 , 133.7594 , "None"));
Path.Add(new Vector3(-8086.576 , -999.6792 , 133.7071 , "None"));
Path.Add(new Vector3(-8079.604 , -994.3691 , 134.0928 , "None"));
Path.Add(new Vector3(-8071.443 , -985.8257 , 134.2026 , "None"));
Path.Add(new Vector3(-8067.831 , -980.3661 , 135.0779 , "None"));
Path.Add(new Vector3(-8064.142 , -973.9024 , 136.085 , "None"));
Path.Add(new Vector3(-8060.832 , -965.3387 , 137.341 , "None"));
Path.Add(new Vector3(-8058.563 , -956.0073 , 137.4273 , "None"));
Path.Add(new Vector3(-8056.711 , -946.565 , 139.47 , "None"));
Path.Add(new Vector3(-8056.204 , -940.9038 , 139.8283 , "None"));
Path.Add(new Vector3(-8055.686 , -934.3723 , 139.5171 , "None"));
Path.Add(new Vector3(-8054.584 , -929.6918 , 139.3451 , "None"));
Path.Add(new Vector3(-8052.02 , -925.625 , 139.7805 , "None"));
Path.Add(new Vector3(-8048.033 , -923.8574 , 140.1551 , "None"));
Path.Add(new Vector3(-8042.382 , -923.2434 , 139.3138 , "None"));
Path.Add(new Vector3(-8036.937 , -924.8384 , 138.2757 , "None"));
Path.Add(new Vector3(-8031.748 , -927.1547 , 137.608 , "None"));
Path.Add(new Vector3(-8022.732 , -935.428 , 134.6895 , "None"));
Path.Add(new Vector3(-8010.347 , -949.2809 , 131.5446 , "None"));
Path.Add(new Vector3(-8003.94 , -961.6309 , 128.5659 , "None"));
Path.Add(new Vector3(-8000.958 , -975.2666 , 127.6989 , "None"));
Path.Add(new Vector3(-8001.516 , -989.2261 , 127.9464 , "None"));
Path.Add(new Vector3(-8005.77 , -1002.535 , 128.7525 , "None"));
Path.Add(new Vector3(-8011.728 , -1015.203 , 129.3662 , "None"));
Path.Add(new Vector3(-8018.434 , -1027.486 , 129.9812 , "None"));
Path.Add(new Vector3(-8024.961 , -1039.866 , 130.5895 , "None"));
Path.Add(new Vector3(-8029.725 , -1053.02 , 131.0001 , "None"));
Path.Add(new Vector3(-8033.473 , -1066.504 , 131.0881 , "None"));
Path.Add(new Vector3(-8035.993 , -1080.274 , 131.0867 , "None"));
Path.Add(new Vector3(-8037.987 , -1094.131 , 131.0867 , "None"));
Path.Add(new Vector3(-8040.513 , -1107.89 , 131.0867 , "None"));
Path.Add(new Vector3(-8045.025 , -1121.578 , 131.0867 , "None"));
Path.Add(new Vector3(-8050.644 , -1134.398 , 131.0869 , "None"));
Path.Add(new Vector3(-8056.822 , -1146.96 , 131.0871 , "None"));
Path.Add(new Vector3(-8063.038 , -1159.505 , 131.087 , "None"));
Path.Add(new Vector3(-8069.007 , -1172.165 , 131.1013 , "None"));
Path.Add(new Vector3(-8073.28 , -1185.457 , 131.456 , "None"));
Path.Add(new Vector3(-8072.416 , -1199.294 , 132.2072 , "None"));
Path.Add(new Vector3(-8064.47 , -1210.718 , 133.0575 , "None"));
Path.Add(new Vector3(-8054.519 , -1220.564 , 133.4038 , "None"));
Path.Add(new Vector3(-8044.246 , -1230.075 , 133.7626 , "None"));
Path.Add(new Vector3(-8034.138 , -1239.758 , 133.7314 , "None"));
Path.Add(new Vector3(-8027.21 , -1247.08 , 133.617 , "None"));
Path.Add(new Vector3(-8024.727 , -1250.113 , 133.5543 , "None"));
Path.Add(new Vector3(-8017.205 , -1261.9 , 133.4032 , "None"));
Path.Add(new Vector3(-8012.369 , -1275.006 , 132.9689 , "None"));
Path.Add(new Vector3(-8009.664 , -1288.734 , 132.3846 , "None"));
Path.Add(new Vector3(-8008.327 , -1302.662 , 132.4262 , "None"));
Path.Add(new Vector3(-8009.959 , -1316.522 , 132.7956 , "None"));
Path.Add(new Vector3(-8013.689 , -1330.015 , 133.4251 , "None"));
Path.Add(new Vector3(-8018.955 , -1342.968 , 133.4696 , "None"));
Path.Add(new Vector3(-8026.883 , -1356.552 , 133.738 , "None"));
Path.Add(new Vector3(-8035.295 , -1367.743 , 133.6695 , "None"));
Path.Add(new Vector3(-8043.707 , -1378.934 , 133.1406 , "None"));
Path.Add(new Vector3(-8051.024 , -1390.842 , 132.9053 , "None"));
Path.Add(new Vector3(-8057.002 , -1403.496 , 133.293 , "None"));
Path.Add(new Vector3(-8061.055 , -1416.886 , 132.9128 , "None"));
Path.Add(new Vector3(-8063.535 , -1430.659 , 132.2088 , "None"));
Path.Add(new Vector3(-8065.136 , -1444.565 , 132.2787 , "None"));
Path.Add(new Vector3(-8065.008 , -1458.55 , 132.2106 , "None"));
Path.Add(new Vector3(-8060.612 , -1471.739 , 132.6857 , "None"));
Path.Add(new Vector3(-8053.129 , -1483.557 , 133.2213 , "None"));
Path.Add(new Vector3(-8044.765 , -1494.785 , 133.9276 , "None"));
Path.Add(new Vector3(-8035.994 , -1505.696 , 133.9258 , "None"));
Path.Add(new Vector3(-8027.021 , -1516.435 , 133.5843 , "None"));
Path.Add(new Vector3(-8017.645 , -1526.832 , 133.4274 , "None"));
Path.Add(new Vector3(-8008.378 , -1537.324 , 133.0913 , "None"));
Path.Add(new Vector3(-8000.263 , -1548.719 , 132.7494 , "None"));
Path.Add(new Vector3(-7996.173 , -1555.44 , 132.6305 , "None"));
Path.Add(new Vector3(-7989.848 , -1567.887 , 133.0587 , "None"));
Path.Add(new Vector3(-7986.175 , -1580.023 , 133.1962 , "None"));
Path.Add(new Vector3(-7982.876 , -1594.979 , 133.0226 , "None"));
Path.Add(new Vector3(-7979.938 , -1608.667 , 133.435 , "None"));
Path.Add(new Vector3(-7976.955 , -1621.452 , 133.3297 , "None"));
Path.Add(new Vector3(-7974.757 , -1627.621 , 132.9041 , "None"));
Path.Add(new Vector3(-7971.783 , -1641.288 , 133.0704 , "None"));
Path.Add(new Vector3(-7970.926 , -1655.26 , 133.6382 , "None"));
Path.Add(new Vector3(-7970.13 , -1669.237 , 134.8598 , "None"));
Path.Add(new Vector3(-7969.104 , -1683.199 , 136.7059 , "None"));
Path.Add(new Vector3(-7968.069 , -1697.161 , 137.9346 , "None"));
Path.Add(new Vector3(-7967.274 , -1711.137 , 136.8357 , "None"));
Path.Add(new Vector3(-7966.788 , -1725.128 , 134.5958 , "None"));
Path.Add(new Vector3(-7966.615 , -1739.126 , 132.6441 , "None"));
Path.Add(new Vector3(-7966.623 , -1753.126 , 132.1591 , "None"));
Path.Add(new Vector3(-7966.63 , -1767.126 , 132.3209 , "None"));
Path.Add(new Vector3(-7966.879 , -1781.12 , 133.6191 , "None"));
Path.Add(new Vector3(-7968.033 , -1795.073 , 133.6721 , "None"));
Path.Add(new Vector3(-7969.146 , -1809.028 , 133.2701 , "None"));
Path.Add(new Vector3(-7968.743 , -1822.993 , 132.5242 , "None"));
Path.Add(new Vector3(-7964.567 , -1836.296 , 132.9844 , "None"));
Path.Add(new Vector3(-7957.643 , -1848.443 , 132.4993 , "None"));
Path.Add(new Vector3(-7948.259 , -1858.785 , 132.3504 , "None"));
Path.Add(new Vector3(-7935.188 , -1864.593 , 132.8007 , "None"));
Path.Add(new Vector3(-7921.288 , -1866.173 , 132.6727 , "None"));
Path.Add(new Vector3(-7907.725 , -1869.275 , 132.4398 , "None"));
Path.Add(new Vector3(-7896.415 , -1876.684 , 132.769 , "None"));
Path.Add(new Vector3(-7887.868 , -1882.778 , 133.1653 , "None"));
Path.Add(new Vector3(-7881.943 , -1884.27 , 133.9652 , "None"));
Path.Add(new Vector3(-7871.461 , -1884.779 , 135.8501 , "None"));
Path.Add(new Vector3(-7863.795 , -1886.322 , 137.9703 , "None"));
Path.Add(new Vector3(-7857.425 , -1891.616 , 138.6766 , "None"));
Path.Add(new Vector3(-7852.182 , -1896.906 , 138.3765 , "None"));
Path.Add(new Vector3(-7841.4 , -1907.784 , 139.31 , "None"));
Path.Add(new Vector3(-7838.326 , -1910.887 , 139.2721 , "None"));
Path.Add(new Vector3(-7824.786 , -1921.254 , 135.4969 , "None"));
Path.Add(new Vector3(-7813.06 , -1928.9 , 134.0798 , "None"));
Path.Add(new Vector3(-7801.894 , -1935.812 , 133.4455 , "None"));
Path.Add(new Vector3(-7789.253 , -1943.636 , 133.7784 , "None"));
Path.Add(new Vector3(-7778.264 , -1950.821 , 133.6175 , "None"));
Path.Add(new Vector3(-7767.014 , -1959.154 , 133.4671 , "None"));
Path.Add(new Vector3(-7755.615 , -1967.98 , 133.4391 , "None"));
Path.Add(new Vector3(-7745.048 , -1977.823 , 133.4391 , "None"));
Path.Add(new Vector3(-7736.26 , -1987.579 , 133.4391 , "None"));
Path.Add(new Vector3(-7726.925 , -1998.013 , 133.4391 , "None"));
Path.Add(new Vector3(-7717.692 , -2008.533 , 133.4391 , "None"));
Path.Add(new Vector3(-7710.022 , -2020.244 , 133.4391 , "None"));
Path.Add(new Vector3(-7702.846 , -2032.25 , 133.4391 , "None"));
Path.Add(new Vector3(-7697.939 , -2045.338 , 133.3844 , "None"));
Path.Add(new Vector3(-7694.871 , -2058.989 , 132.5696 , "None"));
Path.Add(new Vector3(-7692.147 , -2072.722 , 131.0068 , "None"));
Path.Add(new Vector3(-7687.519 , -2085.875 , 128.8174 , "None"));
Path.Add(new Vector3(-7679.26 , -2097.088 , 128.4093 , "None"));
Path.Add(new Vector3(-7668.555 , -2106.096 , 130.7022 , "None"));
Path.Add(new Vector3(-7656.975 , -2113.956 , 131.4665 , "None"));
Path.Add(new Vector3(-7645.129 , -2121.417 , 133.6409 , "None"));
Path.Add(new Vector3(-7633.283 , -2128.879 , 135.5324 , "None"));
Path.Add(new Vector3(-7621.3 , -2136.116 , 136.4376 , "None"));
Path.Add(new Vector3(-7609.17 , -2143.107 , 142.0354 , "None"));
Path.Add(new Vector3(-7596.672 , -2150.3 , 147.7905 , "None"));
Path.Add(new Vector3(-7583.527 , -2157.237 , 151.1471 , "None"));
Path.Add(new Vector3(-7576.84 , -2160.518 , 152.1793 , "None"));
Path.Add(new Vector3(-7565.004 , -2166.139 , 155.0257 , "None"));
Path.Add(new Vector3(-7560.963 , -2167.872 , 155.9697 , "None"));
Path.Add(new Vector3(-7548.097 , -2173.389 , 157.9477 , "None"));
Path.Add(new Vector3(-7543.246 , -2175.431 , 158.7705 , "None"));
Path.Add(new Vector3(-7537.091 , -2177.676 , 159.2296 , "None"));
Path.Add(new Vector3(-7527.251 , -2179.861 , 160.5436 , "None"));
Path.Add(new Vector3(-7520.822 , -2181.121 , 162.0638 , "None"));
Path.Add(new Vector3(-7515.239 , -2182.189 , 163.1653 , "None"));
IsCompleteWhenAtLastPath = false;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

        








public override bool HasQuest() { return true; }


}


public sealed class GatherBurningSteppesFix : QuestFollowPathClass
{
    public GatherBurningSteppesFix()
    {
        Name = "GatherBurningSteppesFix";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-7520.041 , -2181.032 , 162.2036 , "None"));
Path.Add(new Vector3(-7524.799 , -2180.291 , 161.308 , "None"));
Path.Add(new Vector3(-7538.601 , -2177.983 , 159.1555 , "None"));
Path.Add(new Vector3(-7551.502 , -2172.619 , 157.3906 , "None"));
Path.Add(new Vector3(-7563.993 , -2166.297 , 155.1938 , "None"));
Path.Add(new Vector3(-7576.336 , -2159.697 , 152.2448 , "None"));
Path.Add(new Vector3(-7588.256 , -2152.355 , 150.2491 , "None"));
Path.Add(new Vector3(-7600.387 , -2145.385 , 145.1092 , "None"));
Path.Add(new Vector3(-7613.171 , -2139.694 , 139.4733 , "None"));
Path.Add(new Vector3(-7626.75 , -2136.366 , 135.7677 , "None"));
Path.Add(new Vector3(-7640.557 , -2137.44 , 135.5397 , "None"));
Path.Add(new Vector3(-7653.624 , -2142.459 , 135.5397 , "None"));
Path.Add(new Vector3(-7666.537 , -2147.869 , 132.5324 , "None"));
Path.Add(new Vector3(-7680.104 , -2150.85 , 134.6153 , "None"));
Path.Add(new Vector3(-7687.516 , -2150.525 , 134.1663 , "None"));
Path.Add(new Vector3(-7694.026 , -2150.979 , 133.0757 , "None"));
Path.Add(new Vector3(-7700.487 , -2162.672 , 132.4868 , "None"));
Path.Add(new Vector3(-7706.083 , -2175.491 , 131.8961 , "None"));
Path.Add(new Vector3(-7707.564 , -2189.761 , 134.4811 , "None"));
Path.Add(new Vector3(-7706.832 , -2202.452 , 135.0661 , "None"));
Path.Add(new Vector3(-7706.025 , -2216.429 , 135.7023 , "None"));
Path.Add(new Vector3(-7705.799 , -2220.343 , 136.3289 , "None"));
Path.Add(new Vector3(-7706.106 , -2226.886 , 137.1415 , "None"));
Path.Add(new Vector3(-7707.324 , -2240.833 , 139.2058 , "None"));
Path.Add(new Vector3(-7707.548 , -2248.224 , 139.9882 , "None"));
Path.Add(new Vector3(-7702.944 , -2261.385 , 140.7076 , "None"));
Path.Add(new Vector3(-7695.353 , -2273.101 , 141.4138 , "None"));
Path.Add(new Vector3(-7686.728 , -2283.004 , 141.7334 , "None"));
Path.Add(new Vector3(-7678.93 , -2294.597 , 142.3195 , "None"));
Path.Add(new Vector3(-7673.176 , -2302.843 , 142.4989 , "None"));
Path.Add(new Vector3(-7668.413 , -2305.937 , 142.4929 , "None"));
Path.Add(new Vector3(-7664.504 , -2306.234 , 141.5078 , "None"));
Path.Add(new Vector3(-7650.982 , -2306.47 , 140.0503 , "None"));
Path.Add(new Vector3(-7637.062 , -2306.9 , 139.8019 , "None"));
Path.Add(new Vector3(-7627.099 , -2316.505 , 139.8858 , "None"));
Path.Add(new Vector3(-7620.688 , -2328.933 , 139.7058 , "None"));
Path.Add(new Vector3(-7614.968 , -2341.706 , 139.7772 , "None"));
Path.Add(new Vector3(-7610.123 , -2354.838 , 139.3697 , "None"));
Path.Add(new Vector3(-7606.122 , -2368.253 , 138.8272 , "None"));
Path.Add(new Vector3(-7603.949 , -2382.034 , 138.6117 , "None"));
Path.Add(new Vector3(-7606.749 , -2395.576 , 140.4817 , "None"));
Path.Add(new Vector3(-7615.617 , -2406.31 , 144.2694 , "None"));
Path.Add(new Vector3(-7625.172 , -2416.48 , 144.7124 , "None"));
Path.Add(new Vector3(-7632.485 , -2428.399 , 144.7933 , "None"));
Path.Add(new Vector3(-7642.174 , -2438.5 , 145.5408 , "None"));
Path.Add(new Vector3(-7652.003 , -2448.47 , 146.2796 , "None"));
Path.Add(new Vector3(-7661.565 , -2458.696 , 145.792 , "None"));
Path.Add(new Vector3(-7670.149 , -2468.59 , 144.6316 , "None"));
Path.Add(new Vector3(-7672.356 , -2480.422 , 140.2371 , "None"));
Path.Add(new Vector3(-7668.299 , -2485.443 , 137.9318 , "None"));
Path.Add(new Vector3(-7656.814 , -2493.4 , 134.3959 , "None"));
Path.Add(new Vector3(-7642.982 , -2493.957 , 133.3597 , "None"));
Path.Add(new Vector3(-7629.32 , -2490.945 , 133.338 , "None"));
Path.Add(new Vector3(-7616.088 , -2486.396 , 133.3348 , "None"));
Path.Add(new Vector3(-7603.147 , -2481.066 , 133.5744 , "None"));
Path.Add(new Vector3(-7591.466 , -2473.494 , 136.049 , "None"));
Path.Add(new Vector3(-7586.004 , -2460.857 , 136.12 , "None"));
Path.Add(new Vector3(-7589.467 , -2447.355 , 136.2264 , "None"));
Path.Add(new Vector3(-7589.006 , -2433.396 , 136.4729 , "None"));
Path.Add(new Vector3(-7589.661 , -2419.008 , 137.2911 , "None"));
Path.Add(new Vector3(-7592.607 , -2405.323 , 137.5272 , "None"));
Path.Add(new Vector3(-7595.547 , -2392.094 , 138.0543 , "None"));
Path.Add(new Vector3(-7598.678 , -2378.002 , 138.1538 , "None"));
Path.Add(new Vector3(-7601.715 , -2364.336 , 138.6737 , "None"));
Path.Add(new Vector3(-7604.708 , -2351.119 , 140.2826 , "None"));
Path.Add(new Vector3(-7608.484 , -2337.648 , 140.4452 , "None"));
Path.Add(new Vector3(-7614.78 , -2324.675 , 140.1637 , "None"));
Path.Add(new Vector3(-7624.023 , -2314.256 , 139.8522 , "None"));
Path.Add(new Vector3(-7636.648 , -2308.407 , 139.8066 , "None"));
Path.Add(new Vector3(-7650.445 , -2306.575 , 140.0442 , "None"));
Path.Add(new Vector3(-7664.279 , -2305.794 , 141.5789 , "None"));
Path.Add(new Vector3(-7676.088 , -2298.339 , 142.4551 , "None"));
Path.Add(new Vector3(-7686.023 , -2288.501 , 141.9315 , "None"));
Path.Add(new Vector3(-7695.109 , -2277.851 , 141.5169 , "None"));
Path.Add(new Vector3(-7705.286 , -2268.325 , 141.0074 , "None"));
Path.Add(new Vector3(-7718.347 , -2263.507 , 140.5823 , "None"));
Path.Add(new Vector3(-7732.237 , -2261.817 , 137.4178 , "None"));
Path.Add(new Vector3(-7745.991 , -2259.342 , 134.0946 , "None"));
Path.Add(new Vector3(-7759.465 , -2255.57 , 133.4392 , "None"));
Path.Add(new Vector3(-7772.634 , -2250.817 , 133.7131 , "None"));
Path.Add(new Vector3(-7786.14 , -2247.212 , 133.4393 , "None"));
Path.Add(new Vector3(-7800.038 , -2245.562 , 133.4393 , "None"));
Path.Add(new Vector3(-7813.963 , -2244.117 , 133.4393 , "None"));
Path.Add(new Vector3(-7827.889 , -2242.673 , 133.4393 , "None"));
Path.Add(new Vector3(-7841.814 , -2241.229 , 133.4393 , "None"));
Path.Add(new Vector3(-7855.729 , -2239.695 , 133.4393 , "None"));
Path.Add(new Vector3(-7869.592 , -2237.76 , 133.821 , "None"));
Path.Add(new Vector3(-7883.558 , -2237.213 , 133.4365 , "None"));
Path.Add(new Vector3(-7892.347 , -2239.792 , 133.4359 , "None"));
Path.Add(new Vector3(-7904.509 , -2243.393 , 128.1496 , "None"));
Path.Add(new Vector3(-7917.943 , -2247.334 , 127.6374 , "None"));
Path.Add(new Vector3(-7931.376 , -2251.276 , 127.013 , "None"));
Path.Add(new Vector3(-7941.02 , -2255.144 , 126.8427 , "None"));
Path.Add(new Vector3(-7943.578 , -2258.11 , 127.0212 , "None"));
Path.Add(new Vector3(-7950.808 , -2272.119 , 127.8841 , "None"));
Path.Add(new Vector3(-7957.228 , -2284.56 , 128.5655 , "None"));
Path.Add(new Vector3(-7963.841 , -2296.884 , 128.8728 , "None"));
Path.Add(new Vector3(-7970.091 , -2308.433 , 129.0557 , "None"));
Path.Add(new Vector3(-7973.636 , -2314.983 , 131.8811 , "None"));
Path.Add(new Vector3(-7983.735 , -2328.569 , 127.4619 , "None"));
Path.Add(new Vector3(-7988.262 , -2331.103 , 127.8637 , "None"));
Path.Add(new Vector3(-7998.453 , -2329.479 , 131.4421 , "None"));
Path.Add(new Vector3(-8004.167 , -2324.794 , 130.978 , "None"));
Path.Add(new Vector3(-8003.912 , -2312.421 , 130.2289 , "None"));
Path.Add(new Vector3(-8001.185 , -2306.973 , 130.4689 , "None"));
Path.Add(new Vector3(-7994.086 , -2295.93 , 129.9922 , "None"));
Path.Add(new Vector3(-7986.205 , -2284.36 , 129.9922 , "None"));
Path.Add(new Vector3(-7978.051 , -2272.98 , 129.9922 , "None"));
Path.Add(new Vector3(-7969.942 , -2261.568 , 130.0214 , "None"));
Path.Add(new Vector3(-7962.729 , -2248.59 , 128.4749 , "None"));
Path.Add(new Vector3(-7959.148 , -2235.98 , 127.2301 , "None"));
Path.Add(new Vector3(-7955.944 , -2221.462 , 126.0119 , "None"));
Path.Add(new Vector3(-7953.126 , -2208.635 , 125.6527 , "None"));
Path.Add(new Vector3(-7955.155 , -2194.183 , 125.1354 , "None"));
Path.Add(new Vector3(-7962.517 , -2182.288 , 125.4834 , "None"));
Path.Add(new Vector3(-7969.973 , -2174.367 , 126.0165 , "None"));
Path.Add(new Vector3(-7980.167 , -2164.771 , 126.2158 , "None"));
Path.Add(new Vector3(-7990.36 , -2155.174 , 125.8975 , "None"));
Path.Add(new Vector3(-7994.519 , -2151.259 , 125.5537 , "None"));
Path.Add(new Vector3(-7999.921 , -2146.173 , 125.5514 , "None"));
Path.Add(new Vector3(-8010.115 , -2136.576 , 126.1811 , "None"));
Path.Add(new Vector3(-8020.309 , -2126.98 , 127.739 , "None"));
Path.Add(new Vector3(-8025.462 , -2122.95 , 125.5831 , "None"));
Path.Add(new Vector3(-8030.339 , -2119.978 , 123.357 , "None"));
Path.Add(new Vector3(-8042.622 , -2115.566 , 122.5823 , "None"));
Path.Add(new Vector3(-8056.531 , -2115.412 , 126.6903 , "None"));
Path.Add(new Vector3(-8069.743 , -2120.01 , 132.4461 , "None"));
Path.Add(new Vector3(-8082.854 , -2124.92 , 133.1647 , "None"));
Path.Add(new Vector3(-8096.622 , -2126.982 , 133.728 , "None"));
Path.Add(new Vector3(-8110.326 , -2124.744 , 133.982 , "None"));
Path.Add(new Vector3(-8121.934 , -2117.011 , 133.3978 , "None"));
Path.Add(new Vector3(-8128.736 , -2110.198 , 133.8268 , "None"));
Path.Add(new Vector3(-8131.895 , -2106.027 , 133.6985 , "None"));
Path.Add(new Vector3(-8138.55 , -2090.815 , 132.0405 , "None"));
Path.Add(new Vector3(-8143.949 , -2077.418 , 133.0525 , "None"));
Path.Add(new Vector3(-8144.599 , -2070.453 , 132.3304 , "None"));
Path.Add(new Vector3(-8142.925 , -2063.709 , 131.8978 , "None"));
Path.Add(new Vector3(-8135.667 , -2055.174 , 131.2378 , "None"));
Path.Add(new Vector3(-8123.359 , -2046.833 , 130.1888 , "None"));
Path.Add(new Vector3(-8111.771 , -2038.978 , 129.5953 , "None"));
Path.Add(new Vector3(-8100.9 , -2031.61 , 130.0736 , "None"));
Path.Add(new Vector3(-8089.311 , -2023.756 , 129.549 , "None"));
Path.Add(new Vector3(-8076.694 , -2015.893 , 130.2856 , "None"));
Path.Add(new Vector3(-8064.716 , -2008.646 , 132.0284 , "None"));
Path.Add(new Vector3(-8053.352 , -2002.064 , 133.2717 , "None"));
Path.Add(new Vector3(-8041.237 , -1995.048 , 134.8364 , "None"));
Path.Add(new Vector3(-8033.29 , -1990.445 , 135.7573 , "None"));
Path.Add(new Vector3(-8027.62 , -1987.161 , 135.9085 , "None"));
Path.Add(new Vector3(-8016.121 , -1980.821 , 137.1304 , "None"));
Path.Add(new Vector3(-8003.982 , -1973.852 , 138.541 , "None"));
Path.Add(new Vector3(-8000.988 , -1972.038 , 138.8607 , "None"));
Path.Add(new Vector3(-7989.756 , -1965.235 , 140.1561 , "None"));
Path.Add(new Vector3(-7977.724 , -1958.08 , 137.5148 , "None"));
Path.Add(new Vector3(-7965.037 , -1952.172 , 135.8661 , "None"));
Path.Add(new Vector3(-7951.31 , -1946.468 , 134.1072 , "None"));
Path.Add(new Vector3(-7938.758 , -1942.621 , 133.0544 , "None"));
Path.Add(new Vector3(-7925.183 , -1939.199 , 132.1004 , "None"));
Path.Add(new Vector3(-7911.692 , -1935.574 , 132.1429 , "None"));
Path.Add(new Vector3(-7899.323 , -1929.137 , 132.7812 , "None"));
Path.Add(new Vector3(-7887.545 , -1921.584 , 134.7192 , "None"));
Path.Add(new Vector3(-7874.144 , -1918.26 , 143.0283 , "None"));
Path.Add(new Vector3(-7864.396 , -1923.984 , 145.8183 , "None"));
Path.Add(new Vector3(-7861.609 , -1926.102 , 145.7369 , "None"));
Path.Add(new Vector3(-7855.087 , -1929.615 , 142.7076 , "None"));
Path.Add(new Vector3(-7848.07 , -1932.11 , 140.5512 , "None"));
Path.Add(new Vector3(-7842.561 , -1933.509 , 139.0978 , "None"));
Path.Add(new Vector3(-7839.082 , -1933.897 , 137.5303 , "None"));
Path.Add(new Vector3(-7829.519 , -1930.339 , 134.6295 , "None"));
Path.Add(new Vector3(-7817.803 , -1922.768 , 135.1733 , "None"));
Path.Add(new Vector3(-7807.308 , -1913.504 , 134.3434 , "None"));
Path.Add(new Vector3(-7798.247 , -1902.85 , 134.9292 , "None"));
Path.Add(new Vector3(-7790.101 , -1890.953 , 136.2975 , "None"));
Path.Add(new Vector3(-7782.631 , -1879.612 , 135.1588 , "None"));
Path.Add(new Vector3(-7774.681 , -1867.582 , 133.9569 , "None"));
Path.Add(new Vector3(-7766.178 , -1856.482 , 134.0857 , "None"));
Path.Add(new Vector3(-7756.013 , -1846.869 , 134.4057 , "None"));
Path.Add(new Vector3(-7744.361 , -1839.165 , 133.2089 , "None"));
Path.Add(new Vector3(-7731.4 , -1833.914 , 133.4317 , "None"));
Path.Add(new Vector3(-7717.857 , -1830.412 , 136.2378 , "None"));
Path.Add(new Vector3(-7703.905 , -1829.368 , 135.7091 , "None"));
Path.Add(new Vector3(-7689.924 , -1829.03 , 133.4002 , "None"));
Path.Add(new Vector3(-7676.244 , -1831.535 , 133.2896 , "None"));
Path.Add(new Vector3(-7664.799 , -1839.319 , 135.5511 , "None"));
Path.Add(new Vector3(-7656.728 , -1850.717 , 138.6104 , "None"));
Path.Add(new Vector3(-7650.739 , -1863.338 , 139.8602 , "None"));
Path.Add(new Vector3(-7645.682 , -1876.392 , 140.1321 , "None"));
Path.Add(new Vector3(-7637.993 , -1886.841 , 140.0348 , "None"));
Path.Add(new Vector3(-7630.93 , -1889.115 , 141.8045 , "None"));
Path.Add(new Vector3(-7622.979 , -1891.549 , 144.189 , "None"));
Path.Add(new Vector3(-7615.668 , -1892.953 , 147.7797 , "None"));
Path.Add(new Vector3(-7606.494 , -1892.814 , 152.3988 , "None"));
Path.Add(new Vector3(-7599.497 , -1891.621 , 156.3972 , "None"));
Path.Add(new Vector3(-7594.688 , -1891.408 , 158.9469 , "None"));
Path.Add(new Vector3(-7589.301 , -1893.183 , 162.5261 , "None"));
Path.Add(new Vector3(-7577.739 , -1903.851 , 169.2023 , "None"));
Path.Add(new Vector3(-7567.66 , -1913.567 , 175.6732 , "None"));
Path.Add(new Vector3(-7560.861 , -1923.29 , 182.3179 , "None"));
Path.Add(new Vector3(-7556.571 , -1928.279 , 185.5021 , "None"));
Path.Add(new Vector3(-7550.793 , -1932.933 , 188.0052 , "None"));
Path.Add(new Vector3(-7537.976 , -1940.467 , 185.2561 , "None"));
Path.Add(new Vector3(-7525.907 , -1947.562 , 183.8471 , "None"));
Path.Add(new Vector3(-7522.412 , -1950.813 , 183.6807 , "None"));
Path.Add(new Vector3(-7516.714 , -1961.456 , 184.4628 , "None"));
Path.Add(new Vector3(-7517.743 , -1965.693 , 185.3804 , "None"));
Path.Add(new Vector3(-7520.216 , -1969.785 , 186.4293 , "None"));
Path.Add(new Vector3(-7525.013 , -1969.9 , 185.9754 , "None"));
Path.Add(new Vector3(-7539.132 , -1962.116 , 179.9931 , "None"));
Path.Add(new Vector3(-7552.584 , -1958.24 , 176.2222 , "None"));
Path.Add(new Vector3(-7558.311 , -1956.104 , 175.515 , "None"));
Path.Add(new Vector3(-7562.14 , -1952.69 , 175.6811 , "None"));
Path.Add(new Vector3(-7565.456 , -1946.025 , 176.8499 , "None"));
Path.Add(new Vector3(-7566.233 , -1938.629 , 178.1846 , "None"));
Path.Add(new Vector3(-7566.137 , -1932.95 , 179.5955 , "None"));
Path.Add(new Vector3(-7565.099 , -1926.452 , 180.5485 , "None"));
Path.Add(new Vector3(-7565.436 , -1921.684 , 178.5951 , "None"));
Path.Add(new Vector3(-7568.062 , -1913.832 , 175.513 , "None"));
Path.Add(new Vector3(-7572.399 , -1906.739 , 172.2913 , "None"));
Path.Add(new Vector3(-7577.206 , -1902.248 , 169.5793 , "None"));
Path.Add(new Vector3(-7581.683 , -1898.745 , 166.8541 , "None"));
Path.Add(new Vector3(-7585.638 , -1895.998 , 165.196 , "None"));
Path.Add(new Vector3(-7590.345 , -1892.763 , 161.6152 , "None"));
Path.Add(new Vector3(-7594.047 , -1890.395 , 159.5739 , "None"));
Path.Add(new Vector3(-7597.954 , -1890.71 , 157.386 , "None"));
Path.Add(new Vector3(-7603.508 , -1891.9 , 153.8965 , "None"));
Path.Add(new Vector3(-7606.842 , -1892.964 , 152.2405 , "None"));
Path.Add(new Vector3(-7613.14 , -1892.407 , 149.376 , "None"));
Path.Add(new Vector3(-7625.61 , -1888.294 , 143.8475 , "None"));
Path.Add(new Vector3(-7629.279 , -1886.836 , 142.7118 , "None"));
Path.Add(new Vector3(-7641.164 , -1881.299 , 140.7397 , "None"));
Path.Add(new Vector3(-7647.523 , -1875.941 , 139.8389 , "None"));
Path.Add(new Vector3(-7658.229 , -1866.919 , 139.6404 , "None"));
Path.Add(new Vector3(-7668.934 , -1857.897 , 135.9845 , "None"));
Path.Add(new Vector3(-7679.64 , -1848.875 , 135.7192 , "None"));
Path.Add(new Vector3(-7690.345 , -1839.854 , 133.445 , "None"));
Path.Add(new Vector3(-7701.051 , -1830.832 , 135.0106 , "None"));
Path.Add(new Vector3(-7711.756 , -1821.81 , 136.2392 , "None"));
Path.Add(new Vector3(-7722.462 , -1812.788 , 135.5224 , "None"));
Path.Add(new Vector3(-7733.167 , -1803.767 , 134.1173 , "None"));
Path.Add(new Vector3(-7744.194 , -1794.474 , 133.5053 , "None"));
Path.Add(new Vector3(-7754.579 , -1785.723 , 133.0053 , "None"));
Path.Add(new Vector3(-7764.994 , -1776.38 , 132.3402 , "None"));
Path.Add(new Vector3(-7773.674 , -1765.401 , 133.4654 , "None"));
Path.Add(new Vector3(-7782.241 , -1754.328 , 133.3809 , "None"));
Path.Add(new Vector3(-7790.843 , -1743.283 , 133.1236 , "None"));
Path.Add(new Vector3(-7796.944 , -1735.83 , 132.6305 , "None"));
Path.Add(new Vector3(-7800.44 , -1732.524 , 132.5188 , "None"));
Path.Add(new Vector3(-7808.213 , -1728.56 , 132.7392 , "None"));
Path.Add(new Vector3(-7821.26 , -1723.482 , 134.761 , "None"));
Path.Add(new Vector3(-7834.271 , -1718.319 , 138.5399 , "None"));
Path.Add(new Vector3(-7842.038 , -1714.329 , 140.6286 , "None"));
Path.Add(new Vector3(-7847.59 , -1709.491 , 140.2034 , "None"));
Path.Add(new Vector3(-7852.929 , -1699.07 , 139.9373 , "None"));
Path.Add(new Vector3(-7855.887 , -1689.935 , 139.7408 , "None"));
Path.Add(new Vector3(-7857.906 , -1677.866 , 140.0164 , "None"));
Path.Add(new Vector3(-7859.495 , -1667.487 , 140.0202 , "None"));
Path.Add(new Vector3(-7860.024 , -1664.027 , 139.9057 , "None"));
Path.Add(new Vector3(-7862.143 , -1650.188 , 140.0507 , "None"));
Path.Add(new Vector3(-7862.93 , -1641.924 , 140.0822 , "None"));
Path.Add(new Vector3(-7862.618 , -1634.513 , 139.9418 , "None"));
Path.Add(new Vector3(-7860.714 , -1620.651 , 139.265 , "None"));
Path.Add(new Vector3(-7858.304 , -1611.764 , 139.2646 , "None"));
Path.Add(new Vector3(-7854.82 , -1600.947 , 139.516 , "None"));
Path.Add(new Vector3(-7851.614 , -1592.311 , 139.8193 , "None"));
Path.Add(new Vector3(-7847.841 , -1582.513 , 140.2004 , "None"));
Path.Add(new Vector3(-7845.653 , -1577.237 , 140.8351 , "None"));
Path.Add(new Vector3(-7843.079 , -1573.167 , 140.5492 , "None"));
Path.Add(new Vector3(-7837.832 , -1569.245 , 137.68 , "None"));
Path.Add(new Vector3(-7833.543 , -1568.415 , 135.87 , "None"));
Path.Add(new Vector3(-7828.815 , -1567.5 , 132.9614 , "None"));
Path.Add(new Vector3(-7822.732 , -1567.44 , 131.5869 , "None"));
Path.Add(new Vector3(-7817.064 , -1567.875 , 132.2554 , "None"));
Path.Add(new Vector3(-7812.853 , -1569.032 , 135.8144 , "None"));
Path.Add(new Vector3(-7808.293 , -1570.583 , 136.5026 , "None"));
Path.Add(new Vector3(-7794.685 , -1576.528 , 132.9501 , "None"));
Path.Add(new Vector3(-7789.478 , -1578.874 , 133.2471 , "None"));
Path.Add(new Vector3(-7777.515 , -1578.266 , 133.4253 , "None"));
Path.Add(new Vector3(-7775.321 , -1573.232 , 133.4846 , "None"));
Path.Add(new Vector3(-7776.464 , -1565.076 , 133.4744 , "None"));
Path.Add(new Vector3(-7782.972 , -1559.901 , 133.412 , "None"));
Path.Add(new Vector3(-7785.76 , -1557.785 , 133.3811 , "None"));
Path.Add(new Vector3(-7797.097 , -1549.58 , 133.5531 , "None"));
Path.Add(new Vector3(-7808.805 , -1541.905 , 133.3911 , "None"));
Path.Add(new Vector3(-7820.573 , -1534.323 , 134.0293 , "None"));
Path.Add(new Vector3(-7831.792 , -1525.95 , 137.3444 , "None"));
Path.Add(new Vector3(-7841.605 , -1518.644 , 138.4096 , "None"));
Path.Add(new Vector3(-7852.296 , -1516.284 , 138.2858 , "None"));
Path.Add(new Vector3(-7865.171 , -1513.725 , 139.292 , "None"));
Path.Add(new Vector3(-7872.583 , -1512.996 , 141.2003 , "None"));
Path.Add(new Vector3(-7877.381 , -1506.592 , 141.8593 , "None"));
Path.Add(new Vector3(-7879.888 , -1498.566 , 144.038 , "None"));
Path.Add(new Vector3(-7875.854 , -1495.183 , 145.3794 , "None"));
Path.Add(new Vector3(-7864.556 , -1486.923 , 144.7948 , "None"));
Path.Add(new Vector3(-7859.769 , -1482.515 , 144.7543 , "None"));
Path.Add(new Vector3(-7856.992 , -1468.624 , 145.5702 , "None"));
Path.Add(new Vector3(-7863.041 , -1456.732 , 144.9012 , "None"));
Path.Add(new Vector3(-7871.651 , -1445.693 , 144.6983 , "None"));
Path.Add(new Vector3(-7881.367 , -1435.057 , 144.5544 , "None"));
Path.Add(new Vector3(-7893.211 , -1427.836 , 146.8776 , "None"));
Path.Add(new Vector3(-7896.993 , -1426.868 , 149.0214 , "None"));
Path.Add(new Vector3(-7900.472 , -1426.486 , 150.2693 , "None"));
Path.Add(new Vector3(-7903.968 , -1426.647 , 149.9507 , "None"));
Path.Add(new Vector3(-7917.953 , -1427.289 , 142.2561 , "None"));
Path.Add(new Vector3(-7931.938 , -1427.931 , 138.8051 , "None"));
Path.Add(new Vector3(-7945.932 , -1428.376 , 136.5678 , "None"));
Path.Add(new Vector3(-7959.915 , -1429.04 , 137.0101 , "None"));
Path.Add(new Vector3(-7973.863 , -1430.228 , 138.54 , "None"));
Path.Add(new Vector3(-7987.746 , -1431.833 , 140.0271 , "None"));
Path.Add(new Vector3(-7997.206 , -1433.602 , 140.2392 , "None"));
Path.Add(new Vector3(-8010.798 , -1436.957 , 140.1587 , "None"));
Path.Add(new Vector3(-8016.343 , -1438.327 , 140.9968 , "None"));
Path.Add(new Vector3(-8021.598 , -1445.236 , 140.2253 , "None"));
Path.Add(new Vector3(-8027.822 , -1457.776 , 138.6207 , "None"));
Path.Add(new Vector3(-8034.046 , -1470.317 , 136.1065 , "None"));
Path.Add(new Vector3(-8040.271 , -1482.857 , 134.0032 , "None"));
Path.Add(new Vector3(-8046.109 , -1494.62 , 133.9108 , "None"));
Path.Add(new Vector3(-8052.226 , -1508.166 , 134.3659 , "None"));
Path.Add(new Vector3(-8055.166 , -1515.01 , 133.4143 , "None"));
Path.Add(new Vector3(-8058.105 , -1521.853 , 134.5119 , "None"));
Path.Add(new Vector3(-8062.935 , -1533.096 , 139.0644 , "None"));
Path.Add(new Vector3(-8065.199 , -1538.309 , 139.05 , "None"));
Path.Add(new Vector3(-8070.369 , -1548.934 , 134.8795 , "None"));
Path.Add(new Vector3(-8076.833 , -1561.349 , 136.0389 , "None"));
Path.Add(new Vector3(-8083.909 , -1573.429 , 137.1155 , "None"));
Path.Add(new Vector3(-8091.647 , -1585.089 , 139.0918 , "None"));
Path.Add(new Vector3(-8099.845 , -1596.437 , 133.4881 , "None"));
Path.Add(new Vector3(-8108.044 , -1607.785 , 133.4005 , "None"));
Path.Add(new Vector3(-8110.864 , -1611.689 , 133.3576 , "None"));
Path.Add(new Vector3(-8121.709 , -1621.409 , 133.2479 , "None"));
Path.Add(new Vector3(-8127.357 , -1621.041 , 133.304 , "None"));
Path.Add(new Vector3(-8132.399 , -1613.23 , 133.5938 , "None"));
Path.Add(new Vector3(-8131.573 , -1607.609 , 136.1227 , "None"));
Path.Add(new Vector3(-8129.227 , -1602.431 , 137.0382 , "None"));
Path.Add(new Vector3(-8120.886 , -1591.412 , 133.5973 , "None"));
Path.Add(new Vector3(-8110.619 , -1581.901 , 133.5998 , "None"));
Path.Add(new Vector3(-8099.242 , -1573.748 , 134.6351 , "None"));
Path.Add(new Vector3(-8087.083 , -1566.809 , 133.9568 , "None"));
Path.Add(new Vector3(-8074.914 , -1559.888 , 135.6368 , "None"));
Path.Add(new Vector3(-8062.78 , -1552.905 , 133.2201 , "None"));
Path.Add(new Vector3(-8052.396 , -1546.382 , 138.1685 , "None"));
Path.Add(new Vector3(-8047.642 , -1543.267 , 137.6245 , "None"));
Path.Add(new Vector3(-8036.224 , -1535.18 , 134.7069 , "None"));
Path.Add(new Vector3(-8032.667 , -1522.002 , 133.2397 , "None"));
Path.Add(new Vector3(-8036.986 , -1508.872 , 133.6965 , "None"));
Path.Add(new Vector3(-8044.189 , -1496.884 , 133.9781 , "None"));
Path.Add(new Vector3(-8051.769 , -1485.113 , 133.2979 , "None"));
Path.Add(new Vector3(-8056.514 , -1477.744 , 133.0752 , "None"));
Path.Add(new Vector3(-8063.291 , -1465.53 , 132.2211 , "None"));
Path.Add(new Vector3(-8067.661 , -1452.245 , 131.8639 , "None"));
Path.Add(new Vector3(-8070.106 , -1438.465 , 131.8162 , "None"));
Path.Add(new Vector3(-8070.673 , -1424.488 , 131.8047 , "None"));
Path.Add(new Vector3(-8069.428 , -1409.68 , 131.9297 , "None"));
Path.Add(new Vector3(-8066.54 , -1396.879 , 132.4459 , "None"));
Path.Add(new Vector3(-8061.374 , -1383.893 , 133.3181 , "None"));
Path.Add(new Vector3(-8055.223 , -1371.319 , 134.2282 , "None"));
Path.Add(new Vector3(-8048.404 , -1358.107 , 135.3202 , "None"));
Path.Add(new Vector3(-8042.441 , -1345.447 , 134.4883 , "None"));
Path.Add(new Vector3(-8038.135 , -1332.138 , 133.9279 , "None"));
Path.Add(new Vector3(-8035.853 , -1319.224 , 133.6849 , "None"));
Path.Add(new Vector3(-8035.153 , -1310.067 , 132.4067 , "None"));
Path.Add(new Vector3(-8035.748 , -1297.041 , 132.2847 , "None"));
Path.Add(new Vector3(-8040.17 , -1289.555 , 133.6263 , "None"));
Path.Add(new Vector3(-8049.91 , -1279.517 , 138.1419 , "None"));
Path.Add(new Vector3(-8060.868 , -1270.81 , 139.0915 , "None"));
Path.Add(new Vector3(-8064.018 , -1268.477 , 139.6807 , "None"));
Path.Add(new Vector3(-8069.426 , -1264.729 , 139.8838 , "None"));
Path.Add(new Vector3(-8076.975 , -1259.498 , 134.4701 , "None"));
Path.Add(new Vector3(-8088.48 , -1251.525 , 133.3817 , "None"));
Path.Add(new Vector3(-8095.315 , -1246.789 , 133.1641 , "None"));
Path.Add(new Vector3(-8100.701 , -1243.057 , 133.0959 , "None"));
Path.Add(new Vector3(-8103.946 , -1240.808 , 133.0605 , "None"));
Path.Add(new Vector3(-8116.196 , -1231.662 , 132.952 , "None"));
Path.Add(new Vector3(-8127.39 , -1223.255 , 132.9181 , "None"));
Path.Add(new Vector3(-8138.133 , -1214.284 , 132.9431 , "None"));
Path.Add(new Vector3(-8147.755 , -1204.126 , 133.484 , "None"));
Path.Add(new Vector3(-8150.741 , -1200.347 , 134.6172 , "None"));
Path.Add(new Vector3(-8154.992 , -1194.243 , 136.5461 , "None"));
Path.Add(new Vector3(-8156.035 , -1187.847 , 135.7126 , "None"));
Path.Add(new Vector3(-8159.496 , -1176.778 , 136.8691 , "None"));
Path.Add(new Vector3(-8165.418 , -1164.106 , 139.0784 , "None"));
Path.Add(new Vector3(-8167.833 , -1158.029 , 140.2469 , "None"));
Path.Add(new Vector3(-8171.866 , -1144.675 , 142.9595 , "None"));
Path.Add(new Vector3(-8174.941 , -1138.872 , 143.8666 , "None"));
Path.Add(new Vector3(-8181.078 , -1130.913 , 145.3415 , "None"));
Path.Add(new Vector3(-8191.127 , -1120.536 , 146.9773 , "None"));
Path.Add(new Vector3(-8201.426 , -1111.053 , 147.6467 , "None"));
Path.Add(new Vector3(-8211.829 , -1103.054 , 148.127 , "None"));
Path.Add(new Vector3(-8225.26 , -1096.85 , 146.1134 , "None"));
Path.Add(new Vector3(-8238.301 , -1095.668 , 143.7617 , "None"));
Path.Add(new Vector3(-8253.137 , -1096.567 , 143.0324 , "None"));
Path.Add(new Vector3(-8267.083 , -1096.83 , 143.414 , "None"));
Path.Add(new Vector3(-8275.731 , -1092.037 , 143.2936 , "None"));
Path.Add(new Vector3(-8279.145 , -1087.516 , 143.1953 , "None"));
Path.Add(new Vector3(-8279.619 , -1081.044 , 143.354 , "None"));
Path.Add(new Vector3(-8276.682 , -1076.178 , 143.7023 , "None"));
Path.Add(new Vector3(-8270.538 , -1072.141 , 144.2654 , "None"));
Path.Add(new Vector3(-8257.084 , -1068.698 , 144.1095 , "None"));
Path.Add(new Vector3(-8243.09 , -1068.619 , 143.1727 , "None"));
Path.Add(new Vector3(-8229.093 , -1068.911 , 143.0036 , "None"));
Path.Add(new Vector3(-8222.727 , -1070.208 , 143.3213 , "None"));
Path.Add(new Vector3(-8212.267 , -1067.704 , 143.3851 , "None"));
Path.Add(new Vector3(-8200.803 , -1059.679 , 145.294 , "None"));
Path.Add(new Vector3(-8195.514 , -1055.815 , 147.1979 , "None"));
Path.Add(new Vector3(-8189.959 , -1050.852 , 146.8185 , "None"));
Path.Add(new Vector3(-8179.228 , -1041.875 , 142.9801 , "None"));
Path.Add(new Vector3(-8174.23 , -1041.971 , 143.1702 , "None"));
Path.Add(new Vector3(-8174.327 , -1051.152 , 142.6234 , "None"));
Path.Add(new Vector3(-8174.741 , -1065.566 , 142.6621 , "None"));
Path.Add(new Vector3(-8174.753 , -1073.011 , 142.2284 , "None"));
Path.Add(new Vector3(-8173.066 , -1081.536 , 143.1645 , "None"));
Path.Add(new Vector3(-8173.435 , -1089.816 , 144.6325 , "None"));
Path.Add(new Vector3(-8174.056 , -1103.802 , 143.6369 , "None"));
Path.Add(new Vector3(-8174.678 , -1117.788 , 142.4612 , "None"));
Path.Add(new Vector3(-8175.11 , -1131.778 , 143.7473 , "None"));
Path.Add(new Vector3(-8171.528 , -1144.382 , 142.736 , "None"));
Path.Add(new Vector3(-8164.872 , -1151.827 , 140.1065 , "None"));
Path.Add(new Vector3(-8160.833 , -1153.371 , 139.0083 , "None"));
Path.Add(new Vector3(-8149.495 , -1154.144 , 135.6974 , "None"));
Path.Add(new Vector3(-8132.892 , -1154.146 , 132.714 , "None"));
Path.Add(new Vector3(-8118.893 , -1154.061 , 131.2713 , "None"));
Path.Add(new Vector3(-8105.243 , -1151.228 , 130.7751 , "None"));
Path.Add(new Vector3(-8092.591 , -1145.351 , 130.7549 , "None"));
Path.Add(new Vector3(-8082.34 , -1135.993 , 131.201 , "None"));
Path.Add(new Vector3(-8074.314 , -1124.528 , 131.0192 , "None"));
Path.Add(new Vector3(-8067.367 , -1112.406 , 131.255 , "None"));
Path.Add(new Vector3(-8061.771 , -1101.046 , 131.1504 , "None"));
Path.Add(new Vector3(-8059.463 , -1096.819 , 131.426 , "None"));
Path.Add(new Vector3(-8054.489 , -1086.597 , 130.7305 , "None"));
Path.Add(new Vector3(-8052.279 , -1081.823 , 130.97 , "None"));
Path.Add(new Vector3(-8052.299 , -1073.543 , 130.5353 , "None"));
Path.Add(new Vector3(-8057.821 , -1058.812 , 129.104 , "None"));
Path.Add(new Vector3(-8059.832 , -1054.436 , 128.857 , "None"));
Path.Add(new Vector3(-8066.39 , -1042.082 , 129.2909 , "None"));
Path.Add(new Vector3(-8074.393 , -1031.696 , 129.767 , "None"));
Path.Add(new Vector3(-8078.415 , -1028.367 , 130.3306 , "None"));
Path.Add(new Vector3(-8089.803 , -1023.822 , 131.025 , "None"));
Path.Add(new Vector3(-8103.696 , -1018.527 , 132.569 , "None"));
Path.Add(new Vector3(-8116.163 , -1014.398 , 133.435 , "None"));
Path.Add(new Vector3(-8129.426 , -1009.92 , 134.1264 , "None"));
Path.Add(new Vector3(-8135.641 , -1005.922 , 134.4002 , "None"));
Path.Add(new Vector3(-8145.176 , -1000.547 , 134.9802 , "None"));
Path.Add(new Vector3(-8152.198 , -1002.555 , 135.2717 , "None"));
Path.Add(new Vector3(-8155.033 , -1007.472 , 134.5877 , "None"));
Path.Add(new Vector3(-8155.108 , -1014.886 , 133.8983 , "None"));
Path.Add(new Vector3(-8152.745 , -1021.475 , 133.6887 , "None"));
Path.Add(new Vector3(-8146.874 , -1028.407 , 133.121 , "None"));
Path.Add(new Vector3(-8140.311 , -1031.825 , 132.8575 , "None"));
Path.Add(new Vector3(-8132.507 , -1031.651 , 133.355 , "None"));
Path.Add(new Vector3(-8122.704 , -1029.356 , 133.2451 , "None"));
Path.Add(new Vector3(-8109.409 , -1024.981 , 132.126 , "None"));
Path.Add(new Vector3(-8096.916 , -1018.688 , 132.3502 , "None"));
Path.Add(new Vector3(-8085.586 , -1010.57 , 132.9978 , "None"));
Path.Add(new Vector3(-8077.252 , -999.3272 , 133.4123 , "None"));
Path.Add(new Vector3(-8069.733 , -987.5348 , 133.4355 , "None"));
Path.Add(new Vector3(-8063.535 , -974.9882 , 135.8171 , "None"));
Path.Add(new Vector3(-8059 , -961.7562 , 137.0536 , "None"));
Path.Add(new Vector3(-8057.614 , -956.2439 , 137.0486 , "None"));
Path.Add(new Vector3(-8056.198 , -948.5075 , 138.8353 , "None"));
Path.Add(new Vector3(-8055.703 , -942.8453 , 138.9414 , "None"));
Path.Add(new Vector3(-8055.284 , -935.4091 , 139.391 , "None"));
Path.Add(new Vector3(-8054.415 , -930.6773 , 139.1201 , "None"));
Path.Add(new Vector3(-8051.117 , -927.204 , 139.4065 , "None"));
Path.Add(new Vector3(-8045.718 , -925.4347 , 139.1739 , "None"));
Path.Add(new Vector3(-8041.826 , -925.9019 , 138.3538 , "None"));
Path.Add(new Vector3(-8037.261 , -927.397 , 137.5936 , "None"));
Path.Add(new Vector3(-8031.261 , -930.0218 , 136.9046 , "None"));
Path.Add(new Vector3(-8024.686 , -933.4603 , 135.2833 , "None"));
Path.Add(new Vector3(-8018.656 , -937.0113 , 133.743 , "None"));
Path.Add(new Vector3(-8008.322 , -945.0786 , 131.061 , "None"));
Path.Add(new Vector3(-8001.603 , -955.2183 , 129.0459 , "None"));
Path.Add(new Vector3(-8000.466 , -958.9672 , 128.5405 , "None"));
Path.Add(new Vector3(-8000.012 , -972.83 , 127.749 , "None"));
Path.Add(new Vector3(-8001.983 , -986.6879 , 127.8502 , "None"));
Path.Add(new Vector3(-8005.353 , -1000.264 , 128.541 , "None"));
Path.Add(new Vector3(-8010.993 , -1013.068 , 129.2818 , "None"));
Path.Add(new Vector3(-8017.709 , -1025.348 , 129.8749 , "None"));
Path.Add(new Vector3(-8024.729 , -1037.46 , 130.5765 , "None"));
Path.Add(new Vector3(-8030.727 , -1050.1 , 130.8909 , "None"));
Path.Add(new Vector3(-8034.014 , -1063.652 , 131.0876 , "None"));
Path.Add(new Vector3(-8035.568 , -1077.565 , 131.0876 , "None"));
Path.Add(new Vector3(-8037.405 , -1091.442 , 131.0876 , "None"));
Path.Add(new Vector3(-8040.068 , -1105.184 , 131.0876 , "None"));
Path.Add(new Vector3(-8043.851 , -1118.657 , 131.0876 , "None"));
Path.Add(new Vector3(-8049.014 , -1131.664 , 131.0876 , "None"));
Path.Add(new Vector3(-8054.942 , -1144.347 , 131.0876 , "None"));
Path.Add(new Vector3(-8060.941 , -1156.996 , 131.0882 , "None"));
Path.Add(new Vector3(-8066.999 , -1169.618 , 131.0868 , "None"));
Path.Add(new Vector3(-8072.356 , -1182.539 , 131.43 , "None"));
Path.Add(new Vector3(-8072.727 , -1196.456 , 132.1839 , "None"));
Path.Add(new Vector3(-8067.172 , -1209.115 , 132.9071 , "None"));
Path.Add(new Vector3(-8057.803 , -1219.508 , 133.4489 , "None"));
Path.Add(new Vector3(-8048.192 , -1229.688 , 133.8119 , "None"));
Path.Add(new Vector3(-8038.613 , -1239.897 , 133.7676 , "None"));
Path.Add(new Vector3(-8029.827 , -1251.326 , 133.3399 , "None"));
Path.Add(new Vector3(-8024.22 , -1263.652 , 133.1403 , "None"));
Path.Add(new Vector3(-8019.331 , -1277.238 , 133.5208 , "None"));
Path.Add(new Vector3(-8016.634 , -1290.502 , 133.6672 , "None"));
Path.Add(new Vector3(-8016.326 , -1304.486 , 133.5403 , "None"));
Path.Add(new Vector3(-8017.501 , -1318.431 , 133.7355 , "None"));
Path.Add(new Vector3(-8019.961 , -1332.204 , 133.8615 , "None"));
Path.Add(new Vector3(-8024.12 , -1346.031 , 133.4716 , "None"));
Path.Add(new Vector3(-8029.666 , -1358.884 , 133.7469 , "None"));
Path.Add(new Vector3(-8035.763 , -1371.486 , 133.5014 , "None"));
Path.Add(new Vector3(-8042.014 , -1384.012 , 132.9416 , "None"));
Path.Add(new Vector3(-8048.259 , -1396.542 , 132.8846 , "None"));
Path.Add(new Vector3(-8053.038 , -1409.679 , 133.377 , "None"));
Path.Add(new Vector3(-8055.556 , -1422.56 , 132.8743 , "None"));
Path.Add(new Vector3(-8056.698 , -1436.505 , 132.7916 , "None"));
Path.Add(new Vector3(-8055.594 , -1451.282 , 133.91 , "None"));
Path.Add(new Vector3(-8052.754 , -1464.985 , 133.7552 , "None"));
Path.Add(new Vector3(-8051.832 , -1468.361 , 133.674 , "None"));
Path.Add(new Vector3(-8046.058 , -1485.314 , 133.7015 , "None"));
Path.Add(new Vector3(-8040.043 , -1496.984 , 134.0559 , "None"));
Path.Add(new Vector3(-8032.709 , -1508.907 , 133.8042 , "None"));
Path.Add(new Vector3(-8025.222 , -1520.737 , 133.4218 , "None"));
Path.Add(new Vector3(-8017.735 , -1532.567 , 133.2369 , "None"));
Path.Add(new Vector3(-8009.784 , -1545.13 , 132.6619 , "None"));
Path.Add(new Vector3(-8002.365 , -1557.002 , 132.4036 , "None"));
Path.Add(new Vector3(-7995.797 , -1569.363 , 132.7868 , "None"));
Path.Add(new Vector3(-7990.499 , -1581.374 , 132.9432 , "None"));
Path.Add(new Vector3(-7985.828 , -1594.571 , 133.1038 , "None"));
Path.Add(new Vector3(-7981.752 , -1607.952 , 133.3573 , "None"));
Path.Add(new Vector3(-7978.42 , -1621.548 , 133.18 , "None"));
Path.Add(new Vector3(-7975.464 , -1635.231 , 132.5187 , "None"));
Path.Add(new Vector3(-7973.081 , -1649.024 , 133.6791 , "None"));
Path.Add(new Vector3(-7971.251 , -1662.902 , 134.0455 , "None"));
Path.Add(new Vector3(-7969.968 , -1676.843 , 135.879 , "None"));
Path.Add(new Vector3(-7969.42 , -1688.198 , 137.2094 , "None"));
Path.Add(new Vector3(-7969.144 , -1694.772 , 137.8273 , "None"));
Path.Add(new Vector3(-7968.556 , -1708.76 , 137.3738 , "None"));
Path.Add(new Vector3(-7967.968 , -1722.747 , 135.0346 , "None"));
Path.Add(new Vector3(-7967.381 , -1736.735 , 132.9324 , "None"));
Path.Add(new Vector3(-7966.793 , -1750.723 , 132.1559 , "None"));
Path.Add(new Vector3(-7966.339 , -1764.715 , 132.1748 , "None"));
Path.Add(new Vector3(-7965.996 , -1776.078 , 133.5584 , "None"));
Path.Add(new Vector3(-7966.615 , -1789.19 , 133.837 , "None"));
Path.Add(new Vector3(-7967.722 , -1803.146 , 133.2248 , "None"));
Path.Add(new Vector3(-7968.65 , -1817.111 , 132.4179 , "None"));
Path.Add(new Vector3(-7967.184 , -1831.017 , 133.1217 , "None"));
Path.Add(new Vector3(-7964.313 , -1844.717 , 132.7268 , "None"));
Path.Add(new Vector3(-7960.72 , -1858.246 , 132.4843 , "None"));
Path.Add(new Vector3(-7956.937 , -1871.725 , 132.4093 , "None"));
Path.Add(new Vector3(-7954.575 , -1880.136 , 132.2146 , "None"));
Path.Add(new Vector3(-7951.652 , -1890.22 , 132.0073 , "None"));
Path.Add(new Vector3(-7949.17 , -1897.242 , 132.1672 , "None"));
Path.Add(new Vector3(-7947.251 , -1902.593 , 132.2892 , "None"));
Path.Add(new Vector3(-7943.199 , -1913.691 , 130.7201 , "None"));
Path.Add(new Vector3(-7940.06 , -1920.401 , 131.7845 , "None"));
Path.Add(new Vector3(-7927.145 , -1931.298 , 132.2416 , "None"));
Path.Add(new Vector3(-7914.339 , -1936.951 , 132.285 , "None"));
Path.Add(new Vector3(-7902.341 , -1944.038 , 132.8995 , "None"));
Path.Add(new Vector3(-7893.338 , -1954.635 , 133.6486 , "None"));
Path.Add(new Vector3(-7891.805 , -1957.781 , 133.8551 , "None"));
Path.Add(new Vector3(-7888.739 , -1966.438 , 134.4703 , "None"));
Path.Add(new Vector3(-7885.663 , -1975.121 , 134.8259 , "None"));
Path.Add(new Vector3(-7875.658 , -1982.905 , 135.3578 , "None"));
Path.Add(new Vector3(-7871.669 , -1985.604 , 136.4625 , "None"));
Path.Add(new Vector3(-7864.608 , -1989.944 , 138.4507 , "None"));
Path.Add(new Vector3(-7849.553 , -1991.747 , 138.8049 , "None"));
Path.Add(new Vector3(-7836.723 , -1989.305 , 139.5633 , "None"));
Path.Add(new Vector3(-7823.472 , -1984.787 , 135.728 , "None"));
Path.Add(new Vector3(-7809.87 , -1982.008 , 133.8373 , "None"));
Path.Add(new Vector3(-7796.263 , -1985.092 , 134.8389 , "None"));
Path.Add(new Vector3(-7782.919 , -1989.33 , 135.1432 , "None"));
Path.Add(new Vector3(-7769.576 , -1993.567 , 134.3116 , "None"));
Path.Add(new Vector3(-7756.233 , -1997.805 , 133.4801 , "None"));
Path.Add(new Vector3(-7742.96 , -2002.248 , 133.5957 , "None"));
Path.Add(new Vector3(-7730.684 , -2008.891 , 133.5238 , "None"));
Path.Add(new Vector3(-7720.002 , -2017.902 , 133.4391 , "None"));
Path.Add(new Vector3(-7711.078 , -2028.674 , 133.4391 , "None"));
Path.Add(new Vector3(-7703.465 , -2040.418 , 133.4391 , "None"));
Path.Add(new Vector3(-7696.256 , -2052.419 , 133.0525 , "None"));
Path.Add(new Vector3(-7689.371 , -2064.605 , 131.4709 , "None"));
Path.Add(new Vector3(-7683.235 , -2077.184 , 129.0206 , "None"));
Path.Add(new Vector3(-7677.33 , -2089.877 , 127.4354 , "None"));
Path.Add(new Vector3(-7669.214 , -2101.181 , 128.9844 , "None"));
Path.Add(new Vector3(-7658.25 , -2109.865 , 130.8635 , "None"));
Path.Add(new Vector3(-7646.915 , -2118.08 , 132.729 , "None"));
Path.Add(new Vector3(-7635.138 , -2125.649 , 135.3085 , "None"));
Path.Add(new Vector3(-7622.957 , -2133.333 , 135.8904 , "None"));
Path.Add(new Vector3(-7611.571 , -2140.735 , 140.411 , "None"));
Path.Add(new Vector3(-7599.849 , -2148.39 , 146.2715 , "None"));
Path.Add(new Vector3(-7588.082 , -2155.975 , 150.3963 , "None"));
Path.Add(new Vector3(-7575.883 , -2162.836 , 152.5973 , "None"));
Path.Add(new Vector3(-7570.661 , -2165.065 , 153.7509 , "None"));
Path.Add(new Vector3(-7557.341 , -2169.378 , 157.0045 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

        








public override bool HasQuest() { return true; }


}


public sealed class GatherBurningSteppesBandAid : QuestFollowPathClass
{
    public GatherBurningSteppesBandAid()
    {
        Name = "GatherBurningSteppesBandAid";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-7504.03 , -2187.54 , 165.53 , "None"));
Path.Add(new Vector3(-7508.267 , -2186.065 , 164.4737 , "None"));
Path.Add(new Vector3(-7511.573 , -2184.914 , 163.9295 , "None"));
Path.Add(new Vector3(-7514.878 , -2183.763 , 163.2704 , "None"));
Path.Add(new Vector3(-7518.184 , -2182.612 , 162.5862 , "None"));
Path.Add(new Vector3(-7521.569 , -2181.786 , 161.8992 , "None"));
Path.Add(new Vector3(-7525.043 , -2181.357 , 161.1527 , "None"));
Path.Add(new Vector3(-7528.517 , -2180.927 , 160.1532 , "None"));
Path.Add(new Vector3(-7531.99 , -2180.498 , 159.5624 , "None"));
Path.Add(new Vector3(-7535.451 , -2179.978 , 159.2539 , "None"));
Path.Add(new Vector3(-7538.888 , -2179.319 , 159.1224 , "None"));
Path.Add(new Vector3(-7542.295 , -2178.519 , 158.9357 , "None"));
Path.Add(new Vector3(-7545.697 , -2177.698 , 158.3964 , "None"));
Path.Add(new Vector3(-7549.285 , -2176.73 , 157.7949 , "None"));
Path.Add(new Vector3(-7555.693 , -2174.514 , 157.1048 , "None"));
Path.Add(new Vector3(-7558.947 , -2173.227 , 156.9669 , "None"));
Path.Add(new Vector3(-7562.139 , -2171.79 , 156.432 , "None"));
Path.Add(new Vector3(-7565.313 , -2170.316 , 155.9214 , "None"));
Path.Add(new Vector3(-7568.454 , -2168.772 , 155.0753 , "None"));
Path.Add(new Vector3(-7571.583 , -2167.206 , 153.7881 , "None"));
Path.Add(new Vector3(-7574.764 , -2165.494 , 153.1305 , "None"));
Path.Add(new Vector3(-7580.727 , -2162.047 , 151.8205 , "None"));
Path.Add(new Vector3(-7583.844 , -2160.221 , 151.3483 , "None"));
Path.Add(new Vector3(-7589.797 , -2156.54 , 150.1284 , "None"));
Path.Add(new Vector3(-7592.723 , -2154.618 , 149.584 , "None"));
Path.Add(new Vector3(-7598.529 , -2150.708 , 147.3744 , "None"));
Path.Add(new Vector3(-7601.336 , -2148.812 , 145.9268 , "None"));
Path.Add(new Vector3(-7604.329 , -2146.789 , 144.4996 , "None"));
Path.Add(new Vector3(-7607.241 , -2144.847 , 143.1971 , "None"));
Path.Add(new Vector3(-7610.199 , -2142.975 , 141.5975 , "None"));
Path.Add(new Vector3(-7613.249 , -2141.263 , 139.9167 , "None"));
Path.Add(new Vector3(-7616.441 , -2139.83 , 138.4012 , "None"));
Path.Add(new Vector3(-7619.742 , -2138.67 , 137.3067 , "None"));
Path.Add(new Vector3(-7623.129 , -2137.79 , 136.3733 , "None"));
Path.Add(new Vector3(-7626.555 , -2137.075 , 135.8216 , "None"));
Path.Add(new Vector3(-7630.001 , -2136.468 , 135.5888 , "None"));
Path.Add(new Vector3(-7636.954 , -2136.96 , 135.5397 , "None"));
Path.Add(new Vector3(-7643.731 , -2138.704 , 135.5397 , "None"));
Path.Add(new Vector3(-7650.326 , -2141.044 , 135.5397 , "None"));
Path.Add(new Vector3(-7656.769 , -2143.781 , 135.1441 , "None"));
Path.Add(new Vector3(-7659.982 , -2145.167 , 132.5319 , "None"));
Path.Add(new Vector3(-7666.414 , -2147.932 , 132.5319 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

        








public override bool HasQuest() { return true; }


}

