namespace Maple2.Trigger._02020120_bf {
    public static class _dungeonmissioncheckskillbreakclear {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "SkillBreakSuccess") == 1) {
                    context.State = new State스킬브레이크성공_던전미션랭크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬브레이크성공_던전미션랭크 : TriggerState {
            internal State스킬브레이크성공_던전미션랭크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonMissionComplete(missionId: 23037005);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
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