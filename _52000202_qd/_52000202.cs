using System;

namespace Maple2.Trigger._52000202_qd {
    public static class _52000202 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Statestart(context);

        private class Statestart : TriggerState {
            internal Statestart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {2001}, arg2: new int[] {10003431},
                    arg3: new byte[] {1})) {
                    context.State = new StateCameraEffect01(context);
                    return;
                }

                if (!context.QuestUserDetected(arg1: new int[] {2001}, arg2: new int[] {10003431},
                    arg3: new byte[] {1})) {
                    context.State = new State고마해_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect01 : TriggerState {
            internal StateCameraEffect01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateCameraEffect02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect02 : TriggerState {
            internal StateCameraEffect02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4001}, arg2: false);
                context.SetProductionUI(arg1: 1);
                context.MoveUser(arg1: 52000202, arg2: 5001);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateCameraEffect03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect03 : TriggerState {
            internal StateCameraEffect03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetSceneSkip(arg1: "Skip_1", arg2: "nextState");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateCameraEffect03_3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect03_3 : TriggerState {
            internal StateCameraEffect03_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4002}, arg2: false);
                context.MoveUserPath(arg1: "MS2PatrolData_3001");
                context.ShowCaption(type: "VerticalCaption", title: "$52000202_QD__52000202__0$", align: "bottomLeft",
                    offsetRateX: 0f, offsetRateY: 0f, duration: 5000, scale: 2.5f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State시공의균열(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시공의균열 : TriggerState {
            internal State시공의균열(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4003, 4004}, arg2: false);
                context.SetProductionUI(arg1: 3);
                context.AddCinematicTalk(npcID: 0, msg: "$52000202_QD__52000202__1$", duration: 4000);
                context.AddCinematicTalk(npcID: 0, msg: "$52000202_QD__52000202__2$", duration: 5000);
                context.AddCinematicTalk(npcID: 0, msg: "$52000202_QD__52000202__3$", duration: 4500);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 14000)) {
                    context.State = new State시공의균열_02_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시공의균열_02_01 : TriggerState {
            internal State시공의균열_02_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 101, enable: true, path: @"BG/Common/Eff_Com_Vibrate_long.xml");
                context.SetPcEmotionLoop(arg1: "Attack_Idle_A", arg2: 11000f);
                context.AddCinematicTalk(npcID: 0, msg: "$52000202_QD__52000202__4$", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State시공의균열_02_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시공의균열_02_02 : TriggerState {
            internal State시공의균열_02_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.0f);
                context.AddCinematicTalk(npcID: 0, msg: "$52000202_QD__52000202__5$", duration: 4000);
                context.AddCinematicTalk(npcID: 0, msg: "$52000202_QD__52000202__6$", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new State시공의균열_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시공의균열_03 : TriggerState {
            internal State시공의균열_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 101, enable: false, path: @"BG/Common/Eff_Com_Vibrate_long.xml");
                context.CameraSelectPath(arg1: new int[] {4005}, arg2: false);
                context.CreateMonster(arg1: new int[] {201});
                context.CreateMonster(arg1: new int[] {202});
                context.SetPortal(arg1: 8001, arg2: false, arg3: false);
                context.SetPortal(arg1: 8002, arg2: false, arg3: false);
                context.MoveUser(arg1: 52000202, arg2: 5002);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State시공의균열_03_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시공의균열_03_02 : TriggerState {
            internal State시공의균열_03_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4006}, arg2: false);
                context.CreateMonster(arg1: new int[] {203});
                context.CreateMonster(arg1: new int[] {204});
                context.SetPortal(arg1: 8003, arg2: false, arg3: false);
                context.SetPortal(arg1: 8004, arg2: false, arg3: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State시공의균열_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시공의균열_04 : TriggerState {
            internal State시공의균열_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4007, 4008}, arg2: false);
                context.AddCinematicTalk(npcID: 0, msg: "$52000202_QD__52000202__7$", duration: 4000);
                context.AddCinematicTalk(npcID: 0, msg: "$52000202_QD__52000202__8$", duration: 4500);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    context.State = new State전투준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투준비 : TriggerState {
            internal State전투준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(arg1: "Attack_Idle_A", arg2: 4500f);
                context.CameraSelectPath(arg1: new int[] {4009}, arg2: false);
                context.AddCinematicTalk(npcID: 0, msg: "$52000202_QD__52000202__9$", duration: 4500);
                context.DestroyMonster(arg1: new int[] {201});
                context.DestroyMonster(arg1: new int[] {202});
                context.DestroyMonster(arg1: new int[] {203});
                context.DestroyMonster(arg1: new int[] {204});
                context.CreateMonster(arg1: new int[] {205});
                context.CreateMonster(arg1: new int[] {206});
                context.CreateMonster(arg1: new int[] {207});
                context.CreateMonster(arg1: new int[] {208});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    context.State = new StateUI테스트(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateUI테스트 : TriggerState {
            internal StateUI테스트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetProductionUI(arg1: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State몰려온다(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몰려온다 : TriggerState {
            internal State몰려온다(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4010}, arg2: false);
                context.MoveUserPath(arg1: "MS2PatrolData_3006");
                context.MoveNpc(arg1: 205, arg2: "MS2PatrolData_3002");
                context.MoveNpc(arg1: 206, arg2: "MS2PatrolData_3003");
                context.MoveNpc(arg1: 207, arg2: "MS2PatrolData_3004");
                context.MoveNpc(arg1: 208, arg2: "MS2PatrolData_3005");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State몰려온다_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몰려온다_02 : TriggerState {
            internal State몰려온다_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimeScale(enable: true, startScale: 0.1f, endScale: 0.5f, duration: 5.0f, interpolator: 1);
                context.SetOnetimeEffect(id: 30, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastWhiteOutFast.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State몰려온다_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몰려온다_03 : TriggerState {
            internal State몰려온다_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {205});
                context.DestroyMonster(arg1: new int[] {206});
                context.DestroyMonster(arg1: new int[] {207});
                context.DestroyMonster(arg1: new int[] {208});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State고마해(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State고마해 : TriggerState {
            internal State고마해(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 30, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastWhiteOutFast.xml");
                context.SetProductionUI(arg1: 1);
                context.CameraSelectPath(arg1: new int[] {4011}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State고마해_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State고마해_02 : TriggerState {
            internal State고마해_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 3);
                context.AddCinematicTalk(npcID: 0, msg: "$52000202_QD__52000202__10$", duration: 2500);
                context.AddCinematicTalk(npcID: 0, msg: "$52000202_QD__52000202__11$", duration: 4000);
                context.AddCinematicTalk(npcID: 0, msg: "$52000202_QD__52000202__12$", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 9500)) {
                    context.State = new State고마해_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State고마해_03 : TriggerState {
            internal State고마해_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(arg1: "Attack_Idle_A", arg2: 9000f);
                context.SetOnetimeEffect(id: 102, enable: true, path: @"BG/Common/Eff_Com_Vibrate_long.xml");
                context.AddCinematicTalk(npcID: 0, msg: "$52000202_QD__52000202__13$", duration: 4500);
                context.AddCinematicTalk(npcID: 0, msg: "$52000202_QD__52000202__14$", duration: 4000);
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8500)) {
                    context.State = new State고마해_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State고마해_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State고마해_04 : TriggerState {
            internal State고마해_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetAchievement(arg1: 2001, arg3: "illusionaryAttack");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State이동시키기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이동시키기 : TriggerState {
            internal State이동시키기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000201, arg2: 5001);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}