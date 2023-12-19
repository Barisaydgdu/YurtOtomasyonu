namespace YurtOtomasyonu
{
    partial class FrmOdaBilgileri
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOdaAra = new System.Windows.Forms.TextBox();
            this.lblOdaSayisi = new System.Windows.Forms.Label();
            this.lblBosOda = new System.Windows.Forms.Label();
            this.lblKacBos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(28, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 597);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(324, 558);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(505, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "ODA ARA";
            // 
            // txtOdaAra
            // 
            this.txtOdaAra.Location = new System.Drawing.Point(388, 131);
            this.txtOdaAra.Name = "txtOdaAra";
            this.txtOdaAra.Size = new System.Drawing.Size(351, 34);
            this.txtOdaAra.TabIndex = 2;
            this.txtOdaAra.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblOdaSayisi
            // 
            this.lblOdaSayisi.AutoSize = true;
            this.lblOdaSayisi.Location = new System.Drawing.Point(383, 228);
            this.lblOdaSayisi.Name = "lblOdaSayisi";
            this.lblOdaSayisi.Size = new System.Drawing.Size(118, 25);
            this.lblOdaSayisi.TabIndex = 3;
            this.lblOdaSayisi.Text = "Oda Sayısı";
            // 
            // lblBosOda
            // 
            this.lblBosOda.AutoSize = true;
            this.lblBosOda.Location = new System.Drawing.Point(578, 228);
            this.lblBosOda.Name = "lblBosOda";
            this.lblBosOda.Size = new System.Drawing.Size(161, 25);
            this.lblBosOda.TabIndex = 4;
            this.lblBosOda.Text = "Boş Oda Sayısı";
            // 
            // lblKacBos
            // 
            this.lblKacBos.AutoSize = true;
            this.lblKacBos.Font = new System.Drawing.Font("MV Boli", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKacBos.Location = new System.Drawing.Point(629, 253);
            this.lblKacBos.Name = "lblKacBos";
            this.lblKacBos.Size = new System.Drawing.Size(49, 49);
            this.lblKacBos.TabIndex = 6;
            this.lblKacBos.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(418, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 49);
            this.label2.TabIndex = 7;
            this.label2.Text = "0";
            // 
            // FrmOdaBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(765, 741);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblKacBos);
            this.Controls.Add(this.lblBosOda);
            this.Controls.Add(this.lblOdaSayisi);
            this.Controls.Add(this.txtOdaAra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOdaBilgileri";
            this.Text = "FrmOdaBilgileri";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOdaAra;
        private System.Windows.Forms.Label lblOdaSayisi;
        private System.Windows.Forms.Label lblBosOda;
        private System.Windows.Forms.Label lblKacBos;
        private System.Windows.Forms.Label label2;
    }
}