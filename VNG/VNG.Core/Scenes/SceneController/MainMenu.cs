using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VNG.Core.Scenes.Component;
using VNG.Core.Scenes.Core;
using VNG.Core.Scenes.DependencyInjections;
using VNG.Core.Scenes.Integrations;
using VNG.WindowsDX.Scenes.DependencyInjections;

namespace VNG.Core.Scenes.SceneController
{
    internal class MainMenu: VNGScreenManager
    {

        private VNGText labelText;

        public override void screenDidAppear()
        {
            setupUI();
        }
        public override void runtimeUpdate()
        {
            if (MouseInjections.GetInstance().mouseLeftDown)
            {
                labelText.setText("Your Mom");
                return;
            }
            labelText.setText("Your Dad");
        }

        private void setupUI()
        {
            labelText = new VNGText("Hello World");
            view.addComponent(labelText);
        }
    }
}
