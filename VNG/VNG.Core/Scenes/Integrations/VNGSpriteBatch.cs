using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using VNG.Core.Scenes.DependencyInjections;

namespace VNG.Core.Scenes.Integrations
{
    internal class VNGSpriteBatch: SpriteBatch
    {
        private List<SpriteBatchComponent> components = new List<SpriteBatchComponent>();

        public VNGSpriteBatch(GraphicsDevice graphicsDevice) : base(graphicsDevice) { }

        public VNGSpriteBatch(GraphicsDevice graphicsDevice, int capacity) : base(graphicsDevice, capacity) { }

        public void drawAll()
        {
            this.Begin();

            foreach (var component in this.components)
            {
                DrawString(component.Font, component.Text, new Vector2(25, 25), Color.White);
            }

            this.End();
        }

        public void addComponent(SpriteBatchComponent component)
        {
            components.Add(component);
        }
    }
}
