using System;

namespace Maple2.Trigger._02000525_bf {
    public static class _qeagle_10 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작대기중(context);

        private class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000202}, arg2: 1);
                context.SetActor(arg1: 919, arg2: false, arg3: "Attack_Idle_A");
                context.SetEffect(arg1: new int[] {920}, arg2: false);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000202}, arg2: 0)) {
                    context.State = new State오브젝트반응(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오브젝트반응 : TriggerState {
            internal State오브젝트반응(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 919, arg2: true, arg3: "Attack_Idle_A");
                context.SetEffect(arg1: new int[] {920}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State그리폰제거(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetActor(arg1: 919, arg2: false, arg3: "Attack_Idle_A");
                context.SetEffect(arg1: new int[] {920}, arg2: false);
            }
        }

        private class State그리폰제거 : TriggerState {
            internal State그리폰제거(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 600);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State시작대기중(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}