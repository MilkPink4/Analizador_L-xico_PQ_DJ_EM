namespace Analizador_Léxico_PQ_DJ_EM
{
    partial class FrmTokens
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
            this.txtToken = new System.Windows.Forms.TextBox();
            this.txtSimbolo = new System.Windows.Forms.TextBox();
            this.dgvTablaSimbolos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAnalizar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAnalizador = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaSimbolos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtToken
            // 
            this.txtToken.Location = new System.Drawing.Point(46, 107);
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(138, 23);
            this.txtToken.TabIndex = 0;
            // 
            // txtSimbolo
            // 
            this.txtSimbolo.Location = new System.Drawing.Point(276, 107);
            this.txtSimbolo.Name = "txtSimbolo";
            this.txtSimbolo.Size = new System.Drawing.Size(139, 23);
            this.txtSimbolo.TabIndex = 1;
            // 
            // dgvTablaSimbolos
            // 
            this.dgvTablaSimbolos.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dgvTablaSimbolos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaSimbolos.Location = new System.Drawing.Point(44, 239);
            this.dgvTablaSimbolos.Name = "dgvTablaSimbolos";
            this.dgvTablaSimbolos.RowHeadersWidth = 51;
            this.dgvTablaSimbolos.RowTemplate.Height = 24;
            this.dgvTablaSimbolos.Size = new System.Drawing.Size(416, 326);
            this.dgvTablaSimbolos.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Token";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(273, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Simbolo";
            // 
            // btnAnalizar
            // 
            this.btnAnalizar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAnalizar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalizar.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnAnalizar.Location = new System.Drawing.Point(44, 161);
            this.btnAnalizar.Name = "btnAnalizar";
            this.btnAnalizar.Size = new System.Drawing.Size(99, 62);
            this.btnAnalizar.TabIndex = 5;
            this.btnAnalizar.Text = "ANALIZAR";
            this.btnAnalizar.UseVisualStyleBackColor = false;
            this.btnAnalizar.Click += new System.EventHandler(this.btnAnalizar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnBuscar.Location = new System.Drawing.Point(207, 161);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(99, 62);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnEliminar.Location = new System.Drawing.Point(360, 161);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 62);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(183, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 39);
            this.label3.TabIndex = 8;
            this.label3.Text = "TOKENS";
            // 
            // lblAnalizador
            // 
            this.lblAnalizador.AutoSize = true;
            this.lblAnalizador.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnalizador.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblAnalizador.Location = new System.Drawing.Point(389, 9);
            this.lblAnalizador.Name = "lblAnalizador";
            this.lblAnalizador.Size = new System.Drawing.Size(104, 17);
            this.lblAnalizador.TabIndex = 9;
            this.lblAnalizador.Text = "Ir al Analizador";
            this.lblAnalizador.Click += new System.EventHandler(this.lblAnalizador_Click);
            // 
            // FrmTokens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(505, 600);
            this.Controls.Add(this.lblAnalizador);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAnalizar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTablaSimbolos);
            this.Controls.Add(this.txtSimbolo);
            this.Controls.Add(this.txtToken);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmTokens";
            this.Text = "FrmTokens";
            this.Load += new System.EventHandler(this.FrmTokens_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaSimbolos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.TextBox txtSimbolo;
        private System.Windows.Forms.DataGridView dgvTablaSimbolos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAnalizar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAnalizador;
    }
}