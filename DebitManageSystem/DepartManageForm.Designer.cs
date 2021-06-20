namespace DebitManageSystem
{
    partial class DepartManageForm
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
            this.Title = new System.Windows.Forms.Label();
            this.DepartId_SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DepartId_DisplayTextBox = new System.Windows.Forms.TextBox();
            this.DepartNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.EndButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Title.Font = new System.Drawing.Font("Meiryo UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Title.Location = new System.Drawing.Point(72, 45);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(125, 37);
            this.Title.TabIndex = 0;
            this.Title.Text = "部門管理";
            // 
            // DepartId_SearchTextBox
            // 
            this.DepartId_SearchTextBox.Location = new System.Drawing.Point(299, 64);
            this.DepartId_SearchTextBox.Name = "DepartId_SearchTextBox";
            this.DepartId_SearchTextBox.Size = new System.Drawing.Size(113, 19);
            this.DepartId_SearchTextBox.TabIndex = 1;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(436, 60);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(84, 26);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "検索";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "部門コード";
            // 
            // DepartId_DisplayTextBox
            // 
            this.DepartId_DisplayTextBox.Location = new System.Drawing.Point(176, 157);
            this.DepartId_DisplayTextBox.Name = "DepartId_DisplayTextBox";
            this.DepartId_DisplayTextBox.Size = new System.Drawing.Size(113, 19);
            this.DepartId_DisplayTextBox.TabIndex = 4;
            // 
            // DepartNameTextBox
            // 
            this.DepartNameTextBox.Location = new System.Drawing.Point(176, 210);
            this.DepartNameTextBox.Name = "DepartNameTextBox";
            this.DepartNameTextBox.Size = new System.Drawing.Size(113, 19);
            this.DepartNameTextBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "部門名";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(12, 331);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(84, 26);
            this.UpdateButton.TabIndex = 7;
            this.UpdateButton.Text = "登録/更新";
            this.UpdateButton.UseVisualStyleBackColor = true;
            // 
            // EndButton
            // 
            this.EndButton.Location = new System.Drawing.Point(436, 331);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(84, 26);
            this.EndButton.TabIndex = 8;
            this.EndButton.Text = "終了";
            this.EndButton.UseVisualStyleBackColor = true;
            this.EndButton.Click += new System.EventHandler(this.EndButton_Click);
            // 
            // DepartManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 369);
            this.Controls.Add(this.EndButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.DepartNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DepartId_DisplayTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.DepartId_SearchTextBox);
            this.Controls.Add(this.Title);
            this.Name = "DepartManageForm";
            this.Text = "メニュー";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox DepartId_SearchTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DepartId_DisplayTextBox;
        private System.Windows.Forms.TextBox DepartNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button EndButton;
    }
}