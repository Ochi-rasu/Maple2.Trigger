namespace Maple2.Trigger._02000395_bf {
    public static class _02_enteracemob {
        public class StateSetting : TriggerState {
            internal StateSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {900, 901});
                context.SetUserValue(key: "MobSpawn", value: 0);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "MobSpawn") == 1) {
                    context.State = new StateMobSpawn01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMobSpawn01 : TriggerState {
            internal StateMobSpawn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {900}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateMobSpawn02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMobSpawn02 : TriggerState {
            internal StateMobSpawn02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {901}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {900, 901})) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateMobSpawn01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}