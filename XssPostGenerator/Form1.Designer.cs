namespace XssPostGenerator {
    partial class Form1 {
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMarkup = new System.Windows.Forms.RichTextBox();
            this.txtRawData = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtViewState = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Raw data:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Generated markup:";
            // 
            // txtMarkup
            // 
            this.txtMarkup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMarkup.Location = new System.Drawing.Point(15, 183);
            this.txtMarkup.Name = "txtMarkup";
            this.txtMarkup.Size = new System.Drawing.Size(860, 263);
            this.txtMarkup.TabIndex = 3;
            this.txtMarkup.Text = "";
            // 
            // txtRawData
            // 
            this.txtRawData.Location = new System.Drawing.Point(10, 25);
            this.txtRawData.Name = "txtRawData";
            this.txtRawData.Size = new System.Drawing.Size(865, 139);
            this.txtRawData.TabIndex = 4;
            this.txtRawData.Text = "";
            this.txtRawData.TextChanged += new System.EventHandler(this.txtRawData_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 449);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ViewState:";
            // 
            // txtViewState
            // 
            this.txtViewState.Location = new System.Drawing.Point(15, 465);
            this.txtViewState.Name = "txtViewState";
            this.txtViewState.Size = new System.Drawing.Size(860, 138);
            this.txtViewState.TabIndex = 6;
            this.txtViewState.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 615);
            this.Controls.Add(this.txtViewState);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRawData);
            this.Controls.Add(this.txtMarkup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "XSS POST generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtMarkup;
        private System.Windows.Forms.RichTextBox txtRawData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtViewState;
    }
}

