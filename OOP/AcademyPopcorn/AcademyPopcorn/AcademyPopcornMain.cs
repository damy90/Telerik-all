using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class AcademyPopcornMain
    {
        const int WorldRows = 23;
        public const int WorldCols = 40;
        const int RacketLength = 6;

        static void Initialize(Engine engine)
        {
            int startRow = 3;
            int startCol = 2;
            int endCol = WorldCols - 2;

            for (int i = startCol; i < endCol; i++)
            {
                Block currBlock = new Block(new MatrixCoords(startRow, i));

                engine.AddObject(currBlock);
            }

            for (int i = startCol; i < endCol; i++)
            {
                UnpassableBlock currBlock = new UnpassableBlock(new MatrixCoords(startRow - 2, i));

                engine.AddObject(currBlock);
            }

            for (int i = startCol; i < endCol; i+=2)
            {
                ExplodingBlock currBlock = new ExplodingBlock(new MatrixCoords(startRow + 1, i));

                engine.AddObject(currBlock);
            }
            for (int i = startCol; i < endCol; i += 2)
            {
                GiftBlock currBlock = new GiftBlock(new MatrixCoords(startRow + 2, i));

                engine.AddObject(currBlock);
            }
            Ball theBall = new Ball(new MatrixCoords(WorldRows / 2, 0),
                new MatrixCoords(-1, 1));
            UnstoppableBall unstoppable = new UnstoppableBall(new MatrixCoords(WorldRows / 2+4, 0),
                new MatrixCoords(-1, 1));

            engine.AddObject(theBall);
            engine.AddObject(unstoppable);

            ShoothingRacket theRacket = new ShoothingRacket(new MatrixCoords(WorldRows - 1, WorldCols / 2), RacketLength);

            engine.AddObject(theRacket);

            //TrailObject test = new TrailObject(3, new MatrixCoords(5, 5), new char[1, 1]{{'H'}});
            //engine.AddObject(test);

            //walls
            InitializeWalls(engine);
        }

        private static void InitializeWalls(Engine engine)
        {
            for (int row = 0; row < WorldRows; row++)
            {
                IndestructibleBlock wall = new IndestructibleBlock(new MatrixCoords(row, 0));
                engine.AddObject(wall);
                wall = new IndestructibleBlock(new MatrixCoords(row, WorldCols - 1));
                engine.AddObject(wall);
            }
            //ceiling
            for (int col = 1; col < WorldCols-1; col++)
            {
                IndestructibleBlock wall = new IndestructibleBlock(new MatrixCoords(0, col));
                engine.AddObject(wall);
            }
        }

        static void Main(string[] args)
        {
            IRenderer renderer = new ConsoleRenderer(WorldRows, WorldCols);
            IUserInterface keyboard = new KeyboardInterface();

            ShootingRacketEngine gameEngine = new ShootingRacketEngine(renderer, keyboard);

            keyboard.OnLeftPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketLeft();
            };

            keyboard.OnRightPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketRight();
            };

            keyboard.OnActionPressed += (sender, eventInfo) =>
            {
                gameEngine.ShootPlayerRacket();
            };

            Initialize(gameEngine);

            //

            gameEngine.Run();
        }
    }
}
