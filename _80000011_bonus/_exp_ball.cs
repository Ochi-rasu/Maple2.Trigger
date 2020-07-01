using System;

namespace Maple2.Trigger._80000011_bonus {
    public static class _exp_ball {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State입장(context);

        private class State입장 : TriggerState {
            internal State입장(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {101})) {
                    context.CreateItem(arg1: new int[] {9001});
                    context.State = new State5초(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State5초 : TriggerState {
            internal State5초(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 5);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.CreateItem(arg1: new int[] {9001});
                    context.State = new State10초(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State10초 : TriggerState {
            internal State10초(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 5);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.CreateItem(arg1: new int[] {9001});
                    context.State = new State15초(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State15초 : TriggerState {
            internal State15초(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 5);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.CreateItem(arg1: new int[] {9001});
                    context.State = new State20초(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State20초 : TriggerState {
            internal State20초(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 5);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.CreateItem(arg1: new int[] {9001});
                    context.State = new State25초(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State25초 : TriggerState {
            internal State25초(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 5);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.CreateItem(arg1: new int[] {9001});
                    context.State = new State완료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State완료 : TriggerState {
            internal State완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}