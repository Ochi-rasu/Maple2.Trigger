using System;

namespace Maple2.Trigger._02020025_bf {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State입장(context);

        private class State입장 : TriggerState {
            internal State입장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: "9001", arg2: true);
                context.SetAgent(arg1: "9002", arg2: true);
                context.SetAgent(arg1: "9003", arg2: true);
                context.SetAgent(arg1: "9004", arg2: true);
                context.SetAgent(arg1: "9005", arg2: true);
                context.SetAgent(arg1: "9006", arg2: true);
                context.SetAgent(arg1: "9007", arg2: true);
                context.SetAgent(arg1: "9008", arg2: true);
                context.DestroyMonster(arg1: new int[] {-1});
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 3, arg2: false, arg3: false, arg4: false);
                context.SetUserValue(triggerID: 99990004, key: "Timer", value: 0);
                context.SetUserValue(triggerID: 99990006, key: "SpecialTimer", value: 0);
                context.SetUserValue(triggerID: 99990002, key: "battlesetting", value: 0);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {901})) {
                    context.State = new State카메라_시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라_시작 : TriggerState {
            internal State카메라_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "카메라_종료", arg2: "exit");
                context.MoveUser(arg1: 02020025, arg2: 1);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State카메라_캡션(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라_캡션 : TriggerState {
            internal State카메라_캡션(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {5001, 5002}, arg2: true);
                context.ShowCaption(type: "VerticalCaption", title: "$02020025_BF__main__3$",
                    desc: "$02020025_BF__main__4$", align: "centerLeft", offsetRateX: 0f, offsetRateY: 0f,
                    duration: 5000, scale: 2f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State유저연출(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State유저연출 : TriggerState {
            internal State유저연출(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {202});
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$02020025_BF__main__5$", arg4: 5, arg5: 0);
                context.CameraSelect(arg1: 503, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State카메라_콘대르설명1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라_콘대르설명1 : TriggerState {
            internal State카메라_콘대르설명1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 202, arg2: "Talk_B", arg3: 18430f);
                context.AddCinematicTalk(npcID: 24110001, msg: "$02020025_BF__main__0$", duration: 4000, align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State유저연출_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State유저연출_2 : TriggerState {
            internal State유저연출_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$02020025_BF__main__6$", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State유저연출_3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State유저연출_3 : TriggerState {
            internal State유저연출_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 504, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State카메라_콘대르설명2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라_콘대르설명2 : TriggerState {
            internal State카메라_콘대르설명2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 24110001, illustID: "Conder_normal", msg: "$02020025_BF__main__1$",
                    duration: 4000, align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State카메라_콘대르설명3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라_콘대르설명3 : TriggerState {
            internal State카메라_콘대르설명3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 24110001, illustID: "Conder_normal", msg: "$02020025_BF__main__2$",
                    duration: 4000, align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State카메라_콘대르설명4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라_콘대르설명4 : TriggerState {
            internal State카메라_콘대르설명4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 24110001, illustID: "Conder_normal", msg: "$02020025_BF__main__7$",
                    duration: 4000, align: "left");
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State카메라_종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라_종료 : TriggerState {
            internal State카메라_종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 0.1f);
                context.DestroyMonster(arg1: new int[] {202});
            }

            public override void Execute() {
                if (true) {
                    context.State = new State준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State준비 : TriggerState {
            internal State준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {201}, arg2: false, arg3: 3000);
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 902, arg2: new int[] {201}) && context.WaitTick(waitTick: 2000)) {
                    context.State = new State전투_진행(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투_진행 : TriggerState {
            internal State전투_진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: "9001", arg2: false);
                context.SetAgent(arg1: "9002", arg2: false);
                context.SetAgent(arg1: "9003", arg2: false);
                context.SetAgent(arg1: "9004", arg2: false);
                context.SetAgent(arg1: "9005", arg2: false);
                context.SetAgent(arg1: "9006", arg2: false);
                context.SetAgent(arg1: "9007", arg2: false);
                context.SetAgent(arg1: "9008", arg2: false);
                context.SetUserValue(triggerID: 99990002, key: "battlesetting", value: 1);
            }

            public override void Execute() {
                if (context.UserValue(key: "End", value: 1)) {
                    context.State = new State랭크체크대사(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State랭크체크대사 : TriggerState {
            internal State랭크체크대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DungeonFirstUserMissionScore(score: 1500, @operator: "GreaterEqual")) {
                    context.SideNpcTalk(npcID: 24110001, illust: "Conder_normal", duration: 5000,
                        script: "$02020025_BF__main__8$", voice: @"ko/Npc/00002146");
                    context.State = new State던전종료_A랭크이상(context);
                    return;
                }

                if (context.DungeonFirstUserMissionScore(score: 1500, @operator: "Less")) {
                    context.SideNpcTalk(npcID: 24110001, illust: "Conder_smile", duration: 5000,
                        script: "$02020025_BF__main__9$", voice: @"ko/Npc/00002145");
                    context.State = new State던전종료_A랭크미만(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State던전종료_A랭크이상 : TriggerState {
            internal State던전종료_A랭크이상(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {201});
                context.DungeonClear();
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State던전종료_A랭크미만 : TriggerState {
            internal State던전종료_A랭크미만(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {201});
                context.DungeonFail();
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}