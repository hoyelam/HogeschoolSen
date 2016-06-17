using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Xna.Framework;
using MonoGame;
using HogeschoolSen.Buttons;

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
            var buttonFactory = new ButtonFactory();
            var yellowButton = buttonFactory.makeNewButton("yellow", "Yellow button pressed");
            var redButton = buttonFactory.makeNewButton("red", "Red button pressed");
            var blueButton = buttonFactory.makeNewButton("blue", "Blue button pressed");

            yellowButton.DoAction();
            redButton.DoAction();
            blueButton.DoAction();

            var yellowButtonSize = new SizeAdjustableDecorator(yellowButton);
            Console.WriteLine(yellowButtonSize.GetHeight());
            yellowButtonSize.AdjustHeight(40);
            Console.WriteLine(yellowButtonSize.GetHeight());
            using (var game = new Game())
            {
                game.Run();
            }
        }
    }
}
