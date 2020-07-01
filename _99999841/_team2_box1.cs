namespace Maple2.Trigger._99999841 {
    public static class _team2_box1 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetDungeonVariable(varId: 911, value: false);
                context.SetInteractObject(arg1: new[] {10002179}, arg2: 0, arg3: false);
            }

            public override void Execute() {
                if (context.GetDungeonVariable(id: 901) == true) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.GetDungeonVariable(id: 902) == true) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.GetDungeonVariable(id: 903) == true) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.GetUserValue(key: "Start") == 1) {
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10002179}, arg2: 1, arg3: false);
                context.SetInteractObject(arg1: new[] {10002180}, arg2: 1, arg3: false);
                context.SetInteractObject(arg1: new[] {10002181}, arg2: 1, arg3: false);
                context.SetInteractObject(arg1: new[] {10002182}, arg2: 1, arg3: false);
            }

            public override void Execute() {
                if (context.GetDungeonVariable(id: 901) == true) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.GetDungeonVariable(id: 902) == true) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.GetDungeonVariable(id: 903) == true) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10002179}, arg2: 0)) {
                    context.State = new State애디셔널_중첩1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State애디셔널_중첩1 : TriggerState {
            internal State애디셔널_중첩1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetDungeonVariable(varId: 911, value: true);
                context.AddBuff(arg1: new[] {9001}, arg2: 70002531, arg3: 1, arg5: false);
            }

            public override void Execute() {
                if (context.GetDungeonVariable(id: 901) == true) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.GetDungeonVariable(id: 902) == true) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.GetDungeonVariable(id: 903) == true) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State애디셔널_중첩2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State애디셔널_중첩2 : TriggerState {
            internal State애디셔널_중첩2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {9001}, arg2: 70002531, arg3: 1, arg5: false);
            }

            public override void Execute() {
                if (context.GetDungeonVariable(id: 901) == true) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.GetDungeonVariable(id: 902) == true) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.GetDungeonVariable(id: 903) == true) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State애디셔널_중첩3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State애디셔널_중첩3 : TriggerState {
            internal State애디셔널_중첩3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {9001}, arg2: 70002531, arg3: 1, arg5: false);
            }

            public override void Execute() {
                if (context.GetDungeonVariable(id: 901) == true) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.GetDungeonVariable(id: 902) == true) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.GetDungeonVariable(id: 903) == true) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10002179}, arg2: 0, arg3: false);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "BadMob") == 1) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}