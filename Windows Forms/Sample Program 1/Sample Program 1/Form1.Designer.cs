
namespace Sample_Program_1
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
            this.butGreeting = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblAskName = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butGreeting
            // 
            this.butGreeting.Location = new System.Drawing.Point(45, 90);
            this.butGreeting.Name = "butGreeting";
            this.butGreeting.Size = new System.Drawing.Size(75, 23);
            this.butGreeting.TabIndex = 0;
            this.butGreeting.Text = "Greeting";
            this.butGreeting.UseVisualStyleBackColor = true;
            this.butGreeting.Click += new System.EventHandler(this.butGreeting_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(31, 57);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 20);
            this.txtInput.TabIndex = 1;
            // 
            // lblAskName
            // 
            this.lblAskName.AutoSize = true;
            this.lblAskName.Location = new System.Drawing.Point(28, 22);
            this.lblAskName.Name = "lblAskName";
            this.lblAskName.Size = new System.Drawing.Size(0, 13);
            this.lblAskName.TabIndex = 2;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(85, 125);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 13);
            this.lblOutput.TabIndex = 3;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(30, 22);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(101, 13);
            this.lblQuestion.TabIndex = 4;
            this.lblQuestion.Text = "What is your name?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblAskName);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.butGreeting);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butGreeting;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblAskName;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblQuestion;
    }
}

