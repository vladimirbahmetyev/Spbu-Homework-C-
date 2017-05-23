namespace Hw6_2
{
    partial class Clock
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clock));
            this.ClockTimer = new System.Windows.Forms.Label();
            this.ClockTime = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ClockTimer
            // 
            this.ClockTimer.AutoSize = true;
            this.ClockTimer.Font = new System.Drawing.Font("Algerian", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClockTimer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClockTimer.Location = new System.Drawing.Point(12, 9);
            this.ClockTimer.Name = "ClockTimer";
            this.ClockTimer.Size = new System.Drawing.Size(218, 31);
            this.ClockTimer.TabIndex = 0;
            this.ClockTimer.Text = "Time: HH:mm:ss";
            this.ClockTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ClockTimer.UseMnemonic = false;
            this.ClockTimer.Click += new System.EventHandler(this.ClockTimer_Click);
            // 
            // ClockTime
            // 
            this.ClockTime.Enabled = true;
            this.ClockTime.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Clock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(234, 41);
            this.Controls.Add(this.ClockTimer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(250, 80);
            this.MinimumSize = new System.Drawing.Size(250, 80);
            this.Name = "Clock";
            this.Text = "Часы";
            this.Load += new System.EventHandler(this.Clock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ClockTimer;
        private System.Windows.Forms.Timer ClockTime;
    }
}

