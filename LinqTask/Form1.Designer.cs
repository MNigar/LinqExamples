
namespace LinqTask
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
            this.btn_Task1 = new System.Windows.Forms.Button();
            this.btn_Task2 = new System.Windows.Forms.Button();
            this.rtb_Result = new System.Windows.Forms.RichTextBox();
            this.btn_Task3 = new System.Windows.Forms.Button();
            this.btn_Task4 = new System.Windows.Forms.Button();
            this.btn_Task5 = new System.Windows.Forms.Button();
            this.btn_Task6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Task1
            // 
            this.btn_Task1.Location = new System.Drawing.Point(25, 82);
            this.btn_Task1.Name = "btn_Task1";
            this.btn_Task1.Size = new System.Drawing.Size(162, 80);
            this.btn_Task1.TabIndex = 0;
            this.btn_Task1.Text = "Task1";
            this.btn_Task1.UseVisualStyleBackColor = true;
            this.btn_Task1.Click += new System.EventHandler(this.btn_Task1_Click);
            // 
            // btn_Task2
            // 
            this.btn_Task2.Location = new System.Drawing.Point(233, 82);
            this.btn_Task2.Name = "btn_Task2";
            this.btn_Task2.Size = new System.Drawing.Size(162, 80);
            this.btn_Task2.TabIndex = 1;
            this.btn_Task2.Text = "Task2";
            this.btn_Task2.UseVisualStyleBackColor = true;
            this.btn_Task2.Click += new System.EventHandler(this.btn_Task2_Click);
            // 
            // rtb_Result
            // 
            this.rtb_Result.Location = new System.Drawing.Point(25, 314);
            this.rtb_Result.Name = "rtb_Result";
            this.rtb_Result.Size = new System.Drawing.Size(534, 90);
            this.rtb_Result.TabIndex = 2;
            this.rtb_Result.Text = "";
            // 
            // btn_Task3
            // 
            this.btn_Task3.Location = new System.Drawing.Point(413, 82);
            this.btn_Task3.Name = "btn_Task3";
            this.btn_Task3.Size = new System.Drawing.Size(162, 80);
            this.btn_Task3.TabIndex = 3;
            this.btn_Task3.Text = "Task3";
            this.btn_Task3.UseVisualStyleBackColor = true;
            this.btn_Task3.Click += new System.EventHandler(this.btn_Task3_Click);
            // 
            // btn_Task4
            // 
            this.btn_Task4.Location = new System.Drawing.Point(591, 82);
            this.btn_Task4.Name = "btn_Task4";
            this.btn_Task4.Size = new System.Drawing.Size(162, 80);
            this.btn_Task4.TabIndex = 4;
            this.btn_Task4.Text = "Task4";
            this.btn_Task4.UseVisualStyleBackColor = true;
            this.btn_Task4.Click += new System.EventHandler(this.btn_Task4_Click);
            // 
            // btn_Task5
            // 
            this.btn_Task5.Location = new System.Drawing.Point(25, 183);
            this.btn_Task5.Name = "btn_Task5";
            this.btn_Task5.Size = new System.Drawing.Size(162, 80);
            this.btn_Task5.TabIndex = 5;
            this.btn_Task5.Text = "Task5";
            this.btn_Task5.UseVisualStyleBackColor = true;
            this.btn_Task5.Click += new System.EventHandler(this.btn_Task5_Click);
            // 
            // btn_Task6
            // 
            this.btn_Task6.Location = new System.Drawing.Point(319, 185);
            this.btn_Task6.Name = "btn_Task6";
            this.btn_Task6.Size = new System.Drawing.Size(162, 80);
            this.btn_Task6.TabIndex = 6;
            this.btn_Task6.Text = "Task6";
            this.btn_Task6.UseVisualStyleBackColor = true;
            this.btn_Task6.Click += new System.EventHandler(this.btn_Task6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Task6);
            this.Controls.Add(this.btn_Task5);
            this.Controls.Add(this.btn_Task4);
            this.Controls.Add(this.btn_Task3);
            this.Controls.Add(this.rtb_Result);
            this.Controls.Add(this.btn_Task2);
            this.Controls.Add(this.btn_Task1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Task1;
        private System.Windows.Forms.Button btn_Task2;
        private System.Windows.Forms.RichTextBox rtb_Result;
        private System.Windows.Forms.Button btn_Task3;
        private System.Windows.Forms.Button btn_Task4;
        private System.Windows.Forms.Button btn_Task5;
        private System.Windows.Forms.Button btn_Task6;
    }
}

