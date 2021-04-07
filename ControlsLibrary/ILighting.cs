namespace ColorMan.ControlsLibrary
{
    public interface ILighting
    {
        bool CanLight();
        bool IsInside();
        void LightOn();
        void LightOff();
    }
}
