using V1.Survivors.V1.SkillStates;

namespace V1.Survivors.V1
{
    public static class V1States
    {
        public static void Init()
        {
            V1Mod.Modules.Content.AddEntityState(typeof(SlashCombo));

            V1Mod.Modules.Content.AddEntityState(typeof(Shoot));

            V1Mod.Modules.Content.AddEntityState(typeof(Roll));

            V1Mod.Modules.Content.AddEntityState(typeof(ThrowBomb));
        }
    }
}
