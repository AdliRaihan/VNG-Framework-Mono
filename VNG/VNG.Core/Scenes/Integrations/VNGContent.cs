using Microsoft.Xna.Framework.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VNG.Core.Scenes.DependencyInjections;

namespace VNG.Core.Scenes.Helper
{
    internal class VNGContent : ContentDI
    {
        public ContentManager getContentManager;

        ContentManager ContentDI.getContentManager => getContentManager;

        public VNGContent(ContentManager contentManager)
        {
            this.getContentManager = contentManager;
        }

    }
}
