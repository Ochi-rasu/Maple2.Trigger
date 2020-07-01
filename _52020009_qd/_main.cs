namespace Maple2.Trigger._52020009_qd {
    public static class _main {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {8001}, arg2: false);
                context.SetInteractObject(arg1: new[] {10001266}, arg2: 0);
                context.SetEffect(arg1: new[] {5001}, arg2: false);
                context.SetEffect(arg1: new[] {5002}, arg2: false);
                context.SetEffect(arg1: new[] {5003}, arg2: false);
                context.SetEffect(arg1: new[] {5004}, arg2: false);
                context.SetEffect(arg1: new[] {5005}, arg2: false);
                context.SetEffect(arg1: new[] {5006}, arg2: false);
                context.SetEffect(arg1: new[] {5100}, arg2: true);
                context.SetEffect(arg1: new[] {5101}, arg2: true);
                context.SetEffect(arg1: new[] {5102}, arg2: true);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {60200020},
                    arg3: new byte[] {1})) {
                    context.State = new StateReady(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {60200020},
                    arg3: new byte[] {2})) {
                    context.State = new StateMeshOff(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {60200020},
                    arg3: new byte[] {3})) {
                    context.State = new StateMeshOff(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {201}, arg2: true);
                context.CreateMonster(arg1: new[] {202}, arg2: true);
                context.CreateMonster(arg1: new[] {203}, arg2: true);
                context.CreateMonster(arg1: new[] {204}, arg2: true);
                context.CreateMonster(arg1: new[] {205}, arg2: true);
                context.CreateMonster(arg1: new[] {206}, arg2: true);
                context.CreateMonster(arg1: new[] {207}, arg2: true);
                context.SetEffect(arg1: new[] {5001}, arg2: true);
                context.SetEffect(arg1: new[] {5002}, arg2: true);
                context.SetEffect(arg1: new[] {5003}, arg2: true);
                context.SetEffect(arg1: new[] {5004}, arg2: true);
                context.SetEffect(arg1: new[] {5005}, arg2: true);
                context.SetEffect(arg1: new[] {5006}, arg2: true);
                context.SetMesh(arg1: new[] {8001}, arg2: true);
                context.AddBalloonTalk(spawnPointId: 0, msg: "!", duration: 3000, delayTick: 0);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {201, 202, 203, 204, 205, 206, 207})) {
                    context.State = new StateEvent_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_01 : TriggerState {
            internal StateEvent_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001266}, arg2: 1);
                context.SetMesh(arg1: new[] {8001}, arg2: true);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000449}, arg2: 0)) {
                    context.State = new StateMeshOff(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMeshOff : TriggerState {
            internal StateMeshOff(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {8001}, arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {60200020},
                    arg3: new byte[] {1})) {
                    context.State = new StateEvent_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}