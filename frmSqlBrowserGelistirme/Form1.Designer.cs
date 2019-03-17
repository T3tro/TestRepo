namespace frmSqlBrowserGelistirme
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtServerName = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.txtUsername = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.txtPassword = new System.Windows.Forms.ToolStripTextBox();
            this.btnBaglan = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.cmbDatabases = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.cmbTables = new System.Windows.Forms.ToolStripComboBox();
            this.btnCalistir = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel7 = new System.Windows.Forms.ToolStripLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.clbColumns = new System.Windows.Forms.CheckedListBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.txtServerName,
            this.toolStripLabel2,
            this.txtUsername,
            this.toolStripLabel3,
            this.txtPassword,
            this.btnBaglan,
            this.toolStripLabel4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(709, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(94, 24);
            this.toolStripLabel1.Text = "Server Name";
            // 
            // txtServerName
            // 
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(100, 27);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(78, 24);
            this.toolStripLabel2.Text = "UserName";
            // 
            // txtUsername
            // 
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 27);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(70, 24);
            this.toolStripLabel3.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 27);
            // 
            // btnBaglan
            // 
            this.btnBaglan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBaglan.Image = ((System.Drawing.Image)(resources.GetObject("btnBaglan.Image")));
            this.btnBaglan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBaglan.Name = "btnBaglan";
            this.btnBaglan.Size = new System.Drawing.Size(24, 24);
            this.btnBaglan.Text = "Bağlan";
            this.btnBaglan.Click += new System.EventHandler(this.btnBaglan_Click);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(55, 24);
            this.toolStripLabel4.Text = "Bağlan";
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel5,
            this.cmbDatabases,
            this.toolStripLabel6,
            this.cmbTables,
            this.btnCalistir,
            this.toolStripLabel7});
            this.toolStrip2.Location = new System.Drawing.Point(0, 27);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(709, 28);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(78, 25);
            this.toolStripLabel5.Text = "Databases";
            // 
            // cmbDatabases
            // 
            this.cmbDatabases.Name = "cmbDatabases";
            this.cmbDatabases.Size = new System.Drawing.Size(121, 28);
            this.cmbDatabases.SelectedIndexChanged += new System.EventHandler(this.cmbDatabases_SelectedIndexChanged);
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(50, 25);
            this.toolStripLabel6.Text = "Tables";
            // 
            // cmbTables
            // 
            this.cmbTables.Name = "cmbTables";
            this.cmbTables.Size = new System.Drawing.Size(121, 28);
            this.cmbTables.SelectedIndexChanged += new System.EventHandler(this.cmbTables_SelectedIndexChanged);
            // 
            // btnCalistir
            // 
            this.btnCalistir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCalistir.Image = ((System.Drawing.Image)(resources.GetObject("btnCalistir.Image")));
            this.btnCalistir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCalistir.Name = "btnCalistir";
            this.btnCalistir.Size = new System.Drawing.Size(24, 25);
            this.btnCalistir.Tag = "";
            this.btnCalistir.Text = "Çalıştır";
            this.btnCalistir.Click += new System.EventHandler(this.btnCalistir_Click);
            // 
            // toolStripLabel7
            // 
            this.toolStripLabel7.Name = "toolStripLabel7";
            this.toolStripLabel7.Size = new System.Drawing.Size(54, 25);
            this.toolStripLabel7.Text = "Çalıştır";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 55);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.clbColumns);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(8);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(8);
            this.splitContainer1.Size = new System.Drawing.Size(709, 283);
            this.splitContainer1.SplitterDistance = 236;
            this.splitContainer1.TabIndex = 2;
            // 
            // clbColumns
            // 
            this.clbColumns.CheckOnClick = true;
            this.clbColumns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbColumns.FormattingEnabled = true;
            this.clbColumns.Location = new System.Drawing.Point(8, 8);
            this.clbColumns.Name = "clbColumns";
            this.clbColumns.Size = new System.Drawing.Size(220, 267);
            this.clbColumns.TabIndex = 0;
            this.clbColumns.SelectedIndexChanged += new System.EventHandler(this.clbColumns_SelectedIndexChanged);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(8, 8);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.txtQuery);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer2.Size = new System.Drawing.Size(453, 267);
            this.splitContainer2.SplitterDistance = 125;
            this.splitContainer2.TabIndex = 0;
            // 
            // txtQuery
            // 
            this.txtQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtQuery.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtQuery.Location = new System.Drawing.Point(0, 0);
            this.txtQuery.Multiline = true;
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtQuery.Size = new System.Drawing.Size(453, 125);
            this.txtQuery.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(453, 138);
            this.dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 338);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Sql Server Calismam";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtServerName;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox txtUsername;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripTextBox txtPassword;
        private System.Windows.Forms.ToolStripButton btnBaglan;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripComboBox cmbDatabases;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripComboBox cmbTables;
        private System.Windows.Forms.ToolStripButton btnCalistir;
        private System.Windows.Forms.ToolStripLabel toolStripLabel7;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckedListBox clbColumns;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

