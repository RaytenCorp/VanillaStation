using Robust.Shared.GameStates;
using Robust.Shared.Serialization;
using Content.Shared.Vanilla.Skill;

namespace Content.Shared.SkillTrainer;

[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
public sealed partial class SkillLearnerComponent : Component
{
    //Пилотирование
    [DataField("PilotingExpToLearn"), AutoNetworkedField]
    public int PilotingExpToLearn { get; set; } = 600;

    //Стрельба
    [DataField("RangeWeaponExpToLearn"), AutoNetworkedField]
    public int RangeWeaponExpToLearn { get; set; } = 600;

    //Ближний бой
    [DataField("MeleeWeaponExpToLearn"), AutoNetworkedField]
    public int MeleeWeaponExpToLearn { get; set; } = 600;

    //Медицина
    [DataField("MedicineExpToLearn"), AutoNetworkedField]
    public int MedicineExpToLearn { get; set; } = 600;

    //Химия
    [DataField("ChemistryExpToLearn"), AutoNetworkedField]
    public int ChemistryExpToLearn { get; set; } = 600;

    //Инженерия
    [DataField("EngineeringExpToLearn"), AutoNetworkedField]
    public int EngineeringExpToLearn { get; set; } = 600;

    //Строительство
    [DataField("BuildingExpToLearn"), AutoNetworkedField]
    public int BuildingExpToLearn { get; set; } = 600;

    //Исследования
    [DataField("ResearchExpToLearn"), AutoNetworkedField]
    public int ResearchExpToLearn { get; set; } = 600;

    //Приборостроение
    [DataField("InstrumentationExpToLearn"), AutoNetworkedField]
    public int InstrumentationExpToLearn { get; set; } = 600;

    //Ботаника
    [DataField("BotanyExpToLearn"), AutoNetworkedField]
    public int BotanyExpToLearn { get; set; } = 600;

    //Бюрократия
    [DataField("BureaucracyExpToLearn"), AutoNetworkedField]
    public int BureaucracyExpToLearn { get; set; } = 600;

    //Муз. инструменты
    [DataField("MusInstrumentsExpToLearn"), AutoNetworkedField]
    public int MusInstrumentsExpToLearn { get; set; } = 600;

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
            skillType.Botany => BotanyExpToLearn,
            skillType.Bureaucracy => BureaucracyExpToLearn,
            skillType.MusInstruments => MusInstrumentsExpToLearn,
            _ => -1
        };
    }
}