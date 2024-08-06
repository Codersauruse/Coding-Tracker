namespace Codingtracker
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
            components = new System.ComponentModel.Container();
            formTimer = new System.Windows.Forms.Timer(components);
            tabPage4 = new TabPage();
            tabPage3 = new TabPage();
            tabPage2 = new TabPage();
            tabPage1 = new TabPage();
            timerLabel = new Label();
            startBtn = new Button();
            endBtn = new Button();
            resetBtn = new Button();
            tabControl1 = new TabControl();
            splitContainer1 = new SplitContainer();
            tabPage2.SuspendLayout();
            tabPage1.SuspendLayout();
            tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // formTimer
            // 
            formTimer.Tick += formTimer_Tick;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 34);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(845, 433);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Add Goals";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPage3.Location = new Point(4, 34);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(845, 433);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Stats";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(splitContainer1);
            tabPage2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(845, 433);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "View coding time";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.DarkCyan;
            tabPage1.Controls.Add(resetBtn);
            tabPage1.Controls.Add(endBtn);
            tabPage1.Controls.Add(startBtn);
            tabPage1.Controls.Add(timerLabel);
            tabPage1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPage1.ForeColor = SystemColors.ActiveCaption;
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(845, 433);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Coding Tracker";
            // 
            // timerLabel
            // 
            timerLabel.AutoSize = true;
            timerLabel.BackColor = Color.MediumTurquoise;
            timerLabel.Font = new Font("Yu Gothic Light", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timerLabel.ForeColor = SystemColors.ActiveCaptionText;
            timerLabel.Location = new Point(245, 70);
            timerLabel.Name = "timerLabel";
            timerLabel.Size = new Size(350, 155);
            timerLabel.TabIndex = 0;
            timerLabel.Text = "00:00";
            // 
            // startBtn
            // 
            startBtn.BackColor = Color.Chartreuse;
            startBtn.Font = new Font("Lucida Sans Unicode", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            startBtn.ForeColor = SystemColors.ActiveCaptionText;
            startBtn.Location = new Point(245, 254);
            startBtn.Name = "startBtn";
            startBtn.Size = new Size(93, 45);
            startBtn.TabIndex = 1;
            startBtn.Text = "Start";
            startBtn.UseVisualStyleBackColor = false;
            startBtn.Click += button1_Click;
            // 
            // endBtn
            // 
            endBtn.BackColor = Color.IndianRed;
            endBtn.Font = new Font("Lucida Sans Unicode", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            endBtn.ForeColor = SystemColors.ActiveCaptionText;
            endBtn.Location = new Point(375, 254);
            endBtn.Name = "endBtn";
            endBtn.Size = new Size(91, 45);
            endBtn.TabIndex = 2;
            endBtn.Text = "Stop";
            endBtn.UseVisualStyleBackColor = false;
            endBtn.Click += button2_Click;
            // 
            // resetBtn
            // 
            resetBtn.BackColor = Color.Turquoise;
            resetBtn.Font = new Font("Lucida Console", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resetBtn.ForeColor = SystemColors.ActiveCaptionText;
            resetBtn.Location = new Point(499, 254);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(96, 45);
            resetBtn.TabIndex = 3;
            resetBtn.Text = "Reset";
            resetBtn.UseVisualStyleBackColor = false;
            resetBtn.Click += button3_Click;
            // 
            // tabControl1
            // 
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Cursor = Cursors.Hand;
            tabControl1.Font = new Font("MS Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl1.ItemSize = new Size(200, 30);
            tabControl1.Location = new Point(0, -2);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.Padding = new Point(5, 5);
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(853, 471);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.LightSeaGreen;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.PaleTurquoise;
            splitContainer1.Size = new Size(839, 427);
            splitContainer1.SplitterDistance = 268;
            splitContainer1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 464);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabPage2.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer formTimer;
        private TabPage tabPage4;
        private TabPage tabPage3;
        private TabPage tabPage2;
        private TabPage tabPage1;
        private Button resetBtn;
        private Button endBtn;
        private Button startBtn;
        private Label timerLabel;
        private TabControl tabControl1;
        private SplitContainer splitContainer1;
    }
}
