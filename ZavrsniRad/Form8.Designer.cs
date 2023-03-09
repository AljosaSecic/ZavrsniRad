
namespace ZavrsniRad
{
    partial class Form8
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeIgriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zanrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.singleILIMultiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.platformaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objavljenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daLiSeUpdejtujeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daLiImaNastavakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.igriceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.igriceDataSet = new ZavrsniRad.IgriceDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.igriceTableAdapter = new ZavrsniRad.IgriceDataSetTableAdapters.IgriceTableAdapter();
            this.igriceDataSet1 = new ZavrsniRad.IgriceDataSet();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.igriceLinkoviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.linkoviTableAdapter = new ZavrsniRad.IgriceDataSetTableAdapters.LinkoviTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igriceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igriceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igriceDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igriceLinkoviBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 33;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.imeIgriceDataGridViewTextBoxColumn,
            this.zanrDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.singleILIMultiDataGridViewTextBoxColumn,
            this.platformaDataGridViewTextBoxColumn,
            this.objavljenaDataGridViewTextBoxColumn,
            this.daLiSeUpdejtujeDataGridViewTextBoxColumn,
            this.daLiImaNastavakDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.igriceBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(477, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(251, 156);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // imeIgriceDataGridViewTextBoxColumn
            // 
            this.imeIgriceDataGridViewTextBoxColumn.DataPropertyName = "Ime igrice";
            this.imeIgriceDataGridViewTextBoxColumn.HeaderText = "Ime igrice";
            this.imeIgriceDataGridViewTextBoxColumn.Name = "imeIgriceDataGridViewTextBoxColumn";
            this.imeIgriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.imeIgriceDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // zanrDataGridViewTextBoxColumn
            // 
            this.zanrDataGridViewTextBoxColumn.DataPropertyName = "Zanr";
            this.zanrDataGridViewTextBoxColumn.HeaderText = "Zanr";
            this.zanrDataGridViewTextBoxColumn.Name = "zanrDataGridViewTextBoxColumn";
            this.zanrDataGridViewTextBoxColumn.ReadOnly = true;
            this.zanrDataGridViewTextBoxColumn.Visible = false;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.ReadOnly = true;
            this.ageDataGridViewTextBoxColumn.Visible = false;
            // 
            // singleILIMultiDataGridViewTextBoxColumn
            // 
            this.singleILIMultiDataGridViewTextBoxColumn.DataPropertyName = "SingleILIMulti";
            this.singleILIMultiDataGridViewTextBoxColumn.HeaderText = "SingleILIMulti";
            this.singleILIMultiDataGridViewTextBoxColumn.Name = "singleILIMultiDataGridViewTextBoxColumn";
            this.singleILIMultiDataGridViewTextBoxColumn.ReadOnly = true;
            this.singleILIMultiDataGridViewTextBoxColumn.Visible = false;
            // 
            // platformaDataGridViewTextBoxColumn
            // 
            this.platformaDataGridViewTextBoxColumn.DataPropertyName = "Platforma";
            this.platformaDataGridViewTextBoxColumn.HeaderText = "Platforma";
            this.platformaDataGridViewTextBoxColumn.Name = "platformaDataGridViewTextBoxColumn";
            this.platformaDataGridViewTextBoxColumn.ReadOnly = true;
            this.platformaDataGridViewTextBoxColumn.Visible = false;
            // 
            // objavljenaDataGridViewTextBoxColumn
            // 
            this.objavljenaDataGridViewTextBoxColumn.DataPropertyName = "Objavljena";
            this.objavljenaDataGridViewTextBoxColumn.HeaderText = "Objavljena";
            this.objavljenaDataGridViewTextBoxColumn.Name = "objavljenaDataGridViewTextBoxColumn";
            this.objavljenaDataGridViewTextBoxColumn.ReadOnly = true;
            this.objavljenaDataGridViewTextBoxColumn.Visible = false;
            // 
            // daLiSeUpdejtujeDataGridViewTextBoxColumn
            // 
            this.daLiSeUpdejtujeDataGridViewTextBoxColumn.DataPropertyName = "DaLiSeUpdejtuje";
            this.daLiSeUpdejtujeDataGridViewTextBoxColumn.HeaderText = "DaLiSeUpdejtuje";
            this.daLiSeUpdejtujeDataGridViewTextBoxColumn.Name = "daLiSeUpdejtujeDataGridViewTextBoxColumn";
            this.daLiSeUpdejtujeDataGridViewTextBoxColumn.ReadOnly = true;
            this.daLiSeUpdejtujeDataGridViewTextBoxColumn.Visible = false;
            // 
            // daLiImaNastavakDataGridViewTextBoxColumn
            // 
            this.daLiImaNastavakDataGridViewTextBoxColumn.DataPropertyName = "DaLiImaNastavak";
            this.daLiImaNastavakDataGridViewTextBoxColumn.HeaderText = "DaLiImaNastavak";
            this.daLiImaNastavakDataGridViewTextBoxColumn.Name = "daLiImaNastavakDataGridViewTextBoxColumn";
            this.daLiImaNastavakDataGridViewTextBoxColumn.ReadOnly = true;
            this.daLiImaNastavakDataGridViewTextBoxColumn.Visible = false;
            // 
            // igriceBindingSource
            // 
            this.igriceBindingSource.DataMember = "Igrice";
            this.igriceBindingSource.DataSource = this.igriceDataSet;
            // 
            // igriceDataSet
            // 
            this.igriceDataSet.DataSetName = "IgriceDataSet";
            this.igriceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(857, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 45);
            this.button1.TabIndex = 1;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // igriceTableAdapter
            // 
            this.igriceTableAdapter.ClearBeforeFill = true;
            // 
            // igriceDataSet1
            // 
            this.igriceDataSet1.DataSetName = "IgriceDataSet";
            this.igriceDataSet1.Locale = new System.Globalization.CultureInfo("en-US");
            this.igriceDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.linkDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.igriceLinkoviBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(243, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(228, 115);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.Visible = false;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            // 
            // linkDataGridViewTextBoxColumn
            // 
            this.linkDataGridViewTextBoxColumn.DataPropertyName = "Link";
            this.linkDataGridViewTextBoxColumn.HeaderText = "Link";
            this.linkDataGridViewTextBoxColumn.Name = "linkDataGridViewTextBoxColumn";
            // 
            // igriceLinkoviBindingSource
            // 
            this.igriceLinkoviBindingSource.AllowNew = true;
            this.igriceLinkoviBindingSource.DataMember = "Linkovi";
            this.igriceLinkoviBindingSource.DataSource = this.igriceDataSet;
            // 
            // linkoviTableAdapter
            // 
            this.linkoviTableAdapter.ClearBeforeFill = true;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1204, 661);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mysting Gaming";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igriceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igriceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igriceDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igriceLinkoviBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private IgriceDataSet igriceDataSet;
        private System.Windows.Forms.BindingSource igriceBindingSource;
        private IgriceDataSetTableAdapters.IgriceTableAdapter igriceTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeIgriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zanrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn singleILIMultiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn platformaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn objavljenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn daLiSeUpdejtujeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn daLiImaNastavakDataGridViewTextBoxColumn;
        private IgriceDataSet igriceDataSet1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource igriceLinkoviBindingSource;
        private IgriceDataSetTableAdapters.LinkoviTableAdapter linkoviTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn linkDataGridViewTextBoxColumn;
    }
}