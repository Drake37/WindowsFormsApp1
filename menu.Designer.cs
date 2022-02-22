namespace WindowsFormsApp1
{
    partial class menu
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
            this.btGame1 = new System.Windows.Forms.Button();
            this.btGame2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btGame1
            // 
            this.btGame1.BackColor = System.Drawing.Color.Green;
            this.btGame1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btGame1.Location = new System.Drawing.Point(23, 63);
            this.btGame1.Name = "btGame1";
            this.btGame1.Size = new System.Drawing.Size(156, 55);
            this.btGame1.TabIndex = 0;
            this.btGame1.Text = "Удвоитель";
            this.btGame1.UseVisualStyleBackColor = false;
            this.btGame1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btGame2
            // 
            this.btGame2.BackColor = System.Drawing.Color.Green;
            this.btGame2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btGame2.Location = new System.Drawing.Point(23, 136);
            this.btGame2.Name = "btGame2";
            this.btGame2.Size = new System.Drawing.Size(156, 55);
            this.btGame2.TabIndex = 1;
            this.btGame2.Text = "Угадай число";
            this.btGame2.UseVisualStyleBackColor = false;
            this.btGame2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите игру";
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(207, 217);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btGame2);
            this.Controls.Add(this.btGame1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(223, 256);
            this.MinimumSize = new System.Drawing.Size(223, 256);
            this.Name = "menu";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btGame1;
        private System.Windows.Forms.Button btGame2;
        private System.Windows.Forms.Label label1;
    }
}