
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
            this.components = new System.ComponentModel.Container();
            this.CSVLabel = new System.Windows.Forms.Label();
            this.FilePathTextBox = new System.Windows.Forms.TextBox();
            this.SearchFilePathButton = new System.Windows.Forms.Button();
            this.InputButton = new System.Windows.Forms.Button();
            this.debitInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ExecuteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.debitInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CSVLabel
            // 
            this.CSVLabel.AutoSize = true;
            this.CSVLabel.Location = new System.Drawing.Point(20, 64);
            this.CSVLabel.Name = "CSVLabel";
            this.CSVLabel.Size = new System.Drawing.Size(62, 12);
            this.CSVLabel.TabIndex = 0;
            this.CSVLabel.Text = "CSVファイル";
            // 
            // FilePathTextBox
            // 
            this.FilePathTextBox.Location = new System.Drawing.Point(93, 64);
            this.FilePathTextBox.Name = "FilePathTextBox";
            this.FilePathTextBox.Size = new System.Drawing.Size(298, 19);
            this.FilePathTextBox.TabIndex = 1;
            // 
            // SearchFilePathButton
            // 
            this.SearchFilePathButton.Location = new System.Drawing.Point(388, 64);
            this.SearchFilePathButton.Name = "SearchFilePathButton";
            this.SearchFilePathButton.Size = new System.Drawing.Size(61, 19);
            this.SearchFilePathButton.TabIndex = 2;
            this.SearchFilePathButton.Text = "参照";
            this.SearchFilePathButton.UseVisualStyleBackColor = true;
            this.SearchFilePathButton.Click += new System.EventHandler(this.SearchFilePathButton_Click);
            // 
            // InputButton
            // 
            this.InputButton.Location = new System.Drawing.Point(492, 58);
            this.InputButton.Name = "InputButton";
            this.InputButton.Size = new System.Drawing.Size(89, 30);
            this.InputButton.TabIndex = 4;
            this.InputButton.Text = "データ表示";
            this.InputButton.UseVisualStyleBackColor = true;
            this.InputButton.Click += new System.EventHandler(this.InputButton_Click);
            // 
            // debitInfoBindingSource
            // 
            this.debitInfoBindingSource.DataSource = typeof(DebitManageSystem.DebitInfo);
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.Location = new System.Drawing.Point(610, 58);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(89, 30);
            this.ExecuteButton.TabIndex = 6;
            this.ExecuteButton.Text = "更新";
            this.ExecuteButton.UseVisualStyleBackColor = true;
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // InputCSVForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 476);
            this.Controls.Add(this.ExecuteButton);
            this.Controls.Add(this.InputButton);
            this.Controls.Add(this.SearchFilePathButton);
            this.Controls.Add(this.FilePathTextBox);
            this.Controls.Add(this.CSVLabel);
            this.Name = "InputCSVForm";
            this.Text = "CSV取込画面";
            this.Load += new System.EventHandler(this.InputCSVForm_Load);
            this.Controls.SetChildIndex(this.CSVLabel, 0);
            this.Controls.SetChildIndex(this.FilePathTextBox, 0);
            this.Controls.SetChildIndex(this.SearchFilePathButton, 0);
            this.Controls.SetChildIndex(this.InputButton, 0);
            this.Controls.SetChildIndex(this.ExecuteButton, 0);
            ((System.ComponentModel.ISupportInitialize)(this.debitInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CSVLabel;
        private System.Windows.Forms.TextBox FilePathTextBox;
        private System.Windows.Forms.Button SearchFilePathButton;
        private System.Windows.Forms.Button InputButton;
        private System.Windows.Forms.BindingSource debitInfoBindingSource;
        private System.Windows.Forms.Button ExecuteButton;
    }
}