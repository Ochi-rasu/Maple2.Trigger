using System;

namespace Maple2.Trigger._63000023_cs {
    public static class _gototria01 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10001001}, arg2: 0);
                context.SetEffect(arg1: new int[] {5000}, arg2: false);
                context.SetEffect(arg1: new int[] {5001}, arg2: false);
                context.SetEffect(arg1: new int[] {5002}, arg2: false);
                context.SetEffect(arg1: new int[] {5200}, arg2: false);
                context.SetEffect(arg1: new int[] {5300}, arg2: false);
                context.SetEffect(arg1: new int[] {5100}, arg2: false);
                context.SetEffect(arg1: new int[] {5101}, arg2: false);
                context.SetEffect(arg1: new int[] {5102}, arg2: false);
                context.SetEffect(arg1: new int[] {5103}, arg2: false);
                context.SetEffect(arg1: new int[] {5104}, arg2: false);
                context.CreateMonster(arg1: new int[] {201, 301, 401, 501, 601}, arg2: false);
                context.SetBreakable(arg1: new int[] {4000}, arg2: false);
                context.SetEffect(arg1: new int[] {6000}, arg2: false);
                context.SetEffect(arg1: new int[] {6001}, arg2: false);
                context.SetEffect(arg1: new int[] {7000}, arg2: false);
                context.SetEffect(arg1: new int[] {7001}, arg2: false);
                context.SetEffect(arg1: new int[] {7002}, arg2: false);
                context.SetEffect(arg1: new int[] {7003}, arg2: false);
                context.SetEffect(arg1: new int[] {7100}, arg2: false);
                context.SetEffect(arg1: new int[] {7101}, arg2: false);
                context.SetEffect(arg1: new int[] {7102}, arg2: false);
                context.SetEffect(arg1: new int[] {7103}, arg2: false);
                context.SetEffect(arg1: new int[] {7200}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "9000")) {
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
                context.CameraSelect(arg1: 500, arg2: true);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {90000440},
                    arg3: new byte[] {3})) {
                    context.State = new StateQuestOngoing01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {90000441},
                    arg3: new byte[] {1})) {
                    context.State = new StateQuestOngoing11(context);
                    return;
                }

                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateWalkWithJacey01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuestOngoing01 : TriggerState {
            internal StateQuestOngoing01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 500, arg2: false);
                context.DestroyMonster(arg1: new int[] {201, 301});
                context.CreateMonster(arg1: new int[] {202, 302}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateQuestOngoing02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuestOngoing02 : TriggerState {
            internal StateQuestOngoing02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateNextQuestStart01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuestOngoing11 : TriggerState {
            internal StateQuestOngoing11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 500, arg2: false);
                context.DestroyMonster(arg1: new int[] {201, 301});
                context.CreateMonster(arg1: new int[] {202, 302}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateQuestOngoing12(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuestOngoing12 : TriggerState {
            internal StateQuestOngoing12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateGetCloseToTheCar01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWalkWithJacey01 : TriggerState {
            internal StateWalkWithJacey01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CreateMonster(arg1: new int[] {101}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateWalkWithJacey02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWalkWithJacey02 : TriggerState {
            internal StateWalkWithJacey02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 501, arg2: true);
                context.MoveUserPath(arg1: "MS2PatrolData_1000");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateWalkWithJacey03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWalkWithJacey03 : TriggerState {
            internal StateWalkWithJacey03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 600, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDialogue01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDialogue01 : TriggerState {
            internal StateDialogue01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 201, arg2: "Talk_A");
                context.SetEffect(arg1: new int[] {7000}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001545, arg3: "$63000023_CS__GOTOTRIA01__0$", arg4: 6);
                context.SetSkip(arg1: "Dialogue02");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new StateDialogue02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDialogue02 : TriggerState {
            internal StateDialogue02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {7000}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 201, arg2: "Idle_A");
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateDialogue03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDialogue03 : TriggerState {
            internal StateDialogue03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 301, arg2: "Talk_A");
                context.SetEffect(arg1: new int[] {7100}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001546, arg3: "$63000023_CS__GOTOTRIA01__1$", arg4: 6);
                context.SetSkip(arg1: "Dialogue04");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new StateDialogue04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDialogue04 : TriggerState {
            internal StateDialogue04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {7100}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 301, arg2: "Idle_A");
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateDialogue05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDialogue05 : TriggerState {
            internal StateDialogue05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 201, arg2: "Talk_A");
                context.SetEffect(arg1: new int[] {7001}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001545, arg3: "$63000023_CS__GOTOTRIA01__2$", arg4: 6);
                context.SetSkip(arg1: "Dialogue06");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new StateDialogue06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDialogue06 : TriggerState {
            internal StateDialogue06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {7001}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 201, arg2: "Idle_A");
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateDialogue07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDialogue07 : TriggerState {
            internal StateDialogue07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 201, arg2: "Talk_A");
                context.SetConversation(arg1: 2, arg2: 11001545, arg3: "$63000023_CS__GOTOTRIA01__3$", arg4: 4);
                context.SetSkip(arg1: "Dialogue08");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateDialogue08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDialogue08 : TriggerState {
            internal StateDialogue08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 201, arg2: "Idle_A");
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateDialogue09(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDialogue09 : TriggerState {
            internal StateDialogue09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 301, arg2: "Talk_A");
                context.SetEffect(arg1: new int[] {7101}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001546, arg3: "$63000023_CS__GOTOTRIA01__4$", arg4: 5);
                context.SetSkip(arg1: "Dialogue10");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateDialogue10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDialogue10 : TriggerState {
            internal StateDialogue10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {7101}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 301, arg2: "Idle_A");
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateDialogue11(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDialogue11 : TriggerState {
            internal StateDialogue11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 201, arg2: "Talk_A");
                context.SetEffect(arg1: new int[] {7002}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001545, arg3: "$63000023_CS__GOTOTRIA01__5$", arg4: 5);
                context.SetSkip(arg1: "Dialogue12");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateDialogue12(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDialogue12 : TriggerState {
            internal StateDialogue12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {7002}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 201, arg2: "Idle_A");
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateDialogue13(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDialogue13 : TriggerState {
            internal StateDialogue13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 301, arg2: "Talk_A");
                context.SetEffect(arg1: new int[] {7102}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001546, arg3: "$63000023_CS__GOTOTRIA01__6$", arg4: 5);
                context.SetSkip(arg1: "Dialogue14");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateDialogue14(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDialogue14 : TriggerState {
            internal StateDialogue14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {7102}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 301, arg2: "Idle_A");
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateDialogue15(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDialogue15 : TriggerState {
            internal StateDialogue15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 201, arg2: "Talk_A");
                context.SetEffect(arg1: new int[] {7003}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001545, arg3: "$63000023_CS__GOTOTRIA01__7$", arg4: 5);
                context.SetSkip(arg1: "Dialogue16");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateDialogue16(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDialogue16 : TriggerState {
            internal StateDialogue16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 201, arg2: "Idle_A");
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateDialogue17(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDialogue17 : TriggerState {
            internal StateDialogue17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 201, arg2: "Talk_A");
                context.SetConversation(arg1: 2, arg2: 11001545, arg3: "$63000023_CS__GOTOTRIA01__8$", arg4: 4);
                context.SetSkip(arg1: "Dialogue18");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateDialogue18(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDialogue18 : TriggerState {
            internal StateDialogue18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {7003}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 201, arg2: "Idle_A");
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateDialogue19(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDialogue19 : TriggerState {
            internal StateDialogue19(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 301, arg2: "Talk_A");
                context.SetEffect(arg1: new int[] {7103}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001546, arg3: "$63000023_CS__GOTOTRIA01__9$", arg4: 5);
                context.SetSkip(arg1: "Dialogue20");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateDialogue20(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDialogue20 : TriggerState {
            internal StateDialogue20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 301, arg2: "Idle_A");
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateDialogue21(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDialogue21 : TriggerState {
            internal StateDialogue21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 301, arg2: "Talk_A");
                context.SetConversation(arg1: 2, arg2: 11001546, arg3: "$63000023_CS__GOTOTRIA01__10$", arg4: 4);
                context.SetSkip(arg1: "Dialogue22");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateDialogue22(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDialogue22 : TriggerState {
            internal StateDialogue22(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {7103}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 301, arg2: "Idle_A");
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.CameraSelect(arg1: 601, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateAttackIdle01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateAttackIdle01 : TriggerState {
            internal StateAttackIdle01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_201");
                context.MoveNpc(arg1: 301, arg2: "MS2PatrolData_301");
                context.SetEffect(arg1: new int[] {7200}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 201, arg3: "$63000023_CS__GOTOTRIA01__11$", arg4: 3, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 301, arg3: "$63000023_CS__GOTOTRIA01__12$", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateTalkJacey01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTalkJacey01 : TriggerState {
            internal StateTalkJacey01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_101");
                context.MoveUserPath(arg1: "MS2PatrolData_1001");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateTalkJacey02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTalkJacey02 : TriggerState {
            internal StateTalkJacey02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 700, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateTalkJacey03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTalkJacey03 : TriggerState {
            internal StateTalkJacey03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {7200}, arg2: false);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_102");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateJaceyTalk04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateJaceyTalk04 : TriggerState {
            internal StateJaceyTalk04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001620, arg3: "$63000023_CS__GOTOTRIA01__13$", arg4: 5);
                context.SetSkip(arg1: "JaceyTalk05");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateJaceyTalk05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateJaceyTalk05 : TriggerState {
            internal StateJaceyTalk05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateJaceyLeave01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateJaceyLeave01 : TriggerState {
            internal StateJaceyLeave01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new StateJaceyLeave02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateJaceyLeave02 : TriggerState {
            internal StateJaceyLeave02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_103");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateJaceyLeave03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateJaceyLeave03 : TriggerState {
            internal StateJaceyLeave03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_1002");
                context.CameraSelectPath(arg1: new int[] {701, 702}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateJaceyLeave04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateJaceyLeave04 : TriggerState {
            internal StateJaceyLeave04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$63000023_CS__GOTOTRIA01__14$", arg4: 4, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.State = new StateJaceyLeave05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateJaceyLeave05 : TriggerState {
            internal StateJaceyLeave05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {201, 301});
                context.CreateMonster(arg1: new int[] {202, 302}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateJaceyLeave06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateJaceyLeave06 : TriggerState {
            internal StateJaceyLeave06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraSelect(arg1: 702, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateQuestComplete01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuestComplete01 : TriggerState {
            internal StateQuestComplete01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {101});
                context.ShowGuideSummary(entityID: 10028010, textID: 10028010);
                context.SetEffect(arg1: new int[] {5000}, arg2: true);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {90000440},
                    arg3: new byte[] {3})) {
                    context.State = new StateNextQuestStart01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 10028010);
            }
        }

        private class StateNextQuestStart01 : TriggerState {
            internal StateNextQuestStart01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 10028020, textID: 10028020);
                context.SetEffect(arg1: new int[] {5000}, arg2: true);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {90000441},
                    arg3: new byte[] {1})) {
                    context.State = new StateGetCloseToTheCar01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 10028020);
            }
        }

        private class StateGetCloseToTheCar01 : TriggerState {
            internal StateGetCloseToTheCar01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {6000}, arg2: true);
                context.ShowGuideSummary(entityID: 10028030, textID: 10028030);
                context.SetEffect(arg1: new int[] {5000}, arg2: true);
                context.SetEffect(arg1: new int[] {5001}, arg2: true);
                context.SetEffect(arg1: new int[] {5200}, arg2: true);
                context.SetEffect(arg1: new int[] {5100}, arg2: true);
                context.SetEffect(arg1: new int[] {5101}, arg2: true);
                context.SetEffect(arg1: new int[] {5102}, arg2: true);
                context.SetEffect(arg1: new int[] {5103}, arg2: true);
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "9001")) {
                    context.State = new StateGetCloseToTheCar02(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 10028030);
            }
        }

        private class StateGetCloseToTheCar02 : TriggerState {
            internal StateGetCloseToTheCar02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 202, arg2: "MS2PatrolData_202");
                context.MoveNpc(arg1: 302, arg2: "MS2PatrolData_302");
                context.ShowGuideSummary(entityID: 10028040, textID: 10028040);
                context.SetInteractObject(arg1: new int[] {10001001}, arg2: 1);
                context.SetEffect(arg1: new int[] {5000}, arg2: true);
                context.SetEffect(arg1: new int[] {5002}, arg2: true);
                context.SetEffect(arg1: new int[] {5300}, arg2: true);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10001001}, arg2: 0)) {
                    context.State = new StateGetInTheCar01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGetInTheCar01 : TriggerState {
            internal StateGetInTheCar01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(arg1: new int[] {4000}, arg2: true);
                context.HideGuideSummary(entityID: 10028040);
                context.SetEffect(arg1: new int[] {5000}, arg2: false);
                context.SetEffect(arg1: new int[] {5002}, arg2: false);
                context.SetEffect(arg1: new int[] {5001}, arg2: false);
                context.SetEffect(arg1: new int[] {5200}, arg2: false);
                context.SetEffect(arg1: new int[] {5100}, arg2: false);
                context.SetEffect(arg1: new int[] {5101}, arg2: false);
                context.SetEffect(arg1: new int[] {5102}, arg2: false);
                context.SetEffect(arg1: new int[] {5103}, arg2: false);
                context.SetEffect(arg1: new int[] {5104}, arg2: false);
                context.SetEffect(arg1: new int[] {5300}, arg2: false);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateGetInTheCar02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGetInTheCar02 : TriggerState {
            internal StateGetInTheCar02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {6000}, arg2: false);
                context.SetEffect(arg1: new int[] {6001}, arg2: true);
                context.MoveUser(arg1: 63000023, arg2: 2, arg3: 9900);
                context.CameraSelect(arg1: 800, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateGetInTheCar03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGetInTheCar03 : TriggerState {
            internal StateGetInTheCar03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateCarMoving01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCarMoving01 : TriggerState {
            internal StateCarMoving01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new StateCarMoving02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCarMoving02 : TriggerState {
            internal StateCarMoving02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(arg1: new int[] {4000}, arg2: false);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
                context.CameraSelect(arg1: 800, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateCarMoving03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCarMoving03 : TriggerState {
            internal StateCarMoving03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {6001}, arg2: false);
                context.MoveUser(arg1: 02000062, arg2: 13, arg3: 9900);
            }

            public override void Execute() {
                if (!context.UserDetected(arg1: "9900")) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}