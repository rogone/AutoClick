using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Starter1
{
    public partial class ShowControls : Form
    {
        public ShowControls()
        {
            InitializeComponent();
        }

        private void ShowControls_Load(object sender, EventArgs e)
        {
            Control win = Control.FromHandle(Recorder.Instance.spywindow);
            //Control win = Process.GetCurrentProcess().MainWindowHandle);
            if (null != win)
            {
                //treeView1.TopNode = new TreeNode();
                treeView1.Nodes.Add(win.Text);

                addChild(win, treeView1.TopNode);
                treeView1.ExpandAll();
            }
        }

        private void addChild(object father, TreeNode fathernode)
        {
            if (father is ToolStripMenuItem)
            {
                ToolStripMenuItem item = father as ToolStripMenuItem;
                if (item.DropDownItems.Count > 0)
                {
                    fathernode.Nodes.Add("ToolStripDropDownItem");

                    foreach (ToolStripItem i in item.DropDownItems)
                    {
                        TreeNode tn = new TreeNode();
                        tn.Text = string.Format("{0}, Name:{1}, Text:{2}, Tooltip:{3}", i.GetType().FullName, i.Name, i.Text, i.ToolTipText);
                        fathernode.Nodes[0].Nodes.Add(tn);
                        addChild(i, tn);
                    }
                }
            }
            /*else if (father is MenuStrip)
            {
                MenuStrip m = father as MenuStrip;

                if (m.Items.Count > 0)
                {
                    fathernode.Nodes.Add("MenuStrip");

                    foreach (ToolStripItem i in m.Items)
                    {
                        TreeNode tn = new TreeNode();
                        tn.Text = string.Format("{0}, Name:{1}, Text:{2}, Tooltip:{3}", i.GetType().FullName, i.Name, i.Text, i.ToolTipText);
                        fathernode.Nodes[0].Nodes.Add(tn);
                        addChild(i, tn);
                    }
                }
            }*/
            else if (father is ToolStrip)
            {
                ToolStrip m = father as ToolStrip;

                if (m.Items.Count > 0)
                {
                    fathernode.Nodes.Add("ToolStrip");

                    foreach (ToolStripItem i in m.Items)
                    {
                        TreeNode tn = new TreeNode();
                        tn.Text = string.Format("{0}, Name:{1}, Text:{2}, Tooltip:{3}", i.GetType().FullName, i.Name, i.Text, i.ToolTipText);
                        fathernode.Nodes[0].Nodes.Add(tn);
                        addChild(i, tn);
                    }
                }
            }
            else if (father is Control)
            {
                Control ctl = father as Control;
                foreach (Control c in ctl.Controls)
                {
                    TreeNode tn = new TreeNode();
                    tn.Text = string.Format("{0}, Name:{1}, Text:{2}", c.GetType().FullName, c.Name, c.Text);
                    fathernode.Nodes.Add(tn);

                    addChild(c, tn);
                }  
            }
        }
    }
}