using Net.Chdk.Model.Card;
using Net.Chdk.Model.Software;

namespace Net.Chdk.Detectors.CameraModel
{
    public interface ICameraModelDetector
    {
        CameraModels GetCameraModels(CardInfo cardInfo, SoftwareInfo softwareInfo);
    }
}
