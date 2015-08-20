using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        //input
        string[] cubeDimensions=Console.ReadLine().Split(' ');
        int width = int.Parse(cubeDimensions[0]);
        int heigth = int.Parse(cubeDimensions[1]);
        int depth = int.Parse(cubeDimensions[2]);

        string[, ,] subCubePreperties = new string[width, heigth, depth];
        for (int level = 0; level < heigth; level++)
        {
            string[] subCubePrepertiesInput = Regex.Replace(Console.ReadLine(), @"([^0-9])\s+", m => m.Groups[1].Value).Split(new char[] { '(', ')', '|' }, StringSplitOptions.RemoveEmptyEntries);
            int subCubePrepertiesInputIndex = 0;
            for (int d = 0; d < depth; d++)
                for (int w = 0; w < width; w++, subCubePrepertiesInputIndex++)
                    subCubePreperties[w, level, d] = subCubePrepertiesInput[subCubePrepertiesInputIndex];
        }
        
        string[] ballStartPos=Console.ReadLine().Split(' ');
        int ballWidth = int.Parse(ballStartPos[0]);
        int ballHeigth = 0;
        int ballDepth = int.Parse(ballStartPos[1]);
        //logic
        bool stuck = false;
        bool exited = false;
        while (ballHeigth < heigth && !stuck && !exited)
        {
            switch (subCubePreperties[ballWidth, ballHeigth, ballDepth][0])
            {
                case 'S':
                    if (ballHeigth == heigth - 1)//the balli is on the last level
                    {
                        exited = true;
                        break;
                    }

                    int newDepth = ballDepth, newWidth = ballWidth;
                    if (subCubePreperties[ballWidth, ballHeigth, ballDepth].IndexOf("F", 1)!=-1)
                        newDepth --;
                    else if (subCubePreperties[ballWidth, ballHeigth, ballDepth].IndexOf("B", 1) != -1)
                        newDepth ++;
                    if (subCubePreperties[ballWidth, ballHeigth, ballDepth].IndexOf("L", 1) != -1)
                        newWidth --;
                    else if (subCubePreperties[ballWidth, ballHeigth, ballDepth].IndexOf("R", 1) != -1)
                        newWidth ++;
                    //if the ball can slide to the new coordinates
                    if (newWidth >= 0 && newWidth < width && newDepth >= 0 && newDepth < depth)
                    {
                        ballHeigth++;
                        ballWidth = newWidth;
                        ballDepth = newDepth;
                    }
                    else stuck = true;

                    break;
                case 'T':
                    Regex cordinates = new Regex("[0-9]+");
                    Match cordinate = cordinates.Match(subCubePreperties[ballWidth, ballHeigth, ballDepth]);
                    ballWidth = int.Parse(cordinate.ToString());
                    cordinate = cordinate.NextMatch();
                    ballHeigth = int.Parse(cordinate.ToString());
                    break;
                case 'E':
                    if (ballHeigth == heigth - 1)
                    {
                        exited = true;
                        break;
                    }
                    ballHeigth++;
                    break;
                default:
                    stuck = true;//case B:
                    break;
            }
        }
        Console.WriteLine("{0}\n{1} {2} {3}", exited ? "Yes" : "No", ballWidth, ballHeigth, ballDepth);
    }
}
