using System.Collections.Generic;

public static class Constant
{
    public const string GUID = "__PLUGIN_GUID__";
#if HS2
    public const string NAME = "__PLUGIN_NAME__ for HS2";
#elif AI
    public const string NAME = "__PLUGIN_NAME__ for AI";
#else
    public const string NAME = "__PLUGIN_NAME__";
#endif
    public const string VERSION = "__PLUGIN_VERSION__";
}