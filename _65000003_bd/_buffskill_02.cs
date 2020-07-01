using System;

namespace Maple2.Trigger._65000003_bd {
    public static class _buffskill_02 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작대기중(context);

        private class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 202, arg2: true, arg3: "Idle_A");
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {10602})) {
                    context.State = new State스킬랜덤(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬랜덤 : TriggerState {
            internal State스킬랜덤(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 202, arg2: true, arg3: "Dead_A");
            }

            public override void Execute() {
                if (!context.UserDetected(arg1: new int[] {10602})) {
                    context.State = new State초기화(context);
                    return;
                }

                if (context.RandomCondition(arg1: 33f)) {
                    context.State = new StateA스킬작동(context);
                    return;
                }

                if (context.RandomCondition(arg1: 33f)) {
                    context.State = new StateB스킬작동(context);
                    return;
                }

                if (context.RandomCondition(arg1: 34f)) {
                    context.State = new StateC스킬작동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateA스킬작동 : TriggerState {
            internal StateA스킬작동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {7201}, arg2: true);
                context.SetTimer(arg1: "60", arg2: 60);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "60")) {
                    context.SetSkill(arg1: new int[] {7201}, arg2: false);
                    context.State = new State시작대기중(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateB스킬작동 : TriggerState {
            internal StateB스킬작동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {7202}, arg2: true);
                context.SetTimer(arg1: "60", arg2: 60);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "60")) {
                    context.SetSkill(arg1: new int[] {7202}, arg2: false);
                    context.State = new State시작대기중(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateC스킬작동 : TriggerState {
            internal StateC스킬작동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {7203}, arg2: true);
                context.SetTimer(arg1: "60", arg2: 60);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "60")) {
                    context.SetSkill(arg1: new int[] {7203}, arg2: false);
                    context.State = new State시작대기중(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State초기화 : TriggerState {
            internal State초기화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new int[] {7201}, arg2: false);
                context.SetSkill(arg1: new int[] {7202}, arg2: false);
                context.SetSkill(arg1: new int[] {7203}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State시작대기중(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}