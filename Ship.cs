using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Spaceship
{
    internal class Ship
    {
        static public Vector2 defaultPosition = new Vector2(640, 360);
        public Vector2 position = defaultPosition;
        public int speed = 180;

        public void shipUpdate(GameTime gameTime)
        {
            KeyboardState kState = Keyboard.GetState();
            float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;

            if (kState.IsKeyDown(Keys.D))
            {
                position.X += speed * dt;
            }

            if (kState.IsKeyDown(Keys.A))
            {
                position.X -= speed * dt;
            }

            if (kState.IsKeyDown(Keys.S))
            {
                position.Y += speed * dt;
            }

            if (kState.IsKeyDown(Keys.W))
            {
                position.Y -= speed * dt;
            }
        }
    }
}
