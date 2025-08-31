
using Microsoft.Xna.Framework;
using VNG.Core.Scenes.Component;
using VNG.Core.Scenes.Core;
using VNG.WindowsDX.Scenes.DependencyInjections;
using static System.Net.Mime.MediaTypeNames;

namespace VNG.Core.Scenes.SceneController
{
    internal class MainMenu: VNGScreenManager
    {

        private VNGText labelText;

        public override void screenDidAppear()
        {
            setupUI();
            setupLayout();
        }
        public override void runtimeUpdate()
        {
            if (MouseDI.GetInstance().mouseLeftDown)
            {
                this.pushNewScreen(new UserSettingMenu());
            }
        }

        private void setupUI()
        {
            labelText = new VNGText("Hello World From Main Menu");
            view.addComponent(labelText);
        }

        private void setupLayout()
        {
            labelText.make().addTopConstraintFrom(view.screenSize, new Vector2(120, 120));
        }
    }
}
