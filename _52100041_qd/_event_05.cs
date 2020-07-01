namespace Maple2.Trigger._52100041_qd {
    public static class _event_05 {
        public class Statenone : TriggerState {
            internal Statenone(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {706})) {
                    context.State = new Stateidle(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {121, 154, 122, 156, 110})) {
                    context.State = new Stateready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateready : TriggerState {
            internal Stateready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1110, 1111, 1112, 1113}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statestart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart : TriggerState {
            internal Statestart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 1110, arg3: "$52100041_QD__EVENT_05__0$", arg4: 3, arg5: 4);
                context.SetConversation(arg1: 1, arg2: 1111, arg3: "$52100041_QD__EVENT_05__1$", arg4: 3, arg5: 5);
                context.SetConversation(arg1: 1, arg2: 1112, arg3: "$52100041_QD__EVENT_05__2$", arg4: 3, arg5: 1);
                context.SetConversation(arg1: 1, arg2: 1113, arg3: "$52100041_QD__EVENT_05__3$", arg4: 3, arg5: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    context.State = new Stateexit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateexit : TriggerState {
            internal Stateexit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {1110, 1111, 1112, 1113});
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}