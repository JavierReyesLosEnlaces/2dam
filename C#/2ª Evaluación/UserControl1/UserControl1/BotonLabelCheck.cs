using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserControl1
{
    public partial class BotonLabelCheck : Button
    {
        /*
        public BotonLabelCheck()
        {
            InitializeComponent();
        }

        public BotonLabelCheck(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        */
        // 1. Atributo para redimensionar
        private bool redimensionar = true;

        // 2. getters y setters
        private bool Redimensionar
        {
            get { return redimensionar; }
            set { redimensionar = value; }
        }

        // Cuando pasamos el ratón por encima
        protected override void OnMouseEnter (EventArgs e)
        {
            if (redimensionar)
            {
                this.Size = new System.Drawing.Size(150, 150);
            }
            // redirecciona el evento al evento de la vlase base button
            base.OnMouseEnter(e);
        }
    }
}
