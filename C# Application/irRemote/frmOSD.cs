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
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            ANIMATE.Interval = 50;
            ANIMATE.Tick += Animacja;
            ANIMATE.Start();
        }

        private void Animacja(object sender, EventArgs e)
        {
            if (Program.TimeOut >= 4) // 5 sek.
            {
                Program.Animating = true;
            }

            if (Program.Animating)
            {
                if (Program.TimeOut < 1)
                {
                    // chyba najlepsza animacja to po prostu fadein
                    if (this.Opacity < .75)
                    {
                        this.Opacity += .03;
                    }
                    else
                    {
                        this.Opacity = .75;
                        Program.Animating = false;
                    }
                }
                else
                {
                    if (this.Opacity > 0)
                    {
                        this.Opacity -= .03;
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

        private void TIKrobiTAK(object sender, EventArgs e)
        {
            _cTXT.ForeColor = Program.OSD_COLOR;
            _cLOGO.Image = Program.OSD_ICO;
            _cTXT.Text = Program.OSD_TXT;

            if (this.Opacity == .75)
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
