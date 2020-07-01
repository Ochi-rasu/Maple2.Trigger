using System;

namespace Maple2.Trigger._52000061_qd {
    public static class _playmusic01 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5000}, arg2: false);
                context.SetEffect(arg1: new int[] {5001}, arg2: false);
                context.SetEffect(arg1: new int[] {5002}, arg2: false);
                context.SetEffect(arg1: new int[] {5003}, arg2: false);
                context.SetEffect(arg1: new int[] {5004}, arg2: false);
                context.SetEffect(arg1: new int[] {5100}, arg2: false);
                context.SetEffect(arg1: new int[] {5200}, arg2: false);
                context.SetSound(arg1: 10000, arg2: false);
                context.CreateMonster(arg1: new int[] {101, 201, 202, 203, 204}, arg2: false);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {90000550},
                    arg3: new byte[] {1})) {
                    context.State = new StateLodingDelay01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {90000550},
                    arg3: new byte[] {2})) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLodingDelay01 : TriggerState {
            internal StateLodingDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

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
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StatePCWalkInStage01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCWalkInStage01 : TriggerState {
            internal StatePCWalkInStage01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000061, arg2: 10);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StatePCWalkInStage02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCWalkInStage02 : TriggerState {
            internal StatePCWalkInStage02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_1000");
                context.CameraSelect(arg1: 600, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StatePCWalkInStage03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCWalkInStage03 : TriggerState {
            internal StatePCWalkInStage03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraSelectPath(arg1: new int[] {601, 602}, arg2: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {9000})) {
                    context.State = new StatePCWalkInStage04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCWalkInStage04 : TriggerState {
            internal StatePCWalkInStage04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 603, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StatePCBow01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCBow01 : TriggerState {
            internal StatePCBow01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionSequence(arg1: "Emotion_Chin_Chin_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.State = new StatePCBow02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCBow02 : TriggerState {
            internal StatePCBow02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StatePCBow03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCBow03 : TriggerState {
            internal StatePCBow03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 1.0f);
                context.CameraSelect(arg1: 610, arg2: true);
                context.MoveUser(arg1: 52000061, arg2: 20);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StatePCReadyToPlayThePiano01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCReadyToPlayThePiano01 : TriggerState {
            internal StatePCReadyToPlayThePiano01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(arg1: "Music_Piano_Idle_A", arg2: 31500f);
                context.SetEffect(arg1: new int[] {5100}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StatePCPlayMusic01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCPlayMusic01 : TriggerState {
            internal StatePCPlayMusic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetSound(arg1: 10000, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StatePCPlayMusic02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCPlayMusic02 : TriggerState {
            internal StatePCPlayMusic02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5000}, arg2: true);
                context.SetEffect(arg1: new int[] {5001}, arg2: true);
                context.SetEffect(arg1: new int[] {5002}, arg2: true);
                context.SetEffect(arg1: new int[] {5003}, arg2: true);
                context.SetEffect(arg1: new int[] {5004}, arg2: true);
                context.SetNpcEmotionLoop(arg1: 201, arg2: "Play_A", arg3: 30500f);
                context.SetNpcEmotionLoop(arg1: 202, arg2: "Play_A", arg3: 30500f);
                context.SetNpcEmotionLoop(arg1: 203, arg2: "Play_A", arg3: 30500f);
                context.SetNpcEmotionLoop(arg1: 204, arg2: "Play_A", arg3: 30500f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 30500)) {
                    context.State = new StatePCPlayMusic03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCPlayMusic03 : TriggerState {
            internal StatePCPlayMusic03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 10000, arg2: false);
                context.SetEffect(arg1: new int[] {5000}, arg2: false);
                context.SetEffect(arg1: new int[] {5001}, arg2: false);
                context.SetEffect(arg1: new int[] {5002}, arg2: false);
                context.SetEffect(arg1: new int[] {5003}, arg2: false);
                context.SetEffect(arg1: new int[] {5004}, arg2: false);
                context.SetEffect(arg1: new int[] {5200}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StatePCPlayQuit01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCPlayQuit01 : TriggerState {
            internal StatePCPlayQuit01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetEffect(arg1: new int[] {5100}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new StatePCPlayQuit02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCPlayQuit02 : TriggerState {
            internal StatePCPlayQuit02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000061, arg2: 30);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StatePCPlayQuit03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCPlayQuit03 : TriggerState {
            internal StatePCPlayQuit03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 1.0f);
                context.SetAchievement(arg1: 9900, arg2: "trigger", arg3: "PerformanceWithNPC");
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {90000550},
                    arg3: new byte[] {3})) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}