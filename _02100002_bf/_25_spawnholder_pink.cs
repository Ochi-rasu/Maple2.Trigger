using System;

namespace Maple2.Trigger._02100002_bf {
    public static class _25_spawnholder_pink {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "ActivateHolder", value: 0);
                context.SetUserValue(key: "DungeonQuit", value: 0);
                context.SetInteractObject(arg1: new int[] {10001256}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {10001257}, arg2: 0);
            }

            public override void Execute() {
                if (context.UserValue(key: "ActivateHolder", value: 1)) {
                    context.State = new StateLoadingDelay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelay : TriggerState {
            internal StateLoadingDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSpawnStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSpawnStart : TriggerState {
            internal StateSpawnStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10001257}, arg2: 1);
                context.SetInteractObject(arg1: new int[] {10001256}, arg2: 2);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10001257}, arg2: 0)) {
                    context.State = new StateStopDelay(context);
                    return;
                }

                if (context.UserValue(key: "DungeonQuit", value: 1)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStopDelay : TriggerState {
            internal StateStopDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 105, key: "SpawnHold", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSpawnStop(context);
                    return;
                }

                if (context.UserValue(key: "DungeonQuit", value: 1)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSpawnStop : TriggerState {
            internal StateSpawnStop(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10001257}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {10001256}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10001256}, arg2: 0)) {
                    context.State = new StateStartDelay(context);
                    return;
                }

                if (context.UserValue(key: "DungeonQuit", value: 1)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStartDelay : TriggerState {
            internal StateStartDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 105, key: "SpawnHold", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSpawnStart(context);
                    return;
                }

                if (context.UserValue(key: "DungeonQuit", value: 1)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10001256}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {10001257}, arg2: 0);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}