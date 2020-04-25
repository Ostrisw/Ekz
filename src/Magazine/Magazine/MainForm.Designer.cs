namespace Magazine
{
    partial class MainForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtBoxIzdatel = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblIzdatel = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.txtBoxPrice = new System.Windows.Forms.TextBox();
            this.txtBoxNumber = new System.Windows.Forms.TextBox();
            this.txtBoxFilePath = new System.Windows.Forms.TextBox();
            this.btnFilePath = new System.Windows.Forms.Button();
            this.lblFilePath = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(669, 217);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtBoxIzdatel
            // 
            this.txtBoxIzdatel.Location = new System.Drawing.Point(253, 24);
            this.txtBoxIzdatel.Name = "txtBoxIzdatel";
            this.txtBoxIzdatel.Size = new System.Drawing.Size(135, 20);
            this.txtBoxIzdatel.TabIndex = 1;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(522, 58);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(135, 22);
            this.btn_send.TabIndex = 3;
            this.btn_send.Text = "Отправить";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(12, 21);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(135, 20);
            this.txtBoxName.TabIndex = 5;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(167, 21);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(57, 13);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Название";
            // 
            // lblIzdatel
            // 
            this.lblIzdatel.AutoSize = true;
            this.lblIzdatel.Location = new System.Drawing.Point(409, 24);
            this.lblIzdatel.Name = "lblIzdatel";
            this.lblIzdatel.Size = new System.Drawing.Size(56, 13);
            this.lblIzdatel.TabIndex = 9;
            this.lblIzdatel.Text = "Издатель";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(168, 58);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(33, 13);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "Цена";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(409, 59);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(69, 13);
            this.lblNumber.TabIndex = 11;
            this.lblNumber.Text = "Номер ISSN";
            // 
            // txtBoxPrice
            // 
            this.txtBoxPrice.Location = new System.Drawing.Point(12, 59);
            this.txtBoxPrice.Name = "txtBoxPrice";
            this.txtBoxPrice.Size = new System.Drawing.Size(135, 20);
            this.txtBoxPrice.TabIndex = 12;
            // 
            // txtBoxNumber
            // 
            this.txtBoxNumber.Location = new System.Drawing.Point(253, 59);
            this.txtBoxNumber.Name = "txtBoxNumber";
            this.txtBoxNumber.Size = new System.Drawing.Size(135, 20);
            this.txtBoxNumber.TabIndex = 13;
            // 
            // txtBoxFilePath
            // 
            this.txtBoxFilePath.Location = new System.Drawing.Point(471, 18);
            this.txtBoxFilePath.Name = "txtBoxFilePath";
            this.txtBoxFilePath.Size = new System.Drawing.Size(186, 20);
            this.txtBoxFilePath.TabIndex = 17;
            // 
            // btnFilePath
            // 
            this.btnFilePath.Location = new System.Drawing.Point(656, 16);
            this.btnFilePath.Name = "btnFilePath";
            this.btnFilePath.Size = new System.Drawing.Size(25, 23);
            this.btnFilePath.TabIndex = 18;
            this.btnFilePath.Text = "...";
            this.btnFilePath.UseVisualStyleBackColor = true;
            this.btnFilePath.Click += new System.EventHandler(this.btnFilePath_Click);
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Location = new System.Drawing.Point(468, 2);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(74, 13);
            this.lblFilePath.TabIndex = 19;
            this.lblFilePath.Text = "Путь к файлу";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 346);
            this.Controls.Add(this.lblFilePath);
            this.Controls.Add(this.btnFilePath);
            this.Controls.Add(this.txtBoxFilePath);
            this.Controls.Add(this.txtBoxNumber);
            this.Controls.Add(this.txtBoxPrice);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblIzdatel);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.txtBoxIzdatel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainForm";
            this.Text = "Магазин";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtBoxIzdatel;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblIzdatel;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox txtBoxPrice;
        private System.Windows.Forms.TextBox txtBoxNumber;
        private System.Windows.Forms.TextBox txtBoxFilePath;
        private System.Windows.Forms.Button btnFilePath;
        private System.Windows.Forms.Label lblFilePath;
    }
}

