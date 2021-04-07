
using ColorMan.ContractLibrary;

namespace ColorMan
{
    public interface IComponentSubscriber
    {
        void NewColor(object sender, LinkedItemEventArgs<float> args);
        void SubscribeNewColor();
        void UnsubscribeNewColor();
    }
}
