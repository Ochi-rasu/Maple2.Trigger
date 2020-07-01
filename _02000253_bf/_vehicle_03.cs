using System;

namespace Maple2.Trigger._02000253_bf {
    public static class _vehicle_03 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Stateidle(context);

        private class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8053}, arg2: false);
            }

            public override void Execute() {
                if (context.DungeonMaxUserCount(value: 3)) {
                    context.State = new Statevehicle_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statevehicle_01 : TriggerState {
            internal Statevehicle_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CountUsers(arg1: 906, arg2: 1)) {
                    context.State = new Statemonster_spawn_ready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statemonster_spawn_ready : TriggerState {
            internal Statemonster_spawn_ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new Statemonster_spawn(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statemonster_spawn : TriggerState {
            internal Statemonster_spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8053}, arg2: true);
                context.CreateMonster(arg1: new int[] {3001}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {3001})) {
                    context.State = new Statevehicle_spawn(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statevehicle_spawn : TriggerState {
            internal Statevehicle_spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8053}, arg2: true);
                context.SetInteractObject(arg1: new int[] {10001052}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10001052}, arg2: 0)) {
                    context.State = new Stateend(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateend : TriggerState {
            internal Stateend(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10001052}, arg2: 2);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}