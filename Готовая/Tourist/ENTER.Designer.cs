namespace Tourist
{
    partial class ENTER
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
            this.ENTERBUTTON = new System.Windows.Forms.Button();
            this.NAMEENTER = new System.Windows.Forms.TextBox();
            this.PASSWORDENTER = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ENTERBUTTON
            // 
            this.ENTERBUTTON.BackColor = System.Drawing.Color.Transparent;
            this.ENTERBUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ENTERBUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ENTERBUTTON.Location = new System.Drawing.Point(27, 120);
            this.ENTERBUTTON.Name = "ENTERBUTTON";
            this.ENTERBUTTON.Size = new System.Drawing.Size(230, 61);
            this.ENTERBUTTON.TabIndex = 0;
            this.ENTERBUTTON.Text = "Вход";
            this.ENTERBUTTON.UseVisualStyleBackColor = false;
            this.ENTERBUTTON.Click += new System.EventHandler(this.ENTERBUTTON_Click);
            // 
            // NAMEENTER
            // 
            this.NAMEENTER.Location = new System.Drawing.Point(27, 51);
            this.NAMEENTER.Name = "NAMEENTER";
            this.NAMEENTER.Size = new System.Drawing.Size(230, 20);
            this.NAMEENTER.TabIndex = 1;
            this.NAMEENTER.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NAMEENTER.TextChanged += new System.EventHandler(this.NAMEENTER_TextChanged);
            // 
            // PASSWORDENTER
            // 
            this.PASSWORDENTER.Location = new System.Drawing.Point(27, 94);
            this.PASSWORDENTER.Name = "PASSWORDENTER";
            this.PASSWORDENTER.Size = new System.Drawing.Size(230, 20);
            this.PASSWORDENTER.TabIndex = 2;
            this.PASSWORDENTER.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PASSWORDENTER.TextChanged += new System.EventHandler(this.PASSWORDENTER_TextChanged);
            this.PASSWORDENTER.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PASSWORDENTER_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(24, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(24, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль";
            // 
            // ENTER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.BackgroundImage = global::Tourist.Properties.Resources.image_13;
            this.ClientSize = new System.Drawing.Size(278, 227);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PASSWORDENTER);
            this.Controls.Add(this.NAMEENTER);
            this.Controls.Add(this.ENTERBUTTON);
            this.Name = "ENTER";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход";
            this.Load += new System.EventHandler(this.ENTER_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ENTERBUTTON;
        private System.Windows.Forms.TextBox NAMEENTER;
        private System.Windows.Forms.TextBox PASSWORDENTER;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

