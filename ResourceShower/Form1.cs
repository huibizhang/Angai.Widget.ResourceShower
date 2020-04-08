using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResourceShower
{
    public partial class Form1 : Form
    {
        PerformanceCounter p_CPU;
        Microsoft.VisualBasic.Devices.ComputerInfo ci = new Microsoft.VisualBasic.Devices.ComputerInfo();
        Microsoft.VisualBasic.Devices.Computer c = new Microsoft.VisualBasic.Devices.Computer();

        SolidBrush bb = new SolidBrush(Color.FromArgb(0, 192, 0)); 
        SolidBrush bb2 = new SolidBrush(Color.FromArgb(51, 153, 255));
        Pen p1,p2;

        ResourceMonitor cpu, memory;

        bool drag;

        int dragX, dragY;

        JObject setting;
        bool setting_loaded;

        Size original_size = new Size(206, 105);

        public static int gap = 3;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            load_setting();

            p_CPU = new PerformanceCounter("Processor", "% Processor Time", "_Total");

            timer1.Enabled = true;

            List<Canva> cpu_canvas = new List<Canva>();
            List<Canva> memory_canvas = new List<Canva>();

            for (int i = 0; i < 3; i++){
                cpu_canvas.Add(new Canva(new Bitmap(200, 50)));
                memory_canvas.Add(new Canva(new Bitmap(200, 50)));
            }

            cpu = new ResourceMonitor(cpu_canvas);
            memory = new ResourceMonitor(memory_canvas);

            p1 = new Pen(bb, 1);
            p2 = new Pen(bb2, 1);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int cpu_value = (int)p_CPU.NextValue();
            int memory_value = (int)((ci.TotalPhysicalMemory - ci.AvailablePhysicalMemory) * 100 / ci.TotalPhysicalMemory);

            pictureBox1.Image = cpu.Ddraw(cpu_value, true, p1, this.Font);
            pictureBox2.Image = memory.Ddraw(memory_value, false, p2, this.Font);
        }

        private void Form1_ResizeBegin(object sender, EventArgs e)
        {
            ReSize();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (drag = e.Button == MouseButtons.Left) {
                dragX = e.X;
                dragY = e.Y;
            }
                
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag) {
                this.Left += e.X - dragX;
                this.Top += e.Y - dragY;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                drag = false;
                save();
            }
        }

        private void 顯示在最上層ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            顯示在最上層ToolStripMenuItem.Checked = !顯示在最上層ToolStripMenuItem.Checked;
            this.TopMost = 顯示在最上層ToolStripMenuItem.Checked;
            save();
        }

        private void 無邊框ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            無邊框ToolStripMenuItem.Checked = !無邊框ToolStripMenuItem.Checked;
            if (無邊框ToolStripMenuItem.Checked)
                this.FormBorderStyle = FormBorderStyle.None;
            else
                this.FormBorderStyle = FormBorderStyle.Sizable;
            save();
        }

        private void 結束ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Size = original_size;
        }

        private void xToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Size = new Size((int)((double)original_size.Width*1.25), (int)((double)original_size.Height*1.25));
        }

        private void xToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Size = new Size((int)((double)original_size.Width * 1.5), (int)((double)original_size.Height * 1.5));
        }

        private void 連續ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gap = 1;
            save();
        }

        private void 間斷2xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gap = 2;
            save();
        }

        private void 間斷3xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gap = 3;
            save();
        }

        void ReSize() {
            if (this.FormBorderStyle == FormBorderStyle.Sizable)
            {
                pictureBox1.Height = (this.Height - 45) / 2;
                pictureBox2.Height = pictureBox1.Height;
                pictureBox2.Top = pictureBox1.Height + 2;
            }
            else {
                pictureBox1.Height = (this.Height - 5) / 2;
                pictureBox2.Height = pictureBox1.Height;
                pictureBox2.Top = pictureBox1.Height + 2;
            }
            save();
        }

        void load_setting()
        {
            if (!File.Exists("setting.json"))
                File.WriteAllText("setting.json", Properties.Resources.OriginalSetting);

            string temp = File.ReadAllText("setting.json");
            setting = (JObject)JsonConvert.DeserializeObject(temp);

            this.Left = (int)setting["position"]["x"];
            this.Top = (int)setting["position"]["y"];

            this.Width = (int)setting["size"]["width"];
            this.Height = (int)setting["size"]["height"];

            gap = (int)setting["gap"];

            顯示在最上層ToolStripMenuItem.Checked = (bool)setting["topMost"];
            this.TopMost = 顯示在最上層ToolStripMenuItem.Checked;

            無邊框ToolStripMenuItem.Checked = (bool)setting["noneBorder"];

            if (無邊框ToolStripMenuItem.Checked)
            {
                this.FormBorderStyle = FormBorderStyle.None;
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
            }

            setting_loaded = true;
        }

        void save() {
            if (setting_loaded) {
                setting["position"]["x"] = this.Left;
                setting["position"]["y"] = this.Top;

                setting["size"]["width"] = this.Width;
                setting["size"]["height"] = this.Height;

                setting["gap"] = gap;
                setting["topMost"] = this.TopMost;
                setting["noneBorder"] = (this.FormBorderStyle == FormBorderStyle.None);

                File.WriteAllText("setting.json", setting.ToString());
            }
        }
    }
}
