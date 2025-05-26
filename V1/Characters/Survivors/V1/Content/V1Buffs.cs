using RoR2;
using UnityEngine;

namespace V1.Survivors.V1
{
    public static class V1Buffs
    {
        // armor buff gained during roll
        public static BuffDef armorBuff;

        public static void Init(AssetBundle assetBundle)
        {
            armorBuff = V1Mod.Modules.Content.CreateAndAddBuff("V1ArmorBuff",
                LegacyResourcesAPI.Load<BuffDef>("BuffDefs/HiddenInvincibility").iconSprite,
                Color.white,
                false,
                false);

        }
    }
}
