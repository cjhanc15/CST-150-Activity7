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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(findingPi));
            this.title = new System.Windows.Forms.Label();
            this.termsLabel = new System.Windows.Forms.Label();
            this.terms = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.solutionLabel = new System.Windows.Forms.Label();
            this.answer = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(234)))), ((int)(((byte)(213)))));
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
            this.termsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(245)))), ((int)(((byte)(229)))));
            this.termsLabel.Location = new System.Drawing.Point(431, 382);
            this.termsLabel.Name = "termsLabel";
            this.termsLabel.Size = new System.Drawing.Size(538, 72);
            this.termsLabel.TabIndex = 1;
            this.termsLabel.Text = "Number of Terms:";
            // 
            // terms
            // 
            this.terms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(245)))), ((int)(((byte)(229)))));
            this.terms.Font = new System.Drawing.Font("Verdana", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.terms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(195)))), ((int)(((byte)(176)))));
            this.terms.Location = new System.Drawing.Point(975, 382);
            this.terms.Name = "terms";
            this.terms.Size = new System.Drawing.Size(188, 72);
            this.terms.TabIndex = 2;
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(234)))), ((int)(((byte)(213)))));
            this.calculateButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(1169, 382);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(243, 72);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "CALCULATE";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // solutionLabel
            // 
            this.solutionLabel.AutoSize = true;
            this.solutionLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(234)))), ((int)(((byte)(213)))));
            this.solutionLabel.Font = new System.Drawing.Font("Verdana", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solutionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(195)))), ((int)(((byte)(176)))));
            this.solutionLabel.Location = new System.Drawing.Point(674, 697);
            this.solutionLabel.Name = "solutionLabel";
            this.solutionLabel.Size = new System.Drawing.Size(271, 65);
            this.solutionLabel.TabIndex = 4;
            this.solutionLabel.Text = "Solution:";
            this.solutionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // answer
            // 
            this.answer.AutoSize = true;
            this.answer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(234)))), ((int)(((byte)(213)))));
            this.answer.Font = new System.Drawing.Font("Verdana", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.answer.Location = new System.Drawing.Point(942, 697);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(47, 65);
            this.answer.TabIndex = 5;
            this.answer.Text = " ";
            this.answer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.error.Location = new System.Drawing.Point(968, 457);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(28, 38);
            this.error.TabIndex = 6;
            this.error.Text = " ";
            // 
            // findingPi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(195)))), ((int)(((byte)(176)))));
            this.ClientSize = new System.Drawing.Size(1864, 1052);
            this.Controls.Add(this.error);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.solutionLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.terms);
            this.Controls.Add(this.termsLabel);
            this.Controls.Add(this.title);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(195)))), ((int)(((byte)(176)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Label solutionLabel;
        private System.Windows.Forms.Label answer;
        private System.Windows.Forms.Label error;
    }
}

