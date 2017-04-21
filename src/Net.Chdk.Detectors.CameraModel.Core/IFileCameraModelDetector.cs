using Net.Chdk.Model.CameraModel;

namespace Net.Chdk.Detectors.CameraModel
{
    public interface IFileCameraModelDetector
    {
        CameraModelInfo[] GetCameraModels(string filePath);
    }
}
