using System;

namespace Maple2.Trigger._02000014_ad {
    public static class _ia_115 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작대기중(context);

        private class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000115}, arg2: 1);
                context.SetActor(arg1: 115, arg2: true, arg3: "Dead_A");
            }

            public override void Execute() {
                if (true) {
                    context.State = new State오브젝트반응(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오브젝트반응 : TriggerState {
            internal State오브젝트반응(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000115}, arg2: 0)) {
                    context.State = new StateNPC이동(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetActor(arg1: 115, arg2: false, arg3: "Dead_A");
                context.CreateMonster(arg1: new int[] {93}, arg2: false);
            }
        }

        private class StateNPC이동 : TriggerState {
            internal StateNPC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 93, arg2: "MS2PatrolData403");
                context.SetConversation(arg1: 1, arg2: 93, arg3: "$02000014_AD__IA_115__0$", arg4: 4, arg5: 0);
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 293, arg2: new int[] {93})) {
                    context.State = new StateNPC소멸(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC소멸 : TriggerState {
            internal StateNPC소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {93});
                context.SetTimer(arg1: "303", arg2: 10);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "303")) {
                    context.State = new State시작대기중(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}