namespace Baseball
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
            this.btnSim = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtTeam1 = new System.Windows.Forms.TextBox();
            this.txtTeam2 = new System.Windows.Forms.TextBox();
            this.lblEnterTeam1 = new System.Windows.Forms.Label();
            this.lblEnterTeam2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTeam2ScoreFinal = new System.Windows.Forms.Label();
            this.lblTeam2Score9 = new System.Windows.Forms.Label();
            this.lblTeam2Score8 = new System.Windows.Forms.Label();
            this.lblTeam2Score7 = new System.Windows.Forms.Label();
            this.lblTeam2Score6 = new System.Windows.Forms.Label();
            this.lblTeam2Score5 = new System.Windows.Forms.Label();
            this.lblTeam2Score4 = new System.Windows.Forms.Label();
            this.lblTeam2Score3 = new System.Windows.Forms.Label();
            this.lblTeam2Score2 = new System.Windows.Forms.Label();
            this.lblTeam2Score1 = new System.Windows.Forms.Label();
            this.lblTeam2 = new System.Windows.Forms.Label();
            this.lblTeam1ScoreFinal = new System.Windows.Forms.Label();
            this.lblTeam1Score9 = new System.Windows.Forms.Label();
            this.lblTeam1Score8 = new System.Windows.Forms.Label();
            this.lblTeam1Score7 = new System.Windows.Forms.Label();
            this.lblTeam1Score6 = new System.Windows.Forms.Label();
            this.lblTeam1Score5 = new System.Windows.Forms.Label();
            this.lblTeam1Score4 = new System.Windows.Forms.Label();
            this.lblTeam1Score3 = new System.Windows.Forms.Label();
            this.lblTeam1Score2 = new System.Windows.Forms.Label();
            this.lblTeam1Score1 = new System.Windows.Forms.Label();
            this.lblTeam1 = new System.Windows.Forms.Label();
            this.lblFinal = new System.Windows.Forms.Label();
            this.lblNinth = new System.Windows.Forms.Label();
            this.lblEighth = new System.Windows.Forms.Label();
            this.lblSeventh = new System.Windows.Forms.Label();
            this.lblSixth = new System.Windows.Forms.Label();
            this.lblFifth = new System.Windows.Forms.Label();
            this.lblThird = new System.Windows.Forms.Label();
            this.lblSecond = new System.Windows.Forms.Label();
            this.lblFirst = new System.Windows.Forms.Label();
            this.lblFourth = new System.Windows.Forms.Label();
            this.lblTeam = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSim
            // 
            this.btnSim.Location = new System.Drawing.Point(390, 179);
            this.btnSim.Name = "btnSim";
            this.btnSim.Size = new System.Drawing.Size(98, 58);
            this.btnSim.TabIndex = 1;
            this.btnSim.Text = "Play Ball!";
            this.btnSim.UseVisualStyleBackColor = true;
            this.btnSim.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(516, 179);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(98, 58);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // txtTeam1
            // 
            this.txtTeam1.Location = new System.Drawing.Point(119, 179);
            this.txtTeam1.Name = "txtTeam1";
            this.txtTeam1.Size = new System.Drawing.Size(119, 20);
            this.txtTeam1.TabIndex = 3;
            this.txtTeam1.Text = "Enter the first team";
            // 
            // txtTeam2
            // 
            this.txtTeam2.Location = new System.Drawing.Point(119, 208);
            this.txtTeam2.Name = "txtTeam2";
            this.txtTeam2.Size = new System.Drawing.Size(119, 20);
            this.txtTeam2.TabIndex = 4;
            this.txtTeam2.Text = "Enter the second team";
            // 
            // lblEnterTeam1
            // 
            this.lblEnterTeam1.AutoSize = true;
            this.lblEnterTeam1.Location = new System.Drawing.Point(42, 182);
            this.lblEnterTeam1.Name = "lblEnterTeam1";
            this.lblEnterTeam1.Size = new System.Drawing.Size(43, 13);
            this.lblEnterTeam1.TabIndex = 5;
            this.lblEnterTeam1.Text = "Team 1";
            // 
            // lblEnterTeam2
            // 
            this.lblEnterTeam2.AutoSize = true;
            this.lblEnterTeam2.Location = new System.Drawing.Point(42, 211);
            this.lblEnterTeam2.Name = "lblEnterTeam2";
            this.lblEnterTeam2.Size = new System.Drawing.Size(43, 13);
            this.lblEnterTeam2.TabIndex = 6;
            this.lblEnterTeam2.Text = "Team 2";
            this.lblEnterTeam2.Click += new System.EventHandler(this.lblTeam2_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 11;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblTeam2ScoreFinal, 10, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTeam2Score9, 9, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTeam2Score8, 8, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTeam2Score7, 7, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTeam2Score6, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTeam2Score5, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTeam2Score4, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTeam2Score3, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTeam2Score2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTeam2Score1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTeam2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTeam1ScoreFinal, 10, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTeam1Score9, 9, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTeam1Score8, 8, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTeam1Score7, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTeam1Score6, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTeam1Score5, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTeam1Score4, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTeam1Score3, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTeam1Score2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTeam1Score1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTeam1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblFinal, 10, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblNinth, 9, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblEighth, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblSeventh, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblSixth, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblFifth, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblThird, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblSecond, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblFirst, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblFourth, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTeam, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 31);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.0315F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.9685F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(623, 130);
            this.tableLayoutPanel1.TabIndex = 7;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // lblTeam2ScoreFinal
            // 
            this.lblTeam2ScoreFinal.AutoSize = true;
            this.lblTeam2ScoreFinal.Location = new System.Drawing.Point(576, 86);
            this.lblTeam2ScoreFinal.Name = "lblTeam2ScoreFinal";
            this.lblTeam2ScoreFinal.Size = new System.Drawing.Size(0, 13);
            this.lblTeam2ScoreFinal.TabIndex = 32;
            // 
            // lblTeam2Score9
            // 
            this.lblTeam2Score9.AutoSize = true;
            this.lblTeam2Score9.Location = new System.Drawing.Point(526, 86);
            this.lblTeam2Score9.Name = "lblTeam2Score9";
            this.lblTeam2Score9.Size = new System.Drawing.Size(0, 13);
            this.lblTeam2Score9.TabIndex = 31;
            // 
            // lblTeam2Score8
            // 
            this.lblTeam2Score8.AutoSize = true;
            this.lblTeam2Score8.Location = new System.Drawing.Point(476, 86);
            this.lblTeam2Score8.Name = "lblTeam2Score8";
            this.lblTeam2Score8.Size = new System.Drawing.Size(0, 13);
            this.lblTeam2Score8.TabIndex = 30;
            // 
            // lblTeam2Score7
            // 
            this.lblTeam2Score7.AutoSize = true;
            this.lblTeam2Score7.Location = new System.Drawing.Point(426, 86);
            this.lblTeam2Score7.Name = "lblTeam2Score7";
            this.lblTeam2Score7.Size = new System.Drawing.Size(0, 13);
            this.lblTeam2Score7.TabIndex = 29;
            // 
            // lblTeam2Score6
            // 
            this.lblTeam2Score6.AutoSize = true;
            this.lblTeam2Score6.Location = new System.Drawing.Point(376, 86);
            this.lblTeam2Score6.Name = "lblTeam2Score6";
            this.lblTeam2Score6.Size = new System.Drawing.Size(0, 13);
            this.lblTeam2Score6.TabIndex = 28;
            // 
            // lblTeam2Score5
            // 
            this.lblTeam2Score5.AutoSize = true;
            this.lblTeam2Score5.Location = new System.Drawing.Point(326, 86);
            this.lblTeam2Score5.Name = "lblTeam2Score5";
            this.lblTeam2Score5.Size = new System.Drawing.Size(0, 13);
            this.lblTeam2Score5.TabIndex = 27;
            // 
            // lblTeam2Score4
            // 
            this.lblTeam2Score4.AutoSize = true;
            this.lblTeam2Score4.Location = new System.Drawing.Point(276, 86);
            this.lblTeam2Score4.Name = "lblTeam2Score4";
            this.lblTeam2Score4.Size = new System.Drawing.Size(0, 13);
            this.lblTeam2Score4.TabIndex = 26;
            // 
            // lblTeam2Score3
            // 
            this.lblTeam2Score3.AutoSize = true;
            this.lblTeam2Score3.Location = new System.Drawing.Point(226, 86);
            this.lblTeam2Score3.Name = "lblTeam2Score3";
            this.lblTeam2Score3.Size = new System.Drawing.Size(0, 13);
            this.lblTeam2Score3.TabIndex = 25;
            // 
            // lblTeam2Score2
            // 
            this.lblTeam2Score2.AutoSize = true;
            this.lblTeam2Score2.Location = new System.Drawing.Point(176, 86);
            this.lblTeam2Score2.Name = "lblTeam2Score2";
            this.lblTeam2Score2.Size = new System.Drawing.Size(0, 13);
            this.lblTeam2Score2.TabIndex = 24;
            // 
            // lblTeam2Score1
            // 
            this.lblTeam2Score1.AutoSize = true;
            this.lblTeam2Score1.Location = new System.Drawing.Point(126, 86);
            this.lblTeam2Score1.Name = "lblTeam2Score1";
            this.lblTeam2Score1.Size = new System.Drawing.Size(0, 13);
            this.lblTeam2Score1.TabIndex = 23;
            // 
            // lblTeam2
            // 
            this.lblTeam2.AutoSize = true;
            this.lblTeam2.Location = new System.Drawing.Point(3, 86);
            this.lblTeam2.Name = "lblTeam2";
            this.lblTeam2.Size = new System.Drawing.Size(43, 13);
            this.lblTeam2.TabIndex = 22;
            this.lblTeam2.Text = "Team 2";
            // 
            // lblTeam1ScoreFinal
            // 
            this.lblTeam1ScoreFinal.AutoSize = true;
            this.lblTeam1ScoreFinal.Location = new System.Drawing.Point(576, 41);
            this.lblTeam1ScoreFinal.Name = "lblTeam1ScoreFinal";
            this.lblTeam1ScoreFinal.Size = new System.Drawing.Size(0, 13);
            this.lblTeam1ScoreFinal.TabIndex = 21;
            this.lblTeam1ScoreFinal.Click += new System.EventHandler(this.lblTeam1ScoreFinal_Click);
            // 
            // lblTeam1Score9
            // 
            this.lblTeam1Score9.AutoSize = true;
            this.lblTeam1Score9.Location = new System.Drawing.Point(526, 41);
            this.lblTeam1Score9.Name = "lblTeam1Score9";
            this.lblTeam1Score9.Size = new System.Drawing.Size(0, 13);
            this.lblTeam1Score9.TabIndex = 20;
            // 
            // lblTeam1Score8
            // 
            this.lblTeam1Score8.AutoSize = true;
            this.lblTeam1Score8.Location = new System.Drawing.Point(476, 41);
            this.lblTeam1Score8.Name = "lblTeam1Score8";
            this.lblTeam1Score8.Size = new System.Drawing.Size(0, 13);
            this.lblTeam1Score8.TabIndex = 19;
            // 
            // lblTeam1Score7
            // 
            this.lblTeam1Score7.AutoSize = true;
            this.lblTeam1Score7.Location = new System.Drawing.Point(426, 41);
            this.lblTeam1Score7.Name = "lblTeam1Score7";
            this.lblTeam1Score7.Size = new System.Drawing.Size(0, 13);
            this.lblTeam1Score7.TabIndex = 18;
            this.lblTeam1Score7.Click += new System.EventHandler(this.label20_Click);
            // 
            // lblTeam1Score6
            // 
            this.lblTeam1Score6.AutoSize = true;
            this.lblTeam1Score6.Location = new System.Drawing.Point(376, 41);
            this.lblTeam1Score6.Name = "lblTeam1Score6";
            this.lblTeam1Score6.Size = new System.Drawing.Size(0, 13);
            this.lblTeam1Score6.TabIndex = 17;
            // 
            // lblTeam1Score5
            // 
            this.lblTeam1Score5.AutoSize = true;
            this.lblTeam1Score5.Location = new System.Drawing.Point(326, 41);
            this.lblTeam1Score5.Name = "lblTeam1Score5";
            this.lblTeam1Score5.Size = new System.Drawing.Size(0, 13);
            this.lblTeam1Score5.TabIndex = 16;
            // 
            // lblTeam1Score4
            // 
            this.lblTeam1Score4.AutoSize = true;
            this.lblTeam1Score4.Location = new System.Drawing.Point(276, 41);
            this.lblTeam1Score4.Name = "lblTeam1Score4";
            this.lblTeam1Score4.Size = new System.Drawing.Size(0, 13);
            this.lblTeam1Score4.TabIndex = 15;
            // 
            // lblTeam1Score3
            // 
            this.lblTeam1Score3.AutoSize = true;
            this.lblTeam1Score3.Location = new System.Drawing.Point(226, 41);
            this.lblTeam1Score3.Name = "lblTeam1Score3";
            this.lblTeam1Score3.Size = new System.Drawing.Size(10, 13);
            this.lblTeam1Score3.TabIndex = 14;
            this.lblTeam1Score3.Text = " ";
            this.lblTeam1Score3.Click += new System.EventHandler(this.lblTeam1Score3_Click);
            // 
            // lblTeam1Score2
            // 
            this.lblTeam1Score2.AutoSize = true;
            this.lblTeam1Score2.Location = new System.Drawing.Point(176, 41);
            this.lblTeam1Score2.Name = "lblTeam1Score2";
            this.lblTeam1Score2.Size = new System.Drawing.Size(0, 13);
            this.lblTeam1Score2.TabIndex = 13;
            // 
            // lblTeam1Score1
            // 
            this.lblTeam1Score1.AutoSize = true;
            this.lblTeam1Score1.Location = new System.Drawing.Point(126, 41);
            this.lblTeam1Score1.Name = "lblTeam1Score1";
            this.lblTeam1Score1.Size = new System.Drawing.Size(0, 13);
            this.lblTeam1Score1.TabIndex = 12;
            // 
            // lblTeam1
            // 
            this.lblTeam1.AutoSize = true;
            this.lblTeam1.Location = new System.Drawing.Point(3, 41);
            this.lblTeam1.Name = "lblTeam1";
            this.lblTeam1.Size = new System.Drawing.Size(43, 13);
            this.lblTeam1.TabIndex = 11;
            this.lblTeam1.Text = "Team 1";
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.Location = new System.Drawing.Point(576, 0);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(29, 13);
            this.lblFinal.TabIndex = 10;
            this.lblFinal.Text = "Final";
            // 
            // lblNinth
            // 
            this.lblNinth.AutoSize = true;
            this.lblNinth.Location = new System.Drawing.Point(526, 0);
            this.lblNinth.Name = "lblNinth";
            this.lblNinth.Size = new System.Drawing.Size(22, 13);
            this.lblNinth.TabIndex = 9;
            this.lblNinth.Text = "9th";
            // 
            // lblEighth
            // 
            this.lblEighth.AutoSize = true;
            this.lblEighth.Location = new System.Drawing.Point(476, 0);
            this.lblEighth.Name = "lblEighth";
            this.lblEighth.Size = new System.Drawing.Size(22, 13);
            this.lblEighth.TabIndex = 8;
            this.lblEighth.Text = "8th";
            // 
            // lblSeventh
            // 
            this.lblSeventh.AutoSize = true;
            this.lblSeventh.Location = new System.Drawing.Point(426, 0);
            this.lblSeventh.Name = "lblSeventh";
            this.lblSeventh.Size = new System.Drawing.Size(22, 13);
            this.lblSeventh.TabIndex = 7;
            this.lblSeventh.Text = "7th";
            // 
            // lblSixth
            // 
            this.lblSixth.AutoSize = true;
            this.lblSixth.Location = new System.Drawing.Point(376, 0);
            this.lblSixth.Name = "lblSixth";
            this.lblSixth.Size = new System.Drawing.Size(22, 13);
            this.lblSixth.TabIndex = 6;
            this.lblSixth.Text = "6th";
            // 
            // lblFifth
            // 
            this.lblFifth.AutoSize = true;
            this.lblFifth.Location = new System.Drawing.Point(326, 0);
            this.lblFifth.Name = "lblFifth";
            this.lblFifth.Size = new System.Drawing.Size(22, 13);
            this.lblFifth.TabIndex = 5;
            this.lblFifth.Text = "5th";
            // 
            // lblThird
            // 
            this.lblThird.AutoSize = true;
            this.lblThird.Location = new System.Drawing.Point(226, 0);
            this.lblThird.Name = "lblThird";
            this.lblThird.Size = new System.Drawing.Size(22, 13);
            this.lblThird.TabIndex = 4;
            this.lblThird.Text = "3rd";
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.Location = new System.Drawing.Point(176, 0);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(25, 13);
            this.lblSecond.TabIndex = 3;
            this.lblSecond.Text = "2nd";
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Location = new System.Drawing.Point(126, 0);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(21, 13);
            this.lblFirst.TabIndex = 2;
            this.lblFirst.Text = "1st";
            // 
            // lblFourth
            // 
            this.lblFourth.AutoSize = true;
            this.lblFourth.Location = new System.Drawing.Point(276, 0);
            this.lblFourth.Name = "lblFourth";
            this.lblFourth.Size = new System.Drawing.Size(22, 13);
            this.lblFourth.TabIndex = 0;
            this.lblFourth.Text = "4th";
            // 
            // lblTeam
            // 
            this.lblTeam.AutoSize = true;
            this.lblTeam.Location = new System.Drawing.Point(3, 0);
            this.lblTeam.Name = "lblTeam";
            this.lblTeam.Size = new System.Drawing.Size(39, 13);
            this.lblTeam.TabIndex = 1;
            this.lblTeam.Text = "Teams";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 309);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblEnterTeam2);
            this.Controls.Add(this.lblEnterTeam1);
            this.Controls.Add(this.txtTeam2);
            this.Controls.Add(this.txtTeam1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSim);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSim;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtTeam1;
        private System.Windows.Forms.TextBox txtTeam2;
        private System.Windows.Forms.Label lblEnterTeam1;
        private System.Windows.Forms.Label lblEnterTeam2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTeam2ScoreFinal;
        private System.Windows.Forms.Label lblTeam2Score9;
        private System.Windows.Forms.Label lblTeam2Score8;
        private System.Windows.Forms.Label lblTeam2Score7;
        private System.Windows.Forms.Label lblTeam2Score6;
        private System.Windows.Forms.Label lblTeam2Score5;
        private System.Windows.Forms.Label lblTeam2Score4;
        private System.Windows.Forms.Label lblTeam2Score3;
        private System.Windows.Forms.Label lblTeam2Score2;
        private System.Windows.Forms.Label lblTeam2Score1;
        private System.Windows.Forms.Label lblTeam2;
        private System.Windows.Forms.Label lblTeam1ScoreFinal;
        private System.Windows.Forms.Label lblTeam1Score9;
        private System.Windows.Forms.Label lblTeam1Score8;
        private System.Windows.Forms.Label lblTeam1Score7;
        private System.Windows.Forms.Label lblTeam1Score6;
        private System.Windows.Forms.Label lblTeam1Score5;
        private System.Windows.Forms.Label lblTeam1Score4;
        private System.Windows.Forms.Label lblTeam1Score3;
        private System.Windows.Forms.Label lblTeam1Score2;
        private System.Windows.Forms.Label lblTeam1Score1;
        private System.Windows.Forms.Label lblTeam1;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.Label lblNinth;
        private System.Windows.Forms.Label lblEighth;
        private System.Windows.Forms.Label lblSeventh;
        private System.Windows.Forms.Label lblSixth;
        private System.Windows.Forms.Label lblFifth;
        private System.Windows.Forms.Label lblThird;
        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblFourth;
        private System.Windows.Forms.Label lblTeam;
    }
}

