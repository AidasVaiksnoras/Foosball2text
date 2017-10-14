using Emgu.CV;
using Emgu.CV.Structure;

namespace Logic
{
    public interface IBallWatcher
    {
        Ball Ball { get; }

        void UpdateBallWatcher(Image<Gray, byte> image);
    }
}