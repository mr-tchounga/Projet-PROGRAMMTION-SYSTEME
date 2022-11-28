namespace PROG_SYS.View.Material
{
    partial class Material_view
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
            this.label1 = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_totalQty = new System.Windows.Forms.Label();
            this.label_qtyAvailable = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.totalQty = new System.Windows.Forms.TextBox();
            this.qtyAvailable = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(56, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Material";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.Location = new System.Drawing.Point(57, 107);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(59, 22);
            this.label_name.TabIndex = 1;
            this.label_name.Text = "Name";
            // 
            // label_totalQty
            // 
            this.label_totalQty.AutoSize = true;
            this.label_totalQty.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_totalQty.Location = new System.Drawing.Point(57, 155);
            this.label_totalQty.Name = "label_totalQty";
            this.label_totalQty.Size = new System.Drawing.Size(131, 22);
            this.label_totalQty.TabIndex = 2;
            this.label_totalQty.Text = "Total Quantity";
            // 
            // label_qtyAvailable
            // 
            this.label_qtyAvailable.AutoSize = true;
            this.label_qtyAvailable.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_qtyAvailable.Location = new System.Drawing.Point(57, 205);
            this.label_qtyAvailable.Name = "label_qtyAvailable";
            this.label_qtyAvailable.Size = new System.Drawing.Size(165, 22);
            this.label_qtyAvailable.TabIndex = 3;
            this.label_qtyAvailable.Text = "Quantity Available";
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(264, 108);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(303, 30);
            this.name.TabIndex = 4;
            // 
            // totalQty
            // 
            this.totalQty.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalQty.Location = new System.Drawing.Point(264, 156);
            this.totalQty.Name = "totalQty";
            this.totalQty.Size = new System.Drawing.Size(100, 30);
            this.totalQty.TabIndex = 5;
            // 
            // qtyAvailable
            // 
            this.qtyAvailable.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtyAvailable.Location = new System.Drawing.Point(264, 206);
            this.qtyAvailable.Name = "qtyAvailable";
            this.qtyAvailable.Size = new System.Drawing.Size(100, 30);
            this.qtyAvailable.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(61, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 45);
            this.button1.TabIndex = 7;
            this.button1.Text = "Validate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(633, 356);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.qtyAvailable);
            this.Controls.Add(this.totalQty);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label_qtyAvailable);
            this.Controls.Add(this.label_totalQty);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Material";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_totalQty;
        private System.Windows.Forms.Label label_qtyAvailable;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox totalQty;
        private System.Windows.Forms.TextBox qtyAvailable;
        private System.Windows.Forms.Button button1;
    }
}