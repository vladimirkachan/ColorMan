using ColorMan.ColorSpaces;
using ColorMan.ContractLibrary;

namespace ColorMan
{
    public class CmykAppSpace : AppSpace
    {
        public CmykAppSpace() : base(typeof(Cmyk), "C", "M", "Y", "K") { }

	    public override void SetValIn(IBaseSpace value)
	    {
			Cmyk cmyk = value.GetType() == SpaceType ? (Cmyk)value : new Cmyk(value.ToColor());
			Component["C"].SetValIn(cmyk.Cyan);
			Component["M"].SetValIn(cmyk.Magenta);
			Component["Y"].SetValIn(cmyk.Yellow);
			Component["K"].SetValIn(cmyk.KeyBlack);
	    }
        public override void NewColor(object sender, LinkedItemEventArgs<float> args)
        {
            float v0 = Component["C"].Val, v1 = Component["M"].Val, v2 = Component["Y"].Val, v3 = Component["K"].Val;
	        TwoColorton.Instance.Space1 = Val = new Cmyk(v0, v1, v2, v3);
            OnNewValue();
        }
    }
}
