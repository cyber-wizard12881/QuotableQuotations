namespace QuotableQuotations.Client
{
    partial class QuotableQuotationsForm
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
            this.lblUrl = new System.Windows.Forms.Label();
            this.rbRead = new System.Windows.Forms.RadioButton();
            this.rbCreate = new System.Windows.Forms.RadioButton();
            this.rbUpdate = new System.Windows.Forms.RadioButton();
            this.rbDelete = new System.Windows.Forms.RadioButton();
            this.grpOperations = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblCriteria = new System.Windows.Forms.Label();
            this.rbName = new System.Windows.Forms.RadioButton();
            this.rbCategory = new System.Windows.Forms.RadioButton();
            this.rbText = new System.Windows.Forms.RadioButton();
            this.grpCriteria = new System.Windows.Forms.GroupBox();
            this.txtCriteria = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.grpEntity = new System.Windows.Forms.GroupBox();
            this.txtQQQuote = new System.Windows.Forms.TextBox();
            this.txtQQCategory = new System.Windows.Forms.TextBox();
            this.txtQQName = new System.Windows.Forms.TextBox();
            this.txtQQId = new System.Windows.Forms.TextBox();
            this.lblQQQuote = new System.Windows.Forms.Label();
            this.lblQQCategory = new System.Windows.Forms.Label();
            this.lblQQName = new System.Windows.Forms.Label();
            this.lblQQId = new System.Windows.Forms.Label();
            this.rbNonTransactional = new System.Windows.Forms.RadioButton();
            this.rbTransactional = new System.Windows.Forms.RadioButton();
            this.grpMode = new System.Windows.Forms.GroupBox();
            this.grpTransactionalOperations = new System.Windows.Forms.GroupBox();
            this.rbTransactionalDelete = new System.Windows.Forms.RadioButton();
            this.rbTransactionalCreate = new System.Windows.Forms.RadioButton();
            this.rbReplace = new System.Windows.Forms.RadioButton();
            this.grpTransactional = new System.Windows.Forms.GroupBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.grpOperations.SuspendLayout();
            this.grpCriteria.SuspendLayout();
            this.grpEntity.SuspendLayout();
            this.grpMode.SuspendLayout();
            this.grpTransactionalOperations.SuspendLayout();
            this.grpTransactional.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(130, 85);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(100, 13);
            this.lblUrl.TabIndex = 0;
            this.lblUrl.Text = "WCF Service Mode";
            // 
            // rbRead
            // 
            this.rbRead.AutoSize = true;
            this.rbRead.Location = new System.Drawing.Point(34, 25);
            this.rbRead.Name = "rbRead";
            this.rbRead.Size = new System.Drawing.Size(51, 17);
            this.rbRead.TabIndex = 2;
            this.rbRead.TabStop = true;
            this.rbRead.Text = "Read";
            this.rbRead.UseVisualStyleBackColor = true;
            // 
            // rbCreate
            // 
            this.rbCreate.AutoSize = true;
            this.rbCreate.Location = new System.Drawing.Point(187, 25);
            this.rbCreate.Name = "rbCreate";
            this.rbCreate.Size = new System.Drawing.Size(56, 17);
            this.rbCreate.TabIndex = 3;
            this.rbCreate.TabStop = true;
            this.rbCreate.Text = "Create";
            this.rbCreate.UseVisualStyleBackColor = true;
            // 
            // rbUpdate
            // 
            this.rbUpdate.AutoSize = true;
            this.rbUpdate.Location = new System.Drawing.Point(334, 25);
            this.rbUpdate.Name = "rbUpdate";
            this.rbUpdate.Size = new System.Drawing.Size(60, 17);
            this.rbUpdate.TabIndex = 4;
            this.rbUpdate.TabStop = true;
            this.rbUpdate.Text = "Update";
            this.rbUpdate.UseVisualStyleBackColor = true;
            // 
            // rbDelete
            // 
            this.rbDelete.AutoSize = true;
            this.rbDelete.Location = new System.Drawing.Point(471, 25);
            this.rbDelete.Name = "rbDelete";
            this.rbDelete.Size = new System.Drawing.Size(56, 17);
            this.rbDelete.TabIndex = 5;
            this.rbDelete.TabStop = true;
            this.rbDelete.Text = "Delete";
            this.rbDelete.UseVisualStyleBackColor = true;
            // 
            // grpOperations
            // 
            this.grpOperations.Controls.Add(this.rbDelete);
            this.grpOperations.Controls.Add(this.rbUpdate);
            this.grpOperations.Controls.Add(this.rbCreate);
            this.grpOperations.Controls.Add(this.rbRead);
            this.grpOperations.Location = new System.Drawing.Point(99, 140);
            this.grpOperations.Name = "grpOperations";
            this.grpOperations.Size = new System.Drawing.Size(575, 77);
            this.grpOperations.TabIndex = 6;
            this.grpOperations.TabStop = false;
            this.grpOperations.Text = "Non-Transactional Operations:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(130, 538);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(40, 13);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "Result:";
            // 
            // lblCriteria
            // 
            this.lblCriteria.AutoSize = true;
            this.lblCriteria.Location = new System.Drawing.Point(128, 464);
            this.lblCriteria.Name = "lblCriteria";
            this.lblCriteria.Size = new System.Drawing.Size(42, 13);
            this.lblCriteria.TabIndex = 8;
            this.lblCriteria.Text = "Criteria:";
            // 
            // rbName
            // 
            this.rbName.AutoSize = true;
            this.rbName.Location = new System.Drawing.Point(18, 19);
            this.rbName.Name = "rbName";
            this.rbName.Size = new System.Drawing.Size(53, 17);
            this.rbName.TabIndex = 9;
            this.rbName.TabStop = true;
            this.rbName.Text = "Name";
            this.rbName.UseVisualStyleBackColor = true;
            // 
            // rbCategory
            // 
            this.rbCategory.AutoSize = true;
            this.rbCategory.Location = new System.Drawing.Point(110, 19);
            this.rbCategory.Name = "rbCategory";
            this.rbCategory.Size = new System.Drawing.Size(67, 17);
            this.rbCategory.TabIndex = 10;
            this.rbCategory.TabStop = true;
            this.rbCategory.Text = "Category";
            this.rbCategory.UseVisualStyleBackColor = true;
            // 
            // rbText
            // 
            this.rbText.AutoSize = true;
            this.rbText.Location = new System.Drawing.Point(229, 19);
            this.rbText.Name = "rbText";
            this.rbText.Size = new System.Drawing.Size(89, 17);
            this.rbText.TabIndex = 11;
            this.rbText.TabStop = true;
            this.rbText.Text = "Text in Quote";
            this.rbText.UseVisualStyleBackColor = true;
            // 
            // grpCriteria
            // 
            this.grpCriteria.Controls.Add(this.rbText);
            this.grpCriteria.Controls.Add(this.rbCategory);
            this.grpCriteria.Controls.Add(this.rbName);
            this.grpCriteria.Location = new System.Drawing.Point(223, 454);
            this.grpCriteria.Name = "grpCriteria";
            this.grpCriteria.Size = new System.Drawing.Size(342, 61);
            this.grpCriteria.TabIndex = 12;
            this.grpCriteria.TabStop = false;
            this.grpCriteria.Text = "Search:";
            // 
            // txtCriteria
            // 
            this.txtCriteria.Location = new System.Drawing.Point(610, 472);
            this.txtCriteria.Name = "txtCriteria";
            this.txtCriteria.Size = new System.Drawing.Size(283, 20);
            this.txtCriteria.TabIndex = 13;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(947, 468);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(125, 32);
            this.btnSubmit.TabIndex = 14;
            this.btnSubmit.Text = "Perform Action";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(176, 568);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResult.Size = new System.Drawing.Size(868, 324);
            this.txtResult.TabIndex = 15;
            // 
            // grpEntity
            // 
            this.grpEntity.Controls.Add(this.txtQQQuote);
            this.grpEntity.Controls.Add(this.txtQQCategory);
            this.grpEntity.Controls.Add(this.txtQQName);
            this.grpEntity.Controls.Add(this.txtQQId);
            this.grpEntity.Controls.Add(this.lblQQQuote);
            this.grpEntity.Controls.Add(this.lblQQCategory);
            this.grpEntity.Controls.Add(this.lblQQName);
            this.grpEntity.Controls.Add(this.lblQQId);
            this.grpEntity.Location = new System.Drawing.Point(98, 345);
            this.grpEntity.Name = "grpEntity";
            this.grpEntity.Size = new System.Drawing.Size(974, 70);
            this.grpEntity.TabIndex = 16;
            this.grpEntity.TabStop = false;
            this.grpEntity.Text = "QuotableQuotation Entity:";
            // 
            // txtQQQuote
            // 
            this.txtQQQuote.Location = new System.Drawing.Point(630, 39);
            this.txtQQQuote.Name = "txtQQQuote";
            this.txtQQQuote.Size = new System.Drawing.Size(324, 20);
            this.txtQQQuote.TabIndex = 7;
            // 
            // txtQQCategory
            // 
            this.txtQQCategory.Location = new System.Drawing.Point(449, 36);
            this.txtQQCategory.Name = "txtQQCategory";
            this.txtQQCategory.Size = new System.Drawing.Size(100, 20);
            this.txtQQCategory.TabIndex = 6;
            // 
            // txtQQName
            // 
            this.txtQQName.Location = new System.Drawing.Point(218, 36);
            this.txtQQName.Name = "txtQQName";
            this.txtQQName.Size = new System.Drawing.Size(138, 20);
            this.txtQQName.TabIndex = 5;
            // 
            // txtQQId
            // 
            this.txtQQId.Location = new System.Drawing.Point(67, 36);
            this.txtQQId.Name = "txtQQId";
            this.txtQQId.Size = new System.Drawing.Size(62, 20);
            this.txtQQId.TabIndex = 4;
            // 
            // lblQQQuote
            // 
            this.lblQQQuote.AutoSize = true;
            this.lblQQQuote.Location = new System.Drawing.Point(584, 39);
            this.lblQQQuote.Name = "lblQQQuote";
            this.lblQQQuote.Size = new System.Drawing.Size(39, 13);
            this.lblQQQuote.TabIndex = 3;
            this.lblQQQuote.Text = "Quote:";
            // 
            // lblQQCategory
            // 
            this.lblQQCategory.AutoSize = true;
            this.lblQQCategory.Location = new System.Drawing.Point(374, 38);
            this.lblQQCategory.Name = "lblQQCategory";
            this.lblQQCategory.Size = new System.Drawing.Size(52, 13);
            this.lblQQCategory.TabIndex = 2;
            this.lblQQCategory.Text = "Category:";
            // 
            // lblQQName
            // 
            this.lblQQName.AutoSize = true;
            this.lblQQName.Location = new System.Drawing.Point(158, 39);
            this.lblQQName.Name = "lblQQName";
            this.lblQQName.Size = new System.Drawing.Size(38, 13);
            this.lblQQName.TabIndex = 1;
            this.lblQQName.Text = "Name:";
            // 
            // lblQQId
            // 
            this.lblQQId.AutoSize = true;
            this.lblQQId.Location = new System.Drawing.Point(24, 38);
            this.lblQQId.Name = "lblQQId";
            this.lblQQId.Size = new System.Drawing.Size(19, 13);
            this.lblQQId.TabIndex = 0;
            this.lblQQId.Text = "Id:";
            // 
            // rbNonTransactional
            // 
            this.rbNonTransactional.AutoSize = true;
            this.rbNonTransactional.Location = new System.Drawing.Point(9, 39);
            this.rbNonTransactional.Name = "rbNonTransactional";
            this.rbNonTransactional.Size = new System.Drawing.Size(112, 17);
            this.rbNonTransactional.TabIndex = 17;
            this.rbNonTransactional.TabStop = true;
            this.rbNonTransactional.Text = "Non-Transactional";
            this.rbNonTransactional.UseVisualStyleBackColor = true;
            // 
            // rbTransactional
            // 
            this.rbTransactional.AutoSize = true;
            this.rbTransactional.Location = new System.Drawing.Point(173, 39);
            this.rbTransactional.Name = "rbTransactional";
            this.rbTransactional.Size = new System.Drawing.Size(89, 17);
            this.rbTransactional.TabIndex = 18;
            this.rbTransactional.TabStop = true;
            this.rbTransactional.Text = "Transactional";
            this.rbTransactional.UseVisualStyleBackColor = true;
            // 
            // grpMode
            // 
            this.grpMode.Controls.Add(this.rbNonTransactional);
            this.grpMode.Controls.Add(this.rbTransactional);
            this.grpMode.Location = new System.Drawing.Point(250, 46);
            this.grpMode.Name = "grpMode";
            this.grpMode.Size = new System.Drawing.Size(291, 88);
            this.grpMode.TabIndex = 19;
            this.grpMode.TabStop = false;
            this.grpMode.Text = "Mode:";
            // 
            // grpTransactionalOperations
            // 
            this.grpTransactionalOperations.Controls.Add(this.rbTransactionalDelete);
            this.grpTransactionalOperations.Controls.Add(this.rbTransactionalCreate);
            this.grpTransactionalOperations.Controls.Add(this.rbReplace);
            this.grpTransactionalOperations.Location = new System.Drawing.Point(685, 140);
            this.grpTransactionalOperations.Name = "grpTransactionalOperations";
            this.grpTransactionalOperations.Size = new System.Drawing.Size(437, 77);
            this.grpTransactionalOperations.TabIndex = 20;
            this.grpTransactionalOperations.TabStop = false;
            this.grpTransactionalOperations.Text = "Transactional Operations:";
            // 
            // rbTransactionalDelete
            // 
            this.rbTransactionalDelete.AutoSize = true;
            this.rbTransactionalDelete.Location = new System.Drawing.Point(262, 30);
            this.rbTransactionalDelete.Name = "rbTransactionalDelete";
            this.rbTransactionalDelete.Size = new System.Drawing.Size(56, 17);
            this.rbTransactionalDelete.TabIndex = 2;
            this.rbTransactionalDelete.TabStop = true;
            this.rbTransactionalDelete.Text = "Delete";
            this.rbTransactionalDelete.UseVisualStyleBackColor = true;
            // 
            // rbTransactionalCreate
            // 
            this.rbTransactionalCreate.AutoSize = true;
            this.rbTransactionalCreate.Location = new System.Drawing.Point(152, 30);
            this.rbTransactionalCreate.Name = "rbTransactionalCreate";
            this.rbTransactionalCreate.Size = new System.Drawing.Size(56, 17);
            this.rbTransactionalCreate.TabIndex = 1;
            this.rbTransactionalCreate.TabStop = true;
            this.rbTransactionalCreate.Text = "Create";
            this.rbTransactionalCreate.UseVisualStyleBackColor = true;
            // 
            // rbReplace
            // 
            this.rbReplace.AutoSize = true;
            this.rbReplace.Location = new System.Drawing.Point(26, 30);
            this.rbReplace.Name = "rbReplace";
            this.rbReplace.Size = new System.Drawing.Size(65, 17);
            this.rbReplace.TabIndex = 0;
            this.rbReplace.TabStop = true;
            this.rbReplace.Text = "Replace";
            this.rbReplace.UseVisualStyleBackColor = true;
            // 
            // grpTransactional
            // 
            this.grpTransactional.Controls.Add(this.txtTo);
            this.grpTransactional.Controls.Add(this.txtFrom);
            this.grpTransactional.Controls.Add(this.lblTo);
            this.grpTransactional.Controls.Add(this.lblFrom);
            this.grpTransactional.Location = new System.Drawing.Point(106, 240);
            this.grpTransactional.Name = "grpTransactional";
            this.grpTransactional.Size = new System.Drawing.Size(965, 79);
            this.grpTransactional.TabIndex = 21;
            this.grpTransactional.TabStop = false;
            this.grpTransactional.Text = "Transactional:";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(359, 41);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(208, 20);
            this.txtTo.TabIndex = 3;
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(88, 40);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(206, 20);
            this.txtFrom.TabIndex = 2;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(317, 40);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(23, 13);
            this.lblTo.TabIndex = 1;
            this.lblTo.Text = "To:";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(28, 40);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(33, 13);
            this.lblFrom.TabIndex = 0;
            this.lblFrom.Text = "From:";
            // 
            // QuotableQuotationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 933);
            this.Controls.Add(this.grpTransactional);
            this.Controls.Add(this.grpTransactionalOperations);
            this.Controls.Add(this.grpMode);
            this.Controls.Add(this.grpEntity);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtCriteria);
            this.Controls.Add(this.grpCriteria);
            this.Controls.Add(this.lblCriteria);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.grpOperations);
            this.Controls.Add(this.lblUrl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "QuotableQuotationsForm";
            this.Text = "QuotableQuotations Client";
            this.grpOperations.ResumeLayout(false);
            this.grpOperations.PerformLayout();
            this.grpCriteria.ResumeLayout(false);
            this.grpCriteria.PerformLayout();
            this.grpEntity.ResumeLayout(false);
            this.grpEntity.PerformLayout();
            this.grpMode.ResumeLayout(false);
            this.grpMode.PerformLayout();
            this.grpTransactionalOperations.ResumeLayout(false);
            this.grpTransactionalOperations.PerformLayout();
            this.grpTransactional.ResumeLayout(false);
            this.grpTransactional.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.RadioButton rbRead;
        private System.Windows.Forms.RadioButton rbCreate;
        private System.Windows.Forms.RadioButton rbUpdate;
        private System.Windows.Forms.RadioButton rbDelete;
        private System.Windows.Forms.GroupBox grpOperations;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblCriteria;
        private System.Windows.Forms.RadioButton rbName;
        private System.Windows.Forms.RadioButton rbCategory;
        private System.Windows.Forms.RadioButton rbText;
        private System.Windows.Forms.GroupBox grpCriteria;
        private System.Windows.Forms.TextBox txtCriteria;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.GroupBox grpEntity;
        private System.Windows.Forms.Label lblQQId;
        private System.Windows.Forms.Label lblQQName;
        private System.Windows.Forms.Label lblQQCategory;
        private System.Windows.Forms.Label lblQQQuote;
        private System.Windows.Forms.TextBox txtQQId;
        private System.Windows.Forms.TextBox txtQQName;
        private System.Windows.Forms.TextBox txtQQCategory;
        private System.Windows.Forms.TextBox txtQQQuote;
        private System.Windows.Forms.RadioButton rbNonTransactional;
        private System.Windows.Forms.RadioButton rbTransactional;
        private System.Windows.Forms.GroupBox grpMode;
        private System.Windows.Forms.GroupBox grpTransactionalOperations;
        private System.Windows.Forms.RadioButton rbReplace;
        private System.Windows.Forms.RadioButton rbTransactionalCreate;
        private System.Windows.Forms.RadioButton rbTransactionalDelete;
        private System.Windows.Forms.GroupBox grpTransactional;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.TextBox txtTo;
    }
}

