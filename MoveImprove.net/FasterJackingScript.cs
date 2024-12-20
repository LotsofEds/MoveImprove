using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GTA;

namespace MoveImprove.net
{
    internal class FasterJackingScript
    {
        private static bool CheckDateTime;
        private static DateTime currentDateTime;
        public static void Tick()
        {
            if (CheckDateTime == false)
            {
                currentDateTime = DateTime.Now;
                CheckDateTime = true;
            }

            if (DateTime.Now.Subtract(currentDateTime).TotalMilliseconds > 50.0)
            {
                CheckDateTime = false;
                if (Game.LocalPlayer.Character.isGettingIntoAVehicle)
                {
                    if (!GTA.Native.Function.Call<bool>("IS_PED_JACKING", Game.LocalPlayer.Character))
                    {
                        GTA.Native.Function.Call("SET_CHAR_ALL_ANIMS_SPEED", Game.LocalPlayer.Character, ((double)Main.EnterExitVehSpeed));
                    }

                    else if (Main.FasterJacking == true && GTA.Native.Function.Call<bool>("IS_PED_JACKING", Game.LocalPlayer.Character))
                    {
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "veh@std_jack_unarmdc", "jack_perp_ds", 1.25);
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "veh@low_jack_pistol", "jack_perp_ds", 1.5);
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "veh@low_jack_pistol", "jack_perp_ps", 1.2);
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "veh@low_jack_rifle", "jack_perp_ds", 1.2);
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "veh@low_jack_rifle", "jack_perp_ps", 1.2);
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "veh@low_jack_rpg", "jack_perp_ds", 1.2);
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "veh@low_jack_rpg", "jack_perp_ps", 1.2);
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "veh@std_jack_pistol", "jack_perp_ds", 1.3);
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "veh@std_jack_pistol", "jack_perp_ps", 1.2);
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "veh@std_jack_pistolb", "jack_perp_ds", 1.2);
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "veh@std_jack_pistolb", "jack_perp_ps", 1.2);
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "veh@std_jack_rifle", "jack_perp_ds", 1.2);
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "veh@std_jack_rifle", "jack_perp_ps", 1.2);
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "veh@std_jack_rifle_b", "jack_perp_ds", 1.2);
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "veh@std_jack_rifle_c", "jack_perp_ds", 1.2);
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "veh@std_jack_rpg", "jack_perp_ds", 1.2);
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "veh@std_jack_rpg", "jack_perp_ps", 1.2);
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "veh@tru_jack_pistol", "jack_perp_ds", 1.2);
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "veh@tru_jack_pistol", "jack_perp_ps", 1.2);
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "veh@tru_jack_rifle", "jack_perp_ds", 1.2);
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "veh@tru_jack_rifle", "jack_perp_ps", 1.2);
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "veh@van_jack_pistol", "jack_perp_ds", 1.2);
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "veh@van_jack_pistol", "jack_perp_ps", 1.2);
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "veh@van_jack_rifle", "jack_perp_ds", 1.2);
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "veh@van_jack_rifle", "jack_perp_ps", 1.4);


                        GTA.Ped[] pedGroup = GTA.World.GetPeds(Game.LocalPlayer.Character.Position, 3);
                        foreach (GTA.Ped ped in pedGroup)
                        {
                            if (!Game.Exists(ped)) continue;
                            if (!ped.isAliveAndWell) continue;
                            if (!Game.LocalPlayer.Character.isGettingIntoAVehicle) continue;

                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "veh@std_jack_unarmdc", "jack_driver_ds", 1.25);
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "veh@low_jack_pistol", "jack_driver_ds", 1.35);
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "veh@low_jack_pistol", "jack_driver_ps", 1.2);
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "veh@low_jack_rifle", "jack_driver_ds", 1.2);
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "veh@low_jack_rifle", "jack_driver_ps", 1.2);
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "veh@low_jack_rpg", "jack_driver_ds", 1.2);
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "veh@low_jack_rpg", "jack_driver_ps", 1.2);
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "veh@std_jack_pistol", "jack_driver_ds", 1.3);
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "veh@std_jack_pistol", "jack_driver_ps", 1.2);
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "veh@std_jack_pistolb", "jack_driver_ds", 1.2);
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "veh@std_jack_pistolb", "jack_driver_ps", 1.2);
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "veh@std_jack_rifle", "jack_driver_ds", 1.2);
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "veh@std_jack_rifle", "jack_driver_ps", 1.2);
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "veh@std_jack_rifle_b", "jack_driver_ds", 1.2);
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "veh@std_jack_rifle_c", "jack_driver_ds", 1.3);
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "veh@std_jack_rpg", "jack_driver_ds", 1.2);
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "veh@std_jack_rpg", "jack_driver_ps", 1.2);
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "veh@tru_jack_pistol", "jack_driver_ds", 1.0);
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "veh@tru_jack_pistol", "jack_driver_ps", 1.0);
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "veh@tru_jack_rifle", "jack_driver_ds", 1.0);
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "veh@tru_jack_rifle", "jack_driver_ps", 1.0);
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "veh@van_jack_pistol", "jack_driver_ds", 1.2);
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "veh@van_jack_pistol", "jack_driver_ps", 1.2);
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "veh@van_jack_rifle", "jack_driver_ds", 1.2);
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "veh@van_jack_rifle", "jack_driver_ps", 1.4);
                        }
                    }
                    GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "veh@bike_chopper", "pickup_lhs", 1.25);
                    GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "veh@bike_chopper", "pickup_rhs", 1.25);
                    GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "veh@bike_chopper", "pullup_lhs", 1.25);
                    GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "veh@bike_chopper", "pullup_rhs", 1.5);
                    GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "veh@bike_dirt", "pickup_lhs", 1.25);
                    GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "veh@bike_dirt", "pickup_rhs", 1.25);
                    GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "veh@bike_dirt", "pullup_lhs", 1.25);
                    GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "veh@bike_dirt", "pullup_rhs", 1.5);
                    GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "veh@bike_freeway", "pickup_lhs", 1.25);
                    GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "veh@bike_freeway", "pickup_rhs", 1.25);
                    GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "veh@bike_freeway", "pullup_lhs", 1.25);
                    GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "veh@bike_freeway", "pullup_rhs", 1.5);
                    GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "veh@bike_scooter", "pickup_lhs", 1.33);
                    GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "veh@bike_scooter", "pickup_rhs", 1.17);
                    GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "veh@bike_scooter", "pullup_lhs", 1.5);
                    GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "veh@bike_scooter", "pullup_rhs", 1.33);
                    GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "veh@bike_spt", "pickup_lhs", 1.25);
                    GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "veh@bike_spt", "pickup_rhs", 1.25);
                    GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "veh@bike_spt", "pullup_lhs", 1.25);
                    GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "veh@bike_spt", "pullup_rhs", 1.5);
                }
                if (Game.LocalPlayer.Character.isInVehicle() && !Game.LocalPlayer.Character.isSittingInVehicle() && !Game.LocalPlayer.Character.isGettingIntoAVehicle)
                {
                    GTA.Native.Function.Call("SET_CHAR_ALL_ANIMS_SPEED", Game.LocalPlayer.Character, ((double)Main.EnterExitVehSpeed));
                }
            }
        }
    }
}
