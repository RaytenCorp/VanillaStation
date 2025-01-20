using Robust.Shared.GameStates;
using Robust.Shared.Serialization;
using Content.Shared.Vanilla.Skill;

namespace Content.Shared.SkillTrainer;

[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
public sealed partial class SkillLearnerComponent : Component
{
    //Пилотирование
    [DataField("PilotingExpToLearn"), AutoNetworkedField]
    public int PilotingExpToLearn { get; set; } = 900;

    //Стрельба
    [DataField("RangeWeaponExpToLearn"), AutoNetworkedField]
    public int RangeWeaponExpToLearn { get; set; } = 900;

    //Ближний бой
    [DataField("MeleeWeaponExpToLearn"), AutoNetworkedField]
    public int MeleeWeaponExpToLearn { get; set; } = 900;

    //Медицина
    [DataField("MedicineExpToLearn"), AutoNetworkedField]
    public int MedicineExpToLearn { get; set; } = 900;

    //Химия
    [DataField("ChemistryExpToLearn"), AutoNetworkedField]
    public int ChemistryExpToLearn { get; set; } = 900;

    //Инженерия
    [DataField("EngineeringExpToLearn"), AutoNetworkedField]
    public int EngineeringExpToLearn { get; set; } = 900;

    //Строительство
    [DataField("BuildingExpToLearn"), AutoNetworkedField]
    public int BuildingExpToLearn { get; set; } = 900;

    //Исследования
    [DataField("ResearchExpToLearn"), AutoNetworkedField]
    public int ResearchExpToLearn { get; set; } = 900;

    //Приборостроение
    [DataField("InstrumentationExpToLearn"), AutoNetworkedField]
    public int InstrumentationExpToLearn { get; set; } = 900;


    //получить доступное количество опыта на обучение
    public int GetSkillExpToLearn(skillType skill)
    {
        return skill switch
        {
            skillType.Chemistry => ChemistryExpToLearn,
            skillType.Medicine => MedicineExpToLearn,
            skillType.RangeWeapon => RangeWeaponExpToLearn,
            skillType.MeleeWeapon => MeleeWeaponExpToLearn,
            skillType.Piloting => PilotingExpToLearn,
            skillType.Research => ResearchExpToLearn,
            skillType.Instrumentation => InstrumentationExpToLearn,
            skillType.Building => BuildingExpToLearn,
            skillType.Engineering => EngineeringExpToLearn,
            _ => -1
        };
    }
}