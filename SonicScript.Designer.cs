namespace SonicScript
{
    partial class SonicScript
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SonicScript));
            this._selectColorTile1Btn = new Sulakore.Components.SKoreButton();
            this._statusLabel = new Sulakore.Components.SKoreLabel();
            this._selectSwitchBtn = new Sulakore.Components.SKoreButton();
            this._startStopBtn = new Sulakore.Components.SKoreButton();
            this._loadSaveBtn = new Sulakore.Components.SKoreButton();
            this._saveConfigBtn = new Sulakore.Components.SKoreButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this._configLabel = new System.Windows.Forms.Label();
            this._selectColorTile2Btn = new Sulakore.Components.SKoreButton();
            this.SuspendLayout();
            // 
            // _selectColorTile1Btn
            // 
            this._selectColorTile1Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this._selectColorTile1Btn.Location = new System.Drawing.Point(12, 219);
            this._selectColorTile1Btn.Name = "_selectColorTile1Btn";
            this._selectColorTile1Btn.Size = new System.Drawing.Size(114, 20);
            this._selectColorTile1Btn.TabIndex = 109;
            this._selectColorTile1Btn.Text = "Selecteer tegel1";
            this._selectColorTile1Btn.Click += new System.EventHandler(this._selectColorTileBtn_Click);
            // 
            // _statusLabel
            // 
            this._statusLabel.AnimationInterval = 0;
            this._statusLabel.DisplayBoundary = true;
            this._statusLabel.Location = new System.Drawing.Point(12, 245);
            this._statusLabel.Name = "_statusLabel";
            this._statusLabel.Size = new System.Drawing.Size(255, 20);
            this._statusLabel.TabIndex = 108;
            this._statusLabel.Text = "Standing By...";
            // 
            // _selectSwitchBtn
            // 
            this._selectSwitchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this._selectSwitchBtn.Location = new System.Drawing.Point(12, 193);
            this._selectSwitchBtn.Name = "_selectSwitchBtn";
            this._selectSwitchBtn.Size = new System.Drawing.Size(114, 20);
            this._selectSwitchBtn.TabIndex = 110;
            this._selectSwitchBtn.Text = "Selecteer hendel";
            this._selectSwitchBtn.Click += new System.EventHandler(this._selectSwitchBtn_Click);
            // 
            // _startStopBtn
            // 
            this._startStopBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this._startStopBtn.Location = new System.Drawing.Point(12, 153);
            this._startStopBtn.Name = "_startStopBtn";
            this._startStopBtn.Size = new System.Drawing.Size(114, 34);
            this._startStopBtn.TabIndex = 111;
            this._startStopBtn.Text = "Start/stop";
            this._startStopBtn.Click += new System.EventHandler(this._startStopBtn_Click);
            // 
            // _loadSaveBtn
            // 
            this._loadSaveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this._loadSaveBtn.Location = new System.Drawing.Point(183, 3);
            this._loadSaveBtn.Name = "_loadSaveBtn";
            this._loadSaveBtn.Size = new System.Drawing.Size(91, 21);
            this._loadSaveBtn.TabIndex = 112;
            this._loadSaveBtn.Text = "Laad";
            this._loadSaveBtn.Click += new System.EventHandler(this._loadSaveBtn_Click);
            // 
            // _saveConfigBtn
            // 
            this._saveConfigBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this._saveConfigBtn.Location = new System.Drawing.Point(183, 30);
            this._saveConfigBtn.Name = "_saveConfigBtn";
            this._saveConfigBtn.Size = new System.Drawing.Size(91, 21);
            this._saveConfigBtn.TabIndex = 113;
            this._saveConfigBtn.Text = "Opslaan";
            this._saveConfigBtn.Click += new System.EventHandler(this._saveConfigBtn_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // _configLabel
            // 
            this._configLabel.AutoSize = true;
            this._configLabel.Location = new System.Drawing.Point(9, 9);
            this._configLabel.Name = "_configLabel";
            this._configLabel.Size = new System.Drawing.Size(37, 13);
            this._configLabel.TabIndex = 116;
            this._configLabel.Text = "Status";
            // 
            // _selectColorTile2Btn
            // 
            this._selectColorTile2Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this._selectColorTile2Btn.Location = new System.Drawing.Point(132, 219);
            this._selectColorTile2Btn.Name = "_selectColorTile2Btn";
            this._selectColorTile2Btn.Size = new System.Drawing.Size(114, 20);
            this._selectColorTile2Btn.TabIndex = 117;
            this._selectColorTile2Btn.Text = "Selecteer tegel2";
            this._selectColorTile2Btn.Click += new System.EventHandler(this._selectColorTile2Btn_Click);
            // 
            // SonicScript
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(291, 286);
            this.Controls.Add(this._selectColorTile2Btn);
            this.Controls.Add(this._configLabel);
            this.Controls.Add(this._saveConfigBtn);
            this.Controls.Add(this._loadSaveBtn);
            this.Controls.Add(this._startStopBtn);
            this.Controls.Add(this._selectSwitchBtn);
            this.Controls.Add(this._selectColorTile1Btn);
            this.Controls.Add(this._statusLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SonicScript";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sonic game script";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal Sulakore.Components.SKoreButton _selectColorTile1Btn;
        internal Sulakore.Components.SKoreLabel _statusLabel;
        internal Sulakore.Components.SKoreButton _selectSwitchBtn;
        internal Sulakore.Components.SKoreButton _startStopBtn;
        internal Sulakore.Components.SKoreButton _loadSaveBtn;
        internal Sulakore.Components.SKoreButton _saveConfigBtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label _configLabel;
        internal Sulakore.Components.SKoreButton _selectColorTile2Btn;
    }
}

