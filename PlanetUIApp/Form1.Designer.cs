namespace PlanetUIApp
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
            this.planetNamelabel = new System.Windows.Forms.Label();
            this.planetListComboBox = new System.Windows.Forms.ComboBox();
            this.showPlanetbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // planetNamelabel
            // 
            this.planetNamelabel.AutoSize = true;
            this.planetNamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planetNamelabel.Location = new System.Drawing.Point(62, 84);
            this.planetNamelabel.Name = "planetNamelabel";
            this.planetNamelabel.Size = new System.Drawing.Size(135, 25);
            this.planetNamelabel.TabIndex = 0;
            this.planetNamelabel.Text = "Planet Name";
            // 
            // planetListComboBox
            // 
            this.planetListComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planetListComboBox.FormattingEnabled = true;
            this.planetListComboBox.Items.AddRange(new object[] {
            "Earth",
            "Planet",
            "Saturn",
            "Mars"});
            this.planetListComboBox.Location = new System.Drawing.Point(255, 81);
            this.planetListComboBox.Name = "planetListComboBox";
            this.planetListComboBox.Size = new System.Drawing.Size(237, 33);
            this.planetListComboBox.TabIndex = 1;
            // 
            // showPlanetbutton
            // 
            this.showPlanetbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPlanetbutton.Location = new System.Drawing.Point(255, 205);
            this.showPlanetbutton.Name = "showPlanetbutton";
            this.showPlanetbutton.Size = new System.Drawing.Size(237, 61);
            this.showPlanetbutton.TabIndex = 2;
            this.showPlanetbutton.Text = "Show Planet";
            this.showPlanetbutton.UseVisualStyleBackColor = true;
            this.showPlanetbutton.Click += new System.EventHandler(this.showPlanetbutton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.showPlanetbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showPlanetbutton);
            this.Controls.Add(this.planetListComboBox);
            this.Controls.Add(this.planetNamelabel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label planetNamelabel;
        private System.Windows.Forms.ComboBox planetListComboBox;
        private System.Windows.Forms.Button showPlanetbutton;
    }
}

