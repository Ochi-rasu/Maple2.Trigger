using System;

namespace Maple2.Trigger._63000001_cs {
    public static class _trigger_17 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {317}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {117})) {
                    context.State = new State발판17(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State발판17 : TriggerState {
            internal State발판17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {317}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (!context.UserDetected(arg1: new int[] {117})) {
                    context.State = new State발판17끝(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State발판17끝 : TriggerState {
            internal State발판17끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "417", arg2: 2, arg3: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "417")) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}