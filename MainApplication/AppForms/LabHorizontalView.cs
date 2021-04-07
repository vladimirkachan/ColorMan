using ColorMan.ColorSpaces;

namespace ColorMan.AppForms
{
    public partial class LabHorizontalView : HorizontalLinearView
    {
        public LabHorizontalView()
        {
            InitializeComponent();
            SetColorBoxBrushes();
        }
        void SetColorBoxBrushes()
        {
            hcbox1.BrushFunc = () =>
            {
                int n = hcbox1.ColorCount;
                for (int i = 0; i < n; i++) 
                    hcbox1.GetColors()[i] = Lab.FromLab(100f * i / (n - 1f), hcbox2.Val * 255f - 128f, hcbox3.Val * 255f - 128f);
                return hcbox1.UpdatedBrush();
            };
            hcbox2.BrushFunc = () =>
            {
                int n = hcbox2.ColorCount;
                for (int i = 0; i < n; i++)
                    hcbox2.GetColors()[i] = Lab.FromLab(hcbox1.Val * 100f, 255f * i / (n - 1f) - 128f, hcbox3.Val * 255f - 128f);
                return hcbox2.UpdatedBrush();
            };
            hcbox3.BrushFunc = () =>
            {
                int n = hcbox3.ColorCount;
                for (int i = 0; i < n; i++)
                    hcbox3.GetColors()[i] = Lab.FromLab(hcbox1.Val * 100f, hcbox2.Val * 255f - 128f, 255f * i / (n - 1f) - 128f);
                return hcbox3.UpdatedBrush();
            };
        }
    }
}
