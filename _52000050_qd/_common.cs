using System;

namespace Maple2.Trigger._52000050_qd {
    public static class _common {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Stateidle(context);

        private class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 702, arg2: new int[] {121})) {
                    context.State = new Statenpc_exit_01(context);
                    return;
                }

                if (context.NpcDetected(arg1: 702, arg2: new int[] {122})) {
                    context.State = new Statenpc_exit_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statenpc_exit_01 : TriggerState {
            internal Statenpc_exit_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {121});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new Stateidle(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statenpc_exit_02 : TriggerState {
            internal Statenpc_exit_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {122});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new Stateidle(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}