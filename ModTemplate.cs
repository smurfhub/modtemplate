using BepInEx;

namespace ModTemplate
{
    [BepInPlugin("es.smurfhub.modtemplate", "ModTemplate", "0.1.0")]
    public class ModTemplatePlugin : BaseUnityPlugin
    {
        private void Awake()
        {
            Logger.LogInfo("Paco fuma tabaco.");
        }
    }
}
