using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using VNG.Core.Scenes.DependencyInjections;
using VNG.Core.Scenes.Layouts;

namespace VNG.Core.Scenes.Component
{
    internal class VNGComponent : VNGComponentInterface
    {
        internal virtual SpriteFont Font { get; set; }

        SpriteFont VNGComponentInterface.Font => Font;

        internal virtual string Text { get; set; }

        string VNGComponentInterface.Text => Text;

        internal virtual Rectangle bounds { get; set; } = Rectangle.Empty;

        Rectangle VNGComponentInterface.bounds => bounds;

        internal virtual UILayoutConstraint constraint { get; set; } = new UILayoutConstraint();

        UILayoutConstraint VNGComponentInterface.constraint { get => constraint; set => constraint = value; }

        internal virtual bool isTextComponent { get; set; } = false;

        bool VNGComponentInterface.isTextComponent => isTextComponent;

        internal UILayoutConstraint make() => constraint;
    }
}
