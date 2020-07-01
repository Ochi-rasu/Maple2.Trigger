using System;
using System.Numerics;

namespace Maple2.Trigger._02020111_bf {
    public static class _lapenta_attack {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작(context);

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAmbientLight(arg1: new Vector3(183f, 189f, 201f));
                context.SetDirectionalLight(arg1: new Vector3(192f, 210f, 211f), arg2: new Vector3(170f, 170f, 170f));
            }

            public override void Execute() {
                if (context.UserValue(key: "Lapenta_Attack", value: 1)) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: "talk", npcID: 23501011, illust: "Turned_Renduebian_normal",
                    script: "$02020111_BF__LAPENTA_ATTACK__0$", duration: 3432, voice: @"ko/Npc/00002199");
                context.SetAmbientLight(arg1: new Vector3(52f, 48f, 38f));
                context.SetDirectionalLight(arg1: new Vector3(0f, 0f, 0f), arg2: new Vector3(206f, 174f, 84f));
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3432)) {
                    context.State = new State스킬발동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬발동 : TriggerState {
            internal State스킬발동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(
                    arg1: new int[] {
                        200001, 200002, 200003, 200004, 200005, 200011, 200012, 200013, 200014, 200015, 200021, 200022,
                        200023, 200024, 200025, 200031, 200032, 200033, 200034, 200035
                    }, arg2: false);
                context.SetSkill(arg1: new int[] {5001}, arg2: true);
                context.AddBuff(arg1: new int[] {101}, arg2: 62100026, arg3: 1, arg4: true);
                context.AddBuff(arg1: new int[] {1001}, arg2: 75000002, arg3: 1);
                context.AddBuff(arg1: new int[] {1002}, arg2: 75000002, arg3: 1);
                context.AddBuff(arg1: new int[] {1003}, arg2: 75000002, arg3: 1);
                context.AddBuff(arg1: new int[] {1004}, arg2: 75000002, arg3: 1);
                context.AddBuff(arg1: new int[] {1005}, arg2: 75000002, arg3: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State실패조건버프(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State실패조건버프 : TriggerState {
            internal State실패조건버프(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 900204, key: "Message", value: 1);
                context.AddBuff(arg1: new int[] {101}, arg2: 70002181, arg3: 1, arg4: true);
            }

            public override void Execute() {
                if (context.UserValue(key: "Lapenta_Attack", value: 0)) {
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}