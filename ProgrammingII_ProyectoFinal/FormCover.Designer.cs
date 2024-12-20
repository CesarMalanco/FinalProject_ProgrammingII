namespace WinFormsFinalProject
{
    partial class FormCover
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
            lblCover_Subject = new Label();
            lblCover_TeamMembers = new Label();
            lblCover_Teacher = new Label();
            lblCover_Date = new Label();
            btnContinue = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblCover_Subject
            // 
            lblCover_Subject.AutoSize = true;
            lblCover_Subject.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCover_Subject.Location = new Point(357, 85);
            lblCover_Subject.Name = "lblCover_Subject";
            lblCover_Subject.Size = new Size(137, 29);
            lblCover_Subject.TabIndex = 0;
            lblCover_Subject.Text = "Programación II";
            // 
            // lblCover_TeamMembers
            // 
            lblCover_TeamMembers.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCover_TeamMembers.Location = new Point(357, 215);
            lblCover_TeamMembers.Name = "lblCover_TeamMembers";
            lblCover_TeamMembers.Size = new Size(255, 204);
            lblCover_TeamMembers.TabIndex = 2;
            lblCover_TeamMembers.Text = "Integrantes:\nMariana Isabel Alvarado de la Huerta.\nDanna Cristina Castro Hernández.\nDarely Quezada Guerrero\nCelia Fernanda Vela Uribe.\nCésar Andrés Zuleta Malanco.";
            // 
            // lblCover_Teacher
            // 
            lblCover_Teacher.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCover_Teacher.Location = new Point(357, 176);
            lblCover_Teacher.Name = "lblCover_Teacher";
            lblCover_Teacher.Size = new Size(320, 39);
            lblCover_Teacher.TabIndex = 3;
            lblCover_Teacher.Text = "PROF: Dra. Georgina Salazar Partida";
            // 
            // lblCover_Date
            // 
            lblCover_Date.AutoSize = true;
            lblCover_Date.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCover_Date.Location = new Point(367, 453);
            lblCover_Date.Name = "lblCover_Date";
            lblCover_Date.Size = new Size(206, 29);
            lblCover_Date.TabIndex = 4;
            lblCover_Date.Text = "19 de Diciembre del 2024";
            // 
            // btnContinue
            // 
            btnContinue.Location = new Point(763, 512);
            btnContinue.Margin = new Padding(3, 4, 3, 4);
            btnContinue.Name = "btnContinue";
            btnContinue.RightToLeft = RightToLeft.No;
            btnContinue.Size = new Size(110, 45);
            btnContinue.TabIndex = 5;
            btnContinue.Text = "Continuar";
            btnContinue.UseVisualStyleBackColor = true;
            btnContinue.Click += btnContinue_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = WinFormsFinalProyect.Properties.Resources.LogoUAA;
            pictureBox1.Location = new Point(25, 16);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(185, 129);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(357, 114);
            label1.Name = "label1";
            label1.Size = new Size(320, 31);
            label1.TabIndex = 7;
            label1.Text = "Cine Sharp View";
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // FormCover
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnContinue);
            Controls.Add(lblCover_Date);
            Controls.Add(lblCover_Teacher);
            Controls.Add(lblCover_TeamMembers);
            Controls.Add(lblCover_Subject);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormCover";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Portada";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCover_Subject;
        private Label lblCover_TeamMembers;
        private Label lblCover_Teacher;
        private Label lblCover_Date;
        private Button btnContinue;
        private PictureBox pictureBox1;
        private Label label1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
    }
}