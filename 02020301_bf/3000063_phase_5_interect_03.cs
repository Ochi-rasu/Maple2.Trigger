namespace Maple2.Trigger._02020301_bf {
    public static class _3000063_phase_5_interect_03 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {200035, 200036}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Phase_5_Interect_03") == 1) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State인터렉트_설정(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인터렉트_설정 : TriggerState {
            internal State인터렉트_설정(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {200035, 200036}, arg2: true);
                context.SetInteractObject(arg1: new[] {10003103}, arg2: 1);
                context.SetVisibleBreakableObject(arg1: new[] {5530}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10003103}, arg2: 0)) {
                    return new State인터렉트_동작(context);
                }

                if (context.GetUserValue(key: "Phase_5_Interect_03") == 0) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인터렉트_동작 : TriggerState {
            internal State인터렉트_동작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {200035, 200036}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State인터렉트_리셋(context);
                }

                if (context.GetUserValue(key: "Phase_5_Interect_03") == 0) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인터렉트_리셋 : TriggerState {
            internal State인터렉트_리셋(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    return new State인터렉트_설정(context);
                }

                if (context.GetUserValue(key: "Phase_5_Interect_03") == 0) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}