
namespace CS_Luffarschack
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_NewGame = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblPlayerO = new System.Windows.Forms.Label();
            this.PlayerO = new System.Windows.Forms.Label();
            this.lblPlayerX = new System.Windows.Forms.Label();
            this.PlayerX = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Title);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1344, 110);
            this.panel1.TabIndex = 0;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.Black;
            this.Title.Location = new System.Drawing.Point(6, 6);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(502, 91);
            this.Title.TabIndex = 0;
            this.Title.Text = "Luffarschack";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(12, 128);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1344, 577);
            this.panel2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Location = new System.Drawing.Point(673, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(664, 567);
            this.panel4.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.btn_Exit);
            this.panel7.Controls.Add(this.btn_Reset);
            this.panel7.Controls.Add(this.btn_NewGame);
            this.panel7.Location = new System.Drawing.Point(3, 276);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(654, 284);
            this.panel7.TabIndex = 0;
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(325, 141);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(322, 136);
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.Location = new System.Drawing.Point(3, 141);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(322, 136);
            this.btn_Reset.TabIndex = 1;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_NewGame
            // 
            this.btn_NewGame.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_NewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NewGame.Location = new System.Drawing.Point(3, 3);
            this.btn_NewGame.Name = "btn_NewGame";
            this.btn_NewGame.Size = new System.Drawing.Size(644, 137);
            this.btn_NewGame.TabIndex = 1;
            this.btn_NewGame.Text = "New Game";
            this.btn_NewGame.UseVisualStyleBackColor = false;
            this.btn_NewGame.Click += new System.EventHandler(this.btn_NewGame_Click);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.lblPlayerO);
            this.panel6.Controls.Add(this.PlayerO);
            this.panel6.Controls.Add(this.lblPlayerX);
            this.panel6.Controls.Add(this.PlayerX);
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(654, 267);
            this.panel6.TabIndex = 0;
            // 
            // lblPlayerO
            // 
            this.lblPlayerO.BackColor = System.Drawing.Color.White;
            this.lblPlayerO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPlayerO.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerO.Location = new System.Drawing.Point(338, 149);
            this.lblPlayerO.Name = "lblPlayerO";
            this.lblPlayerO.Size = new System.Drawing.Size(304, 78);
            this.lblPlayerO.TabIndex = 0;
            this.lblPlayerO.Text = "0";
            this.lblPlayerO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayerO
            // 
            this.PlayerO.AutoSize = true;
            this.PlayerO.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerO.Location = new System.Drawing.Point(3, 149);
            this.PlayerO.Name = "PlayerO";
            this.PlayerO.Size = new System.Drawing.Size(324, 78);
            this.PlayerO.TabIndex = 0;
            this.PlayerO.Text = "Player O:";
            // 
            // lblPlayerX
            // 
            this.lblPlayerX.BackColor = System.Drawing.Color.White;
            this.lblPlayerX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPlayerX.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerX.Location = new System.Drawing.Point(338, 36);
            this.lblPlayerX.Name = "lblPlayerX";
            this.lblPlayerX.Size = new System.Drawing.Size(304, 78);
            this.lblPlayerX.TabIndex = 0;
            this.lblPlayerX.Text = "0";
            this.lblPlayerX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayerX
            // 
            this.PlayerX.AutoSize = true;
            this.PlayerX.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerX.Location = new System.Drawing.Point(9, 36);
            this.PlayerX.Name = "PlayerX";
            this.PlayerX.Size = new System.Drawing.Size(316, 78);
            this.PlayerX.TabIndex = 0;
            this.PlayerX.Text = "Player X:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btn_9);
            this.panel3.Controls.Add(this.btn_6);
            this.panel3.Controls.Add(this.btn_3);
            this.panel3.Controls.Add(this.btn_8);
            this.panel3.Controls.Add(this.btn_7);
            this.panel3.Controls.Add(this.btn_5);
            this.panel3.Controls.Add(this.btn_4);
            this.panel3.Controls.Add(this.btn_2);
            this.panel3.Controls.Add(this.btn_1);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(664, 567);
            this.panel3.TabIndex = 0;
            // 
            // btn_9
            // 
            this.btn_9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 94.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_9.Location = new System.Drawing.Point(429, 354);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(200, 158);
            this.btn_9.TabIndex = 1;
            this.btn_9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_9.UseVisualStyleBackColor = false;
            this.btn_9.Click += new System.EventHandler(this.btn_9_Click);
            // 
            // btn_6
            // 
            this.btn_6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 94.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_6.Location = new System.Drawing.Point(429, 190);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(200, 158);
            this.btn_6.TabIndex = 1;
            this.btn_6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_6.UseVisualStyleBackColor = false;
            this.btn_6.Click += new System.EventHandler(this.btn_6_Click);
            // 
            // btn_3
            // 
            this.btn_3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 94.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_3.Location = new System.Drawing.Point(429, 26);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(200, 158);
            this.btn_3.TabIndex = 1;
            this.btn_3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_3.UseVisualStyleBackColor = false;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // btn_8
            // 
            this.btn_8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 94.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_8.Location = new System.Drawing.Point(223, 354);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(200, 158);
            this.btn_8.TabIndex = 1;
            this.btn_8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_8.UseVisualStyleBackColor = false;
            this.btn_8.Click += new System.EventHandler(this.btn_8_Click);
            // 
            // btn_7
            // 
            this.btn_7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 94.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_7.Location = new System.Drawing.Point(17, 354);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(200, 158);
            this.btn_7.TabIndex = 1;
            this.btn_7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_7.UseVisualStyleBackColor = false;
            this.btn_7.Click += new System.EventHandler(this.btn_7_Click);
            // 
            // btn_5
            // 
            this.btn_5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 94.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_5.Location = new System.Drawing.Point(223, 190);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(200, 158);
            this.btn_5.TabIndex = 1;
            this.btn_5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_5.UseVisualStyleBackColor = false;
            this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
            // 
            // btn_4
            // 
            this.btn_4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 94.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_4.Location = new System.Drawing.Point(17, 190);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(200, 158);
            this.btn_4.TabIndex = 1;
            this.btn_4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_4.UseVisualStyleBackColor = false;
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // btn_2
            // 
            this.btn_2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 94.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_2.Location = new System.Drawing.Point(223, 26);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(200, 158);
            this.btn_2.TabIndex = 1;
            this.btn_2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_2.UseVisualStyleBackColor = false;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_1
            // 
            this.btn_1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 94.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1.Location = new System.Drawing.Point(17, 26);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(200, 158);
            this.btn_1.TabIndex = 1;
            this.btn_1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_1.UseVisualStyleBackColor = false;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Location = new System.Drawing.Point(835, 39);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(698, 110);
            this.panel5.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1368, 741);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Luffarschack";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_NewGame;
        private System.Windows.Forms.Label lblPlayerO;
        private System.Windows.Forms.Label PlayerO;
        private System.Windows.Forms.Label lblPlayerX;
        private System.Windows.Forms.Label PlayerX;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_2;
    }
}

