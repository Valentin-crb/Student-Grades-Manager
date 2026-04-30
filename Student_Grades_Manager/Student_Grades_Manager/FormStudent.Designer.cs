namespace Student_Grades_Manager
{
    partial class FormStudent
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
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbPrenume = new System.Windows.Forms.TextBox();
            this.tbCNP = new System.Windows.Forms.TextBox();
            this.tbGrupa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnSterge = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrenume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCNP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGrupa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBoxAn = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(89, 37);
            this.tbNume.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(129, 20);
            this.tbNume.TabIndex = 0;
            // 
            // tbPrenume
            // 
            this.tbPrenume.Location = new System.Drawing.Point(89, 85);
            this.tbPrenume.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPrenume.Name = "tbPrenume";
            this.tbPrenume.Size = new System.Drawing.Size(129, 20);
            this.tbPrenume.TabIndex = 1;
            // 
            // tbCNP
            // 
            this.tbCNP.Location = new System.Drawing.Point(89, 131);
            this.tbCNP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbCNP.Name = "tbCNP";
            this.tbCNP.Size = new System.Drawing.Size(129, 20);
            this.tbCNP.TabIndex = 2;
            // 
            // tbGrupa
            // 
            this.tbGrupa.Location = new System.Drawing.Point(89, 270);
            this.tbGrupa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbGrupa.Name = "tbGrupa";
            this.tbGrupa.Size = new System.Drawing.Size(129, 20);
            this.tbGrupa.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Prenume";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 136);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "CNP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 187);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "An";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 272);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Grupa";
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(89, 341);
            this.btnAdauga.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(117, 41);
            this.btnAdauga.TabIndex = 11;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.Location = new System.Drawing.Point(299, 341);
            this.btnModifica.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(117, 41);
            this.btnModifica.TabIndex = 12;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnSterge
            // 
            this.btnSterge.Location = new System.Drawing.Point(493, 341);
            this.btnSterge.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(117, 41);
            this.btnSterge.TabIndex = 13;
            this.btnSterge.Text = "Sterge";
            this.btnSterge.UseVisualStyleBackColor = true;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colPrenume,
            this.colCNP,
            this.colAn,
            this.colGrupa});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(299, 52);
            this.listView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(362, 238);
            this.listView1.TabIndex = 14;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // colName
            // 
            this.colName.Text = "Nume";
            // 
            // colPrenume
            // 
            this.colPrenume.Text = "Prenume";
            // 
            // colCNP
            // 
            this.colCNP.Text = "CNP";
            // 
            // colAn
            // 
            this.colAn.Text = "An";
            // 
            // colGrupa
            // 
            this.colGrupa.Text = "Grupa";
            // 
            // comboBoxAn
            // 
            this.comboBoxAn.FormattingEnabled = true;
            this.comboBoxAn.Items.AddRange(new object[] {
            "Anul I",
            "Anul II",
            "Anul III",
            "Anul IV"});
            this.comboBoxAn.Location = new System.Drawing.Point(89, 187);
            this.comboBoxAn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxAn.Name = "comboBoxAn";
            this.comboBoxAn.Size = new System.Drawing.Size(92, 21);
            this.comboBoxAn.TabIndex = 15;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 422);
            this.Controls.Add(this.comboBoxAn);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbGrupa);
            this.Controls.Add(this.tbCNP);
            this.Controls.Add(this.tbPrenume);
            this.Controls.Add(this.tbNume);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormStudent";
            this.Text = "FormStudent";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.TextBox tbPrenume;
        private System.Windows.Forms.TextBox tbCNP;
        private System.Windows.Forms.TextBox tbGrupa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colPrenume;
        private System.Windows.Forms.ColumnHeader colCNP;
        private System.Windows.Forms.ColumnHeader colAn;
        private System.Windows.Forms.ColumnHeader colGrupa;
        private System.Windows.Forms.ComboBox comboBoxAn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}