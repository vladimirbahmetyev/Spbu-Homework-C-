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
            this.ClockTime = new System.Windows.Forms.Timer(this.components);
            this.ClockTimer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ClockTime
            // 
            this.ClockTime.Enabled = true;
            this.ClockTime.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ClockTimer
            // 
            this.ClockTimer.AutoSize = true;
            this.ClockTimer.Location = new System.Drawing.Point(12, 9);
            this.ClockTimer.Name = "ClockTimer";
            this.ClockTimer.Size = new System.Drawing.Size(84, 13);
            this.ClockTimer.TabIndex = 0;
            this.ClockTimer.Text = "Time: HH:mm:ss";
            this.ClockTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ClockTimer.UseMnemonic = false;
            this.ClockTimer.Click += new System.EventHandler(this.ClockTimer_Click);
            // 
            // Clock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(204, 26);
            this.Controls.Add(this.ClockTimer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(220, 65);
            this.MinimumSize = new System.Drawing.Size(220, 65);
            this.Name = "Clock";
            this.Text = "Часы";
            this.Load += new System.EventHandler(this.Clock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer ClockTime;
        private System.Windows.Forms.Label ClockTimer;
    }
}

