using ColorMan.ColorSpaces;
using ColorMan.ContractLibrary;

namespace ColorMan
{
    public class RgbAppSpace : AppSpace
    {
        public RgbAppSpace() : base(typeof(Rgb),"R", "G", "B") {}

        public override void SetValIn(IBaseSpace value)
        {
	        Rgb rgb = value is Rgb ? (Rgb)value : new Rgb(value.ToColor());
            Component["R"].SetValIn(rgb.R01);
			Component["G"].SetValIn(rgb.G01);
			Component["B"].SetValIn(rgb.B01);
        }
        public override void NewColor(object sender, LinkedItemEventArgs<float> args)
        {
            float v0 = Component["R"].Val, v1 = Component["G"].Val, v2 = Component["B"].Val;
	        TwoColorton.Instance.Space1 = Val = new Rgb(v0 * 255, v1 * 255, v2 * 255);
            OnNewValue();
        }
    }
}
