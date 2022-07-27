using System;
using System.IO;

namespace OceanLogic
{
    public static class GameSettings
    {
        private static string projectPath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;

        public const int defaultTimeToReproduce = 6;
        public const int defaultTimeToFeed = 6;
        public const int defaultNumRows = 20;
        public const int defaultNumCols = 75;
        public const int defaultNumPrey = 100;
        public const int defaultNumPredators = 20;
        public const int defaultNumKillerWhales = 5;
        public const int defaultNumObstacles = 70;
        public const char defaultPreyImage = 'f';
        public const char defaultPredatorImage = 'S';
        public const char defaultKillerWhaleImage = '$';
        public const char defaultObstacleImage = '#';
        public const char defaultEmptyImage = '-';
        public const int defaultNumIterations = 1000;

        public static string preyImagePath = projectPath + @"\Static files\Images\Fish.png";
        public static string predatorImagePath = projectPath + @"\Static files\Images\Shark.png";
        public static string killerWhaleImagePath = projectPath + @"\Static files\Images\Killer whale.png";
        public static string obstacleImagePath = projectPath + @"\Static files\Images\Obstacle.png";
        public static string menuSongPath = projectPath + @"\Static files\Sounds\Bon Jovi - Its my life.wav";

        public static string[] gameSounds = new string[] 
        { 
          projectPath + @"\Static files\Sounds\Undertale Megalovania Song Sound Effect.wav",
          projectPath + @"\Static files\Sounds\Crush 40 - Open Your Heart.wav",
          projectPath + @"\Static files\Sounds\Rollin-Limp Bizkit- Instrumental.wav"
        };
    }
}
