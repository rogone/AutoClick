using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using MyHook;

namespace Starter1
{
    public partial class Form1 : Form
    {
        public IntPtr targetHandle 
        {
            get { return this._targetHandle; }
            set {this._targetHandle = value;}
        }

        private IntPtr _targetHandle;

        public Form1()
        {
            InitializeComponent();

            this.openFileDialog1.Filter = "可执行文件(*.exe)|*.exe";
            this.openFileDialog1.InitialDirectory = ".";
            this.openFileDialog1.Multiselect = false;
            this.openFileDialog1.RestoreDirectory = true;
            this.openFileDialog1.Title = "选择可执行程序";
            this.openFileDialog1.ValidateNames = true;

            btOK.Enabled = false;
            comboBox1.GotFocus += new System.EventHandler(this.updateProcesses);
            btBrowse.Click += new System.EventHandler(this.btBrowse_Click);
        }

        private void btBrowse_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string strFileName = this.openFileDialog1.FileName;
                if (strFileName.Length > 0)
                {
                    //this.btBrowse.Enabled = false;
                    startProcess(strFileName);  
                }
            }
        }

        private void startProcess(string name)
        {
            Process app = new Process();
            app.StartInfo.FileName = name;
            app.StartInfo.CreateNoWindow = false;
            app.StartInfo.ErrorDialog = true;
            app.EnableRaisingEvents = true;

            app.Exited += new System.EventHandler(on_exit);
            app.Start();
            app.WaitForExit(1 * 1000);

            if (app.HasExited)
            {
                MessageBox.Show("进程意外退出", "警告");
            }
            else
            {
                updateProcesses(this, new EventArgs());
                IntPtr appid = new IntPtr(app.Id);
                IntPtr handle;
                foreach (object ob in this.comboBox1.Items)
                {
                    handle = ((MyComboBoxItem)ob).Handle;
                    IntPtr pid = NativeUtils.GetProcessForWindow(handle);
                    if (pid == appid)
                    {
                        this._targetHandle = handle;

                        btOK.Enabled = true;
                    }
                }
            }   
        }

        private void on_exit(object sender, EventArgs e)
        {
            this.btBrowse.Enabled = true;
            btOK.Enabled = false;
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            if ((this.targetHandle != IntPtr.Zero) && NativeUtils.IsTargetInDifferentProcess(this.targetHandle))
            {
                try
                {
                    FormHook hook = new FormHook();
                    hook.Hook(this.targetHandle, base.Handle);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void updateProcesses(object sender, EventArgs e)
        {
            this.comboBox1.Items.Clear();
            NativeUtils.EnumWindows(new NativeUtils.EnumWindowsProc(this.EnumWindowsProc), this.comboBox1.Handle);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.targetHandle = ((MyComboBoxItem)this.comboBox1.SelectedItem).Handle;
            this.btOK.Enabled = true;
        }

        private bool EnumWindowsProc(IntPtr hWnd, IntPtr h)
        {
            if (h == this.comboBox1.Handle
                && NativeUtils.IsTargetInDifferentProcess(hWnd)
                && NativeUtils.IsWindowVisible(hWnd))
            {
                this.comboBox1.Items.Add(new MyComboBoxItem(hWnd));
            }
            return true;
        }

        private void on_hooked(IntPtr h1, IntPtr h2)
        {
            Form form = new Recorder();
            form.Show();
        }
    }
}