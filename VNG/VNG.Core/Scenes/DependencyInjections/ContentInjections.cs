using Microsoft.Xna.Framework.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace VNG.Core.Scenes.DependencyInjections
{
    public interface ContentInjections
    {
        public ContentManager getContentManager { get; }

        public static ContentInjections instance;

        public static ContentInjections GetInstance()
        {
            return instance;
        }

        public static void SetInstance(ContentInjections contentManager)
        {
            instance = contentManager;
        }
    }
}
