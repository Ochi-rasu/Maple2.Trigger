using System;

namespace Maple2.Trigger._82000002_survival {
    public static class _11_relicmob_red {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateSetting(context);

        private class StateSetting : TriggerState {
            internal StateSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {1100, 1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108, 1109});
                context.SetUserValue(key: "RelicMobSpawn", value: 0);
                context.SetUserValue(key: "RelicMobRemove", value: 0);
            }

            public override void Execute() {
                if (context.UserValue(key: "RelicMobSpawn", value: 1)) {
                    context.State = new StateDelay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay : TriggerState {
            internal StateDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 30000)) {
                    context.State = new StateMobSpawnRandom(context);
                    return;
                }

                if (context.UserValue(key: "RelicMobRemove", value: 1)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMobSpawnRandom : TriggerState {
            internal StateMobSpawnRandom(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StateMobSpawn01(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StateMobSpawn02(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StateMobSpawn03(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StateMobSpawn04(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StateMobSpawn05(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StateMobSpawn06(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StateMobSpawn07(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StateMobSpawn08(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StateMobSpawn09(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StateMobSpawn10(context);
                    return;
                }

                if (context.UserValue(key: "ExtraEventOff", value: 1)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMobSpawn01 : TriggerState {
            internal StateMobSpawn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {1100}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {1100})) {
                    context.State = new StateNotice(context);
                    return;
                }

                if (context.UserValue(key: "RelicMobRemove", value: 1)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMobSpawn02 : TriggerState {
            internal StateMobSpawn02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {1101}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {1101})) {
                    context.State = new StateNotice(context);
                    return;
                }

                if (context.UserValue(key: "RelicMobRemove", value: 1)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMobSpawn03 : TriggerState {
            internal StateMobSpawn03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {1102}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {1102})) {
                    context.State = new StateNotice(context);
                    return;
                }

                if (context.UserValue(key: "RelicMobRemove", value: 1)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMobSpawn04 : TriggerState {
            internal StateMobSpawn04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {1103}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {1103})) {
                    context.State = new StateNotice(context);
                    return;
                }

                if (context.UserValue(key: "RelicMobRemove", value: 1)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMobSpawn05 : TriggerState {
            internal StateMobSpawn05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {1104}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {1104})) {
                    context.State = new StateNotice(context);
                    return;
                }

                if (context.UserValue(key: "RelicMobRemove", value: 1)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMobSpawn06 : TriggerState {
            internal StateMobSpawn06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {1105}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {1105})) {
                    context.State = new StateNotice(context);
                    return;
                }

                if (context.UserValue(key: "RelicMobRemove", value: 1)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMobSpawn07 : TriggerState {
            internal StateMobSpawn07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {1106}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {1106})) {
                    context.State = new StateNotice(context);
                    return;
                }

                if (context.UserValue(key: "RelicMobRemove", value: 1)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMobSpawn08 : TriggerState {
            internal StateMobSpawn08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {1107}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {1107})) {
                    context.State = new StateNotice(context);
                    return;
                }

                if (context.UserValue(key: "RelicMobRemove", value: 1)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMobSpawn09 : TriggerState {
            internal StateMobSpawn09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {1108}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {1108})) {
                    context.State = new StateNotice(context);
                    return;
                }

                if (context.UserValue(key: "RelicMobRemove", value: 1)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMobSpawn10 : TriggerState {
            internal StateMobSpawn10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {1109}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {1109})) {
                    context.State = new StateNotice(context);
                    return;
                }

                if (context.UserValue(key: "RelicMobRemove", value: 1)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNotice : TriggerState {
            internal StateNotice(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 16, key: "RelicMobRedDie", value: 1);
            }

            public override void Execute() {
                if (context.UserValue(key: "RelicMobRemove", value: 1)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {1100, 1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108, 1109});
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}