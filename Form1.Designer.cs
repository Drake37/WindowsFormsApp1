namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btNewGame = new System.Windows.Forms.Button();
            this.btPlusOne = new System.Windows.Forms.Button();
            this.btMultiTwo = new System.Windows.Forms.Button();
            this.btUndo = new System.Windows.Forms.Button();
            this.lbCompNum = new System.Windows.Forms.Label();
            this.lbUserNum = new System.Windows.Forms.Label();
            this.lbSteps = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btNewGame
            // 
            this.btNewGame.Location = new System.Drawing.Point(271, 12);
            this.btNewGame.Name = "btNewGame";
            this.btNewGame.Size = new System.Drawing.Size(100, 40);
            this.btNewGame.TabIndex = 0;
            this.btNewGame.Text = "New Game";
            this.btNewGame.UseVisualStyleBackColor = true;
            this.btNewGame.Click += new System.EventHandler(this.btNewGame_Click);
            // 
            // btPlusOne
            // 
            this.btPlusOne.Location = new System.Drawing.Point(272, 63);
            this.btPlusOne.Name = "btPlusOne";
            this.btPlusOne.Size = new System.Drawing.Size(100, 40);
            this.btPlusOne.TabIndex = 1;
            this.btPlusOne.Text = "+1";
            this.btPlusOne.UseVisualStyleBackColor = true;
            this.btPlusOne.Click += new System.EventHandler(this.btPlusOne_Click);
            // 
            // btMultiTwo
            // 
            this.btMultiTwo.Location = new System.Drawing.Point(271, 118);
            this.btMultiTwo.Name = "btMultiTwo";
            this.btMultiTwo.Size = new System.Drawing.Size(100, 40);
            this.btMultiTwo.TabIndex = 2;
            this.btMultiTwo.Text = "*2";
            this.btMultiTwo.UseVisualStyleBackColor = true;
            this.btMultiTwo.Click += new System.EventHandler(this.btMultiTwo_Click);
            // 
            // btUndo
            // 
            this.btUndo.Location = new System.Drawing.Point(271, 176);
            this.btUndo.Name = "btUndo";
            this.btUndo.Size = new System.Drawing.Size(100, 40);
            this.btUndo.TabIndex = 3;
            this.btUndo.Text = "Undo";
            this.btUndo.UseVisualStyleBackColor = true;
            this.btUndo.Click += new System.EventHandler(this.btUndo_Click);
            // 
            // lbCompNum
            // 
            this.lbCompNum.AutoSize = true;
            this.lbCompNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCompNum.Location = new System.Drawing.Point(25, 32);
            this.lbCompNum.Name = "lbCompNum";
            this.lbCompNum.Size = new System.Drawing.Size(57, 20);
            this.lbCompNum.TabIndex = 4;
            this.lbCompNum.Text = "label1";
            // 
            // lbUserNum
            // 
            this.lbUserNum.AutoSize = true;
            this.lbUserNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbUserNum.Location = new System.Drawing.Point(25, 83);
            this.lbUserNum.Name = "lbUserNum";
            this.lbUserNum.Size = new System.Drawing.Size(57, 20);
            this.lbUserNum.TabIndex = 5;
            this.lbUserNum.Text = "label2";
            // 
            // lbSteps
            // 
            this.lbSteps.AutoSize = true;
            this.lbSteps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSteps.Location = new System.Drawing.Point(25, 138);
            this.lbSteps.Name = "lbSteps";
            this.lbSteps.Size = new System.Drawing.Size(57, 20);
            this.lbSteps.TabIndex = 6;
            this.lbSteps.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.lbSteps);
            this.Controls.Add(this.lbUserNum);
            this.Controls.Add(this.lbCompNum);
            this.Controls.Add(this.btUndo);
            this.Controls.Add(this.btMultiTwo);
            this.Controls.Add(this.btPlusOne);
            this.Controls.Add(this.btNewGame);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 300);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Удвоитель";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btNewGame;
        private System.Windows.Forms.Button btPlusOne;
        private System.Windows.Forms.Button btMultiTwo;
        private System.Windows.Forms.Button btUndo;
        private System.Windows.Forms.Label lbCompNum;
        private System.Windows.Forms.Label lbUserNum;
        private System.Windows.Forms.Label lbSteps;
    }
}

