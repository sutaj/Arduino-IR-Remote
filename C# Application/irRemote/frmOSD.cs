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
using System;
using System.Windows.Forms;

namespace irRemote
{
    public partial class frmOSD : Form
    {
        Timer TIK = new Timer();
        Timer ANIMATE = new Timer();

        public frmOSD()
        {
            InitializeComponent();

            TIK.Interval = 250;
            TIK.Tick += TIKrobiTAK;
            TIK.Start();

            ANIMATE.Interval = 30;
            ANIMATE.Tick += Animacja;
            ANIMATE.Start();
        }

        #region animate...
        private void Animacja(object sender, EventArgs e)
        {
                if (Program.TimeOut >= (STALE.OSD_TIMEOUT - 1))
                {
                    Program.Animating = true;
                }

            if (Program.Animating)
            {
                if (Program.TimeOut < 1)
                {
                    // chyba najlepsza animacja to po prostu fadein
                    if (this.Opacity < STALE.OSD_ALPHA)
                    {
                        this.Opacity += STALE.OSD_ANIM_MODIFICATOR;
                    }
                    else
                    {
                        this.Opacity = STALE.OSD_ALPHA;
                        Program.Animating = false;
                    }
                }
                else
                {
                    if (this.Opacity > 0)
                    {
                        this.Opacity -= STALE.OSD_ANIM_MODIFICATOR;
                    }
                    else
                    {
                        this.Opacity = 0;
                        Program.Animating = false;
                        Program.TimeOut = 0;
                    }
                }

            }

        }
        #endregion

        private void TIKrobiTAK(object sender, EventArgs e)
        {

            _cTXT.ForeColor = Program.OSD_COLOR;
            _cLOGO.Image = Program.OSD_ICO;
            _cTXT.Text = Program.OSD_TXT;

            if (this.Opacity == STALE.OSD_ALPHA)
            {
                Program.TimeOut++;
            }
        }

        private void frmOSD_Load(object sender, EventArgs e)
        {
            // operujemy na głównym monitorze...
            // osd on main monitor...
            this.Top = 0;
            this.Left = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
            Program.Animating = true;
        }

        private void frmOSD_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
