using System;

namespace Maple2.Trigger._02000536_bf {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Stateidle(context);

        private class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.CreateMonster(arg1: new int[] {501, 502, 504, 505, 506, 507, 508, 509, 510, 511}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10003147}, arg2: 0);
                context.SetMesh(arg1: new int[] {9999}, arg2: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {701}, arg2: 0)) {
                    context.State = new Stateready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateready : TriggerState {
            internal Stateready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetSceneSkip();
                context.CreateMonster(arg1: new int[] {102}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statestart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart : TriggerState {
            internal Statestart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "전투시작", arg2: "nextState");
                context.CameraSelectPath(arg1: new int[] {7000, 7003}, arg2: false);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.ShowCaption(type: "VerticalCaption", title: "$02000536_BF__MAIN__0$",
                    desc: "$02000536_BF__MAIN__1$", align: "centerRight", offsetRateX: 0f, offsetRateY: 0f,
                    duration: 3000, scale: 2f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State하렌인사(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State하렌인사 : TriggerState {
            internal State하렌인사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {7003, 7001}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 102, arg2: "Bore_A", arg3: 5000f);
                context.AddCinematicTalk(npcID: 23300001, msg: "$02000536_BF__MAIN__2$", align: "center",
                    duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    context.State = new State하렌인사2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State하렌인사2 : TriggerState {
            internal State하렌인사2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 102, arg2: "Attack_01_E,Attack_01_B");
                context.AddCinematicTalk(npcID: 23300001, msg: "$02000536_BF__MAIN__3$", align: "center",
                    duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State전투시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투시작 : TriggerState {
            internal State전투시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 1f);
                context.SetEventUI(arg1: 1, arg2: "$02000536_BF__MAIN__4$", arg3: new int[] {3000});
                context.CreateMonster(arg1: new int[] {101}, arg2: false);
                context.DestroyMonster(arg1: new int[] {102});
            }

            public override void Execute() {
                if (context.CheckNpcHp(compare: "lowerEqual", value: 70, spawnPointId: 101, isRelative: "true")) {
                    context.State = new State메이드군단을스폰(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State메이드군단을스폰 : TriggerState {
            internal State메이드군단을스폰(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {301, 302, 303, 304}, arg2: false);
                context.SideNpcTalk(npcID: 23300001, illust: "Haren_serious", duration: 4000,
                    script: "$02000536_BF__MAIN__5$");
            }

            public override void Execute() {
                if (context.CheckNpcHp(compare: "lowerEqual", value: 50, spawnPointId: 101, isRelative: "true")) {
                    context.State = new State메이드군단을스폰2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State메이드군단을스폰2 : TriggerState {
            internal State메이드군단을스폰2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {401, 402, 403, 404}, arg2: false);
            }

            public override void Execute() {
                if (context.CheckNpcHp(compare: "lowerEqual", value: 30, spawnPointId: 101, isRelative: "true")) {
                    context.State = new State몬스터사망체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터사망체크 : TriggerState {
            internal State몬스터사망체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcID: 23300001, illust: "Haren_serious", duration: 4000,
                    script: "$02000536_BF__MAIN__6$");
                context.CreateMonster(arg1: new int[] {201, 202, 203, 204}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {101})) {
                    context.State = new State던전클리어(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State던전클리어 : TriggerState {
            internal State던전클리어(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcID: 23300001, illust: "Haren_serious", duration: 3000,
                    script: "$02000536_BF__MAIN__8$");
                context.SetMesh(arg1: new int[] {9999}, arg2: false);
                context.DestroyMonster(arg1: new int[] {-1});
                context.DungeonClear();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State트리거완료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트리거완료 : TriggerState {
            internal State트리거완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {-1});
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}