namespace CST_150_Activity_8
{
    partial class caloriesCalcForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(caloriesCalcForm));
            this.fatGramLabel = new System.Windows.Forms.Label();
            this.carbGramLabel = new System.Windows.Forms.Label();
            this.fatGramTextBox = new System.Windows.Forms.TextBox();
            this.carbGramTextBox = new System.Windows.Forms.TextBox();
            this.fatCaloriesOutputLabel = new System.Windows.Forms.Label();
            this.carbCaloriesOutputLabel = new System.Windows.Forms.Label();
            this.totalCaloriesLabel = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fatGramLabel
            // 
            this.fatGramLabel.AutoSize = true;
            this.fatGramLabel.Location = new System.Drawing.Point(16, 38);
            this.fatGramLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fatGramLabel.Name = "fatGramLabel";
            this.fatGramLabel.Size = new System.Drawing.Size(78, 17);
            this.fatGramLabel.TabIndex = 0;
            this.fatGramLabel.Text = "Fat Grams:";
            // 
            // carbGramLabel
            // 
            this.carbGramLabel.AutoSize = true;
            this.carbGramLabel.Location = new System.Drawing.Point(16, 70);
            this.carbGramLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.carbGramLabel.Name = "carbGramLabel";
            this.carbGramLabel.Size = new System.Drawing.Size(88, 17);
            this.carbGramLabel.TabIndex = 1;
            this.carbGramLabel.Text = "Carb Grams:";
            // 
            // fatGramTextBox
            // 
            this.fatGramTextBox.Location = new System.Drawing.Point(123, 34);
            this.fatGramTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fatGramTextBox.Name = "fatGramTextBox";
            this.fatGramTextBox.Size = new System.Drawing.Size(132, 22);
            this.fatGramTextBox.TabIndex = 2;
            // 
            // carbGramTextBox
            // 
            this.carbGramTextBox.Location = new System.Drawing.Point(123, 66);
            this.carbGramTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.carbGramTextBox.Name = "carbGramTextBox";
            this.carbGramTextBox.Size = new System.Drawing.Size(132, 22);
            this.carbGramTextBox.TabIndex = 3;
            // 
            // fatCaloriesOutputLabel
            // 
            this.fatCaloriesOutputLabel.AutoSize = true;
            this.fatCaloriesOutputLabel.Location = new System.Drawing.Point(17, 132);
            this.fatCaloriesOutputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fatCaloriesOutputLabel.Name = "fatCaloriesOutputLabel";
            this.fatCaloriesOutputLabel.Size = new System.Drawing.Size(0, 17);
            this.fatCaloriesOutputLabel.TabIndex = 4;
            // 
            // carbCaloriesOutputLabel
            // 
            this.carbCaloriesOutputLabel.AutoSize = true;
            this.carbCaloriesOutputLabel.Location = new System.Drawing.Point(17, 175);
            this.carbCaloriesOutputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.carbCaloriesOutputLabel.Name = "carbCaloriesOutputLabel";
            this.carbCaloriesOutputLabel.Size = new System.Drawing.Size(0, 17);
            this.carbCaloriesOutputLabel.TabIndex = 5;
            // 
            // totalCaloriesLabel
            // 
            this.totalCaloriesLabel.AutoSize = true;
            this.totalCaloriesLabel.Location = new System.Drawing.Point(17, 219);
            this.totalCaloriesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalCaloriesLabel.Name = "totalCaloriesLabel";
            this.totalCaloriesLabel.Size = new System.Drawing.Size(0, 17);
            this.totalCaloriesLabel.TabIndex = 6;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(20, 291);
            this.calcButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(100, 28);
            this.calcButton.TabIndex = 7;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // caloriesCalcForm
            // 
            this.AcceptButton = this.calcButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 332);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.totalCaloriesLabel);
            this.Controls.Add(this.carbCaloriesOutputLabel);
            this.Controls.Add(this.fatCaloriesOutputLabel);
            this.Controls.Add(this.carbGramTextBox);
            this.Controls.Add(this.fatGramTextBox);
            this.Controls.Add(this.carbGramLabel);
            this.Controls.Add(this.fatGramLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "caloriesCalcForm";
            this.Text = "Calories Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fatGramLabel;
        private System.Windows.Forms.Label carbGramLabel;
        private System.Windows.Forms.TextBox fatGramTextBox;
        private System.Windows.Forms.TextBox carbGramTextBox;
        private System.Windows.Forms.Label fatCaloriesOutputLabel;
        private System.Windows.Forms.Label carbCaloriesOutputLabel;
        private System.Windows.Forms.Label totalCaloriesLabel;
        private System.Windows.Forms.Button calcButton;
    }
}

