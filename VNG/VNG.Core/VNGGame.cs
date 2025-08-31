using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using VNG.Core.Localization;
using VNG.Core.Scenes.Component;
using VNG.Core.Scenes.Core;
using VNG.Core.Scenes.DependencyInjections;
using VNG.Core.Scenes.Helper;
using VNG.Core.Scenes.Integrations;
using VNG.Core.Scenes.SceneController;
using VNG.WindowsDX.Scenes.DependencyInjections;
using VNG.WindowsDX.Scenes.Helper;
using static System.Net.Mime.MediaTypeNames;

namespace VNG.Core
{
    /// <summary>
    /// The main class for the game, responsible for managing game components, settings, 
    /// and platform-specific configurations.
    /// </summary>
    public class VNGGame : Game
    {
        // Resources for drawing.
        private GraphicsDeviceManager graphicsDeviceManager;

        public readonly static bool IsMobile = OperatingSystem.IsAndroid() || OperatingSystem.IsIOS();

        public readonly static bool IsDesktop = OperatingSystem.IsMacOS() || OperatingSystem.IsLinux() || OperatingSystem.IsWindows();

        VNGText mouseStateLabel;

        // If this null then something is went wrong, don't use nullable on this one
        // Cause might causing unexpected bug
        VNGSceneManager<GraphicsDevice> screenManager;
        
        public VNGGame()
        {
            graphicsDeviceManager = new GraphicsDeviceManager(this);

            setupInjections();

            Content.RootDirectory = "Content";

            // Share GraphicsDeviceManager as a service.
            Services.AddService(typeof(GraphicsDeviceManager), graphicsDeviceManager);

            // Configure screen orientations.
            graphicsDeviceManager.SupportedOrientations = DisplayOrientation.LandscapeLeft | DisplayOrientation.LandscapeRight;
            IsMouseVisible = true;
            // set resizable
            Window.AllowUserResizing = true;
        }

        protected override void Initialize()
        {
            base.Initialize();

            List<CultureInfo> cultures = LocalizationManager.GetSupportedCultures();
            var languages = new List<CultureInfo>();
            for (int i = 0; i < cultures.Count; i++)
            {
                languages.Add(cultures[i]);
            }

            var selectedLanguage = LocalizationManager.DEFAULT_CULTURE_CODE;
            LocalizationManager.SetCulture(selectedLanguage);
        }

        protected override void LoadContent()
        {
            base.LoadContent();
            screenManager = VNGSceneManager<GraphicsDevice>.instatiate(this.GraphicsDevice);
            mouseStateLabel = new VNGText("Hello World");
            screenManager.pushNewScreen(new MainMenu());
        }

        protected override void Update(GameTime gameTime)
        {
            screenManager.runtimeUpdate();
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.MonoGameOrange);
            screenManager.render();
            base.Draw(gameTime);
        }

        private void setupInjections()
        {
            MouseInjections.SetInstance(new VNGMouse(this));
            ContentInjections.SetInstance(new VNGContent(Content));
        }
    }
}