using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_tac_toe.Class;

namespace Tic_tac_toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        Juego valJuego = new Juego();
        private void button3_Click(object sender, EventArgs e)
        {
            string sTituloMensaje = "";

            if(!valJuego.ValidaCelda(2))
            {
                if(valJuego.iTurno == 1)
                {
                    button3.Text = "X";
                }
                else
                {
                    button3.Text = "O";
                }
                button3.BackColor = valJuego.Marcarturno();

                sTituloMensaje = valJuego.ValidarVictoria();
                if (sTituloMensaje.Length > 0)
                {
                    lblTurno.Text = sTituloMensaje;
                }
                else
                {
                    ReiniciarJuego();
                }
            }            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sTituloMensaje = "";

            if (!valJuego.ValidaCelda(0))
            {
                if (valJuego.iTurno == 1)
                {
                    button1.Text = "X";
                }
                else
                {
                    button1.Text = "O";
                }
                button1.BackColor = valJuego.Marcarturno();


                sTituloMensaje = valJuego.ValidarVictoria();
                if (sTituloMensaje.Length > 0)
                {
                    lblTurno.Text = sTituloMensaje;
                }
                else
                {
                    ReiniciarJuego();
                }
            }            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sTituloMensaje = "";
                        
            if (!valJuego.ValidaCelda(1))
            {
                if (valJuego.iTurno == 1)
                {
                    button2.Text = "X";
                }
                else
                {
                    button2.Text = "O";
                }
                button2.BackColor = valJuego.Marcarturno();
                sTituloMensaje = valJuego.ValidarVictoria();
                if (sTituloMensaje.Length > 0)
                {
                    lblTurno.Text = sTituloMensaje;
                }
                else
                {
                    ReiniciarJuego();
                }
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sTituloMensaje = "";
            if (!valJuego.ValidaCelda(3))
            {
                if (valJuego.iTurno == 1)
                {
                    button4.Text = "X";
                }
                else
                {
                    button4.Text = "O";
                }
                button4.BackColor = valJuego.Marcarturno();


                sTituloMensaje = valJuego.ValidarVictoria();
                if (sTituloMensaje.Length > 0)
                {
                    lblTurno.Text = sTituloMensaje;
                }
                else
                {
                    ReiniciarJuego();
                }
            }            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string sTituloMensaje = "";
            if (!valJuego.ValidaCelda(4))
            {
                if (valJuego.iTurno == 1)
                {
                    button5.Text = "X";
                }
                else
                {
                    button5.Text = "O";
                }
                button5.BackColor = valJuego.Marcarturno();


                sTituloMensaje = valJuego.ValidarVictoria();
                if (sTituloMensaje.Length > 0)
                {
                    lblTurno.Text = sTituloMensaje;
                }
                else
                {
                    ReiniciarJuego();
                }
            }
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string sTituloMensaje = "";
            if (!valJuego.ValidaCelda(5))
            {
                if (valJuego.iTurno == 1)
                {
                    button6.Text = "X";
                }
                else
                {
                    button6.Text = "O";
                }
                button6.BackColor = valJuego.Marcarturno();

                sTituloMensaje = valJuego.ValidarVictoria();
                if (sTituloMensaje.Length > 0)
                {
                    lblTurno.Text = sTituloMensaje;
                }
                else
                {
                    ReiniciarJuego();
                }
            }          
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string sTituloMensaje = "";
            if(!valJuego.ValidaCelda(6))
            {
                if (valJuego.iTurno == 1)
                {
                    button7.Text = "X";
                }
                else
                {
                    button7.Text = "O";
                }
                button7.BackColor = valJuego.Marcarturno();

                sTituloMensaje = valJuego.ValidarVictoria();
                if (sTituloMensaje.Length > 0)
                {
                    lblTurno.Text = sTituloMensaje;
                }
                else
                {
                    ReiniciarJuego();
                }
            }            

        }

        private void button8_Click(object sender, EventArgs e)
        {
            string sTituloMensaje = "";
            if(!valJuego.ValidaCelda(7))
            {
                if (valJuego.iTurno == 1)
                {
                    button8.Text = "X";
                }
                else
                {
                    button8.Text = "O";
                }
                button8.BackColor = valJuego.Marcarturno();

                sTituloMensaje = valJuego.ValidarVictoria();
                if (sTituloMensaje.Length > 0)
                {
                    lblTurno.Text = sTituloMensaje;
                }
                else
                {
                    ReiniciarJuego();
                }
            }            

        }

        private void button9_Click(object sender, EventArgs e)
        {
            string sTituloMensaje = "";

            if (!valJuego.ValidaCelda(8))
            {
                if (valJuego.iTurno == 1)
                {
                    button9.Text = "X";
                }
                else
                {
                    button9.Text = "O";
                }
                button9.BackColor = valJuego.Marcarturno();

                sTituloMensaje = valJuego.ValidarVictoria();
                if (sTituloMensaje.Length > 0)
                {
                    lblTurno.Text = sTituloMensaje;
                }
                else
                {
                    ReiniciarJuego();
                }
            }
            
        }

        public void ReiniciarJuego()
        {
            button1.BackColor = System.Drawing.Color.Gainsboro;
            button2.BackColor = System.Drawing.Color.Gainsboro;
            button3.BackColor = System.Drawing.Color.Gainsboro;
            button4.BackColor = System.Drawing.Color.Gainsboro;
            button5.BackColor = System.Drawing.Color.Gainsboro;
            button6.BackColor = System.Drawing.Color.Gainsboro;
            button7.BackColor = System.Drawing.Color.Gainsboro;
            button8.BackColor = System.Drawing.Color.Gainsboro;
            button9.BackColor = System.Drawing.Color.Gainsboro;
            valJuego.Matriz = new int[9];
            valJuego.iTurno = 1;
            lblTurno.Text = "TURNO 1";

            button1.Text= "";
            button2.Text= "";
            button3.Text= "";
            button4.Text= "";
            button5.Text= "";
            button6.Text= "";
            button7.Text= "";
            button8.Text= "";
            button9.Text= "";
        }



    }
}
