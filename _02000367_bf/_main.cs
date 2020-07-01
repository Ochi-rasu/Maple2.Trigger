using System;

namespace Maple2.Trigger._02000367_bf {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3000}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3101, 3102, 3103, 3104, 3105, 3106}, arg2: true, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetMesh(arg1: new int[] {3113, 3114}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetPortal(arg1: 11, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 22, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 33, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 44, arg2: false, arg3: false, arg4: false);
                context.SetInteractObject(arg1: new int[] {10000983}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {10000984}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {10000985}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {10000986}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {10000987}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {10000988}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {10000995}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {10000996}, arg2: 2);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {1001})) {
                    context.State = new State전투01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투01 : TriggerState {
            internal State전투01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(
                    arg1: new int[]
                        {11101, 11102, 11103, 11104, 11105, 11106, 11107, 11201, 11202, 11203, 11204, 11205},
                    arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[]
                    {11101, 11102, 11103, 11104, 11105, 11106, 11107, 11201, 11202, 11203, 11204, 11205})) {
                    context.State = new State전투02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투02 : TriggerState {
            internal State전투02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3101, 3102}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new int[] {10000983}, arg2: 1);
                context.SetInteractObject(arg1: new int[] {10000984}, arg2: 1);
                context.CreateMonster(arg1: new int[] {12101, 12102, 12201, 12202, 12203, 12204, 12205, 12206, 12207},
                    arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[]
                    {12101, 12102, 12201, 12202, 12203, 12204, 12205, 12206, 12207})) {
                    context.State = new State전투03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투03 : TriggerState {
            internal State전투03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3103, 3104}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new int[] {10000985}, arg2: 1);
                context.SetInteractObject(arg1: new int[] {10000986}, arg2: 1);
                context.CreateMonster(
                    arg1: new int[]
                        {13101, 13102, 13103, 13104, 13105, 13106, 13107, 13108, 13109, 13201, 13202, 13203, 13204},
                    arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[]
                    {13101, 13102, 13103, 13104, 13105, 13106, 13107, 13108, 13109, 13201, 13202, 13203, 13204})) {
                    context.SetMesh(arg1: new int[] {3105, 3106}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.SetInteractObject(arg1: new int[] {10000987}, arg2: 1);
                    context.SetInteractObject(arg1: new int[] {10000988}, arg2: 1);
                    context.State = new State합류대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State합류대기 : TriggerState {
            internal State합류대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "main", value: 1)) {
                    context.State = new State전투04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투04 : TriggerState {
            internal State전투04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {30001, 30002, 30003, 30004}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {30001, 30002, 30003, 30004})) {
                    context.State = new State포털개방(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State포털개방 : TriggerState {
            internal State포털개방(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 11, arg2: true, arg3: true, arg4: false);
                context.SetPortal(arg1: 22, arg2: true, arg3: true, arg4: false);
                context.SetPortal(arg1: 33, arg2: true, arg3: true, arg4: false);
                context.SetPortal(arg1: 44, arg2: true, arg3: true, arg4: false);
                context.CreateMonster(
                    arg1: new int[] {41101, 41102, 41103, 41104, 41105, 41106, 41201, 41202, 41203, 41204},
                    arg2: false);
                context.SetUserValue(triggerID: 9999900, key: "main2", value: 1);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[]
                    {41101, 41102, 41103, 41104, 41105, 41106, 41201, 41202, 41203, 41204})) {
                    context.SetMesh(arg1: new int[] {3113, 3114}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.SetInteractObject(arg1: new int[] {10000995}, arg2: 1);
                    context.SetInteractObject(arg1: new int[] {10000996}, arg2: 1);
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}