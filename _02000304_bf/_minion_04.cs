namespace Maple2.Trigger._02000304_bf {
    public static class _minion_04 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {114})) {
                    context.CreateMonster(arg1: new[] {1007, 1008}, arg2: false);
                    context.State = new State종료체크(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {2001})) {
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
                if (context.MonsterDead(arg1: new[] {1007, 1008})) {
                    context.State = new State대기시간(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.DestroyMonster(arg1: new[] {1007, 1008});
                    context.State = new State대기시간(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대기시간 : TriggerState {
            internal State대기시간(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.MoveUser(arg1: 02000304, arg2: 10, arg3: 114);
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}