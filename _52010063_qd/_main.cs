using System;

namespace Maple2.Trigger._52010063_qd {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Statestart(context);

        private class Statestart : TriggerState {
            internal Statestart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {101}, arg2: false);
                context.CreateMonster(arg1: new int[] {102}, arg2: false);
                context.CreateMonster(arg1: new int[] {111, 112, 113, 114, 115}, arg2: false);
                context.DestroyMonster(arg1: new int[] {211, 212, 213, 214, 215});
                context.SetEffect(arg1: new int[] {6000, 6001, 6002, 6003, 6004, 6010, 6011}, arg2: false);
                context.SetMesh(arg1: new int[] {4001, 4002, 4003, 4004}, arg2: false);
            }

            public override void Execute() {
                if (context.CheckUser()) {
                    context.State = new State퀘스트조건체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트조건체크 : TriggerState {
            internal State퀘스트조건체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {91000066},
                    arg3: new byte[] {3})) {
                    context.State = new State맵이동_작전실로(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {91000066},
                    arg3: new byte[] {2})) {
                    context.State = new State처치후_대기(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {91000066},
                    arg3: new byte[] {1})) {
                    context.State = new State처치후_대기(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {91000065},
                    arg3: new byte[] {3})) {
                    context.State = new State처치후_대기(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {91000065},
                    arg3: new byte[] {2})) {
                    context.State = new State처치후_대기(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {91000065},
                    arg3: new byte[] {1})) {
                    context.State = new State처치후_대기(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {91000064},
                    arg3: new byte[] {3})) {
                    context.State = new State처치후_대기(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {91000064},
                    arg3: new byte[] {2})) {
                    context.State = new State처치후_대기(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {91000064},
                    arg3: new byte[] {1})) {
                    context.State = new State연출시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State처치후_대기 : TriggerState {
            internal State처치후_대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.DestroyMonster(arg1: new int[]
                    {101, 102, 111, 112, 113, 114, 115, 211, 212, 213, 214, 215, 221, 222, 223, 224, 225, 226});
                context.MoveUser(arg1: 52010063, arg2: 20);
                context.CreateMonster(arg1: new int[] {103}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State처치후(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State처치후 : TriggerState {
            internal State처치후(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State맵이동_작전실로 : TriggerState {
            internal State맵이동_작전실로(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[]
                    {101, 102, 111, 112, 113, 114, 115, 211, 212, 213, 214, 215, 221, 222, 223, 224, 225, 226});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State최종맵이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State최종맵이동 : TriggerState {
            internal State최종맵이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.MoveUser(arg1: 52010052, arg2: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State최종맵이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출시작 : TriggerState {
            internal State연출시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "전투전스킵완료", arg2: "nextState");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Dead_A", arg3: 999999f);
                context.SetNpcEmotionLoop(arg1: 102, arg2: "Attack_02_D", arg3: 17000f);
                context.SetEffect(arg1: new int[] {6000, 6003}, arg2: true);
                context.SetEffect(arg1: new int[] {6001}, arg2: true);
                context.SetEffect(arg1: new int[] {6002}, arg2: true);
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State인페르녹줌인00(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State인페르녹줌인00 : TriggerState {
            internal State인페르녹줌인00(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State인페르녹줌인01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State인페르녹줌인01 : TriggerState {
            internal State인페르녹줌인01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8000, 8001, 8002}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new StatePC놀람01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePC놀람01 : TriggerState {
            internal StatePC놀람01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8003}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StatePC놀람02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePC놀람02 : TriggerState {
            internal StatePC놀람02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 0, msg: "$52010063_QD__main__0$", duration: 3000, align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State인페르녹줌인02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State인페르녹줌인02 : TriggerState {
            internal State인페르녹줌인02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8004}, arg2: false);
                context.AddCinematicTalk(npcID: 11003832, illustID: "infernog_nomal", msg: "$52010063_QD__main__1$",
                    duration: 5000, align: "right");
                context.SetEffect(arg1: new int[] {6000, 6003}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 102, arg2: "Attack_03_D");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State인페르녹줌인03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State인페르녹줌인03 : TriggerState {
            internal State인페르녹줌인03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003832, illustID: "infernog_nomal", msg: "$52010063_QD__main__2$",
                    duration: 5000, align: "right");
                context.SetNpcEmotionSequence(arg1: 102, arg2: "Attack_03_F");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State인페르녹줌인04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State인페르녹줌인04 : TriggerState {
            internal State인페르녹줌인04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8002}, arg2: false);
                context.AddCinematicTalk(npcID: 11003832, illustID: "infernog_nomal", msg: "$52010063_QD__main__3$",
                    duration: 5000, align: "right");
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_Infernog_goforward");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State부하대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State부하대사01 : TriggerState {
            internal State부하대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8011}, arg2: false);
                context.AddCinematicTalk(npcID: 11003839, msg: "$52010063_QD__main__4$", duration: 3000,
                    align: "right");
                context.SetNpcEmotionSequence(arg1: 114, arg2: "Attack_01_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State부하대사02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State부하대사02 : TriggerState {
            internal State부하대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8012}, arg2: false);
                context.AddCinematicTalk(npcID: 11003839, msg: "$52010063_QD__main__5$", duration: 3000,
                    align: "right");
                context.SetNpcEmotionSequence(arg1: 115, arg2: "Attack_01_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State인페르녹대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State인페르녹대사01 : TriggerState {
            internal State인페르녹대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8004}, arg2: false);
                context.AddCinematicTalk(npcID: 11003832, illustID: "infernog_nomal", msg: "$52010063_QD__main__6$",
                    duration: 4000, align: "right");
                context.SetNpcEmotionSequence(arg1: 102, arg2: "Attack_02_F");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State인페르녹대사02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State인페르녹대사02 : TriggerState {
            internal State인페르녹대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8003, 8005}, arg2: false);
                context.AddCinematicTalk(npcID: 11003832, illustID: "infernog_nomal", msg: "$52010063_QD__main__7$",
                    duration: 6000, align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State인페르녹대사03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State인페르녹대사03 : TriggerState {
            internal State인페르녹대사03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003832, illustID: "infernog_nomal", msg: "$52010063_QD__main__8$",
                    duration: 5000, align: "right");
                context.SetNpcEmotionSequence(arg1: 102, arg2: "Attack_02_E");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State인페르녹대사04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State인페르녹대사04 : TriggerState {
            internal State인페르녹대사04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003832, illustID: "infernog_nomal", msg: "$52010063_QD__main__9$",
                    duration: 5000, align: "right");
                context.SetNpcEmotionSequence(arg1: 102, arg2: "Attack_03_D");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State인페르녹대사05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State인페르녹대사05 : TriggerState {
            internal State인페르녹대사05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8004, 8000}, arg2: false);
                context.AddCinematicTalk(npcID: 11003832, illustID: "infernog_nomal", msg: "$52010063_QD__main__10$",
                    duration: 5000, align: "right");
                context.SetNpcEmotionSequence(arg1: 102, arg2: "Leave_01_A,Leave_02_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State부하들준비00(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State부하들준비00 : TriggerState {
            internal State부하들준비00(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8000}, arg2: false);
                context.AddCinematicTalk(npcID: 11003839, msg: "$52010063_QD__main__11$", duration: 3000,
                    align: "right");
                context.SetEffect(arg1: new int[] {6010}, arg2: true);
                context.SetNpcEmotionSequence(arg1: 102, arg2: "Leave_02_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State부하들등장00(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State부하들등장00 : TriggerState {
            internal State부하들등장00(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State부하들등장01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투전스킵완료 : TriggerState {
            internal State전투전스킵완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.DestroyMonster(arg1: new int[] {102});
                context.DestroyMonster(arg1: new int[] {111, 112, 113, 114, 115});
                context.CreateMonster(arg1: new int[] {211}, arg2: true);
                context.MoveUser(arg1: 52010063, arg2: 11);
                context.SetEffect(arg1: new int[] {6000, 6003}, arg2: false);
                context.SetEffect(arg1: new int[] {6010}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State부하들등장02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State부하들등장01 : TriggerState {
            internal State부하들등장01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {102});
                context.DestroyMonster(arg1: new int[] {111, 112, 113, 114, 115});
                context.CreateMonster(arg1: new int[] {211, 221, 222, 223, 224, 225, 226}, arg2: false);
                context.MoveUser(arg1: 52010063, arg2: 11);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State부하들등장02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State부하들등장02 : TriggerState {
            internal State부하들등장02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraReset(interpolationTime: 2.0f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State부하들등장211(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State부하들등장211 : TriggerState {
            internal State부하들등장211(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {212}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {211})) {
                    context.State = new State부하들등장212(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State부하들등장212 : TriggerState {
            internal State부하들등장212(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {213}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {212})) {
                    context.State = new State부하들등장213(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State부하들등장213 : TriggerState {
            internal State부하들등장213(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {214}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {213})) {
                    context.State = new State부하들등장214215(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State부하들등장214215 : TriggerState {
            internal State부하들등장214215(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {215}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {214, 215})) {
                    context.State = new State트리스탄구출00(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트리스탄구출00 : TriggerState {
            internal State트리스탄구출00(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.DestroyMonster(arg1: new int[]
                    {111, 112, 113, 114, 115, 211, 212, 213, 214, 215, 221, 222, 223, 224, 225, 226});
                context.SetAchievement(arg1: 9000, arg2: "trigger", arg3: "crimsonbalrogwipeout");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetMesh(arg1: new int[] {4001, 4002, 4003, 4004}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State트리스탄구출01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트리스탄구출01 : TriggerState {
            internal State트리스탄구출01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.DestroyMonster(arg1: new int[] {101});
                context.CreateMonster(arg1: new int[] {103}, arg2: false);
                context.MoveUser(arg1: 52010063, arg2: 20);
                context.SetEffect(arg1: new int[] {6001, 6002}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State트리스탄구출02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트리스탄구출02 : TriggerState {
            internal State트리스탄구출02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "전투후스킵완료", arg2: "nextState");
                context.CameraSelectPath(arg1: new int[] {8003, 8013, 8014}, arg2: false);
                context.SetOnetimeEffect(id: 2, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetNpcEmotionLoop(arg1: 103, arg2: "Dead_A", arg3: 5000f);
                context.SetEffect(arg1: new int[] {6004}, arg2: true);
                context.AddCinematicTalk(npcID: 11003825, illustID: "Tristan_normal", msg: "$52010063_QD__main__12$",
                    duration: 5000, align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State트리스탄구출03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트리스탄구출03 : TriggerState {
            internal State트리스탄구출03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {6010}, arg2: false);
                context.SetEffect(arg1: new int[] {6011}, arg2: true);
                context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_Tristan_walk");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State트리스탄구출04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트리스탄구출04 : TriggerState {
            internal State트리스탄구출04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8022, 8021}, arg2: false);
                context.AddCinematicTalk(npcID: 11003825, illustID: "Tristan_normal", msg: "$52010063_QD__main__13$",
                    duration: 3000, align: "right");
                context.SetNpcEmotionLoop(arg1: 103, arg2: "ChatUp_A", arg3: 3000f);
                context.SetEffect(arg1: new int[] {6004}, arg2: false);
                context.SetEffect(arg1: new int[] {6011}, arg2: false);
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투후스킵완료 : TriggerState {
            internal State전투후스킵완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {6000, 6001, 6002, 6003, 6004, 6005, 6010, 6011}, arg2: false);
                context.MoveUser(arg1: 52010063, arg2: 20);
                context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_Tristan_walk");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출종료 : TriggerState {
            internal State연출종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 2.0f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetMesh(arg1: new int[] {4001, 4002, 4003, 4004}, arg2: false);
                context.SetAchievement(arg1: 9000, arg2: "trigger", arg3: "tristanrescue");
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {91000065},
                    arg3: new byte[] {3})) {
                    context.State = new State콘대르_대사(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State콘대르_대사 : TriggerState {
            internal State콘대르_대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: "talk", npcID: 11003534, illust: "Conder_normal",
                    script: "$52010063_QD__main__15$", duration: 12098, voice: @"ko/Npc/00002170");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 12098)) {
                    context.State = new State퀘스트유저감지_대사(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트유저감지_대사 : TriggerState {
            internal State퀘스트유저감지_대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {91000066},
                    arg3: new byte[] {3})) {
                    context.State = new State블리체_대사(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State블리체_대사 : TriggerState {
            internal State블리체_대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: "talk", npcID: 11003533, illust: "Bliche_nomal",
                    script: "$52010063_QD__main__14$", duration: 13000, voice: @"ko/Npc/00002153");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 13000)) {
                    context.State = new State마지막체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마지막체크 : TriggerState {
            internal State마지막체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {91000066},
                    arg3: new byte[] {3})) {
                    context.State = new State맵이동_작전실로(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}