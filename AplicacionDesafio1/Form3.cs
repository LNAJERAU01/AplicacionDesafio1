using AplicacionDesafio1.Properties;
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
    public partial class Form3 : Form
    {
        private List<string> listEstaE = new List<string>()  {"40","34","26" };
        private List<string> listDatosE = new List<string>() { "Título en español:", "Creador por:", "Protagonistas:", "País de origen:", "Temporadas:", "Episodios:", "Sinopsis:" };
        private List<string> listInfoE1 = new List<string>() { "Juego de tronos", "David Benioff \n\rD. B. Weiss", "Sean Bean\n\rNikolaj Coster-Waldau\n\rPeter Dinklage\n\rEmilia Clarke\n\rLena Headey\n\rIain Glen\n\rKit Harington\n\rSophie Turner\n\rMaisie Williams\n\rIsaac Hempstead-Wright\n\rNatalie Dormer", "Estados Unidos", "8", "73", "La trama de Game of Thrones está basada en la serie de novelas Canción de hielo y fuego, y relata las vivencias de un grupo de personajes de distintas casas nobiliarias en el continente ficticio Poniente para tener el control del Trono de Hierro y gobernar los siete reinos que conforman el territorio." };
        private List<string> listInfoE2 = new List<string>() { "Chernóbil", "Craig Mazin", "Jared Harris\n\rStellan Skarsgård\n\rEmily Watson", "Estados Unidos\n\rReino Unido", "1", "5", "La serie gira en torno al desastre nuclear de Chernóbil de abril de 1986 y los esfuerzos de limpieza sin precedentes que siguieron. Cuenta con un reparto encabezado por Jared Harris, Stellan Skarsgård y Emily Watson." };
        private List<string> listInfoE3 = new List<string>() { "La maravillosa Señora Maisel", "Amy Sherman-Palladino", "Rachel Brosnahan\n\rMichael Zegen\n\rAlex Borstein\n\rTony Shalhoub\n\rMarin Hinkle", "Estados Unidos", "3", "26", "La serie cuenta la historia de un ama de casa en Nueva York que descubre que tiene una habilidad especial para la comedia en vivo. El primer episodio se estrenó como parte de la temporada de pilotos de primavera de Amazon Studios el 17 de marzo de 2017, recibiendo la aclamación de la crítica." };

        private List<string> listEstaL = new List<string>()  {"44","30","26" };
        private List<string> listDatosL = new List<string>() { "Autor:", "Género::", "Subgénero:", "# paginas::", "Protagonistas:", "Antagonistas:", "Argumento:" };
        private List<string> listInfoL1 = new List<string>() { "J. K. Rowling", "Novela", "Literatura fantástica, literatura juvenil, novela de desarrollo y literatura infantil y juvenil", "3407 (ENG)\r\n3665 (ESP)", "Harry Potter\r\nRon weasley\r\nHermione Granger\r\nGinny Weasley\r\nNeville Longbottom\r\nAlbus Dumbledore", "Lord Voldemort\r\nMortífagos", "La historia comienza con la celebración del mundo mágico. Durante muchos años, había sido aterrorizado por el malvado mago Lord Voldemort. La noche del 31 de octubre, mató a Lily y James Potter. Sin embargo, cuando intenta matar a su hijo de 1 año, Harry, la maldición asesina Avada Kedavra se vuelve sobre sí mismo. El cuerpo de Voldemort resulta destruido, pero él sobrevive: no está muerto ni vivo. Por su parte, a Harry solo le queda una cicatriz con forma de rayo en la frente que es el único remanente físico de la maldición de Voldemort. Harry es el único sobreviviente de la maldición asesina, y a raíz de la misteriosa derrota de Voldemort,\r\nel mundo mágico empieza a llamarlo como «el niño que sobrevivió»." };
        private List<string> listInfoL2 = new List<string>() { "Robert Lawrence Stine", "Ciencia ficción, literatura infantil y suspenso", "Suspenso, terror, juvenil", "---", "El protagonista principal de una historia de Pesadillas / Escalofríos, es a menudo situado en una ubicación remota o de alguna manera aislada en algunas situaciones.", "---", "La serie consta de un total de 60 libros para España, el último de los cuales (Sangre de monstruo IV) se publicó en 1999, mientras que en Hispanoamérica consta de 45 historias. El nombre se tradujo en España como Pesadillas y en Hispanoamérica como Escalofríos." };
        private List<string> listInfoL3 = new List<string>() { "Erle Stanley Gardner", "Novela policiaca", "XX", "XX", "Perry Mason", "XX", "El personaje era un abogado que llegó a aparecer en 80 novelas e historias cortas, la mayoría de las cuales versaban sobre la defensa de un cliente que había sido acusado de asesinato. En general, Perry Mason era capaz de demostrar la inocencia de su cliente mediante la averiguación de la culpabilidad del verdadero asesino, otro personaje de la historia." };

        private List<string> listEstaP = new List<string>()  {"47","38","15" };
        private List<string> listDatosP = new List<string>() { "Desarrollador(es):", "Extensiones:", "Apareció en:", "Sistema operativo:", "Paradigma:", "Ultima versión estable:", "Licencia:" };
        private List<string> listInfoP1 = new List<string>() { "Python Software Foundation", ".py, .pyc, .pyd, .pyo, .pyw, .pyz", "1991", "Multiplataforma", "Multiparadigma: orientado a objetos, imperativo, funcional, reflexivo", "3.8.3", "Python Software Foundation License" };
        private List<string> listInfoP2 = new List<string>() { "James Gosling y Sun Microsystems", "java, class, jar, jad y jmod", "1996", "Multiplataforma", "Orientado a objetos, imperativo", "14.01", "GNU GPL / Java Community Process" };
        private List<string> listInfoP3 = new List<string>() { "XX", ".js", "1995", "XX", "Multiparadigma, programación funcional, programación basada en prototipos, imperativo, interpretado (scripting)", "ECMAScript2016", "XX" };
        public Form3()
        {
            InitializeComponent();
        }

        public Form3(string categoria, List<string> tabs)
        {
            InitializeComponent();
            this.Text = categoria;
            this.tabPage1.Text = tabs[0];
            this.tabPage2.Text = tabs[1];
            this.tabPage3.Text = tabs[2];
            this.tabPage4.Text = tabs[3];

            this.label1.Text = tabs[0];
            this.label2.Text = tabs[1];
            this.label3.Text = tabs[2];
            this.label4.Text = tabs[3];

            switch (categoria){
                case "Entretenimiento":
                    pictureBox1.Image = Properties.Resources.got;
                    pictureBox2.Image = Properties.Resources.chernobyl;
                    pictureBox3.Image = Properties.Resources.marvelours;

                    chart1.Titles.Add("Entretenimiento");
                    chart1.Series["Series1"].Points.AddXY(tabs[0], listEstaE[0]);
                    chart1.Series["Series1"].Points.AddXY(tabs[1], listEstaE[1]);
                    chart1.Series["Series1"].Points.AddXY(tabs[2], listEstaE[2]);

                    this.label5.Text = listDatosE[0];
                    this.label6.Text = listDatosE[1];
                    this.label7.Text = listDatosE[2];
                    this.label8.Text = listDatosE[3];
                    this.label9.Text = listDatosE[4];
                    this.label10.Text = listDatosE[5];
                    this.label11.Text = listDatosE[6];

                    this.label12.Text = listInfoE1[0];
                    this.label13.Text = listInfoE1[1];
                    this.label14.Text = listInfoE1[2];
                    this.label15.Text = listInfoE1[3];
                    this.label16.Text = listInfoE1[4];
                    this.label17.Text = listInfoE1[5];
                    this.label18.Text = listInfoE1[6];

                    this.label19.Text = listDatosE[0];
                    this.label20.Text = listDatosE[1];
                    this.label21.Text = listDatosE[2];
                    this.label22.Text = listDatosE[3];
                    this.label23.Text = listDatosE[4];
                    this.label24.Text = listDatosE[5];
                    this.label25.Text = listDatosE[6];

                    this.label26.Text = listInfoE2[0];
                    this.label27.Text = listInfoE2[1];
                    this.label28.Text = listInfoE2[2];
                    this.label29.Text = listInfoE2[3];
                    this.label30.Text = listInfoE2[4];
                    this.label31.Text = listInfoE2[5];
                    this.label32.Text = listInfoE2[6];

                    this.label33.Text = listDatosE[0];
                    this.label34.Text = listDatosE[1];
                    this.label35.Text = listDatosE[2];
                    this.label36.Text = listDatosE[3];
                    this.label37.Text = listDatosE[4];
                    this.label38.Text = listDatosE[5];
                    this.label39.Text = listDatosE[6];

                    this.label40.Text = listInfoE3[0];
                    this.label41.Text = listInfoE3[1];
                    this.label42.Text = listInfoE3[2];
                    this.label43.Text = listInfoE3[3];
                    this.label44.Text = listInfoE3[4];
                    this.label45.Text = listInfoE3[5];
                    this.label46.Text = listInfoE3[6];

                    break;
                case "Libros":
                    pictureBox1.Image = Properties.Resources.HarryPotter;
                    pictureBox2.Image = Properties.Resources.goosebumps;
                    pictureBox3.Image = Properties.Resources.PerryMason;

                    chart1.Titles.Add("Entretenimiento");
                    chart1.Series["Series1"].Points.AddXY(tabs[0], listEstaL[0]);
                    chart1.Series["Series1"].Points.AddXY(tabs[1], listEstaL[1]);
                    chart1.Series["Series1"].Points.AddXY(tabs[2], listEstaL[2]);
                   
                    this.label5.Text = listDatosL[0];
                    this.label6.Text = listDatosL[1];
                    this.label7.Text = listDatosL[2];
                    this.label8.Text = listDatosL[3];
                    this.label9.Text = listDatosL[4];
                    this.label10.Text = listDatosL[5];
                    this.label11.Text = listDatosL[6];

                    this.label12.Text = listInfoL1[0];
                    this.label13.Text = listInfoL1[1];
                    this.label14.Text = listInfoL1[2];
                    this.label15.Text = listInfoL1[3];
                    this.label16.Text = listInfoL1[4];
                    this.label17.Text = listInfoL1[5];
                    this.label18.Text = listInfoL1[6];

                    this.label19.Text = listDatosL[0];
                    this.label20.Text = listDatosL[1];
                    this.label21.Text = listDatosL[2];
                    this.label22.Text = listDatosL[3];
                    this.label23.Text = listDatosL[4];
                    this.label24.Text = listDatosL[5];
                    this.label25.Text = listDatosL[6];

                    this.label26.Text = listInfoL2[0];
                    this.label27.Text = listInfoL2[1];
                    this.label28.Text = listInfoL2[2];
                    this.label29.Text = listInfoL2[3];
                    this.label30.Text = listInfoL2[4];
                    this.label31.Text = listInfoL2[5];
                    this.label32.Text = listInfoL2[6];

                    this.label33.Text = listDatosL[0];
                    this.label34.Text = listDatosL[1];
                    this.label35.Text = listDatosL[2];
                    this.label36.Text = listDatosL[3];
                    this.label37.Text = listDatosL[4];
                    this.label38.Text = listDatosL[5];
                    this.label39.Text = listDatosL[6];

                    this.label40.Text = listInfoL3[0];
                    this.label41.Text = listInfoL3[1];
                    this.label42.Text = listInfoL3[2];
                    this.label43.Text = listInfoL3[3];
                    this.label44.Text = listInfoL3[4];
                    this.label45.Text = listInfoL3[5];
                    this.label46.Text = listInfoL3[6];

                    break;
                case "Programacion":
                    pictureBox1.Image = Properties.Resources.python;
                    pictureBox2.Image = Properties.Resources.java;
                    pictureBox3.Image = Properties.Resources.js;

                    chart1.Titles.Add("Entretenimiento");
                    chart1.Series["Series1"].Points.AddXY(tabs[0], listEstaP[0]);
                    chart1.Series["Series1"].Points.AddXY(tabs[1], listEstaP[1]);
                    chart1.Series["Series1"].Points.AddXY(tabs[2], listEstaP[2]);
                    
                    this.label5.Text = listDatosP[0];
                    this.label6.Text = listDatosP[1];
                    this.label7.Text = listDatosP[2];
                    this.label8.Text = listDatosP[3];
                    this.label9.Text = listDatosP[4];
                    this.label10.Text = listDatosP[5];
                    this.label11.Text = listDatosP[6];

                    this.label12.Text = listInfoP1[0];
                    this.label13.Text = listInfoP1[1];
                    this.label14.Text = listInfoP1[2];
                    this.label15.Text = listInfoP1[3];
                    this.label16.Text = listInfoP1[4];
                    this.label17.Text = listInfoP1[5];
                    this.label18.Text = listInfoP1[6];

                    this.label19.Text = listDatosP[0];
                    this.label20.Text = listDatosP[1];
                    this.label21.Text = listDatosP[2];
                    this.label22.Text = listDatosP[3];
                    this.label23.Text = listDatosP[4];
                    this.label24.Text = listDatosP[5];
                    this.label25.Text = listDatosP[6];

                    this.label26.Text = listInfoP2[0];
                    this.label27.Text = listInfoP2[1];
                    this.label28.Text = listInfoP2[2];
                    this.label29.Text = listInfoP2[3];
                    this.label30.Text = listInfoP2[4];
                    this.label31.Text = listInfoP2[5];
                    this.label32.Text = listInfoP2[6];

                    this.label33.Text = listDatosP[0];
                    this.label34.Text = listDatosP[1];
                    this.label35.Text = listDatosP[2];
                    this.label36.Text = listDatosP[3];
                    this.label37.Text = listDatosP[4];
                    this.label38.Text = listDatosP[5];
                    this.label39.Text = listDatosP[6];

                    this.label40.Text = listInfoP3[0];
                    this.label41.Text = listInfoP3[1];
                    this.label42.Text = listInfoP3[2];
                    this.label43.Text = listInfoP3[3];
                    this.label44.Text = listInfoP3[4];
                    this.label45.Text = listInfoP3[5];
                    this.label46.Text = listInfoP3[6];

                    break;
            }

        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
