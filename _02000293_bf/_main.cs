using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02000293_bf {
    public static class _main {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {
                    2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011, 2012, 2013, 2014, 2015, 2016,
                    2017, 2018, 2019, 2020, 2021, 2022, 2023, 2024, 2025, 2028, 2029, 2030, 2031, 2032, 2033, 2034,
                    2035, 2036
                });
                context.DestroyMonster(arg1: new[] {25000, 25001, 25002, 25003, 25004, 25005, 25006, 25007, 25008});
                context.SetInteractObject(arg1: new[] {10000509}, arg2: 1);
                context.SetInteractObject(arg1: new[] {10000504}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10000505}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10000520}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10000521}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10000522}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10000523}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10000524}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10000529}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10000530}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10000531}, arg2: 0);
                context.SetPortal(arg1: 2, arg2: true, arg3: false, arg4: true);
                context.SetMesh(arg1: new[] {510000}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3001, 3002, 3003, 3004, 3005, 3006}, arg2: true, arg3: 0, arg4: 0,
                    arg5: 0f);
            }

            public override void Execute() {
                if (context.GetUserCount() > 0) {
                    context.State = new StateLoadingDelay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelay : TriggerState {
            internal StateLoadingDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State =
                        new _checkusercount.StateCheckUserCount(context, new StateDungeonStart(context));
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 600, arg2: true);
                context.SetSkip(arg1: "CameraWalk01");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateCameraWalk01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraWalk01 : TriggerState {
            internal StateCameraWalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraSelect(arg1: 600, arg2: false);
                context.SetMesh(arg1: new[] {3001, 3002, 3003, 3004, 3005, 3006}, arg2: false, arg3: 0, arg4: 100,
                    arg5: 2f);
                context.SetSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State준비 : TriggerState {
            internal State준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20002931, textId: 20002931);
                context.CreateMonster(
                    arg1: new[] {
                        2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011, 2012, 2013, 2014, 2015, 2016,
                        2017, 2018, 2019, 2020, 2021, 2022, 2023, 2024, 2025
                    }, arg2: false);
            }

            public override void Execute() {
                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State1번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State2번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State3번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State4번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State5번생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1번생성 : TriggerState {
            internal State1번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000523}, arg2: 1);
                context.SetInteractObject(arg1: new[] {10000505}, arg2: 1);
                context.SetInteractObject(arg1: new[] {10000509}, arg2: 1);
                context.SetInteractObject(arg1: new[] {10000520}, arg2: 1);
                context.SetInteractObject(arg1: new[] {10000521}, arg2: 1);
                context.SetInteractObject(arg1: new[] {10000522}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000523}, arg2: 0)) {
                    context.State = new State1번아이템(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1번아이템 : TriggerState {
            internal State1번아이템(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 20002931);
                context.CreateMonster(arg1: new[] {25000}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 25000, arg3: "$02000293_BF__MAIN__1$", arg4: 2);
                context.CreateItem(arg1: new[] {500001});
                context.ShowGuideSummary(entityId: 20002932, textId: 20002932);
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
                context.SetTimer(arg1: "181", arg2: 181);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000509}, arg2: 0)) {
                    context.State = new State소멸대기(context);
                    return;
                }

                if (context.TimeExpired(arg1: "181")) {
                    context.State = new State소멸(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2번생성 : TriggerState {
            internal State2번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000504}, arg2: 1);
                context.SetInteractObject(arg1: new[] {10000524}, arg2: 1);
                context.SetInteractObject(arg1: new[] {10000509}, arg2: 1);
                context.SetInteractObject(arg1: new[] {10000520}, arg2: 1);
                context.SetInteractObject(arg1: new[] {10000521}, arg2: 1);
                context.SetInteractObject(arg1: new[] {10000522}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000524}, arg2: 0)) {
                    context.State = new State2번아이템(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2번아이템 : TriggerState {
            internal State2번아이템(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 20002931);
                context.CreateMonster(arg1: new[] {25001}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 25001, arg3: "$02000293_BF__MAIN__3$", arg4: 2);
                context.CreateItem(arg1: new[] {500002});
                context.ShowGuideSummary(entityId: 20002932, textId: 20002932);
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
                context.SetTimer(arg1: "181", arg2: 181);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000509}, arg2: 0)) {
                    context.State = new State소멸대기(context);
                    return;
                }

                if (context.TimeExpired(arg1: "181")) {
                    context.State = new State소멸(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3번생성 : TriggerState {
            internal State3번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000504}, arg2: 1);
                context.SetInteractObject(arg1: new[] {10000505}, arg2: 1);
                context.SetInteractObject(arg1: new[] {10000509}, arg2: 1);
                context.SetInteractObject(arg1: new[] {10000529}, arg2: 1);
                context.SetInteractObject(arg1: new[] {10000521}, arg2: 1);
                context.SetInteractObject(arg1: new[] {10000522}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000529}, arg2: 0)) {
                    context.State = new State3번아이템(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3번아이템 : TriggerState {
            internal State3번아이템(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 20002931);
                context.CreateMonster(arg1: new[] {25006}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 25006, arg3: "$02000293_BF__MAIN__13$", arg4: 2);
                context.CreateItem(arg1: new[] {500007});
                context.ShowGuideSummary(entityId: 20002932, textId: 20002932);
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
                context.SetTimer(arg1: "181", arg2: 181);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000509}, arg2: 0)) {
                    context.State = new State소멸대기(context);
                    return;
                }

                if (context.TimeExpired(arg1: "181")) {
                    context.State = new State소멸(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State4번생성 : TriggerState {
            internal State4번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000504}, arg2: 1);
                context.SetInteractObject(arg1: new[] {10000505}, arg2: 1);
                context.SetInteractObject(arg1: new[] {10000509}, arg2: 1);
                context.SetInteractObject(arg1: new[] {10000520}, arg2: 1);
                context.SetInteractObject(arg1: new[] {10000530}, arg2: 1);
                context.SetInteractObject(arg1: new[] {10000522}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000530}, arg2: 0)) {
                    context.State = new State4번아이템(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State4번아이템 : TriggerState {
            internal State4번아이템(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 20002931);
                context.CreateMonster(arg1: new[] {25007}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 25007, arg3: "$02000293_BF__MAIN__15$", arg4: 2);
                context.CreateItem(arg1: new[] {500008});
                context.ShowGuideSummary(entityId: 20002932, textId: 20002932);
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
                context.SetTimer(arg1: "181", arg2: 181);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000509}, arg2: 0)) {
                    context.State = new State소멸대기(context);
                    return;
                }

                if (context.TimeExpired(arg1: "181")) {
                    context.State = new State소멸(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State5번생성 : TriggerState {
            internal State5번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000504}, arg2: 1);
                context.SetInteractObject(arg1: new[] {10000505}, arg2: 1);
                context.SetInteractObject(arg1: new[] {10000509}, arg2: 1);
                context.SetInteractObject(arg1: new[] {10000520}, arg2: 1);
                context.SetInteractObject(arg1: new[] {10000521}, arg2: 1);
                context.SetInteractObject(arg1: new[] {10000531}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000531}, arg2: 0)) {
                    context.State = new State5번아이템(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State5번아이템 : TriggerState {
            internal State5번아이템(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 20002931);
                context.CreateMonster(arg1: new[] {25008}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 25008, arg3: "$02000293_BF__MAIN__17$", arg4: 2);
                context.CreateItem(arg1: new[] {500009});
                context.ShowGuideSummary(entityId: 20002932, textId: 20002932);
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
                context.SetTimer(arg1: "181", arg2: 181);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000509}, arg2: 0)) {
                    context.State = new State소멸대기(context);
                    return;
                }

                if (context.TimeExpired(arg1: "181")) {
                    context.State = new State소멸(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State소멸대기 : TriggerState {
            internal State소멸대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {510000}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State소멸2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State소멸 : TriggerState {
            internal State소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 20002932);
                context.DestroyMonster(arg1: new[] {
                    2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011, 2012, 2013, 2014, 2015, 2016,
                    2017, 2018, 2019, 2020, 2021, 2022, 2023, 2024, 2025, 2028, 2029, 2030, 2031, 2032, 2033, 2034,
                    2035, 2036
                });
                context.DestroyMonster(arg1: new[] {25000, 25001, 25002, 25003, 25004, 25005, 25006, 25007, 25008});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State소멸2 : TriggerState {
            internal State소멸2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 20002932);
                context.DestroyMonster(arg1: new[] {
                    2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011, 2012, 2013, 2014, 2015, 2016,
                    2017, 2018, 2019, 2020, 2021, 2022, 2023, 2024, 2025, 2028, 2029, 2030, 2031, 2032, 2033, 2034,
                    2035, 2036
                });
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}