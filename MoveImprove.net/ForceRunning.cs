using System;
using System.Collections.Generic;
using GTA;

namespace MoveImprove.net
{
    internal class ForceRunning
    {
        private static string animone;
        public static void Tick()
        {
            GTA.Native.Function.Call("REQUEST_ANIMS", "move_fast");
            animone = GTA.Native.Function.Call<string>("GET_ANIM_GROUP_FROM_CHAR", Game.LocalPlayer.Character);
            if (Main.SprintToVehicles == true && Game.isGameKeyPressed(GameKey.EnterCar) && !Game.isGameKeyPressed(GameKey.MoveForward) && !Game.isGameKeyPressed(GameKey.MoveBackward) && !Game.isGameKeyPressed(GameKey.MoveLeft) && !Game.isGameKeyPressed(GameKey.MoveRight) && Game.LocalPlayer.Character.isAlive && !Game.LocalPlayer.Character.isRagdoll && !Game.LocalPlayer.Character.isSittingInVehicle())
            {
                if (!animone.Contains("move_fast"))
                {
                    GTA.Native.Function.Call("SET_ANIM_GROUP_FOR_CHAR", Game.LocalPlayer.Character, "move_fast");
                }
            }
            if (Main.ForceRun == true)
            {
                if (Game.isGameKeyPressed(GameKey.Sprint) && !GTA.Native.Function.Call<bool>("IS_PED_IN_COVER", Game.LocalPlayer.Character))
                {
                    Game.WaitInCurrentScript(500);
                    if (Game.isGameKeyPressed(GameKey.Sprint) && (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_player", "walk") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_player", "walk_b") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_player", "walk_c") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_player", "walk_down") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_player", "walk_up") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_player", "walk_turn_l") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_player", "walk_turn_l2") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_player", "walk_turn_l3") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_player", "walk_turn_r") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_player", "walk_turn_r2") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_player", "walk_turn_r3")))
                    {
                        if (!(GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_player", "run") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_player", "run_down") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_player", "run_up") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_player", "run_turn_l") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_player", "run_turn_l2") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_player", "run_turn_r") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_player", "run_turn_r2") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_player", "sprint") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_player", "sprint_turn_l") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_player", "sprint_turn_r")))
                        {
                            GTA.Native.Function.Call("SET_ANIM_GROUP_FOR_CHAR", Game.LocalPlayer.Character, "move_fast");
                        }
                    }
                }
            }

            if (animone!= null&&animone.Contains("move_fast") && ((!Game.isGameKeyPressed(GameKey.EnterCar) || Game.isGameKeyPressed(GameKey.MoveForward) || Game.isGameKeyPressed(GameKey.MoveBackward) || Game.isGameKeyPressed(GameKey.MoveLeft) || Game.isGameKeyPressed(GameKey.MoveRight) || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_fast", "sprint")) && !Game.isGameKeyPressed(GameKey.Sprint)))
            {
                GTA.Native.Function.Call("SET_ANIM_GROUP_FOR_CHAR", Game.LocalPlayer.Character, "move_player");
            }
        }
    }
}
