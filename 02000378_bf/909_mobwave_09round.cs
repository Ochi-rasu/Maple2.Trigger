namespace Maple2.Trigger._02000378_bf {
    public static class _909_mobwave_09round {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "PenaltyFinish", value: 0);
                context.SetUserValue(key: "WaveTime", value: 0);
                context.SetEffect(triggerIds: new []{5109}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "MobWaveStart") == 1) {
                    return new StateReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State1stWaveStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1stWaveStart : TriggerState {
            internal State1stWaveStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5000}, visible: true);
                context.SetEventUI(arg1: 1, script: "$02000378_BF__909_MOBWAVE_09ROUND__0$", duration: 6000, boxId: 0);
                context.SetUserValue(key: "WaveTime", value: 1);
                context.SetEffect(triggerIds: new []{5109}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State1stWaveDirectionRandom(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1stWaveDirectionRandom : TriggerState {
            internal State1stWaveDirectionRandom(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 20)) {
                    return new State1stWaveDirection10(context);
                }

                if (context.RandomCondition(rate: 20)) {
                    return new State1stWaveDirection20(context);
                }

                if (context.RandomCondition(rate: 20)) {
                    return new State1stWaveDirection30(context);
                }

                if (context.RandomCondition(rate: 20)) {
                    return new State1stWaveDirection40(context);
                }

                if (context.RandomCondition(rate: 20)) {
                    return new State1stWaveDirection50(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1stWaveDirection10 : TriggerState {
            internal State1stWaveDirection10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{90900, 90902, 90904}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State1stWaveDirection11(context);
                }

                if (context.MonsterDead(spawnIds: new []{1009})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1stWaveDirection11 : TriggerState {
            internal State1stWaveDirection11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{90901, 90903, 90905}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State1stWaveDelayRandom(context);
                }

                if (context.MonsterDead(spawnIds: new []{1009})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1stWaveDirection20 : TriggerState {
            internal State1stWaveDirection20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{90910, 90912, 90914}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State1stWaveDirection21(context);
                }

                if (context.MonsterDead(spawnIds: new []{1009})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1stWaveDirection21 : TriggerState {
            internal State1stWaveDirection21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{90911, 90913, 90915}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State1stWaveDelayRandom(context);
                }

                if (context.MonsterDead(spawnIds: new []{1009})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1stWaveDirection30 : TriggerState {
            internal State1stWaveDirection30(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{90920, 90922, 90924}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State1stWaveDirection31(context);
                }

                if (context.MonsterDead(spawnIds: new []{1009})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1stWaveDirection31 : TriggerState {
            internal State1stWaveDirection31(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{90921, 90923, 90925}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State1stWaveDelayRandom(context);
                }

                if (context.MonsterDead(spawnIds: new []{1009})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1stWaveDirection40 : TriggerState {
            internal State1stWaveDirection40(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{90930, 90932, 90934}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State1stWaveDirection41(context);
                }

                if (context.MonsterDead(spawnIds: new []{1009})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1stWaveDirection41 : TriggerState {
            internal State1stWaveDirection41(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{90931, 90933, 90935}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State1stWaveDelayRandom(context);
                }

                if (context.MonsterDead(spawnIds: new []{1009})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1stWaveDirection50 : TriggerState {
            internal State1stWaveDirection50(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{90940, 90942, 90944}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State1stWaveDirection51(context);
                }

                if (context.MonsterDead(spawnIds: new []{1009})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1stWaveDirection51 : TriggerState {
            internal State1stWaveDirection51(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{90941, 90943, 90945}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State1stWaveDelayRandom(context);
                }

                if (context.MonsterDead(spawnIds: new []{1009})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1stWaveDelayRandom : TriggerState {
            internal State1stWaveDelayRandom(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 30)) {
                    return new State1stWaveDelay4000(context);
                }

                if (context.RandomCondition(rate: 30)) {
                    return new State1stWaveDelay5000(context);
                }

                if (context.RandomCondition(rate: 30)) {
                    return new State1stWaveDelay3000(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1stWaveDelay4000 : TriggerState {
            internal State1stWaveDelay4000(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State2ndWaveStart(context);
                }

                if (context.MonsterDead(spawnIds: new []{1009})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1stWaveDelay5000 : TriggerState {
            internal State1stWaveDelay5000(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State2ndWaveStart(context);
                }

                if (context.MonsterDead(spawnIds: new []{1009})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1stWaveDelay3000 : TriggerState {
            internal State1stWaveDelay3000(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State2ndWaveStart(context);
                }

                if (context.MonsterDead(spawnIds: new []{1009})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2ndWaveStart : TriggerState {
            internal State2ndWaveStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "WaveTime", value: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State2ndWaveDirectionRandom(context);
                }

                if (context.MonsterDead(spawnIds: new []{1009})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDirectionRandom : TriggerState {
            internal State2ndWaveDirectionRandom(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 20)) {
                    return new State2ndWaveDirection10(context);
                }

                if (context.RandomCondition(rate: 20)) {
                    return new State2ndWaveDirection20(context);
                }

                if (context.RandomCondition(rate: 20)) {
                    return new State2ndWaveDirection30(context);
                }

                if (context.RandomCondition(rate: 20)) {
                    return new State2ndWaveDirection40(context);
                }

                if (context.RandomCondition(rate: 20)) {
                    return new State2ndWaveDirection50(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDirection10 : TriggerState {
            internal State2ndWaveDirection10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{90904, 90906, 90908}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State2ndWaveDirection11(context);
                }

                if (context.MonsterDead(spawnIds: new []{1009})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDirection11 : TriggerState {
            internal State2ndWaveDirection11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{90905, 90907, 90909}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State2ndWaveDelayRandom(context);
                }

                if (context.MonsterDead(spawnIds: new []{1009})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDirection20 : TriggerState {
            internal State2ndWaveDirection20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{90914, 90916, 90918}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State2ndWaveDirection21(context);
                }

                if (context.MonsterDead(spawnIds: new []{1009})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDirection21 : TriggerState {
            internal State2ndWaveDirection21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{90915, 90917, 90919}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State2ndWaveDelayRandom(context);
                }

                if (context.MonsterDead(spawnIds: new []{1009})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDirection30 : TriggerState {
            internal State2ndWaveDirection30(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{90924, 90926, 90928}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State2ndWaveDirection31(context);
                }

                if (context.MonsterDead(spawnIds: new []{1009})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDirection31 : TriggerState {
            internal State2ndWaveDirection31(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{90925, 90927, 90929}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State2ndWaveDelayRandom(context);
                }

                if (context.MonsterDead(spawnIds: new []{1009})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDirection40 : TriggerState {
            internal State2ndWaveDirection40(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{90934, 90936, 90938}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State2ndWaveDirection41(context);
                }

                if (context.MonsterDead(spawnIds: new []{1009})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDirection41 : TriggerState {
            internal State2ndWaveDirection41(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{90935, 90937, 90939}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State2ndWaveDelayRandom(context);
                }

                if (context.MonsterDead(spawnIds: new []{1009})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDirection50 : TriggerState {
            internal State2ndWaveDirection50(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{90944, 90946, 90948}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State2ndWaveDirection51(context);
                }

                if (context.MonsterDead(spawnIds: new []{1009})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDirection51 : TriggerState {
            internal State2ndWaveDirection51(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{90945, 90947, 90949}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State2ndWaveDelayRandom(context);
                }

                if (context.MonsterDead(spawnIds: new []{1009})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDelayRandom : TriggerState {
            internal State2ndWaveDelayRandom(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 30)) {
                    return new State2ndWaveDelay3000(context);
                }

                if (context.RandomCondition(rate: 30)) {
                    return new State2ndWaveDelay4000(context);
                }

                if (context.RandomCondition(rate: 30)) {
                    return new State2ndWaveDelay5000(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDelay3000 : TriggerState {
            internal State2ndWaveDelay3000(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State3rdWaveStart(context);
                }

                if (context.MonsterDead(spawnIds: new []{1009})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDelay4000 : TriggerState {
            internal State2ndWaveDelay4000(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State3rdWaveStart(context);
                }

                if (context.MonsterDead(spawnIds: new []{1009})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDelay5000 : TriggerState {
            internal State2ndWaveDelay5000(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State3rdWaveStart(context);
                }

                if (context.MonsterDead(spawnIds: new []{1009})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3rdWaveStart : TriggerState {
            internal State3rdWaveStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "WaveTime", value: 3);
            }

            public override TriggerState? Execute() {
                return new State3rdWaveDirectionRandom(context);
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDirectionRandom : TriggerState {
            internal State3rdWaveDirectionRandom(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 20)) {
                    return new State3rdWaveDirection10(context);
                }

                if (context.RandomCondition(rate: 20)) {
                    return new State3rdWaveDirection20(context);
                }

                if (context.RandomCondition(rate: 20)) {
                    return new State3rdWaveDirection30(context);
                }

                if (context.RandomCondition(rate: 20)) {
                    return new State3rdWaveDirection40(context);
                }

                if (context.RandomCondition(rate: 20)) {
                    return new State3rdWaveDirection50(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDirection10 : TriggerState {
            internal State3rdWaveDirection10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{90900, 90902, 90908}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State3rdWaveDirection11(context);
                }

                if (context.MonsterDead(spawnIds: new []{1009})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDirection11 : TriggerState {
            internal State3rdWaveDirection11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{90901, 90903, 90909}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State3rdWaveDelayRandom(context);
                }

                if (context.MonsterDead(spawnIds: new []{1009})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDirection20 : TriggerState {
            internal State3rdWaveDirection20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{90910, 90912, 90918}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State3rdWaveDirection21(context);
                }

                if (context.MonsterDead(spawnIds: new []{1009})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDirection21 : TriggerState {
            internal State3rdWaveDirection21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{90911, 90913, 90919}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State3rdWaveDelayRandom(context);
                }

                if (context.MonsterDead(spawnIds: new []{1009})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDirection30 : TriggerState {
            internal State3rdWaveDirection30(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{90920, 90922, 90928}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State3rdWaveDirection31(context);
                }

                if (context.MonsterDead(spawnIds: new []{1009})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDirection31 : TriggerState {
            internal State3rdWaveDirection31(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{90921, 90923, 90929}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State3rdWaveDelayRandom(context);
                }

                if (context.MonsterDead(spawnIds: new []{1009})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDirection40 : TriggerState {
            internal State3rdWaveDirection40(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{90930, 90932, 90938}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State3rdWaveDirection41(context);
                }

                if (context.MonsterDead(spawnIds: new []{1009})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDirection41 : TriggerState {
            internal State3rdWaveDirection41(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{90931, 90933, 90939}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State3rdWaveDelayRandom(context);
                }

                if (context.MonsterDead(spawnIds: new []{1009})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDirection50 : TriggerState {
            internal State3rdWaveDirection50(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{90940, 90942, 90948}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State3rdWaveDirection51(context);
                }

                if (context.MonsterDead(spawnIds: new []{1009})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDirection51 : TriggerState {
            internal State3rdWaveDirection51(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{90941, 90943, 90949}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State3rdWaveDelayRandom(context);
                }

                if (context.MonsterDead(spawnIds: new []{1009})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDelayRandom : TriggerState {
            internal State3rdWaveDelayRandom(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 30)) {
                    return new State3rdWaveDelay2000(context);
                }

                if (context.RandomCondition(rate: 30)) {
                    return new State3rdWaveDelay3000(context);
                }

                if (context.RandomCondition(rate: 30)) {
                    return new State3rdWaveDelay4000(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDelay2000 : TriggerState {
            internal State3rdWaveDelay2000(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State4thWaveStart(context);
                }

                if (context.MonsterDead(spawnIds: new []{1009})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDelay3000 : TriggerState {
            internal State3rdWaveDelay3000(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State4thWaveStart(context);
                }

                if (context.MonsterDead(spawnIds: new []{1009})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDelay4000 : TriggerState {
            internal State3rdWaveDelay4000(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State4thWaveStart(context);
                }

                if (context.MonsterDead(spawnIds: new []{1009})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4thWaveStart : TriggerState {
            internal State4thWaveStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "WaveTime", value: 4);
            }

            public override TriggerState? Execute() {
                return new State4thWaveDirectionRandom(context);
            }

            public override void OnExit() { }
        }

        private class State4thWaveDirectionRandom : TriggerState {
            internal State4thWaveDirectionRandom(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 20)) {
                    return new State4thWaveDirection10(context);
                }

                if (context.RandomCondition(rate: 20)) {
                    return new State4thWaveDirection20(context);
                }

                if (context.RandomCondition(rate: 20)) {
                    return new State4thWaveDirection30(context);
                }

                if (context.RandomCondition(rate: 20)) {
                    return new State4thWaveDirection40(context);
                }

                if (context.RandomCondition(rate: 20)) {
                    return new State4thWaveDirection50(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4thWaveDirection10 : TriggerState {
            internal State4thWaveDirection10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{90900, 90906, 90908}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State4thWaveDirection11(context);
                }

                if (context.MonsterDead(spawnIds: new []{1009})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4thWaveDirection11 : TriggerState {
            internal State4thWaveDirection11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{90901, 90907, 90909}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDefenceSucess01(context);
                }

                if (context.MonsterDead(spawnIds: new []{1009})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4thWaveDirection20 : TriggerState {
            internal State4thWaveDirection20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{90910, 90916, 90918}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State4thWaveDirection21(context);
                }

                if (context.MonsterDead(spawnIds: new []{1009})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4thWaveDirection21 : TriggerState {
            internal State4thWaveDirection21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{90911, 90917, 90919}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDefenceSucess01(context);
                }

                if (context.MonsterDead(spawnIds: new []{1009})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4thWaveDirection30 : TriggerState {
            internal State4thWaveDirection30(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{90920, 90926, 90928}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State4thWaveDirection31(context);
                }

                if (context.MonsterDead(spawnIds: new []{1009})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4thWaveDirection31 : TriggerState {
            internal State4thWaveDirection31(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{90921, 90927, 90929}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDefenceSucess01(context);
                }

                if (context.MonsterDead(spawnIds: new []{1009})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4thWaveDirection40 : TriggerState {
            internal State4thWaveDirection40(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{90930, 90936, 90938}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State4thWaveDirection41(context);
                }

                if (context.MonsterDead(spawnIds: new []{1009})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4thWaveDirection41 : TriggerState {
            internal State4thWaveDirection41(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{90931, 90937, 90939}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDefenceSucess01(context);
                }

                if (context.MonsterDead(spawnIds: new []{1009})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4thWaveDirection50 : TriggerState {
            internal State4thWaveDirection50(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{90940, 90946, 90948}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDefenceSucess01(context);
                }

                if (context.MonsterDead(spawnIds: new []{1009})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4thWaveDirection51 : TriggerState {
            internal State4thWaveDirection51(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{90941, 90947, 90949}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDefenceSucess01(context);
                }

                if (context.MonsterDead(spawnIds: new []{1009})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5thWaveStart : TriggerState {
            internal State5thWaveStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "WaveTime", value: 5);
                context.CreateMonster(spawnIds: new []{90990, 90992, 90994}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State5thWaveDelay(context);
                }

                if (context.MonsterDead(spawnIds: new []{1009})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5thWaveDelay : TriggerState {
            internal State5thWaveDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{90991, 90993, 90995}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateDefenceSucess01(context);
                }

                if (context.MonsterDead(spawnIds: new []{1009})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDefenceSucess01 : TriggerState {
            internal StateDefenceSucess01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{90900, 90901, 90902, 90903, 90904, 90905, 90906, 90907, 90908, 90910, 90910, 90911, 90912, 90913, 90914, 90915, 90916, 90917, 90918, 90919, 90920, 90921, 90922, 90923, 90924, 90925, 90926, 90927, 90928, 90929, 90930, 90931, 90932, 90933, 90934, 90935, 90936, 90937, 90938, 90939, 90940, 90941, 90942, 90943, 90944, 90945, 90946, 90947, 90948, 90949, 90980, 90981, 90982, 90983, 90984, 90985, 90986, 90987, 90988, 90989, 90990, 90991, 90992, 90993, 90994, 90995, 90996, 90997, 90998, 90999})) {
                    return new StateDefenceSucess02(context);
                }

                if (context.MonsterDead(spawnIds: new []{1009})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDefenceSucess02 : TriggerState {
            internal StateDefenceSucess02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5109}, visible: false);
                context.SetUserValue(triggerId: 9, key: "09RoundSuccess", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpcDownPenaltyStart : TriggerState {
            internal StateNpcDownPenaltyStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 809, key: "PenaltyMob", value: 1);
                context.DestroyMonster(spawnIds: new []{1009});
                context.CreateMonster(spawnIds: new []{1109}, arg2: false);
                context.SetEffect(triggerIds: new []{5000}, visible: true);
                context.SetEventUI(arg1: 1, script: "$02000378_BF__909_MOBWAVE_09ROUND__1$", duration: 4000, boxId: 0);
                context.SetConversation(type: 1, spawnId: 1109, script: "$02000378_BF__909_MOBWAVE_09ROUND__2$", arg4: 4, arg5: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateNpcDownPenaltyEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpcDownPenaltyEnd : TriggerState {
            internal StateNpcDownPenaltyEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "PenaltyFinish") == 1) {
                    return new StateReturnToWave(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReturnToWave : TriggerState {
            internal StateReturnToWave(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "PenaltyFinish", value: 0);
                context.SetEffect(triggerIds: new []{5000}, visible: true);
                context.SetEventUI(arg1: 1, script: "$02000378_BF__909_MOBWAVE_09ROUND__3$", duration: 4000, boxId: 0);
                context.DestroyMonster(spawnIds: new []{1109});
                context.CreateMonster(spawnIds: new []{1009}, arg2: false);
                context.RemoveBalloonTalk(spawnId: 1109);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "WaveTime") == 1) {
                    return new State2ndWaveStart(context);
                }

                if (context.GetUserValue(key: "WaveTime") == 2) {
                    return new State3rdWaveStart(context);
                }

                if (context.GetUserValue(key: "WaveTime") == 3) {
                    return new State4thWaveStart(context);
                }

                if (context.GetUserValue(key: "WaveTime") == 4) {
                    return new State5thWaveStart(context);
                }

                if (context.GetUserValue(key: "WaveTime") == 5) {
                    return new State5thWaveStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
