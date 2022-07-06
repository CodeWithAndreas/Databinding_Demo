namespace Databinding_Demo
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.cb_Person = new System.Windows.Forms.ComboBox();
            this.gb_Anzeige = new System.Windows.Forms.GroupBox();
            this.rb_anzeige2 = new System.Windows.Forms.RadioButton();
            this.rb_anzeige1 = new System.Windows.Forms.RadioButton();
            this.tb_vorname = new System.Windows.Forms.TextBox();
            this.tb_nachname = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.gb_Anzeige.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_Person
            // 
            this.cb_Person.FormattingEnabled = true;
            this.cb_Person.Location = new System.Drawing.Point(44, 33);
            this.cb_Person.Name = "cb_Person";
            this.cb_Person.Size = new System.Drawing.Size(350, 21);
            this.cb_Person.TabIndex = 0;
            this.cb_Person.SelectedIndexChanged += new System.EventHandler(this.cb_Person_SelectedIndexChanged);
            // 
            // gb_Anzeige
            // 
            this.gb_Anzeige.Controls.Add(this.rb_anzeige2);
            this.gb_Anzeige.Controls.Add(this.rb_anzeige1);
            this.gb_Anzeige.Location = new System.Drawing.Point(44, 294);
            this.gb_Anzeige.Name = "gb_Anzeige";
            this.gb_Anzeige.Size = new System.Drawing.Size(200, 74);
            this.gb_Anzeige.TabIndex = 1;
            this.gb_Anzeige.TabStop = false;
            this.gb_Anzeige.Text = "Anzeige";
            // 
            // rb_anzeige2
            // 
            this.rb_anzeige2.AutoSize = true;
            this.rb_anzeige2.Location = new System.Drawing.Point(7, 44);
            this.rb_anzeige2.Name = "rb_anzeige2";
            this.rb_anzeige2.Size = new System.Drawing.Size(122, 17);
            this.rb_anzeige2.TabIndex = 1;
            this.rb_anzeige2.Text = "Vorname Nachname";
            this.rb_anzeige2.UseVisualStyleBackColor = true;
            this.rb_anzeige2.CheckedChanged += new System.EventHandler(this.rb_anzeige2_CheckedChanged);
            // 
            // rb_anzeige1
            // 
            this.rb_anzeige1.AutoSize = true;
            this.rb_anzeige1.Checked = true;
            this.rb_anzeige1.Location = new System.Drawing.Point(7, 20);
            this.rb_anzeige1.Name = "rb_anzeige1";
            this.rb_anzeige1.Size = new System.Drawing.Size(122, 17);
            this.rb_anzeige1.TabIndex = 0;
            this.rb_anzeige1.TabStop = true;
            this.rb_anzeige1.Text = "Nachname Vorname";
            this.rb_anzeige1.UseVisualStyleBackColor = true;
            this.rb_anzeige1.CheckedChanged += new System.EventHandler(this.rb_anzeige1_CheckedChanged);
            // 
            // tb_vorname
            // 
            this.tb_vorname.Location = new System.Drawing.Point(477, 34);
            this.tb_vorname.Name = "tb_vorname";
            this.tb_vorname.ReadOnly = true;
            this.tb_vorname.Size = new System.Drawing.Size(261, 20);
            this.tb_vorname.TabIndex = 2;
            // 
            // tb_nachname
            // 
            this.tb_nachname.Location = new System.Drawing.Point(477, 60);
            this.tb_nachname.Name = "tb_nachname";
            this.tb_nachname.ReadOnly = true;
            this.tb_nachname.Size = new System.Drawing.Size(261, 20);
            this.tb_nachname.TabIndex = 2;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(477, 86);
            this.tb_email.Name = "tb_email";
            this.tb_email.ReadOnly = true;
            this.tb_email.Size = new System.Drawing.Size(261, 20);
            this.tb_email.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_nachname);
            this.Controls.Add(this.tb_vorname);
            this.Controls.Add(this.gb_Anzeige);
            this.Controls.Add(this.cb_Person);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gb_Anzeige.ResumeLayout(false);
            this.gb_Anzeige.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Person;
        private System.Windows.Forms.GroupBox gb_Anzeige;
        private System.Windows.Forms.RadioButton rb_anzeige2;
        private System.Windows.Forms.RadioButton rb_anzeige1;
        private System.Windows.Forms.TextBox tb_vorname;
        private System.Windows.Forms.TextBox tb_nachname;
        private System.Windows.Forms.TextBox tb_email;
    }
}

