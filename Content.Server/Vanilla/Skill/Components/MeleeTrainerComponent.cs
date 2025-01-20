using Robust.Shared.GameStates;
using Content.Shared.Vanilla.Skill;

namespace Content.Server.Vanilla.Skill;


[RegisterComponent]
public sealed partial class MeleeTrainerComponent : Component
{
    [DataField("ExpPerHit")]
    public int ExpPerHit { get; set; } = 1;

    [DataField("skillType")]
    public skillType SkillType { get; set; } = skillType.MeleeWeapon;

}

