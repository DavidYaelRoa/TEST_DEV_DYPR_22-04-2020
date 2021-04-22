
namespace FormPut
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
            this.txtAct = new System.Windows.Forms.TextBox();
            this.txtAM = new System.Windows.Forms.TextBox();
            this.txtAP = new System.Windows.Forms.TextBox();
            this.txtFN = new System.Windows.Forms.MaskedTextBox();
            this.txtFA = new System.Windows.Forms.MaskedTextBox();
            this.txtFR = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUA = new System.Windows.Forms.TextBox();
            this.txtRFC = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtAct
            // 
            this.txtAct.Location = new System.Drawing.Point(271, 415);
            this.txtAct.Name = "txtAct";
            this.txtAct.Size = new System.Drawing.Size(100, 20);
            this.txtAct.TabIndex = 45;
            // 
            // txtAM
            // 
            this.txtAM.Location = new System.Drawing.Point(272, 271);
            this.txtAM.Name = "txtAM";
            this.txtAM.Size = new System.Drawing.Size(100, 20);
            this.txtAM.TabIndex = 44;
            // 
            // txtAP
            // 
            this.txtAP.Location = new System.Drawing.Point(271, 234);
            this.txtAP.Name = "txtAP";
            this.txtAP.Size = new System.Drawing.Size(100, 20);
            this.txtAP.TabIndex = 43;
            // 
            // txtFN
            // 
            this.txtFN.Location = new System.Drawing.Point(272, 343);
            this.txtFN.Mask = "00/00/0000";
            this.txtFN.Name = "txtFN";
            this.txtFN.Size = new System.Drawing.Size(100, 20);
            this.txtFN.TabIndex = 42;
            this.txtFN.ValidatingType = typeof(System.DateTime);
            // 
            // txtFA
            // 
            this.txtFA.Location = new System.Drawing.Point(272, 165);
            this.txtFA.Mask = "00/00/0000";
            this.txtFA.Name = "txtFA";
            this.txtFA.Size = new System.Drawing.Size(100, 20);
            this.txtFA.TabIndex = 41;
            this.txtFA.ValidatingType = typeof(System.DateTime);
            // 
            // txtFR
            // 
            this.txtFR.Location = new System.Drawing.Point(272, 130);
            this.txtFR.Mask = "00/00/0000";
            this.txtFR.Name = "txtFR";
            this.txtFR.Size = new System.Drawing.Size(100, 20);
            this.txtFR.TabIndex = 40;
            this.txtFR.ValidatingType = typeof(System.DateTime);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 476);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 39;
            this.button1.Text = "Actualizar Datos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(213, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "Formato de Actualizacion";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(160, 422);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Activo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(160, 386);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Usuario Agregado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(160, 350);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Fecha de Nacimiento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(160, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "RFC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(160, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Apellido Materno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Apellido Paterno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Nombre";
            // 
            // txtUA
            // 
            this.txtUA.Location = new System.Drawing.Point(272, 380);
            this.txtUA.Name = "txtUA";
            this.txtUA.Size = new System.Drawing.Size(100, 20);
            this.txtUA.TabIndex = 30;
            // 
            // txtRFC
            // 
            this.txtRFC.Location = new System.Drawing.Point(272, 307);
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Size = new System.Drawing.Size(100, 20);
            this.txtRFC.TabIndex = 29;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(272, 200);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Fecha de Actualizacion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Fecha de Registro";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(154, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 13);
            this.label11.TabIndex = 46;
            this.label11.Text = "ID de la persona";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(271, 97);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 47;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 518);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtAct);
            this.Controls.Add(this.txtAM);
            this.Controls.Add(this.txtAP);
            this.Controls.Add(this.txtFN);
            this.Controls.Add(this.txtFA);
            this.Controls.Add(this.txtFR);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUA);
            this.Controls.Add(this.txtRFC);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAct;
        private System.Windows.Forms.TextBox txtAM;
        private System.Windows.Forms.TextBox txtAP;
        private System.Windows.Forms.MaskedTextBox txtFN;
        private System.Windows.Forms.MaskedTextBox txtFA;
        private System.Windows.Forms.MaskedTextBox txtFR;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUA;
        private System.Windows.Forms.TextBox txtRFC;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtID;
    }
}

