using System;
using System.Windows.Forms;

namespace TemperatureConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double inputValue;
            if (!double.TryParse(txtInput.Text, out inputValue))
            {
                MessageBox.Show("กรุณากรอกตัวเลขที่ถูกต้อง");
                return;
            }

            string fromUnit = cmbFrom.SelectedItem.ToString();
            string toUnit = cmbTo.SelectedItem.ToString();
            double result = ConvertTemperature(inputValue, fromUnit, toUnit);

            lblResult.Text = $"ผลลัพธ์: {result:0.00} {toUnit}";
        }

        private double ConvertTemperature(double value, string from, string to)
        {
            double celsius;

            // แปลงหน่วยต้นทางเป็น Celsius
            switch (from)
            {
                case "Celsius":
                    celsius = value;
                    break;
                case "Fahrenheit":
                    celsius = (value - 32) * 5 / 9;
                    break;
                case "Kelvin":
                    celsius = value - 273.15;
                    break;
                default:
                    throw new Exception("หน่วยต้นทางไม่ถูกต้อง");
            }

            // แปลงจาก Celsius ไปยังหน่วยปลายทาง
            switch (to)
            {
                case "Celsius":
                    return celsius;
                case "Fahrenheit":
                    return (celsius * 9 / 5) + 32;
                case "Kelvin":
                    return celsius + 273.15;
                default:
                    throw new Exception("หน่วยปลายทางไม่ถูกต้อง");
            }
        }
    }
}
