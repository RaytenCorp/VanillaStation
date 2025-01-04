using Robust.Shared.GameStates;
using Content.Shared.Vanilla.Skill;

namespace Content.Server.Vanilla.Skill;


[RegisterComponent]
public sealed partial class GunTrainerComponent : Component
{
    [DataField("ExpPerShot")]
    public int ExpPerShot { get; set; } = 1;

    [DataField("skillType")]
    public skillType SkillType { get; set; } = skillType.RangeWeapon;

}

