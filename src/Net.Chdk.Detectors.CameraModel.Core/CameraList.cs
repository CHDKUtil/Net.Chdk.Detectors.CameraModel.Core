using Net.Chdk.Model.Camera;
using Net.Chdk.Model.CameraModel;

namespace Net.Chdk.Detectors.CameraModel
{
    public sealed class CameraList
    {
        public CameraInfo Info { get; set; }
        public CameraModelInfo[] Models { get; set; }
    }
}
