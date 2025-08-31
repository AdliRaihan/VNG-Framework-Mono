using Microsoft.Xna.Framework;
using VNG.Core.Scenes.DependencyInjections;

namespace VNG.WindowsDX.Scenes.DependencyInjections
{
    internal interface MouseDI
    {
        private static MouseDI _instance;

        public Vector2 mousePosition { get; }

        public bool mouseLeftUp { get; }

        public bool mouseRightUp { get; }

        public bool mouseLeftDown { get; }

        public bool mouseRightDown { get; }

        public static MouseDI GetInstance()
        {
            return _instance;
        }

        public static void SetInstance(MouseDI injector)
        {
            _instance = injector;
        }
    }
}
