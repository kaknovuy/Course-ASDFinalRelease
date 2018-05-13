namespace lab4Alg {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.text_skr = new System.Windows.Forms.TextBox();
            this.text_inf = new System.Windows.Forms.TextBox();
            this.text_key = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.butCreate = new System.Windows.Forms.Button();
            this.but_Add = new System.Windows.Forms.Button();
            this.but_Show = new System.Windows.Forms.Button();
            this.but_Find = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox_test = new System.Windows.Forms.TextBox();
            this.text_task = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.but_edit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text_skr
            // 
            this.text_skr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_skr.Location = new System.Drawing.Point(107, 26);
            this.text_skr.Name = "text_skr";
            this.text_skr.Size = new System.Drawing.Size(143, 23);
            this.text_skr.TabIndex = 1;
            // 
            // text_inf
            // 
            this.text_inf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_inf.Location = new System.Drawing.Point(107, 62);
            this.text_inf.Name = "text_inf";
            this.text_inf.Size = new System.Drawing.Size(143, 23);
            this.text_inf.TabIndex = 2;
            // 
            // text_key
            // 
            this.text_key.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_key.Location = new System.Drawing.Point(389, 24);
            this.text_key.Name = "text_key";
            this.text_key.Size = new System.Drawing.Size(143, 23);
            this.text_key.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Сокр. имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "информация";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(277, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ключ";
            // 
            // butCreate
            // 
            this.butCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCreate.Location = new System.Drawing.Point(11, 126);
            this.butCreate.Name = "butCreate";
            this.butCreate.Size = new System.Drawing.Size(157, 54);
            this.butCreate.TabIndex = 7;
            this.butCreate.Text = "Создать";
            this.butCreate.UseVisualStyleBackColor = true;
            this.butCreate.Click += new System.EventHandler(this.butCreate_Click);
            // 
            // but_Add
            // 
            this.but_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_Add.Location = new System.Drawing.Point(11, 186);
            this.but_Add.Name = "but_Add";
            this.but_Add.Size = new System.Drawing.Size(157, 54);
            this.but_Add.TabIndex = 8;
            this.but_Add.Text = "Добавить";
            this.but_Add.UseVisualStyleBackColor = true;
            this.but_Add.Click += new System.EventHandler(this.but_Add_Click);
            // 
            // but_Show
            // 
            this.but_Show.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_Show.Location = new System.Drawing.Point(11, 306);
            this.but_Show.Name = "but_Show";
            this.but_Show.Size = new System.Drawing.Size(157, 54);
            this.but_Show.TabIndex = 9;
            this.but_Show.Text = "Показать дерево";
            this.but_Show.UseVisualStyleBackColor = true;
            this.but_Show.Click += new System.EventHandler(this.but_Show_Click);
            // 
            // but_Find
            // 
            this.but_Find.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_Find.Location = new System.Drawing.Point(11, 425);
            this.but_Find.Name = "but_Find";
            this.but_Find.Size = new System.Drawing.Size(157, 54);
            this.but_Find.TabIndex = 10;
            this.but_Find.Text = "Найти";
            this.but_Find.UseVisualStyleBackColor = true;
            this.but_Find.Click += new System.EventHandler(this.but_Find_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(11, 485);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 54);
            this.button1.TabIndex = 11;
            this.button1.Text = "Удалить елемент";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(11, 545);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 54);
            this.button2.TabIndex = 12;
            this.button2.Text = "Удалить дерево";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox_test
            // 
            this.textBox_test.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_test.Location = new System.Drawing.Point(183, 126);
            this.textBox_test.Multiline = true;
            this.textBox_test.Name = "textBox_test";
            this.textBox_test.Size = new System.Drawing.Size(355, 471);
            this.textBox_test.TabIndex = 13;
            // 
            // text_task
            // 
            this.text_task.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_task.Location = new System.Drawing.Point(389, 62);
            this.text_task.Name = "text_task";
            this.text_task.Size = new System.Drawing.Size(143, 23);
            this.text_task.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(273, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Ключ родителя";
            // 
            // but_edit
            // 
            this.but_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_edit.Location = new System.Drawing.Point(11, 246);
            this.but_edit.Name = "but_edit";
            this.but_edit.Size = new System.Drawing.Size(157, 54);
            this.but_edit.TabIndex = 16;
            this.but_edit.Text = "Изменить";
            this.but_edit.UseVisualStyleBackColor = true;
            this.but_edit.Click += new System.EventHandler(this.but_edit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(334, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Дерево";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(11, 365);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(157, 54);
            this.button3.TabIndex = 18;
            this.button3.Text = "Показать элемент";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 609);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.but_edit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_task);
            this.Controls.Add(this.textBox_test);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.but_Find);
            this.Controls.Add(this.but_Show);
            this.Controls.Add(this.but_Add);
            this.Controls.Add(this.butCreate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_key);
            this.Controls.Add(this.text_inf);
            this.Controls.Add(this.text_skr);
            this.Name = "Form1";
            this.Text = "Вячеслав Мищенко 621п";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox text_skr;
        private System.Windows.Forms.TextBox text_inf;
        private System.Windows.Forms.TextBox text_key;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button butCreate;
        private System.Windows.Forms.Button but_Add;
        private System.Windows.Forms.Button but_Show;
        private System.Windows.Forms.Button but_Find;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox_test;
        private System.Windows.Forms.TextBox text_task;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button but_edit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
    }
}

