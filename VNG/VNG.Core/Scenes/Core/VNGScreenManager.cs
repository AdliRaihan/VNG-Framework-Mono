using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using VNG.Core.Scenes.DependencyInjections;
using VNG.Core.Scenes.Integrations;

namespace VNG.Core.Scenes.Core
{
    internal abstract class VNGScreenManager
    {

        public abstract void screenDidAppear();
        public abstract void runtimeUpdate();

        private VNGSpriteBatch _view;

        private GraphicsDevice _device;

        private Vector2 _view2dSize
        {
            get
            {
                return Vector2.Zero;
            }
        }

        public GraphicsDevice device
        {
            get
            {
                if (_device == null)
                {
                    // TODO: Make General Error to fix this weirdness
                    throw new InvalidOperationException("Lifecycle violation: this method cannot be called from Initialize. Use only within the designated lifecycle stage. ####");
                }
                return _device;
            }
        }

        public VNGSpriteBatch view
        {
            get
            {
                if (_view == null)
                {
                    // TODO: Make General Error to fix this weirdness
                    throw new InvalidOperationException("Lifecycle violation: this method cannot be called from Initialize. Use only within the designated lifecycle stage. ####");
                }
                return _view;
            }
        }

        public void setActive(GraphicsDevice device)
        {
            this._device = device;
            this._view = new VNGSpriteBatch(device);
        }

        public void screenDidDestroy() { }

        public void pushNewScreen(VNGScreenManager vngScreen)
        {
            VNGSceneManager<GraphicsDevice>.Shared().pushNewScreen(vngScreen);
        }

        public void destroyScreen()
        {
            VNGSceneManager<GraphicsDevice>.Shared().destroyScreen(this);
        }
    }
}
