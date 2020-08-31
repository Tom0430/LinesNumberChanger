namespace LinesNumberChanger
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonCountUp = new System.Windows.Forms.Button();
            this.buttonCountDown = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 32);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1492, 638);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // buttonCountUp
            // 
            this.buttonCountUp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonCountUp.Location = new System.Drawing.Point(263, 691);
            this.buttonCountUp.Name = "buttonCountUp";
            this.buttonCountUp.Size = new System.Drawing.Size(274, 37);
            this.buttonCountUp.TabIndex = 2;
            this.buttonCountUp.Text = "行番号＋１";
            this.buttonCountUp.UseVisualStyleBackColor = false;
            this.buttonCountUp.Click += new System.EventHandler(this.buttonCountUp_Click);
            // 
            // buttonCountDown
            // 
            this.buttonCountDown.BackColor = System.Drawing.Color.LightCoral;
            this.buttonCountDown.Location = new System.Drawing.Point(955, 691);
            this.buttonCountDown.Name = "buttonCountDown";
            this.buttonCountDown.Size = new System.Drawing.Size(274, 37);
            this.buttonCountDown.TabIndex = 3;
            this.buttonCountDown.Text = "行番号－１";
            this.buttonCountDown.UseVisualStyleBackColor = false;
            this.buttonCountDown.Click += new System.EventHandler(this.buttonCountDown_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "下に文字をコピペしてちょ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1527, 757);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCountDown);
            this.Controls.Add(this.buttonCountUp);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "行番号変換装置";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonCountUp;
        private System.Windows.Forms.Button buttonCountDown;
        private System.Windows.Forms.Label label1;
    }
}

