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

        public static void SetMusic()
        {
            if (currentMusicIndex == GameSettings.gameSounds.Length)
            {
                currentMusicIndex = 0;
            }

            _soundPlayer.SoundLocation = GameSettings.gameSounds[currentMusicIndex++];
        }
    }
}
