using Robust.Shared.GameStates;
using Content.Shared.Vanilla.Skill;

namespace Content.Server.Vanilla.Skill
{
    [RegisterComponent]
    public sealed partial class EmitSkillExperienceOnSpawnComponent : Component
    {
        [DataField("radius")]
        public float Radius { get; set; } = 12.0f;

        [DataField("experienceAmount")]
        public int ExperienceAmount { get; set; } = 600;

        [DataField("skilltype")]
        public skillType SkillType { get; set; } = skillType.Engineering; 
    }
}
