using GTA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveImprove.net
{
    internal class CounterStrikes : Script
    {
        bool IsCountering;
        bool IsCounteringArmed;
        GTA.Native.Pointer CounterTime = 0.0;
        public CounterStrikes()
        {
            this.Tick += new EventHandler(this.ScriptCommunicationExample2_Tick);
        }

        private void ScriptCommunicationExample2_Tick(object sender, EventArgs e)
        {
            foreach (GTA.Ped ped in GTA.World.GetPeds(Player.Character.Position, 3))
            {
                if (!Game.Exists(ped)) continue;
                if (!ped.isAliveAndWell) continue;
                if (ped.isSittingInVehicle()) continue;

                if (ped.Exists() && ped != Player.Character && ped.isAliveAndWell && !GTA.Native.Function.Call<bool>("IS_PED_IN_COMBAT", ped))
                {
                    GTA.Native.Function.Call("SET_CHAR_READY_TO_BE_STUNNED", ped, 1);
                }

                else if (ped.Exists() && ped.isAliveAndWell && GTA.Native.Function.Call<bool>("IS_PED_IN_COMBAT", ped))
                {
                    GTA.Native.Function.Call("SET_CHAR_READY_TO_BE_STUNNED", ped, 0);
                }

                if (!GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Player.Character, "melee_counters", "counter_right_2") && !GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Player.Character, "melee_counters", "counter_left_2") && !GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Player.Character, "melee_counters", "counter_back_2") && !GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Player.Character, "melee_counters", "counter_right_3") && !GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Player.Character, "melee_counters", "counter_left_3") && !GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Player.Character, "melee_counters", "counter_back_3") && !GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Player.Character, "melee_counters", "counter_right") && !GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Player.Character, "melee_counters", "counter_left") && !GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Player.Character, "melee_counters", "counter_back"))
                {
                    IsCountering = false;
                }

                if (!GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Player.Character, "melee_baseball_extra", "counter_left") && !GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Player.Character, "melee_baseball_extra", "counter_right") && !GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Player.Character, "melee_baseball_extra", "counter_back") && !GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Player.Character, "melee_knife_extra", "counter_left") && !GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Player.Character, "melee_knife_extra", "counter_right") && !GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Player.Character, "melee_knife_extra", "counter_back"))
                {
                    IsCounteringArmed = false;
                }

                if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", ped, "melee_counters", "hit_counter_right_2") && GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Player.Character, "melee_counters", "counter_right_2"))
                {
                    GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Player.Character, "melee_counters", "counter_right_2", CounterTime);
                    if (IsCountering == false && CounterTime < 0.17 && CounterTime > 0.14)
                    {
                        IsCountering = true;
                        ped.Health -= 18;
                        Wait(100);
                    }
                    if (IsCountering == false && CounterTime < 0.27 && CounterTime > 0.24)
                    {
                        IsCountering = true;
                        ped.Health -= 18;
                        Wait(100);
                    }
                    if (IsCountering == true && (CounterTime > 0.27 || (CounterTime < 0.24 && CounterTime > 0.17)))
                    {
                        IsCountering = false;
                    }
                }

                if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", ped, "melee_counters", "hit_counter_back_3") && GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Player.Character, "melee_counters", "counter_back_3"))
                {
                    GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Player.Character, "melee_counters", "counter_back_3", CounterTime);
                    if (IsCountering == false && CounterTime < 0.23 && CounterTime > 0.2)
                    {
                        IsCountering = true;
                        ped.Health -= 25;
                        Wait(100);
                    }
                    if (IsCountering == true && CounterTime > 0.23)
                    {
                        IsCountering = false;
                    }
                }

                if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", ped, "melee_counters", "hit_counter_left_2") && GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Player.Character, "melee_counters", "counter_left_2"))
                {
                    GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Player.Character, "melee_counters", "counter_left_2", CounterTime);
                    if (IsCountering == false && CounterTime < 0.17 && CounterTime > 0.15)
                    {
                        IsCountering = true;
                        ped.Health -= 18;
                        Wait(100);
                    }
                    if (IsCountering == false && CounterTime < 0.32 && CounterTime > 0.3)
                    {
                        IsCountering = true;
                        ped.Health -= 18;
                        Wait(100);
                    }
                    if (IsCountering == true && (CounterTime > 0.32 || (CounterTime < 0.3 && CounterTime > 0.17)))
                    {
                        IsCountering = false;
                    }
                }

                if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", ped, "melee_counters", "hit_counter_left_3") && GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Player.Character, "melee_counters", "counter_left_3"))
                {
                    GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Player.Character, "melee_counters", "counter_left_3", CounterTime);
                    if (IsCountering == false && CounterTime < 0.135 && CounterTime > 0.11)
                    {
                        IsCountering = true;
                        ped.Health -= 18;
                        Wait(100);
                    }
                    if (IsCountering == false && CounterTime < 0.345 && CounterTime > 0.32)
                    {
                        IsCountering = true;
                        ped.Health -= 18;
                        Wait(100);
                    }
                    if (IsCountering == true && (CounterTime > 0.345 || (CounterTime < 0.32 && CounterTime > 0.135)))
                    {
                        IsCountering = false;
                    }
                }

                if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", ped, "melee_counters", "hit_counter_right_3") && GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Player.Character, "melee_counters", "counter_right_3"))
                {
                    GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Player.Character, "melee_counters", "counter_right_3", CounterTime);
                    if (IsCountering == false && CounterTime < 0.135 && CounterTime > 0.11)
                    {
                        IsCountering = true;
                        ped.Health -= 18;
                        Wait(100);
                    }
                    if (IsCountering == false && CounterTime < 0.355 && CounterTime > 0.33)
                    {
                        IsCountering = true;
                        ped.Health -= 18;
                        Wait(100);
                    }
                    if (IsCountering == true && (CounterTime > 0.355 || (CounterTime < 0.33 && CounterTime > 0.135)))
                    {
                        IsCountering = false;
                    }
                }

                if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", ped, "melee_counters", "hit_counter_back_2") && GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Player.Character, "melee_counters", "counter_back_2"))
                {
                    GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Player.Character, "melee_counters", "counter_back_2", CounterTime);
                    if (IsCountering == false && CounterTime < 0.17 && CounterTime > 0.14)
                    {
                        IsCountering = true;
                        ped.Health -= 12;
                        Wait(100);
                    }
                    if (IsCountering == false && CounterTime < 0.34 && CounterTime > 0.31)
                    {
                        IsCountering = true;
                        ped.Health -= 12;
                        Wait(100);
                    }
                    if (IsCountering == false && CounterTime < 0.49 && CounterTime > 0.46)
                    {
                        IsCountering = true;
                        ped.Health -= 12;
                        Wait(100);
                    }
                    if (IsCountering == true && (CounterTime > 0.49 || (CounterTime < 0.46 && CounterTime > 0.34) || (CounterTime < 0.31 && CounterTime > 0.17)))
                    {
                        IsCountering = false;
                    }
                }

                if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", ped, "melee_baseball_extra", "hit_counter_left") && GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Player.Character, "melee_baseball_extra", "counter_left"))
                {
                    GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Player.Character, "melee_baseball_extra", "counter_left", CounterTime);
                    if (IsCounteringArmed == false && CounterTime < 0.14 && CounterTime > 0.1)
                    {
                        IsCounteringArmed = true;
                        ped.Health -= 36;
                        Wait(150);
                    }
                    if (IsCounteringArmed == true && CounterTime > 0.14)
                    {
                        IsCounteringArmed = false;
                    }
                }

                if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", ped, "melee_baseball_extra", "hit_counter_right") && GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Player.Character, "melee_baseball_extra", "counter_right"))
                {
                    GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Player.Character, "melee_baseball_extra", "counter_right", CounterTime);
                    if (IsCounteringArmed == false && CounterTime < 0.21 && CounterTime > 0.17)
                    {
                        IsCounteringArmed = true;
                        ped.Health -= 36;
                        Wait(150);
                    }
                    if (IsCounteringArmed == true && CounterTime > 0.21)
                    {
                        IsCounteringArmed = false;
                    }
                }

                if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", ped, "melee_baseball_extra", "hit_counter_back") && GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Player.Character, "melee_baseball_extra", "counter_back"))
                {
                    GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Player.Character, "melee_baseball_extra", "counter_back", CounterTime);
                    if (IsCounteringArmed == false && CounterTime < 0.145 && CounterTime > 0.12)
                    {
                        IsCounteringArmed = true;
                        ped.Health -= 36;
                        Wait(150);
                    }
                    if (IsCounteringArmed == true && CounterTime > 0.145)
                    {
                        IsCounteringArmed = false;
                    }
                }

                if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", ped, "melee_knife_extra", "hit_counter_left") && GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Player.Character, "melee_knife_extra", "counter_left"))
                {
                    GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Player.Character, "melee_knife_extra", "counter_left", CounterTime);
                    if (IsCounteringArmed == false && CounterTime < 0.33 && CounterTime > 0.3)
                    {
                        IsCounteringArmed = true;
                        ped.Health -= 70;
                        Wait(150);
                    }
                    if (IsCounteringArmed == true && CounterTime > 0.33)
                    {
                        IsCounteringArmed = false;
                    }
                }

                if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", ped, "melee_knife_extra", "hit_counter_right") && GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Player.Character, "melee_knife_extra", "counter_right"))
                {
                    GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Player.Character, "melee_knife_extra", "counter_right", CounterTime);
                    if (IsCounteringArmed == false && CounterTime < 0.33 && CounterTime > 0.3)
                    {
                        IsCounteringArmed = true;
                        ped.Health -= 70;
                        Wait(150);
                    }
                    if (IsCounteringArmed == true && CounterTime > 0.33)
                    {
                        IsCounteringArmed = false;
                    }
                }

                if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", ped, "melee_knife_extra", "hit_counter_back") && GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Player.Character, "melee_knife_extra", "counter_back"))
                {
                    GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Player.Character, "melee_knife_extra", "counter_back", CounterTime);
                    if (IsCounteringArmed == false && CounterTime < 0.33 && CounterTime > 0.3)
                    {
                        IsCounteringArmed = true;
                        ped.Health -= 70;
                        Wait(150);
                    }
                    if (IsCounteringArmed == true && CounterTime > 0.33)
                    {
                        IsCounteringArmed = false;
                    }
                }

                if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", ped, "melee_counters", "hit_counter_back") && GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Player.Character, "melee_counters", "counter_back"))
                {
                    GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Player.Character, "melee_counters", "counter_back", CounterTime);
                    if (IsCountering == false && CounterTime < 0.205 && CounterTime > 0.17)
                    {
                        IsCountering = true;
                        ped.Health -= 12;
                        Wait(100);
                    }
                    if (IsCountering == false && CounterTime < 0.365 && CounterTime > 0.33)
                    {
                        IsCountering = true;
                        ped.Health -= 12;
                        Wait(100);
                    }
                    if (IsCountering == true && (CounterTime > 0.365 || (CounterTime < 0.33 && CounterTime > 0.205)))
                    {
                        IsCountering = false;
                    }
                }

                if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", ped, "melee_counters", "hit_counter_left") && GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Player.Character, "melee_counters", "counter_left"))
                {
                    GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Player.Character, "melee_counters", "counter_left", CounterTime);
                    if (IsCountering == false && CounterTime < 0.22 && CounterTime > 0.19)
                    {
                        IsCountering = true;
                        ped.Health -= 12;
                        Wait(100);
                    }
                    if (IsCountering == false && CounterTime < 0.36 && CounterTime > 0.33)
                    {
                        IsCountering = true;
                        ped.Health -= 12;
                        Wait(100);
                    }
                    if (IsCountering == true && (CounterTime > 0.36 || (CounterTime < 0.33 && CounterTime > 0.22)))
                    {
                        IsCountering = false;
                    }
                }

                if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", ped, "melee_counters", "hit_counter_right") && GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Player.Character, "melee_counters", "counter_right"))
                {
                    GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Player.Character, "melee_counters", "counter_right", CounterTime);
                    if (IsCountering == false && CounterTime < 0.185 && CounterTime > 0.15)
                    {
                        IsCountering = true;
                        ped.Health -= 12;
                        Wait(100);
                    }
                    if (IsCountering == false && CounterTime < 0.365 && CounterTime > 0.33)
                    {
                        IsCountering = true;
                        ped.Health -= 12;
                        Wait(100);
                    }
                    if (IsCountering == true && (CounterTime > 0.365 || (CounterTime < 0.33 && CounterTime > 0.185)))
                    {
                        IsCountering = false;
                    }
                }

                if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Player.Character, "melee_counters", "counter_left_2"))
                {
                    GTA.Native.Pointer pfinlefta = 0.0;
                    GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Player.Character, "melee_counters", "counter_left_2", pfinlefta);
                    if (pfinlefta > 0.65)
                    {
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Player.Character, "melee_counters", "counter_left_2", 1.75);
                    }

                    if (pfinlefta > 0.85)
                    {
                        GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Player.Character, "melee_counters", "counter_left_2", 1.0);
                    }
                }

                if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Player.Character, "melee_counters", "counter_right_3"))
                {
                    GTA.Native.Pointer pfinrightb = 0.0;
                    GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Player.Character, "melee_counters", "counter_right_3", pfinrightb);
                    if (pfinrightb > 0.6)
                    {
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Player.Character, "melee_counters", "counter_right_3", 1.75);
                    }
                    if (pfinrightb > 0.85)
                    {
                        GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Player.Character, "melee_counters", "counter_right_3", 1.0);
                    }
                }
            }
        }
    }
}
