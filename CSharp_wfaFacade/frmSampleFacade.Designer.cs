namespace CSharp_wfaFacade
{
    partial class frmSampleFacade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSampleFacade));
            this.lstVision = new System.Windows.Forms.ListView();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.btnDrive = new System.Windows.Forms.Button();
            this.rbtRadioKiss = new System.Windows.Forms.RadioButton();
            this.lblTuneRadio = new System.Windows.Forms.Label();
            this.rbtRadioCulturaFM = new System.Windows.Forms.RadioButton();
            this.btnPark = new System.Windows.Forms.Button();
            this.rbtRadioCulturaAM = new System.Windows.Forms.RadioButton();
            this.rbtRadioAlpha = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lstVision
            // 
            this.lstVision.Location = new System.Drawing.Point(354, 15);
            this.lstVision.Name = "lstVision";
            this.lstVision.Size = new System.Drawing.Size(296, 291);
            this.lstVision.TabIndex = 0;
            this.lstVision.UseCompatibleStateImageBehavior = false;
            this.lstVision.View = System.Windows.Forms.View.Details;
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.Location = new System.Drawing.Point(12, 206);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(346, 100);
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = resources.GetString("lblSubTitle.Text");
            // 
            // btnDrive
            // 
            this.btnDrive.Location = new System.Drawing.Point(12, 12);
            this.btnDrive.Name = "btnDrive";
            this.btnDrive.Size = new System.Drawing.Size(105, 23);
            this.btnDrive.TabIndex = 2;
            this.btnDrive.Text = "&Drive - Dirigir";
            this.btnDrive.UseVisualStyleBackColor = true;
            this.btnDrive.Click += new System.EventHandler(this.btnDrive_Click);
            // 
            // rbtRadioKiss
            // 
            this.rbtRadioKiss.AutoSize = true;
            this.rbtRadioKiss.Checked = true;
            this.rbtRadioKiss.Location = new System.Drawing.Point(161, 66);
            this.rbtRadioKiss.Name = "rbtRadioKiss";
            this.rbtRadioKiss.Size = new System.Drawing.Size(158, 17);
            this.rbtRadioKiss.TabIndex = 3;
            this.rbtRadioKiss.TabStop = true;
            this.rbtRadioKiss.Tag = "102.1";
            this.rbtRadioKiss.Text = "102.1 - Kiss FM (True Rock)";
            this.rbtRadioKiss.UseVisualStyleBackColor = true;
            // 
            // lblTuneRadio
            // 
            this.lblTuneRadio.AutoSize = true;
            this.lblTuneRadio.Location = new System.Drawing.Point(158, 17);
            this.lblTuneRadio.Name = "lblTuneRadio";
            this.lblTuneRadio.Size = new System.Drawing.Size(66, 13);
            this.lblTuneRadio.TabIndex = 4;
            this.lblTuneRadio.Text = "Tune Radio:";
            // 
            // rbtRadioCulturaFM
            // 
            this.rbtRadioCulturaFM.AutoSize = true;
            this.rbtRadioCulturaFM.Location = new System.Drawing.Point(161, 89);
            this.rbtRadioCulturaFM.Name = "rbtRadioCulturaFM";
            this.rbtRadioCulturaFM.Size = new System.Drawing.Size(162, 17);
            this.rbtRadioCulturaFM.TabIndex = 5;
            this.rbtRadioCulturaFM.Tag = "103.3";
            this.rbtRadioCulturaFM.Text = "103.3 - Cultura FM (Classical)";
            this.rbtRadioCulturaFM.UseVisualStyleBackColor = true;
            // 
            // btnPark
            // 
            this.btnPark.Location = new System.Drawing.Point(12, 145);
            this.btnPark.Name = "btnPark";
            this.btnPark.Size = new System.Drawing.Size(105, 23);
            this.btnPark.TabIndex = 6;
            this.btnPark.Text = "&Park - Estacionar";
            this.btnPark.UseVisualStyleBackColor = true;
            this.btnPark.Click += new System.EventHandler(this.btnPark_Click);
            // 
            // rbtRadioCulturaAM
            // 
            this.rbtRadioCulturaAM.AutoSize = true;
            this.rbtRadioCulturaAM.Location = new System.Drawing.Point(161, 112);
            this.rbtRadioCulturaAM.Name = "rbtRadioCulturaAM";
            this.rbtRadioCulturaAM.Size = new System.Drawing.Size(138, 17);
            this.rbtRadioCulturaAM.TabIndex = 7;
            this.rbtRadioCulturaAM.Tag = "1200";
            this.rbtRadioCulturaAM.Text = "1200 - Cultura Brasil AM";
            this.rbtRadioCulturaAM.UseVisualStyleBackColor = true;
            // 
            // rbtRadioAlpha
            // 
            this.rbtRadioAlpha.AutoSize = true;
            this.rbtRadioAlpha.Location = new System.Drawing.Point(161, 43);
            this.rbtRadioAlpha.Name = "rbtRadioAlpha";
            this.rbtRadioAlpha.Size = new System.Drawing.Size(153, 17);
            this.rbtRadioAlpha.TabIndex = 8;
            this.rbtRadioAlpha.Tag = "101.7";
            this.rbtRadioAlpha.Text = "101.7 - Alpha FM (Ambient)";
            this.rbtRadioAlpha.UseVisualStyleBackColor = true;
            // 
            // frmSampleFacade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 315);
            this.Controls.Add(this.rbtRadioAlpha);
            this.Controls.Add(this.rbtRadioCulturaAM);
            this.Controls.Add(this.lstVision);
            this.Controls.Add(this.btnPark);
            this.Controls.Add(this.rbtRadioCulturaFM);
            this.Controls.Add(this.lblTuneRadio);
            this.Controls.Add(this.rbtRadioKiss);
            this.Controls.Add(this.btnDrive);
            this.Controls.Add(this.lblSubTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSampleFacade";
            this.ShowIcon = false;
            this.Text = "Sample of Facade (Exemplo de Fachada)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstVision;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Button btnDrive;
        private System.Windows.Forms.RadioButton rbtRadioKiss;
        private System.Windows.Forms.Label lblTuneRadio;
        private System.Windows.Forms.RadioButton rbtRadioCulturaFM;
        private System.Windows.Forms.Button btnPark;
        private System.Windows.Forms.RadioButton rbtRadioCulturaAM;
        private System.Windows.Forms.RadioButton rbtRadioAlpha;
    }
}

