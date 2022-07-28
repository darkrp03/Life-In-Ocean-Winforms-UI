using OceanLogic;
using System.Media;

namespace Game
{
    internal static class SoundService
    {
        private static readonly SoundPlayer _soundPlayer;
        private static int currentMusicIndex = 0;

        public static bool IsMuted { get; set; } = false;

        static SoundService()
        {
            _soundPlayer = new SoundPlayer();
        }

        public static SoundPlayer SoundPlayer
        {
            get => _soundPlayer;
        }

        public static void SetDefaultMusic()
        {
            _soundPlayer.SoundLocation = GameSettings.gameSoundsPath[0];
        }

        public static void SetNextMusic()
        {
            if (++currentMusicIndex == GameSettings.gameSoundsPath.Length)
            {
                currentMusicIndex = 0;
            }

            _soundPlayer.SoundLocation = GameSettings.gameSoundsPath[currentMusicIndex];
        }

        public static void SetPreviousMusic()
        {
            if (--currentMusicIndex < 0)
            {
                currentMusicIndex = GameSettings.gameSoundsPath.Length - 1;
            }

            _soundPlayer.SoundLocation = GameSettings.gameSoundsPath[currentMusicIndex];
        }
    }
}
