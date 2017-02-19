namespace SvcClientApp
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
            this.btnCallSync = new System.Windows.Forms.Button();
            this.btnCallAsync = new System.Windows.Forms.Button();
            this.lblSyncResult = new System.Windows.Forms.Label();
            this.lblAsyncResult = new System.Windows.Forms.Label();
            this.lblSyncCounter = new System.Windows.Forms.Label();
            this.lblAsyncCounter = new System.Windows.Forms.Label();
            this.lbSyncResult = new System.Windows.Forms.ListBox();
            this.lbAsyncResult = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCallSync
            // 
            this.btnCallSync.Location = new System.Drawing.Point(12, 50);
            this.btnCallSync.Name = "btnCallSync";
            this.btnCallSync.Size = new System.Drawing.Size(75, 23);
            this.btnCallSync.TabIndex = 0;
            this.btnCallSync.Text = "Call Sync";
            this.btnCallSync.UseVisualStyleBackColor = true;
            this.btnCallSync.Click += new System.EventHandler(this.btnCallSync_Click);
            // 
            // btnCallAsync
            // 
            this.btnCallAsync.Location = new System.Drawing.Point(243, 50);
            this.btnCallAsync.Name = "btnCallAsync";
            this.btnCallAsync.Size = new System.Drawing.Size(75, 23);
            this.btnCallAsync.TabIndex = 1;
            this.btnCallAsync.Text = "Call Async";
            this.btnCallAsync.UseVisualStyleBackColor = true;
            this.btnCallAsync.Click += new System.EventHandler(this.btnCallAsync_Click);
            // 
            // lblSyncResult
            // 
            this.lblSyncResult.AutoSize = true;
            this.lblSyncResult.Location = new System.Drawing.Point(105, 54);
            this.lblSyncResult.Name = "lblSyncResult";
            this.lblSyncResult.Size = new System.Drawing.Size(0, 13);
            this.lblSyncResult.TabIndex = 2;
            // 
            // lblAsyncResult
            // 
            this.lblAsyncResult.AutoSize = true;
            this.lblAsyncResult.Location = new System.Drawing.Point(242, 86);
            this.lblAsyncResult.Name = "lblAsyncResult";
            this.lblAsyncResult.Size = new System.Drawing.Size(0, 13);
            this.lblAsyncResult.TabIndex = 3;
            // 
            // lblSyncCounter
            // 
            this.lblSyncCounter.AutoSize = true;
            this.lblSyncCounter.Location = new System.Drawing.Point(9, 33);
            this.lblSyncCounter.Name = "lblSyncCounter";
            this.lblSyncCounter.Size = new System.Drawing.Size(71, 13);
            this.lblSyncCounter.TabIndex = 4;
            this.lblSyncCounter.Text = "Sync Counter";
            // 
            // lblAsyncCounter
            // 
            this.lblAsyncCounter.AutoSize = true;
            this.lblAsyncCounter.Location = new System.Drawing.Point(240, 33);
            this.lblAsyncCounter.Name = "lblAsyncCounter";
            this.lblAsyncCounter.Size = new System.Drawing.Size(76, 13);
            this.lblAsyncCounter.TabIndex = 5;
            this.lblAsyncCounter.Text = "Async Counter";
            // 
            // lbSyncResult
            // 
            this.lbSyncResult.FormattingEnabled = true;
            this.lbSyncResult.Location = new System.Drawing.Point(12, 79);
            this.lbSyncResult.Name = "lbSyncResult";
            this.lbSyncResult.Size = new System.Drawing.Size(210, 290);
            this.lbSyncResult.TabIndex = 6;
            // 
            // lbAsyncResult
            // 
            this.lbAsyncResult.FormattingEnabled = true;
            this.lbAsyncResult.Location = new System.Drawing.Point(243, 79);
            this.lbAsyncResult.Name = "lbAsyncResult";
            this.lbAsyncResult.Size = new System.Drawing.Size(210, 290);
            this.lbAsyncResult.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 393);
            this.Controls.Add(this.lbAsyncResult);
            this.Controls.Add(this.lbSyncResult);
            this.Controls.Add(this.lblAsyncCounter);
            this.Controls.Add(this.lblSyncCounter);
            this.Controls.Add(this.lblAsyncResult);
            this.Controls.Add(this.lblSyncResult);
            this.Controls.Add(this.btnCallAsync);
            this.Controls.Add(this.btnCallSync);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCallSync;
        private System.Windows.Forms.Button btnCallAsync;
        private System.Windows.Forms.Label lblSyncResult;
        private System.Windows.Forms.Label lblAsyncResult;
        private System.Windows.Forms.Label lblSyncCounter;
        private System.Windows.Forms.Label lblAsyncCounter;
        private System.Windows.Forms.ListBox lbSyncResult;
        private System.Windows.Forms.ListBox lbAsyncResult;
    }
}

