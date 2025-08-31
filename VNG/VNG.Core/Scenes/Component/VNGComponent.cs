using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using VNG.Core.Scenes.DependencyInjections;
using VNG.Core.Scenes.Layouts;

namespace VNG.Core.Scenes.Component
{
    internal class VNGComponent : SpriteBatchComponent
    {
        internal virtual SpriteFont Font { get; set; }

        SpriteFont SpriteBatchComponent.Font => Font;

        internal virtual string Text { get; set; }

        string SpriteBatchComponent.Text => Text;

        internal virtual Rectangle bounds { get; set; } = Rectangle.Empty;

        Rectangle SpriteBatchComponent.bounds => bounds;

        internal virtual UILayoutConstraint constraint { get; set; } = new UILayoutConstraint();

        UILayoutConstraint SpriteBatchComponent.constraint { get => constraint; set => constraint = value; }

        internal virtual bool isTextComponent { get; set; } = false;

        bool SpriteBatchComponent.isTextComponent => isTextComponent;

        internal UILayoutConstraint make() => constraint;
    }
}
