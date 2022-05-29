using System.Windows.Forms;

namespace E_num_0._0._3
{
    public partial class VvodDannih : Form
    {
        public VvodDannih()
        {
            InitializeComponent();
        }

        public static string addressIP;
        public static string nameUser;
        public static string passwordUser = "";

        private void buttonOtpravkiDannih_Click(object sender, System.EventArgs e)
        {
            addressIP = vvodNameOrIP.Text;
            nameUser = vvodNameUser.Text;
            passwordUser = vvodPasswordUser.Text;

            if (passwordUser == "")
            {
                OknoSoshibkoi oknoSoshibkoi = new OknoSoshibkoi();

                oknoSoshibkoi.ShowDialog();

                return;
            }

            Close();
        }

        private void vvodNameOrIP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buttonOtpravkiDannih_Click(sender, e);
        }

        private void vvodNameUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buttonOtpravkiDannih_Click(sender, e);
        }

        private void vvodPasswordUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buttonOtpravkiDannih_Click(sender, e);
        }

        private void buttonOtpravkiDannih_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buttonOtpravkiDannih_Click(sender, e);
        }
    }
}
