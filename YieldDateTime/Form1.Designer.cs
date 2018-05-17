namespace YieldDateTime
{
    partial class FormYieldDateTime
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
            this.textBoxDays = new System.Windows.Forms.TextBox();
            this.richTextBoxResultDays = new System.Windows.Forms.RichTextBox();
            this.buttonGetDays = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxDays
            // 
            this.textBoxDays.Location = new System.Drawing.Point(66, 46);
            this.textBoxDays.Name = "textBoxDays";
            this.textBoxDays.Size = new System.Drawing.Size(100, 20);
            this.textBoxDays.TabIndex = 0;
            // 
            // richTextBoxResultDays
            // 
            this.richTextBoxResultDays.Location = new System.Drawing.Point(12, 101);
            this.richTextBoxResultDays.Name = "richTextBoxResultDays";
            this.richTextBoxResultDays.Size = new System.Drawing.Size(509, 279);
            this.richTextBoxResultDays.TabIndex = 1;
            this.richTextBoxResultDays.Text = "";
            // 
            // buttonGetDays
            // 
            this.buttonGetDays.Location = new System.Drawing.Point(172, 44);
            this.buttonGetDays.Name = "buttonGetDays";
            this.buttonGetDays.Size = new System.Drawing.Size(75, 23);
            this.buttonGetDays.TabIndex = 2;
            this.buttonGetDays.Text = "Show Days";
            this.buttonGetDays.UseVisualStyleBackColor = true;
            this.buttonGetDays.Click += new System.EventHandler(this.buttonGetDays_Click);
            // 
            // FormYieldDateTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 407);
            this.Controls.Add(this.buttonGetDays);
            this.Controls.Add(this.richTextBoxResultDays);
            this.Controls.Add(this.textBoxDays);
            this.Name = "FormYieldDateTime";
            this.Text = "Main Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDays;
        private System.Windows.Forms.RichTextBox richTextBoxResultDays;
        private System.Windows.Forms.Button buttonGetDays;
    }
}

