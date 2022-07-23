using System;
using System.IO;

namespace OceanLogic
{
    public static class GameSettings
    {
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

        public static string PreyImagePath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + @"\Static files\Images\Fish.png";
        public static string PredatorImagePath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + @"\Static files\Images\Shark.png";
        public static string KillerWhaleImagePath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + @"\Static files\Images\Killer whale.png";
        public static string ObstacleImagePath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + @"\Static files\Images\Obstacle.png";
        public static string menuSongPath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + @"\Static files\Sounds\(REMIX) Space Harrier (Mitch Murder Remix).wav";
        public static string gameSongPath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + @"\Static files\Sounds\Undertale Megalovania Song Sound Effect.wav";
    }
}
