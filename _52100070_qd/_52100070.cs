using System;

namespace Maple2.Trigger._52100070_qd {
    public static class _52100070 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateReady(context);

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 400, arg2: true);
                context.SetEffect(arg1: new int[] {5000}, arg2: false);
                context.SetEffect(arg1: new int[] {5001}, arg2: false);
                context.SetEffect(arg1: new int[] {5002}, arg2: false);
                context.SetEffect(arg1: new int[] {5003}, arg2: false);
                context.SetEffect(arg1: new int[] {5004}, arg2: false);
                context.SetEffect(arg1: new int[] {5005}, arg2: false);
                context.SetEffect(arg1: new int[] {5006}, arg2: false);
                context.SetEffect(arg1: new int[] {5007}, arg2: false);
                context.VisibleMyPc(isVisible: false);
                context.SetProductionUI(arg1: 1);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {1000})) {
                    context.State = new Statenarration01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statenarration01 : TriggerState {
            internal Statenarration01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetProductionUI(arg1: 9, arg2: "$52100070_QD__52100070__0$");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State암전1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State암전1 : TriggerState {
            internal State암전1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetProductionUI(arg1: 1);
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    context.State = new StateCamera_Move_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCamera_Move_01 : TriggerState {
            internal StateCamera_Move_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {400, 401}, arg2: false);
                context.ShowCaption(type: "VerticalCaption", title: "$52100070_QD__52100070__1$",
                    desc: "$52100070_QD__52100070__2$", align: "bottomLeft", offsetRateX: 0f, offsetRateY: 0f,
                    duration: 5000, scale: 2.5f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State몬스터생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터생성 : TriggerState {
            internal State몬스터생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip(arg1: "연출끝");
                context.CreateMonster(arg1: new int[] {101, 102, 103}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State전경카메라1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전경카메라1 : TriggerState {
            internal State전경카메라1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 600, arg2: true);
                context.CameraSelectPath(arg1: new int[] {600, 601}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State퐈이야(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퐈이야 : TriggerState {
            internal State퐈이야(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5001}, arg2: true);
                context.SetEffect(arg1: new int[] {5002}, arg2: true);
                context.SetEffect(arg1: new int[] {5004}, arg2: true);
                context.SetEffect(arg1: new int[] {5007}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State이슈라카메라1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이슈라카메라1 : TriggerState {
            internal State이슈라카메라1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {402, 403}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State이슈라카메라2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이슈라카메라2 : TriggerState {
            internal State이슈라카메라2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 500, arg2: true);
                context.CameraSelectPath(arg1: new int[] {500, 501}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State이슈라카메라3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이슈라카메라3 : TriggerState {
            internal State이슈라카메라3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 404, arg2: false);
                context.CameraSelectPath(arg1: new int[] {404, 405}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State이슈라카메라4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이슈라카메라4 : TriggerState {
            internal State이슈라카메라4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 406, arg2: false);
                context.CameraSelectPath(arg1: new int[] {406, 407}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State렌듀비앙이동1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State렌듀비앙이동1 : TriggerState {
            internal State렌듀비앙이동1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimeScale(enable: true, startScale: 0.5f, endScale: 0.5f, duration: 50.0f, interpolator: 1);
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_11003867");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State유페리아이동1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State유페리아이동1 : TriggerState {
            internal State유페리아이동1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_11003868");
                context.SetEffect(arg1: new int[] {5000}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State이슈라이동1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이슈라이동1 : TriggerState {
            internal State이슈라이동1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5005}, arg2: true);
                context.SetEffect(arg1: new int[] {5006}, arg2: true);
                context.SetTimeScale(enable: true, startScale: 0.3f, endScale: 0.3f, duration: 50.0f, interpolator: 1);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_11003866");
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State연출끝(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출끝 : TriggerState {
            internal State연출끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5000}, arg2: false);
                context.SetEffect(arg1: new int[] {5001}, arg2: false);
                context.SetEffect(arg1: new int[] {5002}, arg2: false);
                context.SetEffect(arg1: new int[] {5003}, arg2: false);
                context.SetEffect(arg1: new int[] {5004}, arg2: false);
                context.SetEffect(arg1: new int[] {5005}, arg2: false);
                context.SetEffect(arg1: new int[] {5006}, arg2: false);
                context.SetEffect(arg1: new int[] {5007}, arg2: false);
                context.SetTimeScale(enable: false, startScale: 0.5f, endScale: 0.5f, duration: 50.0f, interpolator: 1);
                context.DestroyMonster(arg1: new int[] {101, 102, 103}, arg2: false);
                context.SetSkip();
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 0.0f);
                context.VisibleMyPc(isVisible: true);
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.MoveUser(arg1: 52010068, arg2: 6001);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateReady(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}