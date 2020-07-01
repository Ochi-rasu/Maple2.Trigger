using System;

namespace Maple2.Trigger._99999940_bgtest {
    public static class _sample {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작대기(context);

        private class State시작대기 : TriggerState {
            internal State시작대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}