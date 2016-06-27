using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Xna.Framework;
using MonoGame;
using HogeschoolSen.Buttons;
using HogeschoolSen.TextLabels;
using HogeschoolSen.Collections;
using HogeschoolSen.Visitor;
using Microsoft.Xna.Framework.Graphics;

namespace HogeschoolSen
{
    class Game : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Texture2D t;

        public Game()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void LoadContent()
        {
            base.LoadContent();
            spriteBatch = new SpriteBatch(GraphicsDevice);
            t = new Texture2D(GraphicsDevice, 1, 1);
            t.SetData<Color>(
                new Color[] { Color.Black });

        }

        protected override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            GraphicsDevice.Clear(Color.AliceBlue);
        }

        protected override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);

            spriteBatch.Begin();

            // Factory
            var buttonFactory = new ButtonFactory();
            var colorFactory = new ColorFactory();
            var defaultButtons = new UIElements();
            defaultButtons.AddElement(buttonFactory.makeNewButton("yellow", "Yellow button pressed"));
            defaultButtons.AddElement(buttonFactory.makeNewButton("red", "Red button pressed"));
            defaultButtons.AddElement(buttonFactory.makeNewButton("blue", "Blue button pressed"));

            var defaultButtonsIterator = defaultButtons.CreateIterator();
            var yellowButton = (AbstractButton) defaultButtonsIterator.First();

            var defaultButton = (IButton) defaultButtonsIterator.First();
            var xPos = 0;
            while (defaultButton != null)
            {
                Texture2D defaultButtonRect = new Texture2D(graphics.GraphicsDevice, 25, 25);
                Color[] defaultButtonColor = new Color[25 * 25];
                for (int i = 0; i < defaultButtonColor.Length; ++i) defaultButtonColor[i] = colorFactory.MakeColor(defaultButton.GetColor());
                defaultButtonRect.SetData(defaultButtonColor);
                spriteBatch.Draw(defaultButtonRect, new Vector2(xPos, 0), colorFactory.MakeColor(defaultButton.GetColor()));
                
                defaultButton.DoAction();
                xPos += 25;
                defaultButton = (IButton) defaultButtonsIterator.Next();
            }

            // Decorator
            var adjustableYellowButton = new SizeAdjustableDecorator(yellowButton);
            adjustableYellowButton.AdjustHeight(40);

            Texture2D rect = new Texture2D(graphics.GraphicsDevice, adjustableYellowButton.GetWidth(), adjustableYellowButton.GetHeight());
            Color[] data = new Color[adjustableYellowButton.GetWidth() * adjustableYellowButton.GetHeight()];
            for (int i = 0; i < data.Length; ++i) data[i] = colorFactory.MakeColor(adjustableYellowButton.GetColor());
            rect.SetData(data);
            spriteBatch.Draw(rect, new Vector2(0, 50), colorFactory.MakeColor(adjustableYellowButton.GetColor()));

            // Adapter
            IButton textLabelAdaptere = new TextLabelAdapter(new TextLabel());
            textLabelAdaptere.SetAction("This is the Adaptee");
            textLabelAdaptere.DoAction();

            // Iterator
            UIElements allElements = new UIElements();
            allElements.AddElement(adjustableYellowButton);
            allElements.AddElement(textLabelAdaptere);

            Iterator iterator = allElements.CreateIterator();
            Console.WriteLine("Iterating over collection:");
            var item = (IButton)iterator.First();
            while (item != null)
            {
                item.DoAction();
                item = (IButton)iterator.Next();
            }

            // Visitor
            var visitor = new ButtonVisitor();
            adjustableYellowButton.Accept(visitor);

            spriteBatch.End();
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
    
            using (var game = new Game())
            {
                game.Run();
            }
        }
    }
}
