﻿namespace tutorial_2_3
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.translationLabel = new System.Windows.Forms.Label();
            this.italianButton = new System.Windows.Forms.Button();
            this.spanishButton = new System.Windows.Forms.Button();
            this.germanButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(52, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(596, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "選擇一個語言，我會說早安";
            // 
            // translationLabel
            // 
            this.translationLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.translationLabel.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.translationLabel.Location = new System.Drawing.Point(102, 223);
            this.translationLabel.Name = "translationLabel";
            this.translationLabel.Size = new System.Drawing.Size(538, 75);
            this.translationLabel.TabIndex = 1;
            this.translationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // italianButton
            // 
            this.italianButton.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.italianButton.Location = new System.Drawing.Point(60, 330);
            this.italianButton.Name = "italianButton";
            this.italianButton.Size = new System.Drawing.Size(183, 61);
            this.italianButton.TabIndex = 2;
            this.italianButton.Text = "義大利文";
            this.italianButton.UseVisualStyleBackColor = true;
            this.italianButton.Click += new System.EventHandler(this.italianButton_Click);
            // 
            // spanishButton
            // 
            this.spanishButton.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.spanishButton.Location = new System.Drawing.Point(280, 330);
            this.spanishButton.Name = "spanishButton";
            this.spanishButton.Size = new System.Drawing.Size(183, 61);
            this.spanishButton.TabIndex = 3;
            this.spanishButton.Text = "西班牙文";
            this.spanishButton.UseVisualStyleBackColor = true;
            this.spanishButton.Click += new System.EventHandler(this.spanishButton_Click);
            // 
            // germanButton
            // 
            this.germanButton.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.germanButton.Location = new System.Drawing.Point(515, 330);
            this.germanButton.Name = "germanButton";
            this.germanButton.Size = new System.Drawing.Size(183, 61);
            this.germanButton.TabIndex = 4;
            this.germanButton.Text = "德文";
            this.germanButton.UseVisualStyleBackColor = true;
            this.germanButton.Click += new System.EventHandler(this.germanButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.germanButton);
            this.Controls.Add(this.spanishButton);
            this.Controls.Add(this.italianButton);
            this.Controls.Add(this.translationLabel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "語言翻譯器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label translationLabel;
        private System.Windows.Forms.Button italianButton;
        private System.Windows.Forms.Button spanishButton;
        private System.Windows.Forms.Button germanButton;
    }
}

