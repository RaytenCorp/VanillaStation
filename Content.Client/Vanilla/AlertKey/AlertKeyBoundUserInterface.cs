using Content.Shared.CCVar;
using Content.Shared.Chat;
using Content.Shared.Vanilla.AlertKey;
using Robust.Client.UserInterface;
using Robust.Shared.Configuration;
using Robust.Shared.Timing;

namespace Content.Client.Vanilla.AlertKey
{
    public sealed class AlertKeyBoundUserInterface : BoundUserInterface
    {
        private AlertKeyMenu? _menu;

        public AlertKeyBoundUserInterface(EntityUid owner, Enum uiKey) : base(owner, uiKey)
        {
        }

        protected override void Open()
        {
            base.Open();

            _menu = this.CreateWindow<AlertKeyMenu>();

        }
        protected override void UpdateState(BoundUserInterfaceState state)
        {
            base.UpdateState(state);
        }
    }
}
