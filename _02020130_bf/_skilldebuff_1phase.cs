namespace Maple2.Trigger._02020130_bf {
    public static class _skilldebuff_1phase {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "SkillDebuffCheck_1Phase", value: 0);
                context.SetUserValue(key: "MonsterMany", value: 0);
                context.SetUserValue(key: "FirstBattleEnd", value: 0);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 601) == 1) {
                    context.State = new State보스의저주디버프사용신호대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스의저주디버프사용신호대기 : TriggerState {
            internal State보스의저주디버프사용신호대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "SkillDebuffCheck_1Phase") == 1) {
                    context.State = new State소환몹활성화될때까지잠시기다리기(context);
                    return;
                }

                if (context.GetUserValue(key: "FirstBattleEnd") == 1) {
                    context.State = new State폭발저주디버프제거잠시대기(context);
                    return;
                }

                if (context.GetUserValue(key: "FirstBattleEnd") == 99) {
                    context.State = new State폭발저주디버프제거하고종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State소환몹활성화될때까지잠시기다리기 : TriggerState {
            internal State소환몹활성화될때까지잠시기다리기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5200)) {
                    context.State = new State소환몹전멸할때까지대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State소환몹전멸할때까지대기 : TriggerState {
            internal State소환몹전멸할때까지대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "MonsterMany") == 0) {
                    context.State = new State폭발저주디버프제거잠시대기(context);
                    return;
                }

                if (context.GetUserValue(key: "FirstBattleEnd") == 1) {
                    context.State = new State폭발저주디버프제거잠시대기(context);
                    return;
                }

                if (context.GetUserValue(key: "FirstBattleEnd") == 99) {
                    context.State = new State폭발저주디버프제거하고종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State폭발저주디버프제거잠시대기 : TriggerState {
            internal State폭발저주디버프제거잠시대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "SkillDebuffCheck_1Phase", value: 0);
                context.SetUserValue(key: "FirstBattleEnd", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1200)) {
                    context.State = new State폭발저주디버프제거(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State폭발저주디버프제거 : TriggerState {
            internal State폭발저주디버프제거(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {601}, arg2: 50001413, arg3: 1, arg4: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1800)) {
                    context.State = new State보스의저주디버프사용신호대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State폭발저주디버프제거하고종료 : TriggerState {
            internal State폭발저주디버프제거하고종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {601}, arg2: 50001413, arg3: 1, arg4: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1200)) {
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