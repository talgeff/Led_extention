namespace Led_GUI_Extention
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
            this.RedLed = new Led_GUI_Extention.Led();
            this.BlueLed = new Led_GUI_Extention.Led();
            this.GreenLed = new Led_GUI_Extention.Led();
            this.BlueLedBTN = new System.Windows.Forms.Button();
            this.GreenLedBTN = new System.Windows.Forms.Button();
            this.RedLedBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RedLed
            // 
            this.RedLed.AutoSize = true;
            this.RedLed.Color = Led_GUI_Extention.Led.LedType.Red;
            this.RedLed.DisplayStatus = false;
            this.RedLed.Location = new System.Drawing.Point(45, 73);
            this.RedLed.MinimumSize = new System.Drawing.Size(30, 30);
            this.RedLed.Name = "RedLed";
            this.RedLed.Size = new System.Drawing.Size(78, 30);
            this.RedLed.TabIndex = 0;
            this.RedLed.Text = "RedLed";
            this.RedLed.UseVisualStyleBackColor = true;
            // 
            // BlueLed
            // 
            this.BlueLed.AutoSize = true;
            this.BlueLed.Color = Led_GUI_Extention.Led.LedType.Blue;
            this.BlueLed.DisplayStatus = true;
            this.BlueLed.Location = new System.Drawing.Point(218, 73);
            this.BlueLed.MinimumSize = new System.Drawing.Size(30, 30);
            this.BlueLed.Name = "BlueLed";
            this.BlueLed.Size = new System.Drawing.Size(78, 30);
            this.BlueLed.TabIndex = 2;
            this.BlueLed.Text = "RedLed";
            this.BlueLed.UseVisualStyleBackColor = true;
            // 
            // GreenLed
            // 
            this.GreenLed.AutoSize = true;
            this.GreenLed.Color = Led_GUI_Extention.Led.LedType.Green;
            this.GreenLed.DisplayStatus = true;
            this.GreenLed.Location = new System.Drawing.Point(131, 73);
            this.GreenLed.MinimumSize = new System.Drawing.Size(30, 30);
            this.GreenLed.Name = "GreenLed";
            this.GreenLed.Size = new System.Drawing.Size(78, 30);
            this.GreenLed.TabIndex = 3;
            this.GreenLed.Text = "RedLed";
            this.GreenLed.UseVisualStyleBackColor = true;
            // 
            // BlueLedBTN
            // 
            this.BlueLedBTN.Location = new System.Drawing.Point(195, 12);
            this.BlueLedBTN.Name = "BlueLedBTN";
            this.BlueLedBTN.Size = new System.Drawing.Size(75, 36);
            this.BlueLedBTN.TabIndex = 4;
            this.BlueLedBTN.Text = "toggle";
            this.BlueLedBTN.UseVisualStyleBackColor = true;
            this.BlueLedBTN.Click += new System.EventHandler(this.BlueLedBTN_Click);
            // 
            // GreenLedBTN
            // 
            this.GreenLedBTN.Location = new System.Drawing.Point(108, 12);
            this.GreenLedBTN.Name = "GreenLedBTN";
            this.GreenLedBTN.Size = new System.Drawing.Size(75, 36);
            this.GreenLedBTN.TabIndex = 5;
            this.GreenLedBTN.Text = "toggle";
            this.GreenLedBTN.UseVisualStyleBackColor = true;
            this.GreenLedBTN.Click += new System.EventHandler(this.GreenLedBTN_Click);
            // 
            // RedLedBTN
            // 
            this.RedLedBTN.Location = new System.Drawing.Point(22, 12);
            this.RedLedBTN.Name = "RedLedBTN";
            this.RedLedBTN.Size = new System.Drawing.Size(75, 36);
            this.RedLedBTN.TabIndex = 6;
            this.RedLedBTN.Text = "toggle";
            this.RedLedBTN.UseVisualStyleBackColor = true;
            this.RedLedBTN.Click += new System.EventHandler(this.RedLedBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 135);
            this.Controls.Add(this.RedLedBTN);
            this.Controls.Add(this.GreenLedBTN);
            this.Controls.Add(this.BlueLedBTN);
            this.Controls.Add(this.GreenLed);
            this.Controls.Add(this.BlueLed);
            this.Controls.Add(this.RedLed);
            this.Name = "Form1";
            this.Text = "Leds";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Led RedLed;
        private Led BlueLed;
        private Led GreenLed;
        private System.Windows.Forms.Button BlueLedBTN;
        private System.Windows.Forms.Button GreenLedBTN;
        private System.Windows.Forms.Button RedLedBTN;
    }
}

