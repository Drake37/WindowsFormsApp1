namespace WindowsFormsApp1
{
    partial class Form2
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
            this.tbNum = new System.Windows.Forms.TextBox();
            this.btCheck = new System.Windows.Forms.Button();
            this.lb1 = new System.Windows.Forms.Label();
            this.btNewGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNum
            // 
            this.tbNum.Location = new System.Drawing.Point(112, 52);
            this.tbNum.Name = "tbNum";
            this.tbNum.Size = new System.Drawing.Size(112, 20);
            this.tbNum.TabIndex = 0;
            // 
            // btCheck
            // 
            this.btCheck.Location = new System.Drawing.Point(112, 78);
            this.btCheck.Name = "btCheck";
            this.btCheck.Size = new System.Drawing.Size(75, 23);
            this.btCheck.TabIndex = 1;
            this.btCheck.Text = "Проверить";
            this.btCheck.UseVisualStyleBackColor = true;
            this.btCheck.Click += new System.EventHandler(this.btCheck_Click);
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(25, 55);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(81, 13);
            this.lb1.TabIndex = 2;
            this.lb1.Text = "Введите число";
            // 
            // btNewGame
            // 
            this.btNewGame.Location = new System.Drawing.Point(243, 78);
            this.btNewGame.Name = "btNewGame";
            this.btNewGame.Size = new System.Drawing.Size(75, 23);
            this.btNewGame.TabIndex = 3;
            this.btNewGame.Text = "Заново";
            this.btNewGame.UseVisualStyleBackColor = true;
            this.btNewGame.Click += new System.EventHandler(this.btNewGame_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.btNewGame);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.btCheck);
            this.Controls.Add(this.tbNum);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 300);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Угадай число";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNum;
        private System.Windows.Forms.Button btCheck;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Button btNewGame;
    }
}