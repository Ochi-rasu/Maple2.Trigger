namespace Maple2.Trigger._51000002_dg {
    public static class _barricade {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {301}, arg2: false, arg3: 0, arg4: 0);
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 102, arg2: new[] {99})) {
                    context.State = new State카운트(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카운트 : TriggerState {
            internal State카운트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "90", arg2: 90);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "90")) {
                    context.State = new State차단(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State차단 : TriggerState {
            internal State차단(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {301}, arg2: true, arg3: 0, arg4: 200);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {99})) {
                    context.State = new State차단해제(context);
                    return;
                }

                if (!context.UserDetected(arg1: new[] {102})) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State차단해제 : TriggerState {
            internal State차단해제(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {301}, arg2: false, arg3: 0, arg4: 0);
            }

            public override void Execute() {
                if (!context.UserDetected(arg1: new[] {102})) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}