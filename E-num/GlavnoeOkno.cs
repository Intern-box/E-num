using System;
using System.IO;
using System.Management;
using System.Windows.Forms;

namespace E_num
{
    public partial class GlavnoeOkno : Form
    {
        public GlavnoeOkno()
        {
            InitializeComponent();
        }

        private void buttonChistka_Click(object sender, EventArgs e)
        {
            poleVivodaDannih.Text = string.Empty;
        }

        private void buttonSohranit_Click(object sender, EventArgs e)
        {
            SaveFileDialog KopiruemDannieVtxt = new SaveFileDialog();
            KopiruemDannieVtxt.Filter = "Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (KopiruemDannieVtxt.ShowDialog() == DialogResult.OK)
                File.WriteAllText(KopiruemDannieVtxt.FileName, poleVivodaDannih.Text);
        }

        private void buttonEtotKomputer_Click(object sender, EventArgs e)
        {
            if (poleVivodaDannih.Text != string.Empty)
            {
                poleVivodaDannih.Text += "\r\n\r\n";
            }

            // Создаём объект и читаем данные по Имени ПК и Имени ОС
            try
            {
                ManagementObjectSearcher searcher0 = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_OperatingSystem");
                foreach (ManagementObject queryObj0 in searcher0.Get())
                {
                    poleVivodaDannih.Text += "Имя компьютера:\t\t" + queryObj0["csname"] + "\r\n";
                    poleVivodaDannih.Text += "Операционная система:\t" + queryObj0["Caption"] + "\r\n";
                }
            }
            catch
            {
                poleVivodaDannih.Text += "Операционная система:\tОшибка определения\r\n";
            }

            // Создаём объект и читаем данные по ЦПУ
            try
            {
                ManagementObjectSearcher searcher1 = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor");
                foreach (ManagementObject queryObj1 in searcher1.Get())
                    poleVivodaDannih.Text += "Процессор:\t\t" + queryObj1["Name"] + "\r\n";
            }
            catch
            {
                poleVivodaDannih.Text += "Процессор:\t\tОшибка определения\r\n";
            }

            // Создаём объект и читаем данные по плате
            try
            {
                ManagementObjectSearcher searcher2 = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BaseBoard");
                foreach (ManagementObject queryObj2 in searcher2.Get())
                    poleVivodaDannih.Text += "Плата:\t\t\t" + queryObj2["Manufacturer"] + queryObj2["Product"] + "\r\n";
            }
            catch
            {
                poleVivodaDannih.Text += "Плата:\t\t\tОшибка определения\r\n";
            }

            // Создаём объект и читаем данные по ОЗУ
            try
            {
                ManagementObjectSearcher searcher3 = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_PhysicalMemory");
                foreach (ManagementObject queryObj3 in searcher3.Get())
                {
                    if ((UInt32)queryObj3["SMBIOSMemoryType"] == 26)
                    {
                        poleVivodaDannih.Text += "Память:\t\t\tDDR4 " + (ulong)queryObj3["Capacity"] / 1073741824 + "GB " + queryObj3["Speed"] + "MHz" + "\r\n";
                    }
                    else if ((UInt32)queryObj3["SMBIOSMemoryType"] == 24)
                    {
                        poleVivodaDannih.Text += "Память:\t\t\tDDR3 " + (ulong)queryObj3["Capacity"] / 1073741824 + "GB " + queryObj3["Speed"] + "MHz" + "\r\n";
                    }
                    else if ((UInt32)queryObj3["SMBIOSMemoryType"] == 19)
                    {
                        poleVivodaDannih.Text += "Память:\t\t\tDDR2 " + (ulong)queryObj3["Capacity"] / 1073741824 + "GB " + queryObj3["Speed"] + "MHz" + "\r\n";
                    }
                    else
                    {
                        poleVivodaDannih.Text += "Память:\t\t\t" + (ulong)queryObj3["Capacity"] / 1073741824 + "GB " + queryObj3["Speed"] + "MHz" + "\r\n";
                    }
                }
            }
            catch
            {
                poleVivodaDannih.Text += "Память:\t\t\tОшибка определения\r\n";
            }

            // Создаём объект и читаем данные по видео-адаптерам
            try
            {
                ManagementObjectSearcher searcher4 = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_VideoController");
                foreach (ManagementObject queryObj4 in searcher4.Get())
                    poleVivodaDannih.Text += "Видеокарта:\t\t" + queryObj4["Description"] + "\r\n";
            }
            catch
            {
                poleVivodaDannih.Text += "Видеокарта:\t\tОшибка определения\r\n";
            }

            // Создаём объект и читаем данные по накопителям
            try
            {
                ManagementObjectSearcher searcher5 = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_DiskDrive");
                foreach (ManagementObject queryObj5 in searcher5.Get())
                    poleVivodaDannih.Text += "Накопитель:\t\t" + queryObj5["Model"] + "\r\n";
            }
            catch
            {
                poleVivodaDannih.Text += "Накопитель:\t\tОшибка определения\r\n";
            }
        }

        private void buttonKomputerVseti_Click(object sender, EventArgs e)
        {
            if (poleVivodaDannih.Text != string.Empty)
            {
                poleVivodaDannih.Text += "\r\n\r\n";
            }

            VvodDannih zaprosDannih = new VvodDannih();

            zaprosDannih.ShowDialog();

            if (VvodDannih.passwordUser == "")
            {
                poleVivodaDannih.Text += "\nПароль не должен быть пустым!";

                return;
            }

            ConnectionOptions options = new ConnectionOptions();
            options.Username = VvodDannih.nameUser;
            options.Password = VvodDannih.passwordUser;

            try
            {
                ManagementScope scope = new ManagementScope($"\\\\{VvodDannih.addressIP}\\root\\cimv2", options);
                scope.Connect();

                // Создаём объект и читаем данные по Имени ПК и Имени ОС
                try
                {
                    ObjectQuery query = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");
                    ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query);
                    foreach (ManagementObject queryObj in searcher.Get())
                    {
                        poleVivodaDannih.Text += "Имя компьютера:\t\t" + queryObj["csname"] + "\r\n";
                        poleVivodaDannih.Text += "Операционная система:\t" + queryObj["Caption"] + "\r\n";
                    }
                }
                catch
                {
                    poleVivodaDannih.Text += "Операционная система:\tОшибка определения\r\n";
                }

                // Создаём объект и читаем данные по ЦПУ
                try
                {
                    ObjectQuery query1 = new ObjectQuery("SELECT * FROM Win32_Processor");
                    ManagementObjectSearcher searcher1 = new ManagementObjectSearcher(scope, query1);
                    foreach (ManagementObject queryObj1 in searcher1.Get())
                        poleVivodaDannih.Text += "Процессор:\t\t" + queryObj1["Name"] + "\r\n";
                }
                catch
                {
                    poleVivodaDannih.Text += "Процессор:\t\tОшибка определения\r\n";
                }

                // Создаём объект и читаем данные по плате
                try
                {
                    ObjectQuery query2 = new ObjectQuery("SELECT * FROM Win32_BaseBoard");
                    ManagementObjectSearcher searcher2 = new ManagementObjectSearcher(scope, query2);
                    foreach (ManagementObject queryObj2 in searcher2.Get())
                        poleVivodaDannih.Text += "Плата:\t\t\t" + queryObj2["Manufacturer"] + queryObj2["Product"] + "\r\n";
                }
                catch
                {
                    poleVivodaDannih.Text += "Плата:\t\t\tОшибка определения\r\n";
                }

                // Создаём объект и читаем данные по ОЗУ
                try
                {
                    ObjectQuery query3 = new ObjectQuery("SELECT * FROM Win32_ComputerSystem");
                    ManagementObjectSearcher searcher3 = new ManagementObjectSearcher(scope, query3);
                    foreach (ManagementObject queryObj3 in searcher3.Get())
                        poleVivodaDannih.Text += "Память:\t\t\t" + (ulong)queryObj3["TotalPhysicalMemory"] / 1024 / 1024 + " МБ" + "\r\n";
                }
                catch
                {
                    poleVivodaDannih.Text += "Память:\t\t\tОшибка определения\r\n";
                }

                // Создаём объект и читаем данные по видео-адаптерам
                try
                {
                    ObjectQuery query4 = new ObjectQuery("SELECT * FROM Win32_VideoController");
                    ManagementObjectSearcher searcher4 = new ManagementObjectSearcher(scope, query4);
                    foreach (ManagementObject queryObj4 in searcher4.Get())
                        poleVivodaDannih.Text += "Видеокарта:\t\t" + queryObj4["Description"] + "\r\n";
                }
                catch
                {
                    poleVivodaDannih.Text += "Видеокарта:\t\tОшибка определения";
                }

                // Создаём объект и читаем данные по накопителям
                try
                {
                    ObjectQuery query5 = new ObjectQuery("SELECT * FROM Win32_DiskDrive");
                    ManagementObjectSearcher searcher5 = new ManagementObjectSearcher(scope, query5);
                    foreach (ManagementObject queryObj5 in searcher5.Get())
                        poleVivodaDannih.Text += "Накопитель:\t\t" + queryObj5["Model"] + "\r\n";
                }
                catch
                {
                    poleVivodaDannih.Text += "Накопитель:\t\tОшибка определения";
                }
            }
            catch
            {
                poleVivodaDannih.Text += "Ошибка подключения к удалённому компьютеру...";
            }
        }
    }
}