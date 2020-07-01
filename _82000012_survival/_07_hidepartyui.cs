namespace Maple2.Trigger._82000012_survival {
    public static class _07_hidepartyui {
        public class StateSetting : TriggerState {
            internal StateSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "HidePartyUI", value: 0);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {9000})) {
                    context.State = new StateHidePartyUI(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateHidePartyUI : TriggerState {
            internal StateHidePartyUI(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetVisibleUI(uiName: "PartyDialog", visible: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateHidePartyUI(context);
                    return;
                }

                if (context.GetUserValue(key: "HidePartyUI") == 1) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}