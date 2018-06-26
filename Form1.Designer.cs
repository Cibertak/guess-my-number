namespace geuss_my_number
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
            this.btn_geuss = new System.Windows.Forms.Button();
            this.Lb_output = new System.Windows.Forms.Label();
            this.tbox_guess = new System.Windows.Forms.TextBox();
            this.lb_left = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_geuss
            // 
            this.btn_geuss.Location = new System.Drawing.Point(204, 283);
            this.btn_geuss.Name = "btn_geuss";
            this.btn_geuss.Size = new System.Drawing.Size(160, 80);
            this.btn_geuss.TabIndex = 0;
            this.btn_geuss.Text = "guess";
            this.btn_geuss.UseVisualStyleBackColor = true;
            this.btn_geuss.Click += new System.EventHandler(this.geuss_Click);
            // 
            // Lb_output
            // 
            this.Lb_output.AutoSize = true;
            this.Lb_output.Location = new System.Drawing.Point(215, 103);
            this.Lb_output.Name = "Lb_output";
            this.Lb_output.Size = new System.Drawing.Size(134, 20);
            this.Lb_output.TabIndex = 1;
            this.Lb_output.Text = "guess my number";
            // 
            // tbox_guess
            // 
            this.tbox_guess.Location = new System.Drawing.Point(151, 215);
            this.tbox_guess.Name = "tbox_guess";
            this.tbox_guess.Size = new System.Drawing.Size(261, 26);
            this.tbox_guess.TabIndex = 2;
            // 
            // lb_left
            // 
            this.lb_left.AutoSize = true;
            this.lb_left.Location = new System.Drawing.Point(219, 159);
            this.lb_left.Name = "lb_left";
            this.lb_left.Size = new System.Drawing.Size(108, 20);
            this.lb_left.TabIndex = 3;
            this.lb_left.Text = "Guess left: 10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 518);
            this.Controls.Add(this.lb_left);
            this.Controls.Add(this.tbox_guess);
            this.Controls.Add(this.Lb_output);
            this.Controls.Add(this.btn_geuss);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_geuss;
        private System.Windows.Forms.Label Lb_output;
        private System.Windows.Forms.TextBox tbox_guess;
        private System.Windows.Forms.Label lb_left;
    }
}

