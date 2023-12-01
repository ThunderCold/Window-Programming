namespace Practice8
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new Practice8.Database1DataSet();
            this.寶可夢招式BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.寶可夢_招式TableAdapter = new Practice8.Database1DataSetTableAdapters.寶可夢_招式TableAdapter();
            this.寶可夢DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.招式DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.relation1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.招式_屬性_威力TableAdapter = new Practice8.Database1DataSetTableAdapters.招式_屬性_威力TableAdapter();
            this.招式DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.屬性DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.威力DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.relation2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.屬性_克制屬性_被克制屬性TableAdapter = new Practice8.Database1DataSetTableAdapters.屬性_克制屬性_被克制屬性TableAdapter();
            this.屬性DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.克制屬性DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.被克制屬性DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.寶可夢招式BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relation1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relation2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.寶可夢DataGridViewTextBoxColumn,
            this.招式DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.寶可夢招式BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(720, 130);
            this.dataGridView1.TabIndex = 0;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 寶可夢招式BindingSource
            // 
            this.寶可夢招式BindingSource.DataMember = "寶可夢_招式";
            this.寶可夢招式BindingSource.DataSource = this.database1DataSet;
            // 
            // 寶可夢_招式TableAdapter
            // 
            this.寶可夢_招式TableAdapter.ClearBeforeFill = true;
            // 
            // 寶可夢DataGridViewTextBoxColumn
            // 
            this.寶可夢DataGridViewTextBoxColumn.DataPropertyName = "寶可夢";
            this.寶可夢DataGridViewTextBoxColumn.HeaderText = "寶可夢";
            this.寶可夢DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.寶可夢DataGridViewTextBoxColumn.Name = "寶可夢DataGridViewTextBoxColumn";
            this.寶可夢DataGridViewTextBoxColumn.Width = 125;
            // 
            // 招式DataGridViewTextBoxColumn
            // 
            this.招式DataGridViewTextBoxColumn.DataPropertyName = "招式";
            this.招式DataGridViewTextBoxColumn.HeaderText = "招式";
            this.招式DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.招式DataGridViewTextBoxColumn.Name = "招式DataGridViewTextBoxColumn";
            this.招式DataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.招式DataGridViewTextBoxColumn1,
            this.屬性DataGridViewTextBoxColumn,
            this.威力DataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.relation1BindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 148);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(720, 130);
            this.dataGridView2.TabIndex = 1;
            // 
            // relation1BindingSource
            // 
            this.relation1BindingSource.DataMember = "Relation_1";
            this.relation1BindingSource.DataSource = this.寶可夢招式BindingSource;
            // 
            // 招式_屬性_威力TableAdapter
            // 
            this.招式_屬性_威力TableAdapter.ClearBeforeFill = true;
            // 
            // 招式DataGridViewTextBoxColumn1
            // 
            this.招式DataGridViewTextBoxColumn1.DataPropertyName = "招式";
            this.招式DataGridViewTextBoxColumn1.HeaderText = "招式";
            this.招式DataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.招式DataGridViewTextBoxColumn1.Name = "招式DataGridViewTextBoxColumn1";
            this.招式DataGridViewTextBoxColumn1.Width = 125;
            // 
            // 屬性DataGridViewTextBoxColumn
            // 
            this.屬性DataGridViewTextBoxColumn.DataPropertyName = "屬性";
            this.屬性DataGridViewTextBoxColumn.HeaderText = "屬性";
            this.屬性DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.屬性DataGridViewTextBoxColumn.Name = "屬性DataGridViewTextBoxColumn";
            this.屬性DataGridViewTextBoxColumn.Width = 125;
            // 
            // 威力DataGridViewTextBoxColumn
            // 
            this.威力DataGridViewTextBoxColumn.DataPropertyName = "威力";
            this.威力DataGridViewTextBoxColumn.HeaderText = "威力";
            this.威力DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.威力DataGridViewTextBoxColumn.Name = "威力DataGridViewTextBoxColumn";
            this.威力DataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.屬性DataGridViewTextBoxColumn1,
            this.克制屬性DataGridViewTextBoxColumn,
            this.被克制屬性DataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.relation2BindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(12, 284);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 27;
            this.dataGridView3.Size = new System.Drawing.Size(720, 130);
            this.dataGridView3.TabIndex = 2;
            // 
            // relation2BindingSource
            // 
            this.relation2BindingSource.DataMember = "Relation_2";
            this.relation2BindingSource.DataSource = this.relation1BindingSource;
            // 
            // 屬性_克制屬性_被克制屬性TableAdapter
            // 
            this.屬性_克制屬性_被克制屬性TableAdapter.ClearBeforeFill = true;
            // 
            // 屬性DataGridViewTextBoxColumn1
            // 
            this.屬性DataGridViewTextBoxColumn1.DataPropertyName = "屬性";
            this.屬性DataGridViewTextBoxColumn1.HeaderText = "屬性";
            this.屬性DataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.屬性DataGridViewTextBoxColumn1.Name = "屬性DataGridViewTextBoxColumn1";
            this.屬性DataGridViewTextBoxColumn1.Width = 125;
            // 
            // 克制屬性DataGridViewTextBoxColumn
            // 
            this.克制屬性DataGridViewTextBoxColumn.DataPropertyName = "克制屬性";
            this.克制屬性DataGridViewTextBoxColumn.HeaderText = "克制屬性";
            this.克制屬性DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.克制屬性DataGridViewTextBoxColumn.Name = "克制屬性DataGridViewTextBoxColumn";
            this.克制屬性DataGridViewTextBoxColumn.Width = 125;
            // 
            // 被克制屬性DataGridViewTextBoxColumn
            // 
            this.被克制屬性DataGridViewTextBoxColumn.DataPropertyName = "被克制屬性";
            this.被克制屬性DataGridViewTextBoxColumn.HeaderText = "被克制屬性";
            this.被克制屬性DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.被克制屬性DataGridViewTextBoxColumn.Name = "被克制屬性DataGridViewTextBoxColumn";
            this.被克制屬性DataGridViewTextBoxColumn.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.寶可夢招式BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relation1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relation2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource 寶可夢招式BindingSource;
        private Database1DataSetTableAdapters.寶可夢_招式TableAdapter 寶可夢_招式TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 寶可夢DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 招式DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource relation1BindingSource;
        private Database1DataSetTableAdapters.招式_屬性_威力TableAdapter 招式_屬性_威力TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 招式DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 屬性DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 威力DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource relation2BindingSource;
        private Database1DataSetTableAdapters.屬性_克制屬性_被克制屬性TableAdapter 屬性_克制屬性_被克制屬性TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 屬性DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 克制屬性DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 被克制屬性DataGridViewTextBoxColumn;
    }
}

