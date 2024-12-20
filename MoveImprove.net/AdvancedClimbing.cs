using System;
using System.Collections.Generic;
using GTA;

namespace MoveImprove.net
{
    internal class AdvancedClimbing
    {
        private static GTA.Object obj1 = null;
        private static GTA.Object ldr = null;
        private static float hdng = 0f;
        private static bool IsGrabbingLedge = false;
        public static void Tick()
        {
            if (Main.ClimbDown == true && Game.isKeyPressed(Main.ClimbDownKey) && Game.LocalPlayer.Character.isAlive && !Game.LocalPlayer.Character.isRagdoll && !Game.LocalPlayer.Character.isInAir && !Game.LocalPlayer.Character.isGettingUp && !Game.LocalPlayer.Character.isSittingInVehicle() && !Game.LocalPlayer.Character.isGettingIntoAVehicle && !Game.LocalPlayer.Character.isSwimming)
            {
                obj1 = World.CreateObject(Model.FromString("cj_dart_1"), Game.LocalPlayer.Character.GetOffsetPosition(new Vector3(0.0f, 2.0f, 20.0f)));
                if (obj1.Exists() && obj1 != null)
                {
                    AnimationSet climbstd = new AnimationSet("climb_std");
                    obj1.AttachToPed(Game.LocalPlayer.Character, Bone.Root, new Vector3(0.0f, 0.2f, -0.0f), new Vector3(0.0f, 0.0f, 0.0f));
                    obj1.Visible = false;
                    Game.WaitInCurrentScript(0);
                    if (obj1.Position.DistanceTo(obj1.Position.ToGround()) > 3.25f && obj1.Exists() && obj1 != null)
                    {
                        obj1.Detach();
                        Game.WaitInCurrentScript(500);
                        if (obj1.Velocity.Z < -4.0f)
                        {
                            obj1.NoLongerNeeded();
                            obj1.Delete();
                            ldr = World.CreateObject("BM_ladder", Game.LocalPlayer.Character.GetOffsetPosition(new Vector3(0.0f, 2.0f, 0.0f)));
                            ldr.Visible = false;
                            if (ldr.Exists())
                            {
                                ldr.AttachToPed(Game.LocalPlayer.Character, Bone.Root, new Vector3(0.0f, 0.25f, -2.8f), new Vector3(0.0f, 0.0f, -3.2f));
                                Game.WaitInCurrentScript(0);
                                ldr.Detach();
                                Game.WaitInCurrentScript(0);
                                GTA.Native.Function.Call("TASK_CLIMB_LADDER", Game.LocalPlayer.Character);
                                Game.WaitInCurrentScript(500);
                                Game.LocalPlayer.Character.Animation.WaitUntilFinished(climbstd, "ladder_geton_top");
                                ldr.NoLongerNeeded();
                                ldr.Delete();
                                Game.WaitInCurrentScript(0);
                                GTA.Native.Function.Call("TASK_SHIMMY", Game.LocalPlayer.Character);
                            }
                        }
                    }
                }
                Game.WaitInCurrentScript(0);
                if (obj1.Exists() && obj1 != null)
                {
                    obj1.NoLongerNeeded();
                    obj1.Delete();
                }
            }

            if (Main.JumpFromLedges == true && GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "climb_std", "climb_idle"))
            {
                if (Game.isGameKeyPressed(GameKey.Aim) && IsGrabbingLedge == false)
                {
                    Game.WaitInCurrentScript(200);
                    IsGrabbingLedge = true;
                    if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "climb_std", "climb_idle"))
                    {
                        hdng = Game.LocalPlayer.Character.Heading;
                    }
                }
                else if (Game.isGameKeyPressed(GameKey.Aim) && IsGrabbingLedge == true)
                {
                    JumpFromLedge();
                }
                else if (!Game.isGameKeyPressed(GameKey.Aim) && IsGrabbingLedge == true && (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "climb_std", "climb_idle")))
                {
                    IsGrabbingLedge = false;
                    Game.LocalPlayer.Character.Task.ClearAllImmediately();
                    Game.LocalPlayer.Character.Heading = hdng;
                    Game.WaitInCurrentScript(0);
                    GTA.Native.Function.Call("FREEZE_CHAR_POSITION", Game.LocalPlayer.Character, false);
                    GTA.Native.Function.Call("TASK_SHIMMY", Game.LocalPlayer.Character);
                }
            }
        }

        private static void JumpFromLedge()
        {
            if (Game.isGameKeyPressed(GameKey.Aim) && GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "climb_std", "climb_idle"))
            {
                GTA.Native.Function.Call("FREEZE_CHAR_POSITION", Game.LocalPlayer.Character, true);
                GTA.Native.Function.Call("TASK_PLAY_ANIM_NON_INTERRUPTABLE", Game.LocalPlayer.Character, "climb_idle", "climb_std", 8.00, 0, 1, 0, 0, -1);
                GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "climb_std", "climb_idle", 0.01);
                if (Game.isGameKeyPressed(GameKey.MoveForward) && Game.isKeyPressed(Main.JumpFromLedgeKey))
                {
                    IsGrabbingLedge = false;
                    Game.LocalPlayer.Character.Task.ClearAllImmediately();
                    Game.LocalPlayer.Character.Heading = Game.CurrentCamera.Heading;
                    GTA.Native.Function.Call("FREEZE_CHAR_POSITION", Game.LocalPlayer.Character, true);
                    obj1 = World.CreateObject("cj_game_cube_1", Game.LocalPlayer.Character.GetOffsetPosition(new Vector3(-0.0f, 0.0f, -2.0f)));
                    if (obj1.Exists() && obj1 != null)
                    {
                        obj1.Visible = false;
                        GTA.Native.Function.Call("FREEZE_OBJECT_POSITION", obj1, true);
                    }
                    Game.WaitInCurrentScript(80);
                    GTA.Native.Function.Call("FREEZE_CHAR_POSITION", Game.LocalPlayer.Character, false);
                    GTA.Native.Function.Call("TASK_JUMP", Game.LocalPlayer.Character);
                    Game.WaitInCurrentScript(500);
                    if (obj1.Exists() && obj1 != null)
                    {
                        obj1.NoLongerNeeded();
                        obj1.Delete();
                    }
                }
            }
        }
    }
}
