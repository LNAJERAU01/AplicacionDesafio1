using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionDesafio1
{
    public partial class Form2 : Form
    {
        private List<Usuario> listaUsuarios = new List<Usuario>();
        private List<string> listaTabsE = new List<string> { "GAME OF THRONES", "CHERNOBYL", "THE MARVELOUS MRS. MAISEL", "ESTADISTICAS" };
        private List<string> listaTabsL = new List<string> { "HARRY POTTER", "GOOSEBUMP", "PERRY MASON", "ESTADISTICAS"};
        private List<string> listaTabsP = new List<string> { "PYTHON", "JAVA", "JAVASCRIPT", "ESTADISTICAS"};
        public Form2()
        {
            InitializeComponent();
            listaUsuarios.Add(new Usuario("jgarcia", "12345678", "Entretenimiento"));
            listaUsuarios.Add(new Usuario("lnajera", "87654321", "Libros"));
            listaUsuarios.Add(new Usuario("mayala", "asdfghj", "Programacion"));
            listaUsuarios.Add(new Usuario("khernadez", "fjhgfdsa", "Entretenimiento"));
            listaUsuarios.Add(new Usuario("mcastillo", "1234asdf", "Libros"));

            textBox1.Text = "jgarcia";
            textBox2.Text = "12345678";
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool encontrado = false;
            foreach (Usuario usr in listaUsuarios)
            {
                if (textBox1.Text.Equals(usr.getNombre()) && textBox2.Text.Equals(usr.getPassword()))
                {
                    encontrado = true;
                    switch (usr.getPreferencia())
                    {
                        case "Entretenimiento":
                            Form fme = new Form3(usr.getPreferencia(), listaTabsE);
                            this.Hide();
                            fme.Show();
                            break;
                        case "Libros":
                            Form fml = new Form3(usr.getPreferencia(), listaTabsL);
                            this.Hide();
                            fml.Show();
                            break;
                        case "Programacion":
                            Form fmp = new Form3(usr.getPreferencia(), listaTabsP);
                            this.Hide();
                            fmp.Show();
                            break;
                    }
                    break;
                }
            }

            if (!encontrado)
            {
                MessageBox.Show("Usuario/Contraseña no validos","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

        }
    }
}
