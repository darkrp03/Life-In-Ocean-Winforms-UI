using System.Media;

namespace Game
{
    internal class SoundService
    {
        private static readonly SoundPlayer _soundPlayer;

        public static bool IsMuted { get; set; } = false;

        static SoundService()
        {
            _soundPlayer = new SoundPlayer();
        }

        public static SoundPlayer SoundPlayer
        {
            get => _soundPlayer;
        }
    }
}
