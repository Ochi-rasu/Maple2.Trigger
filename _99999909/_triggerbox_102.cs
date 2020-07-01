using System;

namespace Maple2.Trigger._99999909 {
    public static class _triggerbox_102 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State블록(context);

        private class State블록 : TriggerState {
            internal State블록(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(
                    arg1: new int[] {
                        3011, 3012, 3013, 3014, 3015, 3016, 3017, 3018, 3019, 3020, 3021, 3022, 3023, 3024, 3025, 3026,
                        3027, 3028
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {102})) {
                    context.State = new State블록생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State블록생성 : TriggerState {
            internal State블록생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetRandomMesh(
                    arg1: new int[] {
                        3011, 3012, 3013, 3014, 3015, 3016, 3017, 3018, 3019, 3020, 3021, 3022, 3023, 3024, 3025, 3026,
                        3027, 3028
                    }, arg2: true, arg3: 6, arg4: 0, arg5: 1);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}