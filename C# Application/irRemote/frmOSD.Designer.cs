namespace irRemote
{
    partial class frmOSD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOSD));
            this._cLOGO = new System.Windows.Forms.PictureBox();
            this._cTXT = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._cLOGO)).BeginInit();
            this.SuspendLayout();
            // 
            // _cLOGO
            // 
            this._cLOGO.BackColor = System.Drawing.Color.Transparent;
            this._cLOGO.Image = global::irRemote.Properties.Resources.Plex_Logo;
            this._cLOGO.Location = new System.Drawing.Point(12, 12);
            this._cLOGO.Name = "_cLOGO";
            this._cLOGO.Size = new System.Drawing.Size(85, 85);
            this._cLOGO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._cLOGO.TabIndex = 0;
            this._cLOGO.TabStop = false;
            // 
            // _cTXT
            // 
            this._cTXT.BackColor = System.Drawing.Color.Transparent;
            this._cTXT.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this._cTXT.ForeColor = System.Drawing.Color.White;
            this._cTXT.Location = new System.Drawing.Point(116, 12);
            this._cTXT.Name = "_cTXT";
            this._cTXT.Size = new System.Drawing.Size(249, 85);
            this._cTXT.TabIndex = 1;
            this._cTXT.Text = "msgmsg";
            this._cTXT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmOSD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(377, 113);
            this.Controls.Add(this._cTXT);
            this.Controls.Add(this._cLOGO);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOSD";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "OSD";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmOSD_FormClosed);
            this.Load += new System.EventHandler(this.frmOSD_Load);
            ((System.ComponentModel.ISupportInitialize)(this._cLOGO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox _cLOGO;
        private System.Windows.Forms.Label _cTXT;
    }
}