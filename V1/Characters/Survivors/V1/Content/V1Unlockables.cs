using V1.Survivors.V1.Achievements;
using RoR2;
using UnityEngine;

namespace V1.Survivors.V1
{
    public static class V1Unlockables
    {
        public static UnlockableDef characterUnlockableDef = null;
        public static UnlockableDef masterySkinUnlockableDef = null;

        public static void Init()
        {
            masterySkinUnlockableDef = V1Mod.Modules.Content.CreateAndAddUnlockbleDef(
                V1MasteryAchievement.unlockableIdentifier,
                V1Mod.Modules.Tokens.GetAchievementNameToken(V1MasteryAchievement.identifier),
                V1Survivor.instance.assetBundle.LoadAsset<Sprite>("texMasteryAchievement"));
        }
    }
}
