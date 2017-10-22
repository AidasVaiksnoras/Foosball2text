using Emgu.CV;
using Emgu.CV.Structure;

namespace Logic
{
    interface IGameWatcher
    {
        void ResetGame();
        void UpdateGameWatcher(Image<Gray, byte> image);
    }
}