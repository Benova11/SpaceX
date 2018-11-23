using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using FarseerPhysics.Dynamics;
using FarseerPhysics.Factories;

namespace SpaceX_new
{
    class Rocket
    {
        private Body body;
        private Vector2 position;
        private Vector2 size;
        private Texture2D texture;

        public Rocket(World world,Vector2 size, Texture2D texture)
        {
            this.size = size;
            body = BodyFactory.CreateRectangle(world, size.X, size.Y, 1);
            body.BodyType = BodyType.Dynamic;
            body.CollisionCategories = Category.Cat1;
            this.texture = texture;
        }

        public Vector2 Position { get => position; set => position = value; }

        public void Draw(SpriteBatch spriteBatch)
        {
            Vector2 scale = new Vector2(size.X / (float)texture.Width, size.Y / (float)texture.Height);
            spriteBatch.Draw(texture, position, null, Color.White, body.Rotation, new Vector2(texture.Width, texture.Height), scale, SpriteEffects.None, 0);
        }
    }


}
