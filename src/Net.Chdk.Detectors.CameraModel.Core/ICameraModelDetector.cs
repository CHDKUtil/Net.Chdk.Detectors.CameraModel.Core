using Net.Chdk.Model.Card;

namespace Net.Chdk.Detectors.CameraModel
{
    public interface ICameraModelDetector
    {
        CameraList GetCameraModels(CardInfo cardInfo);
    }
}
