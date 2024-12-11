namespace Cseresznye_DR0UUU_FORM
{
    partial class UserControl2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            kolcsonzeBindingSource = new BindingSource(components);
            kolcsonzesIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tagDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            konyvDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kolcsonzesDatumDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statuszDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kolcsonzeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { kolcsonzesIdDataGridViewTextBoxColumn, tagDataGridViewTextBoxColumn, konyvDataGridViewTextBoxColumn, kolcsonzesDatumDataGridViewTextBoxColumn, statuszDataGridViewTextBoxColumn });
            dataGridView1.DataSource = kolcsonzeBindingSource;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(412, 233);
            dataGridView1.TabIndex = 0;
            // 
            // kolcsonzeBindingSource
            // 
            kolcsonzeBindingSource.DataSource = typeof(LibraryModels.Kolcsonze);
            // 
            // kolcsonzesIdDataGridViewTextBoxColumn
            // 
            kolcsonzesIdDataGridViewTextBoxColumn.DataPropertyName = "KolcsonzesId";
            kolcsonzesIdDataGridViewTextBoxColumn.HeaderText = "KolcsonzesId";
            kolcsonzesIdDataGridViewTextBoxColumn.Name = "kolcsonzesIdDataGridViewTextBoxColumn";
            // 
            // tagDataGridViewTextBoxColumn
            // 
            tagDataGridViewTextBoxColumn.DataPropertyName = "Tag";
            tagDataGridViewTextBoxColumn.HeaderText = "Tag";
            tagDataGridViewTextBoxColumn.Name = "tagDataGridViewTextBoxColumn";
            // 
            // konyvDataGridViewTextBoxColumn
            // 
            konyvDataGridViewTextBoxColumn.DataPropertyName = "Konyv";
            konyvDataGridViewTextBoxColumn.HeaderText = "Konyv";
            konyvDataGridViewTextBoxColumn.Name = "konyvDataGridViewTextBoxColumn";
            // 
            // kolcsonzesDatumDataGridViewTextBoxColumn
            // 
            kolcsonzesDatumDataGridViewTextBoxColumn.DataPropertyName = "KolcsonzesDatum";
            kolcsonzesDatumDataGridViewTextBoxColumn.HeaderText = "KolcsonzesDatum";
            kolcsonzesDatumDataGridViewTextBoxColumn.Name = "kolcsonzesDatumDataGridViewTextBoxColumn";
            // 
            // statuszDataGridViewTextBoxColumn
            // 
            statuszDataGridViewTextBoxColumn.DataPropertyName = "Statusz";
            statuszDataGridViewTextBoxColumn.HeaderText = "Statusz";
            statuszDataGridViewTextBoxColumn.Name = "statuszDataGridViewTextBoxColumn";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox1.DataBindings.Add(new Binding("Text", kolcsonzeBindingSource, "KolcsonzesId", true));
            textBox1.Location = new Point(103, 257);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(40, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.DataBindings.Add(new Binding("Text", kolcsonzeBindingSource, "Tag", true));
            textBox2.Location = new Point(149, 257);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(174, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox3.DataBindings.Add(new Binding("Text", kolcsonzeBindingSource, "Konyv", true));
            textBox3.Location = new Point(103, 286);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(220, 23);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox4.DataBindings.Add(new Binding("Text", kolcsonzeBindingSource, "KolcsonzesDatum", true));
            textBox4.Location = new Point(103, 317);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(220, 23);
            textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox5.DataBindings.Add(new Binding("Text", kolcsonzeBindingSource, "Statusz", true));
            textBox5.Location = new Point(103, 346);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(220, 23);
            textBox5.TabIndex = 5;
            // 
            // UserControl2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Name = "UserControl2";
            Size = new Size(412, 394);
            Load += UserControl2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)kolcsonzeBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn kolcsonzesIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tagDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn konyvDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kolcsonzesDatumDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statuszDataGridViewTextBoxColumn;
        private BindingSource kolcsonzeBindingSource;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
    }
}
