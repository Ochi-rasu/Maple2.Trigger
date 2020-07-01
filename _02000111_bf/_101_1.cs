using System;

namespace Maple2.Trigger._02000111_bf {
    public static class _101_1 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작대기중1(context);

        private class State시작대기중1 : TriggerState {
            internal State시작대기중1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000164}, arg2: 1);
                context.SetMesh(arg1: new int[] {301}, arg2: false);
                context.SetEffect(arg1: new int[] {401}, arg2: false);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000164}, arg2: 0)) {
                    context.State = new State열기1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작대기중2 : TriggerState {
            internal State시작대기중2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000164}, arg2: 1);
                context.SetMesh(arg1: new int[] {301}, arg2: false);
                context.SetEffect(arg1: new int[] {401}, arg2: false);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000164}, arg2: 0)) {
                    context.State = new State열기1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State열기1 : TriggerState {
            internal State열기1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {301}, arg2: true);
                context.SetEffect(arg1: new int[] {401}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 30);
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 201, arg2: new int[] {103})) {
                    context.State = new State아이템1(context);
                    return;
                }

                if (context.NpcDetected(arg1: 201, arg2: new int[] {104})) {
                    context.State = new State아이템2(context);
                    return;
                }

                if (context.NpcDetected(arg1: 201, arg2: new int[] {105})) {
                    context.State = new State아이템3(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State시작대기중2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아이템1 : TriggerState {
            internal State아이템1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateItem(arg1: new int[] {501}, arg2: 0, arg3: 10000164);
                context.SetMesh(arg1: new int[] {301}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10000164}, arg2: 1);
                context.SetEffect(arg1: new int[] {401}, arg2: true);
                context.DestroyMonster(arg1: new int[] {103});
            }

            public override void Execute() {
                if (true) {
                    context.State = new State빠지기1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아이템2 : TriggerState {
            internal State아이템2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateItem(arg1: new int[] {501}, arg2: 0, arg3: 10000164);
                context.SetMesh(arg1: new int[] {301}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10000164}, arg2: 1);
                context.SetEffect(arg1: new int[] {401}, arg2: true);
                context.DestroyMonster(arg1: new int[] {104});
            }

            public override void Execute() {
                if (true) {
                    context.State = new State빠지기2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아이템3 : TriggerState {
            internal State아이템3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateItem(arg1: new int[] {501}, arg2: 0, arg3: 10000164);
                context.SetMesh(arg1: new int[] {301}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10000164}, arg2: 1);
                context.SetEffect(arg1: new int[] {401}, arg2: true);
                context.DestroyMonster(arg1: new int[] {105});
            }

            public override void Execute() {
                if (true) {
                    context.State = new State빠지기3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State빠지기1 : TriggerState {
            internal State빠지기1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (true) {
                    context.State = new State시작대기중2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State빠지기2 : TriggerState {
            internal State빠지기2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (true) {
                    context.State = new State시작대기중2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State빠지기3 : TriggerState {
            internal State빠지기3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (true) {
                    context.State = new State시작대기중2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}