namespace COMP123__S2019_Lesson8C
{
    partial class Lab08Form
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
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.agetextBox = new System.Windows.Forms.TextBox();
            this.namegroupBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Output_label = new System.Windows.Forms.Label();
            this.Sumitbutten = new System.Windows.Forms.Button();
            this.namegroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lab 8";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(109, 62);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(200, 22);
            this.NameTextBox.TabIndex = 2;
            // 
            // agetextBox
            // 
            this.agetextBox.Location = new System.Drawing.Point(109, 113);
            this.agetextBox.Name = "agetextBox";
            this.agetextBox.Size = new System.Drawing.Size(200, 22);
            this.agetextBox.TabIndex = 4;
            this.agetextBox.TextChanged += new System.EventHandler(this.agetextBox_TextChanged);
            // 
            // namegroupBox
            // 
            this.namegroupBox.BackColor = System.Drawing.Color.LightGray;
            this.namegroupBox.Controls.Add(this.label3);
            this.namegroupBox.Controls.Add(this.label2);
            this.namegroupBox.Controls.Add(this.Output_label);
            this.namegroupBox.Controls.Add(this.agetextBox);
            this.namegroupBox.Controls.Add(this.Sumitbutten);
            this.namegroupBox.Controls.Add(this.NameTextBox);
            this.namegroupBox.Location = new System.Drawing.Point(93, 79);
            this.namegroupBox.Name = "namegroupBox";
            this.namegroupBox.Size = new System.Drawing.Size(439, 198);
            this.namegroupBox.TabIndex = 5;
            this.namegroupBox.TabStop = false;
            this.namegroupBox.Text = "info";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Age";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name";
            // 
            // Output_label
            // 
            this.Output_label.AutoSize = true;
            this.Output_label.Location = new System.Drawing.Point(31, 154);
            this.Output_label.Name = "Output_label";
            this.Output_label.Size = new System.Drawing.Size(0, 17);
            this.Output_label.TabIndex = 7;
            // 
            // Sumitbutten
            // 
            this.Sumitbutten.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.Sumitbutten.Location = new System.Drawing.Point(336, 137);
            this.Sumitbutten.Name = "Sumitbutten";
            this.Sumitbutten.Size = new System.Drawing.Size(76, 34);
            this.Sumitbutten.TabIndex = 6;
            this.Sumitbutten.Text = "Sumit";
            this.Sumitbutten.UseVisualStyleBackColor = true;
            this.Sumitbutten.Click += new System.EventHandler(this.Sumitbutten_Click);
            // 
            // Lab08Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(622, 433);
            this.Controls.Add(this.namegroupBox);
            this.Controls.Add(this.label1);
            this.Name = "Lab08Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab8form";
            this.Load += new System.EventHandler(this.Lab8form_Load);
            this.namegroupBox.ResumeLayout(false);
            this.namegroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox agetextBox;
        private System.Windows.Forms.GroupBox namegroupBox;
        private System.Windows.Forms.Button Sumitbutten;
        private System.Windows.Forms.Label Output_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

