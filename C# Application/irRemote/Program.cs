﻿/***
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
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace irRemote
{
    static class Program
    {
        #region some vars
        static private Color _osd = STALE.KOLOR.BIALY;
        static private string _osdtxt = "Ładowanie...";
        static private Image _osdimg;
        static private int _timeout = 0;
        static private bool _animating = false;
        static private string _tryb;

        internal static Color OSD_COLOR { get => _osd; set => _osd = value; }
        internal static string OSD_TXT { get => _osdtxt; set => _osdtxt = value; }
        internal static Image OSD_ICO { get => _osdimg; set => _osdimg = value; }
        internal static int TimeOut { get => _timeout; set => _timeout = value; }
        internal static bool Animating { get => _animating; set => _animating = value; }
        internal static string TRYB { get => _tryb; set => _tryb = value; }
        #endregion


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
