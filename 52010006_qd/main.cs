namespace Maple2.Trigger._52010006_qd {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1001}, arg2: false);
                context.SetMesh(arg1: new[] {3001}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3002, 3003, 3004, 3005}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3006, 3007, 3008, 3009}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {101})) {
                    return new State미카Appear(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미카Appear : TriggerState {
            internal State미카Appear(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State미카대사01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미카대사01 : TriggerState {
            internal State미카대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetConversation(arg1: 2, arg2: 11001285, arg3: "$52010006_QD__MAIN__0$", arg4: 4);
                context.SetSceneSkip(arg1: "미카대사02_0");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State미카대사02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미카대사02_0 : TriggerState {
            internal State미카대사02_0(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                return new State미카대사02(context);
            }

            public override void OnExit() { }
        }

        private class State미카대사02 : TriggerState {
            internal State미카대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001285, arg3: "$52010006_QD__MAIN__10$", arg4: 4);
                context.SetSceneSkip(arg1: "몬스터생성_0");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    return new StateMobCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobCreation_0 : TriggerState {
            internal StateMobCreation_0(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                return new StateMobCreation(context);
            }

            public override void OnExit() { }
        }

        private class StateMobCreation : TriggerState {
            internal StateMobCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.MoveNpc(arg1: 1001, arg2: "MS2PatrolData_1001_A");
                context.CreateMonster(arg1: new[] {2001}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    return new State미카이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미카이동 : TriggerState {
            internal State미카이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1001, arg2: "MS2PatrolData_1001_B");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 104, arg2: new[] {1001})) {
                    return new State미카교체(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미카교체 : TriggerState {
            internal State미카교체(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {1001});
                context.CreateMonster(arg1: new[] {1007}, arg2: false);
                context.MoveNpc(arg1: 1007, arg2: "MS2PatrolData_1001_C");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 102, arg2: new[] {1007})) {
                    return new State사슬(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State사슬 : TriggerState {
            internal State사슬(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1002}, arg2: false);
                context.SetMesh(arg1: new[] {3001}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State카보대사01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State카보대사01 : TriggerState {
            internal State카보대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetConversation(arg1: 2, arg2: 11001319, arg3: "$52010006_QD__MAIN__1$", arg4: 5);
                context.SetSceneSkip(arg1: "카보대사02_0");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State카보대사02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State카보대사02_0 : TriggerState {
            internal State카보대사02_0(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                return new State카보대사02(context);
            }

            public override void OnExit() { }
        }

        private class State카보대사02 : TriggerState {
            internal State카보대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001319, arg3: "$52010006_QD__MAIN__2$", arg4: 5);
                context.SetSceneSkip(arg1: "미카친구들소환_0");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State미카친구들소환(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
            }
        }

        private class State미카친구들소환_0 : TriggerState {
            internal State미카친구들소환_0(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                return new State미카친구들소환(context);
            }

            public override void OnExit() { }
        }

        private class State미카친구들소환 : TriggerState {
            internal State미카친구들소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.CreateMonster(arg1: new[] {1003, 1004, 1005}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    return new State스타츠대사01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스타츠대사01 : TriggerState {
            internal State스타츠대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.MoveNpc(arg1: 1003, arg2: "MS2PatrolData_1003_A");
                context.MoveNpc(arg1: 1004, arg2: "MS2PatrolData_1004_A");
                context.MoveNpc(arg1: 1005, arg2: "MS2PatrolData_1005_A");
                context.SetConversation(arg1: 2, arg2: 11001292, arg3: "$52010006_QD__MAIN__3$", arg4: 2);
                context.SetSceneSkip(arg1: "둔바대사01_0");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State둔바대사01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State둔바대사01_0 : TriggerState {
            internal State둔바대사01_0(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                return new State둔바대사01(context);
            }

            public override void OnExit() { }
        }

        private class State둔바대사01 : TriggerState {
            internal State둔바대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001217, arg3: "$52010006_QD__MAIN__11$", arg4: 2);
                context.SetSceneSkip(arg1: "타라대사01_0");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State타라대사01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State타라대사01_0 : TriggerState {
            internal State타라대사01_0(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                return new State타라대사01(context);
            }

            public override void OnExit() { }
        }

        private class State타라대사01 : TriggerState {
            internal State타라대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001218, arg3: "$52010006_QD__MAIN__12$", arg4: 3);
                context.SetSceneSkip(arg1: "카보대사03_0");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State카보대사03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State카보대사03_0 : TriggerState {
            internal State카보대사03_0(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                return new State카보대사03(context);
            }

            public override void OnExit() { }
        }

        private class State카보대사03 : TriggerState {
            internal State카보대사03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1002, arg2: "MS2PatrolData_1002_A");
                context.SetConversation(arg1: 2, arg2: 11001319, arg3: "$52010006_QD__MAIN__4$", arg4: 5);
                context.SetSceneSkip(arg1: "카보소환_0");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State카보소환(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
            }
        }

        private class State카보소환_0 : TriggerState {
            internal State카보소환_0(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                return new State카보소환(context);
            }

            public override void OnExit() { }
        }

        private class State카보소환 : TriggerState {
            internal State카보소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.DestroyMonster(arg1: new[] {1002});
                context.CreateMonster(arg1: new[] {2002}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new State카보대사04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State카보대사04 : TriggerState {
            internal State카보대사04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {2002});
                context.CreateMonster(arg1: new[] {1006}, arg2: false);
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetConversation(arg1: 2, arg2: 11001319, arg3: "$52010006_QD__MAIN__5$", arg4: 5);
                context.SetSceneSkip(arg1: "카보대사05_0");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State카보대사05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State카보대사05_0 : TriggerState {
            internal State카보대사05_0(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                return new State카보대사05(context);
            }

            public override void OnExit() { }
        }

        private class State카보대사05 : TriggerState {
            internal State카보대사05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001319, arg3: "$52010006_QD__MAIN__6$", arg4: 5);
                context.MoveNpc(arg1: 1006, arg2: "MS2PatrolData_1002_B");
                context.SetSceneSkip(arg1: "사슬해제_0");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.DestroyMonster(arg1: new[] {1006});
                    return new State사슬해제(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State사슬해제_0 : TriggerState {
            internal State사슬해제_0(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                return new State사슬해제(context);
            }

            public override void OnExit() { }
        }

        private class State사슬해제 : TriggerState {
            internal State사슬해제(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.MoveNpc(arg1: 1003, arg2: "MS2PatrolData_1003_B");
                context.MoveNpc(arg1: 1004, arg2: "MS2PatrolData_1004_B");
                context.MoveNpc(arg1: 1005, arg2: "MS2PatrolData_1005_B");
                context.SetMesh(arg1: new[] {3001}, arg2: false, arg3: 0, arg4: 0, arg5: 3f);
                context.SetMesh(arg1: new[] {3002, 3003, 3004, 3005}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3006, 3007, 3008, 3009}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    context.MoveNpc(arg1: 1007, arg2: "MS2PatrolData_1001_D");
                    return new State스타츠대사02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스타츠대사02 : TriggerState {
            internal State스타츠대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetConversation(arg1: 2, arg2: 11001292, arg3: "$52010006_QD__MAIN__7$", arg4: 5);
                context.SetSceneSkip(arg1: "스타츠대사03_0");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State스타츠대사03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스타츠대사03_0 : TriggerState {
            internal State스타츠대사03_0(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                return new State스타츠대사03(context);
            }

            public override void OnExit() { }
        }

        private class State스타츠대사03 : TriggerState {
            internal State스타츠대사03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001292, arg3: "$52010006_QD__MAIN__8$", arg4: 5);
                context.SetSceneSkip(arg1: "스타츠대사04_0");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State스타츠대사04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스타츠대사04_0 : TriggerState {
            internal State스타츠대사04_0(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                return new State스타츠대사04(context);
            }

            public override void OnExit() { }
        }

        private class State스타츠대사04 : TriggerState {
            internal State스타츠대사04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001292, arg3: "$52010006_QD__MAIN__9$", arg4: 5);
                context.SetSceneSkip(arg1: "업적이벤트발생_0");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.SetCinematicUI(arg1: 0);
                    context.SetCinematicUI(arg1: 2);
                    return new StateAchievement(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateAchievement_0 : TriggerState {
            internal StateAchievement_0(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                return new StateAchievement(context);
            }

            public override void OnExit() { }
        }

        private class StateAchievement : TriggerState {
            internal StateAchievement(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.SetAchievement(arg1: 103, arg2: "trigger", arg3: "RescueMika");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State강제이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State강제이동 : TriggerState {
            internal State강제이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 02010030, arg2: 4, arg3: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}