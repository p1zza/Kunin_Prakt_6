namespace Kunin_Prakt_6
{
    partial class Form1
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
            this.FindKeys = new System.Windows.Forms.Button();
            this.p_label = new System.Windows.Forms.Label();
            this.q_label = new System.Windows.Forms.Label();
            this.Box_For_p = new System.Windows.Forms.TextBox();
            this.Box_For_q = new System.Windows.Forms.TextBox();
            this.OpenKey = new System.Windows.Forms.TextBox();
            this.ClosedKey = new System.Windows.Forms.TextBox();
            this.Refresh = new System.Windows.Forms.Button();
            this.label_User1 = new System.Windows.Forms.Label();
            this.label_User2 = new System.Windows.Forms.Label();
            this.label_User3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.OpenKeylabel = new System.Windows.Forms.Label();
            this.ClosedKeylabel = new System.Windows.Forms.Label();
            this.Person1_E = new System.Windows.Forms.Label();
            this.Person1_D = new System.Windows.Forms.Label();
            this.Person2_E = new System.Windows.Forms.Label();
            this.Person2_D = new System.Windows.Forms.Label();
            this.Person3_E = new System.Windows.Forms.Label();
            this.Person3_D = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StartAlghorytm = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SurnamePerson1 = new System.Windows.Forms.TextBox();
            this.SurnamePerson2 = new System.Windows.Forms.TextBox();
            this.SurnamePerson3 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // FindKeys
            // 
            this.FindKeys.Location = new System.Drawing.Point(37, 154);
            this.FindKeys.Name = "FindKeys";
            this.FindKeys.Size = new System.Drawing.Size(184, 28);
            this.FindKeys.TabIndex = 2;
            this.FindKeys.Text = "Найти пару ключей";
            this.FindKeys.UseVisualStyleBackColor = true;
            this.FindKeys.Click += new System.EventHandler(this.FindKeys_Click);
            // 
            // p_label
            // 
            this.p_label.AutoSize = true;
            this.p_label.Location = new System.Drawing.Point(12, 21);
            this.p_label.Name = "p_label";
            this.p_label.Size = new System.Drawing.Size(125, 13);
            this.p_label.TabIndex = 3;
            this.p_label.Text = "Введите натуральное p";
            // 
            // q_label
            // 
            this.q_label.AutoSize = true;
            this.q_label.Location = new System.Drawing.Point(12, 43);
            this.q_label.Name = "q_label";
            this.q_label.Size = new System.Drawing.Size(125, 13);
            this.q_label.TabIndex = 4;
            this.q_label.Text = "Введите натуральное q";
            // 
            // Box_For_p
            // 
            this.Box_For_p.Location = new System.Drawing.Point(164, 21);
            this.Box_For_p.Name = "Box_For_p";
            this.Box_For_p.Size = new System.Drawing.Size(57, 20);
            this.Box_For_p.TabIndex = 5;
            // 
            // Box_For_q
            // 
            this.Box_For_q.Location = new System.Drawing.Point(164, 43);
            this.Box_For_q.Name = "Box_For_q";
            this.Box_For_q.Size = new System.Drawing.Size(57, 20);
            this.Box_For_q.TabIndex = 6;
            // 
            // OpenKey
            // 
            this.OpenKey.Location = new System.Drawing.Point(121, 86);
            this.OpenKey.Name = "OpenKey";
            this.OpenKey.Size = new System.Drawing.Size(100, 20);
            this.OpenKey.TabIndex = 7;
            // 
            // ClosedKey
            // 
            this.ClosedKey.Location = new System.Drawing.Point(121, 112);
            this.ClosedKey.Name = "ClosedKey";
            this.ClosedKey.Size = new System.Drawing.Size(100, 20);
            this.ClosedKey.TabIndex = 8;
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(37, 195);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(184, 23);
            this.Refresh.TabIndex = 9;
            this.Refresh.Text = "Обновить пару с тем же N";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // label_User1
            // 
            this.label_User1.AutoSize = true;
            this.label_User1.Location = new System.Drawing.Point(47, 0);
            this.label_User1.Name = "label_User1";
            this.label_User1.Size = new System.Drawing.Size(35, 13);
            this.label_User1.TabIndex = 10;
            this.label_User1.Text = "User1";
            // 
            // label_User2
            // 
            this.label_User2.AutoSize = true;
            this.label_User2.Location = new System.Drawing.Point(101, 0);
            this.label_User2.Name = "label_User2";
            this.label_User2.Size = new System.Drawing.Size(35, 13);
            this.label_User2.TabIndex = 11;
            this.label_User2.Text = "User2";
            // 
            // label_User3
            // 
            this.label_User3.AutoSize = true;
            this.label_User3.Location = new System.Drawing.Point(160, 0);
            this.label_User3.Name = "label_User3";
            this.label_User3.Size = new System.Drawing.Size(35, 13);
            this.label_User3.TabIndex = 12;
            this.label_User3.Text = "User3";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.54546F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel1.Controls.Add(this.label_User3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_User2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_User1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.OpenKeylabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ClosedKeylabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Person1_E, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Person1_D, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Person2_E, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.Person2_D, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.Person3_E, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.Person3_D, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.button2, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.button3, 3, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 275);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.54546F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(236, 137);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // OpenKeylabel
            // 
            this.OpenKeylabel.AutoSize = true;
            this.OpenKeylabel.Location = new System.Drawing.Point(3, 28);
            this.OpenKeylabel.Name = "OpenKeylabel";
            this.OpenKeylabel.Size = new System.Drawing.Size(32, 13);
            this.OpenKeylabel.TabIndex = 13;
            this.OpenKeylabel.Text = "Откр";
            // 
            // ClosedKeylabel
            // 
            this.ClosedKeylabel.AutoSize = true;
            this.ClosedKeylabel.Location = new System.Drawing.Point(3, 52);
            this.ClosedKeylabel.Name = "ClosedKeylabel";
            this.ClosedKeylabel.Size = new System.Drawing.Size(32, 13);
            this.ClosedKeylabel.TabIndex = 14;
            this.ClosedKeylabel.Text = "Закр";
            // 
            // Person1_E
            // 
            this.Person1_E.AutoSize = true;
            this.Person1_E.Location = new System.Drawing.Point(47, 28);
            this.Person1_E.Name = "Person1_E";
            this.Person1_E.Size = new System.Drawing.Size(14, 13);
            this.Person1_E.TabIndex = 15;
            this.Person1_E.Text = "E";
            // 
            // Person1_D
            // 
            this.Person1_D.AutoSize = true;
            this.Person1_D.Location = new System.Drawing.Point(47, 52);
            this.Person1_D.Name = "Person1_D";
            this.Person1_D.Size = new System.Drawing.Size(15, 13);
            this.Person1_D.TabIndex = 16;
            this.Person1_D.Text = "D";
            // 
            // Person2_E
            // 
            this.Person2_E.AutoSize = true;
            this.Person2_E.Location = new System.Drawing.Point(101, 28);
            this.Person2_E.Name = "Person2_E";
            this.Person2_E.Size = new System.Drawing.Size(14, 13);
            this.Person2_E.TabIndex = 17;
            this.Person2_E.Text = "E";
            // 
            // Person2_D
            // 
            this.Person2_D.AutoSize = true;
            this.Person2_D.Location = new System.Drawing.Point(101, 52);
            this.Person2_D.Name = "Person2_D";
            this.Person2_D.Size = new System.Drawing.Size(15, 13);
            this.Person2_D.TabIndex = 18;
            this.Person2_D.Text = "D";
            // 
            // Person3_E
            // 
            this.Person3_E.AutoSize = true;
            this.Person3_E.Location = new System.Drawing.Point(160, 28);
            this.Person3_E.Name = "Person3_E";
            this.Person3_E.Size = new System.Drawing.Size(14, 13);
            this.Person3_E.TabIndex = 19;
            this.Person3_E.Text = "E";
            // 
            // Person3_D
            // 
            this.Person3_D.AutoSize = true;
            this.Person3_D.Location = new System.Drawing.Point(160, 52);
            this.Person3_D.Name = "Person3_D";
            this.Person3_D.Size = new System.Drawing.Size(15, 13);
            this.Person3_D.TabIndex = 20;
            this.Person3_D.Text = "D";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel2.Controls.Add(this.SurnamePerson1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.SurnamePerson2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.SurnamePerson3, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(267, 79);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.63636F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.36364F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(303, 139);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Открытый ключ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Закрытый ключ";
            // 
            // StartAlghorytm
            // 
            this.StartAlghorytm.Location = new System.Drawing.Point(267, 21);
            this.StartAlghorytm.Name = "StartAlghorytm";
            this.StartAlghorytm.Size = new System.Drawing.Size(303, 23);
            this.StartAlghorytm.TabIndex = 17;
            this.StartAlghorytm.Text = "Перенести данные для вычислений";
            this.StartAlghorytm.UseVisualStyleBackColor = true;
            this.StartAlghorytm.Click += new System.EventHandler(this.StartAlghorytm_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(160, 75);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 23);
            this.button3.TabIndex = 23;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(101, 75);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(358, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Введите буквы фамилии";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SurnamePerson1
            // 
            this.SurnamePerson1.Location = new System.Drawing.Point(3, 3);
            this.SurnamePerson1.MaxLength = 1;
            this.SurnamePerson1.Name = "SurnamePerson1";
            this.SurnamePerson1.Size = new System.Drawing.Size(100, 20);
            this.SurnamePerson1.TabIndex = 0;
            // 
            // SurnamePerson2
            // 
            this.SurnamePerson2.Location = new System.Drawing.Point(109, 3);
            this.SurnamePerson2.MaxLength = 1;
            this.SurnamePerson2.Name = "SurnamePerson2";
            this.SurnamePerson2.Size = new System.Drawing.Size(100, 20);
            this.SurnamePerson2.TabIndex = 1;
            // 
            // SurnamePerson3
            // 
            this.SurnamePerson3.Location = new System.Drawing.Point(215, 3);
            this.SurnamePerson3.MaxLength = 1;
            this.SurnamePerson3.Name = "SurnamePerson3";
            this.SurnamePerson3.Size = new System.Drawing.Size(85, 20);
            this.SurnamePerson3.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 439);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StartAlghorytm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.ClosedKey);
            this.Controls.Add(this.OpenKey);
            this.Controls.Add(this.Box_For_q);
            this.Controls.Add(this.Box_For_p);
            this.Controls.Add(this.q_label);
            this.Controls.Add(this.p_label);
            this.Controls.Add(this.FindKeys);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button FindKeys;
        private System.Windows.Forms.Label p_label;
        private System.Windows.Forms.Label q_label;
        private System.Windows.Forms.TextBox Box_For_p;
        private System.Windows.Forms.TextBox Box_For_q;
        private System.Windows.Forms.TextBox OpenKey;
        private System.Windows.Forms.TextBox ClosedKey;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Label label_User1;
        private System.Windows.Forms.Label label_User2;
        private System.Windows.Forms.Label label_User3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label OpenKeylabel;
        private System.Windows.Forms.Label ClosedKeylabel;
        private System.Windows.Forms.Label Person1_E;
        private System.Windows.Forms.Label Person1_D;
        private System.Windows.Forms.Label Person2_E;
        private System.Windows.Forms.Label Person2_D;
        private System.Windows.Forms.Label Person3_E;
        private System.Windows.Forms.Label Person3_D;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox SurnamePerson1;
        private System.Windows.Forms.TextBox SurnamePerson2;
        private System.Windows.Forms.TextBox SurnamePerson3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button StartAlghorytm;
        private System.Windows.Forms.Label label3;
    }
}

