namespace BilgisayarCini
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.QuestionButton = new System.Windows.Forms.Button();
            this.AnswerLbl = new System.Windows.Forms.Label();
            this.QuestionBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // QuestionButton
            // 
            this.QuestionButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            resources.ApplyResources(this.QuestionButton, "QuestionButton");
            this.QuestionButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.QuestionButton.Name = "QuestionButton";
            this.QuestionButton.UseVisualStyleBackColor = false;
            this.QuestionButton.Click += new System.EventHandler(this.QuestionButton_Click);
            // 
            // AnswerLbl
            // 
            resources.ApplyResources(this.AnswerLbl, "AnswerLbl");
            this.AnswerLbl.Name = "AnswerLbl";
            // 
            // QuestionBox
            // 
            resources.ApplyResources(this.QuestionBox, "QuestionBox");
            this.QuestionBox.Name = "QuestionBox";
            this.QuestionBox.TextChanged += new System.EventHandler(this.QuestionBox_TextChanged);
            this.QuestionBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.QuestionBox_KeyDown);
            this.QuestionBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QuestionBox_KeyPress);
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AcceptButton = this.QuestionButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.QuestionBox);
            this.Controls.Add(this.AnswerLbl);
            this.Controls.Add(this.QuestionButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button QuestionButton;
        private System.Windows.Forms.Label AnswerLbl;
        private System.Windows.Forms.TextBox QuestionBox;
        private System.Windows.Forms.Timer timer1;
    }
}

