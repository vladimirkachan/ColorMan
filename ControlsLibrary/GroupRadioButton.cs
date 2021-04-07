using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ColorMan.ControlsLibrary
{
    public class GroupRadioButton : RadioButton
    {
        IList<GroupRadioButton> group;
        public Control Outer { get; set; }
        public void SetGroup(IList<GroupRadioButton> arg)
        {
            group = arg;
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData != Keys.Tab) return base.ProcessCmdKey(ref msg, keyData);
            int count = group.Count;
            int i = group.IndexOf(this);
            RadioButton rb = group[++i % count];
            rb.Checked = true;
            rb.Focus();
            return true;
        }
        protected override void OnLostFocus(EventArgs e)
        {
            Keys mod = ModifierKeys & Keys.Modifiers;
            if (mod == Keys.Shift) Outer.Focus();
            base.OnLostFocus(e);
        }
    }
}
