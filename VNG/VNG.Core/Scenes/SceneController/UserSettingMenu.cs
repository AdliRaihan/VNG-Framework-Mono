using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VNG.Core.Scenes.Component;
using VNG.Core.Scenes.Core;

namespace VNG.Core.Scenes.SceneController
{
    internal class UserSettingMenu : VNGScreenManager
    {
        private VNGText labelText;

        public override void runtimeUpdate()
        {
        }

        public override void screenDidAppear()
        {
            setupUI();
            setupLayout();
        }

        public void setupUI()
        {
            labelText = new VNGText("Hello From User Settings");
            view.addComponent(labelText);
        }

        public void setupLayout()
        {
            labelText.make().addTopConstraintFrom(view.screenSize, new Vector2(120, 120));
        }
    }
}
