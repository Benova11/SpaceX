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
    class Land
    {
        private Body body;
        private Fixture fixture;
        private Vector2 position;
        private Vector2 size;
        private Texture2D texture;

        public Land(World world, Vector2 size, Texture2D texture)
        {
            body = BodyFactory.CreateRectangle(world, size.X, size.Y,1000);
            body.BodyType = BodyType.Static;
            body.CollisionCategories = Category.Cat2;
            this.texture = texture;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Vector2 scale = new Vector2(size.X / (float)texture.Width, size.Y / (float)texture.Height);
            spriteBatch.Draw(texture, position, null, Color.White, body.Rotation, new Vector2(texture.Width / 2.0f, texture.Height / 2.0f), scale, SpriteEffects.None, 0);
        }
    }
}
