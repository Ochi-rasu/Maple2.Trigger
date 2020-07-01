using System;

namespace Maple2.Trigger._02000251_bf {
    public static class _end {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State어나운스1 : TriggerState {
            internal State어나운스1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 7);
                context.SetEventUI(arg1: 1, arg2: "$02000251_BF__END__0$", arg3: new int[] {5000}, arg4: "0");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State어나운스2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State어나운스2 : TriggerState {
            internal State어나운스2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 7);
                context.SetEventUI(arg1: 1, arg2: "$02000251_BF__END__1$", arg3: new int[] {5000}, arg4: "0");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State어나운스3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State어나운스3 : TriggerState {
            internal State어나운스3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 7);
                context.SetEventUI(arg1: 1, arg2: "$02000251_BF__END__2$", arg3: new int[] {5000});
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State어나운스4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State어나운스4 : TriggerState {
            internal State어나운스4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 7);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State통과(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State통과 : TriggerState {
            internal State통과(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 300);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}