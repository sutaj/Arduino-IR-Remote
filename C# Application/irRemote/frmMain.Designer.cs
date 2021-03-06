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
            this._ctSEP = new System.Windows.Forms.ToolStripStatusLabel();
            this._cPortSettMnu = new System.Windows.Forms.ToolStripDropDownButton();
            this._cMnuSerialSTOP = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this._cMnuSerialSTART = new System.Windows.Forms.ToolStripMenuItem();
            this._cGITLink = new System.Windows.Forms.ToolStripStatusLabel();
            this._cGRUPA = new System.Windows.Forms.GroupBox();
            this._cpicTRYB = new System.Windows.Forms.PictureBox();
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
            this._cmnushow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this._cmnuzamknij = new System.Windows.Forms.ToolStripMenuItem();
            this._cbMINIMAL = new System.Windows.Forms.CheckBox();
            this._cPortSPEED = new System.Windows.Forms.ComboBox();
            this._cLanguage = new System.Windows.Forms.ComboBox();
            this._cLABELLang = new System.Windows.Forms.Label();
            this._cRECIVE = new System.Windows.Forms.PictureBox();
            this._cSTRIP.SuspendLayout();
            this._cGRUPA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._cpicTRYB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._cSEPA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._cSEP)).BeginInit();
            this._cmnuIKONKA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._cRECIVE)).BeginInit();
            this.SuspendLayout();
            // 
            // _cSTRIP
            // 
            this._cSTRIP.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._cPORTLABEL,
            this._cSerialPort,
            this._ctSEP,
            this._cPortSettMnu,
            this._cGITLink});
            this._cSTRIP.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this._cSTRIP.Location = new System.Drawing.Point(0, 426);
            this._cSTRIP.Name = "_cSTRIP";
            this._cSTRIP.Size = new System.Drawing.Size(462, 22);
            this._cSTRIP.TabIndex = 0;
            this._cSTRIP.Text = "statusStrip1";
            // 
            // _cPORTLABEL
            // 
            this._cPORTLABEL.Margin = new System.Windows.Forms.Padding(30, 3, 0, 2);
            this._cPORTLABEL.Name = "_cPORTLABEL";
            this._cPORTLABEL.Size = new System.Drawing.Size(70, 17);
            this._cPORTLABEL.Text = "Device port:";
            // 
            // _cSerialPort
            // 
            this._cSerialPort.Name = "_cSerialPort";
            this._cSerialPort.Size = new System.Drawing.Size(0, 17);
            // 
            // _ctSEP
            // 
            this._ctSEP.Enabled = false;
            this._ctSEP.Name = "_ctSEP";
            this._ctSEP.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this._ctSEP.Size = new System.Drawing.Size(36, 17);
            this._ctSEP.Text = " | ";
            // 
            // _cPortSettMnu
            // 
            this._cPortSettMnu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._cPortSettMnu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._cMnuSerialSTOP,
            this.toolStripSeparator2,
            this._cMnuSerialSTART});
            this._cPortSettMnu.Image = global::irRemote.Properties.Resources._Settings;
            this._cPortSettMnu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._cPortSettMnu.Name = "_cPortSettMnu";
            this._cPortSettMnu.Size = new System.Drawing.Size(29, 20);
            this._cPortSettMnu.Text = "toolStripDropDownButton1";
            this._cPortSettMnu.ToolTipText = "This options are litte buggy";
            // 
            // _cMnuSerialSTOP
            // 
            this._cMnuSerialSTOP.Name = "_cMnuSerialSTOP";
            this._cMnuSerialSTOP.Size = new System.Drawing.Size(194, 22);
            this._cMnuSerialSTOP.Text = "Stop Serial Connection";
            this._cMnuSerialSTOP.Click += new System.EventHandler(this._cMnuSerialSTOP_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(191, 6);
            // 
            // _cMnuSerialSTART
            // 
            this._cMnuSerialSTART.Name = "_cMnuSerialSTART";
            this._cMnuSerialSTART.Size = new System.Drawing.Size(194, 22);
            this._cMnuSerialSTART.Text = "Start Serial Connection";
            this._cMnuSerialSTART.Click += new System.EventHandler(this._cMnuSerialSTART_Click);
            // 
            // _cGITLink
            // 
            this._cGITLink.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._cGITLink.IsLink = true;
            this._cGITLink.Margin = new System.Windows.Forms.Padding(50, 3, 0, 2);
            this._cGITLink.Name = "_cGITLink";
            this._cGITLink.Size = new System.Drawing.Size(27, 17);
            this._cGITLink.Text = "Akil";
            this._cGITLink.Click += new System.EventHandler(this._cGITLink_Click);
            // 
            // _cGRUPA
            // 
            this._cGRUPA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._cGRUPA.Controls.Add(this._cpicTRYB);
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
            this._cGRUPA.Size = new System.Drawing.Size(438, 329);
            this._cGRUPA.TabIndex = 1;
            this._cGRUPA.TabStop = false;
            this._cGRUPA.Text = "Show events:";
            // 
            // _cpicTRYB
            // 
            this._cpicTRYB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._cpicTRYB.Location = new System.Drawing.Point(379, 20);
            this._cpicTRYB.Name = "_cpicTRYB";
            this._cpicTRYB.Size = new System.Drawing.Size(53, 50);
            this._cpicTRYB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._cpicTRYB.TabIndex = 22;
            this._cpicTRYB.TabStop = false;
            // 
            // _cbBLUE
            // 
            this._cbBLUE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._cbBLUE.Checked = true;
            this._cbBLUE.CheckState = System.Windows.Forms.CheckState.Checked;
            this._cbBLUE.Location = new System.Drawing.Point(334, 298);
            this._cbBLUE.Name = "_cbBLUE";
            this._cbBLUE.Size = new System.Drawing.Size(93, 17);
            this._cbBLUE.TabIndex = 21;
            this._cbBLUE.Text = "[BLUE]";
            this._cbBLUE.UseVisualStyleBackColor = true;
            // 
            // _cbYELLOW
            // 
            this._cbYELLOW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._cbYELLOW.Checked = true;
            this._cbYELLOW.CheckState = System.Windows.Forms.CheckState.Checked;
            this._cbYELLOW.Location = new System.Drawing.Point(221, 298);
            this._cbYELLOW.Name = "_cbYELLOW";
            this._cbYELLOW.Size = new System.Drawing.Size(77, 17);
            this._cbYELLOW.TabIndex = 20;
            this._cbYELLOW.Text = "[YELLOW]";
            this._cbYELLOW.UseVisualStyleBackColor = true;
            // 
            // _cbGREEN
            // 
            this._cbGREEN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._cbGREEN.AutoSize = true;
            this._cbGREEN.Checked = true;
            this._cbGREEN.CheckState = System.Windows.Forms.CheckState.Checked;
            this._cbGREEN.Location = new System.Drawing.Point(111, 298);
            this._cbGREEN.Name = "_cbGREEN";
            this._cbGREEN.Size = new System.Drawing.Size(70, 17);
            this._cbGREEN.TabIndex = 19;
            this._cbGREEN.Text = "[GREEN]";
            this._cbGREEN.UseVisualStyleBackColor = true;
            // 
            // _cbRED
            // 
            this._cbRED.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._cbRED.AutoSize = true;
            this._cbRED.Checked = true;
            this._cbRED.CheckState = System.Windows.Forms.CheckState.Checked;
            this._cbRED.Location = new System.Drawing.Point(15, 298);
            this._cbRED.Name = "_cbRED";
            this._cbRED.Size = new System.Drawing.Size(55, 17);
            this._cbRED.TabIndex = 18;
            this._cbRED.Text = "[RED]";
            this._cbRED.UseVisualStyleBackColor = true;
            // 
            // _cbNUMERY
            // 
            this._cbNUMERY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._cbNUMERY.Checked = true;
            this._cbNUMERY.CheckState = System.Windows.Forms.CheckState.Checked;
            this._cbNUMERY.Location = new System.Drawing.Point(259, 238);
            this._cbNUMERY.Name = "_cbNUMERY";
            this._cbNUMERY.Size = new System.Drawing.Size(114, 17);
            this._cbNUMERY.TabIndex = 17;
            this._cbNUMERY.Text = "Buttons [0-9]";
            this._cbNUMERY.UseVisualStyleBackColor = true;
            // 
            // _cbEXIT
            // 
            this._cbEXIT.AutoSize = true;
            this._cbEXIT.Checked = true;
            this._cbEXIT.CheckState = System.Windows.Forms.CheckState.Checked;
            this._cbEXIT.Location = new System.Drawing.Point(15, 238);
            this._cbEXIT.Name = "_cbEXIT";
            this._cbEXIT.Size = new System.Drawing.Size(90, 17);
            this._cbEXIT.TabIndex = 16;
            this._cbEXIT.Text = "Button [EXIT]";
            this._cbEXIT.UseVisualStyleBackColor = true;
            // 
            // _cbCHDW
            // 
            this._cbCHDW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._cbCHDW.Checked = true;
            this._cbCHDW.CheckState = System.Windows.Forms.CheckState.Checked;
            this._cbCHDW.Location = new System.Drawing.Point(259, 214);
            this._cbCHDW.Name = "_cbCHDW";
            this._cbCHDW.Size = new System.Drawing.Size(114, 17);
            this._cbCHDW.TabIndex = 15;
            this._cbCHDW.Text = "Button [CH-]";
            this._cbCHDW.UseVisualStyleBackColor = true;
            // 
            // _cbCHUP
            // 
            this._cbCHUP.AutoSize = true;
            this._cbCHUP.Checked = true;
            this._cbCHUP.CheckState = System.Windows.Forms.CheckState.Checked;
            this._cbCHUP.Location = new System.Drawing.Point(15, 214);
            this._cbCHUP.Name = "_cbCHUP";
            this._cbCHUP.Size = new System.Drawing.Size(87, 17);
            this._cbCHUP.TabIndex = 14;
            this._cbCHUP.Text = "Button [CH+]";
            this._cbCHUP.UseVisualStyleBackColor = true;
            // 
            // _cbVOLDW
            // 
            this._cbVOLDW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._cbVOLDW.Checked = true;
            this._cbVOLDW.CheckState = System.Windows.Forms.CheckState.Checked;
            this._cbVOLDW.Location = new System.Drawing.Point(259, 190);
            this._cbVOLDW.Name = "_cbVOLDW";
            this._cbVOLDW.Size = new System.Drawing.Size(114, 17);
            this._cbVOLDW.TabIndex = 13;
            this._cbVOLDW.Text = "Button [VOL-]";
            this._cbVOLDW.UseVisualStyleBackColor = true;
            // 
            // _cbVOLUP
            // 
            this._cbVOLUP.AutoSize = true;
            this._cbVOLUP.Checked = true;
            this._cbVOLUP.CheckState = System.Windows.Forms.CheckState.Checked;
            this._cbVOLUP.Location = new System.Drawing.Point(15, 190);
            this._cbVOLUP.Name = "_cbVOLUP";
            this._cbVOLUP.Size = new System.Drawing.Size(93, 17);
            this._cbVOLUP.TabIndex = 12;
            this._cbVOLUP.Text = "Button [VOL+]";
            this._cbVOLUP.UseVisualStyleBackColor = true;
            // 
            // _cbDOL
            // 
            this._cbDOL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._cbDOL.Checked = true;
            this._cbDOL.CheckState = System.Windows.Forms.CheckState.Checked;
            this._cbDOL.Location = new System.Drawing.Point(259, 167);
            this._cbDOL.Name = "_cbDOL";
            this._cbDOL.Size = new System.Drawing.Size(114, 17);
            this._cbDOL.TabIndex = 11;
            this._cbDOL.Text = "Button [DOWN]";
            this._cbDOL.UseVisualStyleBackColor = true;
            // 
            // _cbGORA
            // 
            this._cbGORA.AutoSize = true;
            this._cbGORA.Checked = true;
            this._cbGORA.CheckState = System.Windows.Forms.CheckState.Checked;
            this._cbGORA.Location = new System.Drawing.Point(15, 167);
            this._cbGORA.Name = "_cbGORA";
            this._cbGORA.Size = new System.Drawing.Size(81, 17);
            this._cbGORA.TabIndex = 10;
            this._cbGORA.Text = "Button [UP]";
            this._cbGORA.UseVisualStyleBackColor = true;
            // 
            // _cbLEWO
            // 
            this._cbLEWO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._cbLEWO.Checked = true;
            this._cbLEWO.CheckState = System.Windows.Forms.CheckState.Checked;
            this._cbLEWO.Location = new System.Drawing.Point(259, 143);
            this._cbLEWO.Name = "_cbLEWO";
            this._cbLEWO.Size = new System.Drawing.Size(114, 17);
            this._cbLEWO.TabIndex = 9;
            this._cbLEWO.Text = "Button [LEFT]";
            this._cbLEWO.UseVisualStyleBackColor = true;
            // 
            // _cbPRAWO
            // 
            this._cbPRAWO.AutoSize = true;
            this._cbPRAWO.Checked = true;
            this._cbPRAWO.CheckState = System.Windows.Forms.CheckState.Checked;
            this._cbPRAWO.Location = new System.Drawing.Point(15, 143);
            this._cbPRAWO.Name = "_cbPRAWO";
            this._cbPRAWO.Size = new System.Drawing.Size(100, 17);
            this._cbPRAWO.TabIndex = 8;
            this._cbPRAWO.Text = "Button [RIGHT]";
            this._cbPRAWO.UseVisualStyleBackColor = true;
            // 
            // _cbINPUT
            // 
            this._cbINPUT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._cbINPUT.Checked = true;
            this._cbINPUT.CheckState = System.Windows.Forms.CheckState.Checked;
            this._cbINPUT.Location = new System.Drawing.Point(259, 119);
            this._cbINPUT.Name = "_cbINPUT";
            this._cbINPUT.Size = new System.Drawing.Size(114, 17);
            this._cbINPUT.TabIndex = 7;
            this._cbINPUT.Text = "Button [IMPUT]";
            this._cbINPUT.UseVisualStyleBackColor = true;
            // 
            // _cbAUTO
            // 
            this._cbAUTO.AutoSize = true;
            this._cbAUTO.Checked = true;
            this._cbAUTO.CheckState = System.Windows.Forms.CheckState.Checked;
            this._cbAUTO.Location = new System.Drawing.Point(15, 119);
            this._cbAUTO.Name = "_cbAUTO";
            this._cbAUTO.Size = new System.Drawing.Size(96, 17);
            this._cbAUTO.TabIndex = 6;
            this._cbAUTO.Text = "Button [AUTO]";
            this._cbAUTO.UseVisualStyleBackColor = true;
            // 
            // _cbMUTE
            // 
            this._cbMUTE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._cbMUTE.Checked = true;
            this._cbMUTE.CheckState = System.Windows.Forms.CheckState.Checked;
            this._cbMUTE.Location = new System.Drawing.Point(259, 95);
            this._cbMUTE.Name = "_cbMUTE";
            this._cbMUTE.Size = new System.Drawing.Size(114, 17);
            this._cbMUTE.TabIndex = 5;
            this._cbMUTE.Text = "Button [MUTE]";
            this._cbMUTE.UseVisualStyleBackColor = true;
            // 
            // _cbPOWER
            // 
            this._cbPOWER.AutoSize = true;
            this._cbPOWER.Checked = true;
            this._cbPOWER.CheckState = System.Windows.Forms.CheckState.Checked;
            this._cbPOWER.Location = new System.Drawing.Point(15, 95);
            this._cbPOWER.Name = "_cbPOWER";
            this._cbPOWER.Size = new System.Drawing.Size(107, 17);
            this._cbPOWER.TabIndex = 4;
            this._cbPOWER.Text = "Button [POWER]";
            this._cbPOWER.UseVisualStyleBackColor = true;
            // 
            // _cSEPA
            // 
            this._cSEPA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._cSEPA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._cSEPA.Location = new System.Drawing.Point(15, 267);
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
            this._cbSPEED.Checked = true;
            this._cbSPEED.CheckState = System.Windows.Forms.CheckState.Checked;
            this._cbSPEED.Location = new System.Drawing.Point(259, 53);
            this._cbSPEED.Name = "_cbSPEED";
            this._cbSPEED.Size = new System.Drawing.Size(114, 17);
            this._cbSPEED.TabIndex = 2;
            this._cbSPEED.Text = "Mouse speed";
            this._cbSPEED.UseVisualStyleBackColor = true;
            // 
            // _cbMYSZ
            // 
            this._cbMYSZ.AutoSize = true;
            this._cbMYSZ.Checked = true;
            this._cbMYSZ.CheckState = System.Windows.Forms.CheckState.Checked;
            this._cbMYSZ.Location = new System.Drawing.Point(15, 53);
            this._cbMYSZ.Name = "_cbMYSZ";
            this._cbMYSZ.Size = new System.Drawing.Size(106, 17);
            this._cbMYSZ.TabIndex = 1;
            this._cbMYSZ.Text = "Remote / Mouse";
            this._cbMYSZ.UseVisualStyleBackColor = true;
            // 
            // _cbTRYB
            // 
            this._cbTRYB.AutoSize = true;
            this._cbTRYB.Checked = true;
            this._cbTRYB.CheckState = System.Windows.Forms.CheckState.Checked;
            this._cbTRYB.Cursor = System.Windows.Forms.Cursors.Default;
            this._cbTRYB.Location = new System.Drawing.Point(15, 29);
            this._cbTRYB.Name = "_cbTRYB";
            this._cbTRYB.Size = new System.Drawing.Size(138, 17);
            this._cbTRYB.TabIndex = 0;
            this._cbTRYB.Text = "Mode NETFLIX / PLEX";
            this._cbTRYB.UseVisualStyleBackColor = true;
            // 
            // _cLabelKOL
            // 
            this._cLabelKOL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._cLabelKOL.AutoSize = true;
            this._cLabelKOL.Location = new System.Drawing.Point(12, 394);
            this._cLabelKOL.Name = "_cLabelKOL";
            this._cLabelKOL.Size = new System.Drawing.Size(56, 13);
            this._cLabelKOL.TabIndex = 2;
            this._cLabelKOL.Text = "OSD color";
            // 
            // _cOSDCOLOR
            // 
            this._cOSDCOLOR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._cOSDCOLOR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cOSDCOLOR.FormattingEnabled = true;
            this._cOSDCOLOR.Items.AddRange(new object[] {
            "White",
            "Black",
            "Grey",
            "Blue",
            "Yellow",
            "Red",
            "Green",
            "Purple",
            "Azure"});
            this._cOSDCOLOR.Location = new System.Drawing.Point(75, 390);
            this._cOSDCOLOR.Name = "_cOSDCOLOR";
            this._cOSDCOLOR.Size = new System.Drawing.Size(227, 21);
            this._cOSDCOLOR.TabIndex = 3;
            this._cOSDCOLOR.SelectedValueChanged += new System.EventHandler(this._cOSDCOLOR_SelectedValueChanged);
            // 
            // _cCOLORPREV
            // 
            this._cCOLORPREV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._cCOLORPREV.Location = new System.Drawing.Point(320, 390);
            this._cCOLORPREV.Name = "_cCOLORPREV";
            this._cCOLORPREV.Size = new System.Drawing.Size(56, 21);
            this._cCOLORPREV.TabIndex = 4;
            this._cCOLORPREV.Click += new System.EventHandler(this._cCOLORPREV_Click);
            // 
            // _cmnuIKONKA
            // 
            this._cmnuIKONKA.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._cmnushow,
            this.toolStripSeparator1,
            this._cmnuzamknij});
            this._cmnuIKONKA.Name = "_cmnuIKONKA";
            this._cmnuIKONKA.Size = new System.Drawing.Size(157, 54);
            // 
            // _cmnushow
            // 
            this._cmnushow.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this._cmnushow.Name = "_cmnushow";
            this._cmnushow.Size = new System.Drawing.Size(156, 22);
            this._cmnushow.Text = "Show program";
            this._cmnushow.Click += new System.EventHandler(this._cmnushow_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(153, 6);
            // 
            // _cmnuzamknij
            // 
            this._cmnuzamknij.Name = "_cmnuzamknij";
            this._cmnuzamknij.Size = new System.Drawing.Size(156, 22);
            this._cmnuzamknij.Text = "Exit";
            this._cmnuzamknij.Click += new System.EventHandler(this._cmnuzamknij_Click);
            // 
            // _cbMINIMAL
            // 
            this._cbMINIMAL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._cbMINIMAL.Location = new System.Drawing.Point(301, 351);
            this._cbMINIMAL.Name = "_cbMINIMAL";
            this._cbMINIMAL.Size = new System.Drawing.Size(149, 24);
            this._cbMINIMAL.TabIndex = 5;
            this._cbMINIMAL.Text = "Start minimalized";
            this._cbMINIMAL.UseVisualStyleBackColor = true;
            this._cbMINIMAL.CheckedChanged += new System.EventHandler(this._cbMINIMAL_CheckedChanged);
            // 
            // _cPortSPEED
            // 
            this._cPortSPEED.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._cPortSPEED.FormattingEnabled = true;
            this._cPortSPEED.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "115200"});
            this._cPortSPEED.Location = new System.Drawing.Point(338, 427);
            this._cPortSPEED.Name = "_cPortSPEED";
            this._cPortSPEED.Size = new System.Drawing.Size(98, 21);
            this._cPortSPEED.TabIndex = 6;
            this._cPortSPEED.SelectedIndexChanged += new System.EventHandler(this._cPortSPEED_SelectedIndexChanged);
            // 
            // _cLanguage
            // 
            this._cLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._cLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cLanguage.FormattingEnabled = true;
            this._cLanguage.Items.AddRange(new object[] {
            "Polish",
            "English"});
            this._cLanguage.Location = new System.Drawing.Point(99, 353);
            this._cLanguage.Name = "_cLanguage";
            this._cLanguage.Size = new System.Drawing.Size(143, 21);
            this._cLanguage.TabIndex = 7;
            this._cLanguage.SelectedValueChanged += new System.EventHandler(this._cLanguage_SelectedValueChanged);
            // 
            // _cLABELLang
            // 
            this._cLABELLang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._cLABELLang.AutoSize = true;
            this._cLABELLang.Location = new System.Drawing.Point(13, 356);
            this._cLABELLang.Name = "_cLABELLang";
            this._cLABELLang.Size = new System.Drawing.Size(55, 13);
            this._cLABELLang.TabIndex = 8;
            this._cLABELLang.Text = "Language";
            // 
            // _cRECIVE
            // 
            this._cRECIVE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._cRECIVE.Location = new System.Drawing.Point(5, 431);
            this._cRECIVE.Name = "_cRECIVE";
            this._cRECIVE.Size = new System.Drawing.Size(12, 12);
            this._cRECIVE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._cRECIVE.TabIndex = 9;
            this._cRECIVE.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 448);
            this.Controls.Add(this._cRECIVE);
            this.Controls.Add(this._cLABELLang);
            this.Controls.Add(this._cLanguage);
            this.Controls.Add(this._cPortSPEED);
            this.Controls.Add(this._cbMINIMAL);
            this.Controls.Add(this._cCOLORPREV);
            this.Controls.Add(this._cOSDCOLOR);
            this.Controls.Add(this._cLabelKOL);
            this.Controls.Add(this._cGRUPA);
            this.Controls.Add(this._cSTRIP);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Netflix/Plex IR Remote";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this._cSTRIP.ResumeLayout(false);
            this._cSTRIP.PerformLayout();
            this._cGRUPA.ResumeLayout(false);
            this._cGRUPA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._cpicTRYB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._cSEPA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._cSEP)).EndInit();
            this._cmnuIKONKA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._cRECIVE)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem _cmnushow;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.PictureBox _cpicTRYB;
        private System.Windows.Forms.CheckBox _cbMINIMAL;
        private System.Windows.Forms.ComboBox _cPortSPEED;
        private System.Windows.Forms.ToolStripStatusLabel _ctSEP;
        private System.Windows.Forms.ToolStripDropDownButton _cPortSettMnu;
        private System.Windows.Forms.ToolStripMenuItem _cMnuSerialSTOP;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem _cMnuSerialSTART;
        private System.Windows.Forms.ComboBox _cLanguage;
        private System.Windows.Forms.Label _cLABELLang;
        private System.Windows.Forms.ToolStripStatusLabel _cGITLink;
        private System.Windows.Forms.PictureBox _cRECIVE;
    }
}

