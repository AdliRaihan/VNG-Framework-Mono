using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VNG.Core.Scenes.DependencyInjections;

namespace VNG.Core.Scenes.Component
{
    internal class VNGText : SpriteBatchComponent
    {

        SpriteFont Font => ContentInjections.GetInstance().getContentManager.Load<SpriteFont>("fonts/Hud");
        String Text;
        SpriteFont SpriteBatchComponent.Font => Font;
        string SpriteBatchComponent.Text => Text;

        public VNGText(string text)
        {
            Text = text;
        }

        public void setText(string text)
        {
            Text = text;
        }
    }
}
