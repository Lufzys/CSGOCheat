using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static Memory.Memorys;

namespace DXOverlay.Classes.SDK.Managment
{
    class EngineClient
    {
        public static int ClientState => Read<int>(Game.Engine + Game.Offsets.signatures.dwClientState);
        public static Variables.Enums.SignOnState SignOnState => (Variables.Enums.SignOnState)Read<int>(ClientState + Game.Offsets.signatures.dwClientState_State);
        public static bool IsInGame => SignOnState == Variables.Enums.SignOnState.FULL;
        public static int MaxPlayer => Read<int>(ClientState + Game.Offsets.signatures.dwClientState_MaxPlayer);
        public static void ForceUpdate() => Write<int>(ClientState + Game.Offsets.signatures.clientstate_delta_ticks, -1);
        public static float[] ViewMatrix => ReadMatrix<float>(Game.Client + Game.Offsets.signatures.dwViewMatrix, 16);
        public static Vector3 ViewAngles
        {
            get
            {
                return Read<Vector3>(ClientState + Game.Offsets.signatures.dwClientState_ViewAngles);
            }
            set
            {
                Write<Vector3>(ClientState + Game.Offsets.signatures.dwClientState_ViewAngles, value);
            }
        }
    }
}
