namespace Maple2.Trigger._02010086_bf {
    public static class _boss_bomb {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserCount(boxId: 799) == 1) {
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {6001}, arg2: true);
                context.SetSkill(arg1: new[] {6002}, arg2: true);
                context.SetSkill(arg1: new[] {6003}, arg2: true);
                context.SetSkill(arg1: new[] {6004}, arg2: true);
                context.SetEffect(arg1: new[] {6010}, arg2: true);
                context.SetEffect(arg1: new[] {6011}, arg2: true);
                context.SetEffect(arg1: new[] {6012}, arg2: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}