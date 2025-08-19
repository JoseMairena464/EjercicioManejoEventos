using TodoList.Clases;

namespace TodoList
{
    public partial class Form1 : Form
    {
        List<Tarea> tareas = new List<Tarea>();
        public Form1()
        {
            InitializeComponent();
        }

        public void onBtnAgregarClick(object sender, EventArgs e)
        {
            string nombreTarea = txtBoxTarea.Text;
            if (string.IsNullOrWhiteSpace(nombreTarea) || cbPrioridad.SelectedItem == null)
            {
                MessageBox.Show("Debe ingresar un nombre de tarea y seleccionar una prioridad.");
                return;
            }

            string prioridadSeleccionada = cbPrioridad.SelectedItem.ToString();
            Prioridad prioridadTarea;
            switch (prioridadSeleccionada)
            {
                case "Alta":
                    prioridadTarea = Prioridad.Alta;
                    break;
                case "Media":
                    prioridadTarea = Prioridad.Media;
                    break;
                default:
                    prioridadTarea = Prioridad.Baja;
                    break;
            }

            Tarea nuevaTarea = new Tarea { Nombre = nombreTarea, Prioridad = prioridadTarea };
            tareas.Add(nuevaTarea);

            txtBoxTarea.Text = "";
            cbPrioridad.ResetText();

            renderizarTareas();
        }

        public void renderizarTareas(List<Tarea>? listaFiltrada = null)
        {
            flowPanelTodoList.Controls.Clear();
            var lista = listaFiltrada ?? tareas;

            foreach (Tarea tarea in lista)
            {
                Panel tarjeta = crearTarjeta(tarea);
                flowPanelTodoList.Controls.Add(tarjeta);
            }
        }

        public Panel crearTarjeta(Tarea tarea)
        {
            Panel tarjeta = new Panel();
            tarjeta.Size = new Size(200, 100);
            tarjeta.Padding = new Padding(5);
            tarjeta.Margin = new Padding(5);
            tarjeta.BackColor = Color.White;
            tarjeta.Tag = tarea;

            Label nombreTarea = new Label();
            nombreTarea.AutoSize = true;
            nombreTarea.Text = $"{tarea.Nombre}";
            nombreTarea.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            nombreTarea.Dock = DockStyle.Top;
            nombreTarea.Margin = new Padding(3, 3, 3, 3);

            Label prioridad = new Label();
            prioridad.AutoSize = true;
            prioridad.Text = tarea.Prioridad.ToString();
            prioridad.Font = new Font("Segoe UI", 9);
            prioridad.Dock = DockStyle.Top;
            prioridad.Margin = new Padding(3, 50, 3, 3);

            switch (tarea.Prioridad)
            {
                case Prioridad.Alta:
                    prioridad.ForeColor = Color.Red;
                    break;
                case Prioridad.Media:
                    prioridad.ForeColor = Color.Orange;
                    break;
                default: // Baja
                    prioridad.ForeColor = Color.Green;
                    break;
            }

            tarjeta.Controls.Add(prioridad);
            tarjeta.Controls.Add(nombreTarea);

            return tarjeta;
        }

        public void btnBuscar_Click(object sender, EventArgs e)
        {
            string criterio = txtBoxBuscar.Text.Trim().ToLower();
            if (string.IsNullOrWhiteSpace(criterio))
            {
                renderizarTareas(); 
            }
            else
            {
                var filtradas = tareas
            .Where(t => t.Nombre.ToLower().Contains(criterio))
            .ToList();
                renderizarTareas(filtradas);
            }
        }
    }
}