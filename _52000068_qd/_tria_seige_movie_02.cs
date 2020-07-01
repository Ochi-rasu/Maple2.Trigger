using System;

namespace Maple2.Trigger._52000068_qd {
    public static class _tria_seige_movie_02 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State연출페이즈2검사(context);

        private class State연출페이즈2검사 : TriggerState {
            internal State연출페이즈2검사(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {20002264}, arg2: new int[] {20002264},
                    arg3: new byte[] {3})) {
                    context.State = new State연출페이즈2시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출페이즈2시작 : TriggerState {
            internal State연출페이즈2시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "Quit", arg2: "exit");
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.MoveUser(arg1: 52000068, arg2: 3);
                context.CreateMonster(
                    arg1: new int[] {10024, 10025, 10026, 10027, 10028, 10029, 10030, 10031, 10032, 10033, 10034},
                    arg2: false);
                context.CreateMonster(arg1: new int[] {13000, 13001, 13002, 13003, 13004, 13005, 13006, 13007},
                    arg2: false);
                context.DestroyMonster(arg1: new int[] {11000, 11001, 11002, 11003, 11004, 11005, 11006, 11007},
                    arg2: false);
                context.SetVisibleBreakableObject(
                    arg1: new int[] {5000, 5002, 5003, 5004, 5005, 5006, 5007, 5008, 5009, 5010, 5011, 5012},
                    arg2: false);
                context.SetSound(arg1: 90001, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State연출페이즈2대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출페이즈2대사01 : TriggerState {
            internal State연출페이즈2대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
                context.CameraSelectPath(arg1: new int[] {15000, 15001}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11001966, arg3: "$52000068_QD__TRIA_SEIGE_MOVIE_02__0$",
                    arg4: 7);
                context.SetSkip(arg1: "연출페이즈2대사01스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State연출페이즈2대사01스킵(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출페이즈2대사01스킵 : TriggerState {
            internal State연출페이즈2대사01스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State연출페이즈2대사02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출페이즈2대사02 : TriggerState {
            internal State연출페이즈2대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001966, arg3: "$52000068_QD__TRIA_SEIGE_MOVIE_02__1$",
                    arg4: 7);
                context.SetSkip(arg1: "연출페이즈2대사02스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State연출페이즈2대사02스킵(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출페이즈2대사02스킵 : TriggerState {
            internal State연출페이즈2대사02스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State연출페이즈2대사03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출페이즈2대사03 : TriggerState {
            internal State연출페이즈2대사03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {15002, 15003}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11001901, arg3: "$52000068_QD__TRIA_SEIGE_MOVIE_02__2$",
                    arg4: 7);
                context.SetSkip(arg1: "연출페이즈2대사03스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State연출페이즈2대사03스킵(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출페이즈2대사03스킵 : TriggerState {
            internal State연출페이즈2대사03스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State연출페이즈2대사04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출페이즈2대사04 : TriggerState {
            internal State연출페이즈2대사04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {15004}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11001961, arg3: "$52000068_QD__TRIA_SEIGE_MOVIE_02__3$",
                    arg4: 7);
                context.SetSkip(arg1: "연출페이즈2대사04스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State연출페이즈2대사04스킵(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출페이즈2대사04스킵 : TriggerState {
            internal State연출페이즈2대사04스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State연출페이즈2대사04b(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출페이즈2대사04b : TriggerState {
            internal State연출페이즈2대사04b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {15005, 15006}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11001972, arg3: "$52000068_QD__TRIA_SEIGE_MOVIE_02__4$",
                    arg4: 7);
                context.SetSkip(arg1: "연출페이즈2대사04b스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new State연출페이즈2대사04b스킵(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출페이즈2대사04b스킵 : TriggerState {
            internal State연출페이즈2대사04b스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State연출페이즈2대사05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출페이즈2대사05 : TriggerState {
            internal State연출페이즈2대사05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {15007}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11001972, arg3: "$52000068_QD__TRIA_SEIGE_MOVIE_02__5$",
                    arg4: 7);
                context.SetSkip(arg1: "연출페이즈2대사05스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new State연출페이즈2대사05스킵(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출페이즈2대사05스킵 : TriggerState {
            internal State연출페이즈2대사05스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State연출페이즈2대사05b(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출페이즈2대사05b : TriggerState {
            internal State연출페이즈2대사05b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {15100, 15101}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11001970, arg3: "$52000068_QD__TRIA_SEIGE_MOVIE_02__17$",
                    arg4: 7);
                context.SetSkip(arg1: "연출페이즈2대사05b스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new State연출페이즈2대사05b스킵(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출페이즈2대사05b스킵 : TriggerState {
            internal State연출페이즈2대사05b스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State연출페이즈2대사06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출페이즈2대사06 : TriggerState {
            internal State연출페이즈2대사06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {15102, 15103}, arg2: false);
                context.AddCinematicTalk(npcID: 11000075, illustID: "Ereb_serious",
                    msg: "$52000068_QD__TRIA_SEIGE_MOVIE_02__6$", duration: 7000, align: "center");
                context.SetSkip(arg1: "연출페이즈2대사06스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new State연출페이즈2대사06스킵(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출페이즈2대사06스킵 : TriggerState {
            internal State연출페이즈2대사06스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State연출페이즈2대사07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출페이즈2대사07 : TriggerState {
            internal State연출페이즈2대사07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {15104, 15105}, arg2: false);
                context.MoveNpc(arg1: 13000, arg2: "MS2PatrolData_top_ereb_go");
                context.AddCinematicTalk(npcID: 11000075, illustID: "Ereb_serious",
                    msg: "$52000068_QD__TRIA_SEIGE_MOVIE_02__7$", duration: 7000, align: "center");
                context.SetSkip(arg1: "연출페이즈2대사07스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new State연출페이즈2대사07스킵(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출페이즈2대사07스킵 : TriggerState {
            internal State연출페이즈2대사07스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State연출페이즈2대사08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출페이즈2대사08 : TriggerState {
            internal State연출페이즈2대사08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {15106}, arg2: false);
                context.AddCinematicTalk(npcID: 11000075, illustID: "Ereb_sad",
                    msg: "$52000068_QD__TRIA_SEIGE_MOVIE_02__8$", duration: 7000, align: "center");
                context.SetSkip(arg1: "연출페이즈2대사08스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State연출페이즈2대사08스킵(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출페이즈2대사08스킵 : TriggerState {
            internal State연출페이즈2대사08스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State연출페이즈2대사09(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출페이즈2대사09 : TriggerState {
            internal State연출페이즈2대사09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {15107, 15108}, arg2: false);
                context.AddCinematicTalk(npcID: 11000075, illustID: "Ereb_closeEye",
                    msg: "$52000068_QD__TRIA_SEIGE_MOVIE_02__9$", duration: 7000, align: "center");
                context.SetSkip(arg1: "연출페이즈2대사09스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new State연출페이즈2대사09스킵(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출페이즈2대사09스킵 : TriggerState {
            internal State연출페이즈2대사09스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State연출페이즈2대사10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출페이즈2대사10 : TriggerState {
            internal State연출페이즈2대사10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11000075, illustID: "Ereb_serious",
                    msg: "$52000068_QD__TRIA_SEIGE_MOVIE_02__10$", duration: 7000, align: "center");
                context.SetSkip(arg1: "연출페이즈2대사10스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new State연출페이즈2대사10스킵(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출페이즈2대사10스킵 : TriggerState {
            internal State연출페이즈2대사10스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State연출페이즈2대사11(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출페이즈2대사11 : TriggerState {
            internal State연출페이즈2대사11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {15109}, arg2: false);
                context.AddCinematicTalk(npcID: 11000075, illustID: "Ereb_closeEye",
                    msg: "$52000068_QD__TRIA_SEIGE_MOVIE_02__11$", duration: 7000, align: "center");
                context.SetSkip(arg1: "연출페이즈2대사11스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new State연출페이즈2대사11스킵(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출페이즈2대사11스킵 : TriggerState {
            internal State연출페이즈2대사11스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State연출페이즈2대사12(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출페이즈2대사12 : TriggerState {
            internal State연출페이즈2대사12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {15110}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11001973, arg3: "$52000068_QD__TRIA_SEIGE_MOVIE_02__18$",
                    arg4: 7);
                context.SetSkip(arg1: "연출페이즈2대사12스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new State연출페이즈2대사12스킵(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출페이즈2대사12스킵 : TriggerState {
            internal State연출페이즈2대사12스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State연출페이즈2대사13(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출페이즈2대사13 : TriggerState {
            internal State연출페이즈2대사13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {15111, 15112}, arg2: false);
                context.AddCinematicTalk(npcID: 11000075, illustID: "Ereb_serious",
                    msg: "$52000068_QD__TRIA_SEIGE_MOVIE_02__12$", duration: 7000, align: "center");
                context.SetSkip(arg1: "연출페이즈2대사13스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new State연출페이즈2대사13스킵(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출페이즈2대사13스킵 : TriggerState {
            internal State연출페이즈2대사13스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State연출페이즈2대사14(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출페이즈2대사14 : TriggerState {
            internal State연출페이즈2대사14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11000075, illustID: "Ereb_serious",
                    msg: "$52000068_QD__TRIA_SEIGE_MOVIE_02__13$", duration: 7000, align: "center");
                context.SetSkip(arg1: "연출페이즈2대사14스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State연출페이즈2대사14스킵(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출페이즈2대사14스킵 : TriggerState {
            internal State연출페이즈2대사14스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State연출페이즈2대사15(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출페이즈2대사15 : TriggerState {
            internal State연출페이즈2대사15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {15113, 15114}, arg2: false);
                context.MoveNpc(arg1: 13000, arg2: "MS2PatrolData_top_ereb_back");
                context.AddCinematicTalk(npcID: 11000075, illustID: "Ereb_closeEye",
                    msg: "$52000068_QD__TRIA_SEIGE_MOVIE_02__14$", duration: 7000, align: "center");
                context.SetSkip(arg1: "연출페이즈2대사15스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State연출페이즈2대사15스킵(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출페이즈2대사15스킵 : TriggerState {
            internal State연출페이즈2대사15스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State연출페이즈2대사16(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출페이즈2대사16 : TriggerState {
            internal State연출페이즈2대사16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11000075, illustID: "Ereb_closeEye",
                    msg: "$52000068_QD__TRIA_SEIGE_MOVIE_02__15$", duration: 7000, align: "center");
                context.SetSkip(arg1: "연출페이즈2대사16스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State연출페이즈2대사16스킵(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출페이즈2대사16스킵 : TriggerState {
            internal State연출페이즈2대사16스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State연출페이즈2대사17(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출페이즈2대사17 : TriggerState {
            internal State연출페이즈2대사17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {15115, 15116}, arg2: false);
                context.AddCinematicTalk(npcID: 11000075, illustID: "Ereb_serious",
                    msg: "$52000068_QD__TRIA_SEIGE_MOVIE_02__16$", duration: 7000, align: "center");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State페이드아웃(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State페이드아웃 : TriggerState {
            internal State페이드아웃(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeOut.xml");
                context.RemoveCinematicTalk();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new State페이드아웃_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State페이드아웃_1 : TriggerState {
            internal State페이드아웃_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.MoveUser(arg1: 02000001, arg2: 17);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}