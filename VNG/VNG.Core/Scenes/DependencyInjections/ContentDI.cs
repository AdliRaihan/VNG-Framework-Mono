using Microsoft.Xna.Framework.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace VNG.Core.Scenes.DependencyInjections
{
    internal interface ContentDI
    {
        public ContentManager getContentManager { get; }

        public static ContentDI instance;

        public static ContentDI GetInstance()
        {
            return instance;
        }

        public static void SetInstance(ContentDI contentManager)
        {
            instance = contentManager;
        }
    }
}
