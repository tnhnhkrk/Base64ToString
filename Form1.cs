namespace BaseStr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = DecodeBase64ToString(textBox1.Text);
        }


        // Base64'den string'e dönüþüm yapan metod
        public static string DecodeBase64ToString(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }

        // String'i Base64'e kodlayan metod
        public static string EncodeStringToBase64(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = EncodeStringToBase64(textBox2.Text);

        }
    }
}
