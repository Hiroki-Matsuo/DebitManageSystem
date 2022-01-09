
namespace DebitManageSystem
{
    partial class ClientManageForm
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
            this.EndButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.ClientNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ClientId_DisplayTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ClientId_SearchTextBox = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.Label();
            this.ClientGridView = new System.Windows.Forms.DataGridView();
            this.clientidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debittableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienttableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ClientGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienttableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // EndButton
            // 
            this.EndButton.Location = new System.Drawing.Point(431, 370);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(84, 26);
            this.EndButton.TabIndex = 17;
            this.EndButton.Text = "終了";
            this.EndButton.UseVisualStyleBackColor = true;
            this.EndButton.Click += new System.EventHandler(this.EndButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(341, 370);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(84, 26);
            this.UpdateButton.TabIndex = 16;
            this.UpdateButton.Text = "登録/更新";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // ClientNameTextBox
            // 
            this.ClientNameTextBox.Location = new System.Drawing.Point(372, 170);
            this.ClientNameTextBox.Name = "ClientNameTextBox";
            this.ClientNameTextBox.Size = new System.Drawing.Size(113, 19);
            this.ClientNameTextBox.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "取引先名";
            // 
            // ClientId_DisplayTextBox
            // 
            this.ClientId_DisplayTextBox.Location = new System.Drawing.Point(372, 145);
            this.ClientId_DisplayTextBox.Name = "ClientId_DisplayTextBox";
            this.ClientId_DisplayTextBox.Size = new System.Drawing.Size(113, 19);
            this.ClientId_DisplayTextBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "取引先コード";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(401, 52);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(84, 26);
            this.SearchButton.TabIndex = 11;
            this.SearchButton.Text = "検索";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ClientId_SearchTextBox
            // 
            this.ClientId_SearchTextBox.Location = new System.Drawing.Point(282, 56);
            this.ClientId_SearchTextBox.Name = "ClientId_SearchTextBox";
            this.ClientId_SearchTextBox.Size = new System.Drawing.Size(113, 19);
            this.ClientId_SearchTextBox.TabIndex = 10;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Title.Font = new System.Drawing.Font("Meiryo UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Title.Location = new System.Drawing.Point(12, 38);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(152, 37);
            this.Title.TabIndex = 9;
            this.Title.Text = "取引先管理";
            // 
            // ClientGridView
            // 
            this.ClientGridView.AutoGenerateColumns = false;
            this.ClientGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientidDataGridViewTextBoxColumn,
            this.clientnameDataGridViewTextBoxColumn,
            this.debittableDataGridViewTextBoxColumn});
            this.ClientGridView.DataSource = this.clienttableBindingSource;
            this.ClientGridView.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.ClientGridView.Location = new System.Drawing.Point(12, 127);
            this.ClientGridView.Name = "ClientGridView";
            this.ClientGridView.ReadOnly = true;
            this.ClientGridView.RowTemplate.Height = 21;
            this.ClientGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClientGridView.Size = new System.Drawing.Size(270, 272);
            this.ClientGridView.TabIndex = 18;
            this.ClientGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientGridView_CellDoubleClick);
            // 
            // clientidDataGridViewTextBoxColumn
            // 
            this.clientidDataGridViewTextBoxColumn.DataPropertyName = "client_id";
            this.clientidDataGridViewTextBoxColumn.HeaderText = "取引先CD";
            this.clientidDataGridViewTextBoxColumn.Name = "clientidDataGridViewTextBoxColumn";
            this.clientidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientnameDataGridViewTextBoxColumn
            // 
            this.clientnameDataGridViewTextBoxColumn.DataPropertyName = "client_name";
            this.clientnameDataGridViewTextBoxColumn.HeaderText = "取引先名称";
            this.clientnameDataGridViewTextBoxColumn.Name = "clientnameDataGridViewTextBoxColumn";
            this.clientnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // debittableDataGridViewTextBoxColumn
            // 
            this.debittableDataGridViewTextBoxColumn.DataPropertyName = "debit_table";
            this.debittableDataGridViewTextBoxColumn.HeaderText = "debit_table";
            this.debittableDataGridViewTextBoxColumn.Name = "debittableDataGridViewTextBoxColumn";
            this.debittableDataGridViewTextBoxColumn.ReadOnly = true;
            this.debittableDataGridViewTextBoxColumn.Visible = false;
            // 
            // clienttableBindingSource
            // 
            this.clienttableBindingSource.DataSource = typeof(DebitManageSystem.client_table);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 19;
            this.label3.Text = "○全件リスト";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 12);
            this.label4.TabIndex = 20;
            this.label4.Text = "ID検索";
            // 
            // ClientManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 408);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ClientGridView);
            this.Controls.Add(this.EndButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.ClientNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ClientId_DisplayTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.ClientId_SearchTextBox);
            this.Controls.Add(this.Title);
            this.Name = "ClientManageForm";
            this.Text = "ClientManageForm";
            ((System.ComponentModel.ISupportInitialize)(this.ClientGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienttableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EndButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.TextBox ClientNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ClientId_DisplayTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox ClientId_SearchTextBox;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.DataGridView ClientGridView;
        private System.Windows.Forms.BindingSource clienttableBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn debittableDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
    }
}