
namespace DebitManageSystem
{
    partial class ListBaseForm
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
            this.ListGridView = new System.Windows.Forms.DataGridView();
            this.EndButton = new System.Windows.Forms.Button();
            this.ItemCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ListGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ListGridView
            // 
            this.ListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListGridView.Location = new System.Drawing.Point(21, 115);
            this.ListGridView.Name = "ListGridView";
            this.ListGridView.RowTemplate.Height = 21;
            this.ListGridView.Size = new System.Drawing.Size(748, 293);
            this.ListGridView.TabIndex = 6;
            // 
            // EndButton
            // 
            this.EndButton.Location = new System.Drawing.Point(680, 428);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(89, 30);
            this.EndButton.TabIndex = 7;
            this.EndButton.Text = "終了";
            this.EndButton.UseVisualStyleBackColor = true;
            this.EndButton.Click += new System.EventHandler(this.EndButton_Click);
            // 
            // ItemCombo
            // 
            this.ItemCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ItemCombo.FormattingEnabled = true;
            this.ItemCombo.Location = new System.Drawing.Point(89, 20);
            this.ItemCombo.Name = "ItemCombo";
            this.ItemCombo.Size = new System.Drawing.Size(121, 20);
            this.ItemCombo.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "項目";
            // 
            // ListBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ItemCombo);
            this.Controls.Add(this.EndButton);
            this.Controls.Add(this.ListGridView);
            this.Name = "ListBaseForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ListBaseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private protected System.Windows.Forms.DataGridView ListGridView;
        private protected System.Windows.Forms.Button EndButton;
        protected System.Windows.Forms.ComboBox ItemCombo;
        protected System.Windows.Forms.Label label1;
    }
}