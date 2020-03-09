namespace MiagkovAS
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
            this.lbx = new System.Windows.Forms.ListBox();
            this.lbx_prop = new System.Windows.Forms.ListBox();
            this.btn_discover = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbx
            // 
            this.lbx.FormattingEnabled = true;
            this.lbx.Location = new System.Drawing.Point(12, 16);
            this.lbx.Name = "lbx";
            this.lbx.Size = new System.Drawing.Size(120, 355);
            this.lbx.TabIndex = 0;
            // 
            // lbx_prop
            // 
            this.lbx_prop.FormattingEnabled = true;
            this.lbx_prop.Location = new System.Drawing.Point(138, 16);
            this.lbx_prop.Name = "lbx_prop";
            this.lbx_prop.Size = new System.Drawing.Size(636, 355);
            this.lbx_prop.TabIndex = 1;
            this.lbx_prop.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btn_discover
            // 
            this.btn_discover.Location = new System.Drawing.Point(12, 395);
            this.btn_discover.Name = "btn_discover";
            this.btn_discover.Size = new System.Drawing.Size(120, 23);
            this.btn_discover.TabIndex = 2;
            this.btn_discover.Text = "Искать устройства";
            this.btn_discover.UseVisualStyleBackColor = true;
            this.btn_discover.Click += new System.EventHandler(this.btn_discover_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Внутр. информация";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_discover);
            this.Controls.Add(this.lbx_prop);
            this.Controls.Add(this.lbx);
            this.Name = "Form1";
            this.Text = "Discovery Bluetooth";
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox lbx;
		private System.Windows.Forms.ListBox lbx_prop;
		private System.Windows.Forms.Button btn_discover;
		private System.Windows.Forms.Button button1;
	}
}

