using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using GTA;

namespace MoveImprove.net
{
    public class Main : Script
    {
        public static Keys ClimbDownKey;
        public static Keys JumpFromLedgeKey;
        public static bool Alt180Turn;
        public static bool SprintToVehicles;
        public static bool ForceRun;
        public static bool ExtremeClimbing;
        public static bool ClimbDown = false;
        public static bool JumpFromLedges = false;
        public static bool FasterJacking;
        public static float CombatRollSpeed = 1.0f;
        public static float PickupObjectSpeed = 1.0f;
        public static float ClimbAndShimmySpeed = 1.0f;
        public static float PeekFromCoverSpeed = 1.0f;
        public static float EnterExitVehSpeed = 1.0f;
        public static float CrouchingSpeed = 1.0f;
        public static Vector3 plyrPos = new Vector3(0, 0, 0);

        public Main()
        {
            LoadINI();
            Tick += Main_Tick;
        }
        private void Main_Tick(object sender, EventArgs e)
        {
            FasterJackingScript.Tick();
            FastAnims.Tick();
            AdvancedClimbing.Tick();
            ForceRunning.Tick();
            AdvancedClimbing.Tick();
        }
        public void LoadINI()
        {
            SettingsFile ini = SettingsFile.Open(Path.Combine("scripts", "MoveImprove.ini"));
            ini.Load();
            SprintToVehicles = ini.GetValueBool("SprintToVehicles", "MAIN", false);
            ForceRun = ini.GetValueBool("ForceRun", "MAIN", false);
            FasterJacking = ini.GetValueBool("FasterJacking", "MAIN", false);
            CombatRollSpeed = ini.GetValueFloat("CombatRoll", "ANIMATION SPEED", 1.0f);
            PickupObjectSpeed = ini.GetValueFloat("PickupObject", "ANIMATION SPEED", 1.0f);
            ClimbAndShimmySpeed = ini.GetValueFloat("ClimbAndShimmy", "ANIMATION SPEED", 1.0f);
            PeekFromCoverSpeed = ini.GetValueFloat("PeekFromCover", "ANIMATION SPEED", 1.0f);
            EnterExitVehSpeed = ini.GetValueFloat("EnterandExitVehicles", "ANIMATION SPEED", 1.0f);
            CrouchingSpeed = ini.GetValueFloat("Crouching", "ANIMATION SPEED", 1.0f);
            Alt180Turn = ini.GetValueBool("Alt180Turn", "EXPERIMENTAL FEATURES", false);
            ExtremeClimbing = ini.GetValueBool("ExtremeClimbing", "EXPERIMENTAL FEATURES", false);
            ClimbDown = ini.GetValueBool("ClimbDown", "EXPERIMENTAL FEATURES", false);
            ClimbDownKey = ini.GetValueKey("ClimbDownKey", "EXPERIMENTAL FEATURES", Keys.J);
            JumpFromLedges = ini.GetValueBool("JumpFromLedges", "EXPERIMENTAL FEATURES", false);
            JumpFromLedgeKey = ini.GetValueKey("JumpFromLedgeKey", "EXPERIMENTAL FEATURES", Keys.B);
        }
    }
}

