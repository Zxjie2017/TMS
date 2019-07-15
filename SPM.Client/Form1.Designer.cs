namespace SPM.Client
{
    partial class DBManage
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_textConn = new System.Windows.Forms.Button();
            this.gv_TbView = new System.Windows.Forms.DataGridView();
            this.selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTbName = new System.Windows.Forms.TextBox();
            this.txtDto = new System.Windows.Forms.TextBox();
            this.txtEntity = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btn_Search = new System.Windows.Forms.Button();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpSql = new System.Windows.Forms.TabPage();
            this.tpCs = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.gv_TbView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpCs.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_textConn
            // 
            this.btn_textConn.Location = new System.Drawing.Point(131, 33);
            this.btn_textConn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_textConn.Name = "btn_textConn";
            this.btn_textConn.Size = new System.Drawing.Size(79, 29);
            this.btn_textConn.TabIndex = 0;
            this.btn_textConn.Text = "生成实体类";
            this.btn_textConn.UseVisualStyleBackColor = true;
            this.btn_textConn.Click += new System.EventHandler(this.btn_textConn_Click);
            // 
            // gv_TbView
            // 
            this.gv_TbView.AllowUserToAddRows = false;
            this.gv_TbView.AllowUserToDeleteRows = false;
            this.gv_TbView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gv_TbView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_TbView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selected,
            this.name,
            this.crdate});
            this.gv_TbView.Location = new System.Drawing.Point(2, 2);
            this.gv_TbView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gv_TbView.Name = "gv_TbView";
            this.gv_TbView.RowTemplate.Height = 30;
            this.gv_TbView.Size = new System.Drawing.Size(315, 486);
            this.gv_TbView.TabIndex = 1;
            this.gv_TbView.DoubleClick += new System.EventHandler(this.gv_TbView_DoubleClick);
            // 
            // selected
            // 
            this.selected.DataPropertyName = "selected";
            this.selected.HeaderText = "选择";
            this.selected.Name = "selected";
            this.selected.TrueValue = "1";
            this.selected.Width = 50;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "表名";
            this.name.Name = "name";
            // 
            // crdate
            // 
            this.crdate.DataPropertyName = "crdate";
            this.crdate.HeaderText = "创建时间";
            this.crdate.Name = "crdate";
            this.crdate.Width = 120;
            // 
            // txtTbName
            // 
            this.txtTbName.Location = new System.Drawing.Point(8, 10);
            this.txtTbName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTbName.Name = "txtTbName";
            this.txtTbName.Size = new System.Drawing.Size(122, 21);
            this.txtTbName.TabIndex = 2;
            // 
            // txtDto
            // 
            this.txtDto.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDto.Location = new System.Drawing.Point(4, 4);
            this.txtDto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDto.Multiline = true;
            this.txtDto.Name = "txtDto";
            this.txtDto.Size = new System.Drawing.Size(234, 494);
            this.txtDto.TabIndex = 3;
            // 
            // txtEntity
            // 
            this.txtEntity.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtEntity.Location = new System.Drawing.Point(251, 4);
            this.txtEntity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEntity.Multiline = true;
            this.txtEntity.Name = "txtEntity";
            this.txtEntity.Size = new System.Drawing.Size(248, 494);
            this.txtEntity.TabIndex = 4;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(850, 597);
            this.splitContainer1.SplitterDistance = 326;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 5;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.btn_Search);
            this.splitContainer2.Panel1.Controls.Add(this.btn_textConn);
            this.splitContainer2.Panel1.Controls.Add(this.txtTbName);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.gv_TbView);
            this.splitContainer2.Size = new System.Drawing.Size(326, 597);
            this.splitContainer2.SplitterDistance = 96;
            this.splitContainer2.SplitterWidth = 2;
            this.splitContainer2.TabIndex = 0;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(133, 4);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(77, 28);
            this.btn_Search.TabIndex = 3;
            this.btn_Search.Text = "查询";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer3.Size = new System.Drawing.Size(522, 597);
            this.splitContainer3.SplitterDistance = 31;
            this.splitContainer3.SplitterWidth = 3;
            this.splitContainer3.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tpSql);
            this.tabControl1.Controls.Add(this.tpCs);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(511, 552);
            this.tabControl1.TabIndex = 5;
            // 
            // tpSql
            // 
            this.tpSql.Location = new System.Drawing.Point(4, 22);
            this.tpSql.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpSql.Name = "tpSql";
            this.tpSql.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpSql.Size = new System.Drawing.Size(503, 526);
            this.tpSql.TabIndex = 0;
            this.tpSql.Text = "Sql脚本";
            this.tpSql.UseVisualStyleBackColor = true;
            // 
            // tpCs
            // 
            this.tpCs.Controls.Add(this.txtEntity);
            this.tpCs.Controls.Add(this.txtDto);
            this.tpCs.Location = new System.Drawing.Point(4, 22);
            this.tpCs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpCs.Name = "tpCs";
            this.tpCs.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpCs.Size = new System.Drawing.Size(503, 526);
            this.tpCs.TabIndex = 1;
            this.tpCs.Text = "实体类";
            this.tpCs.UseVisualStyleBackColor = true;
            // 
            // DBManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 597);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DBManage";
            this.Text = "DBManage";
            this.Load += new System.EventHandler(this.DBManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_TbView)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tpCs.ResumeLayout(false);
            this.tpCs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_textConn;
        private System.Windows.Forms.DataGridView gv_TbView;
        private System.Windows.Forms.TextBox txtTbName;
        private System.Windows.Forms.TextBox txtDto;
        private System.Windows.Forms.TextBox txtEntity;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpSql;
        private System.Windows.Forms.TabPage tpCs;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selected;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn crdate;
    }
}

