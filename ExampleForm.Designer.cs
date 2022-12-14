namespace QRCoderExample
{
    partial class ExampleForm
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
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.pbExample = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbExample)).BeginInit();
            this.SuspendLayout();
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(14, 14);
            this.urlTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(422, 23);
            this.urlTextBox.TabIndex = 0;
            this.urlTextBox.Text = "https://github.com/codebude/QRCoder/";
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(14, 44);
            this.generateButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(88, 27);
            this.generateButton.TabIndex = 1;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbExample
            // 
            this.pbExample.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbExample.Location = new System.Drawing.Point(14, 77);
            this.pbExample.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbExample.Name = "pbExample";
            this.pbExample.Size = new System.Drawing.Size(422, 422);
            this.pbExample.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbExample.TabIndex = 2;
            this.pbExample.TabStop = false;
            // 
            // ExampleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 513);
            this.Controls.Add(this.pbExample);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.urlTextBox);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExampleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QRCoder Example";
            ((System.ComponentModel.ISupportInitialize)(this.pbExample)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.PictureBox pbExample;
    }
}

