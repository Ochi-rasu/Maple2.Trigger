namespace Maple2.Trigger._02000076_tw_henesysvillage {
    public static class _01_npcbackup01 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {1001}, arg2: new[] {10002041},
                    arg3: new byte[] {1})) {
                    context.State = new State지원군생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State지원군생성 : TriggerState {
            internal State지원군생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101}, arg2: false);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_11");
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$02000076_TW_HenesysVillage__01_NPCBACKUP01__0$",
                    arg4: 1);
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 3001, arg2: new[] {101})) {
                    context.State = new State지원군이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State지원군이동 : TriggerState {
            internal State지원군이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_101");
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 2001, arg2: new[] {101})) {
                    context.State = new State지원군소멸(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State지원군소멸 : TriggerState {
            internal State지원군소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101});
                context.SetTimer(arg1: "1", arg2: 60);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}