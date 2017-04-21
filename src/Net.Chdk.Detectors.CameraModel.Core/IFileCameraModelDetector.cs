namespace Net.Chdk.Detectors.CameraModel
{
    public interface IFileCameraModelDetector
    {
        CameraModels GetCameraModels(string filePath);
    }
}
