namespace Maple2.Trigger._52000071_qd {
    public static class _02_falsedoor {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3001}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10001104}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001104}, arg2: 0)) {
                    context.State = new StateMobSpawn(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMobSpawn : TriggerState {
            internal StateMobSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {902}, arg2: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}