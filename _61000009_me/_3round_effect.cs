namespace Maple2.Trigger._61000009_me {
    public static class _3round_effect {
        public class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "3Round_Effect") == 1) {
                    context.State = new StateSpawn_Start_Ready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSpawn_Start_Ready : TriggerState {
            internal StateSpawn_Start_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7999}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateSkill_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSkill_01 : TriggerState {
            internal StateSkill_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {5021}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSkill_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSkill_02 : TriggerState {
            internal StateSkill_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {5022}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSkill_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSkill_03 : TriggerState {
            internal StateSkill_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {5023}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSkill_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSkill_04 : TriggerState {
            internal StateSkill_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {5024}, arg2: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}