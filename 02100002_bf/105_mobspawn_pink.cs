namespace Maple2.Trigger._02100002_bf {
    public static class _105_mobspawn_pink {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "Gauge", value: 0);
                context.SetUserValue(key: "StopSpawn", value: 0);
                context.SetUserValue(key: "SpawnHold", value: 0);
                context.DestroyMonster(spawnIds: new []{50100, 50075, 50050, 50025, 50001, 51001, 51002, 51003});
                context.SetEffect(triggerIds: new []{5105, 5205}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Gauge") == 100) {
                    return new StateGauge100_Normal(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGauge100_Normal : TriggerState {
            internal StateGauge100_Normal(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5105}, visible: true);
                context.CreateMonster(spawnIds: new []{50100}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateGauge_SpawnRamdom(context);
                }

                if (context.GetUserValue(key: "SpawnHold") == 1) {
                    return new StateSpawnHold(context);
                }

                if (context.GetUserValue(key: "Gauge") == 75) {
                    return new StateGauge75_Normal(context);
                }

                if (context.GetUserValue(key: "StopSpawn") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGauge75_Normal : TriggerState {
            internal StateGauge75_Normal(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5105}, visible: true);
                context.CreateMonster(spawnIds: new []{50075}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateGauge_SpawnRamdom(context);
                }

                if (context.GetUserValue(key: "SpawnHold") == 1) {
                    return new StateSpawnHold(context);
                }

                if (context.GetUserValue(key: "Gauge") == 100) {
                    return new StateGauge100_Normal(context);
                }

                if (context.GetUserValue(key: "Gauge") == 50) {
                    return new StateGauge50_Normal(context);
                }

                if (context.GetUserValue(key: "StopSpawn") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGauge50_Normal : TriggerState {
            internal StateGauge50_Normal(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5105}, visible: true);
                context.CreateMonster(spawnIds: new []{50050}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateGauge_SpawnRamdom(context);
                }

                if (context.GetUserValue(key: "SpawnHold") == 1) {
                    return new StateSpawnHold(context);
                }

                if (context.GetUserValue(key: "Gauge") == 75) {
                    return new StateGauge75_Normal(context);
                }

                if (context.GetUserValue(key: "Gauge") == 25) {
                    return new StateGauge25_Normal(context);
                }

                if (context.GetUserValue(key: "StopSpawn") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGauge25_Normal : TriggerState {
            internal StateGauge25_Normal(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5105}, visible: true);
                context.CreateMonster(spawnIds: new []{50025}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateGauge_SpawnRamdom(context);
                }

                if (context.GetUserValue(key: "SpawnHold") == 1) {
                    return new StateSpawnHold(context);
                }

                if (context.GetUserValue(key: "Gauge") == 50) {
                    return new StateGauge50_Normal(context);
                }

                if (context.GetUserValue(key: "Gauge") == 1) {
                    return new StateGauge1_Normal(context);
                }

                if (context.GetUserValue(key: "StopSpawn") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGauge1_Normal : TriggerState {
            internal StateGauge1_Normal(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5105}, visible: true);
                context.CreateMonster(spawnIds: new []{50001}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateGauge_SpawnRamdom(context);
                }

                if (context.GetUserValue(key: "SpawnHold") == 1) {
                    return new StateSpawnHold(context);
                }

                if (context.GetUserValue(key: "Gauge") == 25) {
                    return new StateGauge25_Normal(context);
                }

                if (context.GetUserValue(key: "StopSpawn") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSpawnHold : TriggerState {
            internal StateSpawnHold(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "SpawnHold") == 0) {
                    return new StateBackToGaugeState(context);
                }

                if (context.GetUserValue(key: "StopSpawn") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGauge_SpawnRamdom : TriggerState {
            internal StateGauge_SpawnRamdom(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 100, description: "Normal")) {
                    return new StateSpawn_Normal(context);
                }

                if (context.RandomCondition(rate: 5, description: "Eater")) {
                    return new StateSpawn_Eater(context);
                }

                if (context.RandomCondition(rate: 10, description: "Runner")) {
                    return new StateSpawn_Runner(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSpawn_Normal : TriggerState {
            internal StateSpawn_Normal(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return new StateBackToGaugeState(context);
            }

            public override void OnExit() { }
        }

        private class StateSpawn_Eater : TriggerState {
            internal StateSpawn_Eater(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5205}, visible: true);
                context.CreateMonster(spawnIds: new []{51001}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateBackToGaugeState(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSpawn_Runner : TriggerState {
            internal StateSpawn_Runner(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5205}, visible: true);
                context.CreateMonster(spawnIds: new []{51002}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateBackToGaugeState(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBackToGaugeState : TriggerState {
            internal StateBackToGaugeState(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Gauge") == 100) {
                    return new StateGauge100_Normal(context);
                }

                if (context.GetUserValue(key: "Gauge") == 75) {
                    return new StateGauge75_Normal(context);
                }

                if (context.GetUserValue(key: "Gauge") == 50) {
                    return new StateGauge50_Normal(context);
                }

                if (context.GetUserValue(key: "Gauge") == 25) {
                    return new StateGauge25_Normal(context);
                }

                if (context.GetUserValue(key: "Gauge") == 1) {
                    return new StateGauge1_Normal(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{50100, 50075, 50050, 50025, 50001, 51001, 51002, 51003});
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
