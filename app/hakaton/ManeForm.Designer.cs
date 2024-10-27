namespace hakaton
{
    partial class ManeForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btclose = new System.Windows.Forms.Button();
            this.btmaxed = new System.Windows.Forms.Button();
            this.btmin = new System.Windows.Forms.Button();
            this.btmax = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btAnaliz = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sallerTB = new System.Windows.Forms.TextBox();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tovarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hackathonDataSet = new hakaton.hackathonDataSet();
            this.tovarTableAdapter = new hakaton.hackathonDataSetTableAdapters.TovarTableAdapter();
            this.iDtovaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sallerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costSaleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hackathonDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panelHeader, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1024, 622);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Controls.Add(this.label2);
            this.panelHeader.Controls.Add(this.btclose);
            this.panelHeader.Controls.Add(this.btmaxed);
            this.panelHeader.Controls.Add(this.btmin);
            this.panelHeader.Controls.Add(this.btmax);
            this.panelHeader.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(3, 3);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1018, 30);
            this.panelHeader.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::hakaton.Properties.Resources.icons8_демонстрация_экрана_24;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(473, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 1;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btclose
            // 
            this.btclose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btclose.FlatAppearance.BorderSize = 0;
            this.btclose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btclose.Image = global::hakaton.Properties.Resources.icons8_закрыть_окно_24;
            this.btclose.Location = new System.Drawing.Point(990, 0);
            this.btclose.Name = "btclose";
            this.btclose.Size = new System.Drawing.Size(25, 30);
            this.btclose.TabIndex = 1;
            this.btclose.UseVisualStyleBackColor = true;
            this.btclose.Click += new System.EventHandler(this.btclose_Click);
            // 
            // btmaxed
            // 
            this.btmaxed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btmaxed.FlatAppearance.BorderSize = 0;
            this.btmaxed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btmaxed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmaxed.Image = global::hakaton.Properties.Resources.icons8_демонстрация_экрана_24;
            this.btmaxed.Location = new System.Drawing.Point(857, 0);
            this.btmaxed.Name = "btmaxed";
            this.btmaxed.Size = new System.Drawing.Size(25, 30);
            this.btmaxed.TabIndex = 4;
            this.btmaxed.UseVisualStyleBackColor = true;
            this.btmaxed.Visible = false;
            this.btmaxed.Click += new System.EventHandler(this.btmaxed_Click);
            // 
            // btmin
            // 
            this.btmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btmin.FlatAppearance.BorderSize = 0;
            this.btmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmin.Image = global::hakaton.Properties.Resources.icons8_свернуть_окно_24;
            this.btmin.Location = new System.Drawing.Point(929, 0);
            this.btmin.Name = "btmin";
            this.btmin.Size = new System.Drawing.Size(25, 30);
            this.btmin.TabIndex = 3;
            this.btmin.UseVisualStyleBackColor = true;
            this.btmin.Click += new System.EventHandler(this.btmin_Click);
            // 
            // btmax
            // 
            this.btmax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btmax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btmax.FlatAppearance.BorderSize = 0;
            this.btmax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btmax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmax.Image = global::hakaton.Properties.Resources.icons8_скругленный_квадрат_24;
            this.btmax.Location = new System.Drawing.Point(960, 0);
            this.btmax.Name = "btmax";
            this.btmax.Size = new System.Drawing.Size(25, 30);
            this.btmax.TabIndex = 2;
            this.btmax.UseVisualStyleBackColor = true;
            this.btmax.Click += new System.EventHandler(this.btmax_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 39);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1018, 580);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btAnaliz);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 519);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1012, 58);
            this.panel2.TabIndex = 1;
            // 
            // btAnaliz
            // 
            this.btAnaliz.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btAnaliz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btAnaliz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAnaliz.FlatAppearance.BorderSize = 0;
            this.btAnaliz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAnaliz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btAnaliz.ForeColor = System.Drawing.Color.White;
            this.btAnaliz.Location = new System.Drawing.Point(865, 7);
            this.btAnaliz.Name = "btAnaliz";
            this.btAnaliz.Size = new System.Drawing.Size(141, 40);
            this.btAnaliz.TabIndex = 4;
            this.btAnaliz.Text = "Анализ";
            this.btAnaliz.UseVisualStyleBackColor = false;
            this.btAnaliz.Click += new System.EventHandler(this.btAnaliz_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1012, 510);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sallerTB);
            this.panel1.Controls.Add(this.nameTB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1006, 39);
            this.panel1.TabIndex = 0;
            // 
            // sallerTB
            // 
            this.sallerTB.Location = new System.Drawing.Point(274, 11);
            this.sallerTB.Name = "sallerTB";
            this.sallerTB.Size = new System.Drawing.Size(265, 20);
            this.sallerTB.TabIndex = 0;
            this.sallerTB.TextChanged += new System.EventHandler(this.sallerTB_TextChanged);
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(3, 11);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(265, 20);
            this.nameTB.TabIndex = 0;
            this.nameTB.TextChanged += new System.EventHandler(this.nameTB_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDtovaraDataGridViewTextBoxColumn,
            this.brendDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.sallerDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.costSaleDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tovarBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1006, 459);
            this.dataGridView1.TabIndex = 1;
            // 
            // tovarBindingSource
            // 
            this.tovarBindingSource.DataMember = "Tovar";
            this.tovarBindingSource.DataSource = this.hackathonDataSet;
            // 
            // hackathonDataSet
            // 
            this.hackathonDataSet.DataSetName = "hackathonDataSet";
            this.hackathonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tovarTableAdapter
            // 
            this.tovarTableAdapter.ClearBeforeFill = true;
            // 
            // iDtovaraDataGridViewTextBoxColumn
            // 
            this.iDtovaraDataGridViewTextBoxColumn.DataPropertyName = "ID_tovara";
            this.iDtovaraDataGridViewTextBoxColumn.HeaderText = "ID_tovara";
            this.iDtovaraDataGridViewTextBoxColumn.Name = "iDtovaraDataGridViewTextBoxColumn";
            this.iDtovaraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // brendDataGridViewTextBoxColumn
            // 
            this.brendDataGridViewTextBoxColumn.DataPropertyName = "Brend";
            this.brendDataGridViewTextBoxColumn.HeaderText = "Бренд";
            this.brendDataGridViewTextBoxColumn.Name = "brendDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Название";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // sallerDataGridViewTextBoxColumn
            // 
            this.sallerDataGridViewTextBoxColumn.DataPropertyName = "Saller";
            this.sallerDataGridViewTextBoxColumn.HeaderText = "Продавец";
            this.sallerDataGridViewTextBoxColumn.Name = "sallerDataGridViewTextBoxColumn";
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            // 
            // costSaleDataGridViewTextBoxColumn
            // 
            this.costSaleDataGridViewTextBoxColumn.DataPropertyName = "CostSale";
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.costSaleDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.costSaleDataGridViewTextBoxColumn.HeaderText = "Цена с картой";
            this.costSaleDataGridViewTextBoxColumn.Name = "costSaleDataGridViewTextBoxColumn";
            // 
            // ManeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 622);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ManeForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hackathonDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btclose;
        private System.Windows.Forms.Button btmaxed;
        private System.Windows.Forms.Button btmin;
        private System.Windows.Forms.Button btmax;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btAnaliz;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private hackathonDataSet hackathonDataSet;
        private System.Windows.Forms.BindingSource tovarBindingSource;
        private hackathonDataSetTableAdapters.TovarTableAdapter tovarTableAdapter;
        private System.Windows.Forms.TextBox sallerTB;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDtovaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brendDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sallerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costSaleDataGridViewTextBoxColumn;
    }
}

