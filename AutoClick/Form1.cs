using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AutoClick
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //mouse event constants
        const int MOUSEEVENTF_LEFTDOWN = 2;
        const int MOUSEEVENTF_LEFTUP = 4;
        const int MOUSEEVENTF_RIGHTDOWN = 8;
        const int MOUSEEVENTF_RIGHT_UP = 16;
        //input type constant
        const int INPUT_MOUSE = 0;

        [DllImport("User32.dll", SetLastError = true)]
        public static extern int SendInput(int nInputs, ref INPUT pInputs, int cbSize);

        public struct MOUSEINPUT
        {
            public int dx;
            public int dy;
            public int mouseData;
            public int dwFlags;
            public int time;
            public IntPtr dwExtraInfo;
        }

        public struct INPUT
        {
            public uint type;
            public MOUSEINPUT mi;
        };

        bool dir = false;
        bool estado;
        int contbotao;
        int tremer = 0;
        private bool validanumero(KeyEventArgs e)
        {
            // Determine whether the keystroke is a number from the top of the keyboard.
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                // Determine whether the keystroke is a number from the keypad.
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    // Determine whether the keystroke is a backspace.
                    if(e.KeyCode != Keys.Back)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private void modoTravado_CheckedChanged(object sender, EventArgs e)
        {
            campoX.Enabled = !campoX.Enabled;
            campoY.Enabled = !campoY.Enabled;
        }

        private void iniciar_Click(object sender, EventArgs e)
        {
            if (iniciar.Text != "Iniciar")
            {
                desligar();
            }
            else
            {
                timer1.Interval = 3000;
                modoLivre.Enabled = false;
                modoTravado.Enabled = false;

                contbotao = 3;
                timerBotao.Interval = 1;
                timerBotao.Start();
                timer1.Start();
                estado = Console.CapsLock;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = int.Parse(tempo.Text);

            if (modoTravado.Checked)
            {
                Cursor.Position = new Point(int.Parse(campoX.Text), int.Parse(campoY.Text));
            }
            if (shakeBox.Checked)
            {
                tremer = (tremer + 1) % 3;
                Cursor.Position = new Point(Cursor.Position.X + tremer - 1, Cursor.Position.Y + tremer - 1);
            }
            if (ctrlBox.Checked)
            {

            }
            //set up the INPUT struct and fill it for the mouse down
            INPUT i = new INPUT();
            i.type = INPUT_MOUSE;
            i.mi.dx = 0;
            i.mi.dy = 0;
            if(dir)
            i.mi.dwFlags = MOUSEEVENTF_RIGHTDOWN;
            else
            i.mi.dwFlags = MOUSEEVENTF_LEFTDOWN;
            i.mi.dwExtraInfo = IntPtr.Zero;
            i.mi.mouseData = 0;
            i.mi.time = 0;

            //send the input 
            SendInput(1, ref i, Marshal.SizeOf(i));

            //set the INPUT for mouse up and send it
            if(dir)
            i.mi.dwFlags = MOUSEEVENTF_RIGHT_UP;
            else
            i.mi.dwFlags = MOUSEEVENTF_LEFTUP;
            SendInput(1, ref i, Marshal.SizeOf(i));
            
            quantCliques.Text = ""+(int.Parse(quantCliques.Text) + 1);

            if (estado != Console.CapsLock)
                desligar();
        }

        private void desligar()
        {
                timer1.Stop();
                timerBotao.Stop();
                modoLivre.Enabled = true;
                modoTravado.Enabled = true;
                iniciar.Text = "Iniciar";
        }

        private void botDir_CheckedChanged(object sender, EventArgs e)
        {
            dir = !dir;
        }

        private void timerBotao_Tick(object sender, EventArgs e)
        {
            timerBotao.Interval = 1000;
            if (contbotao > 0)
            {
                iniciar.Text = "Iniciar (" + contbotao + ")";
                contbotao--;
            }
            else
            {
                iniciar.Text = "Parar";
                timerBotao.Stop();
            }
        }
    }
}