using System;

namespace Maple2.Trigger._02000246_bf {
    public static class _trigger_02_01 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {611, 612, 613, 614, 615, 616, 617, 618, 619});
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {202})) {
                    context.State = new State몹생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몹생성 : TriggerState {
            internal State몹생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {611, 612, 613, 614, 615, 616, 617, 618, 619}, arg2: false);
                context.SetTimer(arg1: "1", arg2: 120);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {611, 612, 613, 614, 615, 616, 617, 618, 619})) {
                    context.State = new State통과(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State통과 : TriggerState {
            internal State통과(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 180);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}