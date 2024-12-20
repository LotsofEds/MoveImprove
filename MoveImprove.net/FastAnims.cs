using System;
using System.Collections.Generic;
using GTA;

namespace MoveImprove.net
{
    internal class FastAnims
    {
        public static void Tick()
        {
            GTA.Native.Pointer movepntr = 0.0;
            if (GTA.Native.Function.Call<bool>("IS_CHAR_DUCKING", Game.LocalPlayer.Character) && !GTA.Native.Function.Call<bool>("IS_PED_IN_COVER", Game.LocalPlayer.Character))
            {
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "move_crouch", "idle2crouchidle", ((double)Main.CrouchingSpeed));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "move_crouch_rifle", "idle2crouchidle", ((double)Main.CrouchingSpeed));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "move_crouch_rpg", "idle2crouchidle", ((double)Main.CrouchingSpeed));
            }

            else if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_crouch", "crouchidle2idle") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_crouch_rifle", "crouchidle2idle") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "pickup_object", "pickup_high") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "pickup_object", "pickup_low") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "pickup_object", "pickup_med") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "ev_dives", "plyr_roll_left") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "ev_dives", "plyr_roll_right"))
            {
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "pickup_object", "pickup_high", ((double)Main.PickupObjectSpeed));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "pickup_object", "pickup_low", ((double)Main.PickupObjectSpeed));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "pickup_object", "pickup_med", ((double)Main.PickupObjectSpeed));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "ev_dives", "plyr_roll_left", ((double)Main.CombatRollSpeed));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "ev_dives", "plyr_roll_right", ((double)Main.CombatRollSpeed));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "move_crouch", "crouchidle2idle", ((double)Main.CrouchingSpeed));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "move_crouch_rifle", "crouchidle2idle", ((double)Main.CrouchingSpeed));
            }

            else if (GTA.Native.Function.Call<bool>("IS_PED_CLIMBING", Game.LocalPlayer.Character))
            {
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "climb_std", "hang_to_waist", ((double)Main.ClimbAndShimmySpeed));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "climb_std", "waist_to_stand_rifle", ((double)Main.ClimbAndShimmySpeed));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "climb_std", "waist_to_stand_unarmed", ((double)Main.ClimbAndShimmySpeed));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "climb_std", "landing_head_height", ((double)Main.ClimbAndShimmySpeed));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "climb_std", "landing_waist_height", ((double)Main.ClimbAndShimmySpeed));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "climb_std", "waist_to_vault", ((double)Main.ClimbAndShimmySpeed));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "climb_std", "waist_to_vault_shallow", ((double)Main.ClimbAndShimmySpeed));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "climb_std", "shimmy_l", ((double)Main.ClimbAndShimmySpeed));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "climb_std", "shimmy_r", ((double)Main.ClimbAndShimmySpeed));

                if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "climb_std", "landing_stretch_height"))
                {
                    GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "climb_std", "landing_stretch_height", movepntr);
                    if (movepntr > 0.6)
                    {
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "climb_std", "landing_stretch_height", 2.0);
                    }
                }
                if (Main.ExtremeClimbing == true)
                {
                    GTA.Native.Function.Call("REQUEST_ANIMS", "move_crouch");
                    if (!Game.isGameKeyPressed(GameKey.Sprint) && GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "climb_std", "vault_end"))
                    {
                        GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "climb_std", "vault_end", movepntr);
                        if (movepntr < 0.27 && !Game.isGameKeyPressed(GameKey.Sprint) && GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "climb_std", "vault_end"))
                        {
                            GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "climb_std", "vault_end", movepntr);
                            if (movepntr > 0.07 && movepntr < 0.27)
                            {
                                Game.LocalPlayer.Character.Euphoria.BodyBalance.Start();
                                Main.plyrPos = Game.LocalPlayer.Character.Position;
                                Game.WaitInCurrentScript(80);
                                GTA.Native.Function.Call("BLEND_FROM_NM_WITH_ANIM", Game.LocalPlayer.Character, "move_crouch", "crouchidle2idle", 40);
                                Game.WaitInCurrentScript(0);
                                GTA.Native.Function.Call("FREEZE_CHAR_POSITION", Game.LocalPlayer.Character, true);
                                Game.WaitInCurrentScript(500);
                                GTA.Native.Function.Call("FREEZE_CHAR_POSITION", Game.LocalPlayer.Character, false);
                                Game.LocalPlayer.Character.Position = new Vector3(Main.plyrPos.X, Main.plyrPos.Y, (Main.plyrPos.Z - 0.5f));
                            }
                        }
                    }

                    if (!Game.isGameKeyPressed(GameKey.Sprint) && GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "climb_std", "vault_end_r"))
                    {
                        GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "climb_std", "vault_end_r", movepntr);
                        if (movepntr < 0.25 && !Game.isGameKeyPressed(GameKey.Sprint) && GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "climb_std", "vault_end_r"))
                        {
                            GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "climb_std", "vault_end_r", movepntr);
                            if (movepntr > 0.05 && movepntr < 0.25)
                            {
                                Game.LocalPlayer.Character.Euphoria.BodyBalance.Start();
                                Main.plyrPos = Game.LocalPlayer.Character.Position;
                                Game.WaitInCurrentScript(80);
                                GTA.Native.Function.Call("BLEND_FROM_NM_WITH_ANIM", Game.LocalPlayer.Character, "move_crouch", "crouchidle2idle", 40);
                                Game.WaitInCurrentScript(0);
                                GTA.Native.Function.Call("FREEZE_CHAR_POSITION", Game.LocalPlayer.Character, true);
                                Game.WaitInCurrentScript(500);
                                GTA.Native.Function.Call("FREEZE_CHAR_POSITION", Game.LocalPlayer.Character, false);
                                Game.LocalPlayer.Character.Position = new Vector3(Main.plyrPos.X, Main.plyrPos.Y, (Main.plyrPos.Z - 0.5f));
                            }
                        }
                    }

                    if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "climb_std", "waist_to_vault"))
                    {
                        GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "climb_std", "waist_to_vault", movepntr);
                        if (movepntr > 0.52 && movepntr < 0.6 && !Game.isGameKeyPressed(GameKey.Sprint) && GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "climb_std", "waist_to_vault"))
                        {
                            Game.LocalPlayer.Character.Euphoria.BodyBalance.Start();
                            Main.plyrPos = Game.LocalPlayer.Character.Position;
                            Game.WaitInCurrentScript(80);
                            GTA.Native.Function.Call("BLEND_FROM_NM_WITH_ANIM", Game.LocalPlayer.Character, "move_crouch", "crouchidle2idle", 40);
                            Game.WaitInCurrentScript(0);
                            GTA.Native.Function.Call("FREEZE_CHAR_POSITION", Game.LocalPlayer.Character, true);
                            Game.WaitInCurrentScript(500);
                            GTA.Native.Function.Call("FREEZE_CHAR_POSITION", Game.LocalPlayer.Character, false);
                            Game.LocalPlayer.Character.Position = new Vector3(Main.plyrPos.X, Main.plyrPos.Y, (Main.plyrPos.Z - 0.5f));
                        }
                    }

                    if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "climb_std", "waist_to_vault_shallow"))
                    {
                        GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "climb_std", "waist_to_vault_shallow", movepntr);
                        if (movepntr > 0.52 && movepntr < 0.6 && !Game.isGameKeyPressed(GameKey.Sprint) && GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "climb_std", "waist_to_vault_shallow"))
                        {
                            Game.LocalPlayer.Character.Euphoria.BodyBalance.Start();
                            Main.plyrPos = Game.LocalPlayer.Character.Position;
                            Game.WaitInCurrentScript(80);
                            GTA.Native.Function.Call("BLEND_FROM_NM_WITH_ANIM", Game.LocalPlayer.Character, "move_crouch", "crouchidle2idle", 40);
                            Game.WaitInCurrentScript(0);
                            GTA.Native.Function.Call("FREEZE_CHAR_POSITION", Game.LocalPlayer.Character, true);
                            Game.WaitInCurrentScript(500);
                            GTA.Native.Function.Call("FREEZE_CHAR_POSITION", Game.LocalPlayer.Character, false);
                            Game.LocalPlayer.Character.Position = new Vector3(Main.plyrPos.X, Main.plyrPos.Y, (Main.plyrPos.Z - 0.5f));
                        }
                    }
                }
            }

            if (GTA.Native.Function.Call<bool>("IS_PED_IN_COVER", Game.LocalPlayer.Character))
            {
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "cover_l_low_centre", "pistol_peek", ((double)Main.PeekFromCoverSpeed));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "cover_l_low_centre", "rifle_peek", ((double)Main.PeekFromCoverSpeed));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "cover_r_low_centre", "pistol_peek", ((double)Main.PeekFromCoverSpeed));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "cover_r_low_centre", "rifle_peek", ((double)Main.PeekFromCoverSpeed));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "cover_l_low_corner", "pistol_peek", ((double)Main.PeekFromCoverSpeed));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "cover_l_low_corner", "rifle_peek", ((double)Main.PeekFromCoverSpeed));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "cover_r_low_corner", "pistol_peek", ((double)Main.PeekFromCoverSpeed));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "cover_r_low_corner", "rifle_peek", ((double)Main.PeekFromCoverSpeed));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "cover_l_high_corner", "pistol_peek", ((double)Main.PeekFromCoverSpeed));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "cover_l_high_corner", "rifle_peek", ((double)Main.PeekFromCoverSpeed));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "cover_r_high_corner", "pistol_peek", ((double)Main.PeekFromCoverSpeed));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "cover_r_high_corner", "rifle_peek", ((double)Main.PeekFromCoverSpeed));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "cover_l_low_centre", "pistol_normal_fire_intro", ((double)Main.PeekFromCoverSpeed));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "cover_l_low_centre", "rifle_normal_fire_intro", ((double)Main.PeekFromCoverSpeed));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "cover_r_low_centre", "pistol_normal_fire_intro", ((double)Main.PeekFromCoverSpeed));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "cover_r_low_centre", "rifle_normal_fire_intro", ((double)Main.PeekFromCoverSpeed));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "cover_l_low_corner", "pistol_normal_fire_intro", ((double)Main.PeekFromCoverSpeed));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "cover_l_low_corner", "rifle_normal_fire_intro", ((double)Main.PeekFromCoverSpeed));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "cover_r_low_corner", "pistol_normal_fire_intro", ((double)Main.PeekFromCoverSpeed));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "cover_r_low_corner", "rifle_normal_fire_intro", ((double)Main.PeekFromCoverSpeed));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "cover_l_high_corner", "pistol_normal_fire_intro", ((double)Main.PeekFromCoverSpeed));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "cover_l_high_corner", "rifle_normal_fire_intro", ((double)Main.PeekFromCoverSpeed));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "cover_r_high_corner", "pistol_normal_fire_intro", ((double)Main.PeekFromCoverSpeed));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "cover_r_high_corner", "rifle_normal_fire_intro", ((double)Main.PeekFromCoverSpeed));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "cover_l_low_centre", "pistol_normal_fire_outro", ((double)Main.PeekFromCoverSpeed));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "cover_l_low_centre", "rifle_normal_fire_outro", ((double)Main.PeekFromCoverSpeed));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "cover_r_low_centre", "pistol_normal_fire_outro", ((double)Main.PeekFromCoverSpeed));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "cover_r_low_centre", "rifle_normal_fire_outro", ((double)Main.PeekFromCoverSpeed));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "cover_l_low_corner", "pistol_normal_fire_outro", ((double)Main.PeekFromCoverSpeed));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "cover_l_low_corner", "rifle_normal_fire_outro", ((double)Main.PeekFromCoverSpeed));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "cover_r_low_corner", "pistol_normal_fire_outro", ((double)Main.PeekFromCoverSpeed));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "cover_r_low_corner", "rifle_normal_fire_outro", ((double)Main.PeekFromCoverSpeed));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "cover_l_high_corner", "pistol_normal_fire_outro", ((double)Main.PeekFromCoverSpeed));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "cover_l_high_corner", "rifle_normal_fire_outro", ((double)Main.PeekFromCoverSpeed));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "cover_r_high_corner", "pistol_normal_fire_outro", ((double)Main.PeekFromCoverSpeed));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "cover_r_high_corner", "rifle_normal_fire_outro", ((double)Main.PeekFromCoverSpeed));

                if (Game.isGameKeyPressed(GameKey.Sprint))
                {
                    GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "move_combat_strafe", "walk", 1.5);
                    GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "move_rpg", "walk", 1.5);
                    GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "move_crouch", "walk", 1.75);
                    GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "move_crouch_rifle", "walk", 1.75);
                    GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "move_crouch_rpg", "walk", 1.75);
                }
            }

            if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "climb_std", "fall_land"))
            {
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "climb_std", "fall_land", 1.5);
                GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "climb_std", "fall_land", movepntr);
                if (movepntr > 0.3)
                {
                    GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "climb_std", "fall_land", 2.0);
                }
            }

            if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "jump_std", "jump_on_spot"))
            {
                GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "jump_std", "jump_on_spot", movepntr);
                if (movepntr > 0.5)
                {
                    GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "jump_std", "jump_on_spot", 2.0);
                }
            }

            if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "jump_rifle", "jump_on_spot"))
            {
                GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "jump_rifle", "jump_on_spot", movepntr);
                if (movepntr > 0.6)
                {
                    GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "jump_rifle", "jump_on_spot", 2.0);
                }
            }
        }
    }
}
