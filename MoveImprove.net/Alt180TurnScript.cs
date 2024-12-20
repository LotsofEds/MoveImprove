using System;
using System.Collections.Generic;
using GTA;

namespace MoveImprove.net
{
    public class Alt180Turn : Script
    {
        public Alt180Turn()
        {
            Interval = 50;
            this.Tick += AltTurnick;
        }
        private void AltTurnick(object sender, EventArgs e)
        {
            GTA.Native.Function.Call("REQUEST_ANIMS", "move_player");
            GTA.Native.Pointer turnpntr = 0.0;
            if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_player", "sprint_turn_180_r"))
            {
                GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_player", "sprint_turn_180_r", turnpntr);
                if (!Game.isGameKeyPressed(GameKey.Aim) && !Game.isGameKeyPressed(GameKey.MoveForward) && !Game.isGameKeyPressed(GameKey.MoveBackward) && !Game.isGameKeyPressed(GameKey.MoveLeft) && !Game.isGameKeyPressed(GameKey.MoveRight))
                {
                    GTA.Native.Function.Call("TASK_PLAY_ANIM_NON_INTERRUPTABLE", Game.LocalPlayer.Character, "idle", "move_player", 5.00, 0, 1, 0, 0, -1);
                    Game.WaitInCurrentScript(200);
                    if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_player", "idle"))
                    {
                        GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_player", "idle", 1.0);
                        Game.LocalPlayer.Character.Task.ClearAllImmediately();
                    }
                }

                if (turnpntr > 0.5 && turnpntr < 0.7)
                {
                    GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_player", "sprint_turn_180_r", 0.87);
                    if (!Game.isGameKeyPressed(GameKey.Aim) && !Game.isGameKeyPressed(GameKey.MoveForward) && !Game.isGameKeyPressed(GameKey.MoveBackward) && !Game.isGameKeyPressed(GameKey.MoveLeft) && !Game.isGameKeyPressed(GameKey.MoveRight))
                    {
                        GTA.Native.Function.Call("TASK_PLAY_ANIM_NON_INTERRUPTABLE", Game.LocalPlayer.Character, "idle", "move_player", 5.00, 0, 1, 0, 0, -1);
                        Game.WaitInCurrentScript(200);
                        if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_player", "idle"))
                        {
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_player", "idle", 1.0);
                            Game.LocalPlayer.Character.Task.ClearAllImmediately();
                        }
                    }
                }
            }
            if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_player", "sprint_turn_180_l"))
            {
                GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_player", "sprint_turn_180_l", turnpntr);
                if (!Game.isGameKeyPressed(GameKey.Aim) && !Game.isGameKeyPressed(GameKey.MoveForward) && !Game.isGameKeyPressed(GameKey.MoveBackward) && !Game.isGameKeyPressed(GameKey.MoveLeft) && !Game.isGameKeyPressed(GameKey.MoveRight))
                {
                    GTA.Native.Function.Call("TASK_PLAY_ANIM_NON_INTERRUPTABLE", Game.LocalPlayer.Character, "idle", "move_player", 5.00, 0, 1, 0, 0, -1);
                    Game.WaitInCurrentScript(200);
                    if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_player", "idle"))
                    {
                        GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_player", "idle", 1.0);
                        Game.LocalPlayer.Character.Task.ClearAllImmediately();
                    }
                }
                if (turnpntr > 0.57 && turnpntr < 0.7)
                {
                    GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_player", "sprint_turn_180_l", 0.84);
                    if (!Game.isGameKeyPressed(GameKey.Aim) && !Game.isGameKeyPressed(GameKey.MoveForward) && !Game.isGameKeyPressed(GameKey.MoveBackward) && !Game.isGameKeyPressed(GameKey.MoveLeft) && !Game.isGameKeyPressed(GameKey.MoveRight))
                    {
                        GTA.Native.Function.Call("TASK_PLAY_ANIM_NON_INTERRUPTABLE", Game.LocalPlayer.Character, "idle", "move_player", 5.00, 0, 1, 0, 0, -1);
                        Game.WaitInCurrentScript(200);
                        if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_player", "idle"))
                        {
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_player", "idle", 1.0);
                            Game.LocalPlayer.Character.Task.ClearAllImmediately();
                        }
                    }
                }
            }

            if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_player", "run_turn_180_r"))
            {
                GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_player", "run_turn_180_r", turnpntr);
                if (!Game.isGameKeyPressed(GameKey.Aim) && !Game.isGameKeyPressed(GameKey.MoveForward) && !Game.isGameKeyPressed(GameKey.MoveBackward) && !Game.isGameKeyPressed(GameKey.MoveLeft) && !Game.isGameKeyPressed(GameKey.MoveRight))
                {
                    GTA.Native.Function.Call("TASK_PLAY_ANIM_NON_INTERRUPTABLE", Game.LocalPlayer.Character, "idle", "move_player", 5.00, 0, 1, 0, 0, -1);
                    Game.WaitInCurrentScript(200);
                    if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_player", "idle"))
                    {
                        GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_player", "idle", 1.0);
                        Game.LocalPlayer.Character.Task.ClearAllImmediately();
                    }
                }
                if (turnpntr > 0.5 && turnpntr < 0.7)
                {
                    GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_player", "run_turn_180_r", 0.87);
                    if (!Game.isGameKeyPressed(GameKey.Aim) && !Game.isGameKeyPressed(GameKey.MoveForward) && !Game.isGameKeyPressed(GameKey.MoveBackward) && !Game.isGameKeyPressed(GameKey.MoveLeft) && !Game.isGameKeyPressed(GameKey.MoveRight))
                    {
                        GTA.Native.Function.Call("TASK_PLAY_ANIM_NON_INTERRUPTABLE", Game.LocalPlayer.Character, "idle", "move_player", 5.00, 0, 1, 0, 0, -1);
                        Game.WaitInCurrentScript(200);
                        if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_player", "idle"))
                        {
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_player", "idle", 1.0);
                            Game.LocalPlayer.Character.Task.ClearAllImmediately();
                        }
                    }
                }
            }

            if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_player", "run_turn_180_l"))
            {
                GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_player", "run_turn_180_l", turnpntr);
                if (!Game.isGameKeyPressed(GameKey.Aim) && !Game.isGameKeyPressed(GameKey.MoveForward) && !Game.isGameKeyPressed(GameKey.MoveBackward) && !Game.isGameKeyPressed(GameKey.MoveLeft) && !Game.isGameKeyPressed(GameKey.MoveRight))
                {
                    GTA.Native.Function.Call("TASK_PLAY_ANIM_NON_INTERRUPTABLE", Game.LocalPlayer.Character, "idle", "move_player", 5.00, 0, 1, 0, 0, -1);
                    Game.WaitInCurrentScript(200);
                    if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_player", "idle"))
                    {
                        GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_player", "idle", 1.0);
                        Game.LocalPlayer.Character.Task.ClearAllImmediately();
                    }
                }
                if (turnpntr > 0.57 && turnpntr < 0.7)
                {
                    GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_player", "run_turn_180_l", 0.84);
                    if (!Game.isGameKeyPressed(GameKey.Aim) && !Game.isGameKeyPressed(GameKey.MoveForward) && !Game.isGameKeyPressed(GameKey.MoveBackward) && !Game.isGameKeyPressed(GameKey.MoveLeft) && !Game.isGameKeyPressed(GameKey.MoveRight))
                    {
                        GTA.Native.Function.Call("TASK_PLAY_ANIM_NON_INTERRUPTABLE", Game.LocalPlayer.Character, "idle", "move_player", 5.00, 0, 1, 0, 0, -1);
                        Game.WaitInCurrentScript(200);
                        if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_player", "idle"))
                        {
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_player", "idle", 1.0);
                            Game.LocalPlayer.Character.Task.ClearAllImmediately();
                        }
                    }
                }
            }

            if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_player", "run_turn_180"))
            {
                GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_player", "run_turn_180", turnpntr);
                if (!Game.isGameKeyPressed(GameKey.Aim) && !Game.isGameKeyPressed(GameKey.MoveForward) && !Game.isGameKeyPressed(GameKey.MoveBackward) && !Game.isGameKeyPressed(GameKey.MoveLeft) && !Game.isGameKeyPressed(GameKey.MoveRight))
                {
                    GTA.Native.Function.Call("TASK_PLAY_ANIM_NON_INTERRUPTABLE", Game.LocalPlayer.Character, "idle", "move_player", 5.00, 0, 1, 0, 0, -1);
                    Game.WaitInCurrentScript(200);
                    if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_player", "idle"))
                    {
                        GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_player", "idle", 1.0);
                        Game.LocalPlayer.Character.Task.ClearAllImmediately();
                    }
                }
                if (turnpntr > 0.65 && turnpntr < 0.7)
                {
                    GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_player", "run_turn_180", 0.84);
                    if (!Game.isGameKeyPressed(GameKey.Aim) && !Game.isGameKeyPressed(GameKey.MoveForward) && !Game.isGameKeyPressed(GameKey.MoveBackward) && !Game.isGameKeyPressed(GameKey.MoveLeft) && !Game.isGameKeyPressed(GameKey.MoveRight))
                    {
                        GTA.Native.Function.Call("TASK_PLAY_ANIM_NON_INTERRUPTABLE", Game.LocalPlayer.Character, "idle", "move_player", 5.00, 0, 1, 0, 0, -1);
                        Game.WaitInCurrentScript(200);
                        if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_player", "idle"))
                        {
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_player", "idle", 1.0);
                            Game.LocalPlayer.Character.Task.ClearAllImmediately();
                        }
                    }
                }
            }

            if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_rifle", "sprint_turn_180_r"))
            {
                if (!Game.isGameKeyPressed(GameKey.Aim) && !Game.isGameKeyPressed(GameKey.MoveForward) && !Game.isGameKeyPressed(GameKey.MoveBackward) && !Game.isGameKeyPressed(GameKey.MoveLeft) && !Game.isGameKeyPressed(GameKey.MoveRight))
                {
                    GTA.Native.Function.Call("TASK_PLAY_ANIM_NON_INTERRUPTABLE", Game.LocalPlayer.Character, "idle", "move_rifle", 5.00, 0, 1, 0, 0, -1);
                    Game.WaitInCurrentScript(200);
                    if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_rifle", "idle"))
                    {
                        GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rifle", "sprint_turn_180_r", 1.0);
                        GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rifle", "idle", 0.95);
                        while (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_rifle", "idle") && !Game.isGameKeyPressed(GameKey.Aim) && !Game.isGameKeyPressed(GameKey.MoveForward) && !Game.isGameKeyPressed(GameKey.MoveBackward) && !Game.isGameKeyPressed(GameKey.MoveLeft) && !Game.isGameKeyPressed(GameKey.MoveRight))
                        {
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rifle", "sstop_l", 1.0);
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rifle", "sstop_r", 1.0);
                            Game.WaitInCurrentScript(0);
                        }
                        if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_rifle", "idle"))
                        {
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rifle", "idle", 1.0);
                        }
                    }
                }
                GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rifle", "sprint_turn_180_r", turnpntr);
                if (turnpntr > 0.5 && turnpntr < 0.7)
                {
                    GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rifle", "sprint_turn_180_r", 0.87);
                    if (!Game.isGameKeyPressed(GameKey.Aim) && !Game.isGameKeyPressed(GameKey.MoveForward) && !Game.isGameKeyPressed(GameKey.MoveBackward) && !Game.isGameKeyPressed(GameKey.MoveLeft) && !Game.isGameKeyPressed(GameKey.MoveRight))
                    {
                        GTA.Native.Function.Call("TASK_PLAY_ANIM_NON_INTERRUPTABLE", Game.LocalPlayer.Character, "idle", "move_rifle", 5.00, 0, 1, 0, 0, -1);
                        Game.WaitInCurrentScript(200);
                        if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_rifle", "idle"))
                        {
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rifle", "sprint_turn_180_r", 1.0);
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rifle", "idle", 0.95);
                            while (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_rifle", "idle") && !Game.isGameKeyPressed(GameKey.Aim) && !Game.isGameKeyPressed(GameKey.MoveForward) && !Game.isGameKeyPressed(GameKey.MoveBackward) && !Game.isGameKeyPressed(GameKey.MoveLeft) && !Game.isGameKeyPressed(GameKey.MoveRight))
                            {
                                GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rifle", "sstop_l", 1.0);
                                GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rifle", "sstop_r", 1.0);
                                Game.WaitInCurrentScript(0);
                            }
                            if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_rifle", "idle"))
                            {
                                GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rifle", "idle", 1.0);
                            }
                        }
                    }
                }
            }

            if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_rifle", "sprint_turn_180_l"))
            {
                GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rifle", "sprint_turn_180_l", turnpntr);
                if (!Game.isGameKeyPressed(GameKey.Aim) && !Game.isGameKeyPressed(GameKey.MoveForward) && !Game.isGameKeyPressed(GameKey.MoveBackward) && !Game.isGameKeyPressed(GameKey.MoveLeft) && !Game.isGameKeyPressed(GameKey.MoveRight))
                {
                    GTA.Native.Function.Call("TASK_PLAY_ANIM_NON_INTERRUPTABLE", Game.LocalPlayer.Character, "idle", "move_rifle", 5.00, 0, 1, 0, 0, -1);
                    Game.WaitInCurrentScript(200);
                    if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_rifle", "idle"))
                    {
                        GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rifle", "sprint_turn_180_l", 1.0);
                        GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rifle", "idle", 0.95);
                        while (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_rifle", "idle") && !Game.isGameKeyPressed(GameKey.Aim) && !Game.isGameKeyPressed(GameKey.MoveForward) && !Game.isGameKeyPressed(GameKey.MoveBackward) && !Game.isGameKeyPressed(GameKey.MoveLeft) && !Game.isGameKeyPressed(GameKey.MoveRight))
                        {
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rifle", "sstop_l", 1.0);
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rifle", "sstop_r", 1.0);
                            Game.WaitInCurrentScript(0);
                        }
                        if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_rifle", "idle"))
                        {
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rifle", "idle", 1.0);
                        }
                    }
                }
                if (turnpntr > 0.57 && turnpntr < 0.7)
                {
                    GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rifle", "sprint_turn_180_l", 0.84);
                    if (!Game.isGameKeyPressed(GameKey.Aim) && !Game.isGameKeyPressed(GameKey.MoveForward) && !Game.isGameKeyPressed(GameKey.MoveBackward) && !Game.isGameKeyPressed(GameKey.MoveLeft) && !Game.isGameKeyPressed(GameKey.MoveRight))
                    {
                        GTA.Native.Function.Call("TASK_PLAY_ANIM_NON_INTERRUPTABLE", Game.LocalPlayer.Character, "idle", "move_rifle", 5.00, 0, 1, 0, 0, -1);
                        Game.WaitInCurrentScript(200);
                        if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_rifle", "idle"))
                        {
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rifle", "sprint_turn_180_l", 1.0);
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rifle", "idle", 0.95);
                            while (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_rifle", "idle") && !Game.isGameKeyPressed(GameKey.Aim) && !Game.isGameKeyPressed(GameKey.MoveForward) && !Game.isGameKeyPressed(GameKey.MoveBackward) && !Game.isGameKeyPressed(GameKey.MoveLeft) && !Game.isGameKeyPressed(GameKey.MoveRight))
                            {
                                GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rifle", "sstop_l", 1.0);
                                GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rifle", "sstop_r", 1.0);
                                Game.WaitInCurrentScript(0);
                            }
                            if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_rifle", "idle"))
                            {
                                GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rifle", "idle", 1.0);
                            }
                        }
                    }
                }
            }

            if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_rifle", "run_turn_180_r"))
            {
                if (!Game.isGameKeyPressed(GameKey.Aim) && !Game.isGameKeyPressed(GameKey.MoveForward) && !Game.isGameKeyPressed(GameKey.MoveBackward) && !Game.isGameKeyPressed(GameKey.MoveLeft) && !Game.isGameKeyPressed(GameKey.MoveRight))
                {
                    GTA.Native.Function.Call("TASK_PLAY_ANIM_NON_INTERRUPTABLE", Game.LocalPlayer.Character, "idle", "move_rifle", 5.00, 0, 1, 0, 0, -1);
                    Game.WaitInCurrentScript(200);
                    if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_rifle", "idle"))
                    {
                        GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rifle", "run_turn_180_r", 1.0);
                        GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rifle", "idle", 0.95);
                        while (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_rifle", "idle") && !Game.isGameKeyPressed(GameKey.Aim) && !Game.isGameKeyPressed(GameKey.MoveForward) && !Game.isGameKeyPressed(GameKey.MoveBackward) && !Game.isGameKeyPressed(GameKey.MoveLeft) && !Game.isGameKeyPressed(GameKey.MoveRight))
                        {
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rifle", "rstop_l", 1.0);
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rifle", "rstop_r", 1.0);
                            Game.WaitInCurrentScript(0);
                        }
                        if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_rifle", "idle"))
                        {
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rifle", "idle", 1.0);
                        }
                    }
                }
                GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rifle", "run_turn_180_r", turnpntr);
                if (turnpntr > 0.5 && turnpntr < 0.7)
                {
                    GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rifle", "run_turn_180_r", 0.87);
                    if (!Game.isGameKeyPressed(GameKey.Aim) && !Game.isGameKeyPressed(GameKey.MoveForward) && !Game.isGameKeyPressed(GameKey.MoveBackward) && !Game.isGameKeyPressed(GameKey.MoveLeft) && !Game.isGameKeyPressed(GameKey.MoveRight))
                    {
                        GTA.Native.Function.Call("TASK_PLAY_ANIM_NON_INTERRUPTABLE", Game.LocalPlayer.Character, "idle", "move_rifle", 5.00, 0, 1, 0, 0, -1);
                        Game.WaitInCurrentScript(200);
                        if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_rifle", "idle"))
                        {
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rifle", "run_turn_180_r", 1.0);
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rifle", "idle", 0.95);
                            while (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_rifle", "idle") && !Game.isGameKeyPressed(GameKey.Aim) && !Game.isGameKeyPressed(GameKey.MoveForward) && !Game.isGameKeyPressed(GameKey.MoveBackward) && !Game.isGameKeyPressed(GameKey.MoveLeft) && !Game.isGameKeyPressed(GameKey.MoveRight))
                            {
                                GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rifle", "rstop_l", 1.0);
                                GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rifle", "rstop_r", 1.0);
                                Game.WaitInCurrentScript(0);
                            }
                            if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_rifle", "idle"))
                            {
                                GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rifle", "idle", 1.0);
                            }
                        }
                    }
                }
            }

            if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_rifle", "run_turn_180_l"))
            {
                GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rifle", "run_turn_180_l", turnpntr);
                if (!Game.isGameKeyPressed(GameKey.Aim) && !Game.isGameKeyPressed(GameKey.MoveForward) && !Game.isGameKeyPressed(GameKey.MoveBackward) && !Game.isGameKeyPressed(GameKey.MoveLeft) && !Game.isGameKeyPressed(GameKey.MoveRight))
                {
                    GTA.Native.Function.Call("TASK_PLAY_ANIM_NON_INTERRUPTABLE", Game.LocalPlayer.Character, "idle", "move_rifle", 5.00, 0, 1, 0, 0, -1);
                    Game.WaitInCurrentScript(200);
                    if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_rifle", "idle"))
                    {
                        GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rifle", "run_turn_180_l", 1.0);
                        GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rifle", "idle", 0.95);
                        while (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_rifle", "idle") && !Game.isGameKeyPressed(GameKey.Aim) && !Game.isGameKeyPressed(GameKey.MoveForward) && !Game.isGameKeyPressed(GameKey.MoveBackward) && !Game.isGameKeyPressed(GameKey.MoveLeft) && !Game.isGameKeyPressed(GameKey.MoveRight))
                        {
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rifle", "rstop_l", 1.0);
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rifle", "rstop_r", 1.0);
                            Game.WaitInCurrentScript(0);
                        }
                        if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_rifle", "idle"))
                        {
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rifle", "idle", 1.0);
                        }
                    }
                }
                if (turnpntr > 0.57 && turnpntr < 0.7)
                {
                    GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rifle", "run_turn_180_l", 0.84);
                    if (!Game.isGameKeyPressed(GameKey.Aim) && !Game.isGameKeyPressed(GameKey.MoveForward) && !Game.isGameKeyPressed(GameKey.MoveBackward) && !Game.isGameKeyPressed(GameKey.MoveLeft) && !Game.isGameKeyPressed(GameKey.MoveRight))
                    {
                        GTA.Native.Function.Call("TASK_PLAY_ANIM_NON_INTERRUPTABLE", Game.LocalPlayer.Character, "idle", "move_rifle", 5.00, 0, 1, 0, 0, -1);
                        Game.WaitInCurrentScript(200);
                        if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_rifle", "idle"))
                        {
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rifle", "run_turn_180_l", 1.0);
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rifle", "idle", 0.95);
                            while (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_rifle", "idle") && !Game.isGameKeyPressed(GameKey.Aim) && !Game.isGameKeyPressed(GameKey.MoveForward) && !Game.isGameKeyPressed(GameKey.MoveBackward) && !Game.isGameKeyPressed(GameKey.MoveLeft) && !Game.isGameKeyPressed(GameKey.MoveRight))
                            {
                                GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rifle", "rstop_l", 1.0);
                                GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rifle", "rstop_r", 1.0);
                                Game.WaitInCurrentScript(0);
                            }
                            if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_rifle", "idle"))
                            {
                                GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rifle", "idle", 1.0);
                            }
                        }
                    }
                }
            }

            if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_rifle", "run_turn_180"))
            {
                GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rifle", "run_turn_180", turnpntr);
                if (!Game.isGameKeyPressed(GameKey.Aim) && !Game.isGameKeyPressed(GameKey.MoveForward) && !Game.isGameKeyPressed(GameKey.MoveBackward) && !Game.isGameKeyPressed(GameKey.MoveLeft) && !Game.isGameKeyPressed(GameKey.MoveRight))
                {
                    GTA.Native.Function.Call("TASK_PLAY_ANIM_NON_INTERRUPTABLE", Game.LocalPlayer.Character, "idle", "move_rifle", 5.00, 0, 1, 0, 0, -1);
                    Game.WaitInCurrentScript(200);
                    if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_rifle", "idle"))
                    {
                        GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rifle", "run_turn_180", 1.0);
                        GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rifle", "idle", 0.95);
                        while (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_rifle", "idle") && !Game.isGameKeyPressed(GameKey.Aim) && !Game.isGameKeyPressed(GameKey.MoveForward) && !Game.isGameKeyPressed(GameKey.MoveBackward) && !Game.isGameKeyPressed(GameKey.MoveLeft) && !Game.isGameKeyPressed(GameKey.MoveRight))
                        {
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rifle", "rstop_l", 1.0);
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rifle", "rstop_r", 1.0);
                            Game.WaitInCurrentScript(0);
                        }
                        if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_rifle", "idle"))
                        {
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rifle", "idle", 1.0);
                        }
                    }
                }
                if (turnpntr > 0.65 && turnpntr < 0.7)
                {
                    GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rifle", "run_turn_180", 0.84);
                    if (!Game.isGameKeyPressed(GameKey.Aim) && !Game.isGameKeyPressed(GameKey.MoveForward) && !Game.isGameKeyPressed(GameKey.MoveBackward) && !Game.isGameKeyPressed(GameKey.MoveLeft) && !Game.isGameKeyPressed(GameKey.MoveRight))
                    {
                        GTA.Native.Function.Call("TASK_PLAY_ANIM_NON_INTERRUPTABLE", Game.LocalPlayer.Character, "idle", "move_rifle", 5.00, 0, 1, 0, 0, -1);
                        Game.WaitInCurrentScript(200);
                        if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_rifle", "idle"))
                        {
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rifle", "run_turn_180", 1.0);
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rifle", "idle", 0.95);
                            while (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_rifle", "idle") && !Game.isGameKeyPressed(GameKey.Aim) && !Game.isGameKeyPressed(GameKey.MoveForward) && !Game.isGameKeyPressed(GameKey.MoveBackward) && !Game.isGameKeyPressed(GameKey.MoveLeft) && !Game.isGameKeyPressed(GameKey.MoveRight))
                            {
                                GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rifle", "rstop_l", 1.0);
                                GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rifle", "rstop_r", 1.0);
                                Game.WaitInCurrentScript(0);
                            }
                            if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_rifle", "idle"))
                            {
                                GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rifle", "idle", 1.0);
                            }
                        }
                    }
                }
            }

            if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_rpg", "sprint_turn_180_r"))
            {
                GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rpg", "sprint_turn_180_r", turnpntr);
                if (!Game.isGameKeyPressed(GameKey.Aim) && !Game.isGameKeyPressed(GameKey.MoveForward) && !Game.isGameKeyPressed(GameKey.MoveBackward) && !Game.isGameKeyPressed(GameKey.MoveLeft) && !Game.isGameKeyPressed(GameKey.MoveRight))
                {
                    GTA.Native.Function.Call("TASK_PLAY_ANIM_NON_INTERRUPTABLE", Game.LocalPlayer.Character, "idle", "move_rpg", 5.00, 0, 1, 0, 0, -1);
                    Game.WaitInCurrentScript(200);
                    if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_rpg", "idle"))
                    {
                        GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rpg", "sprint_turn_180_r", 1.0);
                        GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rpg", "idle", 0.95);
                        while (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_rpg", "idle") && !Game.isGameKeyPressed(GameKey.Aim) && !Game.isGameKeyPressed(GameKey.MoveForward) && !Game.isGameKeyPressed(GameKey.MoveBackward) && !Game.isGameKeyPressed(GameKey.MoveLeft) && !Game.isGameKeyPressed(GameKey.MoveRight))
                        {
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rpg", "sstop_l", 1.0);
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rpg", "sstop_r", 1.0);
                            Game.WaitInCurrentScript(0);
                        }
                        if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_rpg", "idle"))
                        {
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rpg", "idle", 1.0);
                        }
                    }
                }
                if (turnpntr > 0.5 && turnpntr < 0.7)
                {
                    GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rpg", "sprint_turn_180_r", 0.87);
                    if (!Game.isGameKeyPressed(GameKey.Aim) && !Game.isGameKeyPressed(GameKey.MoveForward) && !Game.isGameKeyPressed(GameKey.MoveBackward) && !Game.isGameKeyPressed(GameKey.MoveLeft) && !Game.isGameKeyPressed(GameKey.MoveRight))
                    {
                        GTA.Native.Function.Call("TASK_PLAY_ANIM_NON_INTERRUPTABLE", Game.LocalPlayer.Character, "idle", "move_rpg", 5.00, 0, 1, 0, 0, -1);
                        Game.WaitInCurrentScript(200);
                        if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_rpg", "idle"))
                        {
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rpg", "sprint_turn_180_r", 1.0);
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rpg", "idle", 0.95);
                            while (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_rpg", "idle") && !Game.isGameKeyPressed(GameKey.Aim) && !Game.isGameKeyPressed(GameKey.MoveForward) && !Game.isGameKeyPressed(GameKey.MoveBackward) && !Game.isGameKeyPressed(GameKey.MoveLeft) && !Game.isGameKeyPressed(GameKey.MoveRight))
                            {
                                GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rpg", "sstop_l", 1.0);
                                GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rpg", "sstop_r", 1.0);
                                Game.WaitInCurrentScript(0);
                            }
                            if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_rpg", "idle"))
                            {
                                GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rpg", "idle", 1.0);
                            }
                        }
                    }
                }
            }

            if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_rpg", "sprint_turn_180_l"))
            {
                GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rpg", "sprint_turn_180_l", turnpntr);
                if (!Game.isGameKeyPressed(GameKey.Aim) && !Game.isGameKeyPressed(GameKey.MoveForward) && !Game.isGameKeyPressed(GameKey.MoveBackward) && !Game.isGameKeyPressed(GameKey.MoveLeft) && !Game.isGameKeyPressed(GameKey.MoveRight))
                {
                    GTA.Native.Function.Call("TASK_PLAY_ANIM_NON_INTERRUPTABLE", Game.LocalPlayer.Character, "idle", "move_rpg", 5.00, 0, 1, 0, 0, -1);
                    Game.WaitInCurrentScript(200);
                    if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_rpg", "idle"))
                    {
                        GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rpg", "sprint_turn_180_l", 1.0);
                        GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rpg", "idle", 0.95);
                        while (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_rpg", "idle") && !Game.isGameKeyPressed(GameKey.Aim) && !Game.isGameKeyPressed(GameKey.MoveForward) && !Game.isGameKeyPressed(GameKey.MoveBackward) && !Game.isGameKeyPressed(GameKey.MoveLeft) && !Game.isGameKeyPressed(GameKey.MoveRight))
                        {
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rpg", "sstop_l", 1.0);
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rpg", "sstop_r", 1.0);
                            Game.WaitInCurrentScript(0);
                        }
                        if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_rpg", "idle"))
                        {
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rpg", "idle", 1.0);
                        }
                    }
                }
                if (turnpntr > 0.57 && turnpntr < 0.7)
                {
                    GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rpg", "sprint_turn_180_l", 0.84);
                    if (!Game.isGameKeyPressed(GameKey.Aim) && !Game.isGameKeyPressed(GameKey.MoveForward) && !Game.isGameKeyPressed(GameKey.MoveBackward) && !Game.isGameKeyPressed(GameKey.MoveLeft) && !Game.isGameKeyPressed(GameKey.MoveRight))
                    {
                        GTA.Native.Function.Call("TASK_PLAY_ANIM_NON_INTERRUPTABLE", Game.LocalPlayer.Character, "idle", "move_rpg", 5.00, 0, 1, 0, 0, -1);
                        Game.WaitInCurrentScript(200);
                        if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_rpg", "idle"))
                        {
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rpg", "sprint_turn_180_l", 1.0);
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rpg", "idle", 0.95);
                            while (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_rpg", "idle") && !Game.isGameKeyPressed(GameKey.Aim) && !Game.isGameKeyPressed(GameKey.MoveForward) && !Game.isGameKeyPressed(GameKey.MoveBackward) && !Game.isGameKeyPressed(GameKey.MoveLeft) && !Game.isGameKeyPressed(GameKey.MoveRight))
                            {
                                GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rpg", "sstop_l", 1.0);
                                GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rpg", "sstop_r", 1.0);
                                Game.WaitInCurrentScript(0);
                            }
                            if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_rpg", "idle"))
                            {
                                GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rpg", "idle", 1.0);
                            }
                        }
                    }
                }
            }

            if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_rpg", "run_turn_180_r"))
            {
                GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rpg", "run_turn_180_r", turnpntr);
                if (!Game.isGameKeyPressed(GameKey.Aim) && !Game.isGameKeyPressed(GameKey.MoveForward) && !Game.isGameKeyPressed(GameKey.MoveBackward) && !Game.isGameKeyPressed(GameKey.MoveLeft) && !Game.isGameKeyPressed(GameKey.MoveRight))
                {
                    GTA.Native.Function.Call("TASK_PLAY_ANIM_NON_INTERRUPTABLE", Game.LocalPlayer.Character, "idle", "move_rpg", 5.00, 0, 1, 0, 0, -1);
                    Game.WaitInCurrentScript(200);
                    if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_rpg", "idle"))
                    {
                        GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rpg", "run_turn_180_r", 1.0);
                        GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rpg", "idle", 0.95);
                        while (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_rpg", "idle") && !Game.isGameKeyPressed(GameKey.Aim) && !Game.isGameKeyPressed(GameKey.MoveForward) && !Game.isGameKeyPressed(GameKey.MoveBackward) && !Game.isGameKeyPressed(GameKey.MoveLeft) && !Game.isGameKeyPressed(GameKey.MoveRight))
                        {
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rpg", "rstop_l", 1.0);
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rpg", "rstop_r", 1.0);
                            Game.WaitInCurrentScript(0);
                        }
                        if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_rpg", "idle"))
                        {
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rpg", "idle", 1.0);
                        }
                    }
                }
                if (turnpntr > 0.5 && turnpntr < 0.7)
                {
                    GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rpg", "run_turn_180_r", 0.87);
                    if (!Game.isGameKeyPressed(GameKey.Aim) && !Game.isGameKeyPressed(GameKey.MoveForward) && !Game.isGameKeyPressed(GameKey.MoveBackward) && !Game.isGameKeyPressed(GameKey.MoveLeft) && !Game.isGameKeyPressed(GameKey.MoveRight))
                    {
                        GTA.Native.Function.Call("TASK_PLAY_ANIM_NON_INTERRUPTABLE", Game.LocalPlayer.Character, "idle", "move_rpg", 5.00, 0, 1, 0, 0, -1);
                        Game.WaitInCurrentScript(200);
                        if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_rpg", "idle"))
                        {
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rpg", "run_turn_180_r", 1.0);
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rpg", "idle", 0.95);
                            while (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_rpg", "idle") && !Game.isGameKeyPressed(GameKey.Aim) && !Game.isGameKeyPressed(GameKey.MoveForward) && !Game.isGameKeyPressed(GameKey.MoveBackward) && !Game.isGameKeyPressed(GameKey.MoveLeft) && !Game.isGameKeyPressed(GameKey.MoveRight))
                            {
                                GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rpg", "rstop_l", 1.0);
                                GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rpg", "rstop_r", 1.0);
                                Game.WaitInCurrentScript(0);
                            }
                            if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_rpg", "idle"))
                            {
                                GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rpg", "idle", 1.0);
                            }
                        }
                    }
                }
            }

            if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_rpg", "run_turn_180_l"))
            {
                GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rpg", "run_turn_180_l", turnpntr);
                if (!Game.isGameKeyPressed(GameKey.Aim) && !Game.isGameKeyPressed(GameKey.MoveForward) && !Game.isGameKeyPressed(GameKey.MoveBackward) && !Game.isGameKeyPressed(GameKey.MoveLeft) && !Game.isGameKeyPressed(GameKey.MoveRight))
                {
                    GTA.Native.Function.Call("TASK_PLAY_ANIM_NON_INTERRUPTABLE", Game.LocalPlayer.Character, "idle", "move_rpg", 5.00, 0, 1, 0, 0, -1);
                    Game.WaitInCurrentScript(200);
                    if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_rpg", "idle"))
                    {
                        GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rpg", "run_turn_180_l", 1.0);
                        GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rpg", "idle", 0.95);
                        while (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_rpg", "idle") && !Game.isGameKeyPressed(GameKey.Aim) && !Game.isGameKeyPressed(GameKey.MoveForward) && !Game.isGameKeyPressed(GameKey.MoveBackward) && !Game.isGameKeyPressed(GameKey.MoveLeft) && !Game.isGameKeyPressed(GameKey.MoveRight))
                        {
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rpg", "rstop_l", 1.0);
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rpg", "rstop_r", 1.0);
                            Game.WaitInCurrentScript(0);
                        }
                        if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_rpg", "idle"))
                        {
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rpg", "idle", 1.0);
                        }
                    }
                }
                if (turnpntr > 0.57 && turnpntr < 0.7)
                {
                    GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rpg", "run_turn_180_l", 0.84);
                    if (!Game.isGameKeyPressed(GameKey.Aim) && !Game.isGameKeyPressed(GameKey.MoveForward) && !Game.isGameKeyPressed(GameKey.MoveBackward) && !Game.isGameKeyPressed(GameKey.MoveLeft) && !Game.isGameKeyPressed(GameKey.MoveRight))
                    {
                        GTA.Native.Function.Call("TASK_PLAY_ANIM_NON_INTERRUPTABLE", Game.LocalPlayer.Character, "idle", "move_rpg", 5.00, 0, 1, 0, 0, -1);
                        Game.WaitInCurrentScript(200);
                        if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_rpg", "idle"))
                        {
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rpg", "run_turn_180_l", 1.0);
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rpg", "idle", 0.95);
                            while (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_rpg", "idle") && !Game.isGameKeyPressed(GameKey.Aim) && !Game.isGameKeyPressed(GameKey.MoveForward) && !Game.isGameKeyPressed(GameKey.MoveBackward) && !Game.isGameKeyPressed(GameKey.MoveLeft) && !Game.isGameKeyPressed(GameKey.MoveRight))
                            {
                                GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rpg", "rstop_l", 1.0);
                                GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rpg", "rstop_r", 1.0);
                                Game.WaitInCurrentScript(0);
                            }
                            if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "move_rpg", "idle"))
                            {
                                GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "move_rpg", "idle", 1.0);
                            }
                        }
                    }
                }
            }
        }
    }
}
