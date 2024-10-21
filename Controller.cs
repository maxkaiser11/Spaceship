﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Spaceship
{
    internal class Controller
    {
        public List<Asteroid> asteroids = new List<Asteroid>();
        public double timer = 2;
        public double maxTime = 2;
        public int nextSpeed = 240;
        public bool inGame = false;

        public void conUpdate(GameTime gameTime)
        {
            // Game Loop
            if (inGame)
            {
                timer -= gameTime.ElapsedGameTime.TotalSeconds;
            }
            else
            {
                KeyboardState kState = Keyboard.GetState();
                if (kState.IsKeyDown(Keys.Enter))
                {
                    inGame = true;
                }
            }


            // Every time timer reachers 0, spawn an asteroid
            if (timer <= 0 )
            {
                asteroids.Add(new Asteroid(nextSpeed));
                timer = maxTime;
                
                if (maxTime > 0.5)
                {
                    maxTime -= 0.1;
                }
                if (nextSpeed < 720)
                {
                    nextSpeed += 4;
                }
            }
        }
    }
}
