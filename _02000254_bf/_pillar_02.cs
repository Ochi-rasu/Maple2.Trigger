namespace Maple2.Trigger._02000254_bf {
    public static class _pillar_02 {
        public class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000441}, arg2: 0);
                context.SetSkill(arg1: new[] {702}, arg2: false);
                context.SetEffect(arg1: new[] {444}, arg2: false);
                context.SetEffect(arg1: new[] {445}, arg2: false);
                context.SetEffect(arg1: new[] {461}, arg2: false);
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 906, arg2: new[] {104})) {
                    context.State = new State반응대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State반응대기 : TriggerState {
            internal State반응대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000441}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000441}, arg2: 0)) {
                    context.State = new State스턴(context);
                    return;
                }

                if (!context.NpcDetected(arg1: 906, arg2: new[] {104})) {
                    context.State = new State시작대기중(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스턴 : TriggerState {
            internal State스턴(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {444}, arg2: true);
                context.SetEffect(arg1: new[] {445}, arg2: true);
                context.SetEffect(arg1: new[] {461}, arg2: true);
                context.SetSkill(arg1: new[] {702}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스턴2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스턴2 : TriggerState {
            internal State스턴2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {702}, arg2: false);
                context.SetTimer(arg1: "1", arg2: 10);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State시작대기중(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}