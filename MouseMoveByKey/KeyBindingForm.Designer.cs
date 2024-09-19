namespace MouseMoveByKey {
    partial class KeyBindingForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.groupUpKeys = new System.Windows.Forms.GroupBox();
            this.btnClearUpKey = new System.Windows.Forms.Button();
            this.btnAddUpKey = new System.Windows.Forms.Button();
            this.listUpKeys = new System.Windows.Forms.ListBox();

            this.groupDownKeys = new System.Windows.Forms.GroupBox();
            this.btnClearDownKey = new System.Windows.Forms.Button();
            this.btnAddDownKeys = new System.Windows.Forms.Button();
            this.listDownKeys = new System.Windows.Forms.ListBox();

            this.groupRightKeys = new System.Windows.Forms.GroupBox();
            this.btnClearRightKey = new System.Windows.Forms.Button();
            this.btnAddRightKey = new System.Windows.Forms.Button();
            this.listRightKeys = new System.Windows.Forms.ListBox();

            this.groupLeftKeys = new System.Windows.Forms.GroupBox();
            this.btnClearLeftKey = new System.Windows.Forms.Button();
            this.btnAddLeftKey = new System.Windows.Forms.Button();
            this.listLeftKeys = new System.Windows.Forms.ListBox();

            this.groupLButtonKeys = new System.Windows.Forms.GroupBox();
            this.btnClearLButtonKey = new System.Windows.Forms.Button();
            this.btnAddLButtonKey = new System.Windows.Forms.Button();
            this.listLButtonKeys = new System.Windows.Forms.ListBox();

            this.groupRButtonKeys = new System.Windows.Forms.GroupBox();
            this.btnClearRButtonKey = new System.Windows.Forms.Button();
            this.btnAddRButtonKey = new System.Windows.Forms.Button();
            this.listRButtonKeys = new System.Windows.Forms.ListBox();

            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.groupUpKeys.SuspendLayout();
            this.groupDownKeys.SuspendLayout();
            this.groupRightKeys.SuspendLayout();
            this.groupLeftKeys.SuspendLayout();
            this.groupLButtonKeys.SuspendLayout();
            this.groupRButtonKeys.SuspendLayout();
            this.SuspendLayout();

            
            int groupBoxWidth = 428;
            int groupBoxHeight = 186;
            int groupBoxDeltaX = groupBoxWidth + 20;
            int groupBoxDeltaY = groupBoxHeight + 20;

            int groupBoxLX = 12;
            int groupBoxRX = groupBoxLX + groupBoxDeltaX;
            int groupBoxY = 108;

            int listBoxX = 6;
            int listBoxY = 39;
            int listBoxWidth = 259;
            int listBoxHeight = 129;

            int btnWidth = 151;
            int btnHeight = 60;
            int btnX = 271;

            int btn1Y = 39;
            int btn2Y = 105;

            // 
            // groupUpKeys
            // 
            this.groupUpKeys.Controls.Add(this.btnClearUpKey);
            this.groupUpKeys.Controls.Add(this.btnAddUpKey);
            this.groupUpKeys.Controls.Add(this.listUpKeys);
            this.groupUpKeys.Location = new System.Drawing.Point(groupBoxLX, groupBoxY);
            this.groupUpKeys.Name = "groupUpKeys";
            this.groupUpKeys.Size = new System.Drawing.Size(groupBoxWidth, groupBoxHeight);
            this.groupUpKeys.TabIndex = 0;
            this.groupUpKeys.TabStop = false;
            this.groupUpKeys.Text = "Move Mouse UP Keys";

            // 
            // listUpKeys
            // 
            this.listUpKeys.FormattingEnabled = true;
            this.listUpKeys.ItemHeight = 25;
            this.listUpKeys.Location = new System.Drawing.Point(listBoxX, listBoxY);
            this.listUpKeys.Name = "listUpKeys";
            this.listUpKeys.Size = new System.Drawing.Size(listBoxWidth, listBoxHeight);
            this.listUpKeys.TabIndex = 0;

            // 
            // btnAddUpKey
            // 
            this.btnAddUpKey.Location = new System.Drawing.Point(btnX, btn1Y);
            this.btnAddUpKey.Name = "btnAddUpKey";
            this.btnAddUpKey.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btnAddUpKey.TabIndex = 1;
            this.btnAddUpKey.Text = "Add Key";
            this.btnAddUpKey.UseVisualStyleBackColor = true;
            this.btnAddUpKey.Click += new System.EventHandler(this.btnAddUpKey_Click);

            // 
            // btnClearUpKey
            // 
            this.btnClearUpKey.Location = new System.Drawing.Point(btnX, btn2Y);
            this.btnClearUpKey.Name = "btnClearUpKey";
            this.btnClearUpKey.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btnClearUpKey.TabIndex = 1;
            this.btnClearUpKey.Text = "Remove Key";
            this.btnClearUpKey.UseVisualStyleBackColor = true;
            this.btnClearUpKey.Click += new System.EventHandler(this.btnClearUpKey_Click);

            // 
            // groupDownKeys
            // 
            this.groupDownKeys.Controls.Add(this.btnClearDownKey);
            this.groupDownKeys.Controls.Add(this.btnAddDownKeys);
            this.groupDownKeys.Controls.Add(this.listDownKeys);
            this.groupDownKeys.Location = new System.Drawing.Point(groupBoxRX, groupBoxY);
            this.groupDownKeys.Name = "groupDownKeys";
            this.groupDownKeys.Size = new System.Drawing.Size(groupBoxWidth, groupBoxHeight);
            this.groupDownKeys.TabIndex = 2;
            this.groupDownKeys.TabStop = false;
            this.groupDownKeys.Text = "Move Mouse DOWN Keys";

            // 
            // listDownKeys
            // 
            this.listDownKeys.FormattingEnabled = true;
            this.listDownKeys.ItemHeight = 25;
            this.listDownKeys.Location = new System.Drawing.Point(listBoxX, listBoxY);
            this.listDownKeys.Name = "listDownKeys";
            this.listDownKeys.Size = new System.Drawing.Size(listBoxWidth, listBoxHeight);
            this.listDownKeys.TabIndex = 0;

            // 
            // btnAddDownKeys
            // 
            this.btnAddDownKeys.Location = new System.Drawing.Point(btnX, btn1Y);
            this.btnAddDownKeys.Name = "btnAddDownKeys";
            this.btnAddDownKeys.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btnAddDownKeys.TabIndex = 1;
            this.btnAddDownKeys.Text = "Add Key";
            this.btnAddDownKeys.UseVisualStyleBackColor = true;
            this.btnAddDownKeys.Click += new System.EventHandler(this.btnAddDownKeys_Click);

            // 
            // btnClearDownKey
            // 
            this.btnClearDownKey.Location = new System.Drawing.Point(btnX, btn2Y);
            this.btnClearDownKey.Name = "btnClearDownKey";
            this.btnClearDownKey.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btnClearDownKey.TabIndex = 1;
            this.btnClearDownKey.Text = "Remove Key";
            this.btnClearDownKey.UseVisualStyleBackColor = true;
            this.btnClearDownKey.Click += new System.EventHandler(this.btnClearDownKey_Click);

            // Update groupBoxY
            groupBoxY += groupBoxDeltaY;

            // 
            // groupLeftKeys
            // 
            this.groupLeftKeys.Controls.Add(this.btnClearLeftKey);
            this.groupLeftKeys.Controls.Add(this.btnAddLeftKey);
            this.groupLeftKeys.Controls.Add(this.listLeftKeys);
            this.groupLeftKeys.Location = new System.Drawing.Point(groupBoxLX, groupBoxY);
            this.groupLeftKeys.Name = "groupLeftKeys";
            this.groupLeftKeys.Size = new System.Drawing.Size(groupBoxWidth, groupBoxHeight);
            this.groupLeftKeys.TabIndex = 3;
            this.groupLeftKeys.TabStop = false;
            this.groupLeftKeys.Text = "Move Mouse LEFT Keys";

            // 
            // listLeftKeys
            // 
            this.listLeftKeys.FormattingEnabled = true;
            this.listLeftKeys.ItemHeight = 25;
            this.listLeftKeys.Location = new System.Drawing.Point(listBoxX, listBoxY);
            this.listLeftKeys.Name = "listLeftKeys";
            this.listLeftKeys.Size = new System.Drawing.Size(listBoxWidth, listBoxHeight);
            this.listLeftKeys.TabIndex = 0;

            // 
            // btnAddLeftKey
            // 
            this.btnAddLeftKey.Location = new System.Drawing.Point(btnX, btn1Y);
            this.btnAddLeftKey.Name = "btnAddLeftKey";
            this.btnAddLeftKey.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btnAddLeftKey.TabIndex = 1;
            this.btnAddLeftKey.Text = "Add Key";
            this.btnAddLeftKey.UseVisualStyleBackColor = true;
            this.btnAddLeftKey.Click += new System.EventHandler(this.btnAddLeftKey_Click);

            // 
            // btnClearLeftKey
            // 
            this.btnClearLeftKey.Location = new System.Drawing.Point(btnX, btn2Y);
            this.btnClearLeftKey.Name = "btnClearLeftKey";
            this.btnClearLeftKey.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btnClearLeftKey.TabIndex = 1;
            this.btnClearLeftKey.Text = "Remove Key";
            this.btnClearLeftKey.UseVisualStyleBackColor = true;
            this.btnClearLeftKey.Click += new System.EventHandler(this.btnClearLeftKey_Click);

            // 
            // groupRightKeys
            // 
            this.groupRightKeys.Controls.Add(this.btnClearRightKey);
            this.groupRightKeys.Controls.Add(this.btnAddRightKey);
            this.groupRightKeys.Controls.Add(this.listRightKeys);
            this.groupRightKeys.Location = new System.Drawing.Point(groupBoxRX, groupBoxY);
            this.groupRightKeys.Name = "groupRightKeys";
            this.groupRightKeys.Size = new System.Drawing.Size(groupBoxWidth, groupBoxHeight);
            this.groupRightKeys.TabIndex = 4;
            this.groupRightKeys.TabStop = false;
            this.groupRightKeys.Text = "Move Mouse RIGHT Keys";

            // 
            // listRightKeys
            // 
            this.listRightKeys.FormattingEnabled = true;
            this.listRightKeys.ItemHeight = 25;
            this.listRightKeys.Location = new System.Drawing.Point(listBoxX, listBoxY);
            this.listRightKeys.Name = "listRightKeys";
            this.listRightKeys.Size = new System.Drawing.Size(listBoxWidth, listBoxHeight);
            this.listRightKeys.TabIndex = 0;

            // 
            // btnAddRightKey
            // 
            this.btnAddRightKey.Location = new System.Drawing.Point(btnX, btn1Y);
            this.btnAddRightKey.Name = "btnAddRightKey";
            this.btnAddRightKey.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btnAddRightKey.TabIndex = 1;
            this.btnAddRightKey.Text = "Add Key";
            this.btnAddRightKey.UseVisualStyleBackColor = true;
            this.btnAddRightKey.Click += new System.EventHandler(this.btnAddRightKey_Click);

            // 
            // btnClearRightKey
            // 
            this.btnClearRightKey.Location = new System.Drawing.Point(btnX, btn2Y);
            this.btnClearRightKey.Name = "btnClearRightKey";
            this.btnClearRightKey.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btnClearRightKey.TabIndex = 1;
            this.btnClearRightKey.Text = "Remove Key";
            this.btnClearRightKey.UseVisualStyleBackColor = true;
            this.btnClearRightKey.Click += new System.EventHandler(this.btnClearRightKey_Click);

            // Update groupBoxY
            groupBoxY += groupBoxDeltaY;

            // 
            // groupLButtonKeys
            // 
            this.groupLButtonKeys.Controls.Add(this.btnClearLButtonKey);
            this.groupLButtonKeys.Controls.Add(this.btnAddLButtonKey);
            this.groupLButtonKeys.Controls.Add(this.listLButtonKeys);
            this.groupLButtonKeys.Location = new System.Drawing.Point(groupBoxLX, groupBoxY);
            this.groupLButtonKeys.Name = "groupLButtonKeys";
            this.groupLButtonKeys.Size = new System.Drawing.Size(groupBoxWidth, groupBoxHeight);
            this.groupLButtonKeys.TabIndex = 4;
            this.groupLButtonKeys.TabStop = false;
            this.groupLButtonKeys.Text = "Mouse LEFT Button Keys";

            // 
            // listLButtonKeyss
            // 
            this.listLButtonKeys.FormattingEnabled = true;
            this.listLButtonKeys.ItemHeight = 25;
            this.listLButtonKeys.Location = new System.Drawing.Point(listBoxX, listBoxY);
            this.listLButtonKeys.Name = "listLButtonKeys";
            this.listLButtonKeys.Size = new System.Drawing.Size(listBoxWidth, listBoxHeight);
            this.listLButtonKeys.TabIndex = 0;

            // 
            // btnAddLButtonKeys
            // 
            this.btnAddLButtonKey.Location = new System.Drawing.Point(btnX, btn1Y);
            this.btnAddLButtonKey.Name = "btnAddLButtonKey";
            this.btnAddLButtonKey.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btnAddLButtonKey.TabIndex = 1;
            this.btnAddLButtonKey.Text = "Add Key";
            this.btnAddLButtonKey.UseVisualStyleBackColor = true;
            this.btnAddLButtonKey.Click += new System.EventHandler(this.btnAddLButtonKey_Click);

            // 
            // btnClearLButtonKeys
            // 
            this.btnClearLButtonKey.Location = new System.Drawing.Point(btnX, btn2Y);
            this.btnClearLButtonKey.Name = "btnClearLButtonKey";
            this.btnClearLButtonKey.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btnClearLButtonKey.TabIndex = 1;
            this.btnClearLButtonKey.Text = "Remove Key";
            this.btnClearLButtonKey.UseVisualStyleBackColor = true;
            this.btnClearLButtonKey.Click += new System.EventHandler(this.btnClearLButtonKey_Click);

            // 
            // groupRButtonKeys
            // 
            this.groupRButtonKeys.Controls.Add(this.btnClearRButtonKey);
            this.groupRButtonKeys.Controls.Add(this.btnAddRButtonKey);
            this.groupRButtonKeys.Controls.Add(this.listRButtonKeys);
            this.groupRButtonKeys.Location = new System.Drawing.Point(groupBoxRX, groupBoxY);
            this.groupRButtonKeys.Name = "groupRButtonKeys";
            this.groupRButtonKeys.Size = new System.Drawing.Size(groupBoxWidth, groupBoxHeight);
            this.groupRButtonKeys.TabIndex = 4;
            this.groupRButtonKeys.TabStop = false;
            this.groupRButtonKeys.Text = "Mouse RIGHT Button Keys";

            // 
            // listRButtonKeys
            // 
            this.listRButtonKeys.FormattingEnabled = true;
            this.listRButtonKeys.ItemHeight = 25;
            this.listRButtonKeys.Location = new System.Drawing.Point(listBoxX, listBoxY);
            this.listRButtonKeys.Name = "listRButtonKeys";
            this.listRButtonKeys.Size = new System.Drawing.Size(listBoxWidth, listBoxHeight);
            this.listRButtonKeys.TabIndex = 0;

            // 
            // btnAddRButtonKey
            // 
            this.btnAddRButtonKey.Location = new System.Drawing.Point(btnX, btn1Y);
            this.btnAddRButtonKey.Name = "btnAddRButtonKey";
            this.btnAddRButtonKey.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btnAddRButtonKey.TabIndex = 1;
            this.btnAddRButtonKey.Text = "Add Key";
            this.btnAddRButtonKey.UseVisualStyleBackColor = true;
            this.btnAddRButtonKey.Click += new System.EventHandler(this.btnAddRButtonKey_Click);

            // 
            // btnClearRButtonKey
            // 
            this.btnClearRButtonKey.Location = new System.Drawing.Point(btnX, btn2Y);
            this.btnClearRButtonKey.Name = "btnClearRButtonKey";
            this.btnClearRButtonKey.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btnClearRButtonKey.TabIndex = 1;
            this.btnClearRButtonKey.Text = "Remove Key";
            this.btnClearRButtonKey.UseVisualStyleBackColor = true;
            this.btnClearRButtonKey.Click += new System.EventHandler(this.btnClearRButtonKey_Click);

            // Update groupBoxY
            groupBoxY += groupBoxDeltaY;


            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(18, groupBoxY + 15);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(272, 60);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(610, groupBoxY + 15);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(272, 60);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(13, 24);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(836, 50);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Text = "Add keys to a Mouse Event, or remove keys. Click Save Changes to save al" +
    "l \r\nchanges, or Cancel to abandon your changes.";
            // 
            // KeyBindingForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(900, 816);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupRightKeys);
            this.Controls.Add(this.groupDownKeys);
            this.Controls.Add(this.groupLeftKeys);
            this.Controls.Add(this.groupUpKeys);
            this.Controls.Add(this.groupLButtonKeys);
            this.Controls.Add(this.groupRButtonKeys);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "KeyBindingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Assign Key Bindings";
            this.Load += new System.EventHandler(this.KeyBindingForm_Load);
            this.groupUpKeys.ResumeLayout(false);
            this.groupDownKeys.ResumeLayout(false);
            this.groupRightKeys.ResumeLayout(false);
            this.groupLeftKeys.ResumeLayout(false);
            this.groupLButtonKeys.ResumeLayout(false);
            this.groupRButtonKeys.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupUpKeys;
        private System.Windows.Forms.Button btnClearUpKey;
        private System.Windows.Forms.Button btnAddUpKey;
        private System.Windows.Forms.ListBox listUpKeys;

        private System.Windows.Forms.GroupBox groupDownKeys;
        private System.Windows.Forms.Button btnClearDownKey;
        private System.Windows.Forms.Button btnAddDownKeys;
        private System.Windows.Forms.ListBox listDownKeys;

        private System.Windows.Forms.GroupBox groupRightKeys;
        private System.Windows.Forms.Button btnClearRightKey;
        private System.Windows.Forms.Button btnAddRightKey;
        private System.Windows.Forms.ListBox listRightKeys;

        private System.Windows.Forms.GroupBox groupLeftKeys;
        private System.Windows.Forms.Button btnClearLeftKey;
        private System.Windows.Forms.Button btnAddLeftKey;
        private System.Windows.Forms.ListBox listLeftKeys;

        private System.Windows.Forms.GroupBox groupLButtonKeys;
        private System.Windows.Forms.Button btnClearLButtonKey;
        private System.Windows.Forms.Button btnAddLButtonKey;
        private System.Windows.Forms.ListBox listLButtonKeys;

        private System.Windows.Forms.GroupBox groupRButtonKeys;
        private System.Windows.Forms.Button btnClearRButtonKey;
        private System.Windows.Forms.Button btnAddRButtonKey;
        private System.Windows.Forms.ListBox listRButtonKeys;

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblDescription;
    }
}