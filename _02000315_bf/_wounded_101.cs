using System;

namespace Maple2.Trigger._02000315_bf {
    public static class _wounded_101 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "BridgeOpen", value: 0);
                context.SetInteractObject(arg1: new int[] {10001036}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10001036}, arg2: 0)) {
                    context.State = new StateWakeUp(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWakeUp : TriggerState {
            internal StateWakeUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10001036}, arg2: 2);
                context.CreateMonster(arg1: new int[] {101}, arg2: false);
            }

            public override void Execute() {
                if (context.UserValue(key: "BridgeOpen", value: 1)) {
                    context.State = new StatePatrol01(context);
                    return;
                }

                if (context.UserValue(key: "BridgeOpen", value: 2)) {
                    context.State = new StatePatrol02(context);
                    return;
                }

                if (context.UserValue(key: "BridgeOpen", value: 3)) {
                    context.State = new StatePatrol03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePatrol01 : TriggerState {
            internal StatePatrol01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_1011");
            }

            public override void Execute() {
                if (context.UserValue(key: "BridgeOpen", value: 2)) {
                    context.State = new StatePatrol02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePatrol02 : TriggerState {
            internal StatePatrol02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_1012");
            }

            public override void Execute() {
                if (context.UserValue(key: "BridgeOpen", value: 3)) {
                    context.State = new StatePatrol03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePatrol03 : TriggerState {
            internal StatePatrol03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_1013");
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}