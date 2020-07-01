namespace Maple2.Trigger._02000410_bf {
    public static class _popupcinema {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserCount(boxId: 750) == 1) {
                    context.State = new State시작연출준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작연출준비 : TriggerState {
            internal State시작연출준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new State전투시작01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투시작01 : TriggerState {
            internal State전투시작01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11003533, illust: "Bliche_nomal", duration: 5000,
                    script: "$02000410_BF__PopUpCinema__0$", voice: @"ko/Npc/00002157");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State전투시작02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투시작02 : TriggerState {
            internal State전투시작02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: "movie", usm: @"Common/WorldInvasionScene1.usm", duration: 0);
                context.SideNpcTalk(npcId: 11003536, illust: "Neirin_normal", duration: 5000,
                    script: "$02000410_BF__PopUpCinema__1$", voice: @"ko/Npc/00002166");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State전투시작03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투시작03 : TriggerState {
            internal State전투시작03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11003795, illust: "infernog_nomal", duration: 5000,
                    script: "$02000410_BF__PopUpCinema__2$", voice: @"ko/Monster/60000724");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State전투시작04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투시작04 : TriggerState {
            internal State전투시작04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11003795, illust: "infernog_nomal", duration: 5000,
                    script: "$02000410_BF__PopUpCinema__3$", voice: @"ko/Monster/60000725");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State전투시작05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투시작05 : TriggerState {
            internal State전투시작05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11000144, illust: "tristan_normal", duration: 5000,
                    script: "$02000410_BF__PopUpCinema__4$", voice: @"ko/Npc/00002172");
            }

            public override void Execute() {
                if (context.GetDungeonPlayTime() == 240) {
                    context.State = new State두번째팝업영상출력(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째팝업영상출력 : TriggerState {
            internal State두번째팝업영상출력(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: "movie", usm: @"Common/WorldInvasionScene2.usm", duration: 0);
                context.SideNpcTalk(npcId: 11003536, illust: "Neirin_normal", duration: 5000,
                    script: "$02000410_BF__PopUpCinema__5$", voice: @"ko/Npc/00002178");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State두번째팝업영상출력02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째팝업영상출력02 : TriggerState {
            internal State두번째팝업영상출력02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11003533, illust: "Bliche_nomal", duration: 5000,
                    script: "$02000410_BF__PopUpCinema__6$", voice: @"ko/Npc/00002173");
            }

            public override void Execute() {
                if (context.GetDungeonPlayTime() == 480) {
                    context.State = new State세번째팝업영상출력(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State세번째팝업영상출력 : TriggerState {
            internal State세번째팝업영상출력(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11003536, illust: "Neirin_normal", duration: 5000,
                    script: "$02000410_BF__PopUpCinema__7$", voice: @"ko/Npc/00002179");
                context.SideNpcTalk(type: "movie", usm: @"Common/WorldInvasionScene3.usm", duration: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State세번째팝업영상출력02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State세번째팝업영상출력02 : TriggerState {
            internal State세번째팝업영상출력02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11003536, illust: "Bliche_nomal", duration: 5000,
                    script: "$02000410_BF__PopUpCinema__8$", voice: @"ko/Npc/00002174");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State세번째팝업영상출력03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State세번째팝업영상출력03 : TriggerState {
            internal State세번째팝업영상출력03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11003536, illust: "Neirin_normal", duration: 5000,
                    script: "$02000410_BF__PopUpCinema__9$", voice: @"ko/Npc/00002180");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State세번째팝업영상출력04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State세번째팝업영상출력04 : TriggerState {
            internal State세번째팝업영상출력04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11003533, illust: "Bliche_nomal", duration: 5000,
                    script: "$02000410_BF__PopUpCinema__10$", voice: @"ko/Npc/00002175");
            }

            public override void Execute() {
                if (context.GetDungeonPlayTime() == 720) {
                    context.State = new State네번째팝업영상출력(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State네번째팝업영상출력 : TriggerState {
            internal State네번째팝업영상출력(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: "movie", usm: @"Common/WorldInvasionScene4.usm", duration: 0);
                context.SideNpcTalk(npcId: 11003536, illust: "Neirin_normal", duration: 5000,
                    script: "$02000410_BF__PopUpCinema__11$", voice: @"ko/Npc/00002181");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State네번째팝업영상출력02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State네번째팝업영상출력02 : TriggerState {
            internal State네번째팝업영상출력02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11003533, illust: "Bliche_nomal", duration: 5000,
                    script: "$02000410_BF__PopUpCinema__12$", voice: @"ko/Npc/00002176");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new State트리거종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트리거종료 : TriggerState {
            internal State트리거종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}