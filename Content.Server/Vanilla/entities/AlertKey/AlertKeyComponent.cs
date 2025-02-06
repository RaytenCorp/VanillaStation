using Robust.Shared.GameStates;

namespace Content.Server.Vanilla.AlertKey;

[RegisterComponent]
public sealed partial class AlertKeyComponent : Component
{
    /// <summary>
    /// разрешенные коды для данного ключа угрозы
    /// </summary>
    [DataField("codeaccess")]
    public List<string> CodeAccess = new();
}
