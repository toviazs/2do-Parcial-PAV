
namespace Pav2022.P2.Presentacion.Vistas
{
    partial class PedidoVista
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
            this.AgregarBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PedidosPendientesDGV = new System.Windows.Forms.DataGridView();
            this.PedidosListosDGV = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PedidosPendientesDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PedidosListosDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // AgregarBtn
            // 
            this.AgregarBtn.Location = new System.Drawing.Point(637, 387);
            this.AgregarBtn.Name = "AgregarBtn";
            this.AgregarBtn.Size = new System.Drawing.Size(147, 23);
            this.AgregarBtn.TabIndex = 0;
            this.AgregarBtn.Text = "Agregar un Pedido";
            this.AgregarBtn.UseVisualStyleBackColor = true;
            this.AgregarBtn.Click += new System.EventHandler(this.AgregarBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pedidos Pendientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(1009, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 45);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pedidos Listos";
            // 
            // PedidosPendientesDGV
            // 
            this.PedidosPendientesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PedidosPendientesDGV.Location = new System.Drawing.Point(12, 75);
            this.PedidosPendientesDGV.Name = "PedidosPendientesDGV";
            this.PedidosPendientesDGV.RowTemplate.Height = 25;
            this.PedidosPendientesDGV.Size = new System.Drawing.Size(605, 306);
            this.PedidosPendientesDGV.TabIndex = 5;
            // 
            // PedidosListosDGV
            // 
            this.PedidosListosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PedidosListosDGV.Location = new System.Drawing.Point(637, 75);
            this.PedidosListosDGV.Name = "PedidosListosDGV";
            this.PedidosListosDGV.RowTemplate.Height = 25;
            this.PedidosListosDGV.Size = new System.Drawing.Size(609, 306);
            this.PedidosListosDGV.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(470, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PedidoVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PedidosListosDGV);
            this.Controls.Add(this.PedidosPendientesDGV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AgregarBtn);
            this.Name = "PedidoVista";
            this.Text = "PedidosVista";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.PedidosPendientesDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PedidosListosDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AgregarBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView PedidosPendientesDGV;
        private System.Windows.Forms.DataGridView PedidosListosDGV;
        private System.Windows.Forms.Button button1;
    }
}