namespace FaceRecognition
{
    partial class MainForm
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
            this.btnStart = new System.Windows.Forms.Button();
            this.imgCamera = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddFace = new System.Windows.Forms.Button();
            this.txtNameTraining = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.picTraining = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbNumberPersons = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbNameOfPersons = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgCamera)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTraining)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(116, 356);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(90, 30);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // imgCamera
            // 
            this.imgCamera.Location = new System.Drawing.Point(12, 12);
            this.imgCamera.Name = "imgCamera";
            this.imgCamera.Size = new System.Drawing.Size(700, 560);
            this.imgCamera.TabIndex = 4;
            this.imgCamera.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddFace);
            this.groupBox1.Controls.Add(this.txtNameTraining);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.picTraining);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Location = new System.Drawing.Point(719, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 565);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Training";
            // 
            // btnAddFace
            // 
            this.btnAddFace.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnAddFace.Location = new System.Drawing.Point(181, 250);
            this.btnAddFace.Name = "btnAddFace";
            this.btnAddFace.Size = new System.Drawing.Size(92, 31);
            this.btnAddFace.TabIndex = 3;
            this.btnAddFace.Text = "Add face";
            this.btnAddFace.UseVisualStyleBackColor = true;
            this.btnAddFace.Click += new System.EventHandler(this.BtnAddFace_Click);
            // 
            // txtNameTraining
            // 
            this.txtNameTraining.Location = new System.Drawing.Point(70, 204);
            this.txtNameTraining.Name = "txtNameTraining";
            this.txtNameTraining.Size = new System.Drawing.Size(203, 26);
            this.txtNameTraining.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.Location = new System.Drawing.Point(6, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name :";
            // 
            // picTraining
            // 
            this.picTraining.Location = new System.Drawing.Point(70, 33);
            this.picTraining.Name = "picTraining";
            this.picTraining.Size = new System.Drawing.Size(150, 150);
            this.picTraining.TabIndex = 0;
            this.picTraining.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbNumberPersons);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lbNameOfPersons);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnStart);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox2.Location = new System.Drawing.Point(1004, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 565);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Results";
            // 
            // lbNumberPersons
            // 
            this.lbNumberPersons.AutoSize = true;
            this.lbNumberPersons.ForeColor = System.Drawing.Color.Red;
            this.lbNumberPersons.Location = new System.Drawing.Point(189, 164);
            this.lbNumberPersons.Name = "lbNumberPersons";
            this.lbNumberPersons.Size = new System.Drawing.Size(17, 19);
            this.lbNumberPersons.TabIndex = 7;
            this.lbNumberPersons.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Location = new System.Drawing.Point(6, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Số khuôn mặt phát hiện được :";
            // 
            // lbNameOfPersons
            // 
            this.lbNameOfPersons.AutoSize = true;
            this.lbNameOfPersons.Location = new System.Drawing.Point(15, 57);
            this.lbNameOfPersons.Name = "lbNameOfPersons";
            this.lbNameOfPersons.Size = new System.Drawing.Size(61, 19);
            this.lbNameOfPersons.TabIndex = 5;
            this.lbNameOfPersons.Text = "Nobody";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên người phát hiện được :";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 583);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.imgCamera);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imgCamera)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTraining)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox imgCamera;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picTraining;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbNumberPersons;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbNameOfPersons;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddFace;
        private System.Windows.Forms.TextBox txtNameTraining;
        private System.Windows.Forms.Label label3;
    }
}

