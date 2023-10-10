using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000168_qd {
    public static class _52000168 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9001})) {
                    return new State영상재생(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State영상재생 : TriggerState {
            internal State영상재생(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{401, 402, 403, 404, 405, 406}, arg2: false);
                context.MoveUser(mapId: 52000168, portalId: 80);
                context.CreateWidget(type: WidgetType.SceneMovie);
                context.PlaySceneMovie(fileName: "jobChange_RBlader.swf", movieId: 1);
            }

            public override TriggerState? Execute() {
                if (context.WidgetCondition(type: WidgetType.SceneMovie, condition: "IsStop", value: "1")) {
                    return new State전경씬01(context);
                }

                if (context.WaitTick(waitTick: 8000)) {
                    return new State전경씬01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전경씬01 : TriggerState {
            internal State전경씬01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new StateSkip_1(context), arg2: "nextState");
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetPcEmotionLoop(sequenceName: "Push_A", duration: 10000f, arg3: true);
                context.SetNpcEmotionLoop(spawnId: 402, sequenceName: "Attack_Idle_A", duration: 1000000f);
                context.SetNpcEmotionLoop(spawnId: 403, sequenceName: "Dead_A", duration: 800000f);
                context.SetNpcEmotionLoop(spawnId: 404, sequenceName: "Dead_A", duration: 800000f);
                context.SetNpcEmotionLoop(spawnId: 405, sequenceName: "Dead_A", duration: 800000f);
                context.SetNpcEmotionLoop(spawnId: 406, sequenceName: "Dead_A", duration: 800000f);
                context.CameraSelectPath(pathIds: new []{4000, 4001, 4003}, returnView: false);
                context.SetCinematicUI(type: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new State전경씬02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전경씬02 : TriggerState {
            internal State전경씬02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateQuit01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit01 : TriggerState {
            internal StateQuit01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateQuit02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 4);
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetOnetimeEffect(id: 2, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateQuit02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit02 : TriggerState {
            internal StateQuit02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 0.0f);
                context.ShowGuideSummary(entityId: 52001681, textId: 52001681, duration: 10000);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{20002373}, questStates: new byte[]{3})) {
                    return new State전직이펙트_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전직이펙트_01 : TriggerState {
            internal State전직이펙트_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 30, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastWhiteOutFast.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State전직이펙트_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전직이펙트_02 : TriggerState {
            internal State전직이펙트_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{402, 403, 404, 405, 406});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State전직이펙트_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전직이펙트_03 : TriggerState {
            internal State전직이펙트_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 30, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastWhiteOutFast.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateQuit03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit03 : TriggerState {
            internal StateQuit03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{402, 403, 404, 405, 406});
                context.CreateMonster(spawnIds: new []{500, 501, 502}, arg2: false);
                context.MoveNpc(spawnId: 500, patrolName: "MS2PatrolData_500");
                context.MoveNpc(spawnId: 501, patrolName: "MS2PatrolData_501");
                context.MoveNpc(spawnId: 502, patrolName: "MS2PatrolData_502");
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{20002374}, questStates: new byte[]{3})) {
                    return new State칼리브요새로01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State칼리브요새로01 : TriggerState {
            internal State칼리브요새로01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State칼리브요새로02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State칼리브요새로02 : TriggerState {
            internal State칼리브요새로02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52000169, portalId: 1);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
