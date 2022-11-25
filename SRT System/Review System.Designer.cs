using System.ComponentModel;

namespace SRT_System
{
    partial class Review_System
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.HLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EvalText = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SugText = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.StatusLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HLabel
            // 
            this.HLabel.AutoSize = true;
            this.HLabel.Location = new System.Drawing.Point(385, 25);
            this.HLabel.Name = "HLabel";
            this.HLabel.Size = new System.Drawing.Size(85, 15);
            this.HLabel.TabIndex = 0;
            this.HLabel.Text = "Review System";
            this.HLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Module :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(175, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(573, 23);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chosen Module : ";
            // 
            // EvalText
            // 
            this.EvalText.Location = new System.Drawing.Point(34, 193);
            this.EvalText.Name = "EvalText";
            this.EvalText.Size = new System.Drawing.Size(751, 157);
            this.EvalText.TabIndex = 4;
            this.EvalText.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(631, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Provide a brief evaluation of the lecturer and the lucture in terms of deliveranc" +
    "e, understandability and professionalism";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(312, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Any suggestions or complaints you would like query out ?";
            // 
            // SugText
            // 
            this.SugText.Location = new System.Drawing.Point(34, 393);
            this.SugText.Name = "SugText";
            this.SugText.Size = new System.Drawing.Size(751, 157);
            this.SugText.TabIndex = 7;
            this.SugText.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(78, 566);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 38);
            this.button1.TabIndex = 8;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(322, 566);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 38);
            this.button2.TabIndex = 9;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(556, 566);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(173, 38);
            this.button3.TabIndex = 10;
            this.button3.Text = "Submit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(528, 620);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(284, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Need Help? Click me to get assistance from students";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // StatusLbl
            // 
            this.StatusLbl.AutoSize = true;
            this.StatusLbl.Location = new System.Drawing.Point(138, 113);
            this.StatusLbl.Name = "StatusLbl";
            this.StatusLbl.Size = new System.Drawing.Size(0, 15);
            this.StatusLbl.TabIndex = 12;
            // 
            // Review_System
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 644);
            this.Controls.Add(this.StatusLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SugText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EvalText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HLabel);
            this.Name = "Review_System";
            this.Text = "Review_System";
            this.Load += new System.EventHandler(this.Review_System_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label HLabel;
        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private RichTextBox EvalText;
        private Label label3;
        private Label label4;
        private RichTextBox SugText;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label5;
        private Label StatusLbl;
    }
}