using System;

namespace Maple2.Trigger._02000252_bf {
    public static class _water_01 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108}, arg2: false, arg3: 0,
                    arg4: 100);
                context.SetInteractObject(arg1: new int[] {10000409}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000409}, arg2: 0)) {
                    context.State = new State물(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State물 : TriggerState {
            internal State물(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108}, arg2: true, arg3: 0,
                    arg4: 250);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}