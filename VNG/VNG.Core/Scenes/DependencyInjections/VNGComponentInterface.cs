using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using VNG.Core.Scenes.Layouts;

namespace VNG.Core.Scenes.DependencyInjections
{
    internal interface VNGComponentInterface
    {

        public SpriteFont Font { get; }

        public string Text { get; }

        public bool isTextComponent { get; }

        public Rectangle bounds { get; }

        public UILayoutConstraint constraint { get; set; }

    }
}
