using System.Numerics;
using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02000403_bf {
    public static class _main {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShadowExpeditionCloseBossGauge();
                context.SetInteractObject(arg1: new[] {12000030, 12000031, 12000032, 12000033, 12000034, 12000035, 12000036}, arg2: 1);
                context.SetMesh(arg1: new[] {1001}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {1002, 1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108, 1109, 1110, 1111, 1112, 1113, 1114, 1115, 1116, 1117, 1118, 1119, 1120, 1121, 1122, 1123, 1124, 1125, 1126, 1127, 1128, 1129, 1130, 1131, 1132, 1133, 1134, 1135, 1136, 1137, 1138, 1139, 1140, 1141, 1142, 1143, 1144, 1145, 1146, 1147, 1148, 1149, 1150, 1151, 1152, 1153, 1154, 1155, 1156, 1157, 1158, 1159, 1160, 1161, 1162, 1163, 1164, 1165, 1166, 1167, 1168, 1169, 1170, 1171, 1172, 1173, 1174, 1175, 1176, 1177, 1178, 1179, 1180, 1181, 1182, 1183, 1184, 1185, 1186, 1187, 1188, 1189, 1190, 1191, 1192, 1193, 1194, 1195, 1196, 1197, 1198, 1199, 1201, 1202, 1203, 1204, 1205, 1206, 1207, 1208, 1209, 1210, 1211, 1212, 1213, 1214, 1215, 1216, 1217, 1218, 1219, 1220}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {1801, 1802}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.CreateMonster(arg1: new[] {101, 102, 103, 104, 199}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {701})) {
                    return new _checkusercount.StateCheckUserCount(context, new StateDungeonStart(context));
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {701})) {
                    return new StateReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetSkip(state: new StateStart(context));
                context.CameraSelectPath(arg1: new[] {8100, 8101, 8102}, arg2: false);
                context.SetAmbientLight(arg1: new Vector3(120f, 120f, 120f));
                context.SetDirectionalLight(arg1: new Vector3(10f, 10f, 10f), arg2: new Vector3(0f, 0f, 0f));
                context.AddBuff(arg1: new[] {701}, arg2: 71000009, arg3: 1, arg4: false, arg5: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateStart(context);
                }

                if (context.GetShadowExpeditionPoints() >= 1000) {
                    context.ShadowExpeditionCloseBossGauge();
                    return new StateBoss_scene(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {1801, 1802}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.CameraReset(interpolationTime: 0.0f);
            }

            public override TriggerState Execute() {
                if (context.GetShadowExpeditionPoints() >= 1000) {
                    context.ShadowExpeditionCloseBossGauge();
                    return new StateBoss_scene(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new[] {105, 106, 107, 108, 109, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 150, 151, 152, 153, 154, 155, 156});
            }
        }

        private class StateBoss_scene : TriggerState {
            internal StateBoss_scene(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7999}, arg2: true);
                context.CreateMonster(arg1: new[] {1999}, arg2: false);
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetSkip(state: new StateBoss(context));
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateBoss_scene_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss_scene_02 : TriggerState {
            internal StateBoss_scene_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip(state: new StateBoss(context));
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraSelectPath(arg1: new[] {8006, 8007}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateBoss_scene_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss_scene_03 : TriggerState {
            internal StateBoss_scene_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip(state: new StateBoss(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateBoss_scene_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss_scene_04 : TriggerState {
            internal StateBoss_scene_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetSkip(state: new StateBoss(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateBoss(context);
                }

                return null;
            }

            public override void OnExit() {
                context.CameraReset(interpolationTime: 0.0f);
            }
        }

        private class StateBoss : TriggerState {
            internal StateBoss(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.CameraReset(interpolationTime: 0.0f);
                context.SetEventUI(arg1: 1, arg2: "$02000403_BF__MAIN__0$", arg3: 3000);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {1999})) {
                    return new StateDungeonClear_ready(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonClear_ready : TriggerState {
            internal StateDungeonClear_ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateDungeonClear(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonClear : TriggerState {
            internal StateDungeonClear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
                context.SetEffect(arg1: new[] {7999}, arg2: false);
                context.SetEffect(arg1: new[] {7998}, arg2: true);
                context.DungeonClear();
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}