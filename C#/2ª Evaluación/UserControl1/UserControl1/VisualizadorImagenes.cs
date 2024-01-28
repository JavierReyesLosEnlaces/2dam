using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserControl1
{
    public partial class VisualizadorImagenes : Panel // Este componente hereda de Panel

    {
        // clase de tipo controlador para representar im´ñagenes
        PictureBox pictureBox;
        public VisualizadorImagenes()
        {
            InitializeComponent();
            pictureBox = new PictureBox();
            this.Controls.Add(pictureBox);
        }

        // Atributos que le damos al componente: categorizamos el componente para la barra de herramientas
        [Category("Custom")]
        [Browsable(true)]
        [Description("Set path to image")]
        [Editor(typeof(System.Windows.Forms.Design.WindowsFormsComponentEditor),typeof(System.Drawing.Design.UITypeEditor))]

        public String ImageFile
        {
            set
            {
                Image img = Image.FromFile(value);
                pictureBox.Image = img; 
                pictureBox.Size = img.Size;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        { 
            base.OnPaint(e);
        }
        /*
        public VisualizadorImagenes(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }
        */
    }
}
