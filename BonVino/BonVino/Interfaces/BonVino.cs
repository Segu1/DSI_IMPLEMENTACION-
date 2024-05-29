using BonVino.Entidades;

namespace BonVino
{
    public partial class ventanaPrincipal : Form
    {
        public ventanaPrincipal()
        {
            InitializeComponent();
        }

        private void ventanaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vino primerVino = new Vino("Malbec", "TaylorSwift");
            Ranking ventana = new Ranking();
            ventana.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        public string GetSelectedComboBoxItem()
        {
            if (comboBox1.SelectedItem != null)
            {
                return (String)comboBox1.SelectedItem;
            }
            return null;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
