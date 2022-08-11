namespace DesktopClient
{
    partial class MainParent
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainParent));
            this.btnPovecaj = new System.Windows.Forms.Button();
            this.btnSmanji = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblKontrolnaTemperatura = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUpali = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblTemperatura = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPovecaj
            // 
            this.btnPovecaj.BackColor = System.Drawing.Color.Transparent;
            this.btnPovecaj.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPovecaj.BackgroundImage")));
            this.btnPovecaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPovecaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPovecaj.FlatAppearance.BorderSize = 0;
            this.btnPovecaj.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPovecaj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPovecaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPovecaj.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPovecaj.Location = new System.Drawing.Point(61, 3);
            this.btnPovecaj.Name = "btnPovecaj";
            this.btnPovecaj.Size = new System.Drawing.Size(52, 50);
            this.btnPovecaj.TabIndex = 0;
            this.btnPovecaj.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPovecaj.UseVisualStyleBackColor = false;
            this.btnPovecaj.Click += new System.EventHandler(this.PovecajTemperaturu);
            // 
            // btnSmanji
            // 
            this.btnSmanji.BackColor = System.Drawing.Color.Transparent;
            this.btnSmanji.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSmanji.BackgroundImage")));
            this.btnSmanji.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSmanji.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSmanji.FlatAppearance.BorderSize = 0;
            this.btnSmanji.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSmanji.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSmanji.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSmanji.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSmanji.Location = new System.Drawing.Point(3, 3);
            this.btnSmanji.Name = "btnSmanji";
            this.btnSmanji.Size = new System.Drawing.Size(52, 48);
            this.btnSmanji.TabIndex = 1;
            this.btnSmanji.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSmanji.UseVisualStyleBackColor = false;
            this.btnSmanji.Click += new System.EventHandler(this.SmanjiTemperaturu);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblKontrolnaTemperatura);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(621, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 304);
            this.panel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(21, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 58);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kontrola\r\nTemperature";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKontrolnaTemperatura
            // 
            this.lblKontrolnaTemperatura.AutoSize = true;
            this.lblKontrolnaTemperatura.Font = new System.Drawing.Font("OCR A Extended", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKontrolnaTemperatura.Location = new System.Drawing.Point(51, 118);
            this.lblKontrolnaTemperatura.Name = "lblKontrolnaTemperatura";
            this.lblKontrolnaTemperatura.Size = new System.Drawing.Size(47, 62);
            this.lblKontrolnaTemperatura.TabIndex = 3;
            this.lblKontrolnaTemperatura.Text = "x";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel2.Controls.Add(this.btnSmanji, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnPovecaj, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnPotvrdi, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(20, 219);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(190, 56);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.BackColor = System.Drawing.Color.Transparent;
            this.btnPotvrdi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPotvrdi.BackgroundImage")));
            this.btnPotvrdi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPotvrdi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPotvrdi.FlatAppearance.BorderSize = 0;
            this.btnPotvrdi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPotvrdi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPotvrdi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPotvrdi.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPotvrdi.ForeColor = System.Drawing.Color.Black;
            this.btnPotvrdi.Location = new System.Drawing.Point(136, 3);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(51, 50);
            this.btnPotvrdi.TabIndex = 5;
            this.btnPotvrdi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPotvrdi.UseVisualStyleBackColor = false;
            this.btnPotvrdi.Click += new System.EventHandler(this.PotvrdiPromjenuTemperature);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnUpali);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(98, 132);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(232, 304);
            this.panel2.TabIndex = 4;
            // 
            // btnUpali
            // 
            this.btnUpali.BackColor = System.Drawing.Color.Transparent;
            this.btnUpali.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpali.BackgroundImage")));
            this.btnUpali.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpali.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpali.FlatAppearance.BorderSize = 0;
            this.btnUpali.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnUpali.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnUpali.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpali.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpali.ForeColor = System.Drawing.Color.Black;
            this.btnUpali.Location = new System.Drawing.Point(65, 118);
            this.btnUpali.Name = "btnUpali";
            this.btnUpali.Size = new System.Drawing.Size(100, 93);
            this.btnUpali.TabIndex = 0;
            this.btnUpali.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpali.UseVisualStyleBackColor = false;
            this.btnUpali.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(45, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 58);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kontrola \r\nStanja\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.lblTemperatura);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(336, 132);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(279, 304);
            this.panel3.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(40, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 58);
            this.label2.TabIndex = 4;
            this.label2.Text = "Temperatura\r\nProstorije";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Location = new System.Drawing.Point(97, 222);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(77, 65);
            this.panel5.TabIndex = 6;
            // 
            // lblTemperatura
            // 
            this.lblTemperatura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTemperatura.AutoSize = true;
            this.lblTemperatura.Font = new System.Drawing.Font("OCR A Extended", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTemperatura.ForeColor = System.Drawing.Color.White;
            this.lblTemperatura.Location = new System.Drawing.Point(40, 101);
            this.lblTemperatura.Name = "lblTemperatura";
            this.lblTemperatura.Size = new System.Drawing.Size(194, 89);
            this.lblTemperatura.TabIndex = 3;
            this.lblTemperatura.Text = "25°C";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.LightBlue;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(953, 517);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38F));
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(336, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(279, 123);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("OCR A Extended", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(3, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 62);
            this.label4.TabIndex = 4;
            this.label4.Text = "IOT\r\nSeminarski\r\n";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(167, 16);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(108, 90);
            this.panel4.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 517);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "IOT";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;


        }

        #endregion

        private Button btnPovecaj;
        private Button btnSmanji;
        private Panel panel1;
        private Label lblKontrolnaTemperatura;
        private Panel panel2;
        private Button btnUpali;
        private Panel panel3;
        private Label lblTemperatura;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnPotvrdi;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel4;
        private Panel panel5;
    }
}