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
        // zmień na nazwę swojej płytki ARDUINO IDE -> NARZĘDZIA -> POBIERZ INFORMACJE O PŁYTCE -> pole BN
        // change name for your arduino board, or atmega chipset
        internal static string DEVICE { get => "Arduino Leonardo"; }

        internal static string TRAY_NAME { get => "USB REMOTE"; }

        internal static string POWER { get => "x100"; }
        internal static string TRYB_ON { get => "x101.1"; }
        internal static string TRYB_OFF { get => "x101.0"; }
        internal static string MYSZ_ON { get => "x102.1"; }
        internal static string MYSZ_OFF { get => "x102.0"; }
        internal static string AUTO { get => "x103"; }
        internal static string INPUT { get => "x104"; }
        internal static string MUTE { get => "x105"; }
        internal static string PRAWO { get => "x106"; }
        internal static string LEWO { get => "x108"; }
        internal static string GORA { get => "x109"; }
        internal static string DOL { get => "x107"; }
        internal static string ENTER { get => "x110"; }
        internal static string VOLUP { get => "x111"; }
        internal static string VOLDW { get => "x112"; }
        internal static string CHUP { get => "x113"; }
        internal static string CHDW { get => "x114"; }
        internal static string EXIT { get => "x115"; }

        internal static string B1 { get => "x116"; }
        internal static string B2 { get => "x117"; }
        internal static string B3 { get => "x118"; }
        internal static string B4 { get => "x119"; }
        internal static string B5 { get => "x120"; }
        internal static string B6 { get => "x121"; }
        internal static string B7 { get => "x122"; }
        internal static string B8 { get => "x123"; }
        internal static string B9 { get => "x124"; }
        internal static string B0 { get => "x125"; }

        internal static string CZERWONY { get => "x126"; }
        internal static string ZIELONY { get => "x127"; }
        internal static string ZOLTY { get => "x128"; }
        internal static string NIEBIESKI { get => "x129"; }

        internal static string SHOWME { get => "x911"; }

        internal enum Tryb
        {
            Mysz,
            Netflix,
            Plex
        }

        /// <summary>
        /// collors
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
