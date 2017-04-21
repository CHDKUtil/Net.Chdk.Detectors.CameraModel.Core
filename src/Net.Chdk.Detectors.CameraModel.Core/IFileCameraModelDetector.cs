namespace Net.Chdk.Detectors.CameraModel
{
    public interface IFileCameraModelDetector
    {
        CameraList GetCameraModels(string filePath);
    }
}
