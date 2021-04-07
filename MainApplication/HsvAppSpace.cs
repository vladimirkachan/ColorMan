using ColorMan.ColorSpaces;
using ColorMan.ContractLibrary;

namespace ColorMan
{
	public class HsvAppSpace : AppSpace, IComponentSubscriber
	{
		public HsvAppSpace() : base(typeof(Hsv), "H", "S", "V") { }

		public override void SetValIn(IBaseSpace value)
		{
			Hsv hsv = value is Hsv ? (Hsv)value : new Hsv(value.ToColor());
			Component["H"].SetValIn(hsv.H01);
			Component["S"].SetValIn(hsv.Saturation);
			Component["V"].SetValIn(hsv.Value);
		}
        public override void NewColor(object sender, LinkedItemEventArgs<float> args)
		{
			float v0 = Component["H"].Val, v1 = Component["S"].Val, v2 = Component["V"].Val;
			TwoColorton.Instance.Space1 = Val = new Hsv(v0 * 360, v1, v2);
			OnNewValue();
		}
		public void SubscribeNewColor()
		{
			Component["H"].NewColor += NewColor;
			Component["S"].NewColor += NewColor;
			Component["V"].NewColor += NewColor;
		}
		public void UnsubscribeNewColor()
		{
			Component["H"].NewColor -= NewColor;
			Component["S"].NewColor -= NewColor;
			Component["V"].NewColor -= NewColor;

		}
	}
}
