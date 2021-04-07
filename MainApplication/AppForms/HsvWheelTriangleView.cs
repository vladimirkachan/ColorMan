
namespace ColorMan.AppForms
{
    public partial class HsvWheelTriangleView : RectSlimView
    {
        public HsvWheelTriangleView()
        {
            InitializeComponent();
            picker.SetColorBoxesBrushes();
            Packs.Add(new Pack(picker.IwheelItem, cnud1));
            Packs.Add(new Pack(picker.Iaitem, cnud2));
            Packs.Add(new Pack(picker.Ihitem, cnud3));
            BoundsDefference = 28;
            LayoutPermit = true;
        }
    }
}
