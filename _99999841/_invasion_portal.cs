namespace Maple2.Trigger._99999841 {
    public static class _invasion_portal {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990010, key: "PCmove", value: 0);
                context.SetInteractObject(arg1: new[] {10002184}, arg2: 2, arg3: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State포탈열림 : TriggerState {
            internal State포탈열림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 30, arg3: true);
                context.SetInteractObject(arg1: new[] {10002184}, arg2: 1, arg3: false);
            }

            public override void Execute() {
                if (context.GetDungeonVariable(id: 2) == true) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.ResetTimer(arg1: "1");
                    context.State = new State포탈닫힘(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10002184}, arg2: 2)) {
                    context.State = new State유저이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State유저이동 : TriggerState {
            internal State유저이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990010, key: "PCmove", value: 1);
            }

            public override void Execute() {
                if (context.GetDungeonVariable(id: 2) == true) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.GetDungeonVariable(id: 1000) == true) {
                    context.State = new State포탈열림(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State포탈닫힘 : TriggerState {
            internal State포탈닫힘(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990010, key: "PCmove", value: 0);
                context.SetTimer(arg1: "2", arg2: 60, arg3: true);
                context.SetInteractObject(arg1: new[] {10002184}, arg2: 2, arg3: false);
            }

            public override void Execute() {
                if (context.GetDungeonVariable(id: 2) == true) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.TimeExpired(arg1: "2")) {
                    context.ResetTimer(arg1: "2");
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10002184}, arg2: 2, arg3: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}