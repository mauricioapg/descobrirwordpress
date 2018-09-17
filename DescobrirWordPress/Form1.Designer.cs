namespace DescobrirWordPress
{
    partial class fomularioPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.labelResultado = new System.Windows.Forms.Label();
            this.groupBoxItens = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnChecar = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.progresso = new System.Windows.Forms.ProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBoxItens.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultado.Location = new System.Drawing.Point(34, 207);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(0, 16);
            this.labelResultado.TabIndex = 2;
            // 
            // groupBoxItens
            // 
            this.groupBoxItens.Controls.Add(this.progresso);
            this.groupBoxItens.Controls.Add(this.btnLimpar);
            this.groupBoxItens.Controls.Add(this.btnChecar);
            this.groupBoxItens.Controls.Add(this.txtUrl);
            this.groupBoxItens.Controls.Add(this.labelResultado);
            this.groupBoxItens.Controls.Add(this.label1);
            this.groupBoxItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxItens.Location = new System.Drawing.Point(12, 12);
            this.groupBoxItens.Name = "groupBoxItens";
            this.groupBoxItens.Size = new System.Drawing.Size(658, 242);
            this.groupBoxItens.TabIndex = 3;
            this.groupBoxItens.TabStop = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(333, 101);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(287, 37);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnChecar
            // 
            this.btnChecar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChecar.Location = new System.Drawing.Point(37, 101);
            this.btnChecar.Name = "btnChecar";
            this.btnChecar.Size = new System.Drawing.Size(287, 37);
            this.btnChecar.TabIndex = 5;
            this.btnChecar.Text = "Checar";
            this.btnChecar.UseVisualStyleBackColor = true;
            this.btnChecar.Click += new System.EventHandler(this.btnChecar_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrl.Location = new System.Drawing.Point(37, 61);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(583, 22);
            this.txtUrl.TabIndex = 4;
            this.txtUrl.Click += new System.EventHandler(this.txtUrl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe a url do site:";
            // 
            // progresso
            // 
            this.progresso.Location = new System.Drawing.Point(37, 161);
            this.progresso.Name = "progresso";
            this.progresso.Size = new System.Drawing.Size(583, 23);
            this.progresso.TabIndex = 7;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // fomularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 266);
            this.Controls.Add(this.groupBoxItens);
            this.Name = "fomularioPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Descobrir Site WordPress";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxItens.ResumeLayout(false);
            this.groupBoxItens.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.GroupBox groupBoxItens;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChecar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.ProgressBar progresso;
        private System.Windows.Forms.Timer timer;
    }
}

