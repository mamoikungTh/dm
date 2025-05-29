namespace TemperatureConverter
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;


        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtInput = new System.Windows.Forms.TextBox();
            this.cmbFrom = new System.Windows.Forms.ComboBox();
            this.cmbTo = new System.Windows.Forms.ComboBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblInput = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblInput.Location = new System.Drawing.Point(30, 30);
            this.lblInput.Name = "lblInput";
            this.lblInput.Text = "อุณหภูมิ (ตัวเลข):";
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtInput.Location = new System.Drawing.Point(160, 27);
            this.txtInput.Size = new System.Drawing.Size(150, 25);
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFrom.Location = new System.Drawing.Point(30, 70);
            this.lblFrom.Text = "จากหน่วย:";
            // 
            // cmbFrom
            // 
            this.cmbFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFrom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbFrom.Items.AddRange(new object[] {
        "Celsius",
        "Fahrenheit",
        "Kelvin"});
            this.cmbFrom.Location = new System.Drawing.Point(160, 67);
            this.cmbFrom.Size = new System.Drawing.Size(150, 25);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTo.Location = new System.Drawing.Point(30, 110);
            this.lblTo.Text = "ไปยังหน่วย:";
            // 
            // cmbTo
            // 
            this.cmbTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTo.Items.AddRange(new object[] {
        "Celsius",
        "Fahrenheit",
        "Kelvin"});
            this.cmbTo.Location = new System.Drawing.Point(160, 107);
            this.cmbTo.Size = new System.Drawing.Size(150, 25);
            // 
            // btnConvert
            // 
            this.btnConvert.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnConvert.Location = new System.Drawing.Point(160, 150);
            this.btnConvert.Size = new System.Drawing.Size(150, 35);
            this.btnConvert.Text = "แปลงอุณหภูมิ";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblResult.Location = new System.Drawing.Point(30, 200);
            this.lblResult.Size = new System.Drawing.Size(130, 20);
            this.lblResult.Text = "ผลลัพธ์: -";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(350, 250);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.cmbFrom);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.cmbTo);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.lblResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temperature Converter";
            this.ResumeLayout(false);
            this.PerformLayout();
        }


        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.ComboBox cmbFrom;
        private System.Windows.Forms.ComboBox cmbTo;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblResult;
    }
}
