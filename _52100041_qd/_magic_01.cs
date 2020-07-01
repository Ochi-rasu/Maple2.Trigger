namespace Maple2.Trigger._52100041_qd {
    public static class _magic_01 {
        public class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10002072}, arg2: 0)) {
                    context.State = new StateReady(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7001}, arg2: false);
                context.SetMesh(arg1: new[] {1101}, arg2: false, arg3: 0, arg4: 200, arg5: 15f);
                context.SetMesh(arg1: new[] {1201}, arg2: true, arg3: 0, arg4: 200, arg5: 15f);
                context.CreateMonster(arg1: new[] {201}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {201})) {
                    context.State = new StateEvent_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_01 : TriggerState {
            internal StateEvent_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {161, 162, 163}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateEvent_01_b(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_01_b : TriggerState {
            internal StateEvent_01_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 161, arg2: "Bore_A");
                context.SetNpcEmotionSequence(arg1: 162, arg2: "Bore_A");
                context.SetNpcEmotionSequence(arg1: 163, arg2: "Bore_A");
                context.SetConversation(arg1: 1, arg2: 161, arg3: "$52100041_QD__MAGIC_01__0$", arg4: 3, arg5: 2);
                context.SetConversation(arg1: 1, arg2: 162, arg3: "$52100041_QD__MAGIC_01__1$", arg4: 3, arg5: 4);
                context.SetConversation(arg1: 1, arg2: 163, arg3: "$52100041_QD__MAGIC_01__2$", arg4: 3, arg5: 6);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    context.State = new StateEvent_01_c(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_01_c : TriggerState {
            internal StateEvent_01_c(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {161, 162, 163});
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}