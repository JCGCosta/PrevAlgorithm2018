namespace PrevAlgoritmo
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCarIni = new System.Windows.Forms.Button();
            this.dvDadosUniverso = new System.Windows.Forms.DataGridView();
            this.btnPrevOP = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFonteD = new System.Windows.Forms.Label();
            this.lblDadosI = new System.Windows.Forms.Label();
            this.lblUniverso = new System.Windows.Forms.Label();
            this.lblPropDIU = new System.Windows.Forms.Label();
            this.lblTaxaDeRetornoAc = new System.Windows.Forms.Label();
            this.btnBackProp = new System.Windows.Forms.Button();
            this.btnBranquearDadosI = new System.Windows.Forms.Button();
            this.ch1 = new System.Windows.Forms.CheckBox();
            this.ch2 = new System.Windows.Forms.CheckBox();
            this.ch3 = new System.Windows.Forms.CheckBox();
            this.btnreset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvDadosUniverso)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCarIni
            // 
            this.btnCarIni.Location = new System.Drawing.Point(16, 54);
            this.btnCarIni.Name = "btnCarIni";
            this.btnCarIni.Size = new System.Drawing.Size(307, 37);
            this.btnCarIni.TabIndex = 0;
            this.btnCarIni.Text = "Carregar Conhecimento Inicial";
            this.btnCarIni.UseVisualStyleBackColor = true;
            this.btnCarIni.Click += new System.EventHandler(this.Button1_Click);
            // 
            // dvDadosUniverso
            // 
            this.dvDadosUniverso.AllowUserToAddRows = false;
            this.dvDadosUniverso.AllowUserToDeleteRows = false;
            this.dvDadosUniverso.AllowUserToOrderColumns = true;
            this.dvDadosUniverso.AllowUserToResizeColumns = false;
            this.dvDadosUniverso.AllowUserToResizeRows = false;
            this.dvDadosUniverso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvDadosUniverso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvDadosUniverso.DefaultCellStyle = dataGridViewCellStyle1;
            this.dvDadosUniverso.Location = new System.Drawing.Point(342, 54);
            this.dvDadosUniverso.Name = "dvDadosUniverso";
            this.dvDadosUniverso.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dvDadosUniverso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvDadosUniverso.ShowCellErrors = false;
            this.dvDadosUniverso.ShowCellToolTips = false;
            this.dvDadosUniverso.ShowEditingIcon = false;
            this.dvDadosUniverso.ShowRowErrors = false;
            this.dvDadosUniverso.Size = new System.Drawing.Size(494, 505);
            this.dvDadosUniverso.TabIndex = 1;
            // 
            // btnPrevOP
            // 
            this.btnPrevOP.Enabled = false;
            this.btnPrevOP.Location = new System.Drawing.Point(43, 199);
            this.btnPrevOP.Name = "btnPrevOP";
            this.btnPrevOP.Size = new System.Drawing.Size(276, 27);
            this.btnPrevOP.TabIndex = 2;
            this.btnPrevOP.Text = "Prever demais pontos do universo por ponto medio";
            this.btnPrevOP.UseVisualStyleBackColor = true;
            this.btnPrevOP.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 112);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(76, 13);
            this.label.TabIndex = 3;
            this.label.Text = "Dados Iniciais:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Universo de Possibilidades:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Proporção Dados Iniciais e o Universo (%):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Taxa de Acerto de Retorno (%):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fonte dos Dados:";
            // 
            // lblFonteD
            // 
            this.lblFonteD.AutoSize = true;
            this.lblFonteD.Location = new System.Drawing.Point(110, 20);
            this.lblFonteD.Name = "lblFonteD";
            this.lblFonteD.Size = new System.Drawing.Size(0, 13);
            this.lblFonteD.TabIndex = 8;
            // 
            // lblDadosI
            // 
            this.lblDadosI.AutoSize = true;
            this.lblDadosI.Location = new System.Drawing.Point(94, 112);
            this.lblDadosI.Name = "lblDadosI";
            this.lblDadosI.Size = new System.Drawing.Size(0, 13);
            this.lblDadosI.TabIndex = 9;
            // 
            // lblUniverso
            // 
            this.lblUniverso.AutoSize = true;
            this.lblUniverso.Location = new System.Drawing.Point(154, 141);
            this.lblUniverso.Name = "lblUniverso";
            this.lblUniverso.Size = new System.Drawing.Size(0, 13);
            this.lblUniverso.TabIndex = 10;
            // 
            // lblPropDIU
            // 
            this.lblPropDIU.AutoSize = true;
            this.lblPropDIU.Location = new System.Drawing.Point(226, 172);
            this.lblPropDIU.Name = "lblPropDIU";
            this.lblPropDIU.Size = new System.Drawing.Size(0, 13);
            this.lblPropDIU.TabIndex = 11;
            // 
            // lblTaxaDeRetornoAc
            // 
            this.lblTaxaDeRetornoAc.AutoSize = true;
            this.lblTaxaDeRetornoAc.Location = new System.Drawing.Point(174, 300);
            this.lblTaxaDeRetornoAc.Name = "lblTaxaDeRetornoAc";
            this.lblTaxaDeRetornoAc.Size = new System.Drawing.Size(0, 13);
            this.lblTaxaDeRetornoAc.TabIndex = 12;
            // 
            // btnBackProp
            // 
            this.btnBackProp.Enabled = false;
            this.btnBackProp.Location = new System.Drawing.Point(43, 262);
            this.btnBackProp.Name = "btnBackProp";
            this.btnBackProp.Size = new System.Drawing.Size(276, 27);
            this.btnBackProp.TabIndex = 13;
            this.btnBackProp.Text = "Tirar Prova Matematica atraves da BackPropagation";
            this.btnBackProp.UseVisualStyleBackColor = true;
            this.btnBackProp.Click += new System.EventHandler(this.Button1_Click_2);
            // 
            // btnBranquearDadosI
            // 
            this.btnBranquearDadosI.Enabled = false;
            this.btnBranquearDadosI.Location = new System.Drawing.Point(43, 229);
            this.btnBranquearDadosI.Name = "btnBranquearDadosI";
            this.btnBranquearDadosI.Size = new System.Drawing.Size(276, 27);
            this.btnBranquearDadosI.TabIndex = 14;
            this.btnBranquearDadosI.Text = "Limpar Pontos Iniciais";
            this.btnBranquearDadosI.UseVisualStyleBackColor = true;
            this.btnBranquearDadosI.Click += new System.EventHandler(this.BtnBranquearDadosI_Click);
            // 
            // ch1
            // 
            this.ch1.AutoSize = true;
            this.ch1.Enabled = false;
            this.ch1.Location = new System.Drawing.Point(16, 209);
            this.ch1.Name = "ch1";
            this.ch1.Size = new System.Drawing.Size(15, 14);
            this.ch1.TabIndex = 15;
            this.ch1.UseVisualStyleBackColor = true;
            // 
            // ch2
            // 
            this.ch2.AutoSize = true;
            this.ch2.Enabled = false;
            this.ch2.Location = new System.Drawing.Point(16, 239);
            this.ch2.Name = "ch2";
            this.ch2.Size = new System.Drawing.Size(15, 14);
            this.ch2.TabIndex = 16;
            this.ch2.UseVisualStyleBackColor = true;
            // 
            // ch3
            // 
            this.ch3.AutoSize = true;
            this.ch3.Enabled = false;
            this.ch3.Location = new System.Drawing.Point(16, 270);
            this.ch3.Name = "ch3";
            this.ch3.Size = new System.Drawing.Size(15, 14);
            this.ch3.TabIndex = 17;
            this.ch3.UseVisualStyleBackColor = true;
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(244, 536);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(75, 23);
            this.btnreset.TabIndex = 18;
            this.btnreset.Text = "Resetar";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.Btnreset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 571);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.ch3);
            this.Controls.Add(this.ch2);
            this.Controls.Add(this.ch1);
            this.Controls.Add(this.btnBranquearDadosI);
            this.Controls.Add(this.btnBackProp);
            this.Controls.Add(this.lblTaxaDeRetornoAc);
            this.Controls.Add(this.lblPropDIU);
            this.Controls.Add(this.lblUniverso);
            this.Controls.Add(this.lblDadosI);
            this.Controls.Add(this.lblFonteD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.btnPrevOP);
            this.Controls.Add(this.dvDadosUniverso);
            this.Controls.Add(this.btnCarIni);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "3_Eixos_3_Entradas_3_Saidas_SemReajustePM";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvDadosUniverso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCarIni;
        private System.Windows.Forms.DataGridView dvDadosUniverso;
        private System.Windows.Forms.Button btnPrevOP;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFonteD;
        private System.Windows.Forms.Label lblDadosI;
        private System.Windows.Forms.Label lblUniverso;
        private System.Windows.Forms.Label lblPropDIU;
        private System.Windows.Forms.Label lblTaxaDeRetornoAc;
        private System.Windows.Forms.Button btnBackProp;
        private System.Windows.Forms.Button btnBranquearDadosI;
        private System.Windows.Forms.CheckBox ch1;
        private System.Windows.Forms.CheckBox ch2;
        private System.Windows.Forms.CheckBox ch3;
        private System.Windows.Forms.Button btnreset;
    }
}

