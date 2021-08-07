
namespace DebitManageSystem
{
    partial class InputCSVForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.FilePathTextBox = new System.Windows.Forms.TextBox();
            this.SearchFilePathButton = new System.Windows.Forms.Button();
            this.EndButton = new System.Windows.Forms.Button();
            this.ExecuteButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "CSVファイル";
            // 
            // FilePathTextBox
            // 
            this.FilePathTextBox.Location = new System.Drawing.Point(93, 32);
            this.FilePathTextBox.Name = "FilePathTextBox";
            this.FilePathTextBox.Size = new System.Drawing.Size(298, 19);
            this.FilePathTextBox.TabIndex = 1;
            // 
            // SearchFilePathButton
            // 
            this.SearchFilePathButton.Location = new System.Drawing.Point(388, 32);
            this.SearchFilePathButton.Name = "SearchFilePathButton";
            this.SearchFilePathButton.Size = new System.Drawing.Size(61, 19);
            this.SearchFilePathButton.TabIndex = 2;
            this.SearchFilePathButton.Text = "参照";
            this.SearchFilePathButton.UseVisualStyleBackColor = true;
            this.SearchFilePathButton.Click += new System.EventHandler(this.SearchFilePathButton_Click);
            // 
            // EndButton
            // 
            this.EndButton.Location = new System.Drawing.Point(720, 420);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(89, 30);
            this.EndButton.TabIndex = 3;
            this.EndButton.Text = "終了";
            this.EndButton.UseVisualStyleBackColor = true;
            this.EndButton.Click += new System.EventHandler(this.EndButton_Click);
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.Location = new System.Drawing.Point(492, 26);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(89, 30);
            this.ExecuteButton.TabIndex = 4;
            this.ExecuteButton.Text = "処理実行";
            this.ExecuteButton.UseVisualStyleBackColor = true;
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(787, 311);
            this.dataGridView1.TabIndex = 5;
            // 
            // InputCSVForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 462);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ExecuteButton);
            this.Controls.Add(this.EndButton);
            this.Controls.Add(this.SearchFilePathButton);
            this.Controls.Add(this.FilePathTextBox);
            this.Controls.Add(this.label1);
            this.Name = "InputCSVForm";
            this.Text = "CSV取込画面";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FilePathTextBox;
        private System.Windows.Forms.Button SearchFilePathButton;
        private System.Windows.Forms.Button EndButton;
        private System.Windows.Forms.Button ExecuteButton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}