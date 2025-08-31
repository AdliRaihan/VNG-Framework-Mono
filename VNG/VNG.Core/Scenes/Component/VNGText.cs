using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Text;
using VNG.Core.Scenes.DependencyInjections;

namespace VNG.Core.Scenes.Component
{
    internal class VNGText : VNGComponent
    {
        public float width = 125f;

        public string placeholderText = string.Empty;

        internal override bool isTextComponent => true;

        internal override Rectangle bounds => new Rectangle
            (constraint.getFinalPosition().ToPoint(), Font.MeasureString(Text).ToPoint());

        internal override SpriteFont Font => ContentDI.GetInstance().getContentManager.Load<SpriteFont>("fonts/Hud");

        public VNGText(string text)
        {
            Text = text;
            Font.LineSpacing = 14;
            setMaximumWidth(width);
        }

        public void setText(string text)
        {
            // Minimize Processing unit for loops 
            if (placeholderText == text)
                return;

            Text = placeholderText = text;
            
            setMaximumWidth(width);
        }

        public void setMaximumWidth(float width)
        {
            StringBuilder plainText = new StringBuilder();

            StringBuilder finalText = new StringBuilder();

            foreach (var item in Text)
            {
                plainText.Append(item);

                Vector2 fontSize = Font.MeasureString(plainText);

                if (fontSize.X > width)
                {
                    finalText.AppendLine(plainText.ToString());
                    plainText = new StringBuilder();
                }
            }

            // Add Leftover text that isn't made inside condition
            Text = finalText.Append(plainText).ToString();
        }
    }
}
