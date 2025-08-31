using Microsoft.Xna.Framework;
using VNG.Core.Scenes.DependencyInjections;

namespace VNG.WindowsDX.Scenes.DependencyInjections
{
    public interface MouseInjections
    {
        private static MouseInjections _instance;

        public Vector2 mousePosition { get; }

        public bool mouseLeftUp { get; }

        public bool mouseRightUp { get; }

        public bool mouseLeftDown { get; }

        public bool mouseRightDown { get; }

        public static MouseInjections GetInstance()
        {
            return _instance;
        }

        public static void SetInstance(MouseInjections injector)
        {
            _instance = injector;
        }
    }
}
