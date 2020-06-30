using System;

namespace Maple2.Trigger._52000094_qd {
    public static class _20002280_rp {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9100}, arg2: new int[] {50100550},
                    arg3: new byte[] {3})) {
                    context.State = new State연출시작(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9100}, arg2: new int[] {20002280},
                    arg3: new byte[] {3})) {
                    context.State = new State연출시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출시작 : TriggerState {
            internal State연출시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3003, 3004}, arg2: false);
                context.SetLocalCamera(cameraId: 302, enable: false);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 300, arg2: true);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SpawnNpcRange(rangeID: new int[] {1001, 1002, 1003, 1004, 1005}, isAutoTargeting: false);
                context.SpawnNpcRange(rangeID: new int[] {2101, 2102, 2103, 2104, 2105, 2106, 2107},
                    isAutoTargeting: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State타이틀(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State타이틀 : TriggerState {
            internal State타이틀(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000094, arg2: 99);
                context.AddBuff(arg1: new int[] {9100}, arg2: 99910170, arg3: 1, arg4: false, arg5: false);
                context.SetProductionUI(arg1: 9, arg2: "$52000094_QD__20002280_RP__0$");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State블랙아이대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State블랙아이대사01 : TriggerState {
            internal State블랙아이대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3003, 3004}, arg2: true);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetConversation(arg1: 2, arg2: 11000006, arg3: "$52000094_QD__20002280_RP__1$", arg4: 3,
                    arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateRP시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRP시작 : TriggerState {
            internal StateRP시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 300, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityID: 25200941, textID: 25200941, duration: 4000);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {2101, 2102, 2103, 2104, 2105, 2106, 2107})) {
                    context.State = new State데블린소환(context);
                    return;
                }

                if (context.WaitTick(waitTick: 40000)) {
                    context.State = new State데블린소환(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State데블린소환 : TriggerState {
            internal State데블린소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 301, arg2: true);
                context.CreateMonster(arg1: new int[] {2199}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.State = new State데블린사망대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State데블린사망대기 : TriggerState {
            internal State데블린사망대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityID: 25200942, textID: 25200942, duration: 4000);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraSelect(arg1: 300, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {2199})) {
                    context.State = new State미션완료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State미션완료 : TriggerState {
            internal State미션완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {2101, 2102, 2103, 2104, 2105, 2106, 2107});
                context.SetEventUI(arg1: 7, arg2: "$52000094_QD__20002280_RP__2$", arg3: new int[] {3000}, arg4: "0");
                context.SetLocalCamera(cameraId: 302, enable: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.SetLocalCamera(cameraId: 302, enable: false);
                    context.State = new State미션완료02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State미션완료02 : TriggerState {
            internal State미션완료02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CreateMonster(arg1: new int[] {2200}, arg2: true);
                context.CreateMonster(arg1: new int[] {2201}, arg2: true);
                context.RemoveBuff(arg1: 9100, arg2: 99910170);
                context.CameraReset(interpolationTime: 0.0f);
                context.SetAchievement(arg1: 9100, arg2: "trigger", arg3: "BlackEyeRpClear");
                context.MoveUser(arg1: 52000094, arg2: 99);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}