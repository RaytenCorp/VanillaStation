using Content.Shared.Interaction;
using Content.Shared.Popups;
using Content.Shared.Vanilla.Skill;
using Robust.Shared.Audio;
using Robust.Shared.GameObjects;

namespace Content.Shared.SkillTrainer;

[RegisterComponent]
public sealed partial class SkillBookComponent : Component
{
    [DataField("skillIncreaseAmount")]
    public int SkillIncreaseAmount { get; set; } = 30;

    [DataField("skillType")]
    public skillType SkillType = skillType.Piloting;
    
    [DataField("basereadTime")]
    public float BaseReadTime { get; set; } = 3f; 
}

