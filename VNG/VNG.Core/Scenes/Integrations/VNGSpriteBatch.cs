using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using VNG.Core.Scenes.Component;
using VNG.Core.Scenes.DependencyInjections;

namespace VNG.Core.Scenes.Integrations
{
    internal class VNGSpriteBatch: SpriteBatch
    {
        private List<VNGComponent> components = new List<VNGComponent>();

        public Point screenSize
        {
            get
            {
                return this.GraphicsDevice.Viewport.Bounds.Size;
            }
        }

        public VNGSpriteBatch(GraphicsDevice graphicsDevice) : base(graphicsDevice) { }

        public VNGSpriteBatch(GraphicsDevice graphicsDevice, int capacity) : base(graphicsDevice, capacity) { }

        public void drawAll()
        {
            this.Begin();

            foreach (var component in this.components)
            {
                DrawString(
                    component.Font, 
                    component.Text, 
                    component.constraint.getFinalPosition(),
                    Color.White,
                    0.0f,
                    Vector2.Zero,
                    0.75f,
                    SpriteEffects.None,
                    1.0f
                );
            }

            this.End();

        }

        public void addComponent(VNGComponent component) => components.Add(component);

        public void flushComponent() => components.Clear();
    }
}
