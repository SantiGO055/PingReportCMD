
namespace FormCMD
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtDos = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUno = new System.Windows.Forms.TextBox();
            this.txtTres = new System.Windows.Forms.TextBox();
            this.txtCuatro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDos
            // 
            this.txtDos.BackColor = System.Drawing.Color.Gainsboro;
            this.txtDos.Location = new System.Drawing.Point(113, 21);
            this.txtDos.MaxLength = 3;
            this.txtDos.Name = "txtDos";
            this.txtDos.Size = new System.Drawing.Size(25, 20);
            this.txtDos.TabIndex = 2;
            this.txtDos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDos_KeyPress);
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(113, 61);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(69, 26);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "Ping";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = ".";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = ".";
            // 
            // txtUno
            // 
            this.txtUno.BackColor = System.Drawing.Color.Gainsboro;
            this.txtUno.Location = new System.Drawing.Point(69, 21);
            this.txtUno.MaxLength = 3;
            this.txtUno.Name = "txtUno";
            this.txtUno.Size = new System.Drawing.Size(25, 20);
            this.txtUno.TabIndex = 1;
            this.txtUno.TextChanged += new System.EventHandler(this.txtUno_TextChanged);
            this.txtUno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUno_KeyDown);
            this.txtUno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUno_KeyPress);
            // 
            // txtTres
            // 
            this.txtTres.BackColor = System.Drawing.Color.Gainsboro;
            this.txtTres.Location = new System.Drawing.Point(157, 21);
            this.txtTres.MaxLength = 3;
            this.txtTres.Name = "txtTres";
            this.txtTres.Size = new System.Drawing.Size(25, 20);
            this.txtTres.TabIndex = 3;
            this.txtTres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTres_KeyPress);
            // 
            // txtCuatro
            // 
            this.txtCuatro.BackColor = System.Drawing.Color.Gainsboro;
            this.txtCuatro.Location = new System.Drawing.Point(204, 21);
            this.txtCuatro.MaxLength = 3;
            this.txtCuatro.Name = "txtCuatro";
            this.txtCuatro.Size = new System.Drawing.Size(25, 20);
            this.txtCuatro.TabIndex = 4;
            this.txtCuatro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCuatro_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "IP:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(103, 93);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 26);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(291, 146);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCuatro);
            this.Controls.Add(this.txtTres);
            this.Controls.Add(this.txtUno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "PingCMD";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDos;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUno;
        private System.Windows.Forms.TextBox txtTres;
        private System.Windows.Forms.TextBox txtCuatro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancelar;
    }
}

