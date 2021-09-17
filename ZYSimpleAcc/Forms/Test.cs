using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZYSimpleAcc.Forms
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }



        public static string EncodePasswordToBase64(string password)
        {
            try
            {
                byte[] encData_byte = new byte[password.Length];
                encData_byte = System.Text.Encoding.UTF8.GetBytes(password);
                string encodedData = Convert.ToBase64String(encData_byte);
                return encodedData;
            }
            catch (Exception ex)
            {
                throw new Exception("Error in base64Encode" + ex.Message);
            }
        }

        public string DecodeFrom64(string encodedData)
        {
            System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
            System.Text.Decoder utf8Decode = encoder.GetDecoder();
            byte[] todecode_byte = Convert.FromBase64String(encodedData);
            int charCount = utf8Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);
            char[] decoded_char = new char[charCount];
            utf8Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
            string result = new String(decoded_char);
            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
          string encrypted  = EncodePasswordToBase64(txtTarget.Text);

            txtEncrypted.Text = encrypted.ToString();
           
        }

        private void Test_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string decrypted = DecodeFrom64(txtEncrypted.Text);

            txtDecrypted.Text = decrypted.ToString(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtTarget.Clear();
            txtEncrypted.Clear();
            txtDecrypted.Clear();
        }
    }
}
