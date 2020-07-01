using System;

namespace Maple2.Trigger._02000244_bf {
    public static class _lever {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {2003}, arg2: false);
                context.SetMesh(arg1: new int[] {899}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10000303}, arg2: 1);
                context.SetInteractObject(arg1: new int[] {10000302}, arg2: 1);
                context.SetInteractObject(arg1: new int[] {10000301}, arg2: 1);
                context.SetMesh(arg1: new int[] {801, 802, 803, 804}, arg2: false);
                context.SetMesh(arg1: new int[] {805, 806, 807, 808}, arg2: true);
                context.SetMesh(arg1: new int[] {809, 810, 811, 812}, arg2: true);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000303}, arg2: 0)) {
                    context.State = new State1단계(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1단계 : TriggerState {
            internal State1단계(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000302}, arg2: 0)) {
                    context.State = new State2단계(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2단계 : TriggerState {
            internal State2단계(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000301}, arg2: 0)) {
                    context.State = new State오픈(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오픈 : TriggerState {
            internal State오픈(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelectPath(arg1: new int[] {8001, 8002}, arg2: true);
                context.SetEffect(arg1: new int[] {2003}, arg2: true);
                context.SetMesh(arg1: new int[] {801, 802, 803, 804}, arg2: true);
                context.SetMesh(arg1: new int[] {805, 806, 807, 808}, arg2: false);
                context.SetMesh(arg1: new int[] {809, 810, 811, 812}, arg2: false);
                context.SetTimer(arg1: "1", arg2: 180);
                context.SetMesh(
                    arg1: new int[] {
                        2101, 2102, 2103, 2104, 2105, 2106, 2107, 2108, 2109, 2110, 2111, 2112, 2113, 2114, 2115, 2116,
                        2117, 2118, 2119, 2120, 2121, 2122, 2123, 2124, 2125, 2126, 2127, 2128, 2129, 2130, 2131, 2132,
                        2133, 2134, 2135, 2136, 2137, 2138, 2139, 2140, 2141, 2142, 2143, 2144, 2145, 2146, 2147, 2148,
                        2149, 2150, 2151, 2152, 2153, 2154, 2155, 2156, 2157, 2158, 2159, 2160, 2161, 2162, 2163, 2164,
                        2165, 2166, 2167, 2168, 2169, 2170, 2171, 2172, 2173, 2174, 2175, 2176, 2177, 2178, 2179, 2180,
                        2181, 2182, 2183, 2184, 2185, 2186, 2187, 2188, 2189, 2190, 2191, 2192, 2193, 2194, 2195, 2196,
                        2197, 2198, 2199
                    }, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new Stateend(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetMesh(
                    arg1: new int[] {
                        2101, 2102, 2103, 2104, 2105, 2106, 2107, 2108, 2109, 2110, 2111, 2112, 2113, 2114, 2115, 2116,
                        2117, 2118, 2119, 2120, 2121, 2122, 2123, 2124, 2125, 2126, 2127, 2128, 2129, 2130, 2131, 2132,
                        2133, 2134, 2135, 2136, 2137, 2138, 2139, 2140, 2141, 2142, 2143, 2144, 2145, 2146, 2147, 2148,
                        2149, 2150, 2151, 2152, 2153, 2154, 2155, 2156, 2157, 2158, 2159, 2160, 2161, 2162, 2163, 2164,
                        2165, 2166, 2167, 2168, 2169, 2170, 2171, 2172, 2173, 2174, 2175, 2176, 2177, 2178, 2179, 2180,
                        2181, 2182, 2183, 2184, 2185, 2186, 2187, 2188, 2189, 2190, 2191, 2192, 2193, 2194, 2195, 2196,
                        2197, 2198, 2199
                    }, arg2: true);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }
        }

        private class Stateend : TriggerState {
            internal Stateend(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}