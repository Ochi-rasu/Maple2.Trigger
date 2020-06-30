using System;
using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02010049_bf {
    public static class _main01 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5000}, arg2: false);
                context.SetMesh(arg1: new int[] {10000}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011, 2012, 2013, 2014, 2015, 2016
                    }, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {20000}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {30000}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015, 3016
                    }, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {9990, 9991, 9992, 9993}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014, 1015, 1016,
                        1017
                    }, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {7000, 7001, 7002, 7003}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.CheckUser()) {
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
                context.CreateMonster(arg1: new int[] {102, 103, 104, 105, 107, 108}, arg2: false);
                context.CreateMonster(arg1: new int[] {201, 202, 203, 204, 205, 206}, arg2: false);
                context.ShowGuideSummary(entityID: 20104901, textID: 20104901, duration: 3000);
                context.PlaySystemSoundInBox(arg2: "System_Space_PopUp_01");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateCameraWalk01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraWalk01 : TriggerState {
            internal StateCameraWalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 600, arg2: true);
                context.SetSkip(arg1: "CameraWalk02");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new StateCameraWalk02(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }
        }

        private class StateCameraWalk02 : TriggerState {
            internal StateCameraWalk02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 600, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateGateOpen01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGateOpen01 : TriggerState {
            internal StateGateOpen01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {9990, 9991, 9992, 9993}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014, 1015, 1016,
                        1017
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 10f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "9001")) {
                    context.State = new State전투지역01시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투지역01시작 : TriggerState {
            internal State전투지역01시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityID: 20104902, textID: 20104902, duration: 5000);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {102, 103, 104, 105, 107, 108})) {
                    context.State = new State전투지역02대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투지역02대기 : TriggerState {
            internal State전투지역02대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {10000}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011, 2012, 2013, 2014, 2015, 2016
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 10f);
                context.PlaySystemSoundInBox(arg2: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityID: 20104903, textID: 20104903, duration: 5000);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "9002")) {
                    context.State = new State전투지역02시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투지역02시작 : TriggerState {
            internal State전투지역02시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityID: 20104902, textID: 20104902, duration: 5000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State전투지역02추가(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투지역02추가 : TriggerState {
            internal State전투지역02추가(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityID: 20104904, textID: 20104904, duration: 5000);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {201, 202, 203, 204, 205, 206})) {
                    context.State = new State전투지역03대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투지역03대기 : TriggerState {
            internal State전투지역03대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {20000}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015, 3016
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 10f);
                context.PlaySystemSoundInBox(arg2: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityID: 20104903, textID: 20104903, duration: 5000);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "9003")) {
                    context.State = new State전투지역03시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투지역03시작 : TriggerState {
            internal State전투지역03시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {399}, arg2: false);
                context.CreateMonster(arg1: new int[] {302, 303, 304, 305, 306, 307}, arg2: false);
                context.CreateMonster(arg1: new int[] {309}, arg2: false);
                context.PlaySystemSoundInBox(arg2: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityID: 20104902, textID: 20104902, duration: 5000);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {302, 303, 304, 305, 306, 307})) {
                    context.State = new State전투지역04시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투지역04시작 : TriggerState {
            internal State전투지역04시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityID: 20104904, textID: 20104904, duration: 5000);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {309})) {
                    context.State = new State퇴장연출01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퇴장연출01 : TriggerState {
            internal State퇴장연출01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {399});
                context.CreateMonster(arg1: new int[] {400}, arg2: false);
                context.MoveNpc(arg1: 400, arg2: "MS2PatrolData_399");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 601, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State퇴장연출02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퇴장연출02 : TriggerState {
            internal State퇴장연출02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5000}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State퇴장연출03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퇴장연출03 : TriggerState {
            internal State퇴장연출03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 601, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 8000, arg2: new int[] {400})) {
                    context.State = new State다리생성01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다리생성01 : TriggerState {
            internal State다리생성01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {400});
                context.SetMesh(arg1: new int[] {30000}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetRandomMesh(arg1: new int[] {7000, 7001, 7002, 7003}, arg2: true, arg3: 4, arg4: 100,
                    arg5: 100);
                context.ShowGuideSummary(entityID: 20104905, textID: 20104905, duration: 6000);
                context.PlaySystemSoundInBox(arg2: "System_Space_PopUp_01");
            }

            public override void Execute() {
                if (!context.UserDetected(arg1: "9010")) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}