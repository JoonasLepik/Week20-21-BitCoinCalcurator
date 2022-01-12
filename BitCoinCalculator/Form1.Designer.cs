namespace BitCoinCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.curencyMenue = new System.Windows.Forms.ComboBox();
            this.getRatesBtn = new System.Windows.Forms.Button();
            this.amountOfBtc = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.resultLbi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // curencyMenue
            // 
            this.curencyMenue.FormattingEnabled = true;
            this.curencyMenue.Items.AddRange(new object[] {
            "EUR",
            "USD"});
            this.curencyMenue.Location = new System.Drawing.Point(56, 49);
            this.curencyMenue.Name = "curencyMenue";
            this.curencyMenue.Size = new System.Drawing.Size(121, 23);
            this.curencyMenue.TabIndex = 0;
            this.curencyMenue.Text = "Select Curency";
            // 
            // getRatesBtn
            // 
            this.getRatesBtn.Location = new System.Drawing.Point(217, 99);
            this.getRatesBtn.Name = "getRatesBtn";
            this.getRatesBtn.Size = new System.Drawing.Size(75, 23);
            this.getRatesBtn.TabIndex = 1;
            this.getRatesBtn.Text = "Get Rates";
            this.getRatesBtn.UseVisualStyleBackColor = true;
            this.getRatesBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // amountOfBtc
            // 
            this.amountOfBtc.Location = new System.Drawing.Point(56, 100);
            this.amountOfBtc.Name = "amountOfBtc";
            this.amountOfBtc.PlaceholderText = "Amount of BitCoins";
            this.amountOfBtc.Size = new System.Drawing.Size(121, 23);
            this.amountOfBtc.TabIndex = 2;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(56, 193);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(100, 23);
            this.result.TabIndex = 3;
            this.result.Visible = false;
            // 
            // resultLbi
            // 
            this.resultLbi.AutoSize = true;
            this.resultLbi.Location = new System.Drawing.Point(56, 164);
            this.resultLbi.Name = "resultLbi";
            this.resultLbi.Size = new System.Drawing.Size(39, 15);
            this.resultLbi.TabIndex = 4;
            this.resultLbi.Text = "Result";
            this.resultLbi.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultLbi);
            this.Controls.Add(this.result);
            this.Controls.Add(this.amountOfBtc);
            this.Controls.Add(this.getRatesBtn);
            this.Controls.Add(this.curencyMenue);
            this.Name = "Form1";
            this.Text = "BitCoin Calcurator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox curencyMenue;
        private System.Windows.Forms.Button getRatesBtn;
        private System.Windows.Forms.TextBox amountOfBtc;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label resultLbi;
    }
}

