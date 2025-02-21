using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buttons.Controls
{
    public class Time:Label
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            this.Text = "0:00";
            this.Font = new Font("ExtraLight", 11);
        }

    }
}
