namespace Maple2.Trigger._99999913 {
    public static class _04_invincible {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {9000})) {
                    context.State = new StateMakeInvincible(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMakeInvincible : TriggerState {
            internal StateMakeInvincible(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {9000}, arg2: 71000049, arg3: 1, arg4: false, arg5: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateMakeInvincible(context);
                    return;
                }

                if (context.GetUserValue(key: "InvincibleOff") == 1) {
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