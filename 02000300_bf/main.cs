namespace Maple2.Trigger._02000300_bf {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000585}, state: 0);
                context.SetEffect(triggerIds: new []{601}, visible: false);
                context.SetMesh(triggerIds: new []{3001, 3002, 3003, 3004, 3005}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.CreateMonster(spawnIds: new []{1001, 1002, 1003, 1004, 1099}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{101})) {
                    return new StateStartCinematicDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematicDelay : TriggerState {
            internal StateStartCinematicDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "2", seconds: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new StateStartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic : TriggerState {
            internal StateStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 301, enabled: true);
                context.SetTimer(timerId: "3", seconds: 3);
                context.SetSkip(state: new StateStopCinematic(context));
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new State트리스탄01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State트리스탄01 : TriggerState {
            internal State트리스탄01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "5", seconds: 5);
                context.SetConversation(type: 2, spawnId: 11000144, script: "$02000300_BF__MAIN__0$", arg4: 4);
                context.SetSkip(state: new StateStopCinematic(context));
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStopCinematic : TriggerState {
            internal StateStopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{301}, returnView: true);
            }

            public override TriggerState? Execute() {
                return new State완료체크(context);
            }

            public override void OnExit() { }
        }

        private class State완료체크 : TriggerState {
            internal State완료체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraSelect(triggerId: 301, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1099})) {
                    return new State또다른StartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State또다른StartCinematic : TriggerState {
            internal State또다른StartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetSkip(state: new State또다른StopCinematic(context));
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State트리스탄마무리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State트리스탄마무리 : TriggerState {
            internal State트리스탄마무리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "5", seconds: 5);
                context.SetConversation(type: 2, spawnId: 11000144, script: "$02000300_BF__MAIN__1$", arg4: 4);
                context.SetSkip(state: new State또다른StopCinematic(context));
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new State또다른StopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State또다른StopCinematic : TriggerState {
            internal State또다른StopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                return new State이동Wait(context);
            }

            public override void OnExit() { }
        }

        private class State이동Wait : TriggerState {
            internal State이동Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000585}, state: 1);
                context.ShowGuideSummary(entityId: 20002999, textId: 20002999);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000585}, arg2: 0)) {
                    context.HideGuideSummary(entityId: 20002999);
                    return new State이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이동 : TriggerState {
            internal State이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{601}, visible: true);
                context.SetTimer(timerId: "4", seconds: 4);
                context.ShowCountUI(text: "$02000300_BF__MAIN__3$", stage: 1, count: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "4")) {
                    context.MoveUser(mapId: 02000299, portalId: 2, boxId: 101);
                    return new State이동Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1800000", seconds: 1800000);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1800000")) {
                    // return new StateEnd2(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
