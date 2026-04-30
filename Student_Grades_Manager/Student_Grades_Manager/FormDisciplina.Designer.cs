namespace Student_Grades_Manager
{
    partial class FormDisciplina
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCod = new System.Windows.Forms.TextBox();
            this.tbNrCredite = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colCod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDenumire = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCredite = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbDenumire = new System.Windows.Forms.TextBox();
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnSterge = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cod";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Denumire";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 195);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nr Credite";
            // 
            // tbCod
            // 
            this.tbCod.Location = new System.Drawing.Point(106, 41);
            this.tbCod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbCod.Name = "tbCod";
            this.tbCod.Size = new System.Drawing.Size(76, 20);
            this.tbCod.TabIndex = 3;
            // 
            // tbNrCredite
            // 
            this.tbNrCredite.Location = new System.Drawing.Point(106, 195);
            this.tbNrCredite.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNrCredite.Name = "tbNrCredite";
            this.tbNrCredite.Size = new System.Drawing.Size(76, 20);
            this.tbNrCredite.TabIndex = 4;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCod,
            this.colDenumire,
            this.colCredite});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(272, 41);
            this.listView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(268, 203);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // colCod
            // 
            this.colCod.Text = "Cod";
            // 
            // colDenumire
            // 
            this.colDenumire.Text = "Denumire";
            this.colDenumire.Width = 95;
            // 
            // colCredite
            // 
            this.colCredite.Text = "Nr Credite";
            this.colCredite.Width = 80;
            // 
            // tbDenumire
            // 
            this.tbDenumire.Location = new System.Drawing.Point(106, 110);
            this.tbDenumire.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbDenumire.Name = "tbDenumire";
            this.tbDenumire.Size = new System.Drawing.Size(76, 20);
            this.tbDenumire.TabIndex = 7;
            // 
            // btnSalveaza
            // 
            this.btnSalveaza.Location = new System.Drawing.Point(106, 296);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Size = new System.Drawing.Size(88, 41);
            this.btnSalveaza.TabIndex = 8;
            this.btnSalveaza.Text = "Salveaza";
            this.btnSalveaza.UseVisualStyleBackColor = true;
            this.btnSalveaza.Click += new System.EventHandler(this.btnSalveaza_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.Location = new System.Drawing.Point(252, 296);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(86, 41);
            this.btnModifica.TabIndex = 9;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnSterge
            // 
            this.btnSterge.Location = new System.Drawing.Point(400, 296);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(81, 41);
            this.btnSterge.TabIndex = 10;
            this.btnSterge.Text = "Sterge";
            this.btnSterge.UseVisualStyleBackColor = true;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormDisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 380);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnSalveaza);
            this.Controls.Add(this.tbDenumire);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.tbNrCredite);
            this.Controls.Add(this.tbCod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormDisciplina";
            this.Text = "FormDisciplina";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCod;
        private System.Windows.Forms.TextBox tbNrCredite;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colCod;
        private System.Windows.Forms.ColumnHeader colDenumire;
        private System.Windows.Forms.ColumnHeader colCredite;
        private System.Windows.Forms.TextBox tbDenumire;
        private System.Windows.Forms.Button btnSalveaza;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}