using Robust.Shared.GameStates;
using System.Threading;

namespace Content.Shared.Vanilla.Skill;

[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
public sealed partial class SkillAmnesiaComponent : Component
{

    [DataField("skilltype"), AutoNetworkedField]
    public skillType skilltype { get; set; } = 0;

    [DataField("exptorestore"), AutoNetworkedField]
    public int exptorestore { get; set; } = 600;
    
    [ViewVariables(VVAccess.ReadWrite), DataField]
    public TimeSpan TimeOfDeath = TimeSpan.Zero;
    
    [ViewVariables(VVAccess.ReadWrite), DataField]
    public TimeSpan NextUpdateTime;
}
