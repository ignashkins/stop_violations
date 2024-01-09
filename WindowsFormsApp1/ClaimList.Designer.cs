namespace WindowsFormsApp1
{
    partial class ClaimList
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
            this.claimListView = new System.Windows.Forms.DataGridView();
            this.putNewClaim = new System.Windows.Forms.Button();
            this.claimText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.autoNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.stateListSelector = new System.Windows.Forms.ComboBox();
            this.cancelEditClaim = new System.Windows.Forms.Button();
            this.saveClaimItem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.claimListView)).BeginInit();
            this.SuspendLayout();
            // 
            // claimListView
            // 
            this.claimListView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.claimListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.claimListView.Location = new System.Drawing.Point(160, 12);
            this.claimListView.Name = "claimListView";
            this.claimListView.ReadOnly = true;
            this.claimListView.Size = new System.Drawing.Size(628, 426);
            this.claimListView.TabIndex = 0;
            this.claimListView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.claimListView_CellDoubleClick);
            // 
            // putNewClaim
            // 
            this.putNewClaim.Location = new System.Drawing.Point(12, 410);
            this.putNewClaim.Name = "putNewClaim";
            this.putNewClaim.Size = new System.Drawing.Size(142, 28);
            this.putNewClaim.TabIndex = 1;
            this.putNewClaim.Text = "Подать заявление";
            this.putNewClaim.UseVisualStyleBackColor = true;
            this.putNewClaim.Click += new System.EventHandler(this.putNewClaim_Click);
            // 
            // claimText
            // 
            this.claimText.Location = new System.Drawing.Point(12, 135);
            this.claimText.Multiline = true;
            this.claimText.Name = "claimText";
            this.claimText.Size = new System.Drawing.Size(142, 269);
            this.claimText.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Опишите свое заявление";
            // 
            // autoNumber
            // 
            this.autoNumber.Location = new System.Drawing.Point(12, 43);
            this.autoNumber.Name = "autoNumber";
            this.autoNumber.Size = new System.Drawing.Size(142, 20);
            this.autoNumber.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Укажите номер авто";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Текущий статус";
            // 
            // stateListSelector
            // 
            this.stateListSelector.FormattingEnabled = true;
            this.stateListSelector.Location = new System.Drawing.Point(12, 89);
            this.stateListSelector.Name = "stateListSelector";
            this.stateListSelector.Size = new System.Drawing.Size(138, 21);
            this.stateListSelector.TabIndex = 8;
            // 
            // cancelEditClaim
            // 
            this.cancelEditClaim.Location = new System.Drawing.Point(95, 410);
            this.cancelEditClaim.Name = "cancelEditClaim";
            this.cancelEditClaim.Size = new System.Drawing.Size(59, 28);
            this.cancelEditClaim.TabIndex = 9;
            this.cancelEditClaim.Text = "Отмена";
            this.cancelEditClaim.UseVisualStyleBackColor = true;
            this.cancelEditClaim.Click += new System.EventHandler(this.cancelEditClaim_Click);
            // 
            // saveClaimItem
            // 
            this.saveClaimItem.Location = new System.Drawing.Point(12, 410);
            this.saveClaimItem.Name = "saveClaimItem";
            this.saveClaimItem.Size = new System.Drawing.Size(77, 28);
            this.saveClaimItem.TabIndex = 10;
            this.saveClaimItem.Text = "Сохранить";
            this.saveClaimItem.UseVisualStyleBackColor = true;
            this.saveClaimItem.Click += new System.EventHandler(this.saveClaimItem_Click);
            // 
            // ClaimList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveClaimItem);
            this.Controls.Add(this.stateListSelector);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.autoNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.claimText);
            this.Controls.Add(this.claimListView);
            this.Controls.Add(this.cancelEditClaim);
            this.Controls.Add(this.putNewClaim);
            this.Name = "ClaimList";
            this.Text = "Заявления";
            this.Load += new System.EventHandler(this.ClaimList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.claimListView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView claimListView;
        private System.Windows.Forms.Button putNewClaim;
        private System.Windows.Forms.TextBox claimText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox autoNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox stateListSelector;
        private System.Windows.Forms.Button cancelEditClaim;
        private System.Windows.Forms.Button saveClaimItem;
    }
}