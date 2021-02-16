namespace Maple2.Trigger._52000087_qd {
    public static class _52000087 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {22651}, arg2: new[] {10003370}, arg3: new byte[] {2})) {
                    return new State보고시작Prepare_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보고시작Prepare_01 : TriggerState {
            internal State보고시작Prepare_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(arg1: 1);
                context.MoveUser(arg1: 52000087, arg2: 6001);
                context.CameraSelectPath(arg1: new[] {4001}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State보고시작Prepare_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보고시작Prepare_02 : TriggerState {
            internal State보고시작Prepare_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(arg1: new[] {4002}, arg2: false);
                context.MoveUserPath(arg1: "MS2PatrolData_3001");
                context.SetSceneSkip(state: new StateSkip_1(context), arg2: "nextState");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5500)) {
                    return new State보고시작Prepare_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보고시작Prepare_03 : TriggerState {
            internal State보고시작Prepare_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(arg1: "Talk_A", arg2: 5000f);
                context.CameraSelectPath(arg1: new[] {4003}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State보고시작Prepare_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보고시작Prepare_04 : TriggerState {
            internal State보고시작Prepare_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State보고시작_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보고시작_01 : TriggerState {
            internal State보고시작_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 9, arg2: "$52000087_QD__52000087__0$");
                context.MoveUser(arg1: 52000087, arg2: 10);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State영상재생(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State영상재생 : TriggerState {
            internal State영상재생(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(arg1: "SceneMovie");
                context.PlaySceneMovie(fileName: "Kritias_EpicCutScene_second_01.swf", movieId: 1);
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WidgetCondition(arg1: "SceneMovie", arg2: "IsStop", arg3: "1")) {
                    return new StateQuit(context);
                }

                if (context.WaitTick(waitTick: 35000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.MoveUser(arg1: 52000087, arg2: 10);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.CameraReset(interpolationTime: 0.0f);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}