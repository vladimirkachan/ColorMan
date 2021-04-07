using ColorMan.ColorSpaces;
using ColorMan.ContractLibrary;
using ColorMan.ExtensionLibrary;

namespace ColorMan
{
    public class LabAppSpace : AppSpace, IComponentSubscriber
    {
        public LabAppSpace() : base(typeof(Lab), "L", "A", "B") { }

        public override void SetValIn(IBaseSpace value)
        {
	        Lab lab = value is Lab ? (Lab)value : new Lab(value.ToColor());
			Component["L"].SetValIn(lab.L01);
			Component["A"].SetValIn(lab.A01);
			Component["B"].SetValIn(lab.B01);
        }
        public override void NewColor(object sender, LinkedItemEventArgs<float> args)
	    {
		    float v0 = Component["L"].Val, v1 = Component["A"].Val, v2 = Component["B"].Val;
		    TwoColorton.Instance.Space1 =
		    Val = new Lab(v0.LinearToRange(0, 100), v1.LinearToRange(-128, 127), v2.LinearToRange(-128, 127));
		    OnNewValue();
	    }
	    public void SubscribeNewColor()
        {
            Component["L"].NewColor += NewColor;
            Component["A"].NewColor += NewColor;
            Component["B"].NewColor += NewColor;
        }
        public void UnsubscribeNewColor()
        {
            Component["L"].NewColor -= NewColor;
            Component["A"].NewColor -= NewColor;
            Component["B"].NewColor -= NewColor;
        }
    }
}
