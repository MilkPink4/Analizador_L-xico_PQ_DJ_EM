namespace Analizador_Léxico_PQ_DJ_EM
{
    partial class FrmAnalizador
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
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.dgvError = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAnalizar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.rtbTexto = new System.Windows.Forms.RichTextBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.lbltokens = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvError)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvResultado
            // 
            this.dgvResultado.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.Location = new System.Drawing.Point(34, 321);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.RowHeadersWidth = 51;
            this.dgvResultado.RowTemplate.Height = 24;
            this.dgvResultado.Size = new System.Drawing.Size(345, 125);
            this.dgvResultado.TabIndex = 0;
            // 
            // dgvError
            // 
            this.dgvError.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dgvError.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvError.Location = new System.Drawing.Point(423, 321);
            this.dgvError.Name = "dgvError";
            this.dgvError.RowHeadersWidth = 51;
            this.dgvError.RowTemplate.Height = 24;
            this.dgvError.Size = new System.Drawing.Size(345, 125);
            this.dgvError.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Resultados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(423, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Errores";
            // 
            // btnAnalizar
            // 
            this.btnAnalizar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAnalizar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalizar.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnAnalizar.Location = new System.Drawing.Point(641, 105);
            this.btnAnalizar.Name = "btnAnalizar";
            this.btnAnalizar.Size = new System.Drawing.Size(127, 75);
            this.btnAnalizar.TabIndex = 4;
            this.btnAnalizar.Text = "ANALIZAR";
            this.btnAnalizar.UseVisualStyleBackColor = false;
            this.btnAnalizar.Click += new System.EventHandler(this.btnAnalizar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnLimpiar.Location = new System.Drawing.Point(641, 200);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(127, 75);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // rtbTexto
            // 
            this.rtbTexto.Location = new System.Drawing.Point(37, 85);
            this.rtbTexto.Name = "rtbTexto";
            this.rtbTexto.Size = new System.Drawing.Size(342, 190);
            this.rtbTexto.TabIndex = 6;
            this.rtbTexto.Text = "";
            // 
            // btnCargar
            // 
            this.btnCargar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnCargar.Location = new System.Drawing.Point(37, 38);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCargar.Size = new System.Drawing.Size(124, 41);
            this.btnCargar.TabIndex = 7;
            this.btnCargar.Text = "CARGAR TEXTO";
            this.btnCargar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // lbltokens
            // 
            this.lbltokens.AutoSize = true;
            this.lbltokens.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltokens.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbltokens.Location = new System.Drawing.Point(691, 9);
            this.lbltokens.Name = "lbltokens";
            this.lbltokens.Size = new System.Drawing.Size(74, 17);
            this.lbltokens.TabIndex = 10;
            this.lbltokens.Text = "Ir a Tokens";
            this.lbltokens.Click += new System.EventHandler(this.lbltokens_Click);
            // 
            // FrmAnalizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(800, 481);
            this.Controls.Add(this.lbltokens);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.rtbTexto);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAnalizar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvError);
            this.Controls.Add(this.dgvResultado);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmAnalizador";
            this.Text = "FrmAnalizador";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.DataGridView dgvError;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAnalizar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.RichTextBox rtbTexto;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Label lbltokens;
    }
}