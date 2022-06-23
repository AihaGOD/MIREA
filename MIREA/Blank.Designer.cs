namespace MIREA
{
    partial class Blank
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tBox_Surname = new System.Windows.Forms.TextBox();
            this.tBox_Name = new System.Windows.Forms.TextBox();
            this.tBox_Patron = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnAdres = new System.Windows.Forms.Button();
            this.btnDocs = new System.Windows.Forms.Button();
            this.btnParents = new System.Windows.Forms.Button();
            this.btnEGE = new System.Windows.Forms.Button();
            this.btnPasport = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnCode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Отчество";
            // 
            // tBox_Surname
            // 
            this.tBox_Surname.Location = new System.Drawing.Point(132, 19);
            this.tBox_Surname.Name = "tBox_Surname";
            this.tBox_Surname.Size = new System.Drawing.Size(164, 20);
            this.tBox_Surname.TabIndex = 1;
            // 
            // tBox_Name
            // 
            this.tBox_Name.Location = new System.Drawing.Point(132, 48);
            this.tBox_Name.Name = "tBox_Name";
            this.tBox_Name.Size = new System.Drawing.Size(164, 20);
            this.tBox_Name.TabIndex = 2;
            // 
            // tBox_Patron
            // 
            this.tBox_Patron.Location = new System.Drawing.Point(132, 78);
            this.tBox_Patron.Name = "tBox_Patron";
            this.tBox_Patron.Size = new System.Drawing.Size(164, 20);
            this.tBox_Patron.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Дата рождения";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(132, 111);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(138, 20);
            this.dateTimePicker.TabIndex = 4;
            // 
            // btnAdres
            // 
            this.btnAdres.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdres.Location = new System.Drawing.Point(16, 152);
            this.btnAdres.Name = "btnAdres";
            this.btnAdres.Size = new System.Drawing.Size(126, 23);
            this.btnAdres.TabIndex = 5;
            this.btnAdres.Text = "Место жительства";
            this.btnAdres.UseVisualStyleBackColor = true;
            this.btnAdres.Click += new System.EventHandler(this.btnAdres_Click);
            // 
            // btnDocs
            // 
            this.btnDocs.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.btnDocs.Location = new System.Drawing.Point(170, 210);
            this.btnDocs.Name = "btnDocs";
            this.btnDocs.Size = new System.Drawing.Size(126, 23);
            this.btnDocs.TabIndex = 10;
            this.btnDocs.Text = "Документы";
            this.btnDocs.UseVisualStyleBackColor = true;
            this.btnDocs.Click += new System.EventHandler(this.btnDocs_Click);
            // 
            // btnParents
            // 
            this.btnParents.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.btnParents.Location = new System.Drawing.Point(170, 152);
            this.btnParents.Name = "btnParents";
            this.btnParents.Size = new System.Drawing.Size(126, 23);
            this.btnParents.TabIndex = 6;
            this.btnParents.Text = "Родители";
            this.btnParents.UseVisualStyleBackColor = true;
            this.btnParents.Click += new System.EventHandler(this.btnParents_Click);
            // 
            // btnEGE
            // 
            this.btnEGE.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.btnEGE.Location = new System.Drawing.Point(170, 181);
            this.btnEGE.Name = "btnEGE";
            this.btnEGE.Size = new System.Drawing.Size(126, 23);
            this.btnEGE.TabIndex = 8;
            this.btnEGE.Text = "ЕГЭ/ГИА";
            this.btnEGE.UseVisualStyleBackColor = true;
            this.btnEGE.Click += new System.EventHandler(this.btnEGE_Click);
            // 
            // btnPasport
            // 
            this.btnPasport.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.btnPasport.Location = new System.Drawing.Point(16, 210);
            this.btnPasport.Name = "btnPasport";
            this.btnPasport.Size = new System.Drawing.Size(126, 23);
            this.btnPasport.TabIndex = 9;
            this.btnPasport.Text = "Паспортные данные";
            this.btnPasport.UseVisualStyleBackColor = true;
            this.btnPasport.Click += new System.EventHandler(this.btnPasport_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.btnAdd.Location = new System.Drawing.Point(16, 265);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(126, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.btnEnd.Location = new System.Drawing.Point(170, 265);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(126, 23);
            this.btnEnd.TabIndex = 12;
            this.btnEnd.Text = "Закрыть";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnCode
            // 
            this.btnCode.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.btnCode.Location = new System.Drawing.Point(16, 181);
            this.btnCode.Name = "btnCode";
            this.btnCode.Size = new System.Drawing.Size(126, 23);
            this.btnCode.TabIndex = 7;
            this.btnCode.Text = "Поступление";
            this.btnCode.UseVisualStyleBackColor = true;
            this.btnCode.Click += new System.EventHandler(this.btnCode_Click);
            // 
            // Blank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(308, 300);
            this.Controls.Add(this.btnCode);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnPasport);
            this.Controls.Add(this.btnEGE);
            this.Controls.Add(this.btnParents);
            this.Controls.Add(this.btnDocs);
            this.Controls.Add(this.btnAdres);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tBox_Patron);
            this.Controls.Add(this.tBox_Name);
            this.Controls.Add(this.tBox_Surname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Blank";
            this.Text = "Бланк заполнения";
            this.Load += new System.EventHandler(this.Blank_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBox_Surname;
        private System.Windows.Forms.TextBox tBox_Name;
        private System.Windows.Forms.TextBox tBox_Patron;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button btnAdres;
        private System.Windows.Forms.Button btnDocs;
        private System.Windows.Forms.Button btnParents;
        private System.Windows.Forms.Button btnEGE;
        private System.Windows.Forms.Button btnPasport;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnCode;
    }
}

