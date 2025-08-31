
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
            if (MouseInjections.GetInstance().mouseLeftDown)
            {
                labelText.setText("Your Mom");
                return;
            }
            labelText.setText("Your Dad " + view.screenSize.ToString() + " asd asjdlka jasldkj alskdj kasdj kjasdkl jaslkdj aklsdjkasdlk jaskldj lajsd lkjaslkd jalkjsd ");
        }

        private void setupUI()
        {
            labelText = new VNGText("Hello World");
            view.addComponent(labelText);
        }

        private void setupLayout()
        {
            labelText.make().addTopConstraintFrom(view.screenSize, new Vector2(120, 120));
        }
    }
}
