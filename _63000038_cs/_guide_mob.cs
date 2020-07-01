using System;

namespace Maple2.Trigger._63000038_cs {
    public static class _guide_mob {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterInCombat(arg1: new int[] {2101})) {
                    context.State = new State가이드출력(context);
                    return;
                }

                if (context.MonsterInCombat(arg1: new int[] {2102})) {
                    context.State = new State가이드출력(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State가이드출력 : TriggerState {
            internal State가이드출력(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 26300383, textID: 26300383);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {102})) {
                    context.State = new State가이드삭제대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State가이드삭제대기 : TriggerState {
            internal State가이드삭제대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State가이드삭제(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State가이드삭제 : TriggerState {
            internal State가이드삭제(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {2103})) {
                    context.HideGuideSummary(entityID: 26300383);
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