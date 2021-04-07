using ColorMan.ColorSpaces;
using ColorMan.ContractLibrary;

namespace ColorMan
{
    public class HslAppSpace : AppSpace, IComponentSubscriber
    {
        public HslAppSpace() : base(typeof(Hsl), "H", "S", "L") {}
        
        public override void SetValIn(IBaseSpace value)
        {
	        Hsl hsl = value is Hsl ? (Hsl)value : new Hsl(value.ToColor());
	        Component["H"].SetValIn(hsl.H01);
			Component["S"].SetValIn(hsl.Saturation);
			Component["L"].SetValIn(hsl.Lightness);
        }
        public override void NewColor(object sender, LinkedItemEventArgs<float> args)
        {
            float v0 = Component["H"].Val, v1 = Component["S"].Val, v2 = Component["L"].Val;
			TwoColorton.Instance.Space1 = Val = new Hsl(v0 * 360, v1, v2);
            OnNewValue();
        }
        public void SubscribeNewColor()
        {
            Component["H"].NewColor += NewColor;
            Component["S"].NewColor += NewColor;
            Component["L"].NewColor += NewColor;
        }
        public void UnsubscribeNewColor()
        {
            Component["H"].NewColor -= NewColor;
            Component["S"].NewColor -= NewColor;
            Component["L"].NewColor -= NewColor;
        }
    }
}
