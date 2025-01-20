using Robust.Shared.GameStates;
using Content.Shared.Vanilla.Skill;

namespace Content.Server.Vanilla.Skill
{
    [RegisterComponent]
    public sealed partial class GunCanBeFallComponent : Component
    {
        [DataField("RequiresRangeWeaponLevel")]
        public SkillLevel RequiresRangeWeaponLevel { get; set; } = SkillLevel.Basic;

        [DataField("Recoil")]
        public float Recoil { get; set; } = 10f;

        [DataField("ChanceToFallPerLevel")]
        public float ChanceToFallPerLevel { get; set; } = 0.5f;
    }
}
