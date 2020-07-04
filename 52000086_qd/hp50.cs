namespace Maple2.Trigger._52000086_qd {
    public static class _hp50 {
        public class StateQuest체크50100300_2 : TriggerState {
            internal StateQuest체크50100300_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50100300}, arg3: new byte[] {3})) {
                    return new State던전종료(context);
                }

                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50100300}, arg3: new byte[] {2})) {
                    return new State던전종료(context);
                }

                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50100300}, arg3: new byte[] {1})) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest체크50100310_2 : TriggerState {
            internal StateQuest체크50100310_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50100310}, arg3: new byte[] {3})) {
                    return new State던전종료(context);
                }

                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50100310}, arg3: new byte[] {2})) {
                    return new State던전종료(context);
                }

                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50100310}, arg3: new byte[] {1})) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest체크50100311_2 : TriggerState {
            internal StateQuest체크50100311_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50100311}, arg3: new byte[] {3})) {
                    return new State던전종료(context);
                }

                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50100311}, arg3: new byte[] {2})) {
                    return new State던전종료(context);
                }

                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50100311}, arg3: new byte[] {1})) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(arg1: new[] {4000}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new[] {4000}, arg2: false);
                context.SetPortal(arg1: 91, arg2: false, arg3: false, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "hp50") == 1) {
                    return new StateStartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic : TriggerState {
            internal StateStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 4);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CreateMonster(arg1: new[] {1007, 1008}, arg2: false);
                context.MoveUser(arg1: 52000086, arg2: 30);
                context.CameraSelect(arg1: 313, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State에르다Appear(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에르다Appear : TriggerState {
            internal State에르다Appear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip(arg1: "StopCinematic");
                context.SetCinematicUI(arg1: 3);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraSelect(arg1: 314, arg2: true);
                context.MoveNpc(arg1: 1008, arg2: "MS2PatrolData_1008A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State에르다대사01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에르다대사01 : TriggerState {
            internal State에르다대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003069, illustId: "SnowQueen_normal", msg: "$52000086_QD__HP50__0$", align: "right", duration: 5000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State비에른대사01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State비에른대사01 : TriggerState {
            internal State비에른대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 315, arg2: true);
                context.AddCinematicTalk(npcId: 11003075, illustId: "SnowKing_normal", msg: "$52000086_QD__HP50__1$", align: "left", duration: 3000);
                context.AddCinematicTalk(npcId: 11003075, illustId: "SnowKing_normal", msg: "$52000086_QD__HP50__2$", align: "left", duration: 2000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State에르다대사02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에르다대사02 : TriggerState {
            internal State에르다대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 316, arg2: true);
                context.VisibleMyPc(isVisible: false);
                context.AddCinematicTalk(npcId: 11003074, illustId: "SnowQueen_normal", msg: "$52000086_QD__HP50__3$", align: "right", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State비에른대사02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State비에른대사02 : TriggerState {
            internal State비에른대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003075, illustId: "SnowKing_normal", msg: "$52000086_QD__HP50__4$", align: "left", duration: 4000);
                context.AddCinematicTalk(npcId: 11003075, illustId: "SnowKing_normal", msg: "$52000086_QD__HP50__5$", align: "left", duration: 5000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    return new State비에른접근(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State비에른접근 : TriggerState {
            internal State비에른접근(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1007, arg2: "MS2PatrolData_1006B");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State에르다대사03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에르다대사03 : TriggerState {
            internal State에르다대사03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.VisibleMyPc(isVisible: true);
                context.CameraSelect(arg1: 317, arg2: true);
                context.AddCinematicTalk(npcId: 11003074, illustId: "SnowQueen_normal", msg: "$52000086_QD__HP50__6$", align: "right", duration: 4000);
                context.AddCinematicTalk(npcId: 11003074, illustId: "SnowQueen_normal", msg: "$52000086_QD__HP50__7$", align: "right", duration: 4000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new State비에른대사03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State비에른대사03 : TriggerState {
            internal State비에른대사03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 318, arg2: true);
                context.AddCinematicTalk(npcId: 11003075, illustId: "SnowKing_normal", msg: "$52000086_QD__HP50__8$", align: "left", duration: 2000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State에르다대사04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에르다대사04 : TriggerState {
            internal State에르다대사04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 317, arg2: true);
                context.AddCinematicTalk(npcId: 11003074, illustId: "SnowQueen_normal", msg: "$52000086_QD__HP50__9$", align: "right", duration: 2000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State비에른대사04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State비에른대사04 : TriggerState {
            internal State비에른대사04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 312, arg2: true);
                context.AddCinematicTalk(npcId: 11003075, illustId: "SnowKing_normal", msg: "$52000086_QD__HP50__10$", align: "right", duration: 5000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State비에른대사05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State비에른대사05 : TriggerState {
            internal State비에른대사05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 318, arg2: true);
                context.AddCinematicTalk(npcId: 11003075, illustId: "SnowKing_normal", msg: "$52000086_QD__HP50__11$", align: "left", duration: 4000);
                context.AddCinematicTalk(npcId: 11003075, illustId: "SnowKing_normal", msg: "$52000086_QD__HP50__12$", align: "left", duration: 4000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new State에르다대사05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에르다대사05 : TriggerState {
            internal State에르다대사05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 317, arg2: true);
                context.AddCinematicTalk(npcId: 11003074, illustId: "SnowQueen_normal", msg: "$52000086_QD__HP50__13$", align: "right", duration: 2000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State에르다대사06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에르다대사06 : TriggerState {
            internal State에르다대사06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {1008});
                context.SetVisibleBreakableObject(arg1: new[] {4000}, arg2: true);
                context.AddCinematicTalk(npcId: 11003075, illustId: "SnowKing_normal", msg: "$52000086_QD__HP50__14$", align: "left", duration: 2000);
                context.AddCinematicTalk(npcId: 11003074, illustId: "SnowQueen_normal", msg: "$52000086_QD__HP50__15$", align: "right", duration: 5000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new State에르다대사07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에르다대사07 : TriggerState {
            internal State에르다대사07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 319, arg2: true);
                context.CreateMonster(arg1: new[] {1009}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new[] {4000}, arg2: false);
                context.AddCinematicTalk(npcId: 11003074, illustId: "SnowQueen_normal", msg: "$52000086_QD__HP50__16$", align: "right", duration: 3000);
                context.AddCinematicTalk(npcId: 11003074, illustId: "SnowQueen_normal", msg: "$52000086_QD__HP50__17$", align: "right", duration: 5000);
                context.AddCinematicTalk(npcId: 11003074, illustId: "SnowQueen_normal", msg: "$52000086_QD__HP50__18$", align: "right", duration: 5000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 13000)) {
                    return new State에르다이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에르다이동 : TriggerState {
            internal State에르다이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1009, arg2: "MS2PatrolData_1009A");
                context.CameraSelect(arg1: 320, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State에르다대사08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에르다대사08 : TriggerState {
            internal State에르다대사08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1007, arg2: "MS2PatrolData_1007A");
                context.AddCinematicTalk(npcId: 11003074, illustId: "SnowQueen_normal", msg: "$52000086_QD__HP50__19$", align: "right", duration: 4000);
                context.AddCinematicTalk(npcId: 11003074, illustId: "SnowQueen_normal", msg: "$52000086_QD__HP50__20$", align: "right", duration: 4000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new State암전(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State암전 : TriggerState {
            internal State암전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStopCinematic : TriggerState {
            internal StateStopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
                context.VisibleMyPc(isVisible: true);
                context.SetAiExtraData(key: "getBack", value: 1);
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.DestroyMonster(arg1: new[] {1007, 1008, 1009});
                context.CreateMonster(arg1: new[] {2098}, arg2: false);
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.CameraReset(interpolationTime: 0.0f);
                context.AddBuff(arg1: new[] {199}, arg2: 70000115, arg3: 1, arg4: false, arg5: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State비에른Dead대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State비에른Dead대기 : TriggerState {
            internal State비에른Dead대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2099})) {
                    return new StateDead연출대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDead연출대기 : TriggerState {
            internal StateDead연출대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDeadStartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDeadStartCinematic : TriggerState {
            internal StateDeadStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000086, arg2: 40);
                context.DestroyMonster(arg1: new[] {2099, 2098});
                context.CreateMonster(arg1: new[] {1101, 1102}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 1102, arg2: "Stun_A", arg3: 999999999999f);
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 4);
                context.SetOnetimeEffect(id: 3, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State에드다이동02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에드다이동02 : TriggerState {
            internal State에드다이동02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip(arg1: "DeadStopCinematic");
                context.SetCinematicUI(arg1: 3);
                context.SetOnetimeEffect(id: 3, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraSelect(arg1: 321, arg2: true);
                context.MoveNpc(arg1: 1101, arg2: "MS2PatrolData_1101A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State에르다대사10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에르다대사10 : TriggerState {
            internal State에르다대사10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003074, illustId: "SnowQueen_normal", msg: "$52000086_QD__HP50__21$", align: "right", duration: 5000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State비에른대사10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State비에른대사10 : TriggerState {
            internal State비에른대사10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 322, arg2: true);
                context.AddCinematicTalk(npcId: 11003075, illustId: "SnowKing_normal", msg: "$52000086_QD__HP50__22$", align: "left", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State에르다대사11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에르다대사11 : TriggerState {
            internal State에르다대사11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003074, illustId: "SnowQueen_normal", msg: "$52000086_QD__HP50__23$", align: "right", duration: 2000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State비에른대사11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State비에른대사11 : TriggerState {
            internal State비에른대사11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 323, arg2: true);
                context.AddCinematicTalk(npcId: 11003075, illustId: "SnowKing_normal", msg: "$52000086_QD__HP50__24$", align: "left", duration: 4000);
                context.AddCinematicTalk(npcId: 11003075, illustId: "SnowKing_normal", msg: "$52000086_QD__HP50__25$", align: "left", duration: 2000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State비에른대사12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State비에른대사12 : TriggerState {
            internal State비에른대사12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003075, illustId: "SnowKing_normal", msg: "$52000086_QD__HP50__26$", align: "left", duration: 4000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State에르다대사12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에르다대사12 : TriggerState {
            internal State에르다대사12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003074, illustId: "SnowQueen_normal", msg: "$52000086_QD__HP50__27$", align: "right", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State비에른대사13(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State비에른대사13 : TriggerState {
            internal State비에른대사13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 322, arg2: true);
                context.SetNpcEmotionLoop(arg1: 1102, arg2: "Idle_A", arg3: 999999999999f);
                context.AddCinematicTalk(npcId: 11003075, illustId: "SnowKing_normal", msg: "$52000086_QD__HP50__28$", align: "left", duration: 5000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State비에른대사14(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State비에른대사14 : TriggerState {
            internal State비에른대사14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 324, arg2: true);
                context.MoveNpc(arg1: 1102, arg2: "MS2PatrolData_1102A");
                context.AddCinematicTalk(npcId: 11003075, illustId: "SnowKing_normal", msg: "$52000086_QD__HP50__29$", align: "left", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State에드다이동03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에드다이동03 : TriggerState {
            internal State에드다이동03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 325, arg2: true);
                context.AddCinematicTalk(npcId: 11003074, illustId: "SnowQueen_normal", msg: "$52000086_QD__HP50__30$", align: "right", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StatePC말풍선대사(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC말풍선대사 : TriggerState {
            internal StatePC말풍선대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52000086_QD__HP50__31$", arg4: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State에르다대사13(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에르다대사13 : TriggerState {
            internal State에르다대사13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003074, illustId: "SnowQueen_normal", msg: "$52000086_QD__HP50__32$", align: "right", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State에르다대사131(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에르다대사131 : TriggerState {
            internal State에르다대사131(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003074, illustId: "SnowQueen_normal", msg: "$52000086_QD__HP50__33$", align: "right", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State에르다대사14(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에르다대사14 : TriggerState {
            internal State에르다대사14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 321, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State에드다마저이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에드다마저이동 : TriggerState {
            internal State에드다마저이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateDeadStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDeadStopCinematic : TriggerState {
            internal StateDeadStopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
                context.SetOnetimeEffect(id: 4, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.DestroyMonster(arg1: new[] {1101, 1102});
                context.CreateMonster(arg1: new[] {10000, 10001, 10002});
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.CameraReset(interpolationTime: 0.0f);
                context.SetAchievement(arg1: 199, arg2: "trigger", arg3: "snowkingbjorn");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State던전종료 : TriggerState {
            internal State던전종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {-1});
                context.SetPortal(arg1: 91, arg2: false, arg3: false, arg4: false);
                context.MoveUser(arg1: 52000086, arg2: 30);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State던전종료1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State던전종료1 : TriggerState {
            internal State던전종료1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 4002, arg2: true, arg3: "Opened");
                context.SetMesh(arg1: new[] {3102}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetActor(arg1: 4002, arg2: true, arg3: "Opened");
                context.SetMesh(arg1: new[] {3102}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetActor(arg1: 4003, arg2: true, arg3: "Opened");
                context.SetMesh(arg1: new[] {3103}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetActor(arg1: 4004, arg2: true, arg3: "Opened");
                context.SetMesh(arg1: new[] {3104}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetBreakable(arg1: new[] {4000}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new[] {4000}, arg2: false);
                context.MoveUser(arg1: 52000086, arg2: 30);
                context.DestroyMonster(arg1: new[] {1101, 1102});
                context.CreateMonster(arg1: new[] {10000, 10001, 10002});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}