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
        frmOSD fOSD = new frmOSD();
        PORTS PORT = new PORTS();
        NotifyIcon IKONA = new NotifyIcon();
        Timer TIK = new Timer();
        SerialPort sPORT = new SerialPort();
        Image ico_NFlix, ico_Plex, ico_Mysz, ico_DataON, ico_DataOFF;
        string port=null, GODZ=null;
        int PL=0, MI=0; // fancy animation :P
        LANG.Language LNG;
        string LABEL_Disconnected, OSD_Loading, OSD_ModeOn, OSD_ModeOff, OSD_MouseOn, OSD_MouseOff, OSD_Power, OSD_Auto, OSD_Input, OSD_Mute,
               OSD_Right, OSD_Left, OSD_Enter, OSD_VolUp, OSD_VolDw, OSD_ChUp, OSD_ChDw, OSD_Exit, OSD_Red, OSD_Green, OSD_911,
               OSD_Yellow, OSD_Blue, OSD_0, OSD_1, OSD_2, OSD_3, OSD_4, OSD_5, OSD_6, OSD_7, OSD_8, OSD_9, OSD_Time, OSD_MSpeed; // fckin hell ! 

        #endregion

        public frmMain()
        {
            InitializeComponent();

            #region events
            this.FormClosing += ZAMYKANIE;
            this.FormClosed += EXIT_ALL;
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
            ico_DataON = new Bitmap(Properties.Resources.green_circle_th, 16, 16);
            ico_DataOFF = new Bitmap(Properties.Resources.red_circle_th, 16, 16);

            #region Load settings from registry
            try
            {
                var lng = Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\AKIL_IR_REMOTE",
                                    "jezyk", LANG.Language.English);

                var s_min = Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\AKIL_IR_REMOTE",
                                    "zminimalizowany", "false");

                var s_rate = Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\AKIL_IR_REMOTE",
                                    "speed", null);

                _cbMINIMAL.Checked = bool.Parse(s_min.ToString());
                _cPortSPEED.SelectedText = s_rate.ToString();

                switch (lng)
                {
                    case "Polish":
                        LNG = LANG.Language.Polish;
                        ChangeLanguage(LANG.Language.Polish);
                        break;
                    case "English":
                    default:
                        LNG = LANG.Language.English;
                        ChangeLanguage(LANG.Language.English);
                        break;
                }

                ChangeLanguage(LNG);
                if (LNG == LANG.Language.Polish)
                {
                    _cLanguage.SelectedIndex = 0;
                }
                else
                {
                    _cLanguage.SelectedIndex = 1;
                }
            }
            catch (Exception)
            {
                _cPortSPEED.SelectedIndex = 5;
            }

            if (_cbMINIMAL.Checked)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            #endregion
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            string _dbg = null;
            #region dbg
#if DEBUG
            _dbg = " - DEBUG";
#endif
            #endregion

            IKONA.Text = string.Format("{0}{1}", STALE.TRAY_NAME, _dbg);
            IKONA.Icon = Properties.Resources.irremote;
            IKONA.Visible = true;
            _cSerialPort.Text = PORT.getPorts(STALE.DEVICE);
            TIK.Interval = 250; // sprawdzamy co ćwierć sekundy / check every quarter of second
            TIK.Start();
            _cOSDCOLOR.SelectedIndex = 0;

            Program.OSD_ICO = Properties.Resources.Plex_Logo;
            Program.OSD_TXT = OSD_Loading;

        }


        /// <summary>
        /// Show osd
        /// </summary>
        private void R()
        {
            Program.Animating = true;
            Program.TimeOut = 0;
        }


        #region Monitor device port
        private void MonitorSerial(object sender, SerialDataReceivedEventArgs e)
        {
            if (sPORT.IsOpen)
            {
                _cRECIVE.Image = ico_DataON;
                string line = sPORT.ReadLine().TrimEnd('\n').TrimEnd('\r');
                this.BeginInvoke(new LineReceivedEvent(LineReceived), line);
            }
        }

        private delegate void LineReceivedEvent(string line);

        private void LineReceived(string line)
        {
            switch (line)
            {
                #region Mode detection
                case STALE.CODES.MYSZ_OFF:
                    if(_cbMYSZ.Checked == true)
                    {
                        Program.MYSZ = false;
                        Program.OSD_TXT = OSD_MouseOff;
                        R();
                    }
                    break;

                case STALE.CODES.MYSZ_ON:
                    if (_cbMYSZ.Checked == true)
                    {
                        Program.MYSZ = true;
                        Program.OSD_TXT = OSD_MouseOn;
                        R();
                    }
                    break;

                case STALE.CODES.TRYB_ON:
                    if (_cbTRYB.Checked == true)
                    {
                        Program.OSD_TXT = OSD_ModeOn;
                        Program.TRYB = "netflix";
                        R();
                    }
                    break;

                case STALE.CODES.TRYB_OFF:
                    if (_cbTRYB.Checked == true)
                    {
                        Program.OSD_TXT = OSD_ModeOff;
                        Program.TRYB = "plex";
                        R();
                    }
                    break;

                #endregion

                #region Buttons

                case STALE.CODES.POWER:
                    if (_cbPOWER.Checked == true)
                    {
                        Program.OSD_TXT = OSD_Power;
                        R();
                    }
                    break;

                case STALE.CODES.AUTO:
                    if (_cbAUTO.Checked == true)
                    {
                        Program.OSD_TXT = OSD_Auto;
                        R();
                    }
                    break;

                case STALE.CODES.INPUT:
                    if (_cbINPUT.Checked == true)
                    {
                        Program.OSD_TXT = OSD_Input;
                        R();
                    }
                    break;

                case STALE.CODES.MUTE:
                    if (_cbMUTE.Checked == true)
                    {
                        Program.OSD_TXT = OSD_Mute;
                        R();
                    }
                    break;

                case STALE.CODES.PRAWO:
                    if (_cbPRAWO.Checked == true)
                    {
                        Program.OSD_TXT = OSD_Right;
                        R();
                    }
                    break;

                case STALE.CODES.LEWO:
                    if (_cbLEWO.Checked == true)
                    {
                        Program.OSD_TXT = OSD_Left;
                        R();
                    }
                    break;

                case STALE.CODES.ENTER:
                    Program.OSD_TXT = OSD_Enter;
                    R();
                    break;

                case STALE.CODES.VOLUP:
                    if (_cbVOLUP.Checked == true)
                    {
                        Program.OSD_TXT = string.Format("{1} {0}", PLUSY(), OSD_VolUp);
                        R();
                    }
                    break;

                case STALE.CODES.VOLDW:
                    if (_cbVOLDW.Checked == true)
                    {
                        Program.OSD_TXT = string.Format("{1} {0}", MINUSY(), OSD_VolDw);
                        R();
                    }
                    break;

                case STALE.CODES.CHUP:
                    if (_cbCHUP.Checked == true)
                    {
                        Program.OSD_TXT = OSD_ChUp;
                        R();
                    }
                    break;

                case STALE.CODES.CHDW:
                    if (_cbCHDW.Checked == true)
                    {
                        Program.OSD_TXT = OSD_ChDw;
                        R();
                    }
                    break;

                case STALE.CODES.EXIT:
                    if (_cbEXIT.Checked == true)
                    {
                        Program.OSD_TXT = OSD_Exit;
                        R();
                    }
                    break;

                    #region 0-9
                case STALE.CODES.B0:
                    if (_cbNUMERY.Checked == true)
                    {
                        Program.OSD_TXT = OSD_0;
                        //Program.OSD_TXT = "Przycisk 0";
                        //EN: Program.OSD_TXT = "Button 0";
                        R();
                    }
                    break;

                case STALE.CODES.B1:
                    if (_cbNUMERY.Checked == true)
                    {
                        Program.OSD_TXT = OSD_1;
                        //Program.OSD_TXT = "Przycisk 1";
                        //EN: Program.OSD_TXT = "Button 1";
                        R();
                    }
                    break;

                case STALE.CODES.B2:
                    if (_cbNUMERY.Checked == true)
                    {
                        Program.OSD_TXT = OSD_2;
                        //Program.OSD_TXT = "Przycisk 2";
                        //EN: Program.OSD_TXT = "Button 2";
                        R();
                    }
                    break;

                case STALE.CODES.B3:
                    if (_cbNUMERY.Checked == true)
                    {
                        Program.OSD_TXT = OSD_3;
                        //Program.OSD_TXT = "Przycisk 3";
                        //EN: Program.OSD_TXT = "Button 3";
                        R();
                    }
                    break;

                case STALE.CODES.B4:
                    if (_cbNUMERY.Checked == true)
                    {
                        Program.OSD_TXT = OSD_4;
                        //Program.OSD_TXT = "Przycisk 4";
                        //EN: Program.OSD_TXT = "Button 4";
                        R();
                    }
                    break;

                case STALE.CODES.B5:
                    if (_cbNUMERY.Checked == true)
                    {
                        Program.OSD_TXT = OSD_5;
                        //Program.OSD_TXT = "Przycisk 5";
                        //EN: Program.OSD_TXT = "Button 5";
                        R();
                    }
                    break;

                case STALE.CODES.B6:
                    if (_cbNUMERY.Checked == true)
                    {
                        Program.OSD_TXT = OSD_6;
                        //Program.OSD_TXT = "Przycisk 6";
                        //EN: Program.OSD_TXT = "Button 6";
                        R();
                    }
                    break;

                case STALE.CODES.B7:
                    if (_cbNUMERY.Checked == true)
                    {
                        Program.OSD_TXT = OSD_7;
                        //Program.OSD_TXT = "Przycisk 7";
                        //EN: Program.OSD_TXT = "Button 7";
                        R();
                    }
                    break;

                case STALE.CODES.B8:
                    if (_cbNUMERY.Checked == true)
                    {
                        Program.OSD_TXT = OSD_8;
                        //Program.OSD_TXT = "Przycisk 8";
                        //EN: Program.OSD_TXT = "Button 8";
                        R();
                    }
                    break;

                case STALE.CODES.B9:
                    if (_cbNUMERY.Checked == true)
                    {
                        Program.OSD_TXT = OSD_9;
                        //Program.OSD_TXT = "Przycisk 9";
                        //EN: Program.OSD_TXT = "Button 9";
                        R();
                    }
                    break;
                #endregion

                case STALE.CODES.CZERWONY:
                    if (_cbRED.Checked == true)
                    {
                        Program.OSD_TXT = OSD_Red;
                        R();
                    }
                    break;

                case STALE.CODES.ZIELONY:
                    if (_cbGREEN.Checked == true)
                    {
                        Program.OSD_TXT = OSD_Green;
                        R();
                    }
                    break;

                case STALE.CODES.ZOLTY:
                    if (_cbYELLOW.Checked == true)
                    {
                        Program.OSD_TXT = OSD_Yellow;
                        R();
                    }
                    break;

                case STALE.CODES.NIEBIESKI:
                    if (_cbBLUE.Checked == true)
                    {
                        Program.OSD_TXT = OSD_Blue;
                        R();
                    }
                    break;
                #endregion

                #region Other functions
                case STALE.CODES.SHOWME:
                    if (this.WindowState == FormWindowState.Minimized)
                    {
                        Program.OSD_TXT = OSD_911;
                        R();
                        SHOW();
                    }
                    break;

                case STALE.CODES.MENU:
                    GODZ = string.Format("{0}:{1}.{2}", DateTime.Now.Hour.ToString("00"),
                                                    DateTime.Now.Minute.ToString("00"),
                                                    DateTime.Now.Second.ToString("00"));

                    Program.OSD_TXT = string.Format("{1} {0}", GODZ, OSD_Time);
                    R();
                    break;
                #endregion

                default:
                    break;
            }

            if (line.Contains("M+") || line.Contains("M-"))
            {
                if (_cbSPEED.Checked)
                {
                    Program.OSD_TXT = string.Format("{1} {0}px ]", line, OSD_MSpeed);
                    R();
                }
            }
        }
        #endregion


        private void TIKTAK(object sender, EventArgs e)
        {
            #region DO STUFF

            _cMnuSerialSTART.Enabled = !sPORT.IsOpen;
            _cMnuSerialSTOP.Enabled = sPORT.IsOpen;

            _cRECIVE.Image = ico_DataOFF;

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
                    _cSerialPort.Text = LABEL_Disconnected;
                }
                if (this.WindowState == FormWindowState.Minimized)
                {
                    this.Hide();
                }
                if (_cpicTRYB.Image != Program.OSD_ICO)
                {
                    _cpicTRYB.Image = @Program.OSD_ICO;
                }
            }
            catch (Exception)
            {
                
            }

        #endregion
        }

        #region LOCALIZATION
        /// <summary>
        /// Change UI language
        /// </summary>
        /// <param name="lang">Language</param>
        /// <returns>true if success</returns>
        internal bool ChangeLanguage(LANG.Language lang)
        {
            bool ret = false;
            
            try
            {
                // one by one... fix this after VS update...
                if(lang == LANG.Language.Polish)
                {
                    this.Text = LANG.POLISH.str_cTitle;
                    _cbAUTO.Text = LANG.POLISH.str_cAuto;
                    _cGRUPA.Text = LANG.POLISH.str_cEvents;
                    _cbTRYB.Text = LANG.POLISH.str_cMode;
                    _cbMYSZ.Text = LANG.POLISH.str_cMouse;
                    _cbSPEED.Text = LANG.POLISH.str_cMSpeed;
                    _cbPOWER.Text = LANG.POLISH.str_cPower;
                    _cbSPEED.Text = LANG.POLISH.str_cMute;
                    _cbAUTO.Text = LANG.POLISH.str_cAuto;
                    _cbINPUT.Text = LANG.POLISH.str_cInput;
                    _cbPRAWO.Text = LANG.POLISH.str_cRight;
                    _cbLEWO.Text = LANG.POLISH.str_cLeft;
                    _cbGORA.Text = LANG.POLISH.str_cUp;
                    _cbDOL.Text = LANG.POLISH.str_cDown;
                    _cbVOLUP.Text = LANG.POLISH.str_cVolUP;
                    _cbVOLDW.Text = LANG.POLISH.str_cVolDW;
                    _cbCHUP.Text = LANG.POLISH.str_cCHUP;
                    _cbCHDW.Text = LANG.POLISH.str_cCHDW;
                    _cbEXIT.Text = LANG.POLISH.str_cExit;
                    _cbNUMERY.Text = LANG.POLISH.str_c09;
                    _cbRED.Text = LANG.POLISH.str_cRed;
                    _cbGREEN.Text = LANG.POLISH.str_cGreen;
                    _cbYELLOW.Text = LANG.POLISH.str_cYellow;
                    _cbBLUE.Text = LANG.POLISH.str_cBlue;
                    _cLABELLang.Text = LANG.POLISH.str_cLang;
                    _cbMINIMAL.Text = LANG.POLISH.str_cStartW;
                    _cLabelKOL.Text = LANG.POLISH.str_cOsdColor;
                    _cPORTLABEL.Text = LANG.POLISH.str_cDevLabel;
                    _cMnuSerialSTART.Text = LANG.POLISH.str_cmnuSerialStart;
                    _cMnuSerialSTOP.Text = LANG.POLISH.str_cmnuSerialStop;
                    _cmnushow.Text = LANG.POLISH.str_cmnuShow;
                    _cmnuzamknij.Text = LANG.POLISH.str_cmnuClose;

                    _cOSDCOLOR.Items.Clear();
                    _cOSDCOLOR.Items.Add(LANG.POLISH.str_sWhite);
                    _cOSDCOLOR.Items.Add(LANG.POLISH.str_sBlack);
                    _cOSDCOLOR.Items.Add(LANG.POLISH.str_sGrey);
                    _cOSDCOLOR.Items.Add(LANG.POLISH.str_sBlue);
                    _cOSDCOLOR.Items.Add(LANG.POLISH.str_sYellow);
                    _cOSDCOLOR.Items.Add(LANG.POLISH.str_sRed);
                    _cOSDCOLOR.Items.Add(LANG.POLISH.str_sGreen);
                    _cOSDCOLOR.Items.Add(LANG.POLISH.str_sPurple);
                    _cOSDCOLOR.Items.Add(LANG.POLISH.str_sAzure);

                    LABEL_Disconnected = LANG.POLISH.str_sDisconnected;

                    OSD_Loading = LANG.POLISH.str_oLoading;
                    OSD_ModeOn = LANG.POLISH.str_oModeOn;
                    OSD_ModeOff = LANG.POLISH.str_oModeOFF;
                    OSD_MouseOn = LANG.POLISH.str_oMouseON;
                    OSD_MouseOff = LANG.POLISH.str_oMouseOFF;
                    OSD_Power = LANG.POLISH.str_oPower;
                    OSD_Auto = LANG.POLISH.str_oAuto;
                    OSD_Input = LANG.POLISH.str_oInput;
                    OSD_Mute = LANG.POLISH.str_oMute;
                    OSD_Right = LANG.POLISH.str_oRight;
                    OSD_Left = LANG.POLISH.str_oLeft;
                    OSD_Enter = LANG.POLISH.str_oEnter;
                    OSD_VolUp = LANG.POLISH.str_oVolUP;
                    OSD_VolDw = LANG.POLISH.str_oVolDW;
                    OSD_ChUp = LANG.POLISH.str_oCHUP;
                    OSD_ChDw = LANG.POLISH.str_oCHDW;
                    OSD_Exit = LANG.POLISH.str_oExit;
                    OSD_Red = LANG.POLISH.str_oRed;
                    OSD_Green = LANG.POLISH.str_oGreen;
                    OSD_Yellow = LANG.POLISH.str_oYellow;
                    OSD_Blue = LANG.POLISH.str_oBlue;
                    OSD_0 = LANG.POLISH.str_o0;
                    OSD_1 = LANG.POLISH.str_o1;
                    OSD_2 = LANG.POLISH.str_o2;
                    OSD_3 = LANG.POLISH.str_o3;
                    OSD_4 = LANG.POLISH.str_o4;
                    OSD_5 = LANG.POLISH.str_o5;
                    OSD_6 = LANG.POLISH.str_o6;
                    OSD_7 = LANG.POLISH.str_o7;
                    OSD_8 = LANG.POLISH.str_o8;
                    OSD_9 = LANG.POLISH.str_o9;
                    OSD_Time = LANG.POLISH.str_oTime;
                    OSD_MSpeed = LANG.POLISH.str_oMouseSpeed;
                    OSD_911 = LANG.POLISH.str_o911;
                }

                if (lang == LANG.Language.English)
                {
                    this.Text = LANG.ENGLISH.str_cTitle;
                    _cbAUTO.Text = LANG.ENGLISH.str_cAuto;
                    _cGRUPA.Text = LANG.ENGLISH.str_cEvents;
                    _cbTRYB.Text = LANG.ENGLISH.str_cMode;
                    _cbMYSZ.Text = LANG.ENGLISH.str_cMouse;
                    _cbSPEED.Text = LANG.ENGLISH.str_cMSpeed;
                    _cbPOWER.Text = LANG.ENGLISH.str_cPower;
                    _cbSPEED.Text = LANG.ENGLISH.str_cMute;
                    _cbAUTO.Text = LANG.ENGLISH.str_cAuto;
                    _cbINPUT.Text = LANG.ENGLISH.str_cInput;
                    _cbPRAWO.Text = LANG.ENGLISH.str_cRight;
                    _cbLEWO.Text = LANG.ENGLISH.str_cLeft;
                    _cbGORA.Text = LANG.ENGLISH.str_cUp;
                    _cbDOL.Text = LANG.ENGLISH.str_cDown;
                    _cbVOLUP.Text = LANG.ENGLISH.str_cVolUP;
                    _cbVOLDW.Text = LANG.ENGLISH.str_cVolDW;
                    _cbCHUP.Text = LANG.ENGLISH.str_cCHUP;
                    _cbCHDW.Text = LANG.ENGLISH.str_cCHDW;
                    _cbEXIT.Text = LANG.ENGLISH.str_cExit;
                    _cbNUMERY.Text = LANG.ENGLISH.str_c09;
                    _cbRED.Text = LANG.ENGLISH.str_cRed;
                    _cbGREEN.Text = LANG.ENGLISH.str_cGreen;
                    _cbYELLOW.Text = LANG.ENGLISH.str_cYellow;
                    _cbBLUE.Text = LANG.ENGLISH.str_cBlue;
                    _cLABELLang.Text = LANG.ENGLISH.str_cLang;
                    _cbMINIMAL.Text = LANG.ENGLISH.str_cStartW;
                    _cLabelKOL.Text = LANG.ENGLISH.str_cOsdColor;
                    _cPORTLABEL.Text = LANG.ENGLISH.str_cDevLabel;
                    _cMnuSerialSTART.Text = LANG.ENGLISH.str_cmnuSerialStart;
                    _cMnuSerialSTOP.Text = LANG.ENGLISH.str_cmnuSerialStop;
                    _cmnushow.Text = LANG.ENGLISH.str_cmnuShow;
                    _cmnuzamknij.Text = LANG.ENGLISH.str_cmnuClose;

                    _cOSDCOLOR.Items.Clear();
                    _cOSDCOLOR.Items.Add(LANG.ENGLISH.str_sWhite);
                    _cOSDCOLOR.Items.Add(LANG.ENGLISH.str_sBlack);
                    _cOSDCOLOR.Items.Add(LANG.ENGLISH.str_sGrey);
                    _cOSDCOLOR.Items.Add(LANG.ENGLISH.str_sBlue);
                    _cOSDCOLOR.Items.Add(LANG.ENGLISH.str_sYellow);
                    _cOSDCOLOR.Items.Add(LANG.ENGLISH.str_sRed);
                    _cOSDCOLOR.Items.Add(LANG.ENGLISH.str_sGreen);
                    _cOSDCOLOR.Items.Add(LANG.ENGLISH.str_sPurple);
                    _cOSDCOLOR.Items.Add(LANG.ENGLISH.str_sAzure);

                    LABEL_Disconnected = LANG.ENGLISH.str_sDisconnected;

                    OSD_Loading = LANG.ENGLISH.str_oLoading;
                    OSD_ModeOn = LANG.ENGLISH.str_oModeOn;
                    OSD_ModeOff = LANG.ENGLISH.str_oModeOFF;
                    OSD_MouseOn = LANG.ENGLISH.str_oMouseON;
                    OSD_MouseOff = LANG.ENGLISH.str_oMouseOFF;
                    OSD_Power = LANG.ENGLISH.str_oPower;
                    OSD_Auto = LANG.ENGLISH.str_oAuto;
                    OSD_Input = LANG.ENGLISH.str_oInput;
                    OSD_Mute = LANG.ENGLISH.str_oMute;
                    OSD_Right = LANG.ENGLISH.str_oRight;
                    OSD_Left = LANG.ENGLISH.str_oLeft;
                    OSD_Enter = LANG.ENGLISH.str_oEnter;
                    OSD_VolUp = LANG.ENGLISH.str_oVolUP;
                    OSD_VolDw = LANG.ENGLISH.str_oVolDW;
                    OSD_ChUp = LANG.ENGLISH.str_oCHUP;
                    OSD_ChDw = LANG.ENGLISH.str_oCHDW;
                    OSD_Exit = LANG.ENGLISH.str_oExit;
                    OSD_Red = LANG.ENGLISH.str_oRed;
                    OSD_Green = LANG.ENGLISH.str_oGreen;
                    OSD_Yellow = LANG.ENGLISH.str_oYellow;
                    OSD_Blue = LANG.ENGLISH.str_oBlue;
                    OSD_0 = LANG.ENGLISH.str_o0;
                    OSD_1 = LANG.ENGLISH.str_o1;
                    OSD_2 = LANG.ENGLISH.str_o2;
                    OSD_3 = LANG.ENGLISH.str_o3;
                    OSD_4 = LANG.ENGLISH.str_o4;
                    OSD_5 = LANG.ENGLISH.str_o5;
                    OSD_6 = LANG.ENGLISH.str_o6;
                    OSD_7 = LANG.ENGLISH.str_o7;
                    OSD_8 = LANG.ENGLISH.str_o8;
                    OSD_9 = LANG.ENGLISH.str_o9;
                    OSD_Time = LANG.ENGLISH.str_oTime;
                    OSD_MSpeed = LANG.ENGLISH.str_oMouseSpeed;
                    OSD_911 = LANG.ENGLISH.str_o911;
                }
                ret = true;
            }
            catch (Exception ex)
            {
                ret = false;
                MessageBox.Show(ex.Message, STALE.TRAY_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return ret;
        }
        #endregion

        #region KOLORKI
        private void _cOSDCOLOR_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (_cOSDCOLOR.Text)
            {
                case LANG.ENGLISH.str_sWhite:
                case LANG.POLISH.str_sWhite:
                    Program.OSD_COLOR = STALE.KOLOR.BIALY;
                    break;

                case LANG.ENGLISH.str_sBlack:
                case LANG.POLISH.str_sBlack:
                    Program.OSD_COLOR = STALE.KOLOR.CZARNY;
                    break;

                case LANG.ENGLISH.str_sGrey:
                case LANG.POLISH.str_sGrey:
                    Program.OSD_COLOR = STALE.KOLOR.SZARY;
                    break;

                case LANG.ENGLISH.str_sBlue:
                case LANG.POLISH.str_sBlue:
                    Program.OSD_COLOR = STALE.KOLOR.NIEBESKI;
                    break;

                case LANG.ENGLISH.str_sYellow:
                case LANG.POLISH.str_sYellow:
                    Program.OSD_COLOR = STALE.KOLOR.ZOLTY;
                    break;

                case LANG.ENGLISH.str_sRed:
                case LANG.POLISH.str_sRed:
                    Program.OSD_COLOR = STALE.KOLOR.CZERWONY;
                    break;

                case LANG.ENGLISH.str_sGreen:
                case LANG.POLISH.str_sGreen:
                    Program.OSD_COLOR = STALE.KOLOR.ZIELONY;
                    break;

                case LANG.ENGLISH.str_sPurple:
                case LANG.POLISH.str_sPurple:
                    Program.OSD_COLOR = STALE.KOLOR.FIOLETOWY;
                    break;

                case LANG.ENGLISH.str_sAzure:
                case LANG.POLISH.str_sAzure:
                    Program.OSD_COLOR = STALE.KOLOR.BLEKITNY;
                    break;

                default:
                    Program.OSD_COLOR = STALE.KOLOR.BIALY;
                    break;
            }
            _cCOLORPREV.BackColor = Program.OSD_COLOR;
        }
        #endregion

        #region Clicks and stuff

        private void SHOW()
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.BringToFront();
            this.TopMost = true;
            this.TopMost = false;
        }

        private void EXIT_ALL(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            // lets start OSD in new thread. SMOOTH animations :)
            new System.Threading.Thread(() => new frmOSD().ShowDialog()).Start();
            //fOSD.Show();
        }

        private void _cGITLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/sutaj/Arduino-IR-Remote");
        }

        private void _cmnuzamknij_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void _cLanguage_SelectedValueChanged(object sender, EventArgs e)
        {
            if (_cLanguage.Text == "Polish")
            {
                Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\AKIL_IR_REMOTE", "jezyk", LANG.Language.Polish);
                ChangeLanguage(LANG.Language.Polish);
            }
            else
            {
                Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\AKIL_IR_REMOTE", "jezyk", LANG.Language.English);
                ChangeLanguage(LANG.Language.English);
            }
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

        private void FIXIKONA(object sender, EventArgs e)
        {
            IKONA.Icon = null;
            Application.DoEvents();
        }

        private void _cPortSPEED_SelectedIndexChanged(object sender, EventArgs e)
        {
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\AKIL_IR_REMOTE", "speed", _cPortSPEED.Text);
            sPORT.BaudRate = int.Parse(_cPortSPEED.Text);
        }

        private void _cMnuSerialSTOP_Click(object sender, EventArgs e)
        {
            try
            {
                sPORT.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error while stopping connection:\n{0}", ex.Message), "Serial Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _cMnuSerialSTART_Click(object sender, EventArgs e)
        {
            try
            {
                sPORT.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error while starting connection:\n{0}", ex.Message), "Serial Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        #endregion

        #region fancy shit
        string PLUSY()
        {
            string ret = null;
            PL++;
            if (PL == 1)
            {
                ret = "🔈+";
            }
            if (PL == 2)
            {
                ret = "🔈++";
            }
            if (PL == 3)
            {
                ret = "🔈+++";
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
                ret = "🔊-";
            }
            if (MI == 2)
            {
                ret = "🔊--";
            }
            if (MI == 3)
            {
                ret = "🔊---";
                MI = 0;
            }

            return ret;
        }
        #endregion
    }

}
