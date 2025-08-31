using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using VNG.WindowsDX.Scenes.DependencyInjections;

namespace VNG.WindowsDX.Scenes.Helper
{
    internal class VNGMouse: MouseInjections
    {
        Vector2 mousePosition
        {
            get
            {
                return Mouse.GetState().Position.ToVector2();
            }
        }

        bool mouseLeftUp
        {
            get
            {
                return Mouse.GetState().LeftButton == ButtonState.Released;
            }
        }

        bool mouseRightUp
        {
            get
            {
                return Mouse.GetState().RightButton == ButtonState.Released;
            }
        }

        bool mouseLeftDown
        {
            get
            {
                return Mouse.GetState().LeftButton == ButtonState.Pressed;
            }
        }

        public bool mouseRightDown
        {
            get
            {
                return Mouse.GetState().LeftButton == ButtonState.Pressed;
            }
        }

        Vector2 MouseInjections.mousePosition => mousePosition;

        bool MouseInjections.mouseLeftUp => mouseLeftUp;

        bool MouseInjections.mouseRightUp => mouseRightUp;

        bool MouseInjections.mouseLeftDown => mouseLeftDown;

        private Game game;

        public VNGMouse(Game game)
        {
            this.game = game;
        }

        public void OnUpdate()
        {
            if (this.game == null)
                return;

            if (this.mouseLeftDown)
            {
                System.Diagnostics.Debug.WriteLine(mousePosition.ToString());
            }
        }
    }
}
