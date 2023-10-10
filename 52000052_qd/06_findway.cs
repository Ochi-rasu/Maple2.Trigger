namespace Maple2.Trigger._52000052_qd {
    public static class _06_findway {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{4026, 3006}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3106}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMeshAnimation(triggerIds: new []{3006}, visible: true, arg3: 0, arg4: 0);
                context.SetMeshAnimation(triggerIds: new []{3106}, visible: false, arg3: 0, arg4: 0);
                context.SetEffect(triggerIds: new []{5206}, visible: false);
                context.SetUserValue(key: "FindWay", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "FindWay") == 1) {
                    return new StateReadyToWalkIn01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReadyToWalkIn01 : TriggerState {
            internal StateReadyToWalkIn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{4026}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.MoveNpc(spawnId: 104, patrolName: "MS2PatrolData_106");
                context.MoveNpc(spawnId: 204, patrolName: "MS2PatrolData_206");
                context.SetConversation(type: 1, spawnId: 204, script: "$52000052_QD__04_FINDWAY__0$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateReadyToWalkIn02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReadyToWalkIn02 : TriggerState {
            internal StateReadyToWalkIn02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1306, key: "RouteSelected", value: 1);
                context.SetUserValue(triggerId: 2306, key: "RouteSelected", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateReadyToWalkIn03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReadyToWalkIn03 : TriggerState {
            internal StateReadyToWalkIn03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 104, script: "$52000052_QD__04_FINDWAY__1$", arg4: 2, arg5: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateRound06_Start(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(spawnIds: new []{104, 204});
            }
        }

        private class StateRound06_Start : TriggerState {
            internal StateRound06_Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1006, 2006}, arg2: false);
                context.SetConversation(type: 1, spawnId: 1006, script: "$52000052_QD__04_FINDWAY__2$", arg4: 3, arg5: 2);
                context.SetUserValue(triggerId: 906, key: "MobWaveStart", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "06RoundSuccess") == 1) {
                    return new StateRound06_Sucess(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound06_Sucess : TriggerState {
            internal StateRound06_Sucess(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 2006, patrolName: "MS2PatrolData_2006");
                context.DestroyMonster(spawnIds: new []{1006});
                context.CreateMonster(spawnIds: new []{106}, arg2: false);
                context.SetMesh(triggerIds: new []{3006}, visible: false, arg3: 100, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3106}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMeshAnimation(triggerIds: new []{3006}, visible: false, arg3: 0, arg4: 0);
                context.SetMeshAnimation(triggerIds: new []{3106}, visible: true, arg3: 0, arg4: 0);
                context.SetEffect(triggerIds: new []{5206}, visible: true);
                context.SetConversation(type: 1, spawnId: 106, script: "$52000052_QD__04_FINDWAY__3$", arg4: 2, arg5: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateRound06_RouteSelect(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound06_RouteSelect : TriggerState {
            internal StateRound06_RouteSelect(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{2006});
                context.CreateMonster(spawnIds: new []{206}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 50)) {
                    return new StateRound06_PickRoute_Left(context);
                }

                if (context.RandomCondition(rate: 50)) {
                    return new StateRound06_PickRoute_Right(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound06_PickRoute_Left : TriggerState {
            internal StateRound06_PickRoute_Left(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1306, key: "MakeTrue", value: 1);
                context.SetUserValue(triggerId: 2306, key: "MakeFalse", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateGoToPortal13(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGoToPortal13 : TriggerState {
            internal StateGoToPortal13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 106, patrolName: "MS2PatrolData_13");
                context.MoveNpc(spawnId: 206, patrolName: "MS2PatrolData_23");
                context.SetUserValue(triggerId: 12, key: "FindWay", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound06_PickRoute_Right : TriggerState {
            internal StateRound06_PickRoute_Right(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1306, key: "MakeFalse", value: 1);
                context.SetUserValue(triggerId: 2306, key: "MakeTrue", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateGoToPortal14(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGoToPortal14 : TriggerState {
            internal StateGoToPortal14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 12, key: "FindWay", value: 1);
                context.MoveNpc(spawnId: 106, patrolName: "MS2PatrolData_14");
                context.MoveNpc(spawnId: 206, patrolName: "MS2PatrolData_24");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{106, 206});
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
