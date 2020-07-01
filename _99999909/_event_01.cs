namespace Maple2.Trigger._99999909 {
    public static class _event_01 {
        public class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {702})) {
                    context.State = new StateReady(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$99999909__EVENT_01__0$", arg3: 3000);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}