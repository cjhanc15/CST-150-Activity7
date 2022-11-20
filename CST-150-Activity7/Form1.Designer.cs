namespace CST_150_Activity7
{
    partial class findingPi
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
            this.title = new System.Windows.Forms.Label();
            this.termsLabel = new System.Windows.Forms.Label();
            this.terms = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.answer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(1864, 225);
            this.title.TabIndex = 0;
            this.title.Text = "Finding Pi";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // termsLabel
            // 
            this.termsLabel.Font = new System.Drawing.Font("Verdana", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.termsLabel.Location = new System.Drawing.Point(487, 386);
            this.termsLabel.Name = "termsLabel";
            this.termsLabel.Size = new System.Drawing.Size(517, 72);
            this.termsLabel.TabIndex = 1;
            this.termsLabel.Text = "Number of Terms:";
            // 
            // terms
            // 
            this.terms.Font = new System.Drawing.Font("Verdana", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.terms.Location = new System.Drawing.Point(1010, 386);
            this.terms.Name = "terms";
            this.terms.Size = new System.Drawing.Size(188, 72);
            this.terms.TabIndex = 2;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(1204, 386);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(157, 72);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "CALCULATE";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // answer
            // 
            this.answer.AutoSize = true;
            this.answer.Font = new System.Drawing.Font("Verdana", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer.Location = new System.Drawing.Point(733, 721);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(271, 65);
            this.answer.TabIndex = 4;
            this.answer.Text = "Solution:";
            // 
            // findingPi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1864, 1052);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.terms);
            this.Controls.Add(this.termsLabel);
            this.Controls.Add(this.title);
            this.Name = "findingPi";
            this.Text = "Finding Pi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label termsLabel;
        private System.Windows.Forms.TextBox terms;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label answer;
    }
}

