namespace MemoryGame
{
    public partial class MG : Form
    {

        Random random = new Random();
        List<string> icons = new List<string>()
        {
            "! ", "!", "b", "b", "k", "k", "r", "r",
            "c", "c", "d" , "d" , "e" , "e", "h", "h",
        };
        Label firstClicked, secondClicked;
        public MG()


        {
            InitializeComponent();
            asignarIconos();
        }
        private void asignarIconos()
        {
            Label label;
            int rndomNumber;

            for (int i = 0; i < tbl_layout.Controls.Count; i++)
            {

                //Verificamos que los elementos del table layout 
                // que sean Label
                if (tbl_layout.Controls[i] is Label)
                {
                    label = (Label)tbl_layout.Controls[i];
                }
                else
                {
                    continue;
                }
                rndomNumber = random.Next(0, icons.Count);
                // en este momento se le asigna el valor de la posición de nuestra lista
                label.Text = icons[rndomNumber];

                //Vamos eliminando los elementos para no repetir
                icons.RemoveAt(rndomNumber);

            }

        }

        private void lbl_Click(object sender, EventArgs e)
        {
            Label clickedLaber = sender as Label;

            if (clickedLaber == null) return;

            if (clickedLaber.ForeColor == Color.Chocolate) return;


            if (clickedLaber.Visible == true) return;


            if(firstClicked == null)
            {
                firstClicked = clickedLaber;
                firstClicked.ForeColor = Color.Chocolate;
                return;
            }

            secondClicked = clickedLaber;
            secondClicked.ForeColor = Color.Chocolate;

            
            
        }
    }
}