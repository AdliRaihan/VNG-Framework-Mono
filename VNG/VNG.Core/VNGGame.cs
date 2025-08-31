using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
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
        VNGSceneManager<GraphicsDevice> screenManager;
        
        public VNGGame()
        {
            // Set Manager ->
            graphicsDeviceManager = new GraphicsDeviceManager(this);
            // Set Initialize Injections ->
            setupInjections();
            // Set Root Directory for Content ->
            Content.RootDirectory = "Content";
            // Set GraphicsManagerDevice Service ->
            Services.AddService(typeof(GraphicsDeviceManager), graphicsDeviceManager);
            // Set Screen Config ->
            graphicsDeviceManager.SupportedOrientations = DisplayOrientation.LandscapeLeft | DisplayOrientation.LandscapeRight;
            // Set Mouse Is Visible ->
            IsMouseVisible = true;
            // Set resizable ->
            Window.AllowUserResizing = true;
        }

        protected override void Initialize()
        {
            base.Initialize();
            List<CultureInfo> cultures = LocalizationManager.GetSupportedCultures();
            var languages = new List<CultureInfo>();
            foreach (var item in cultures)
            {
                // Much safer without index
                languages.Add(item);
            }
            var selectedLanguage = LocalizationManager.DEFAULT_CULTURE_CODE;
            LocalizationManager.SetCulture(selectedLanguage);
        }

        protected override void LoadContent()
        {
            screenManager = VNGSceneManager<GraphicsDevice>.instatiate(this.GraphicsDevice);
            screenManager.pushNewScreen(new MainMenu());
            base.LoadContent();
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
            MouseDI.SetInstance(new VNGMouse(this));
            ContentDI.SetInstance(new VNGContent(Content));
        }
    }
}