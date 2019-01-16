namespace TP_Examenation
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
            this.CatBtn = new System.Windows.Forms.Button();
            this.DogBtn = new System.Windows.Forms.Button();
            this.textBoxForAnim = new System.Windows.Forms.TextBox();
            this.PoliBtn = new System.Windows.Forms.Button();
            this.buttonShit = new System.Windows.Forms.Button();
            this.EventBtn = new System.Windows.Forms.Button();
            this.Exceptions = new System.Windows.Forms.Button();
            this.mimiCompare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CatBtn
            // 
            this.CatBtn.Location = new System.Drawing.Point(568, 186);
            this.CatBtn.Name = "CatBtn";
            this.CatBtn.Size = new System.Drawing.Size(94, 50);
            this.CatBtn.TabIndex = 0;
            this.CatBtn.Text = "Cat";
            this.CatBtn.UseVisualStyleBackColor = true;
            this.CatBtn.Click += new System.EventHandler(this.CatBtn_Click);
            // 
            // DogBtn
            // 
            this.DogBtn.Location = new System.Drawing.Point(79, 186);
            this.DogBtn.Name = "DogBtn";
            this.DogBtn.Size = new System.Drawing.Size(91, 48);
            this.DogBtn.TabIndex = 2;
            this.DogBtn.Text = "Dog";
            this.DogBtn.UseVisualStyleBackColor = true;
            this.DogBtn.Click += new System.EventHandler(this.DogBtn_Click);
            // 
            // textBoxForAnim
            // 
            this.textBoxForAnim.Location = new System.Drawing.Point(277, 200);
            this.textBoxForAnim.Name = "textBoxForAnim";
            this.textBoxForAnim.Size = new System.Drawing.Size(254, 22);
            this.textBoxForAnim.TabIndex = 3;
            // 
            // PoliBtn
            // 
            this.PoliBtn.Location = new System.Drawing.Point(290, 335);
            this.PoliBtn.Name = "PoliBtn";
            this.PoliBtn.Size = new System.Drawing.Size(75, 23);
            this.PoliBtn.TabIndex = 4;
            this.PoliBtn.Text = "Poli";
            this.PoliBtn.UseVisualStyleBackColor = true;
            this.PoliBtn.Click += new System.EventHandler(this.PoliBtn_Click);
            // 
            // buttonShit
            // 
            this.buttonShit.Location = new System.Drawing.Point(79, 335);
            this.buttonShit.Name = "buttonShit";
            this.buttonShit.Size = new System.Drawing.Size(124, 23);
            this.buttonShit.TabIndex = 5;
            this.buttonShit.Text = "List of classes";
            this.buttonShit.UseVisualStyleBackColor = true;
            this.buttonShit.Click += new System.EventHandler(this.buttonShit_Click);
            // 
            // EventBtn
            // 
            this.EventBtn.Location = new System.Drawing.Point(408, 335);
            this.EventBtn.Name = "EventBtn";
            this.EventBtn.Size = new System.Drawing.Size(74, 23);
            this.EventBtn.TabIndex = 6;
            this.EventBtn.Text = "Event";
            this.EventBtn.UseVisualStyleBackColor = true;
            this.EventBtn.Click += new System.EventHandler(this.EventBtn_Click);
            // 
            // Exceptions
            // 
            this.Exceptions.Location = new System.Drawing.Point(654, 292);
            this.Exceptions.Name = "Exceptions";
            this.Exceptions.Size = new System.Drawing.Size(124, 36);
            this.Exceptions.TabIndex = 7;
            this.Exceptions.Text = "Exceptions";
            this.Exceptions.UseVisualStyleBackColor = true;
            this.Exceptions.Click += new System.EventHandler(this.Exceptions_Click);
            // 
            // mimiCompare
            // 
            this.mimiCompare.Location = new System.Drawing.Point(282, 28);
            this.mimiCompare.Name = "mimiCompare";
            this.mimiCompare.Size = new System.Drawing.Size(249, 48);
            this.mimiCompare.TabIndex = 9;
            this.mimiCompare.Text = "Кто милее? Кошки или Собаки?";
            this.mimiCompare.UseVisualStyleBackColor = true;
            this.mimiCompare.Click += new System.EventHandler(this.mimiCompare_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mimiCompare);
            this.Controls.Add(this.Exceptions);
            this.Controls.Add(this.EventBtn);
            this.Controls.Add(this.buttonShit);
            this.Controls.Add(this.PoliBtn);
            this.Controls.Add(this.textBoxForAnim);
            this.Controls.Add(this.DogBtn);
            this.Controls.Add(this.CatBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CatBtn;
        private System.Windows.Forms.Button DogBtn;
        private System.Windows.Forms.TextBox textBoxForAnim;
        private System.Windows.Forms.Button PoliBtn;
        private System.Windows.Forms.Button buttonShit;
        private System.Windows.Forms.Button EventBtn;
        private System.Windows.Forms.Button Exceptions;
        private System.Windows.Forms.Button mimiCompare;
    }
}

