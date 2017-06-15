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
 *      https://github.com/sutaj/Arduino-IR-Remote
 */

/* FREE FOR NON COMMERCIAL USE ONLY ! */

using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;
using Microsoft.Win32;

namespace irRemote
{
    public partial class frmMain : Form
    {

        #region SOME VARS
        PORTS PORT = new PORTS();
        NotifyIcon IKONA = new NotifyIcon();
        Timer TIK = new Timer();
        SerialPort sPORT = new SerialPort();
        Image ico_NFlix, ico_Plex, ico_Mysz;
        string port=null;
        int PL=0, MI=0; // fancy animation :P
        #endregion

        public frmMain()
        {
            InitializeComponent();

            #region events
            this.FormClosing += ZAMYKANIE;
            TIK.Tick += TIKTAK;
            IKONA.DoubleClick += ICON_KLIK;
            IKONA.Disposed += FIXIKONA;
            sPORT.DataReceived += MonitorSerial;
            #endregion


            IKONA.ContextMenuStrip = _cmnuIKONKA;
            sPORT.DtrEnable = true;
            sPORT.BaudRate = 9600;

            ico_NFlix = new Bitmap(Properties.Resources.N_icon, 64, 64);
            ico_Plex = new Bitmap(Properties.Resources.Plex_Logo, 64, 64);
            ico_Mysz = new Bitmap(Properties.Resources.mouse, 64, 64);

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            IKONA.Text = STALE.TRAY_NAME;
            IKONA.Icon = Properties.Resources.irremote;
            IKONA.Visible = true;
            _cSerialPort.Text = PORT.getPorts(STALE.DEVICE);
            TIK.Interval = 250; // sprawdzamy co ćwierć sekundy / check every quarter of second
            TIK.Start();
            _cOSDCOLOR.SelectedIndex = 0;

            Program.OSD_ICO = Properties.Resources.Plex_Logo;
            Program.OSD_TXT = "LOADING...";

            #region Load settings from registry
            try
            {
                var s_min = Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\AKIL_IR_REMOTE",
                                    "zminimalizowany", "false");

                _cbMINIMAL.Checked = bool.Parse(s_min.ToString());
            }
            catch (Exception)
            {
            }

            if (_cbMINIMAL.Checked)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            #endregion

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
            if (line.Contains(STALE.MYSZ_OFF))
            {
                Program.MYSZ = false;
                if (_cbMYSZ.Checked)
                {
                    R();
                    Program.OSD_TXT = "Mysz Wyłączona";
                    //EN: Program.OSD_TXT = "Mouse is OFF";
                }
            }

            if (line.Contains(STALE.MYSZ_ON))
            {
                Program.MYSZ = true;
                if (_cbMYSZ.Checked)
                {
                    R();
                    Program.OSD_TXT = "Mysz Włączona";
                    //EN: Program.OSD_TXT = "Mouse is ON";
                }
            }

            if (line.Contains(STALE.TRYB_ON))
            {
                Program.TRYB = "netflix";
                if (_cbTRYB.Checked)
                {
                    R();
                    Program.OSD_TXT = "Włączenie trybu\nN E T F L I X";
                    //EN: Program.OSD_TXT = "N E T F L I X\nMode";
                }
            }

            if (line.Contains(STALE.TRYB_OFF))
            {
                Program.TRYB = "plex";
                if (_cbTRYB.Checked)
                {
                    R();
                    Program.OSD_TXT = "Włączenie trybu\nP L E X";
                    //EN: Program.OSD_TXT = "P L E X\nMode";
                }
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

            if (line.Contains(STALE.AUTO))
            {
                if (_cbAUTO.Checked)
                {
                    R();
                    Program.OSD_TXT = "LEWE kliknięcie";
                    //EN: Program.OSD_TXT = "LEFT mouse click";
                }
            }

            if (line.Contains(STALE.INPUT))
            {
                if (_cbINPUT.Checked)
                {
                    R();
                    Program.OSD_TXT = "PRAWE kliknięcie";
                    //EN: Program.OSD_TXT = "RIGHT mouse click";
                }
            }

            if (line.Contains(STALE.MUTE))
            {
                if (_cbMUTE.Checked)
                {
                    R();
                    Program.OSD_TXT = "Wyciszenie";
                    //EN: Program.OSD_TXT = "Mute";
                }
            }

            if (line.Contains(STALE.PRAWO))
            {
                if (_cbPRAWO.Checked)
                {
                    R();
                    Program.OSD_TXT = ">> Przewiń do przodu";
                    //EN: Program.OSD_TXT = ">> Seek forward";
                }
            }

            if (line.Contains(STALE.LEWO))
            {
                if (_cbLEWO.Checked)
                {
                    R();
                    Program.OSD_TXT = "<< Przewiń do tyłu";
                    //EN: Program.OSD_TXT = "<< Rewind";
                }
            }

            if (line.Contains(STALE.ENTER))
            {
                if (_cbTRYB.Checked)
                {
                    R();
                    Program.OSD_TXT = "Wstrzymaj / Wznów";
                    //EN: Program.OSD_TXT = "Play / Pause";
                }
            }

            if (line.Contains(STALE.VOLUP))
            {
                if (_cbVOLUP.Checked)
                {
                    R();
                    Program.OSD_TXT = string.Format("Głośność {0}", PLUSY());
                    //EN: Program.OSD_TXT = string.Format("Volume {0}", PLUSY());
                }
            }

            if (line.Contains(STALE.VOLDW))
            {
                if (_cbVOLDW.Checked)
                {
                    R();
                    Program.OSD_TXT = string.Format("Głośność {0}", MINUSY());
                    //EN: Program.OSD_TXT = string.Format("Volume {0}", MINUSY());
                }
            }

            if (line.Contains("M+") || line.Contains("M-"))
            {
                if (_cbSPEED.Checked)
                {
                    R();
                    Program.OSD_TXT = string.Format("Prędkość myszki\npx + {0}", line.Replace("\n", "" ));
                    //EN: Program.OSD_TXT = string.Format("Mouse Speed\npx + {0}", line.Replace("\n", "" ));
                }
            }

            if (line.Contains(STALE.CHUP))
            {
                if (_cbCHUP.Checked)
                {
                    R();
                    Program.OSD_TXT = "Następny odcinek";
                    //EN: Program.OSD_TXT = "Next episode";
                }
            }

            if (line.Contains(STALE.CHDW))
            {
                if (_cbCHDW.Checked)
                {
                    R();
                    Program.OSD_TXT = "Poprzedni odcinek";
                    //EN: Program.OSD_TXT = "Previous episode";
                }
            }

            if (line.Contains(STALE.EXIT))
            {
                if (_cbEXIT.Checked)
                {
                    R();
                    Program.OSD_TXT = "Pełny ekran WŁ/WYŁ";
                    //EN: Program.OSD_TXT = "Toggle\nFull Screepn";
                }
            }

            if (_cbNUMERY.Checked)
            {
                if (line.Contains(STALE.B0))
                {
                    Program.OSD_TXT = "Przycisk 0";
                    //EN: Program.OSD_TXT = "Button 0";
                }
                if (line.Contains(STALE.B1))
                {
                    Program.OSD_TXT = "Przycisk 1";
                    //EN: Program.OSD_TXT = "Button 1";
                }
                if (line.Contains(STALE.B2))
                {
                    Program.OSD_TXT = "Przycisk 2";
                    //EN: Program.OSD_TXT = "Button 2";
                }
                if (line.Contains(STALE.B3))
                {
                    Program.OSD_TXT = "Przycisk 3";
                    //EN: Program.OSD_TXT = "Button 3";
                }
                if (line.Contains(STALE.B4))
                {
                    Program.OSD_TXT = "Przycisk 4";
                    //EN: Program.OSD_TXT = "Button 4";
                }
                if (line.Contains(STALE.B5))
                {
                    Program.OSD_TXT = "Przycisk 5";
                    //EN: Program.OSD_TXT = "Button 5";
                }
                if (line.Contains(STALE.B6))
                {
                    Program.OSD_TXT = "Przycisk 6";
                    //EN: Program.OSD_TXT = "Button 6";
                }
                if (line.Contains(STALE.B7))
                {
                    Program.OSD_TXT = "Przycisk 7";
                    //EN: Program.OSD_TXT = "Button 7";
                }
                if (line.Contains(STALE.B8))
                {
                    Program.OSD_TXT = "Przycisk 8";
                    //EN: Program.OSD_TXT = "Button 8";
                }
                if (line.Contains(STALE.B9))
                {
                    Program.OSD_TXT = "Przycisk 9";
                    //EN: Program.OSD_TXT = "Button 9";
                }
                R();
            }

            if (line.Contains(STALE.CZERWONY))
            {
                if (_cbRED.Checked)
                {
                    R();
                    Program.OSD_TXT = "Wyzwolenie akcji przycisku\nC Z E R W O N Y";
                    //EN: Program.OSD_TXT = "Action under\nR E D";
                }
            }

            if (line.Contains(STALE.ZIELONY))
            {
                if (_cbGREEN.Checked)
                {
                    R();
                    Program.OSD_TXT = "Wyzwolenie akcji przycisku\nZ I E L O N Y";
                    //EN: Program.OSD_TXT = "Action under\nG R E E N";
                }
            }

            if (line.Contains(STALE.ZOLTY))
            {
                if (_cbYELLOW.Checked)
                {
                    R();
                    Program.OSD_TXT = "Wyzwolenie akcji przycisku\nŻ Ó Ł T Y";
                    //EN: Program.OSD_TXT = "Action under\nY E L L O W";
                }
            }

            if (line.Contains(STALE.NIEBIESKI))
            {
                if (_cbBLUE.Checked)
                {
                    R();
                    Program.OSD_TXT = "Wyzwolenie akcji przycisku\nN I E B I E S K I";
                    //EN: Program.OSD_TXT = "Action under\nB L U E";
                }
            }
            #endregion

            #region Other functions
            if (line.Contains(STALE.SHOWME))
            {
                if (this.WindowState == FormWindowState.Minimized)
                {
                    R();
                    Program.OSD_TXT = "Pokazuję program...";
                    //EN: Program.OSD_TXT = "Showing program...";
                    SHOW();
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
            SHOW();
        }

        private void ZAMYKANIE(object sender, FormClosingEventArgs e)
        {
            /* Problem w tym, że ikona się zawiesza przy wyjściu. Czyścimy ręcznie */
            /* Bugfix for notyfiicon */
            IKONA.Icon = null;
            IKONA.Dispose();
            Application.DoEvents();
        }

        private void TIKTAK(object sender, EventArgs e)
        {
            #region DO STUFF
            try
            {
                if (Program.MYSZ)
                {
                    Program.OSD_ICO = ico_Mysz;
                    IKONA.Icon = Icon.FromHandle(Properties.Resources.mouse.GetHicon());
                }
                else
                {
                    if (Program.TRYB == "netflix")
                    {
                        Program.OSD_ICO = ico_NFlix;
                    }
                    else
                    {
                        Program.OSD_ICO = ico_Plex;
                    }
                    IKONA.Icon = Properties.Resources.irremote;
                }

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
                        sPORT.Write("M");
                    }
                }
                else
                {
                    _cSerialPort.Text = "Odłączony";
                    //EN: _cSerialPort.Text = "Disconnected";
                }
                if (this.WindowState == FormWindowState.Minimized)
                {
                    this.Hide();
                }
                _cpicTRYB.Image = Program.OSD_ICO;
            }
            catch (Exception)
            {
            }
            #endregion

        }

        #region KOLORKI
        private void _cOSDCOLOR_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (_cOSDCOLOR.Text)
            {
                case "White":
                    Program.OSD_COLOR = STALE.KOLOR.BIALY;
                    break;

                case "Black":
                    Program.OSD_COLOR = STALE.KOLOR.CZARNY;
                    break;

                case "Grey":
                    Program.OSD_COLOR = STALE.KOLOR.SZARY;
                    break;

                case "Blue":
                    Program.OSD_COLOR = STALE.KOLOR.NIEBESKI;
                    break;

                case "Yellow":
                    Program.OSD_COLOR = STALE.KOLOR.ZOLTY;
                    break;

                case "Red":
                    Program.OSD_COLOR = STALE.KOLOR.CZERWONY;
                    break;

                case "Green":
                    Program.OSD_COLOR = STALE.KOLOR.ZIELONY;
                    break;

                case "Purple":
                    Program.OSD_COLOR = STALE.KOLOR.FIOLETOWY;
                    break;

                case "Azure":
                    Program.OSD_COLOR = STALE.KOLOR.BLEKITNY;
                    break;

                default:
                    Program.OSD_COLOR = STALE.KOLOR.BIALY;
                    break;
            }
            _cCOLORPREV.BackColor = Program.OSD_COLOR;
        }
        #endregion

        private void SHOW()
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            new frmOSD().Show();
        }

        private void _cmnuzamknij_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void _cbMINIMAL_CheckedChanged(object sender, EventArgs e)
        {
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\AKIL_IR_REMOTE", "zminimalizowany", _cbMINIMAL.Checked);
        }

        private void _cCOLORPREV_Click(object sender, EventArgs e)
        {
            Program.Animating = true;
        }

        private void _cmnushow_Click(object sender, EventArgs e)
        {
            SHOW();
        }

        #region fancy shit
        string PLUSY()
        {
            string ret = null;
            PL++;
            if (PL == 1)
            {
                ret = "+";
            }
            if (PL == 2)
            {
                ret = "++";
            }
            if (PL == 3)
            {
                ret = "+++";
                PL = 0;
            }

            return ret;
        }

        string MINUSY()
        {
            string ret = null;
            MI++;
            if (MI == 1)
            {
                ret = "-";
            }
            if (MI == 2)
            {
                ret = "--";
            }
            if (MI == 3)
            {
                ret = "---";
                MI = 0;
            }

            return ret;
        }
        #endregion
    }

}
