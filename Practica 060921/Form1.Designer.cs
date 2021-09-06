
namespace Practica_060921
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
            this.Click = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Click
            // 
            this.Click.Location = new System.Drawing.Point(72, 152);
            this.Click.Name = "Click";
            this.Click.Size = new System.Drawing.Size(75, 23);
            this.Click.TabIndex = 0;
            this.Click.Text = "Clic";
            this.Click.UseVisualStyleBackColor = true;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Items.AddRange(new object[] {
            "1st data"});
            this.listBox.Location = new System.Drawing.Point(269, 137);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(164, 160);
            this.listBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 404);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.Click);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Click;
        private System.Windows.Forms.ListBox listBox;
    }
}

