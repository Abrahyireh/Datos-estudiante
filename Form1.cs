namespace ej1DatosEstudiantes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Implimir_Click(object sender, EventArgs e)
        {
            lbl_Nombre.Text = txt_Nombre.Text;
            lbl_Matricula.Text = txt_Matricula.Text;
            lbl_Edad.Text = txt_Edad.Text;
            lbl_Carrera.Text = txt_Carrera.Text;
            lbl_Apellidos.Text = txt_Apellidos.Text;
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_Nombre.Clear();
            txt_Matricula.Clear();
            txt_Edad.Clear();
            txt_Carrera.Clear();
            txt_Apellidos.Clear();


        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}