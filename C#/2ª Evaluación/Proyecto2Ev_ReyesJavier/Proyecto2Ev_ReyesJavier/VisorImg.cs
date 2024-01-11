using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2Ev_ReyesJavier
{
    public partial class VisorImg : Control
    {
        public VisorImg()
        {
            InitializeComponent();
            this.Size = new Size(100, 50);
            this.BackColor = Color.White;
        }

        public VisorImg(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }
    }
}
    