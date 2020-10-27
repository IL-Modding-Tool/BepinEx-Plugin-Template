using BepInEx;
using BepInEx.Configuration;
using BepInEx.Harmony;
using BepInEx.Logging;
using HarmonyLib;

namespace ExampleProject
{
    [BepInPlugin(Constant.GUID, Constant.NAME, Constant.VERSION)]
    public class ExampleProjectPlugin : BaseUnityPlugin
    {
        private static ManualLogSource _logger;

        private void Start()
        {
            _logger = Logger;
            Harmony.CreateAndPatchAll(typeof(ExampleProjectPlugin));
        }

    }
}