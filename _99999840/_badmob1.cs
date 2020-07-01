namespace Maple2.Trigger._99999840 {
    public static class _badmob1 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990003, key: "BadMob", value: 0);
            }

            public override void Execute() {
                if (context.GetDungeonVariable(id: 911) == true) {
                    context.State = new State몬스터스폰(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터스폰 : TriggerState {
            internal State몬스터스폰(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {991}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {991, 992, 993})) {
                    context.State = new State신호쏴주기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State신호쏴주기 : TriggerState {
            internal State신호쏴주기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990003, key: "BadMob", value: 1);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetDungeonVariable(id: 911) == false) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}