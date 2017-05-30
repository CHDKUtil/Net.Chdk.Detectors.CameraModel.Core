using System;

namespace Net.Chdk.Detectors.CameraModel
{
    public interface IFileCameraModelDetector
    {
        CameraModels GetCameraModels(string filePath, IProgress<double> progress);
    }
}
