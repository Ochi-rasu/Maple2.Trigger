using System;

namespace Maple2.Trigger._61000009_me {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateReady(context);

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 4002, arg2: false, arg3: "Closed_A");
                context.SetEventUI(arg1: 0, arg2: "0,3");
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
                context.SetMesh(arg1: new int[] {6001}, arg2: false);
                context.SetMesh(arg1: new int[] {6002}, arg2: true);
                context.SetEffect(arg1: new int[] {7999}, arg2: false);
                context.SetEffect(arg1: new int[] {7001}, arg2: false);
                context.SetEffect(arg1: new int[] {7002}, arg2: false);
                context.SetEffect(arg1: new int[] {7003}, arg2: false);
                context.SetEffect(arg1: new int[] {7999}, arg2: false);
                context.SetEffect(arg1: new int[] {7998}, arg2: false);
                context.SetEffect(arg1: new int[] {7801}, arg2: false);
                context.SetEffect(arg1: new int[] {7802}, arg2: false);
                context.SetEffect(arg1: new int[] {7803}, arg2: false);
                context.CreateMonster(arg1: new int[] {101}, arg2: false);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 700, arg2: 1)) {
                    context.State = new StateReady_Idle(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReady_Idle : TriggerState {
            internal StateReady_Idle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1, arg4: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateReady_Idle_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReady_Idle_02 : TriggerState {
            internal StateReady_Idle_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_Space_PopUp_01");
                context.SetTimer(arg1: "30", arg2: 30, arg4: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "30")) {
                    context.State = new Statestart_02(context);
                    return;
                }

                if (context.CountUsers(arg1: 700, arg2: 10)) {
                    context.State = new Statestart_02(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 100);
            }
        }

        private class Statestart_01 : TriggerState {
            internal Statestart_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.PlaySystemSoundInBox(arg2: "System_Dark_Intro_Chord_01");
                context.SetProductionUI(arg1: 3, arg2: "$02000374_BF__MAIN__25$");
                context.SetTimer(arg1: "5", arg2: 5, arg4: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.State = new Statestart_02(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetProductionUI(arg1: 7);
            }
        }

        private class Statestart_02 : TriggerState {
            internal Statestart_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 700, arg2: "trigger", arg3: "dailyquest_start");
                context.SetUserValue(triggerID: 2037406, key: "timer", value: 1);
                context.SetEventUI(arg1: 0, arg2: "1,3");
                context.SetEffect(arg1: new int[] {7998}, arg2: true);
                context.SetMesh(arg1: new int[] {6002}, arg2: false);
                context.SetActor(arg1: 4001, arg2: true, arg3: "Opened_A");
                context.SetPortal(arg1: 1, arg2: false, arg3: true, arg4: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {101})) {
                    context.State = new State2Round(context);
                    return;
                }

                if (context.UserDetected(arg1: new int[] {701})) {
                    context.State = new State1Round_Talk(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1Round_Talk : TriggerState {
            internal State1Round_Talk(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000374_BF__MAIN__0$", arg3: new int[] {5000});
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {101})) {
                    context.State = new State2Round(context);
                    return;
                }

                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State1Round_Talk_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1Round_Talk_01 : TriggerState {
            internal State1Round_Talk_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {110}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {101})) {
                    context.State = new State2Round(context);
                    return;
                }

                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State1Round_Talk_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1Round_Talk_02 : TriggerState {
            internal State1Round_Talk_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000374_BF__MAIN__1$", arg3: new int[] {3000});
                context.SetConversation(arg1: 1, arg2: 110, arg3: "$02000374_BF__MAIN__1$", arg4: 3, arg5: 0);
                context.MoveNpc(arg1: 110, arg2: "MS2PatrolData_2001");
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {101})) {
                    context.State = new State2Round(context);
                    return;
                }

                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State1Round_Talk_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1Round_Talk_03 : TriggerState {
            internal State1Round_Talk_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000374_BF__MAIN__2$", arg3: new int[] {3000});
                context.SetConversation(arg1: 1, arg2: 110, arg3: "$02000374_BF__MAIN__2$", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State1Round_Talk_04(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {101})) {
                    context.State = new State2Round(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1Round_Talk_04 : TriggerState {
            internal State1Round_Talk_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {101})) {
                    context.State = new State2Round(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2Round : TriggerState {
            internal State2Round(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000374_BF__MAIN__3$", arg3: new int[] {3000});
                context.SetConversation(arg1: 1, arg2: 110, arg3: "$02000374_BF__MAIN__3$", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State2Round_Talk_00(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2Round_Talk_00 : TriggerState {
            internal State2Round_Talk_00(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000374_BF__MAIN__26$", arg3: new int[] {3000});
                context.SetConversation(arg1: 1, arg2: 110, arg3: "$02000374_BF__MAIN__27$", arg4: 3, arg5: 0);
                context.MoveNpc(arg1: 110, arg2: "MS2PatrolData_2002");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State2Round_Talk_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2Round_Talk_01 : TriggerState {
            internal State2Round_Talk_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 0, arg2: "2,3");
                context.CameraSelect(arg1: 8001, arg2: true);
                context.SetEffect(arg1: new int[] {7801}, arg2: true);
                context.SetEffect(arg1: new int[] {7802}, arg2: true);
                context.SetEventUI(arg1: 1, arg2: "$02000374_BF__MAIN__28$", arg3: new int[] {3000});
                context.SetConversation(arg1: 1, arg2: 110, arg3: "$02000374_BF__MAIN__29$", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.SetSkill(arg1: new int[] {5001}, arg2: true);
                    context.SetSkill(arg1: new int[] {5002}, arg2: true);
                    context.SetSkill(arg1: new int[] {5003}, arg2: true);
                    context.SetSkill(arg1: new int[] {5004}, arg2: true);
                    context.SetSkill(arg1: new int[] {5005}, arg2: true);
                    context.SetSkill(arg1: new int[] {5006}, arg2: true);
                    context.SetSkill(arg1: new int[] {5007}, arg2: true);
                    context.SetSkill(arg1: new int[] {5008}, arg2: true);
                    context.SetSkill(arg1: new int[] {5009}, arg2: true);
                    context.SetSkill(arg1: new int[] {5010}, arg2: true);
                    context.SetSkill(arg1: new int[] {5011}, arg2: true);
                    context.SetSkill(arg1: new int[] {5012}, arg2: true);
                    context.SetSkill(arg1: new int[] {5013}, arg2: true);
                    context.State = new State2Round_Talk_02(context);
                    return;
                }
            }

            public override void OnExit() {
                context.CameraSelect(arg1: 8001, arg2: false);
                context.SetEffect(arg1: new int[] {7001}, arg2: true);
                context.SetEffect(arg1: new int[] {7002}, arg2: true);
                context.SetEffect(arg1: new int[] {7003}, arg2: true);
            }
        }

        private class State2Round_Talk_02 : TriggerState {
            internal State2Round_Talk_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 110, arg2: "MS2PatrolData_2003");
                context.SetEventUI(arg1: 1, arg2: "$02000374_BF__MAIN__5$", arg3: new int[] {3000});
                context.SetConversation(arg1: 1, arg2: 110, arg3: "$02000374_BF__MAIN__5$", arg4: 3, arg5: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State2Round_Talk_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2Round_Talk_03 : TriggerState {
            internal State2Round_Talk_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000374_BF__MAIN__6$", arg3: new int[] {3000});
                context.SetConversation(arg1: 1, arg2: 110, arg3: "$02000374_BF__MAIN__6$", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State2Round_Spawn_Random(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2Round_Spawn_Random : TriggerState {
            internal State2Round_Spawn_Random(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 33f)) {
                    context.State = new State2Round_Spawn_A(context);
                    return;
                }

                if (context.RandomCondition(arg1: 33f)) {
                    context.State = new State2Round_Spawn_B(context);
                    return;
                }

                if (context.RandomCondition(arg1: 33f)) {
                    context.State = new State2Round_Spawn_C(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2Round_Spawn_A : TriggerState {
            internal State2Round_Spawn_A(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000374_BF__MAIN__7$", arg3: new int[] {3000});
                context.SetConversation(arg1: 1, arg2: 110, arg3: "$02000374_BF__MAIN__7$", arg4: 3, arg5: 0);
                context.SetUserValue(triggerID: 2037402, key: "2Round_A", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 85000)) {
                    context.State = new State2Round_Spawn_A_02_Ready(context);
                    return;
                }

                if (context.UserValue(key: "2Round_A", value: 1)) {
                    context.State = new State2Round_Spawn_A_02_Ready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2Round_Spawn_B : TriggerState {
            internal State2Round_Spawn_B(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 110, arg2: "MS2PatrolData_2004");
                context.SetEventUI(arg1: 1, arg2: "$02000374_BF__MAIN__8$", arg3: new int[] {3000});
                context.SetConversation(arg1: 1, arg2: 110, arg3: "$02000374_BF__MAIN__8$", arg4: 3, arg5: 0);
                context.SetUserValue(triggerID: 2037403, key: "2Round_B", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 85000)) {
                    context.State = new State2Round_Spawn_B_02_Ready(context);
                    return;
                }

                if (context.UserValue(key: "2Round_B", value: 1)) {
                    context.State = new State2Round_Spawn_B_02_Ready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2Round_Spawn_C : TriggerState {
            internal State2Round_Spawn_C(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 110, arg2: "MS2PatrolData_2005");
                context.SetEventUI(arg1: 1, arg2: "$02000374_BF__MAIN__9$", arg3: new int[] {3000});
                context.SetConversation(arg1: 1, arg2: 110, arg3: "$02000374_BF__MAIN__9$", arg4: 3, arg5: 0);
                context.SetUserValue(triggerID: 2037404, key: "2Round_C", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 85000)) {
                    context.State = new State2Round_Spawn_C_02_Ready(context);
                    return;
                }

                if (context.UserValue(key: "2Round_C", value: 1)) {
                    context.State = new State2Round_Spawn_C_02_Ready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2Round_Spawn_A_02_Ready : TriggerState {
            internal State2Round_Spawn_A_02_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000374_BF__MAIN__10$", arg3: new int[] {3000});
                context.SetConversation(arg1: 1, arg2: 110, arg3: "$02000374_BF__MAIN__10$", arg4: 3, arg5: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State2Round_Spawn_A_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2Round_Spawn_B_02_Ready : TriggerState {
            internal State2Round_Spawn_B_02_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000374_BF__MAIN__13$", arg3: new int[] {3000});
                context.SetConversation(arg1: 1, arg2: 110, arg3: "$02000374_BF__MAIN__13$", arg4: 3, arg5: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State2Round_Spawn_B_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2Round_Spawn_C_02_Ready : TriggerState {
            internal State2Round_Spawn_C_02_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000374_BF__MAIN__16$", arg3: new int[] {3000});
                context.SetConversation(arg1: 1, arg2: 110, arg3: "$02000374_BF__MAIN__16$", arg4: 3, arg5: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State2Round_Spawn_C_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2Round_Spawn_A_02 : TriggerState {
            internal State2Round_Spawn_A_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 50f)) {
                    context.State = new State2Round_Spawn_A_B_02(context);
                    return;
                }

                if (context.RandomCondition(arg1: 50f)) {
                    context.State = new State2Round_Spawn_A_C_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2Round_Spawn_A_B_02 : TriggerState {
            internal State2Round_Spawn_A_B_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 2037403, key: "2Round_B", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 135000)) {
                    context.State = new State2Round_Spawn_A_B_C(context);
                    return;
                }

                if (context.UserValue(key: "2Round_B", value: 1)) {
                    context.State = new State2Round_Spawn_A_B_C(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2Round_Spawn_A_C_02 : TriggerState {
            internal State2Round_Spawn_A_C_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 2037404, key: "2Round_C", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 135000)) {
                    context.State = new State2Round_Spawn_A_C_B(context);
                    return;
                }

                if (context.UserValue(key: "2Round_C", value: 1)) {
                    context.State = new State2Round_Spawn_A_C_B(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2Round_Spawn_A_B_C : TriggerState {
            internal State2Round_Spawn_A_B_C(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000374_BF__MAIN__11$", arg3: new int[] {3000});
                context.SetConversation(arg1: 1, arg2: 110, arg3: "$02000374_BF__MAIN__11$", arg4: 3, arg5: 1);
                context.SetUserValue(triggerID: 2037404, key: "2Round_C", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    context.State = new State2Round_End_Condition(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2Round_Spawn_A_C_B : TriggerState {
            internal State2Round_Spawn_A_C_B(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000374_BF__MAIN__12$", arg3: new int[] {3000});
                context.SetConversation(arg1: 1, arg2: 110, arg3: "$02000374_BF__MAIN__12$", arg4: 3, arg5: 1);
                context.SetUserValue(triggerID: 2037403, key: "2Round_B", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    context.State = new State2Round_End_Condition(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2Round_Spawn_B_02 : TriggerState {
            internal State2Round_Spawn_B_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 50f)) {
                    context.State = new State2Round_Spawn_B_A_02(context);
                    return;
                }

                if (context.RandomCondition(arg1: 50f)) {
                    context.State = new State2Round_Spawn_B_C_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2Round_Spawn_B_A_02 : TriggerState {
            internal State2Round_Spawn_B_A_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 2037402, key: "2Round_A", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 135000)) {
                    context.State = new State2Round_Spawn_B_A_C(context);
                    return;
                }

                if (context.UserValue(key: "2Round_A", value: 1)) {
                    context.State = new State2Round_Spawn_B_A_C(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2Round_Spawn_B_C_02 : TriggerState {
            internal State2Round_Spawn_B_C_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 2037404, key: "2Round_C", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 135000)) {
                    context.State = new State2Round_Spawn_B_C_A(context);
                    return;
                }

                if (context.UserValue(key: "2Round_C", value: 1)) {
                    context.State = new State2Round_Spawn_B_C_A(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2Round_Spawn_B_A_C : TriggerState {
            internal State2Round_Spawn_B_A_C(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000374_BF__MAIN__14$", arg3: new int[] {3000});
                context.SetConversation(arg1: 1, arg2: 110, arg3: "$02000374_BF__MAIN__14$", arg4: 3, arg5: 1);
                context.SetUserValue(triggerID: 2037404, key: "2Round_C", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    context.State = new State2Round_End_Condition(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2Round_Spawn_B_C_A : TriggerState {
            internal State2Round_Spawn_B_C_A(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000374_BF__MAIN__15$", arg3: new int[] {3000});
                context.SetConversation(arg1: 1, arg2: 110, arg3: "$02000374_BF__MAIN__15$", arg4: 3, arg5: 1);
                context.SetUserValue(triggerID: 2037402, key: "2Round_A", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    context.State = new State2Round_End_Condition(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2Round_Spawn_C_02 : TriggerState {
            internal State2Round_Spawn_C_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 50f)) {
                    context.State = new State2Round_Spawn_C_A_02(context);
                    return;
                }

                if (context.RandomCondition(arg1: 50f)) {
                    context.State = new State2Round_Spawn_C_B_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2Round_Spawn_C_A_02 : TriggerState {
            internal State2Round_Spawn_C_A_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 2037402, key: "2Round_A", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 135000)) {
                    context.State = new State2Round_Spawn_C_A_B(context);
                    return;
                }

                if (context.UserValue(key: "2Round_A", value: 1)) {
                    context.State = new State2Round_Spawn_C_A_B(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2Round_Spawn_C_B_02 : TriggerState {
            internal State2Round_Spawn_C_B_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 2037403, key: "2Round_B", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 135000)) {
                    context.State = new State2Round_Spawn_C_B_A(context);
                    return;
                }

                if (context.UserValue(key: "2Round_B", value: 1)) {
                    context.State = new State2Round_Spawn_C_B_A(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2Round_Spawn_C_A_B : TriggerState {
            internal State2Round_Spawn_C_A_B(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000374_BF__MAIN__18$", arg3: new int[] {3000});
                context.SetConversation(arg1: 1, arg2: 110, arg3: "$02000374_BF__MAIN__18$", arg4: 3, arg5: 1);
                context.SetUserValue(triggerID: 2037403, key: "2Round_B", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    context.State = new State2Round_End_Condition(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2Round_Spawn_C_B_A : TriggerState {
            internal State2Round_Spawn_C_B_A(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000374_BF__MAIN__17$", arg3: new int[] {3000});
                context.SetConversation(arg1: 1, arg2: 110, arg3: "$02000374_BF__MAIN__17$", arg4: 3, arg5: 1);
                context.SetUserValue(triggerID: 2037402, key: "2Round_A", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    context.State = new State2Round_End_Condition(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2Round_End_Condition : TriggerState {
            internal State2Round_End_Condition(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {102, 103, 104})) {
                    context.State = new State3Round_Ready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3Round_Ready : TriggerState {
            internal State3Round_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State3Round_Talk01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3Round_Talk01 : TriggerState {
            internal State3Round_Talk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000374_BF__MAIN__19$", arg3: new int[] {3000});
                context.SetConversation(arg1: 1, arg2: 110, arg3: "$02000374_BF__MAIN__19$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State3Round_Talk02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3Round_Talk02 : TriggerState {
            internal State3Round_Talk02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 0, arg2: "3,3");
                context.SetEventUI(arg1: 1, arg2: "$02000374_BF__MAIN__20$", arg3: new int[] {3000});
                context.SetConversation(arg1: 1, arg2: 110, arg3: "$02000374_BF__MAIN__20$", arg4: 2, arg5: 0);
                context.SetUserValue(triggerID: 2037405, key: "3Round_Effect", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State3Round_Talk03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3Round_Talk03 : TriggerState {
            internal State3Round_Talk03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000374_BF__MAIN__21$", arg3: new int[] {3000});
                context.SetConversation(arg1: 1, arg2: 110, arg3: "$02000374_BF__MAIN__21$", arg4: 2, arg5: 0);
                context.SetEffect(arg1: new int[] {7206}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2300)) {
                    context.State = new State3Round_Talk04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3Round_Talk04 : TriggerState {
            internal State3Round_Talk04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {199}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 199, arg3: "$02000374_BF__MAIN__30$", arg4: 2, arg5: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State3Round_Talk05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3Round_Talk05 : TriggerState {
            internal State3Round_Talk05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {199});
                context.SetEventUI(arg1: 1, arg2: "$02000374_BF__MAIN__31$", arg3: new int[] {3000});
                context.SetConversation(arg1: 1, arg2: 110, arg3: "$02000374_BF__MAIN__32$", arg4: 2, arg5: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State3Round_Talk06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3Round_Talk06 : TriggerState {
            internal State3Round_Talk06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000374_BF__MAIN__22$", arg3: new int[] {3000});
                context.SetConversation(arg1: 1, arg2: 110, arg3: "$02000374_BF__MAIN__22$", arg4: 2, arg5: 0);
                context.SetEffect(arg1: new int[] {7205}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2300)) {
                    context.State = new State3Round_Talk07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3Round_Talk07 : TriggerState {
            internal State3Round_Talk07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 110, arg3: "$02000374_BF__MAIN__23$", arg4: 2, arg5: 0);
                context.CreateMonster(arg1: new int[] {105}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {105})) {
                    context.State = new StateClear(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateClear : TriggerState {
            internal StateClear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 61000009, arg2: 6);
                context.SetActor(arg1: 4002, arg2: true, arg3: "Opened_A");
                context.MoveNpc(arg1: 110, arg2: "MS2PatrolData_2999");
                context.SetEventUI(arg1: 7, arg2: "$02000374_BF__MAIN__33$", arg3: new int[] {3000}, arg4: "0");
                context.SetConversation(arg1: 1, arg2: 110, arg3: "$02000374_BF__MAIN__24$", arg4: 2, arg5: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 4002, arg2: true, arg3: "Closed_A");
                context.SetEventUI(arg1: 1, arg2: "$02000374_BF__MAIN__34$", arg3: new int[] {3000});
                context.SetConversation(arg1: 1, arg2: 110, arg3: "$02000374_BF__MAIN__35$", arg4: 2, arg5: 0);
                context.SetEffect(arg1: new int[] {4102}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateEnd_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnd_02 : TriggerState {
            internal StateEnd_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 4002, arg2: false, arg3: "Closed_A");
                context.DestroyMonster(arg1: new int[] {110});
                context.SetPortal(arg1: 3, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}