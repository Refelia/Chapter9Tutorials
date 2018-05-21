namespace AccessingControlDifferentForm
{
    partial class NutritionalForm
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
            this.foodLabel = new System.Windows.Forms.Label();
            this.calLabel = new System.Windows.Forms.Label();
            this.fatLabel = new System.Windows.Forms.Label();
            this.gramsLabel = new System.Windows.Forms.Label();
            this.foodOutLabel = new System.Windows.Forms.Label();
            this.calOutLabel = new System.Windows.Forms.Label();
            this.fatGramsOUtLabel = new System.Windows.Forms.Label();
            this.gramsOutLabel = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // foodLabel
            // 
            this.foodLabel.AutoSize = true;
            this.foodLabel.Location = new System.Drawing.Point(67, 34);
            this.foodLabel.Name = "foodLabel";
            this.foodLabel.Size = new System.Drawing.Size(31, 13);
            this.foodLabel.TabIndex = 0;
            this.foodLabel.Text = "Food";
            // 
            // calLabel
            // 
            this.calLabel.AutoSize = true;
            this.calLabel.Location = new System.Drawing.Point(54, 74);
            this.calLabel.Name = "calLabel";
            this.calLabel.Size = new System.Drawing.Size(44, 13);
            this.calLabel.TabIndex = 1;
            this.calLabel.Text = "Calories";
            // 
            // fatLabel
            // 
            this.fatLabel.AutoSize = true;
            this.fatLabel.Location = new System.Drawing.Point(44, 117);
            this.fatLabel.Name = "fatLabel";
            this.fatLabel.Size = new System.Drawing.Size(55, 13);
            this.fatLabel.TabIndex = 2;
            this.fatLabel.Text = "Fat Grams";
            // 
            // gramsLabel
            // 
            this.gramsLabel.AutoSize = true;
            this.gramsLabel.Location = new System.Drawing.Point(36, 156);
            this.gramsLabel.Name = "gramsLabel";
            this.gramsLabel.Size = new System.Drawing.Size(62, 13);
            this.gramsLabel.TabIndex = 3;
            this.gramsLabel.Text = "Carb Grams";
            // 
            // foodOutLabel
            // 
            this.foodOutLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.foodOutLabel.Location = new System.Drawing.Point(104, 24);
            this.foodOutLabel.Name = "foodOutLabel";
            this.foodOutLabel.Size = new System.Drawing.Size(100, 23);
            this.foodOutLabel.TabIndex = 4;
            // 
            // calOutLabel
            // 
            this.calOutLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.calOutLabel.Location = new System.Drawing.Point(104, 64);
            this.calOutLabel.Name = "calOutLabel";
            this.calOutLabel.Size = new System.Drawing.Size(100, 23);
            this.calOutLabel.TabIndex = 5;
            // 
            // fatGramsOUtLabel
            // 
            this.fatGramsOUtLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fatGramsOUtLabel.Location = new System.Drawing.Point(105, 107);
            this.fatGramsOUtLabel.Name = "fatGramsOUtLabel";
            this.fatGramsOUtLabel.Size = new System.Drawing.Size(100, 23);
            this.fatGramsOUtLabel.TabIndex = 6;
            // 
            // gramsOutLabel
            // 
            this.gramsOutLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gramsOutLabel.Location = new System.Drawing.Point(105, 146);
            this.gramsOutLabel.Name = "gramsOutLabel";
            this.gramsOutLabel.Size = new System.Drawing.Size(100, 23);
            this.gramsOutLabel.TabIndex = 7;
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(118, 226);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 8;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // NutritionalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.gramsOutLabel);
            this.Controls.Add(this.fatGramsOUtLabel);
            this.Controls.Add(this.calOutLabel);
            this.Controls.Add(this.foodOutLabel);
            this.Controls.Add(this.gramsLabel);
            this.Controls.Add(this.fatLabel);
            this.Controls.Add(this.calLabel);
            this.Controls.Add(this.foodLabel);
            this.Name = "NutritionalForm";
            this.Text = "NutritionalForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label foodLabel;
        private System.Windows.Forms.Label calLabel;
        private System.Windows.Forms.Label fatLabel;
        private System.Windows.Forms.Label gramsLabel;
        public System.Windows.Forms.Label foodOutLabel;
        public System.Windows.Forms.Label calOutLabel;
        public System.Windows.Forms.Label fatGramsOUtLabel;
        public System.Windows.Forms.Label gramsOutLabel;
        private System.Windows.Forms.Button closeBtn;
    }
}