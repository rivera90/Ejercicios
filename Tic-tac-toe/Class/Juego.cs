using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_tac_toe.Class
{
    class Juego
    {
        public Juego()
        {
            iTurno = 1;
            Matriz = new int[9];
        }

        public int iTurno { get; set; }
        public int[] Matriz { get; set; }

        public bool GanaOrizontal(int[] matriz, int turno)
        {
            bool Gana = false;
            for (int i = 0; i <= 2; i++)
            {
                if (matriz[i] == turno)
                {
                    Gana = true;
                }
                else
                {
                    Gana = false;
                    break;
                }
            }

            if (!Gana)
            {
                for (int j = 3; j <= 5; j++)
                {
                    if (matriz[j] == turno)
                    {
                        Gana = true;
                    }
                    else
                    {
                        Gana = false;
                        break;
                    }
                }
            }

            if (!Gana)
            {
                for (int k = 6; k <= 8; k++)
                {
                    if (matriz[k] == turno)
                    {
                        Gana = true;
                    }
                    else
                    {
                        Gana = false;
                        break;
                    }
                }
            }


            if (Gana)
            {
                MessageBox.Show("Felicidades Ganaste " + (iTurno == 1 ? "Jugador 1" : "Jugador 2"));
                
            }

            return Gana;
        }

        public bool GanaVertical(int[] matriz, int turno)
        {
            bool Gana = false;
            for (int i = 0; i <= 6; i = i + 3)
            {
                if (matriz[i] == turno)
                {
                    Gana = true;
                }
                else
                {
                    Gana = false;
                    break;
                }
            }

            if (!Gana)
            {
                for (int j = 1; j <= 7; j = j + 3)
                {
                    if (matriz[j] == turno)
                    {
                        Gana = true;
                    }
                    else
                    {
                        Gana = false;
                        break;
                    }
                }
            }

            if (!Gana)
            {
                for (int k = 2; k <= 8; k = k + 3)
                {
                    if (matriz[k] == turno)
                    {
                        Gana = true;
                    }
                    else
                    {
                        Gana = false;
                        break;
                    }
                }
            }


            if (Gana)
            {
                MessageBox.Show("Felicidades Ganaste " + (iTurno == 1 ? "Jugador 1" : "Jugador 2"));
                
            }
            return Gana;
        }

        public bool GanaEsquina(int[] matriz, int turno)
        {
            bool Gana = false;
            for (int i = 0; i < matriz.Length; i = i + 4)
            {
                if (matriz[i] == turno)
                {
                    Gana = true;
                }
                else
                {
                    Gana = false;
                    break;
                }
            }

            if (!Gana)
            {
                for (int j = 2; j <= 6; j = j + 2)
                {
                    if (matriz[j] == turno)
                    {
                        Gana = true;
                    }
                    else
                    {
                        Gana = false;
                        break;
                    }
                }
            }

            if (Gana)
            {
                MessageBox.Show("Felicidades Ganaste " + (iTurno == 1 ? "Jugador 1" : "Jugador 2"));
                
            }

            return Gana;
        }

        public string ValidarVictoria()
        {
            if (!GanaOrizontal(Matriz, iTurno))
            {
                if (!GanaVertical(Matriz, iTurno))
                {
                    if (!GanaEsquina(Matriz, iTurno))
                    {
                        return CambiarTurno(iTurno);
                    }

                }
            }
            return "";
        }        

        public bool ValidaCelda(int celda)
        {
            bool celdaOcupada = false;
            if(Matriz[celda] > 0)
            {
                celdaOcupada = true;
            }
            else
            {
                Matriz[celda] = iTurno;
            }
            return celdaOcupada;
        }

        public string CambiarTurno(int turno)
        {
            string Titulo = "";
            if (turno == 1)
            {
                iTurno = 2;
            }
            else
            {
                iTurno = 1;
            }


            if (iTurno == 1)
            {
                Titulo = "TURNO 1";

            }
            else
            {
                Titulo = "TURNO 2";
            }

            return Titulo;
        }

        public Color Marcarturno()
        {
            Color color ;
            if (iTurno == 1)
            {
                color = Color.Red;
            }
            else
            {
               color = Color.Blue;
            }
            return color;
        }
    }
}
