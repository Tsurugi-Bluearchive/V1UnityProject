using RoR2;
using V1Mod.Modules.Achievements;

namespace V1.Survivors.V1.Achievements
{
    //automatically creates language tokens "ACHIEVMENT_{identifier.ToUpper()}_NAME" and "ACHIEVMENT_{identifier.ToUpper()}_DESCRIPTION" 
    [RegisterAchievement(identifier, unlockableIdentifier, null, 10, null)]
    public class V1MasteryAchievement : BaseMasteryAchievement
    {
        public const string identifier = V1Survivor.V1_PREFIX + "masteryAchievement";
        public const string unlockableIdentifier = V1Survivor.V1_PREFIX + "masteryUnlockable";

        public override string RequiredCharacterBody => V1Survivor.instance.bodyName;

        //difficulty coeff 3 is monsoon. 3.5 is typhoon for grandmastery skins
        public override float RequiredDifficultyCoefficient => 3;
    }
}