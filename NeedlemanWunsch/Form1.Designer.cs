﻿namespace NeedlemanWunsch
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.alignmentseq1 = new System.Windows.Forms.Label();
            this.matchText = new System.Windows.Forms.TextBox();
            this.Matche = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.missmatchText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gapText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.seq2Text = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.seq1Text = new System.Windows.Forms.TextBox();
            this.alignmentseq2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.Location = new System.Drawing.Point(399, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Show Algorithm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(784, 307);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // alignmentseq1
            // 
            this.alignmentseq1.AutoSize = true;
            this.alignmentseq1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.alignmentseq1.Location = new System.Drawing.Point(515, 341);
            this.alignmentseq1.Name = "alignmentseq1";
            this.alignmentseq1.Size = new System.Drawing.Size(124, 21);
            this.alignmentseq1.TabIndex = 2;
            this.alignmentseq1.Text = "alignmentseq1";
            // 
            // matchText
            // 
            this.matchText.Location = new System.Drawing.Point(94, 359);
            this.matchText.Name = "matchText";
            this.matchText.Size = new System.Drawing.Size(100, 23);
            this.matchText.TabIndex = 3;
            // 
            // Matche
            // 
            this.Matche.AutoSize = true;
            this.Matche.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Matche.Location = new System.Drawing.Point(38, 359);
            this.Matche.Name = "Matche";
            this.Matche.Size = new System.Drawing.Size(54, 19);
            this.Matche.TabIndex = 4;
            this.Matche.Text = "Match";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(7, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Missmatch";
            // 
            // missmatchText
            // 
            this.missmatchText.Location = new System.Drawing.Point(94, 388);
            this.missmatchText.Name = "missmatchText";
            this.missmatchText.Size = new System.Drawing.Size(100, 23);
            this.missmatchText.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(50, 420);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Gap";
            // 
            // gapText
            // 
            this.gapText.Location = new System.Drawing.Point(94, 417);
            this.gapText.Name = "gapText";
            this.gapText.Size = new System.Drawing.Size(100, 23);
            this.gapText.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(221, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Seq2";
            // 
            // seq2Text
            // 
            this.seq2Text.Location = new System.Drawing.Point(268, 414);
            this.seq2Text.Name = "seq2Text";
            this.seq2Text.Size = new System.Drawing.Size(100, 23);
            this.seq2Text.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(221, 385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Seq1";
            // 
            // seq1Text
            // 
            this.seq1Text.Location = new System.Drawing.Point(268, 385);
            this.seq1Text.Name = "seq1Text";
            this.seq1Text.Size = new System.Drawing.Size(100, 23);
            this.seq1Text.TabIndex = 9;
            // 
            // alignmentseq2
            // 
            this.alignmentseq2.AutoSize = true;
            this.alignmentseq2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.alignmentseq2.Location = new System.Drawing.Point(515, 362);
            this.alignmentseq2.Name = "alignmentseq2";
            this.alignmentseq2.Size = new System.Drawing.Size(124, 21);
            this.alignmentseq2.TabIndex = 13;
            this.alignmentseq2.Text = "alignmentseq2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(492, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Çalışma Süresi:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(611, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 21);
            this.label8.TabIndex = 15;
            this.label8.Text = "label8";
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.score.Location = new System.Drawing.Point(691, 420);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(54, 21);
            this.score.TabIndex = 16;
            this.score.Text = "score:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.score);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.alignmentseq2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.seq2Text);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.seq1Text);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gapText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.missmatchText);
            this.Controls.Add(this.Matche);
            this.Controls.Add(this.matchText);
            this.Controls.Add(this.alignmentseq1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private Label alignmentseq1;
        private TextBox matchText;
        private Label Matche;
        private Label label3;
        private TextBox missmatchText;
        private Label label4;
        private TextBox gapText;
        private Label label2;
        private TextBox seq2Text;
        private Label label5;
        private TextBox seq1Text;
        private Label alignmentseq2;
        private Label label7;
        private Label label8;
        private Label score;
    }
}