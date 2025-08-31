using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using VNG.Core.Scenes.Integrations;

#nullable enable
namespace VNG.Core.Scenes.Core
{
    internal class VNGSceneManager<T> where T : GraphicsDevice
    {
        private T? _device;

        private static VNGSceneManager<T>? instance;

        public List<VNGScreenManager> Screens = new List<VNGScreenManager>();

        private VNGScreenManager? activeScreen => Screens.Count > 0 ? Screens[^1] : null;

        public static VNGSceneManager<T> instatiate(T device)
        {
            if (instance == null)
            {
                instance = new VNGSceneManager<T>();
                instance._device = device;
            }
            return instance;
        }

        public static VNGSceneManager<T> Shared()
        {
            if (instance == null)
            {
                throw new InvalidOperationException("Should not reaccess this region");
            }
            return instance;
        }

        public void pushNewScreen(VNGScreenManager screen)
        {
            // TODO: Add Animation if needed

            // In a sense their device should not be nil?
            screen.setActive(this._device);

            Screens.Add(screen);

            screen.screenDidAppear();
        }

        public void presentScreen(VNGSpriteBatch screen)
        {
            // TODO: Add Animation if needed
            // Later Maybe
        }

        public void destroyScreen()
        {
            // TODO: Add Animation if needed
            if (activeScreen == null)
                return;
            Screens.Remove(activeScreen);
        }

        public void destroyScreen(VNGScreenManager screen)
        {
            Screens.Remove(screen);
        }

        public void render()
        {
            activeScreen?.view.drawAll();
        }

        public void runtimeUpdate()
        {
            activeScreen?.runtimeUpdate();
        }
    }
}
