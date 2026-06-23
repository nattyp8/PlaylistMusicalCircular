using PlaylistMusicalCircular.Estructuras;
using PlaylistMusicalCircular.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PlaylistMusicalCircular.Formularios
{
    public partial class FrmPlaylist : Form
    {
        private void AplicarTema()
        {
            Color rosa = ColorTranslator.FromHtml("#EFCEDB");
            Color marron = ColorTranslator.FromHtml("#4F2B1F");

            // Formulario
            this.BackColor = rosa;

            // Botones
            btnActualizar.BackColor = marron;
            btnActualizar.ForeColor = rosa;
            btnActualizar.FlatStyle = FlatStyle.Flat;

            btnEliminar.BackColor = marron;
            btnEliminar.ForeColor = rosa;
            btnEliminar.FlatStyle = FlatStyle.Flat;

            bntBuscar.BackColor = marron;
            bntBuscar.ForeColor = rosa;
            bntBuscar.FlatStyle = FlatStyle.Flat;

            /*btnActualizar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatAppearance.BorderSize = 0;
            bntBuscar.FlatAppearance.BorderSize = 0;
*/
            // TextBox
            txtBuscar.BackColor = Color.White;
            txtBuscar.ForeColor = marron;

            // DataGridView
            dgvPlaylist.BackgroundColor = rosa;
            dgvPlaylist.BorderStyle = BorderStyle.None;

            dgvPlaylist.EnableHeadersVisualStyles = false;

            dgvPlaylist.ColumnHeadersDefaultCellStyle.BackColor = marron;
            dgvPlaylist.ColumnHeadersDefaultCellStyle.ForeColor = rosa;
            dgvPlaylist.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            dgvPlaylist.DefaultCellStyle.BackColor = Color.White;
            dgvPlaylist.DefaultCellStyle.ForeColor = marron;

            dgvPlaylist.AlternatingRowsDefaultCellStyle.BackColor =
                ColorTranslator.FromHtml("#F7E4EC");

            dgvPlaylist.GridColor = marron;

            dgvPlaylist.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvPlaylist.DefaultCellStyle.SelectionBackColor = marron;
            dgvPlaylist.DefaultCellStyle.SelectionForeColor = rosa;
        }
        public FrmPlaylist()
        {
            InitializeComponent();

            AplicarTema();

            CargarPlaylist();
        }

        private void CargarPlaylist()
        {
            //mostrar todas las canciones en el datagridview
            dgvPlaylist.DataSource = null;
            dgvPlaylist.DataSource = GestorPlaylist.Playlist.ObtenerTodas();
            dgvPlaylist.Columns["Duracion"].Visible = false;
            dgvPlaylist.Columns["RutaArchivo"].Visible = false;
            dgvPlaylist.Columns["RutaImagen"].Visible = false;
            dgvPlaylist.RowHeadersVisible = false;

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvPlaylist.CurrentRow != null)
            {
                Cancion cancionSeleccionada =
                    (Cancion)dgvPlaylist.CurrentRow.DataBoundItem;

                FrmEditarCancion frm =
                    new FrmEditarCancion(cancionSeleccionada);

                frm.ShowDialog();

                CargarPlaylist();
            }
        }

        private void bntBuscar_Click(object sender, EventArgs e)
        {
            Cancion? encontrada = GestorPlaylist.Playlist.BuscarCancion(txtBuscar.Text);
            if (encontrada != null)
            {
                MessageBox.Show
                    (
                        "titulo: " + encontrada.Titulo +
                    "\n Artista: " + encontrada.Artista
                    );

            }
            else
            {
                MessageBox.Show("Cancion no encontrada");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //verificar si existe fila seleccionada
            if (dgvPlaylist.CurrentRow != null)
            {
                //obtener titulo de la fila
                string titulo = dgvPlaylist.CurrentRow.Cells["Titulo"].Value.ToString();

                //eliminar
                if (GestorPlaylist.Playlist.EliminarCancion(titulo))
                {
                    MessageBox.Show("Cancion Eliminada");
                    //actualizar la tabla donde se muestr
                    CargarPlaylist();
                }
                else
                {
                    MessageBox.Show("No se ha podido eliminar");
                }
            }
        }

    }
}
