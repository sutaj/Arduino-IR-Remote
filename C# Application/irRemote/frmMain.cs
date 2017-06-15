/***
 *     ▄▄▄       ██ ▄█▀ ██▓ ██▓    
 *    ▒████▄     ██▄█▒ ▓██▒▓██▒    
 *    ▒██  ▀█▄  ▓███▄░ ▒██▒▒██░    
 *    ░██▄▄▄▄██ ▓██ █▄ ░██░▒██░    
 *     ▓█   ▓██▒▒██▒ █▄░██░░██████▒
 *     ▒▒   ▓▒█░▒ ▒▒ ▓▒░▓  ░ ▒░▓  ░
 *      ▒   ▒▒ ░░ ░▒ ▒░ ▒ ░░ ░ ▒  ░
 *      ░   ▒   ░ ░░ ░  ▒ ░  ░ ░   
 *          ░  ░░  ░    ░      ░  ░
 *                                 
 */

 /* FREE FOR NON COMMERCIAL USE ONLY ! */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.IO.Ports;

namespace irRemote
{
    public partial class frmMain : Form
    {
        PORTS PORT = new PORTS();
        NotifyIcon IKONA = new NotifyIcon();
        Timer TIK = new Timer();
        SerialPort sPORT = new SerialPort();
        string port=null;

        public frmMain()
        {
            InitializeComponent();

            TIK.Tick += TIKTAK;
            this.FormClosing += ZAMYKANIE;
            IKONA.DoubleClick += ICON_KLIK;
            IKONA.Disposed += FIXIKONA;
            sPORT.DataReceived += MonitorSerial;

            IKONA.ContextMenuStrip = _cmnuIKONKA;
            sPORT.DtrEnable = true;
            sPORT.BaudRate = 9600;
        }

        private void MonitorSerial(object sender, SerialDataReceivedEventArgs e)
        {
            string line = sPORT.ReadLine();
            this.BeginInvoke(new LineReceivedEvent(LineReceived), line);
        }

        /// <summary>
        /// Show osd
        /// </summary>
        private void R()
        {
            Program.Animating = true;
            Program.TimeOut = 0;
        }

        private delegate void LineReceivedEvent(string line);
        private void LineReceived(string line)
        {
            
            
            #region Wykrywanie trybu
            if(line.Contains(STALE.TRYB_ON))
            {
                Program.TRYB = "netflix";
                if (_cbTRYB.Checked)
                {
                    R();
                    Program.OSD_TXT = "Włączenie trybu\nN E T F L I X";
                }
                Program.OSD_ICO = Properties.Resources.N_icon;
            }

            if (line.Contains(STALE.TRYB_OFF))
            {
                Program.TRYB = "plex";
                if (_cbTRYB.Checked)
                {
                    R();
                    Program.OSD_TXT = "Włączenie trybu\nP L E X";
                }
                Program.OSD_ICO = Properties.Resources.Plex_Logo;
            }

            if (line.Contains(STALE.MYSZ_ON))
            {
                Program.TRYB = "mysz";
                if (_cbMYSZ.Checked)
                {
                    R();
                    Program.OSD_TXT = "Mysz Włączona";
                }
                Program.OSD_ICO = Properties.Resources.mouse;
            }
            if (line.Contains(STALE.MYSZ_OFF))
            {
                sPORT.Write("T");
                System.Threading.Thread.Sleep(100);
                sPORT.Write("W");
                if (_cbMYSZ.Checked)
                {
                    R();
                    Program.OSD_TXT = "Mysz Wyłączona";
                }
                Program.OSD_ICO = Properties.Resources.mouse;
            }
            #endregion

            #region Przyciski
            if (line.Contains(STALE.POWER))
            {
                if (_cbPOWER.Checked)
                {
                    R();
                    Program.OSD_TXT = "Escape";
                }
            }

            if (line.Contains(STALE.AUTO)) /* kod przycisków myszy jest wysyłany tylko w przypadku pracy w trybie myszki. nie trzeba sprawdzać softwareowo */
            {
                if (_cbAUTO.Checked)
                {
                    R();
                    Program.OSD_TXT = "LEWE kliknięcie";
                }
            }

            if (line.Contains(STALE.INPUT))
            {
                if (_cbINPUT.Checked)
                {
                    R();
                    Program.OSD_TXT = "PRAWE kliknięcie";
                }
            }

            if (line.Contains(STALE.MUTE))
            {
                if (_cbMUTE.Checked)
                {
                    R();
                    Program.OSD_TXT = "Wyciszenie";
                }
            }

            if (line.Contains(STALE.PRAWO))
            {
                if (_cbPRAWO.Checked)
                {
                    R();
                    Program.OSD_TXT = ">>> Przewiń do przodu";
                }
            }

            if (line.Contains(STALE.LEWO))
            {
                if (_cbLEWO.Checked)
                {
                    R();
                    Program.OSD_TXT = "<<< Przewiń do tyłu";
                }
            }

            if (line.Contains(STALE.ENTER))
            {
                if (_cbTRYB.Checked)
                {
                    R();
                    Program.OSD_TXT = "Wstrzymaj / Wznów";
                }
            }

            if (line.Contains(STALE.VOLUP))
            {
                if (_cbVOLUP.Checked)
                {
                    R();
                    Program.OSD_TXT = "Głośność +";
                }
            }

            if (line.Contains(STALE.VOLDW))
            {
                if (_cbVOLDW.Checked)
                {
                    R();
                    Program.OSD_TXT = "Głośność -";
                }
            }

            if (line.Contains("M+") || line.Contains("M-"))
            {
                if (_cbSPEED.Checked)
                {
                    R();
                    Program.OSD_TXT = string.Format("Prędkość myszki {0}", line.Remove(0, 2));
                }
            }

            if (line.Contains(STALE.CHUP))
            {
                if (_cbCHUP.Checked)
                {
                    R();
                    Program.OSD_TXT = "Następny w kolejce";
                }
            }

            if (line.Contains(STALE.CHDW))
            {
                if (_cbCHDW.Checked)
                {
                    R();
                    Program.OSD_TXT = "Poprzedni z kolejki";
                }
            }

            if (line.Contains(STALE.EXIT))
            {
                if (_cbEXIT.Checked)
                {
                    R();
                    Program.OSD_TXT = "Pełny ekran WŁ/WYŁ";
                }
            }

            if (line.Contains(STALE.CHUP))
            {
                if (_cbCHUP.Checked)
                {
                    R();
                    Program.OSD_TXT = "Następny w kolejce";
                }
            }

            if (_cbNUMERY.Checked)
            {
                if (line.Contains(STALE.B0))
                {
                    Program.OSD_TXT = "Przycisk 0";
                }
                if (line.Contains(STALE.B1))
                {
                    Program.OSD_TXT = "Przycisk 1";
                }
                if (line.Contains(STALE.B3))
                {
                    Program.OSD_TXT = "Przycisk 3";
                }
                if (line.Contains(STALE.B4))
                {
                    Program.OSD_TXT = "Przycisk 4";
                }
                if (line.Contains(STALE.B5))
                {
                    Program.OSD_TXT = "Przycisk 5";
                }
                if (line.Contains(STALE.B6))
                {
                    Program.OSD_TXT = "Przycisk ";
                }
                if (line.Contains(STALE.B7))
                {
                    Program.OSD_TXT = "Przycisk 7";
                }
                if (line.Contains(STALE.B8))
                {
                    Program.OSD_TXT = "Przycisk 8";
                }
                if (line.Contains(STALE.B9))
                {
                    Program.OSD_TXT = "Przycisk 9";
                }
                R();
            }

            if (line.Contains(STALE.CZERWONY))
            {
                if (_cbRED.Checked)
                {
                    R();
                    Program.OSD_TXT = "Wyzwolenie akcji przycisku\nC Z E R W O N Y";
                }
            }

            if (line.Contains(STALE.ZIELONY))
            {
                if (_cbGREEN.Checked)
                {
                    R();
                    Program.OSD_TXT = "Wyzwolenie akcji przycisku\nZ I E L O N Y";
                }
            }

            if (line.Contains(STALE.ZOLTY))
            {
                if (_cbYELLOW.Checked)
                {
                    R();
                    Program.OSD_TXT = "Wyzwolenie akcji przycisku\nŻ Ó Ł T Y";
                }
            }

            if (line.Contains(STALE.NIEBIESKI))
            {
                if (_cbBLUE.Checked)
                {
                    R();
                    Program.OSD_TXT = "Wyzwolenie akcji przycisku\nN I E B I E S K I";
                }
            }
            #endregion
        }


        private void FIXIKONA(object sender, EventArgs e)
        {
            IKONA.Icon = null;
            Application.DoEvents();
        }

        private void ICON_KLIK(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void ZAMYKANIE(object sender, FormClosingEventArgs e)
        {
            /* Problem w tym, że ikona się zawiesza przy wyjściu. Czyścimy ręcznie */
            IKONA.Icon = null;
            IKONA.Dispose();
            Application.DoEvents();
        }

        private void TIKTAK(object sender, EventArgs e)
        {
            port = PORT.getPorts(STALE.DEVICE);
            if (port != null)
            {
                _cSerialPort.Text = PORT.getPorts(STALE.DEVICE);
                if (!sPORT.IsOpen)
                {
                    sPORT.PortName = port;
                    sPORT.Open();
                    sPORT.Write("T");
                    System.Threading.Thread.Sleep(300);
                    sPORT.Write("W");
                }
            }
            else
            {
                _cSerialPort.Text = "Odłączony";
            }
            if(this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            IKONA.Text = "Pilot USB";
            IKONA.Icon = Properties.Resources.irremote;
            IKONA.Visible = true;
            _cSerialPort.Text = PORT.getPorts("Arduino Leonardo");
            TIK.Interval = 500; // sprawdzamy co pół sekundy
            TIK.Start();

            Program.OSD_ICO = Properties.Resources.Plex_Logo;
            Program.OSD_TXT = "Testowy\ntekst...";

        }

        #region KOLORKI
        private void _cOSDCOLOR_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (_cOSDCOLOR.Text)
            {
                case "Biały":
                    Program.OSD_COLOR = STALE.KOLOR.BIALY;
                    break;

                case "Czarny":
                    Program.OSD_COLOR = STALE.KOLOR.CZARNY;
                    break;

                case "Szary":
                    Program.OSD_COLOR = STALE.KOLOR.SZARY;
                    break;

                case "Niebieski":
                    Program.OSD_COLOR = STALE.KOLOR.NIEBESKI;
                    break;

                case "Zółty":
                    Program.OSD_COLOR = STALE.KOLOR.ZOLTY;
                    break;

                case "Czerwony":
                    Program.OSD_COLOR = STALE.KOLOR.CZERWONY;
                    break;

                case "Zielony":
                    Program.OSD_COLOR = STALE.KOLOR.ZIELONY;
                    break;

                case "Fioletowy":
                    Program.OSD_COLOR = STALE.KOLOR.FIOLETOWY;
                    break;

                case "Błękitny":
                    Program.OSD_COLOR = STALE.KOLOR.BLEKITNY;
                    break;

                default:
                    Program.OSD_COLOR = STALE.KOLOR.BIALY;
                    break;
            }
            _cCOLORPREV.BackColor = Program.OSD_COLOR;
        }
        #endregion

        private void frmMain_Shown(object sender, EventArgs e)
        {
            new frmOSD().Show();
        }

        private void _cmnuzamknij_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void _cCOLORPREV_Click(object sender, EventArgs e)
        {
            Program.Animating = true;
        }
    }

}
