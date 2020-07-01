namespace Maple2.Trigger._02000483_bf {
    public static class _05_hallwaymobwave {
        public class StateSetting : TriggerState {
            internal StateSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {930, 931, 932, 933});
                context.SetUserValue(key: "MobWave", value: 0);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "MobWave") == 1) {
                    context.State = new StateMobSpawn01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMobSpawn01 : TriggerState {
            internal StateMobSpawn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {930}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateMobSpawn02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMobSpawn02 : TriggerState {
            internal StateMobSpawn02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {931}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateMobSpawn03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMobSpawn03 : TriggerState {
            internal StateMobSpawn03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {932}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new StateMobSpawn04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMobSpawn04 : TriggerState {
            internal StateMobSpawn04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {933}, arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}