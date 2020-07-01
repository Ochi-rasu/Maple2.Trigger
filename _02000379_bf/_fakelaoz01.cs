namespace Maple2.Trigger._02000379_bf {
    public static class _fakelaoz01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 10, arg2: false, arg3: false, arg4: false);
                context.SetEffect(arg1: new[] {5000}, arg2: false);
                context.SetEffect(arg1: new[] {5100}, arg2: false);
                context.SetEffect(arg1: new[] {5200}, arg2: false);
                context.SetEffect(arg1: new[] {5300}, arg2: false);
                context.SetMesh(arg1: new[] {3000}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3001}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3002}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMeshAnimation(arg1: new[] {3000}, arg2: true, arg3: 0, arg4: 0);
                context.SetMeshAnimation(arg1: new[] {3001}, arg2: false, arg3: 0, arg4: 0);
                context.SetMeshAnimation(arg1: new[] {3002}, arg2: false, arg3: 0, arg4: 0);
                context.SetMesh(arg1: new[] {3100, 3101, 3102, 3103, 3104, 3105, 3106}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3200, 3201, 3202, 3203, 3204, 3205, 3206}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new[] {
                        3300, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315,
                        3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetSkill(arg1: new[] {2000}, arg2: false);
                context.SetSkill(arg1: new[] {2001}, arg2: false);
                context.SetSkill(arg1: new[] {2002}, arg2: false);
                context.SetAgent(arg1: "8000", arg2: true);
                context.SetAgent(arg1: "8001", arg2: true);
                context.SetAgent(arg1: "8002", arg2: true);
                context.SetAgent(arg1: "8003", arg2: true);
                context.SetAgent(arg1: "8004", arg2: true);
                context.SetAgent(arg1: "8005", arg2: true);
                context.SetAgent(arg1: "8006", arg2: true);
                context.SetAgent(arg1: "8007", arg2: true);
                context.SetAgent(arg1: "8008", arg2: true);
                context.SetAgent(arg1: "8009", arg2: true);
                context.SetAgent(arg1: "8010", arg2: true);
                context.SetAgent(arg1: "8011", arg2: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {9000})) {
                    context.State = new StateLodingDelay01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLodingDelay01 : TriggerState {
            internal StateLodingDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateLodingDelay02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLodingDelay02 : TriggerState {
            internal StateLodingDelay02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101, 201, 301}, arg2: false);
                context.CreateMonster(arg1: new[] {910, 911, 912, 920, 921, 922}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateLodingDelay03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLodingDelay03 : TriggerState {
            internal StateLodingDelay03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateCameraAct01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraAct01 : TriggerState {
            internal StateCameraAct01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 600, arg2: true);
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$02000379_BF__FAKELAOZ01__0$", arg4: 3, arg5: 1);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_101");
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_201");
                context.SetSkip(arg1: "CameraAct02");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateCameraAct02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraAct02 : TriggerState {
            internal StateCameraAct02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateCameraAct03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraAct03 : TriggerState {
            internal StateCameraAct03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 600, arg2: true);
                context.SetConversation(arg1: 1, arg2: 201, arg3: "$02000379_BF__FAKELAOZ01__1$", arg4: 3, arg5: 0);
                context.SetSkip(arg1: "CameraAct04");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateCameraAct04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraAct04 : TriggerState {
            internal StateCameraAct04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraSelect(arg1: 600, arg2: false);
                context.SetSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateKanduraTalk01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateKanduraTalk01 : TriggerState {
            internal StateKanduraTalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 301, arg3: "$02000379_BF__FAKELAOZ01__2$", arg4: 3, arg5: 2);
                context.SetNpcEmotionSequence(arg1: 301, arg2: "Event_A");
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {9001})) {
                    context.State = new StateCollapseBridge01(context);
                    return;
                }

                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateCollapseBridge01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCollapseBridge01 : TriggerState {
            internal StateCollapseBridge01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {2000}, arg2: true);
                context.SetEffect(arg1: new[] {5100}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    context.State = new StateCollapseBridge02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCollapseBridge02 : TriggerState {
            internal StateCollapseBridge02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {2001}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    context.State = new StateCollapseBridge03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCollapseBridge03 : TriggerState {
            internal StateCollapseBridge03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {2002}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    context.State = new StateCollapseBridge04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCollapseBridge04 : TriggerState {
            internal StateCollapseBridge04(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateCameraAct11(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraAct11 : TriggerState {
            internal StateCameraAct11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 601, arg2: true);
                context.SetSkip(arg1: "CameraAct13");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateCameraAct12(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraAct12 : TriggerState {
            internal StateCameraAct12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 301, arg3: "$02000379_BF__FAKELAOZ01__3$", arg4: 3, arg5: 0);
                context.SetNpcEmotionSequence(arg1: 301, arg2: "Event_A");
                context.SetSkip(arg1: "CameraAct13");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateCameraAct13(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraAct13 : TriggerState {
            internal StateCameraAct13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 601, arg2: false);
                context.SetSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateFakeLaozApp01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateFakeLaozApp01 : TriggerState {
            internal StateFakeLaozApp01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 602, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateFakeLaozApp02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateFakeLaozApp02 : TriggerState {
            internal StateFakeLaozApp02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5200}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateFakeLaozApp03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateFakeLaozApp03 : TriggerState {
            internal StateFakeLaozApp03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101, 201});
                context.CreateMonster(arg1: new[] {102, 202, 900}, arg2: false);
                context.SetSkip(arg1: "FakeLaozApp04");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateFakeLaozApp04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateFakeLaozApp04 : TriggerState {
            internal StateFakeLaozApp04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: "8000", arg2: false);
                context.SetAgent(arg1: "8001", arg2: false);
                context.SetAgent(arg1: "8002", arg2: false);
                context.SetAgent(arg1: "8003", arg2: false);
                context.SetAgent(arg1: "8004", arg2: false);
                context.SetAgent(arg1: "8005", arg2: false);
                context.SetAgent(arg1: "8006", arg2: false);
                context.SetAgent(arg1: "8007", arg2: false);
                context.SetAgent(arg1: "8008", arg2: false);
                context.SetAgent(arg1: "8009", arg2: false);
                context.SetAgent(arg1: "8010", arg2: false);
                context.SetAgent(arg1: "8011", arg2: false);
                context.CameraSelect(arg1: 602, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetSkip();
                context.MoveNpc(arg1: 301, arg2: "MS2PatrolData_301");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateKanduraDisapp01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateKanduraDisapp01 : TriggerState {
            internal StateKanduraDisapp01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 2, key: "SpyKandura", value: 1);
                context.DestroyMonster(arg1: new[] {301});
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {900})) {
                    context.State = new StateKanduraDisapp02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateKanduraDisapp02 : TriggerState {
            internal StateKanduraDisapp02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateFakeLaozDie01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateFakeLaozDie01 : TriggerState {
            internal StateFakeLaozDie01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3000}, arg2: false, arg3: 200, arg4: 0, arg5: 5f);
                context.SetMesh(arg1: new[] {3001}, arg2: true, arg3: 0, arg4: 0, arg5: 5f);
                context.SetMeshAnimation(arg1: new[] {3000}, arg2: false, arg3: 0, arg4: 0);
                context.SetMeshAnimation(arg1: new[] {3001}, arg2: true, arg3: 200, arg4: 0);
                context.SetUserValue(triggerId: 2, key: "SpyKandura", value: 2);
                context.DestroyMonster(arg1: new[] {900, 910, 911, 912, 920, 921, 922});
                context.DestroyMonster(arg1: new[] {102, 202});
                context.CreateMonster(arg1: new[] {103, 203}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateLampLightUp01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLampLightUp01 : TriggerState {
            internal StateLampLightUp01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5300}, arg2: true);
                context.SetRandomMesh(
                    arg1: new[] {
                        3300, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315,
                        3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323
                    }, arg2: true, arg3: 24, arg4: 100, arg5: 70);
                context.SetMesh(arg1: new[] {3202, 3203, 3204}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3100, 3101, 3102, 3103, 3104, 3105, 3106}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.CameraSelect(arg1: 700, arg2: true);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetSkip(arg1: "LampLightUp02");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateLampLightUp02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLampLightUp02 : TriggerState {
            internal StateLampLightUp02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
                context.MoveUser(arg1: 02000379, arg2: 11, arg3: 9900);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateLampLightUp03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLampLightUp03 : TriggerState {
            internal StateLampLightUp03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 103, arg3: "$02000379_BF__FAKELAOZ01__4$", arg4: 3, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 203, arg3: "$02000379_BF__FAKELAOZ01__5$", arg4: 3, arg5: 3);
                context.SetSkip(arg1: "LampLightUp04");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new StateLampLightUp04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLampLightUp04 : TriggerState {
            internal StateLampLightUp04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateLampLightUp05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLampLightUp05 : TriggerState {
            internal StateLampLightUp05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_102");
                context.MoveNpc(arg1: 203, arg2: "MS2PatrolData_202");
                context.SetConversation(arg1: 1, arg2: 103, arg3: "$02000379_BF__FAKELAOZ01__6$", arg4: 3, arg5: 2);
                context.SetConversation(arg1: 1, arg2: 203, arg3: "$02000379_BF__FAKELAOZ01__7$", arg4: 3, arg5: 6);
                context.SetSkip(arg1: "TimeToLeave01");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new StateTimeToLeave01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTimeToLeave01 : TriggerState {
            internal StateTimeToLeave01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 700, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 10, arg2: true, arg3: true, arg4: true);
                context.DungeonClear();
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}