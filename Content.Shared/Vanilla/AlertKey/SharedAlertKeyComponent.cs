using Robust.Shared.Serialization;

namespace Content.Shared.Vanilla.AlertKey;

[Virtual]
public partial class SharedAlertKeyComponent : Component
{
}

[Serializable, NetSerializable]
public sealed class AlertKeyInterfaceState : BoundUserInterfaceState
{
    public AlertKeyInterfaceState()
    {

    }
}

[Serializable, NetSerializable]
public sealed class AlertKeyApplyMessage : BoundUserInterfaceMessage
{
    public AlertKeyApplyMessage()
    {

    }
}

[Serializable, NetSerializable]
public enum AlertKeyUiKey
{
    Key
}