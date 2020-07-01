using System;

namespace Maple2.Trigger._52000107_qd {
    public static class _52000107 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
                context.SetEffect(arg1: new int[] {5304}, arg2: false);
                context.SetEffect(arg1: new int[] {5305}, arg2: false);
                context.SetEffect(arg1: new int[] {5306}, arg2: false);
                context.SetEffect(arg1: new int[] {5307}, arg2: false);
                context.SetEffect(arg1: new int[] {5308}, arg2: false);
                context.SetEffect(arg1: new int[] {5309}, arg2: false);
                context.SetEffect(arg1: new int[] {5310}, arg2: false);
                context.SetEffect(arg1: new int[] {5311}, arg2: false);
                context.SetEffect(arg1: new int[] {5312}, arg2: false);
                context.SetEffect(arg1: new int[] {5313}, arg2: false);
                context.SetEffect(arg1: new int[] {5314}, arg2: false);
                context.SetEffect(arg1: new int[] {5315}, arg2: false);
                context.SetEffect(arg1: new int[] {5316}, arg2: false);
                context.SetEffect(arg1: new int[] {5317}, arg2: false);
                context.SetEffect(arg1: new int[] {5318}, arg2: false);
                context.SetEffect(arg1: new int[] {5319}, arg2: false);
                context.SetEffect(arg1: new int[] {5320}, arg2: false);
                context.SetEffect(arg1: new int[] {5321}, arg2: false);
                context.SetEffect(arg1: new int[] {5322}, arg2: false);
                context.SetEffect(arg1: new int[] {5323}, arg2: false);
                context.SetEffect(arg1: new int[] {5324}, arg2: false);
                context.SetEffect(arg1: new int[] {5325}, arg2: false);
                context.SetEffect(arg1: new int[] {5326}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {10010})) {
                    context.State = new State영상준비_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State영상준비_01 : TriggerState {
            internal State영상준비_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.MoveUser(arg1: 52000107, arg2: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State영상재생(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State영상재생 : TriggerState {
            internal State영상재생(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(arg1: "SceneMovie");
                context.PlaySceneMovie(fileName: @"common\JobIntro_HeavyGunner.usm", movieID: 1);
            }

            public override void Execute() {
                if (context.WidgetCondition(arg1: "SceneMovie", arg2: "IsStop", arg3: "1")) {
                    context.State = new State에델슈타인전경씬01(context);
                    return;
                }

                if (context.WaitTick(waitTick: 42000)) {
                    context.State = new State에델슈타인전경씬01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에델슈타인전경씬01 : TriggerState {
            internal State에델슈타인전경씬01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "Skip_1", arg2: "nextState");
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(arg1: new int[] {1000, 1001}, arg2: false);
                context.SetProductionUI(arg1: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8500)) {
                    context.State = new State에델슈타인전경씬01_B(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에델슈타인전경씬01_B : TriggerState {
            internal State에델슈타인전경씬01_B(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State에델슈타인전경씬02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에델슈타인전경씬02 : TriggerState {
            internal State에델슈타인전경씬02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(arg1: new int[] {1002, 1003, 1004, 1005}, arg2: false);
                context.SetProductionUI(arg1: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State에델슈타인전경씬03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에델슈타인전경씬03 : TriggerState {
            internal State에델슈타인전경씬03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCaption(type: "VerticalCaption", title: "$52000107_QD__52000107__0$",
                    desc: "$52000107_QD__52000107__1$", align: "bottomLeft", offsetRateX: 0f, offsetRateY: 0f,
                    duration: 7000, scale: 2.5f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State에델슈타인전경씬04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에델슈타인전경씬04 : TriggerState {
            internal State에델슈타인전경씬04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateQuit01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit01 : TriggerState {
            internal StateQuit01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateQuit02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 4);
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetOnetimeEffect(id: 2, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateQuit02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit02 : TriggerState {
            internal StateQuit02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 0.0f);
                context.SetEffect(arg1: new int[] {5304}, arg2: true);
                context.SetEffect(arg1: new int[] {5305}, arg2: true);
                context.SetEffect(arg1: new int[] {5306}, arg2: true);
                context.SetEffect(arg1: new int[] {5307}, arg2: true);
                context.SetEffect(arg1: new int[] {5308}, arg2: true);
                context.SetEffect(arg1: new int[] {5309}, arg2: true);
                context.SetEffect(arg1: new int[] {5310}, arg2: true);
                context.SetEffect(arg1: new int[] {5311}, arg2: true);
                context.SetEffect(arg1: new int[] {5312}, arg2: true);
                context.SetEffect(arg1: new int[] {5313}, arg2: true);
                context.SetEffect(arg1: new int[] {5314}, arg2: true);
                context.SetEffect(arg1: new int[] {5315}, arg2: true);
                context.SetEffect(arg1: new int[] {5316}, arg2: true);
                context.SetEffect(arg1: new int[] {5317}, arg2: true);
                context.SetEffect(arg1: new int[] {5318}, arg2: true);
                context.SetEffect(arg1: new int[] {5319}, arg2: true);
                context.SetEffect(arg1: new int[] {5320}, arg2: true);
                context.SetEffect(arg1: new int[] {5321}, arg2: true);
                context.SetEffect(arg1: new int[] {5322}, arg2: true);
                context.SetEffect(arg1: new int[] {5323}, arg2: true);
                context.SetEffect(arg1: new int[] {5324}, arg2: true);
                context.SetEffect(arg1: new int[] {5325}, arg2: true);
                context.SetEffect(arg1: new int[] {5326}, arg2: true);
                context.AddBalloonTalk(spawnPointID: 0, msg: "$52000107_QD__52000107__2$", duration: 6000,
                    delayTick: 1000);
                context.ShowGuideSummary(entityID: 25201071, textID: 25201071, duration: 10000);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {10011})) {
                    context.State = new State아이샤등장씬01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아이샤등장씬01 : TriggerState {
            internal State아이샤등장씬01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
                context.CreateMonster(arg1: new int[] {2000}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State아이샤등장씬02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아이샤등장씬02 : TriggerState {
            internal State아이샤등장씬02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "Skip_2", arg2: "nextState");
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.MoveNpc(arg1: 2000, arg2: "MS2PatrolData_Ayesha_go");
                context.CameraSelectPath(arg1: new int[] {1006, 1007}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State아이샤등장씬04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아이샤등장씬04 : TriggerState {
            internal State아이샤등장씬04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 3);
                context.AddCinematicTalk(npcID: 11003291, illustID: "Ayesha_normal", msg: "$52000107_QD__52000107__3$",
                    duration: 4000, align: "right");
                context.SetOnetimeEffect(id: 3000970, enable: true,
                    path: @"BG/Common/Sound/Eff_Ayesha_IntroMovie_03000970.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State아이샤등장씬05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아이샤등장씬05 : TriggerState {
            internal State아이샤등장씬05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.FaceEmotion(spawnPointID: 200, emotionName: "hello_Cait");
                context.ShowCaption(type: "NameCaption", title: "$52000107_QD__52000107__4$",
                    desc: "$52000107_QD__52000107__5$", align: "center", offsetRateX: -0.15f, offsetRateY: 0.15f,
                    duration: 10000, scale: 2.0f);
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new State아이샤등장씬06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSkip_2 : TriggerState {
            internal StateSkip_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 4);
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State아이샤등장씬06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아이샤등장씬06 : TriggerState {
            internal State아이샤등장씬06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 1.0f);
                context.SetEffect(arg1: new int[] {5304}, arg2: false);
                context.SetEffect(arg1: new int[] {5305}, arg2: false);
                context.SetEffect(arg1: new int[] {5306}, arg2: false);
                context.SetEffect(arg1: new int[] {5307}, arg2: false);
                context.SetEffect(arg1: new int[] {5308}, arg2: false);
                context.SetEffect(arg1: new int[] {5309}, arg2: false);
                context.SetEffect(arg1: new int[] {5310}, arg2: false);
                context.SetEffect(arg1: new int[] {5311}, arg2: false);
                context.SetEffect(arg1: new int[] {5312}, arg2: false);
                context.SetEffect(arg1: new int[] {5313}, arg2: false);
                context.SetEffect(arg1: new int[] {5314}, arg2: false);
                context.SetEffect(arg1: new int[] {5315}, arg2: false);
                context.SetEffect(arg1: new int[] {5316}, arg2: false);
                context.SetEffect(arg1: new int[] {5317}, arg2: false);
                context.SetEffect(arg1: new int[] {5318}, arg2: false);
                context.SetEffect(arg1: new int[] {5319}, arg2: false);
                context.SetEffect(arg1: new int[] {5320}, arg2: false);
                context.SetEffect(arg1: new int[] {5321}, arg2: false);
                context.SetEffect(arg1: new int[] {5322}, arg2: false);
                context.SetEffect(arg1: new int[] {5323}, arg2: false);
                context.SetEffect(arg1: new int[] {5324}, arg2: false);
                context.SetEffect(arg1: new int[] {5325}, arg2: false);
                context.SetEffect(arg1: new int[] {5326}, arg2: false);
                context.FaceEmotion(spawnPointID: 200);
                context.ShowGuideSummary(entityID: 25201071, textID: 25201071, duration: 10000);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {10011}, arg2: new int[] {20002296},
                    arg3: new byte[] {2})) {
                    context.State = new State아이샤와떠남01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아이샤와떠남01 : TriggerState {
            internal State아이샤와떠남01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointID: 2000, msg: "$52000107_QD__52000107__6$", duration: 6000,
                    delayTick: 1000);
                context.SetOnetimeEffect(id: 3000971, enable: true,
                    path: @"BG/Common/Sound/Eff_Ayesha_IntroMovie_03000971.xml");
                context.MoveNpc(arg1: 2000, arg2: "MS2PatrolData_Ayesga_out");
                context.ShowGuideSummary(entityID: 25201072, textID: 25201072, duration: 5000);
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 10012, arg2: new int[] {2000})) {
                    context.State = new State아이샤와떠남02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아이샤와떠남02 : TriggerState {
            internal State아이샤와떠남02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
                context.DestroyMonster(arg1: new int[] {2000});
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 9003, arg2: new int[] {202})) {
                    // context.State = new State아이샤와떠남03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}