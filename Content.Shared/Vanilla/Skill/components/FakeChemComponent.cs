using Robust.Shared.GameStates;
using Robust.Shared.Serialization;

namespace Content.Shared.Vanilla.Skill;

[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
public sealed partial class FakeChemComponent : Component
{
        [DataField("FakeColor"), AutoNetworkedField]
        public Color FakeColor { get; set; } = Color.White;
}