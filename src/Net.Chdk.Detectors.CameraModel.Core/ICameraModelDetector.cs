using Net.Chdk.Model.Card;

namespace Net.Chdk.Detectors.CameraModel
{
    public interface ICameraModelDetector
    {
        CameraModels GetCameraModels(CardInfo cardInfo);
    }
}
