﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Xna.Framework;
using MonoGame;
using HogeschoolSen.Buttons;
using HogeschoolSen.TextLabels;

namespace HogeschoolSen
{
    class Game : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;

        public Game()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void LoadContent()
        {
            base.LoadContent();
        }

        protected override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
        }
    }
    class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Factory
            var buttonFactory = new ButtonFactory();
            var yellowButton = buttonFactory.makeNewButton("yellow", "Yellow button pressed");
            var redButton = buttonFactory.makeNewButton("red", "Red button pressed");
            var blueButton = buttonFactory.makeNewButton("blue", "Blue button pressed");

            yellowButton.DoAction();
            redButton.DoAction();
            blueButton.DoAction();

            // Decorator
            var adjustableYellowButton = new SizeAdjustableDecorator(yellowButton);
            Console.WriteLine(adjustableYellowButton.GetHeight());
            adjustableYellowButton.AdjustHeight(40);
            Console.WriteLine(adjustableYellowButton.GetHeight());

            // Adapter
            IButton textLabelAdaptere = new TextLabelAdapter(new TextLabel());
            textLabelAdaptere.SetAction("This is the Adaptee");
            textLabelAdaptere.DoAction();


            using (var game = new Game())
            {
                game.Run();
            }
        }
    }
}
