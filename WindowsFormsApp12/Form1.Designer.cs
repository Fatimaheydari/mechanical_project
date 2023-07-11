namespace WindowsFormsApp12
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.txtb_price_update = new System.Windows.Forms.TextBox();
            this.txtb_repair_update = new System.Windows.Forms.TextBox();
            this.txtb_phone_update = new System.Windows.Forms.TextBox();
            this.txtb_name_update = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 69);
            this.button1.TabIndex = 0;
            this.button1.Text = "DELETE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(59, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(113, 22);
            this.textBox1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(16, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 404);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DELETE";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(52, 304);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 67);
            this.button2.TabIndex = 3;
            this.button2.Text = "UPDATE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.phone);
            this.groupBox2.Controls.Add(this.name);
            this.groupBox2.Controls.Add(this.txtb_price_update);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.txtb_repair_update);
            this.groupBox2.Controls.Add(this.txtb_phone_update);
            this.groupBox2.Controls.Add(this.txtb_name_update);
            this.groupBox2.Location = new System.Drawing.Point(279, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 395);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "UPDATE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "repair";
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Location = new System.Drawing.Point(86, 119);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(45, 16);
            this.phone.TabIndex = 5;
            this.phone.Text = "phone";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(86, 46);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(41, 16);
            this.name.TabIndex = 4;
            this.name.Text = "name";
            // 
            // txtb_price_update
            // 
            this.txtb_price_update.Location = new System.Drawing.Point(62, 233);
            this.txtb_price_update.Name = "txtb_price_update";
            this.txtb_price_update.Size = new System.Drawing.Size(100, 22);
            this.txtb_price_update.TabIndex = 3;
            // 
            // txtb_repair_update
            // 
            this.txtb_repair_update.Location = new System.Drawing.Point(62, 162);
            this.txtb_repair_update.Name = "txtb_repair_update";
            this.txtb_repair_update.Size = new System.Drawing.Size(100, 22);
            this.txtb_repair_update.TabIndex = 2;
            // 
            // txtb_phone_update
            // 
            this.txtb_phone_update.Location = new System.Drawing.Point(62, 94);
            this.txtb_phone_update.Name = "txtb_phone_update";
            this.txtb_phone_update.Size = new System.Drawing.Size(100, 22);
            this.txtb_phone_update.TabIndex = 1;
            // 
            // txtb_name_update
            // 
            this.txtb_name_update.Location = new System.Drawing.Point(62, 21);
            this.txtb_name_update.Name = "txtb_name_update";
            this.txtb_name_update.Size = new System.Drawing.Size(100, 22);
            this.txtb_name_update.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox txtb_price_update;
        private System.Windows.Forms.TextBox txtb_repair_update;
        private System.Windows.Forms.TextBox txtb_phone_update;
        private System.Windows.Forms.TextBox txtb_name_update;
    }
}

