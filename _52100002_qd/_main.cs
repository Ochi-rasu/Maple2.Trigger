using System;

namespace Maple2.Trigger._52100002_qd {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {601}, arg2: false);
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetMesh(arg1: new int[] {3000}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {199})) {
                    context.State = new State퀘스트체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트체크 : TriggerState {
            internal State퀘스트체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {199}, arg2: new int[] {50100060},
                    arg3: new byte[] {1})) {
                    context.State = new State룸체크(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {199}, arg2: new int[] {50100060},
                    arg3: new byte[] {2})) {
                    context.State = new State퀘스트완료가능이거나완료1(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {199}, arg2: new int[] {50100060},
                    arg3: new byte[] {3})) {
                    context.State = new State퀘스트완료가능이거나완료1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State룸체크 : TriggerState {
            internal State룸체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.IsDungeonRoom()) {
                    context.State = new State던전시작(context);
                    return;
                }

                if (!context.IsDungeonRoom()) {
                    context.State = new State퀘스트던전시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State던전시작 : TriggerState {
            internal State던전시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {1001, 1002, 2001}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterInCombat(arg1: new int[] {2001})) {
                    context.SetEffect(arg1: new int[] {601}, arg2: true);
                    context.State = new State사망체크(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {2001, 2002})) {
                    context.State = new State사망딜레이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State사망체크 : TriggerState {
            internal State사망체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {2001, 2002})) {
                    context.State = new State사망딜레이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State사망딜레이 : TriggerState {
            internal State사망딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State종료체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료체크 : TriggerState {
            internal State종료체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {2001, 2002})) {
                    context.State = new State암전대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트던전시작 : TriggerState {
            internal State퀘스트던전시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {1001, 1002, 2101}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterInCombat(arg1: new int[] {2101})) {
                    context.SetEffect(arg1: new int[] {601}, arg2: true);
                    context.State = new State퀘스트사망체크(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {2101, 2102})) {
                    context.State = new State퀘스트사망딜레이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트사망체크 : TriggerState {
            internal State퀘스트사망체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {2101, 2102})) {
                    context.State = new State퀘스트사망딜레이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트사망딜레이 : TriggerState {
            internal State퀘스트사망딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State퀘스트종료체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트종료체크 : TriggerState {
            internal State퀘스트종료체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {2101, 2102})) {
                    context.State = new State암전대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State암전대기 : TriggerState {
            internal State암전대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State암전(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State암전 : TriggerState {
            internal State암전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State종료연출대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료연출대기 : TriggerState {
            internal State종료연출대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 301, arg2: true);
                context.MoveUser(arg1: 52100002, arg2: 2);
                context.DestroyMonster(arg1: new int[] {1001, 1002, 2001, 2002, 2101, 2102});
                context.CreateMonster(arg1: new int[] {1098, 1099}, arg2: false);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetNpcEmotionLoop(arg1: 1098, arg2: "Dead_B", arg3: 3000000f);
                context.SetNpcEmotionLoop(arg1: 1099, arg2: "Dead_B", arg3: 3000000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State종료연출(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료연출 : TriggerState {
            internal State종료연출(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip(arg1: "연출종료");
                context.AddCinematicTalk(npcID: 11003889, illustID: "Firis_normal", msg: "$02000392_BF__MAIN__0$",
                    align: "left", duration: 4000);
                context.AddCinematicTalk(npcID: 11003888, illustID: "Celine_normal", msg: "$02000392_BF__MAIN__1$",
                    align: "right", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new StatePC대사(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePC대사 : TriggerState {
            internal StatePC대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$02000392_BF__MAIN__2$", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StatePC대사2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePC대사2 : TriggerState {
            internal StatePC대사2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$02000392_BF__MAIN__10$", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State자매교체(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State자매교체 : TriggerState {
            internal State자매교체(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {1098, 1099});
                context.CreateMonster(arg1: new int[] {1096, 1097}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State자매대화(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State자매대화 : TriggerState {
            internal State자매대화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 302, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State자매대화01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State자매대화01 : TriggerState {
            internal State자매대화01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003889, illustID: "Firis_normal", msg: "$02000392_BF__MAIN__3$",
                    align: "left", duration: 4000);
                context.AddCinematicTalk(npcID: 11003888, illustID: "Celine_normal", msg: "$02000392_BF__MAIN__4$",
                    align: "right", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new State자매대화02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State자매대화02 : TriggerState {
            internal State자매대화02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003889, illustID: "Firis_normal", msg: "$02000392_BF__MAIN__5$",
                    align: "left", duration: 5000);
                context.SetConversation(arg1: 1, arg2: 1097, arg3: "$02000392_BF__MAIN__6$", arg4: 2, arg5: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State자매대화03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State자매대화03 : TriggerState {
            internal State자매대화03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003888, illustID: "Celine_normal", msg: "$02000392_BF__MAIN__11$",
                    align: "left", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StatePC대사3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePC대사3 : TriggerState {
            internal StatePC대사3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$02000392_BF__MAIN__12$", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State자매대화04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State자매대화04 : TriggerState {
            internal State자매대화04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003888, illustID: "Celine_normal", msg: "$02000392_BF__MAIN__7$",
                    align: "left", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State자매대화05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State자매대화05 : TriggerState {
            internal State자매대화05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003888, illustID: "Celine_normal", msg: "$02000392_BF__MAIN__8$",
                    align: "left", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State자매대화06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State자매대화06 : TriggerState {
            internal State자매대화06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003888, illustID: "Celine_normal", msg: "$02000392_BF__MAIN__9$",
                    align: "left", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출종료 : TriggerState {
            internal State연출종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
                context.DestroyMonster(arg1: new int[] {1098, 1099});
                context.DestroyMonster(arg1: new int[] {1096, 1097});
                context.CreateMonster(arg1: new int[] {1096, 1097}, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 1.0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State룸체크2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트완료가능이거나완료1 : TriggerState {
            internal State퀘스트완료가능이거나완료1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {1096, 1097}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State룸체크2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State룸체크2 : TriggerState {
            internal State룸체크2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.IsDungeonRoom()) {
                    context.State = new State던전완료(context);
                    return;
                }

                if (!context.IsDungeonRoom()) {
                    context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State던전완료 : TriggerState {
            internal State던전완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonClear();
                context.SetAchievement(arg1: 199, arg2: "trigger", arg3: "ClearSirenSisters");
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State종료(context);
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