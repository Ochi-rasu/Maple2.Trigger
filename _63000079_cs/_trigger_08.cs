namespace Maple2.Trigger._63000079_cs {
    public static class _trigger_08 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {308}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {108})) {
                    context.State = new State발판08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State발판08 : TriggerState {
            internal State발판08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {308}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (!context.UserDetected(arg1: new[] {108})) {
                    context.State = new State발판08끝(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State발판08끝 : TriggerState {
            internal State발판08끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "408", arg2: 2, arg3: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "408")) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}