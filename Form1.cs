using System;
using System.Windows.Forms;

namespace ProyectoGitGUI
{
    public partial class Form1 : Form
    {
        private Label etiqueta;
        private TextBox entrada;
        private Button boton;

        public Form1()
        {
            InitializeComponent();
            this.Text = "Proyecto Git GUI en C#";
            this.Width = 400;
            this.Height = 300;

            // Etiqueta
            etiqueta = new Label();
            etiqueta.Text = "Bienvenido a Git GUI Demo";
            etiqueta.Font = new System.Drawing.Font("Arial", 12);
            etiqueta.Top = 20;
            etiqueta.Left = 80;
            etiqueta.Width = 250;
            this.Controls.Add(etiqueta);

            // Cuadro de texto
            entrada = new TextBox();
            entrada.Top = 70;
            entrada.Left = 80;
            entrada.Width = 200;
            this.Controls.Add(entrada);

            // Botón
            boton = new Button();
            boton.Text = "Haz clic aquí";
            boton.Top = 120;
            boton.Left = 120;
            boton.Width = 120;
            boton.BackColor = System.Drawing.Color.LightGreen;
            boton.Click += new EventHandler(this.MostrarMensaje);
            this.Controls.Add(boton);
        }

        private void MostrarMensaje(object? sender, EventArgs e)
        {

            string texto = entrada.Text.Trim();
            if (string.IsNullOrEmpty(texto))
            {
                MessageBox.Show("¡Hola desde Git GUI en C#!");
            }
            else
            {
                MessageBox.Show("Hola " + texto + ", estás usando Git GUI en C#!");
            }


        }

    }
}
