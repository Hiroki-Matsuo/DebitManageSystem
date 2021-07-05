
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
            this.EndButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.ClientNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ClientId_DisplayTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ClientId_SearchTextBox = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EndButton
            // 
            this.EndButton.Location = new System.Drawing.Point(401, 323);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(84, 26);
            this.EndButton.TabIndex = 17;
            this.EndButton.Text = "終了";
            this.EndButton.UseVisualStyleBackColor = true;
            this.EndButton.Click += new System.EventHandler(this.EndButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(12, 323);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(84, 26);
            this.UpdateButton.TabIndex = 16;
            this.UpdateButton.Text = "登録/更新";
            this.UpdateButton.UseVisualStyleBackColor = true;
            // 
            // ClientNameTextBox
            // 
            this.ClientNameTextBox.Location = new System.Drawing.Point(176, 202);
            this.ClientNameTextBox.Name = "ClientNameTextBox";
            this.ClientNameTextBox.Size = new System.Drawing.Size(113, 19);
            this.ClientNameTextBox.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "取引先名";
            // 
            // ClientId_DisplayTextBox
            // 
            this.ClientId_DisplayTextBox.Location = new System.Drawing.Point(176, 149);
            this.ClientId_DisplayTextBox.Name = "ClientId_DisplayTextBox";
            this.ClientId_DisplayTextBox.Size = new System.Drawing.Size(113, 19);
            this.ClientId_DisplayTextBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 152);
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
            // 
            // ClientId_SearchTextBox
            // 
            this.ClientId_SearchTextBox.Location = new System.Drawing.Point(243, 56);
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
            // ClientManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 408);
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
    }
}