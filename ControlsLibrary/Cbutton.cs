using System;
using System.Drawing;
using System.Windows.Forms;

namespace ColorMan.ControlsLibrary
{
    public class Cbutton : Button
    {
        Form form;

        public Color ActiveBorderColor { get; set; }
        public Color ActiveForeColor { get; set; }
        public Color ActiveBackColor { get; set; }
        public Color DeactiveBorderColor { get; set; }
        public Color DeactiveForeColor { get; set; }
        public Color DeactiveBackColor { get; set; }
        public Color LightingBorderColor { get; set; }
        public Color LightingBackColor { get; set; }

        public Cbutton()
        {
            ActiveForeColor = Color.White;
            ActiveBackColor = Color.FromArgb(64, 64, 64);
            DeactiveForeColor = Color.Black;
            DeactiveBackColor = Color.LightGray;
            ActiveBorderColor = SystemColors.MenuHighlight;
            FlatAppearance.BorderColor = DeactiveBorderColor = SystemColors.WindowFrame;
            LightingBorderColor = Color.Gold;
            LightingBackColor = Color.FromArgb(244, 244, 179);
            FlatStyle = FlatStyle.Standard;
            FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 77, 153);
            FlatAppearance.BorderSize = 2;
            Font = new Font("Tahoma", 8.25f);
        }

        void form_Activated(object sender, EventArgs e)
        {
            if (form.ActiveControl == this) OnEnter(e);
        }
        void OnLoad()
        {
            form = FindForm();
            if (form != null) form.Activated += form_Activated;
        }
        protected override void OnLayout(LayoutEventArgs levent)
        {
            if (form == null) OnLoad();
            BackColor = DeactiveBackColor;
            TextAlign = ContentAlignment.MiddleCenter;
            base.OnLayout(levent);
        }
        protected override void OnEnter(EventArgs e)
        {
            OnActive();
            base.OnEnter(e);
        }
        void OnActive()
        {
            ForeColor = ActiveForeColor;
            BackColor = ActiveBackColor;
            FlatAppearance.BorderColor = ActiveBorderColor;
        }
        protected override void OnLeave(EventArgs e)
        {
            ForeColor = DeactiveForeColor;
            BackColor = DeactiveBackColor;
            FlatAppearance.BorderColor = DeactiveBorderColor;
            base.OnLeave(e);
        }
        protected override void OnMouseHover(EventArgs e)
        {
            if (!Focused)
            {
                FlatAppearance.BorderColor = LightingBorderColor;
                BackColor = LightingBackColor;
            }
            base.OnMouseHover(e);
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            FlatAppearance.BorderColor = Focused ? ActiveBorderColor : DeactiveBorderColor;
            BackColor = Focused ? ActiveBackColor : DeactiveBackColor;
            base.OnMouseLeave(e);
        }
    }
}
