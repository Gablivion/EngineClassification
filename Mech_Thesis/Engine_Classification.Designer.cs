namespace Mech_Thesis
{
    partial class Engine_Classification
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblpe = new System.Windows.Forms.LinkLabel();
            this.lbltc = new System.Windows.Forms.LinkLabel();
            this.lbti = new System.Windows.Forms.LinkLabel();
            this.lblec = new System.Windows.Forms.LinkLabel();
            this.lblfu = new System.Windows.Forms.LinkLabel();
            this.lblvl = new System.Windows.Forms.LinkLabel();
            this.lblmi = new System.Windows.Forms.LinkLabel();
            this.lblbd = new System.Windows.Forms.LinkLabel();
            this.lblap = new System.Windows.Forms.LinkLabel();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.dtgvti = new System.Windows.Forms.DataGridView();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExit.Location = new System.Drawing.Point(985, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(51, 43);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblpe
            // 
            this.lblpe.AutoSize = true;
            this.lblpe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblpe.LinkColor = System.Drawing.Color.AliceBlue;
            this.lblpe.Location = new System.Drawing.Point(12, 317);
            this.lblpe.Name = "lblpe";
            this.lblpe.Size = new System.Drawing.Size(282, 22);
            this.lblpe.TabIndex = 20;
            this.lblpe.TabStop = true;
            this.lblpe.Text = "Position and Number of Cylinders \r\n";
            this.lblpe.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblpe_LinkClicked);
            // 
            // lbltc
            // 
            this.lbltc.AutoSize = true;
            this.lbltc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lbltc.LinkColor = System.Drawing.Color.AliceBlue;
            this.lbltc.Location = new System.Drawing.Point(13, 500);
            this.lbltc.Name = "lbltc";
            this.lbltc.Size = new System.Drawing.Size(163, 25);
            this.lbltc.TabIndex = 19;
            this.lbltc.TabStop = true;
            this.lbltc.Text = "Type of Cooling";
            this.lbltc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbltc_LinkClicked);
            // 
            // lbti
            // 
            this.lbti.AutoSize = true;
            this.lbti.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lbti.LinkColor = System.Drawing.Color.AliceBlue;
            this.lbti.Location = new System.Drawing.Point(12, 165);
            this.lbti.Name = "lbti";
            this.lbti.Size = new System.Drawing.Size(170, 25);
            this.lbti.TabIndex = 10;
            this.lbti.TabStop = true;
            this.lbti.Text = "Types of Ignition";
            this.lbti.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbti_LinkClicked);
            // 
            // lblec
            // 
            this.lblec.AutoSize = true;
            this.lblec.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblec.LinkColor = System.Drawing.Color.AliceBlue;
            this.lblec.Location = new System.Drawing.Point(12, 201);
            this.lblec.Name = "lblec";
            this.lblec.Size = new System.Drawing.Size(139, 25);
            this.lblec.TabIndex = 11;
            this.lblec.TabStop = true;
            this.lblec.Text = "Engine Cycle";
            this.lblec.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblec_LinkClicked);
            // 
            // lblfu
            // 
            this.lblfu.AutoSize = true;
            this.lblfu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblfu.LinkColor = System.Drawing.Color.AliceBlue;
            this.lblfu.Location = new System.Drawing.Point(13, 459);
            this.lblfu.Name = "lblfu";
            this.lblfu.Size = new System.Drawing.Size(231, 25);
            this.lblfu.TabIndex = 17;
            this.lblfu.TabStop = true;
            this.lblfu.Text = "Fuel Used (SI engines)";
            this.lblfu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblfu_LinkClicked);
            // 
            // lblvl
            // 
            this.lblvl.AutoSize = true;
            this.lblvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblvl.LinkColor = System.Drawing.Color.AliceBlue;
            this.lblvl.Location = new System.Drawing.Point(13, 237);
            this.lblvl.Name = "lblvl";
            this.lblvl.Size = new System.Drawing.Size(154, 25);
            this.lblvl.TabIndex = 12;
            this.lblvl.TabStop = true;
            this.lblvl.Text = "Valve Location";
            this.lblvl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblvl_LinkClicked);
            // 
            // lblmi
            // 
            this.lblmi.AutoSize = true;
            this.lblmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblmi.LinkColor = System.Drawing.Color.AliceBlue;
            this.lblmi.Location = new System.Drawing.Point(13, 421);
            this.lblmi.Name = "lblmi";
            this.lblmi.Size = new System.Drawing.Size(332, 25);
            this.lblmi.TabIndex = 16;
            this.lblmi.TabStop = true;
            this.lblmi.Text = "Method of Fuel Input (SI Engines)";
            this.lblmi.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblmi_LinkClicked);
            // 
            // lblbd
            // 
            this.lblbd.AutoSize = true;
            this.lblbd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblbd.LinkColor = System.Drawing.Color.AliceBlue;
            this.lblbd.Location = new System.Drawing.Point(13, 275);
            this.lblbd.Name = "lblbd";
            this.lblbd.Size = new System.Drawing.Size(138, 25);
            this.lblbd.TabIndex = 13;
            this.lblbd.TabStop = true;
            this.lblbd.Text = "Basic Design";
            this.lblbd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblbd_LinkClicked);
            // 
            // lblap
            // 
            this.lblap.AutoSize = true;
            this.lblap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblap.LinkColor = System.Drawing.Color.AliceBlue;
            this.lblap.Location = new System.Drawing.Point(12, 382);
            this.lblap.Name = "lblap";
            this.lblap.Size = new System.Drawing.Size(186, 25);
            this.lblap.TabIndex = 15;
            this.lblap.TabStop = true;
            this.lblap.Text = "Air Intake Process";
            this.lblap.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblap_LinkClicked);
            // 
            // linkLabel5
            // 
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.linkLabel5.LinkColor = System.Drawing.Color.AliceBlue;
            this.linkLabel5.Location = new System.Drawing.Point(13, 342);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(310, 22);
            this.linkLabel5.TabIndex = 14;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "of Cylinders of Reciprocating Engines";
            this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);
            // 
            // txtdesc
            // 
            this.txtdesc.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtdesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdesc.ForeColor = System.Drawing.SystemColors.Window;
            this.txtdesc.Location = new System.Drawing.Point(491, 367);
            this.txtdesc.Multiline = true;
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(477, 309);
            this.txtdesc.TabIndex = 32;
            // 
            // dtgvti
            // 
            this.dtgvti.AllowUserToAddRows = false;
            this.dtgvti.AllowUserToDeleteRows = false;
            this.dtgvti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvti.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtgvti.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvti.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvti.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvti.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvti.Location = new System.Drawing.Point(507, 152);
            this.dtgvti.Name = "dtgvti";
            this.dtgvti.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvti.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvti.RowHeadersVisible = false;
            this.dtgvti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvti.Size = new System.Drawing.Size(461, 116);
            this.dtgvti.TabIndex = 31;
            this.dtgvti.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvti_CellClick);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Adobe Devanagari", 15.75F);
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(27, 648);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(206, 28);
            this.linkLabel1.TabIndex = 55;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Back to Engine Materials";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Mech_Thesis.Properties.Resources.G9SO;
            this.pictureBox4.Location = new System.Drawing.Point(41, 548);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(141, 97);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 53;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Mech_Thesis.Properties.Resources.TOPPED;
            this.pictureBox3.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1117, 146);
            this.pictureBox3.TabIndex = 51;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Mech_Thesis.Properties.Resources._153592070_612x612;
            this.pictureBox1.Location = new System.Drawing.Point(421, 191);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(720, 630);
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // Engine_Classification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1038, 701);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.txtdesc);
            this.Controls.Add(this.lblpe);
            this.Controls.Add(this.dtgvti);
            this.Controls.Add(this.lbltc);
            this.Controls.Add(this.lbti);
            this.Controls.Add(this.lblec);
            this.Controls.Add(this.lblfu);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblvl);
            this.Controls.Add(this.linkLabel5);
            this.Controls.Add(this.lblmi);
            this.Controls.Add(this.lblap);
            this.Controls.Add(this.lblbd);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Engine_Classification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Engine_Classification";
            this.Load += new System.EventHandler(this.Engine_Classification_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Engine_Classification_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Engine_Classification_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Engine_Classification_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.LinkLabel lbti;
        private System.Windows.Forms.LinkLabel lblpe;
        private System.Windows.Forms.LinkLabel lbltc;
        private System.Windows.Forms.LinkLabel lblec;
        private System.Windows.Forms.LinkLabel lblfu;
        private System.Windows.Forms.LinkLabel lblvl;
        private System.Windows.Forms.LinkLabel lblmi;
        private System.Windows.Forms.LinkLabel lblbd;
        private System.Windows.Forms.LinkLabel lblap;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.TextBox txtdesc;
        private System.Windows.Forms.DataGridView dtgvti;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}