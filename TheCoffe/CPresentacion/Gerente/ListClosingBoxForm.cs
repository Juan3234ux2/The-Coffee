using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheCoffe.App;
using TheCoffe.CDatos;
using TheCoffe.CNegocio;
using TheCoffe.CNegocio.Services;
using TheCoffe.CPresentacion.Cajero;

namespace TheCoffe.CPresentacion.Gerente
{
    public partial class ListClosingBoxForm : UserControl
    {
        private Paginator<Turno_Caja> paginator;
        private TurnoService turnoService = new TurnoService();
        private UserService userService = new UserService();
        private int id;
        public ListClosingBoxForm()
        {
            InitializeComponent();
            dataClosingBox.AutoGenerateColumns = false;
        }

        public async void RefreshPantalla()
        {
            var turnos = await turnoService.ObtenerTurno();
            paginator = new Paginator<Turno_Caja>(turnos, 9);
            CargarDatos(paginator);
        }

        private async Task ObtenerTurnosFiltrados(int idUsuario = 0)
        {
            var ventasPorFecha = await turnoService.FiltrarPorFecha(dtpFechaDesde.Value, dtpFechaHasta.Value);
            if (idUsuario != 0)
            {
                ventasPorFecha = ventasPorFecha.Where(v => v.id_usuario == idUsuario).ToList();
            }
            paginator = new Paginator<Turno_Caja>(ventasPorFecha, 9);
            CargarDatos(paginator);
        }

        public void CargarDatos(Paginator<Turno_Caja> turno)
        {
            dataClosingBox.DataSource = turno.GetPageData().Select(p => 
            new
            {
                p.id_turno,
                c = p.Usuario.usuario1,
                fechaApertura = p.fecha_apertura?.ToString("dd-MM-yy HH:mm"),
                fechaCierre = p.fecha_cierre?.ToString("dd-MM-yy HH:mm"),
                p.monto_inicial
            }).ToList();
            ActualizarPaginacion(turno);
        }
        private void ActualizarPaginacion(Paginator<Turno_Caja> Turno)
        {
            lblPagina.Text = $"Página {Turno.CurrentPage} de {Turno.TotalPages}";
            btnAnt.Enabled = Turno.CurrentPage > 1;
            btnSig.Enabled = Turno.CurrentPage < Turno.TotalPages;
        }

        private async void ListClosingBoxForm_Load(object sender, EventArgs e)
        {
            await ObtenerTurnosFiltrados();
            var  usuarios = await userService.ObtenerTodosLosUsuarios();
            Usuario usuario = new Usuario
            {
                id_usuario = 0,
                usuario1 = "Todos los usuarios",
                nombre = "",
                contraseña = "11111111",
                telefono = "11111111",
                apellido = "",
            };
            usuarios.Insert(0, usuario);
            cboUsers.SelectedIndex = 0;
            cboUsers.DataSource = usuarios;
            cboUsers.DisplayMember = "usuario1";
            cboUsers.ValueMember = "id_usuario";
        }

        private void btnAnt_Click(object sender, EventArgs e)
        {
            paginator.PreviousPage();
            CargarDatos(paginator);
        }

        private void btnSig_Click(object sender, EventArgs e)
        {
            paginator.NextPage();
            CargarDatos(paginator);
        }

        private void dataClosingBox_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataClosingBox.CurrentRow.Cells[0].Value.ToString());
            if (dataClosingBox.Columns[e.ColumnIndex].Name == "detalle")
            {
                using (OverlayForm overlay = new OverlayForm())
                {
                    overlay.Show();
                    using (CloseBoxForm modal = new CloseBoxForm(id))
                    {
                        modal.ShowDialog(overlay);
                    }
                    overlay.Close();
                }
            }
        }

        private async void cboUsers_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboUsers.SelectedValue != null)
            {
                if (int.TryParse(cboUsers.SelectedValue.ToString(), out int idUsuario))
                {
                    await ObtenerTurnosFiltrados(idUsuario);
                }
            }
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            cboUsers.DroppedDown = !cboUsers.DroppedDown;
        }

        private async void dtpFechaDesde_ValueChanged(object sender, EventArgs e)
        {
            await ObtenerTurnosFiltrados();
        }
    }
}
