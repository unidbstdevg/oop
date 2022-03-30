
namespace my_rect
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
            this.panel1 = new System.Windows.Forms.Panel();

            this.rb_select = new System.Windows.Forms.RadioButton();
            this.rb_create = new System.Windows.Forms.RadioButton();
            this.list_figures = new System.Windows.Forms.ComboBox();

            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(678, 426);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // rb_select
            // 
            this.rb_select.AutoSize = true;
            this.rb_select.Location = new System.Drawing.Point(713, 10);
            this.rb_select.Name = "rb_select";
            this.rb_select.Size = new System.Drawing.Size(69, 21);
            this.rb_select.TabIndex = 1;
            this.rb_select.Text = "Select";
            this.rb_select.UseVisualStyleBackColor = true;
            this.rb_select.CheckedChanged += new System.EventHandler(this.mode_CheckedChanged);
            // 
            // rb_create
            // 
            this.rb_create.AutoSize = true;
            this.rb_create.Location = new System.Drawing.Point(713, 30);
            this.rb_create.Name = "rb_create";
            this.rb_create.Size = new System.Drawing.Size(69, 21);
            this.rb_create.TabIndex = 1;
            this.rb_create.Text = "Create";
            this.rb_create.UseVisualStyleBackColor = true;
            this.rb_create.CheckedChanged += new System.EventHandler(this.mode_CheckedChanged);
            // 
            // list_figures
            // 
            this.list_figures.AutoSize = true;
            this.list_figures.Location = new System.Drawing.Point(713, 60);
            /* this.list_figures.Name = "rb_select"; */
            this.list_figures.Size = new System.Drawing.Size(69, 21);
            this.list_figures.TabIndex = 1;
            this.list_figures.Text = "Figure";
            /* this.list_figures.UseVisualStyleBackColor = true; */
            this.list_figures.Items.Add("Ellipse");
            this.list_figures.Items.Add("Rectangle");
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(713, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(713, 120);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Greenify";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rb_select);
            this.Controls.Add(this.rb_create);
            this.Controls.Add(this.list_figures);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton rb_select;
        private System.Windows.Forms.RadioButton rb_create;
        private System.Windows.Forms.ComboBox list_figures;
    }
}

