using Net.Chdk.Model.CameraModel;
using Net.Chdk.Model.Card;

namespace Net.Chdk.Detectors.CameraModel
{
    public interface ICameraModelDetector
    {
        CameraModelInfo GetCameraModel(CardInfo cardInfo);
    }
}
