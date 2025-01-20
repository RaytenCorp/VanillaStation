using Robust.Shared.GameStates;
using Robust.Shared.Serialization;

namespace Content.Shared.Vanilla.Skill
{
    [RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
    public sealed partial class RequiresSkillComponent : Component
    {
        //Химия
        [DataField("RequiresChemistryLevel"), AutoNetworkedField]
        public SkillLevel RequiresChemistryLevel { get; set; } = 0;

        //Медицина
        [DataField("RequiresMedicineLevel"), AutoNetworkedField]
        public SkillLevel RequiresMedicineLevel { get; set; } = 0;

        //Пилотирование
        [DataField("RequiresPilotingLevel"), AutoNetworkedField]
        public SkillLevel RequiresPilotingLevel { get; set; } = 0;
        [DataField("RequiresPilotingLevelForMap"), AutoNetworkedField]
        public SkillLevel RequiresPilotingLevelForMap { get; set; } = 0;
        [DataField("RequiresPilotingLevelForCoord"), AutoNetworkedField]
        public SkillLevel RequiresPilotingLevelForCoord { get; set; } = 0;

        //Исследования
        [DataField("RequiresResearchLevel"), AutoNetworkedField]
        public SkillLevel RequiresResearchLevel { get; set; } = 0;

        //Приборостроение
        [DataField("RequiresInstrumentationLevel"), AutoNetworkedField]
        public SkillLevel RequiresInstrumentationLevel { get; set; } = 0;

        //Инженерия
        [DataField("RequiresEngineeringLevel"), AutoNetworkedField]
        public SkillLevel RequiresEngineeringLevel { get; set; } = 0;

        //Строительство
        [DataField("RequiresBuildingLevel"), AutoNetworkedField]
        public SkillLevel RequiresBuildingLevel { get; set; } = 0;
    }
}
