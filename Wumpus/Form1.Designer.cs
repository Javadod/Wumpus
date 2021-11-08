
namespace Wumpus
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
            this.tablero = new System.Windows.Forms.Panel();
            this.resetBtn = new System.Windows.Forms.Button();
            this.MoverBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tablero
            // 
            this.tablero.BackColor = System.Drawing.Color.Gray;
            this.tablero.Location = new System.Drawing.Point(10, 10);
            this.tablero.Name = "tablero";
            this.tablero.Size = new System.Drawing.Size(565, 522);
            this.tablero.TabIndex = 0;
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(639, 80);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(92, 44);
            this.resetBtn.TabIndex = 1;
            this.resetBtn.Text = "Reiniciar";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // MoverBtn
            // 
            this.MoverBtn.Location = new System.Drawing.Point(639, 204);
            this.MoverBtn.Name = "MoverBtn";
            this.MoverBtn.Size = new System.Drawing.Size(91, 41);
            this.MoverBtn.TabIndex = 2;
            this.MoverBtn.Text = "Mover";
            this.MoverBtn.UseVisualStyleBackColor = true;
            this.MoverBtn.Click += new System.EventHandler(this.MoverBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 553);
            this.Controls.Add(this.MoverBtn);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.tablero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Wumpus";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel tablero;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button MoverBtn;
    }
}

