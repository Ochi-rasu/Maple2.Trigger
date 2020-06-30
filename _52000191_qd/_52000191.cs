using System;

namespace Maple2.Trigger._52000191_qd {
    public static class _52000191 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Statestart(context);

        private class Statestart : TriggerState {
            internal Statestart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {6001}, arg2: false);
                context.SetEffect(arg1: new int[] {6008}, arg2: false);
                context.SetEffect(arg1: new int[] {6015}, arg2: false);
                context.SetEffect(arg1: new int[] {6022}, arg2: false);
                context.SetEffect(arg1: new int[] {6033}, arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {2001}, arg2: new int[] {10003412},
                    arg3: new byte[] {1})) {
                    context.State = new StateCameraEffect01(context);
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
                if (context.WaitTick(waitTick: 2000)) {
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
                context.MoveUser(arg1: 52000191, arg2: 5001);
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
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetProductionUI(arg1: 1);
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
                context.CameraSelectPath(arg1: new int[] {4002, 4003}, arg2: false);
                context.MoveUserPath(arg1: "MS2PatrolData_3001");
                context.ShowCaption(type: "VerticalCaption", title: "$52000191_QD__52000191__0$", align: "bottomLeft",
                    offsetRateX: 0f, offsetRateY: 0f, duration: 5000, scale: 2.5f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State바론과첫만남_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State바론과첫만남_01 : TriggerState {
            internal State바론과첫만남_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4004}, arg2: false);
                context.SetProductionUI(arg1: 3);
                context.AddCinematicTalk(npcID: 0, msg: "$52000191_QD__52000191__1$", duration: 5000);
                context.AddCinematicTalk(npcID: 11004787, msg: "$52000191_QD__52000191__2$", align: "left",
                    illustID: "Baron_normal", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    context.State = new State바론과첫만남_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State바론과첫만남_02 : TriggerState {
            internal State바론과첫만남_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4005, 4006}, arg2: false);
                context.SetPcEmotionLoop(arg1: "Talk_A", arg2: 5000f);
                context.AddCinematicTalk(npcID: 0, msg: "$52000191_QD__52000191__3$", duration: 5000);
                context.AddCinematicTalk(npcID: 11004787, msg: "$52000191_QD__52000191__4$", align: "left",
                    illustID: "Baron_normal", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    context.State = new State바론과첫만남_02_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State바론과첫만남_02_02 : TriggerState {
            internal State바론과첫만남_02_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(arg1: "Talk_A", arg2: 5000f);
                context.AddCinematicTalk(npcID: 0, msg: "$52000191_QD__52000191__5$", duration: 5000);
                context.AddCinematicTalk(npcID: 11004787, msg: "$52000191_QD__52000191__6$", align: "left",
                    illustID: "Baron_normal", duration: 4000);
                context.AddCinematicTalk(npcID: 11004787, msg: "$52000191_QD__52000191__7$", align: "left",
                    illustID: "Baron_normal", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 13000)) {
                    context.State = new State바론과첫만남_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State바론과첫만남_03 : TriggerState {
            internal State바론과첫만남_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionSequence(arg1: "Emotion_Angry_A");
                context.AddCinematicTalk(npcID: 0, msg: "$52000191_QD__52000191__8$", duration: 4000);
                context.AddCinematicTalk(npcID: 11004787, msg: "$52000191_QD__52000191__9$", align: "left",
                    illustID: "Baron_normal", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new State전투준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투준비 : TriggerState {
            internal State전투준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.VisibleMyPc(isVisible: false);
                context.MoveUser(arg1: 52000191, arg2: 5003);
                context.CameraSelectPath(arg1: new int[] {4007, 4008}, arg2: false);
                context.AddCinematicTalk(npcID: 11004787, msg: "$52000191_QD__52000191__10$", duration: 4000);
                context.SetEffect(arg1: new int[] {6029}, arg2: true);
                context.SetEffect(arg1: new int[] {6030}, arg2: true);
                context.SetEffect(arg1: new int[] {6031}, arg2: true);
                context.CreateMonster(arg1: new int[] {101});
                context.CreateMonster(arg1: new int[] {102});
                context.CreateMonster(arg1: new int[] {103});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State전투준비_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투준비_02 : TriggerState {
            internal State전투준비_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State전투준비_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.MoveUser(arg1: 52000191, arg2: 5003);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State전투준비_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투준비_03 : TriggerState {
            internal State전투준비_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {101});
                context.DestroyMonster(arg1: new int[] {102});
                context.DestroyMonster(arg1: new int[] {103});
                context.VisibleMyPc(isVisible: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State1페이즈(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1페이즈 : TriggerState {
            internal State1페이즈(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetEffect(arg1: new int[] {6001}, arg2: true);
                context.SetEffect(arg1: new int[] {6002}, arg2: true);
                context.SetEffect(arg1: new int[] {6003}, arg2: true);
                context.SetEffect(arg1: new int[] {6004}, arg2: true);
                context.SetEffect(arg1: new int[] {6005}, arg2: true);
                context.SetEffect(arg1: new int[] {6006}, arg2: true);
                context.SetEffect(arg1: new int[] {6007}, arg2: true);
                context.CreateMonster(arg1: new int[] {201});
                context.CreateMonster(arg1: new int[] {202});
                context.CreateMonster(arg1: new int[] {203});
                context.CreateMonster(arg1: new int[] {204});
                context.CreateMonster(arg1: new int[] {205});
                context.CreateMonster(arg1: new int[] {206});
                context.CameraReset(interpolationTime: 0.0f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {201, 202, 203, 204, 205, 206})) {
                    context.State = new State2페이즈(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2페이즈 : TriggerState {
            internal State2페이즈(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: "talk", npcID: 11004787, illust: "Baron_normal",
                    script: "$52000191_QD__52000191__11$", duration: 3000);
                context.SetEffect(arg1: new int[] {6001}, arg2: false);
                context.SetEffect(arg1: new int[] {6015}, arg2: true);
                context.SetEffect(arg1: new int[] {6016}, arg2: true);
                context.SetEffect(arg1: new int[] {6017}, arg2: true);
                context.SetEffect(arg1: new int[] {6018}, arg2: true);
                context.SetEffect(arg1: new int[] {6019}, arg2: true);
                context.SetEffect(arg1: new int[] {6020}, arg2: true);
                context.SetEffect(arg1: new int[] {6021}, arg2: true);
                context.CreateMonster(arg1: new int[] {213});
                context.CreateMonster(arg1: new int[] {214});
                context.CreateMonster(arg1: new int[] {215});
                context.CreateMonster(arg1: new int[] {216});
                context.CreateMonster(arg1: new int[] {217});
                context.CreateMonster(arg1: new int[] {218});
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {213, 214, 215, 216, 217, 218})) {
                    context.State = new State3페이즈(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3페이즈 : TriggerState {
            internal State3페이즈(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: "talk", npcID: 11004787, illust: "Baron_normal",
                    script: "$52000191_QD__52000191__12$", duration: 3000);
                context.SetEffect(arg1: new int[] {6015}, arg2: false);
                context.SetEffect(arg1: new int[] {6008}, arg2: true);
                context.SetEffect(arg1: new int[] {6009}, arg2: true);
                context.SetEffect(arg1: new int[] {6010}, arg2: true);
                context.SetEffect(arg1: new int[] {6011}, arg2: true);
                context.SetEffect(arg1: new int[] {6012}, arg2: true);
                context.SetEffect(arg1: new int[] {6013}, arg2: true);
                context.SetEffect(arg1: new int[] {6014}, arg2: true);
                context.CreateMonster(arg1: new int[] {207});
                context.CreateMonster(arg1: new int[] {208});
                context.CreateMonster(arg1: new int[] {209});
                context.CreateMonster(arg1: new int[] {210});
                context.CreateMonster(arg1: new int[] {211});
                context.CreateMonster(arg1: new int[] {212});
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {207, 208, 209, 210, 211, 212})) {
                    context.State = new State4페이즈(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State4페이즈 : TriggerState {
            internal State4페이즈(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: "talk", npcID: 11004787, illust: "Baron_normal",
                    script: "$52000191_QD__52000191__13$", duration: 3000);
                context.SetEffect(arg1: new int[] {6008}, arg2: false);
                context.SetEffect(arg1: new int[] {6022}, arg2: true);
                context.SetEffect(arg1: new int[] {6023}, arg2: true);
                context.SetEffect(arg1: new int[] {6024}, arg2: true);
                context.SetEffect(arg1: new int[] {6025}, arg2: true);
                context.SetEffect(arg1: new int[] {6026}, arg2: true);
                context.SetEffect(arg1: new int[] {6027}, arg2: true);
                context.SetEffect(arg1: new int[] {6028}, arg2: true);
                context.CreateMonster(arg1: new int[] {219});
                context.CreateMonster(arg1: new int[] {220});
                context.CreateMonster(arg1: new int[] {221});
                context.CreateMonster(arg1: new int[] {222});
                context.CreateMonster(arg1: new int[] {223});
                context.CreateMonster(arg1: new int[] {224});
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {219, 220, 221, 222, 223, 224})) {
                    context.State = new State5페이즈(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State5페이즈 : TriggerState {
            internal State5페이즈(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: "talk", npcID: 11004787, illust: "Baron_normal",
                    script: "$52000191_QD__52000191__14$", duration: 3000);
                context.SetEffect(arg1: new int[] {6022}, arg2: false);
                context.SetEffect(arg1: new int[] {6033}, arg2: true);
                context.SetEffect(arg1: new int[] {6032}, arg2: true);
                context.SetEffect(arg1: new int[] {6034}, arg2: true);
                context.SetEffect(arg1: new int[] {6035}, arg2: true);
                context.SetEffect(arg1: new int[] {6036}, arg2: true);
                context.SetEffect(arg1: new int[] {6037}, arg2: true);
                context.SetEffect(arg1: new int[] {6038}, arg2: true);
                context.CreateMonster(arg1: new int[] {225});
                context.CreateMonster(arg1: new int[] {226});
                context.CreateMonster(arg1: new int[] {227});
                context.CreateMonster(arg1: new int[] {228});
                context.CreateMonster(arg1: new int[] {229});
                context.CreateMonster(arg1: new int[] {230});
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {225, 226, 227, 228, 229, 230})) {
                    context.State = new State고마해(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State고마해 : TriggerState {
            internal State고마해(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State고마해_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State고마해_02 : TriggerState {
            internal State고마해_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {6033}, arg2: false);
                context.CameraSelectPath(arg1: new int[] {4009}, arg2: false);
                context.MoveUser(arg1: 52000191, arg2: 5002);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State고마해_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State고마해_03 : TriggerState {
            internal State고마해_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetSceneSkip(arg1: "Skip_2", arg2: "nextState");
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
                context.SetProductionUI(arg1: 3);
                context.CameraSelectPath(arg1: new int[] {4004}, arg2: false);
                context.SetPcEmotionLoop(arg1: "Attack_Idle_A", arg2: 5000f);
                context.AddCinematicTalk(npcID: 0, msg: "$52000191_QD__52000191__15$", duration: 3000);
                context.AddCinematicTalk(npcID: 11004787, msg: "$52000191_QD__52000191__16$", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State고마해_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State고마해_05 : TriggerState {
            internal State고마해_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4011, 4012}, arg2: false);
                context.AddCinematicTalk(npcID: 0, msg: "$52000191_QD__52000191__17$", duration: 5000);
                context.AddCinematicTalk(npcID: 0, msg: "$52000191_QD__52000191__18$", duration: 5000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new State고마해_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State고마해_06 : TriggerState {
            internal State고마해_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4013, 4014}, arg2: false);
                context.AddCinematicTalk(npcID: 11004787, msg: "$52000191_QD__52000191__19$", duration: 4000);
                context.AddCinematicTalk(npcID: 11004787, msg: "$52000191_QD__52000191__20$", duration: 3000);
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new State고마해_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSkip_2 : TriggerState {
            internal StateSkip_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State고마해_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State고마해_07 : TriggerState {
            internal State고마해_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetAchievement(arg1: 2001, arg3: "BattlewithBaron");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State그만싸워(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State그만싸워 : TriggerState {
            internal State그만싸워(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraReset(interpolationTime: 0.0f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}