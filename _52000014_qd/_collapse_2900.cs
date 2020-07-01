namespace Maple2.Trigger._52000014_qd {
    public static class _collapse_2900 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetMesh(arg1: new[] {2900, 2901, 2902, 2903, 2904, 2905}, arg2: true, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetEffect(arg1: new[] {12900}, arg2: false);
                context.SetEffect(arg1: new[] {22900}, arg2: false);
                context.SetEffect(arg1: new[] {12901}, arg2: false);
                context.SetEffect(arg1: new[] {22901}, arg2: false);
                context.SetEffect(arg1: new[] {12902}, arg2: false);
                context.SetEffect(arg1: new[] {22902}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {9000})) {
                    context.State = new State로딩딜레이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State로딩딜레이 : TriggerState {
            internal State로딩딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State무너짐01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State무너짐01 : TriggerState {
            internal State무너짐01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetTimer(arg1: "2", arg2: 2);
                context.SetEffect(arg1: new[] {12900}, arg2: true);
                context.SetEffect(arg1: new[] {22900}, arg2: true);
                context.SetRandomMesh(arg1: new[] {2900, 2901, 2902, 2903, 2904, 2905}, arg2: false, arg3: 6,
                    arg4: 100, arg5: 200);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.State = new State카메라연출01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라연출01 : TriggerState {
            internal State카메라연출01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 2);
                context.CameraSelect(arg1: 601, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State카메라연출02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라연출02 : TriggerState {
            internal State카메라연출02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "4", arg2: 4);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3, arg2: "$52000014_QD__COLLAPSE_2900__0$");
                context.SetSkip(arg1: "카메라연출03");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    context.State = new State카메라연출03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라연출03 : TriggerState {
            internal State카메라연출03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 3);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraSelect(arg1: 601, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.State = new State무너짐02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State무너짐02 : TriggerState {
            internal State무너짐02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$52000014_QD__COLLAPSE_2900__1$", arg3: 4000, arg4: "0");
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {9002})) {
                    context.State = new State무너짐03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State무너짐03 : TriggerState {
            internal State무너짐03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "10", arg2: 5);
                context.SetEffect(arg1: new[] {12901}, arg2: true);
                context.SetEffect(arg1: new[] {22901}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "10")) {
                    context.State = new State무너짐04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State무너짐04 : TriggerState {
            internal State무너짐04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "10", arg2: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "10")) {
                    context.State = new State무너짐05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State무너짐05 : TriggerState {
            internal State무너짐05(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {9003})) {
                    context.State = new State반응안내01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State반응안내01 : TriggerState {
            internal State반응안내01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "20", arg2: 4);
                context.SetEffect(arg1: new[] {12902}, arg2: true);
                context.SetEffect(arg1: new[] {22902}, arg2: true);
                context.SetEventUI(arg1: 1, arg2: "$52000014_QD__COLLAPSE_2900__2$", arg3: 4000, arg4: "0");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "20")) {
                    context.State = new State줍기안내01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State줍기안내01 : TriggerState {
            internal State줍기안내01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$52000014_QD__COLLAPSE_2900__3$", arg3: 4000, arg4: "0");
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {9004}, arg2: new[] {50001250},
                    arg3: new byte[] {2})) {
                    context.State = new State포털생성01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9004}, arg2: new[] {50001251},
                    arg3: new byte[] {2})) {
                    context.State = new State포털생성01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9004}, arg2: new[] {50001252},
                    arg3: new byte[] {2})) {
                    context.State = new State포털생성01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9004}, arg2: new[] {50001253},
                    arg3: new byte[] {2})) {
                    context.State = new State포털생성01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9004}, arg2: new[] {50001254},
                    arg3: new byte[] {2})) {
                    context.State = new State포털생성01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9004}, arg2: new[] {50001255},
                    arg3: new byte[] {2})) {
                    context.State = new State포털생성01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9004}, arg2: new[] {50001256},
                    arg3: new byte[] {2})) {
                    context.State = new State포털생성01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9004}, arg2: new[] {50001257},
                    arg3: new byte[] {2})) {
                    context.State = new State포털생성01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9004}, arg2: new[] {50001258},
                    arg3: new byte[] {2})) {
                    context.State = new State포털생성01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9004}, arg2: new[] {50001259},
                    arg3: new byte[] {2})) {
                    context.State = new State포털생성01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9004}, arg2: new[] {50001370},
                    arg3: new byte[] {2})) {
                    context.State = new State포털생성01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9004}, arg2: new[] {50001371},
                    arg3: new byte[] {2})) {
                    context.State = new State포털생성01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9004}, arg2: new[] {50001250},
                    arg3: new byte[] {3})) {
                    context.State = new State포털생성01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9004}, arg2: new[] {50001251},
                    arg3: new byte[] {3})) {
                    context.State = new State포털생성01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9004}, arg2: new[] {50001252},
                    arg3: new byte[] {3})) {
                    context.State = new State포털생성01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9004}, arg2: new[] {50001253},
                    arg3: new byte[] {3})) {
                    context.State = new State포털생성01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9004}, arg2: new[] {50001254},
                    arg3: new byte[] {3})) {
                    context.State = new State포털생성01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9004}, arg2: new[] {50001255},
                    arg3: new byte[] {3})) {
                    context.State = new State포털생성01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9004}, arg2: new[] {50001256},
                    arg3: new byte[] {3})) {
                    context.State = new State포털생성01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9004}, arg2: new[] {50001257},
                    arg3: new byte[] {3})) {
                    context.State = new State포털생성01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9004}, arg2: new[] {50001258},
                    arg3: new byte[] {3})) {
                    context.State = new State포털생성01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9004}, arg2: new[] {50001259},
                    arg3: new byte[] {3})) {
                    context.State = new State포털생성01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9004}, arg2: new[] {50001370},
                    arg3: new byte[] {3})) {
                    context.State = new State포털생성01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9004}, arg2: new[] {50001371},
                    arg3: new byte[] {3})) {
                    context.State = new State포털생성01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State포털생성01 : TriggerState {
            internal State포털생성01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {12900}, arg2: false);
                context.SetEffect(arg1: new[] {22900}, arg2: false);
                context.SetEffect(arg1: new[] {12901}, arg2: false);
                context.SetEffect(arg1: new[] {22901}, arg2: false);
                context.SetEffect(arg1: new[] {12902}, arg2: false);
                context.SetEffect(arg1: new[] {22902}, arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}