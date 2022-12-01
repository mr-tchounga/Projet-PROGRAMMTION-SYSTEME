namespace @interface
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.display = new System.Windows.Forms.Button();
            this.find = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.restauDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Validate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.restauDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.SystemColors.ControlDark;
            this.display.ForeColor = System.Drawing.Color.Snow;
            this.display.Location = new System.Drawing.Point(291, 215);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(151, 69);
            this.display.TabIndex = 0;
            this.display.Text = "DISPLAY";
            this.display.UseVisualStyleBackColor = false;
            this.display.Click += new System.EventHandler(this.button1_Click);
            // 
            // find
            // 
            this.find.BackColor = System.Drawing.SystemColors.ControlDark;
            this.find.ForeColor = System.Drawing.Color.Snow;
            this.find.Location = new System.Drawing.Point(58, 215);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(151, 69);
            this.find.TabIndex = 1;
            this.find.Text = "FIND ";
            this.find.UseVisualStyleBackColor = false;
            this.find.Click += new System.EventHandler(this.button2_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.SystemColors.ControlDark;
            this.add.ForeColor = System.Drawing.Color.Snow;
            this.add.Location = new System.Drawing.Point(58, 336);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(151, 69);
            this.add.TabIndex = 2;
            this.add.Text = "ADD";
            this.add.UseVisualStyleBackColor = false;
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.edit.ForeColor = System.Drawing.Color.Snow;
            this.edit.Location = new System.Drawing.Point(521, 215);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(151, 69);
            this.edit.TabIndex = 3;
            this.edit.Text = "EDIT";
            this.edit.UseVisualStyleBackColor = false;
            this.edit.Click += new System.EventHandler(this.button4_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.SystemColors.ControlDark;
            this.delete.ForeColor = System.Drawing.Color.Snow;
            this.delete.Location = new System.Drawing.Point(521, 336);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(151, 69);
            this.delete.TabIndex = 4;
            this.delete.Text = "DELETE";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.button5_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.restauDataSetBindingSource;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(345, 146);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(190, 24);
            this.comboBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "élément à gérer :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(567, 49);
            this.label2.TabIndex = 7;
            this.label2.Text = "Gestion de la base de données";
            // 
            // Validate
            // 
            this.Validate.BackColor = System.Drawing.Color.Red;
            this.Validate.ForeColor = System.Drawing.Color.Snow;
            this.Validate.Location = new System.Drawing.Point(291, 336);
            this.Validate.Name = "Validate";
            this.Validate.Size = new System.Drawing.Size(151, 69);
            this.Validate.TabIndex = 8;
            this.Validate.Text = "VALIDATE  ";
            this.Validate.UseVisualStyleBackColor = false;
            this.Validate.Click += new System.EventHandler(this.Validate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Validate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.Controls.Add(this.find);
            this.Controls.Add(this.display);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restauDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button display;
        private System.Windows.Forms.Button find;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Validate;
        private System.Windows.Forms.BindingSource restauDataSetBindingSource;
    }
}

