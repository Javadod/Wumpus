
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
            this.sentidosLbl = new System.Windows.Forms.Label();
            this.hedorTB = new System.Windows.Forms.TextBox();
            this.brisaTB = new System.Windows.Forms.TextBox();
            this.brilloTB = new System.Windows.Forms.TextBox();
            this.gritoTB = new System.Windows.Forms.TextBox();
            this.flechaTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Map1Btn = new System.Windows.Forms.Button();
            this.Map2Btn = new System.Windows.Forms.Button();
            this.Map3Btn = new System.Windows.Forms.Button();
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
            this.resetBtn.Location = new System.Drawing.Point(586, 255);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(92, 44);
            this.resetBtn.TabIndex = 1;
            this.resetBtn.Text = "Reiniciar";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // MoverBtn
            // 
            this.MoverBtn.Location = new System.Drawing.Point(695, 258);
            this.MoverBtn.Name = "MoverBtn";
            this.MoverBtn.Size = new System.Drawing.Size(91, 41);
            this.MoverBtn.TabIndex = 2;
            this.MoverBtn.Text = "Mover";
            this.MoverBtn.UseVisualStyleBackColor = true;
            this.MoverBtn.Click += new System.EventHandler(this.MoverBtn_Click);
            // 
            // sentidosLbl
            // 
            this.sentidosLbl.AutoSize = true;
            this.sentidosLbl.Location = new System.Drawing.Point(624, 311);
            this.sentidosLbl.Name = "sentidosLbl";
            this.sentidosLbl.Size = new System.Drawing.Size(63, 17);
            this.sentidosLbl.TabIndex = 3;
            this.sentidosLbl.Text = "Sentidos";
            // 
            // hedorTB
            // 
            this.hedorTB.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.hedorTB.Location = new System.Drawing.Point(701, 349);
            this.hedorTB.Name = "hedorTB";
            this.hedorTB.ReadOnly = true;
            this.hedorTB.Size = new System.Drawing.Size(85, 22);
            this.hedorTB.TabIndex = 4;
            this.hedorTB.Text = "Nada";
            // 
            // brisaTB
            // 
            this.brisaTB.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.brisaTB.Location = new System.Drawing.Point(701, 377);
            this.brisaTB.Name = "brisaTB";
            this.brisaTB.ReadOnly = true;
            this.brisaTB.Size = new System.Drawing.Size(85, 22);
            this.brisaTB.TabIndex = 5;
            this.brisaTB.Text = "Nada";
            // 
            // brilloTB
            // 
            this.brilloTB.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.brilloTB.Location = new System.Drawing.Point(701, 405);
            this.brilloTB.Name = "brilloTB";
            this.brilloTB.ReadOnly = true;
            this.brilloTB.Size = new System.Drawing.Size(85, 22);
            this.brilloTB.TabIndex = 6;
            this.brilloTB.Text = "Nada";
            // 
            // gritoTB
            // 
            this.gritoTB.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gritoTB.Location = new System.Drawing.Point(701, 433);
            this.gritoTB.Name = "gritoTB";
            this.gritoTB.ReadOnly = true;
            this.gritoTB.Size = new System.Drawing.Size(85, 22);
            this.gritoTB.TabIndex = 7;
            this.gritoTB.Text = "No";
            // 
            // flechaTB
            // 
            this.flechaTB.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.flechaTB.Location = new System.Drawing.Point(701, 492);
            this.flechaTB.Name = "flechaTB";
            this.flechaTB.ReadOnly = true;
            this.flechaTB.Size = new System.Drawing.Size(85, 22);
            this.flechaTB.TabIndex = 8;
            this.flechaTB.Text = "Sí";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(624, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Hedor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(624, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Brisa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(624, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Brillo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(624, 433);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Grito:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(624, 492);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Flecha:";
            // 
            // Map1Btn
            // 
            this.Map1Btn.Location = new System.Drawing.Point(627, 42);
            this.Map1Btn.Name = "Map1Btn";
            this.Map1Btn.Size = new System.Drawing.Size(125, 46);
            this.Map1Btn.TabIndex = 14;
            this.Map1Btn.Text = "Mapa 1";
            this.Map1Btn.UseVisualStyleBackColor = true;
            this.Map1Btn.Click += new System.EventHandler(this.Map1Btn_Click);
            // 
            // Map2Btn
            // 
            this.Map2Btn.Location = new System.Drawing.Point(627, 111);
            this.Map2Btn.Name = "Map2Btn";
            this.Map2Btn.Size = new System.Drawing.Size(125, 46);
            this.Map2Btn.TabIndex = 15;
            this.Map2Btn.Text = "Mapa 2";
            this.Map2Btn.UseVisualStyleBackColor = true;
            this.Map2Btn.Click += new System.EventHandler(this.Map2Btn_Click);
            // 
            // Map3Btn
            // 
            this.Map3Btn.Location = new System.Drawing.Point(627, 177);
            this.Map3Btn.Name = "Map3Btn";
            this.Map3Btn.Size = new System.Drawing.Size(125, 46);
            this.Map3Btn.TabIndex = 16;
            this.Map3Btn.Text = "Mapa 3";
            this.Map3Btn.UseVisualStyleBackColor = true;
            this.Map3Btn.Click += new System.EventHandler(this.Map3Btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 553);
            this.Controls.Add(this.Map3Btn);
            this.Controls.Add(this.Map2Btn);
            this.Controls.Add(this.Map1Btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flechaTB);
            this.Controls.Add(this.gritoTB);
            this.Controls.Add(this.brilloTB);
            this.Controls.Add(this.brisaTB);
            this.Controls.Add(this.hedorTB);
            this.Controls.Add(this.sentidosLbl);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel tablero;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button MoverBtn;
        private System.Windows.Forms.Label sentidosLbl;
        private System.Windows.Forms.TextBox hedorTB;
        private System.Windows.Forms.TextBox brisaTB;
        private System.Windows.Forms.TextBox brilloTB;
        private System.Windows.Forms.TextBox gritoTB;
        private System.Windows.Forms.TextBox flechaTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Map1Btn;
        private System.Windows.Forms.Button Map2Btn;
        private System.Windows.Forms.Button Map3Btn;
    }
}

