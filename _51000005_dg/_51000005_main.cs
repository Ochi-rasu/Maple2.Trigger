using System;
using System.Numerics;

namespace Maple2.Trigger._51000005_dg {
    public static class _51000005_main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State입장(context);

        private class State입장 : TriggerState {
            internal State입장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 51000005, arg2: 10);
                context.CreateMonster(arg1: new int[] {101}, arg2: false);
                context.SetEffect(arg1: new int[] {601}, arg2: false);
                context.SetEffect(arg1: new int[] {602}, arg2: false);
                context.SetEffect(arg1: new int[] {603}, arg2: false);
                context.SetEffect(arg1: new int[] {604}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {9000})) {
                    context.State = new State인트로(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State인트로 : TriggerState {
            internal State인트로(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "셋둘하나_스킵완료", arg2: "nextState");
                context.CameraSelectPath(arg1: new int[] {8000}, arg2: false);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Talk_A", arg3: 1000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State인트로00(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State인트로00 : TriggerState {
            internal State인트로00(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8003, 8004}, arg2: false);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3, arg2: "$51000005_DG__51000005_MAIN__0$");
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Bore_B", arg3: 2500);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2600)) {
                    context.State = new State인트로01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State인트로01 : TriggerState {
            internal State인트로01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8005, 8006}, arg2: false);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3, arg2: "$51000005_DG__51000005_MAIN__1$");
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Emotion_A", arg3: 2400);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2700)) {
                    context.State = new State인트로02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State인트로02 : TriggerState {
            internal State인트로02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8002, 8001}, arg2: false);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3, arg2: "$51000005_DG__51000005_MAIN__2$");
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Talk_A", arg3: 3000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State인트로03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State인트로03 : TriggerState {
            internal State인트로03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.CameraSelectPath(arg1: new int[] {8003, 8006}, arg2: false);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3, arg2: "$51000005_DG__51000005_MAIN__3$");
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Emotion_D", arg3: 2400);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State게임시작_대기(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }
        }

        private class State셋둘하나_스킵완료 : TriggerState {
            internal State셋둘하나_스킵완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 1.5f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {9000})) {
                    context.State = new State게임시작_대기(context);
                    return;
                }

                if (!context.UserDetected(arg1: new int[] {9000})) {
                    context.State = new State연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State게임시작_대기 : TriggerState {
            internal State게임시작_대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8000}, arg2: false);
                context.SetAchievement(arg1: 9000, arg2: "trigger", arg3: "HyukiThreeTwoOne_start");
                context.WriteLog(arg1: "ThreeTwoOne_log", arg2: 9000, arg3: "char_event",
                    arg5: "HyukiThreeTwoOnegamestart");
                context.ArcadeThreeTwoOne2(type: "StartGame", lifeCount: 5, initScore: 10000);
                context.SetUserValue(triggerID: 4001, key: "Fail", value: 1);
                context.AddBalloonTalk(spawnPointID: 0, msg: "$51000005_DG__51000005_MAIN__4$", duration: 3000);
                context.PlaySystemSoundInBox(arg2: "System_PinkBeans_Arcade_Start_01");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State라운드준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State라운드준비 : TriggerState {
            internal State라운드준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {601}, arg2: false);
                context.SetEffect(arg1: new int[] {602}, arg2: false);
                context.SetEffect(arg1: new int[] {603}, arg2: false);
                context.SetEffect(arg1: new int[] {604}, arg2: false);
            }

            public override void Execute() {
                if (!context.UserDetected(arg1: new int[] {9000})) {
                    context.State = new State완전끝(context);
                    return;
                }

                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State라운드시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State라운드시작 : TriggerState {
            internal State라운드시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 1, textID: 26300736, duration: 3000);
                context.ArcadeThreeTwoOne2(type: "StartRound", uiDuration: 4, round: true);
                context.PlaySystemSoundInBox(arg2: "System_PinkBeans_Arcade_ArrowPopup_01");
            }

            public override void Execute() {
                if (!context.UserDetected(arg1: new int[] {9000})) {
                    context.State = new State완전끝(context);
                    return;
                }

                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State라운드진행(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State라운드진행 : TriggerState {
            internal State라운드진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointID: 101, msg: "$51000005_DG__51000005_MAIN__5$", duration: 1800);
            }

            public override void Execute() {
                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new State01_좌로돌아(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new State02_뒤로돌아(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new State03_우로돌아(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State01_좌로돌아 : TriggerState {
            internal State01_좌로돌아(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ArcadeThreeTwoOne2(type: "ResultRound", resultDirection: 1);
                context.SetNpcRotation(arg1: 101, arg2: 270);
                context.PlaySystemSoundInBox(arg2: "System_PinkBeans_Arcade_Turning_01");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State결과연출(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State02_뒤로돌아 : TriggerState {
            internal State02_뒤로돌아(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ArcadeThreeTwoOne2(type: "ResultRound", resultDirection: 2);
                context.SetNpcRotation(arg1: 101, arg2: 180);
                context.PlaySystemSoundInBox(arg2: "System_PinkBeans_Arcade_Turning_01");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State결과연출(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State03_우로돌아 : TriggerState {
            internal State03_우로돌아(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ArcadeThreeTwoOne2(type: "ResultRound", resultDirection: 3);
                context.SetNpcRotation(arg1: 101, arg2: 90);
                context.PlaySystemSoundInBox(arg2: "System_PinkBeans_Arcade_Turning_01");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State결과연출(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State결과연출 : TriggerState {
            internal State결과연출(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.InitNpcRotation(arg1: new int[] {101});
                context.SetPcRotation(rotation: new Vector3(0f, 0f, 0f));
                context.SetEffect(arg1: new int[] {601}, arg2: false);
                context.SetEffect(arg1: new int[] {602}, arg2: false);
                context.SetEffect(arg1: new int[] {603}, arg2: false);
                context.SetEffect(arg1: new int[] {604}, arg2: false);
            }

            public override void Execute() {
                if (context.UserValue(key: "ThreeTwoOneResult", value: 1)) {
                    context.SetNpcEmotionSequence(arg1: 101, arg2: "Emotion_B", arg3: 4000);
                    context.SetPcEmotionLoop(arg1: "Emotion_Dance_X", arg2: 2450f);
                    context.SetEffect(arg1: new int[] {602}, arg2: true);
                    context.SetEffect(arg1: new int[] {604}, arg2: true);
                    context.AddBalloonTalk(spawnPointID: 101, msg: "$51000005_DG__51000005_MAIN__6$", duration: 3000);
                    context.AddBalloonTalk(msg: "$51000005_DG__51000005_MAIN__7$", duration: 3000);
                    context.PlaySystemSoundInBox(arg2: "System_PinkBeans_Arcade_Correct_01");
                    context.State = new State결과정산(context);
                    return;
                }

                if (context.UserValue(key: "ThreeTwoOneResult", value: 0)) {
                    context.SetNpcEmotionSequence(arg1: 101, arg2: "Emotion_A", arg3: 2167);
                    context.SetEffect(arg1: new int[] {601}, arg2: true);
                    context.SetEffect(arg1: new int[] {603}, arg2: true);
                    context.SetPcEmotionSequence(arg1: "Emotion_Fuss_A");
                    context.AddBalloonTalk(spawnPointID: 101, msg: "$51000005_DG__51000005_MAIN__8$", duration: 3000);
                    context.AddBalloonTalk(msg: "$51000005_DG__51000005_MAIN__9$", duration: 2700);
                    context.PlaySystemSoundInBox(arg2: "System_PinkBeans_Arcade_Wrong_01");
                    context.State = new State결과정산(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State결과정산 : TriggerState {
            internal State결과정산(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ArcadeThreeTwoOne2(type: "ResultRound2", round: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2300)) {
                    context.State = new State라운드결과(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State라운드결과 : TriggerState {
            internal State라운드결과(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ArcadeThreeTwoOne2(type: "ClearRound", round: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State라운드준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출종료 : TriggerState {
            internal State연출종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ArcadeThreeTwoOne2(type: "EndGame");
                context.MoveUser(arg1: 51000005, arg2: 44);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State진짜끝(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State진짜끝 : TriggerState {
            internal State진짜끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 8010, arg2: true);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.PlaySystemSoundInBox(arg2: "System_PinkBeans_Arcade_Result_01");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State완전끝(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State완전끝 : TriggerState {
            internal State완전끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}