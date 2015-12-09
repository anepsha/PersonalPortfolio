namespace Anassign1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.InstructorName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.InstructorEmail = new System.Windows.Forms.TextBox();
            this.ShowPR_InstructorInfo = new System.Windows.Forms.Button();
            this.ShowET_InstructorInfo = new System.Windows.Forms.Button();
            this.ShowTI_InstructorInfo = new System.Windows.Forms.Button();
            this.ShowIG_InstructorInfo = new System.Windows.Forms.Button();
            this.ShowMath_InstructorInfo = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.LogoPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Instructor:";
            // 
            // InstructorName
            // 
            this.InstructorName.Enabled = false;
            this.InstructorName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructorName.Location = new System.Drawing.Point(12, 36);
            this.InstructorName.Name = "InstructorName";
            this.InstructorName.Size = new System.Drawing.Size(171, 26);
            this.InstructorName.TabIndex = 1;
            this.InstructorName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email Adress:";
            // 
            // InstructorEmail
            // 
            this.InstructorEmail.Enabled = false;
            this.InstructorEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructorEmail.ForeColor = System.Drawing.SystemColors.InfoText;
            this.InstructorEmail.Location = new System.Drawing.Point(12, 93);
            this.InstructorEmail.Name = "InstructorEmail";
            this.InstructorEmail.Size = new System.Drawing.Size(235, 26);
            this.InstructorEmail.TabIndex = 3;
            this.InstructorEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ShowPR_InstructorInfo
            // 
            this.ShowPR_InstructorInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowPR_InstructorInfo.Location = new System.Drawing.Point(319, 26);
            this.ShowPR_InstructorInfo.Name = "ShowPR_InstructorInfo";
            this.ShowPR_InstructorInfo.Size = new System.Drawing.Size(189, 28);
            this.ShowPR_InstructorInfo.TabIndex = 4;
            this.ShowPR_InstructorInfo.Text = "PR: Fundamentals";
            this.ShowPR_InstructorInfo.UseVisualStyleBackColor = true;
            this.ShowPR_InstructorInfo.Click += new System.EventHandler(this.ShowPR_InstructorInfo_Click);
            // 
            // ShowET_InstructorInfo
            // 
            this.ShowET_InstructorInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowET_InstructorInfo.Location = new System.Drawing.Point(319, 60);
            this.ShowET_InstructorInfo.Name = "ShowET_InstructorInfo";
            this.ShowET_InstructorInfo.Size = new System.Drawing.Size(189, 25);
            this.ShowET_InstructorInfo.TabIndex = 5;
            this.ShowET_InstructorInfo.Text = "ET Communications";
            this.ShowET_InstructorInfo.UseVisualStyleBackColor = true;
            this.ShowET_InstructorInfo.Click += new System.EventHandler(this.ShowET_InstructorInfo_Click);
            // 
            // ShowTI_InstructorInfo
            // 
            this.ShowTI_InstructorInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowTI_InstructorInfo.Location = new System.Drawing.Point(319, 91);
            this.ShowTI_InstructorInfo.Name = "ShowTI_InstructorInfo";
            this.ShowTI_InstructorInfo.Size = new System.Drawing.Size(189, 27);
            this.ShowTI_InstructorInfo.TabIndex = 6;
            this.ShowTI_InstructorInfo.Text = "TI: Fundamentals";
            this.ShowTI_InstructorInfo.UseVisualStyleBackColor = true;
            this.ShowTI_InstructorInfo.Click += new System.EventHandler(this.ShowTI_InstructorInfo_Click);
            // 
            // ShowIG_InstructorInfo
            // 
            this.ShowIG_InstructorInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowIG_InstructorInfo.Location = new System.Drawing.Point(319, 124);
            this.ShowIG_InstructorInfo.Name = "ShowIG_InstructorInfo";
            this.ShowIG_InstructorInfo.Size = new System.Drawing.Size(189, 27);
            this.ShowIG_InstructorInfo.TabIndex = 7;
            this.ShowIG_InstructorInfo.Text = "IG Dynamics";
            this.ShowIG_InstructorInfo.UseVisualStyleBackColor = true;
            this.ShowIG_InstructorInfo.Click += new System.EventHandler(this.ShowIG_InstructorInfo_Click);
            // 
            // ShowMath_InstructorInfo
            // 
            this.ShowMath_InstructorInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowMath_InstructorInfo.Location = new System.Drawing.Point(319, 157);
            this.ShowMath_InstructorInfo.Name = "ShowMath_InstructorInfo";
            this.ShowMath_InstructorInfo.Size = new System.Drawing.Size(189, 29);
            this.ShowMath_InstructorInfo.TabIndex = 8;
            this.ShowMath_InstructorInfo.Text = "Math for IT";
            this.ShowMath_InstructorInfo.UseVisualStyleBackColor = true;
            this.ShowMath_InstructorInfo.Click += new System.EventHandler(this.ShowMath_InstructorInfo_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(319, 220);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(189, 55);
            this.ExitButton.TabIndex = 9;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // LogoPicture
            // 
            this.LogoPicture.Image = global::Anassign1.Properties.Resources.logo;
            this.LogoPicture.Location = new System.Drawing.Point(12, 245);
            this.LogoPicture.Name = "LogoPicture";
            this.LogoPicture.Size = new System.Drawing.Size(152, 81);
            this.LogoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoPicture.TabIndex = 10;
            this.LogoPicture.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 338);
            this.Controls.Add(this.LogoPicture);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ShowMath_InstructorInfo);
            this.Controls.Add(this.ShowIG_InstructorInfo);
            this.Controls.Add(this.ShowTI_InstructorInfo);
            this.Controls.Add(this.ShowET_InstructorInfo);
            this.Controls.Add(this.ShowPR_InstructorInfo);
            this.Controls.Add(this.InstructorEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InstructorName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ITID Instructor Information";
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InstructorName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox InstructorEmail;
        private System.Windows.Forms.Button ShowPR_InstructorInfo;
        private System.Windows.Forms.Button ShowET_InstructorInfo;
        private System.Windows.Forms.Button ShowTI_InstructorInfo;
        private System.Windows.Forms.Button ShowIG_InstructorInfo;
        private System.Windows.Forms.Button ShowMath_InstructorInfo;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.PictureBox LogoPicture;
    }
}

