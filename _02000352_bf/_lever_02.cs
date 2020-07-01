using System;

namespace Maple2.Trigger._02000352_bf {
    public static class _lever_02 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State닫힘상태(context);

        private class State닫힘상태 : TriggerState {
            internal State닫힘상태(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000823}, arg2: 0);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000823}, arg2: 1)) {
                    context.State = new State작동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State작동 : TriggerState {
            internal State작동(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000823}, arg2: 0)) {
                    context.State = new State열림상태(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State열림상태 : TriggerState {
            internal State열림상태(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 3);
                context.SetEffect(arg1: new int[] {9000003}, arg2: true);
                context.SetMesh(arg1: new int[] {6050, 6051, 6052, 6053}, arg2: false, arg4: 200, arg5: 15f);
                context.SetMesh(arg1: new int[] {6150, 6151, 6152, 6153}, arg2: true, arg4: 200, arg5: 15f);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State열림(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State열림 : TriggerState {
            internal State열림(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}