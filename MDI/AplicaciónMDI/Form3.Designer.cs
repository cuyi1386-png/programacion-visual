namespace AplicaciónMDI
{
    partial class Form3
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
            this.carnetLabelShowView = new System.Windows.Forms.Label();
            this.nameLabelShowView = new System.Windows.Forms.Label();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.asignature_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.note_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.search_carnet = new System.Windows.Forms.TextBox();
            this.search_nombre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // carnetLabelShowView
            // 
            this.carnetLabelShowView.AutoSize = true;
            this.carnetLabelShowView.BackColor = System.Drawing.SystemColors.Control;
            this.carnetLabelShowView.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carnetLabelShowView.Location = new System.Drawing.Point(67, 66);
            this.carnetLabelShowView.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.carnetLabelShowView.Name = "carnetLabelShowView";
            this.carnetLabelShowView.Size = new System.Drawing.Size(70, 24);
            this.carnetLabelShowView.TabIndex = 0;
            this.carnetLabelShowView.Text = "Carnet";
            // 
            // nameLabelShowView
            // 
            this.nameLabelShowView.AutoSize = true;
            this.nameLabelShowView.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabelShowView.Location = new System.Drawing.Point(67, 148);
            this.nameLabelShowView.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.nameLabelShowView.Name = "nameLabelShowView";
            this.nameLabelShowView.Size = new System.Drawing.Size(81, 24);
            this.nameLabelShowView.TabIndex = 1;
            this.nameLabelShowView.Text = "Nombre";
            // 
            // dgvDatos
            // 
            this.dgvDatos.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.asignature_,
            this.note_});
            this.dgvDatos.Location = new System.Drawing.Point(165, 239);
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersWidth = 62;
            this.dgvDatos.Size = new System.Drawing.Size(357, 346);
            this.dgvDatos.TabIndex = 2;
            this.dgvDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellContentClick);
            // 
            // asignature_
            // 
            this.asignature_.HeaderText = "Asignatura";
            this.asignature_.MinimumWidth = 8;
            this.asignature_.Name = "asignature_";
            this.asignature_.Width = 150;
            // 
            // note_
            // 
            this.note_.HeaderText = "Nota";
            this.note_.MinimumWidth = 8;
            this.note_.Name = "note_";
            this.note_.Width = 150;
            // 
            // search_carnet
            // 
            this.search_carnet.Location = new System.Drawing.Point(75, 100);
            this.search_carnet.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.search_carnet.Name = "search_carnet";
            this.search_carnet.Size = new System.Drawing.Size(559, 30);
            this.search_carnet.TabIndex = 3;
            // 
            // search_nombre
            // 
            this.search_nombre.Location = new System.Drawing.Point(72, 178);
            this.search_nombre.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.search_nombre.Name = "search_nombre";
            this.search_nombre.Size = new System.Drawing.Size(561, 30);
            this.search_nombre.TabIndex = 4;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(713, 644);
            this.Controls.Add(this.search_nombre);
            this.Controls.Add(this.search_carnet);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.nameLabelShowView);
            this.Controls.Add(this.carnetLabelShowView);
            this.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label carnetLabelShowView;
        private System.Windows.Forms.Label nameLabelShowView;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn asignature_;
        private System.Windows.Forms.DataGridViewTextBoxColumn note_;
        private System.Windows.Forms.TextBox search_carnet;
        private System.Windows.Forms.TextBox search_nombre;
    }
}