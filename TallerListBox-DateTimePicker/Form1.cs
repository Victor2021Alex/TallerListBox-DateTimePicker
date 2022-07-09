namespace TallerListBox_DateTimePicker
{
    public partial class Form1 : Form
    {
        List<String> listaGeneral = new List<string>();
        List<String> listaSeleccionado = new List<string>();       
        public Form1()
        {
            InitializeComponent();
            llenarLista();
        }
        private void llenarLista()
        {       
            listaGeneral.Add("Victor Bermello");
            listaGeneral.Add("Alex Vera");
            listaGeneral.Add("Juan Mena");
            listaGeneral.Add("Cristhian Zambrano");
            listaGeneral.Add("Maria Catro");
            listaGeneral.Add("Jhon Hidalgo");
            listaGeneral.Add("Israel Haro");

            for (int i = 0; i<listaGeneral.Count; i++)
            {
                lbLista.Items.Add(listaGeneral[i]);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (lbLista.SelectedIndex > -1 ) 
            {
                lblListsSelecVacia.Text = "";
                lblFechaIniCorrect.Text = "";
                lbSeleccionados.Items.Add(lbLista.SelectedItem);
                listaSeleccionado.Add(lbLista.Text);
                lbLista.Items.RemoveAt(lbLista.SelectedIndex);               
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (lbSeleccionados.SelectedIndex > -1)
            {
                lblListsSelecVacia.Text = "";
                lblFechaIniCorrect.Text = "";
                lbLista.Items.Add(lbSeleccionados.SelectedItem);
                listaSeleccionado.Remove(lbSeleccionados.Text);
                lbSeleccionados.Items.RemoveAt(lbSeleccionados.SelectedIndex);
            }
        }

        private void btnQuitarTodo_Click(object sender, EventArgs e)
        {
            if (lbSeleccionados.Items.Count > 0)
            {
                lblListsSelecVacia.Text = "";
                lblFechaIniCorrect.Text = "";
                for (int i=0; i < lbSeleccionados.Items.Count; i++)  
                {
                    lbLista.Items.Add(lbSeleccionados.Items[i]);                   
                }
                lbSeleccionados.Items.Clear();
                listaSeleccionado.Clear();
            }
            else
            {
                lblListsSelecVacia.Text = "Lista de seleccionados vacía";
                lblListsSelecVacia.ForeColor = Color.Red;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            lblFechaIniCorrect.Text = "";
            if (lbSeleccionados.Items.Count > 3)
            {
                lblListsSelecVacia.Text = "Alum. maximos por grupo: 3";
                lblListsSelecVacia.ForeColor = Color.Red;
            }
            else if (dtpFechaInicio.Value.Date < DateTime.Now.Date)
            {
                lblFechaIniCorrect.Text = "Fecha inicio debe ser mayor a fecha actual";
                lblFechaIniCorrect.ForeColor = Color.Red;
            }
            else
            {
                ListViewItem item = new ListViewItem();
                llenarGrupos(item, listaSeleccionado);
                lbSeleccionados.Items.Clear();
                listaSeleccionado.Clear();
            }
        }
        private void llenarGrupos(ListViewItem item, List<String> lista)
        {
            for (int i=0; i<lbSeleccionados.Items.Count; i++)
            {
                item = ltvListaFinal.Items.Add(listaSeleccionado[i]);
                item.SubItems.Add(txtEquipo.Text);
                item.SubItems.Add(dtpFechaInicio.Text);
            }        
        }
    }
}