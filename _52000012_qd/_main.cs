using System;

namespace Maple2.Trigger._52000012_qd {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State초기상태(context);

        private class State초기상태 : TriggerState {
            internal State초기상태(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: "6000", arg2: true);
                context.SetAgent(arg1: "6001", arg2: true);
                context.SetAgent(arg1: "6002", arg2: true);
                context.SetAgent(arg1: "6003", arg2: true);
                context.SetAgent(arg1: "6004", arg2: true);
                context.SetAgent(arg1: "6005", arg2: true);
                context.SetAgent(arg1: "6006", arg2: true);
                context.SetAgent(arg1: "6007", arg2: true);
                context.SetAgent(arg1: "6008", arg2: true);
                context.SetAgent(arg1: "6009", arg2: true);
                context.SetAgent(arg1: "6010", arg2: true);
                context.SetAgent(arg1: "6011", arg2: true);
                context.SetAgent(arg1: "6012", arg2: true);
                context.SetAgent(arg1: "6013", arg2: true);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetActor(arg1: 5001, arg2: false, arg3: "DownIdle_B");
                context.SetEffect(arg1: new int[] {5002}, arg2: false);
                context.SetActor(arg1: 10001, arg2: true, arg3: "Closed");
                context.SetActor(arg1: 10002, arg2: true, arg3: "Closed");
                context.CreateMonster(arg1: new int[] {101}, arg2: false);
                context.CreateMonster(arg1: new int[] {102}, arg2: false);
                context.CreateMonster(arg1: new int[] {103}, arg2: false);
                context.CreateMonster(arg1: new int[] {5000}, arg2: false);
                context.SetAgent(arg1: "7000", arg2: true);
                context.SetAgent(arg1: "7001", arg2: true);
                context.SetAgent(arg1: "7002", arg2: true);
                context.SetAgent(arg1: "7003", arg2: true);
                context.SetAgent(arg1: "7004", arg2: true);
                context.SetAgent(arg1: "8000", arg2: true);
                context.SetAgent(arg1: "8001", arg2: true);
                context.SetAgent(arg1: "8002", arg2: true);
                context.SetAgent(arg1: "8003", arg2: true);
                context.SetAgent(arg1: "8004", arg2: true);
                context.SetAgent(arg1: "8006", arg2: true);
                context.SetAgent(arg1: "8007", arg2: true);
                context.SetAgent(arg1: "8008", arg2: true);
                context.SetAgent(arg1: "8009", arg2: true);
                context.SetAgent(arg1: "8010", arg2: true);
                context.SetMesh(arg1: new int[] {10011}, arg2: true);
                context.SetMesh(arg1: new int[] {10012}, arg2: true);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {10002610},
                    arg3: new byte[] {1})) {
                    context.State = new State레논연출1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State레논연출1 : TriggerState {
            internal State레논연출1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "9", arg2: 2);
                context.CreateMonster(arg1: new int[] {1000}, arg2: false);
                context.SetAgent(arg1: "7000", arg2: false);
                context.SetAgent(arg1: "7001", arg2: false);
                context.SetAgent(arg1: "7002", arg2: false);
                context.SetAgent(arg1: "7003", arg2: false);
                context.SetAgent(arg1: "7004", arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "9")) {
                    context.State = new State레논연출2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State레논연출2 : TriggerState {
            internal State레논연출2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "10", arg2: 4);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetConversation(arg1: 2, arg2: 11000064, arg3: "$52000012_QD__MAIN__0$", arg4: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "10")) {
                    context.State = new State전투1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투1 : TriggerState {
            internal State전투1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {101, 102, 103})) {
                    context.State = new State벨라연출시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벨라연출시작 : TriggerState {
            internal State벨라연출시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetTimer(arg1: "8", arg2: 3);
                context.CameraSelectPath(arg1: new int[] {901, 902}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "8")) {
                    context.State = new State벨라연출중(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벨라연출중 : TriggerState {
            internal State벨라연출중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "11", arg2: 7);
                context.SetConversation(arg1: 2, arg2: 11000844, arg3: "$52000012_QD__MAIN__1$", arg4: 2);
                context.SetConversation(arg1: 2, arg2: 11000064, arg3: "$52000012_QD__MAIN__2$", arg4: 2);
                context.SetConversation(arg1: 2, arg2: 11000064, arg3: "$52000012_QD__MAIN__3$", arg4: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "11")) {
                    context.State = new State벨라연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벨라연출종료 : TriggerState {
            internal State벨라연출종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "14", arg2: 1);
                context.CameraSelectPath(arg1: new int[] {906}, arg2: true);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "14")) {
                    context.State = new State문열림1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State문열림1 : TriggerState {
            internal State문열림1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "19", arg2: 1);
                context.SetAgent(arg1: "8000", arg2: false);
                context.SetAgent(arg1: "8001", arg2: false);
                context.SetAgent(arg1: "8002", arg2: false);
                context.SetAgent(arg1: "8003", arg2: false);
                context.SetAgent(arg1: "8004", arg2: false);
                context.CreateMonster(arg1: new int[] {201}, arg2: false);
                context.CreateMonster(arg1: new int[] {202}, arg2: false);
                context.CreateMonster(arg1: new int[] {203}, arg2: false);
                context.SetActor(arg1: 10001, arg2: true, arg3: "Opened");
                context.SetMesh(arg1: new int[] {10011}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "19")) {
                    context.State = new State전투2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투2 : TriggerState {
            internal State전투2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1000, arg2: "MS2PatrolData_1001");
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {201, 202, 203})) {
                    context.State = new State문열림2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State문열림2 : TriggerState {
            internal State문열림2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "12", arg2: 2);
                context.SetAgent(arg1: "8006", arg2: false);
                context.SetAgent(arg1: "8007", arg2: false);
                context.SetAgent(arg1: "8008", arg2: false);
                context.SetAgent(arg1: "8009", arg2: false);
                context.SetAgent(arg1: "8010", arg2: false);
                context.SetActor(arg1: 10002, arg2: true, arg3: "Opened");
                context.SetMesh(arg1: new int[] {10012}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "12")) {
                    context.State = new State악령연출시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State악령연출시작 : TriggerState {
            internal State악령연출시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetTimer(arg1: "13", arg2: 6);
                context.CameraSelectPath(arg1: new int[] {904, 905}, arg2: false);
                context.CreateMonster(arg1: new int[] {301}, arg2: false);
                context.MoveNpc(arg1: 301, arg2: "MS2PatrolData_301");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "13")) {
                    context.State = new State화면끄기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State화면끄기 : TriggerState {
            internal State화면끄기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "22", arg2: 1);
                context.SetProductionUI(arg1: 4);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "22")) {
                    context.State = new State영혼연출(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State영혼연출 : TriggerState {
            internal State영혼연출(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "23", arg2: 2);
                context.DestroyMonster(arg1: new int[] {301});
                context.DestroyMonster(arg1: new int[] {5000});
                context.DestroyMonster(arg1: new int[] {301});
                context.DestroyMonster(arg1: new int[] {5000});
                context.SetActor(arg1: 5001, arg2: true, arg3: "DownIdle_B");
                context.SetEffect(arg1: new int[] {5002}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "23")) {
                    context.State = new State화면켜기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State화면켜기 : TriggerState {
            internal State화면켜기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 4);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetTimer(arg1: "14", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "14")) {
                    context.State = new State영혼연출중(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State영혼연출중 : TriggerState {
            internal State영혼연출중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "15", arg2: 4);
                context.SetConversation(arg1: 2, arg2: 11000064, arg3: "$52000012_QD__MAIN__4$", arg4: 3);
                context.CameraSelectPath(arg1: new int[] {905, 903}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "15")) {
                    context.State = new State영혼연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State영혼연출종료 : TriggerState {
            internal State영혼연출종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1000, arg2: "MS2PatrolData_1002");
                context.CameraSelect(arg1: 903, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State전투3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투3 : TriggerState {
            internal State전투3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 5001, arg2: false, arg3: "DownIdle_B");
                context.SetEffect(arg1: new int[] {5002}, arg2: false);
                context.CreateMonster(arg1: new int[] {302}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {302})) {
                    context.State = new State레논교체(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State레논교체 : TriggerState {
            internal State레논교체(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {1000});
                context.CreateMonster(arg1: new int[] {2000}, arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {10002611},
                    arg3: new byte[] {2})) {
                    context.State = new State포털생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State포털생성 : TriggerState {
            internal State포털생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (!context.UserDetected(arg1: new int[] {9001})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {1000, 2000, 101, 102, 103, 201, 202, 203, 301, 302});
            }

            public override void Execute() {
                if (true) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}