using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VNG.Core.Scenes.DependencyInjections
{
    public interface SpriteBatchComponent
    {
        public SpriteFont Font { get; }
        public string Text { get; }
    }
}
