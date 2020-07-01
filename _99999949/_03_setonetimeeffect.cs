using System;

namespace Maple2.Trigger._99999949 {
    public static class _03_setonetimeeffect {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"UGC_Test/Eff_Tutorial_Sound_target.xml");
                context.SetOnetimeEffect(id: 2, enable: false, path: @"UGC_Test/Eff_Tutorial_Sound_target.xml");
                context.SetOnetimeEffect(id: 3, enable: false,
                    path: @"BG/Common/Eff_co_targetBox_test_99999949_01.xml");
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {9021})) {
                    context.State = new StateGuide(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGuide : TriggerState {
            internal StateGuide(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DebugString(@string: "3번 영역에 들어가면 SetOnetime트리거가 발동됩니다.Effect targetBox 이펙트 테스트.");
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {9020})) {
                    context.State = new StateSetOnetimeEffectReady01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSetOnetimeEffectReady01 : TriggerState {
            internal StateSetOnetimeEffectReady01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DebugString(@string: "SetOnetimeEffect 1초 후에 시작됩니다.");
                context.SetOnetimeEffect(id: 1, enable: true, path: @"UGC_Test/Eff_Tutorial_Sound_target.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSetOnetimeEffect01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSetOnetimeEffect01 : TriggerState {
            internal StateSetOnetimeEffect01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DebugString(@string: "SetOnetimeEffect 재생");
                context.SetOnetimeEffect(id: 2, enable: true, path: @"UGC_Test/Eff_Tutorial_Sound_target.xml");
                context.SetOnetimeEffect(id: 3, enable: true, path: @"BG/Common/Eff_co_targetBox_test_99999949_01.xml");
                context.SetTimeScale(enable: true, startScale: 1f, endScale: 0.2f, duration: 2f, interpolator: 2);
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
                context.SetTimeScale(enable: true, startScale: 0.2f, endScale: 1f, duration: 2f, interpolator: 2);
                context.SetOnetimeEffect(id: 3, enable: false,
                    path: @"BG/Common/Eff_co_targetBox_test_99999949_01.xml");
                context.DebugString(@string: "5초 후에 트리거가 리셋됩니다. 3번 영역 밖으로 나가세요.");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}