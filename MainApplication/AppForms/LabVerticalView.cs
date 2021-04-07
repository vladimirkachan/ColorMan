using ColorMan.ColorSpaces;

namespace ColorMan.AppForms
{
    public partial class LabVerticalView : VerticalLinearView
    {
        public LabVerticalView()
        {
            InitializeComponent();
            SetColorBoxBrushes();
        }
        void SetColorBoxBrushes()
        {
            vcbox1.BrushFunc = () =>
            {
                int n = vcbox1.ColorCount;
                for (int i = 0; i < n; i++) vcbox1.GetColors()[n - 1 - i] = 
                    Lab.FromLab(100f * i / (n - 1f), vcbox2.Val * 255f - 128f, vcbox3.Val * 255f - 128f);
                return vcbox1.UpdatedBrush();
            };
            vcbox2.BrushFunc = () =>
            {
                int n = vcbox2.ColorCount;
                for (int i = 0; i < n; i++) vcbox2.GetColors()[n - 1 - i] =
                    Lab.FromLab(vcbox1.Val * 100f, 255f * i / (n - 1f) - 128f, vcbox3.Val * 255f - 128f);
                return vcbox2.UpdatedBrush();
            };
            vcbox3.BrushFunc = () =>
            {
                int n = vcbox3.ColorCount;
                for (int i = 0; i < n; i++) vcbox3.GetColors()[n - 1 - i] =
                    Lab.FromLab(vcbox1.Val * 100f, vcbox2.Val * 255f - 128f, 255f * i / (n - 1f) - 128f);
                return vcbox3.UpdatedBrush();
            };
        }
    }
}
