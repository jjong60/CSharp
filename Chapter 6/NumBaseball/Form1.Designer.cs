namespace NumBaseball
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label = new System.Windows.Forms.Label();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.Hit = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.Label();
            this.makeNum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label.Location = new System.Drawing.Point(93, 49);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(195, 30);
            this.label.TabIndex = 0;
            this.label.Text = "숫자 야구";
            this.label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TextBox
            // 
            this.TextBox.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TextBox.Location = new System.Drawing.Point(86, 153);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(100, 39);
            this.TextBox.TabIndex = 1;
            // 
            // Hit
            // 
            this.Hit.AutoSize = true;
            this.Hit.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Hit.Location = new System.Drawing.Point(239, 155);
            this.Hit.Name = "Hit";
            this.Hit.Size = new System.Drawing.Size(75, 37);
            this.Hit.TabIndex = 2;
            this.Hit.Text = "Hit";
            this.Hit.UseVisualStyleBackColor = true;
            this.Hit.Click += new System.EventHandler(this.Hit_Click);
            // 
            // Result
            // 
            this.Result.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Result.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Result.Location = new System.Drawing.Point(0, 239);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(388, 21);
            this.Result.TabIndex = 3;
            this.Result.Text = "0Strike 0Ball 0Out";
            this.Result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // makeNum
            // 
            this.makeNum.Location = new System.Drawing.Point(239, 126);
            this.makeNum.Name = "makeNum";
            this.makeNum.Size = new System.Drawing.Size(75, 23);
            this.makeNum.TabIndex = 4;
            this.makeNum.Text = "Shoot";
            this.makeNum.UseVisualStyleBackColor = true;
            this.makeNum.Click += new System.EventHandler(this.makeNum_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 290);
            this.Controls.Add(this.makeNum);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Hit);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.label);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Button Hit;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Button makeNum;
    }
}

