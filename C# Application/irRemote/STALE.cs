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

using System.Drawing;

namespace irRemote
{
    static internal class STALE
    {
        #region locals...
        private static string tray_name = "USB REMOTE";
        private static double osd_anim_modificator = .025;
        private static double osd_alpha = .75;
        private static int osd_timeout = 5;
        #endregion

        // zmień na nazwę swojej płytki ARDUINO IDE -> NARZĘDZIA -> POBIERZ INFORMACJE O PŁYTCE -> pole BN
        // change name for your arduino board, or atmega chipset
        internal static string DEVICE { get => "Arduino Leonardo"; }

        internal static string TRAY_NAME { get => tray_name; set => tray_name = value; }
        internal static double OSD_ALPHA { get => osd_alpha; set => osd_alpha = value; }
        internal static double OSD_ANIM_MODIFICATOR { get => osd_anim_modificator; set => osd_anim_modificator = value; }
        internal static int OSD_TIMEOUT { get => osd_timeout; set => osd_timeout = value; } // OSD show time in seconds...

        static internal class CODES
        {
            internal const string POWER     = "x100";
            internal const string TRYB_ON   = "x101.1";
            internal const string TRYB_OFF  = "x101.0";
            internal const string MYSZ_ON   = "x102.1";
            internal const string MYSZ_OFF  = "x102.0";
            internal const string AUTO      = "x103";
            internal const string INPUT     = "x104";
            internal const string MUTE      = "x105";
            internal const string PRAWO     = "x106";
            internal const string LEWO      = "x108";
            internal const string GORA      = "x109";
            internal const string DOL       = "x107";
            internal const string ENTER     = "x110";
            internal const string VOLUP     = "x111";
            internal const string VOLDW     = "x112";
            internal const string CHUP      = "x113";
            internal const string CHDW      = "x114";
            internal const string EXIT      = "x115";
            internal const string MENU      = "x130";

            internal const string B1 = "x116";
            internal const string B2 = "x117";
            internal const string B3 = "x118";
            internal const string B4 = "x119";
            internal const string B5 = "x120";
            internal const string B6 = "x121";
            internal const string B7 = "x122";
            internal const string B8 = "x123";
            internal const string B9 = "x124";
            internal const string B0 = "x125";

            internal const string CZERWONY  = "x126";
            internal const string ZIELONY   = "x127";
            internal const string ZOLTY     = "x128";
            internal const string NIEBIESKI = "x129";

            internal const string SHOWME    = "x911";
        }

        internal enum Tryb
        {
            Mysz,
            Netflix,
            Plex
        }

        /// <summary>
        /// kolorki
        /// </summary>
        static internal class KOLOR
        {
            internal static Color BIALY { get => Color.FromArgb(255, 255, 255); }
            internal static Color CZARNY { get => Color.FromArgb(0, 0, 0); }
            internal static Color SZARY { get => Color.FromArgb(148, 148, 148); }
            internal static Color NIEBESKI { get => Color.FromArgb(62, 32, 204); }
            internal static Color ZOLTY { get => Color.FromArgb(221, 223, 27); }
            internal static Color CZERWONY { get => Color.FromArgb(188, 68, 56); }
            internal static Color ZIELONY { get => Color.FromArgb(44, 226, 121); }
            internal static Color FIOLETOWY { get => Color.FromArgb(226, 44, 215); }
            internal static Color BLEKITNY { get => Color.FromArgb(103, 222, 244); }
        }

    }
}
