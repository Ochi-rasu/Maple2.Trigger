namespace Maple2.Trigger._02000148_bf {
    public static class _01_trigger02 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000170}, arg2: 1);
                context.SetEffect(arg1: new[] {205, 206, 207, 208}, arg2: false);
                context.SetMesh(arg1: new[] {309, 310, 311, 312}, arg2: true);
                context.SetMesh(arg1: new[] {313, 314, 315, 316}, arg2: false);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000170}, arg2: 0)) {
                    context.State = new State개봉박두(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State개봉박두 : TriggerState {
            internal State개봉박두(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {309, 310, 311, 312}, arg2: false);
                context.CreateMonster(arg1: new[] {95, 96, 97, 98}, arg2: true);
                context.SetMesh(arg1: new[] {313, 314, 315, 316}, arg2: true);
                context.SetEffect(arg1: new[] {205, 206, 207, 208}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {95, 96, 97, 98})) {
                    context.State = new State유저감지(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State유저감지 : TriggerState {
            internal State유저감지(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 2);
            }

            public override void Execute() {
                if (!context.UserDetected(arg1: new[] {402})) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}