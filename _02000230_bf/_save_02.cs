namespace Maple2.Trigger._02000230_bf {
    public static class _save_02 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {200}, arg2: false);
                context.SetActor(arg1: 201, arg2: true, arg3: "Emotion_Failure_Idle_A");
                context.SetActor(arg1: 20201, arg2: true, arg3: "Attack_Idle_A");
                context.SetActor(arg1: 20202, arg2: true, arg3: "Attack_02_A");
                context.SetActor(arg1: 20203, arg2: true, arg3: "Attack_02_A");
                context.SetActor(arg1: 20204, arg2: true, arg3: "Attack_Idle_A");
                context.SetActor(arg1: 20205, arg2: true, arg3: "Attack_02_A");
            }

            public override void Execute() {
                if (true) {
                    context.State = new State주민구출(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State주민구출 : TriggerState {
            internal State주민구출(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000279}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000279}, arg2: 0)) {
                    context.State = new State문열림(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State문열림 : TriggerState {
            internal State문열림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "10", arg2: 3);
                context.SetConversation(arg1: 1, arg2: 200, arg3: "$02000230_BF__SAVE_02__0$", arg4: 2, arg5: 0);
                context.SetActor(arg1: 20201, arg2: false, arg3: "Attack_Idle_A");
                context.CreateMonster(arg1: new[] {20211}, arg2: true);
                context.SetActor(arg1: 20202, arg2: false, arg3: "Attack_02_A");
                context.CreateMonster(arg1: new[] {20212}, arg2: true);
                context.SetActor(arg1: 20203, arg2: false, arg3: "Attack_02_A");
                context.CreateMonster(arg1: new[] {20213}, arg2: true);
                context.SetActor(arg1: 20204, arg2: false, arg3: "Attack_Idle_A");
                context.CreateMonster(arg1: new[] {20214}, arg2: true);
                context.SetActor(arg1: 20205, arg2: false, arg3: "Attack_02_A");
                context.CreateMonster(arg1: new[] {20215}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 20211, arg3: "$02000230_BF__SAVE_02__1$", arg4: 2, arg5: 1);
                context.SetConversation(arg1: 1, arg2: 20213, arg3: "$02000230_BF__SAVE_02__2$", arg4: 2, arg5: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "10")) {
                    context.State = new State도망과공격(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State도망과공격 : TriggerState {
            internal State도망과공격(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {200});
                context.SetActor(arg1: 201, arg2: false, arg3: "Emotion_Failure_Idle_A");
                context.CreateMonster(arg1: new[] {211}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 211, arg3: "$02000230_BF__SAVE_02__3$", arg4: 2, arg5: 0);
                context.MoveNpc(arg1: 211, arg2: "MS2PatrolData_211_11000688");
                context.SetConversation(arg1: 1, arg2: 211, arg3: "$02000230_BF__SAVE_02__4$", arg4: 2, arg5: 2);
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 90211, arg2: new[] {211})) {
                    context.State = new State도망완료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State도망완료 : TriggerState {
            internal State도망완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {211});
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {20211, 20212, 20213, 20214, 20215})) {
                    context.State = new State트리거초기화(context);
                    return;
                }

                if (!context.MonsterInCombat(arg1: new[] {20211, 20212, 20213, 20214, 20215})) {
                    context.State = new State트리거초기화(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트리거초기화 : TriggerState {
            internal State트리거초기화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "11", arg2: 10);
                context.DestroyMonster(arg1: new[] {20211, 20212, 20213, 20214, 20215});
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "11")) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}