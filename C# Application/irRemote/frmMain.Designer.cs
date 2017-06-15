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
namespace irRemote
{
    partial class frmMain
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this._cSTRIP = new System.Windows.Forms.StatusStrip();
            this._cPORTLABEL = new System.Windows.Forms.ToolStripStatusLabel();
            this._cSerialPort = new System.Windows.Forms.ToolStripStatusLabel();
            this._cGRUPA = new System.Windows.Forms.GroupBox();
            this._cbBLUE = new System.Windows.Forms.CheckBox();
            this._cbYELLOW = new System.Windows.Forms.CheckBox();
            this._cbGREEN = new System.Windows.Forms.CheckBox();
            this._cbRED = new System.Windows.Forms.CheckBox();
            this._cbNUMERY = new System.Windows.Forms.CheckBox();
            this._cbEXIT = new System.Windows.Forms.CheckBox();
            this._cbCHDW = new System.Windows.Forms.CheckBox();
            this._cbCHUP = new System.Windows.Forms.CheckBox();
            this._cbVOLDW = new System.Windows.Forms.CheckBox();
            this._cbVOLUP = new System.Windows.Forms.CheckBox();
            this._cbDOL = new System.Windows.Forms.CheckBox();
            this._cbGORA = new System.Windows.Forms.CheckBox();
            this._cbLEWO = new System.Windows.Forms.CheckBox();
            this._cbPRAWO = new System.Windows.Forms.CheckBox();
            this._cbINPUT = new System.Windows.Forms.CheckBox();
            this._cbAUTO = new System.Windows.Forms.CheckBox();
            this._cbMUTE = new System.Windows.Forms.CheckBox();
            this._cbPOWER = new System.Windows.Forms.CheckBox();
            this._cSEPA = new System.Windows.Forms.PictureBox();
            this._cSEP = new System.Windows.Forms.PictureBox();
            this._cbSPEED = new System.Windows.Forms.CheckBox();
            this._cbMYSZ = new System.Windows.Forms.CheckBox();
            this._cbTRYB = new System.Windows.Forms.CheckBox();
            this._cLabelKOL = new System.Windows.Forms.Label();
            this._cOSDCOLOR = new System.Windows.Forms.ComboBox();
            this._cCOLORPREV = new System.Windows.Forms.Panel();
            this._cmnuIKONKA = new System.Windows.Forms.ContextMenuStrip(this.components);
            this._cmnuzamknij = new System.Windows.Forms.ToolStripMenuItem();
            this._cSTRIP.SuspendLayout();
            this._cGRUPA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._cSEPA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._cSEP)).BeginInit();
            this._cmnuIKONKA.SuspendLayout();
            this.SuspendLayout();
            // 
            // _cSTRIP
            // 
            this._cSTRIP.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._cPORTLABEL,
            this._cSerialPort});
            this._cSTRIP.Location = new System.Drawing.Point(0, 367);
            this._cSTRIP.Name = "_cSTRIP";
            this._cSTRIP.Size = new System.Drawing.Size(462, 22);
            this._cSTRIP.TabIndex = 0;
            this._cSTRIP.Text = "statusStrip1";
            // 
            // _cPORTLABEL
            // 
            this._cPORTLABEL.Name = "_cPORTLABEL";
            this._cPORTLABEL.Size = new System.Drawing.Size(82, 17);
            this._cPORTLABEL.Text = "Aktualny port:";
            // 
            // _cSerialPort
            // 
            this._cSerialPort.Name = "_cSerialPort";
            this._cSerialPort.Size = new System.Drawing.Size(0, 17);
            // 
            // _cGRUPA
            // 
            this._cGRUPA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._cGRUPA.Controls.Add(this._cbBLUE);
            this._cGRUPA.Controls.Add(this._cbYELLOW);
            this._cGRUPA.Controls.Add(this._cbGREEN);
            this._cGRUPA.Controls.Add(this._cbRED);
            this._cGRUPA.Controls.Add(this._cbNUMERY);
            this._cGRUPA.Controls.Add(this._cbEXIT);
            this._cGRUPA.Controls.Add(this._cbCHDW);
            this._cGRUPA.Controls.Add(this._cbCHUP);
            this._cGRUPA.Controls.Add(this._cbVOLDW);
            this._cGRUPA.Controls.Add(this._cbVOLUP);
            this._cGRUPA.Controls.Add(this._cbDOL);
            this._cGRUPA.Controls.Add(this._cbGORA);
            this._cGRUPA.Controls.Add(this._cbLEWO);
            this._cGRUPA.Controls.Add(this._cbPRAWO);
            this._cGRUPA.Controls.Add(this._cbINPUT);
            this._cGRUPA.Controls.Add(this._cbAUTO);
            this._cGRUPA.Controls.Add(this._cbMUTE);
            this._cGRUPA.Controls.Add(this._cbPOWER);
            this._cGRUPA.Controls.Add(this._cSEPA);
            this._cGRUPA.Controls.Add(this._cSEP);
            this._cGRUPA.Controls.Add(this._cbSPEED);
            this._cGRUPA.Controls.Add(this._cbMYSZ);
            this._cGRUPA.Controls.Add(this._cbTRYB);
            this._cGRUPA.Location = new System.Drawing.Point(12, 12);
            this._cGRUPA.Name = "_cGRUPA";
            this._cGRUPA.Size = new System.Drawing.Size(438, 306);
            this._cGRUPA.TabIndex = 1;
            this._cGRUPA.TabStop = false;
            this._cGRUPA.Text = "Zdarzenia";
            // 
            // _cbBLUE
            // 
            this._cbBLUE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._cbBLUE.AutoSize = true;
            this._cbBLUE.Checked = true;
            this._cbBLUE.CheckState = System.Windows.Forms.CheckState.Checked;
            this._cbBLUE.Location = new System.Drawing.Point(316, 275);
            this._cbBLUE.Name = "_cbBLUE";
            this._cbBLUE.Size = new System.Drawing.Size(78, 17);
            this._cbBLUE.TabIndex = 21;
            this._cbBLUE.Text = "NIEBIESKI";
            this._cbBLUE.UseVisualStyleBackColor = true;
            // 
            // _cbYELLOW
            // 
            this._cbYELLOW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._cbYELLOW.AutoSize = true;
            this._cbYELLOW.Checked = true;
            this._cbYELLOW.CheckState = System.Windows.Forms.CheckState.Checked;
            this._cbYELLOW.Location = new System.Drawing.Point(228, 275);
            this._cbYELLOW.Name = "_cbYELLOW";
            this._cbYELLOW.Size = new System.Drawing.Size(62, 17);
            this._cbYELLOW.TabIndex = 20;
            this._cbYELLOW.Text = "ŻÓŁTY";
            this._cbYELLOW.UseVisualStyleBackColor = true;
            // 
            // _cbGREEN
            // 
            this._cbGREEN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._cbGREEN.AutoSize = true;
            this._cbGREEN.Checked = true;
            this._cbGREEN.CheckState = System.Windows.Forms.CheckState.Checked;
            this._cbGREEN.Location = new System.Drawing.Point(130, 275);
            this._cbGREEN.Name = "_cbGREEN";
            this._cbGREEN.Size = new System.Drawing.Size(72, 17);
            this._cbGREEN.TabIndex = 19;
            this._cbGREEN.Text = "ZIELONY";
            this._cbGREEN.UseVisualStyleBackColor = true;
            // 
            // _cbRED
            // 
            this._cbRED.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._cbRED.AutoSize = true;
            this._cbRED.Checked = true;
            this._cbRED.CheckState = System.Windows.Forms.CheckState.Checked;
            this._cbRED.Location = new System.Drawing.Point(15, 275);
            this._cbRED.Name = "_cbRED";
            this._cbRED.Size = new System.Drawing.Size(89, 17);
            this._cbRED.TabIndex = 18;
            this._cbRED.Text = "CZERWONY";
            this._cbRED.UseVisualStyleBackColor = true;
            // 
            // _cbNUMERY
            // 
            this._cbNUMERY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._cbNUMERY.AutoSize = true;
            this._cbNUMERY.Checked = true;
            this._cbNUMERY.CheckState = System.Windows.Forms.CheckState.Checked;
            this._cbNUMERY.Location = new System.Drawing.Point(259, 238);
            this._cbNUMERY.Name = "_cbNUMERY";
            this._cbNUMERY.Size = new System.Drawing.Size(85, 17);
            this._cbNUMERY.TabIndex = 17;
            this._cbNUMERY.Text = "Przyciski 0-9";
            this._cbNUMERY.UseVisualStyleBackColor = true;
            // 
            // _cbEXIT
            // 
            this._cbEXIT.AutoSize = true;
            this._cbEXIT.Checked = true;
            this._cbEXIT.CheckState = System.Windows.Forms.CheckState.Checked;
            this._cbEXIT.Location = new System.Drawing.Point(15, 238);
            this._cbEXIT.Name = "_cbEXIT";
            this._cbEXIT.Size = new System.Drawing.Size(98, 17);
            this._cbEXIT.TabIndex = 16;
            this._cbEXIT.Text = "Przycisku EXIT";
            this._cbEXIT.UseVisualStyleBackColor = true;
            // 
            // _cbCHDW
            // 
            this._cbCHDW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._cbCHDW.AutoSize = true;
            this._cbCHDW.Checked = true;
            this._cbCHDW.CheckState = System.Windows.Forms.CheckState.Checked;
            this._cbCHDW.Location = new System.Drawing.Point(259, 214);
            this._cbCHDW.Name = "_cbCHDW";
            this._cbCHDW.Size = new System.Drawing.Size(92, 17);
            this._cbCHDW.TabIndex = 15;
            this._cbCHDW.Text = "Przycisku CH-";
            this._cbCHDW.UseVisualStyleBackColor = true;
            // 
            // _cbCHUP
            // 
            this._cbCHUP.AutoSize = true;
            this._cbCHUP.Checked = true;
            this._cbCHUP.CheckState = System.Windows.Forms.CheckState.Checked;
            this._cbCHUP.Location = new System.Drawing.Point(15, 214);
            this._cbCHUP.Name = "_cbCHUP";
            this._cbCHUP.Size = new System.Drawing.Size(95, 17);
            this._cbCHUP.TabIndex = 14;
            this._cbCHUP.Text = "Przycisku CH+";
            this._cbCHUP.UseVisualStyleBackColor = true;
            // 
            // _cbVOLDW
            // 
            this._cbVOLDW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._cbVOLDW.AutoSize = true;
            this._cbVOLDW.Checked = true;
            this._cbVOLDW.CheckState = System.Windows.Forms.CheckState.Checked;
            this._cbVOLDW.Location = new System.Drawing.Point(259, 190);
            this._cbVOLDW.Name = "_cbVOLDW";
            this._cbVOLDW.Size = new System.Drawing.Size(98, 17);
            this._cbVOLDW.TabIndex = 13;
            this._cbVOLDW.Text = "Przycisku VOL-";
            this._cbVOLDW.UseVisualStyleBackColor = true;
            // 
            // _cbVOLUP
            // 
            this._cbVOLUP.AutoSize = true;
            this._cbVOLUP.Checked = true;
            this._cbVOLUP.CheckState = System.Windows.Forms.CheckState.Checked;
            this._cbVOLUP.Location = new System.Drawing.Point(15, 190);
            this._cbVOLUP.Name = "_cbVOLUP";
            this._cbVOLUP.Size = new System.Drawing.Size(101, 17);
            this._cbVOLUP.TabIndex = 12;
            this._cbVOLUP.Text = "Przycisku VOL+";
            this._cbVOLUP.UseVisualStyleBackColor = true;
            // 
            // _cbDOL
            // 
            this._cbDOL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._cbDOL.AutoSize = true;
            this._cbDOL.Checked = true;
            this._cbDOL.CheckState = System.Windows.Forms.CheckState.Checked;
            this._cbDOL.Location = new System.Drawing.Point(259, 167);
            this._cbDOL.Name = "_cbDOL";
            this._cbDOL.Size = new System.Drawing.Size(103, 17);
            this._cbDOL.TabIndex = 11;
            this._cbDOL.Text = "Przycisku w Dół";
            this._cbDOL.UseVisualStyleBackColor = true;
            // 
            // _cbGORA
            // 
            this._cbGORA.AutoSize = true;
            this._cbGORA.Checked = true;
            this._cbGORA.CheckState = System.Windows.Forms.CheckState.Checked;
            this._cbGORA.Location = new System.Drawing.Point(15, 167);
            this._cbGORA.Name = "_cbGORA";
            this._cbGORA.Size = new System.Drawing.Size(108, 17);
            this._cbGORA.TabIndex = 10;
            this._cbGORA.Text = "Przycisku w Górę";
            this._cbGORA.UseVisualStyleBackColor = true;
            // 
            // _cbLEWO
            // 
            this._cbLEWO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._cbLEWO.AutoSize = true;
            this._cbLEWO.Checked = true;
            this._cbLEWO.CheckState = System.Windows.Forms.CheckState.Checked;
            this._cbLEWO.Location = new System.Drawing.Point(259, 143);
            this._cbLEWO.Name = "_cbLEWO";
            this._cbLEWO.Size = new System.Drawing.Size(111, 17);
            this._cbLEWO.TabIndex = 9;
            this._cbLEWO.Text = "Przycisku w Lewo";
            this._cbLEWO.UseVisualStyleBackColor = true;
            // 
            // _cbPRAWO
            // 
            this._cbPRAWO.AutoSize = true;
            this._cbPRAWO.Checked = true;
            this._cbPRAWO.CheckState = System.Windows.Forms.CheckState.Checked;
            this._cbPRAWO.Location = new System.Drawing.Point(15, 143);
            this._cbPRAWO.Name = "_cbPRAWO";
            this._cbPRAWO.Size = new System.Drawing.Size(115, 17);
            this._cbPRAWO.TabIndex = 8;
            this._cbPRAWO.Text = "Przycisku w Prawo";
            this._cbPRAWO.UseVisualStyleBackColor = true;
            // 
            // _cbINPUT
            // 
            this._cbINPUT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._cbINPUT.AutoSize = true;
            this._cbINPUT.Checked = true;
            this._cbINPUT.CheckState = System.Windows.Forms.CheckState.Checked;
            this._cbINPUT.Location = new System.Drawing.Point(259, 119);
            this._cbINPUT.Name = "_cbINPUT";
            this._cbINPUT.Size = new System.Drawing.Size(101, 17);
            this._cbINPUT.TabIndex = 7;
            this._cbINPUT.Text = "Przycisk INPUT";
            this._cbINPUT.UseVisualStyleBackColor = true;
            // 
            // _cbAUTO
            // 
            this._cbAUTO.AutoSize = true;
            this._cbAUTO.Checked = true;
            this._cbAUTO.CheckState = System.Windows.Forms.CheckState.Checked;
            this._cbAUTO.Location = new System.Drawing.Point(15, 119);
            this._cbAUTO.Name = "_cbAUTO";
            this._cbAUTO.Size = new System.Drawing.Size(104, 17);
            this._cbAUTO.TabIndex = 6;
            this._cbAUTO.Text = "Przycisku AUTO";
            this._cbAUTO.UseVisualStyleBackColor = true;
            // 
            // _cbMUTE
            // 
            this._cbMUTE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._cbMUTE.AutoSize = true;
            this._cbMUTE.Checked = true;
            this._cbMUTE.CheckState = System.Windows.Forms.CheckState.Checked;
            this._cbMUTE.Location = new System.Drawing.Point(259, 95);
            this._cbMUTE.Name = "_cbMUTE";
            this._cbMUTE.Size = new System.Drawing.Size(105, 17);
            this._cbMUTE.TabIndex = 5;
            this._cbMUTE.Text = "Przycisku MUTE";
            this._cbMUTE.UseVisualStyleBackColor = true;
            // 
            // _cbPOWER
            // 
            this._cbPOWER.AutoSize = true;
            this._cbPOWER.Checked = true;
            this._cbPOWER.CheckState = System.Windows.Forms.CheckState.Checked;
            this._cbPOWER.Location = new System.Drawing.Point(15, 95);
            this._cbPOWER.Name = "_cbPOWER";
            this._cbPOWER.Size = new System.Drawing.Size(115, 17);
            this._cbPOWER.TabIndex = 4;
            this._cbPOWER.Text = "Przycisku POWER";
            this._cbPOWER.UseVisualStyleBackColor = true;
            // 
            // _cSEPA
            // 
            this._cSEPA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._cSEPA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._cSEPA.Location = new System.Drawing.Point(15, 261);
            this._cSEPA.Name = "_cSEPA";
            this._cSEPA.Size = new System.Drawing.Size(401, 4);
            this._cSEPA.TabIndex = 3;
            this._cSEPA.TabStop = false;
            // 
            // _cSEP
            // 
            this._cSEP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._cSEP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._cSEP.Location = new System.Drawing.Point(15, 79);
            this._cSEP.Name = "_cSEP";
            this._cSEP.Size = new System.Drawing.Size(401, 4);
            this._cSEP.TabIndex = 3;
            this._cSEP.TabStop = false;
            // 
            // _cbSPEED
            // 
            this._cbSPEED.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._cbSPEED.AutoSize = true;
            this._cbSPEED.Checked = true;
            this._cbSPEED.CheckState = System.Windows.Forms.CheckState.Checked;
            this._cbSPEED.Location = new System.Drawing.Point(259, 53);
            this._cbSPEED.Name = "_cbSPEED";
            this._cbSPEED.Size = new System.Drawing.Size(103, 17);
            this._cbSPEED.TabIndex = 2;
            this._cbSPEED.Text = "Szybkość myszy";
            this._cbSPEED.UseVisualStyleBackColor = true;
            // 
            // _cbMYSZ
            // 
            this._cbMYSZ.AutoSize = true;
            this._cbMYSZ.Checked = true;
            this._cbMYSZ.CheckState = System.Windows.Forms.CheckState.Checked;
            this._cbMYSZ.Location = new System.Drawing.Point(15, 53);
            this._cbMYSZ.Name = "_cbMYSZ";
            this._cbMYSZ.Size = new System.Drawing.Size(97, 17);
            this._cbMYSZ.TabIndex = 1;
            this._cbMYSZ.Text = "Tryb pilot/mysz";
            this._cbMYSZ.UseVisualStyleBackColor = true;
            // 
            // _cbTRYB
            // 
            this._cbTRYB.AutoSize = true;
            this._cbTRYB.Checked = true;
            this._cbTRYB.CheckState = System.Windows.Forms.CheckState.Checked;
            this._cbTRYB.Location = new System.Drawing.Point(15, 29);
            this._cbTRYB.Name = "_cbTRYB";
            this._cbTRYB.Size = new System.Drawing.Size(132, 17);
            this._cbTRYB.TabIndex = 0;
            this._cbTRYB.Text = "Tryb NETFLIX / PLEX";
            this._cbTRYB.UseVisualStyleBackColor = true;
            // 
            // _cLabelKOL
            // 
            this._cLabelKOL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._cLabelKOL.AutoSize = true;
            this._cLabelKOL.Location = new System.Drawing.Point(12, 334);
            this._cLabelKOL.Name = "_cLabelKOL";
            this._cLabelKOL.Size = new System.Drawing.Size(57, 13);
            this._cLabelKOL.TabIndex = 2;
            this._cLabelKOL.Text = "Kolor OSD";
            // 
            // _cOSDCOLOR
            // 
            this._cOSDCOLOR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._cOSDCOLOR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cOSDCOLOR.FormattingEnabled = true;
            this._cOSDCOLOR.Items.AddRange(new object[] {
            "Biały",
            "Czarny",
            "Szary",
            "Niebieski",
            "Zółty",
            "Czerwony",
            "Zielony",
            "Fioletowy",
            "Błękitny"});
            this._cOSDCOLOR.Location = new System.Drawing.Point(75, 330);
            this._cOSDCOLOR.Name = "_cOSDCOLOR";
            this._cOSDCOLOR.Size = new System.Drawing.Size(227, 21);
            this._cOSDCOLOR.TabIndex = 3;
            this._cOSDCOLOR.SelectedValueChanged += new System.EventHandler(this._cOSDCOLOR_SelectedValueChanged);
            // 
            // _cCOLORPREV
            // 
            this._cCOLORPREV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._cCOLORPREV.Location = new System.Drawing.Point(320, 330);
            this._cCOLORPREV.Name = "_cCOLORPREV";
            this._cCOLORPREV.Size = new System.Drawing.Size(56, 21);
            this._cCOLORPREV.TabIndex = 4;
            this._cCOLORPREV.Click += new System.EventHandler(this._cCOLORPREV_Click);
            // 
            // _cmnuIKONKA
            // 
            this._cmnuIKONKA.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._cmnuzamknij});
            this._cmnuIKONKA.Name = "_cmnuIKONKA";
            this._cmnuIKONKA.Size = new System.Drawing.Size(118, 26);
            // 
            // _cmnuzamknij
            // 
            this._cmnuzamknij.Name = "_cmnuzamknij";
            this._cmnuzamknij.Size = new System.Drawing.Size(117, 22);
            this._cmnuzamknij.Text = "Zamknij";
            this._cmnuzamknij.Click += new System.EventHandler(this._cmnuzamknij_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 389);
            this.Controls.Add(this._cCOLORPREV);
            this.Controls.Add(this._cOSDCOLOR);
            this.Controls.Add(this._cLabelKOL);
            this.Controls.Add(this._cGRUPA);
            this.Controls.Add(this._cSTRIP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "ir Remote";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this._cSTRIP.ResumeLayout(false);
            this._cSTRIP.PerformLayout();
            this._cGRUPA.ResumeLayout(false);
            this._cGRUPA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._cSEPA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._cSEP)).EndInit();
            this._cmnuIKONKA.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip _cSTRIP;
        private System.Windows.Forms.ToolStripStatusLabel _cPORTLABEL;
        private System.Windows.Forms.ToolStripStatusLabel _cSerialPort;
        private System.Windows.Forms.GroupBox _cGRUPA;
        private System.Windows.Forms.PictureBox _cSEP;
        private System.Windows.Forms.CheckBox _cbSPEED;
        private System.Windows.Forms.CheckBox _cbMYSZ;
        private System.Windows.Forms.CheckBox _cbTRYB;
        private System.Windows.Forms.CheckBox _cbINPUT;
        private System.Windows.Forms.CheckBox _cbAUTO;
        private System.Windows.Forms.CheckBox _cbMUTE;
        private System.Windows.Forms.CheckBox _cbPOWER;
        private System.Windows.Forms.CheckBox _cbCHDW;
        private System.Windows.Forms.CheckBox _cbCHUP;
        private System.Windows.Forms.CheckBox _cbVOLDW;
        private System.Windows.Forms.CheckBox _cbVOLUP;
        private System.Windows.Forms.CheckBox _cbDOL;
        private System.Windows.Forms.CheckBox _cbGORA;
        private System.Windows.Forms.CheckBox _cbLEWO;
        private System.Windows.Forms.CheckBox _cbPRAWO;
        private System.Windows.Forms.CheckBox _cbBLUE;
        private System.Windows.Forms.CheckBox _cbYELLOW;
        private System.Windows.Forms.CheckBox _cbGREEN;
        private System.Windows.Forms.CheckBox _cbRED;
        private System.Windows.Forms.CheckBox _cbNUMERY;
        private System.Windows.Forms.CheckBox _cbEXIT;
        private System.Windows.Forms.PictureBox _cSEPA;
        private System.Windows.Forms.Label _cLabelKOL;
        private System.Windows.Forms.ComboBox _cOSDCOLOR;
        private System.Windows.Forms.Panel _cCOLORPREV;
        private System.Windows.Forms.ContextMenuStrip _cmnuIKONKA;
        private System.Windows.Forms.ToolStripMenuItem _cmnuzamknij;
    }
}

