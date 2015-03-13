using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MouseKeyboardLibrary;
using MyHook;
using System.Reflection;
using System.Threading;

namespace Starter1
{
    public partial class Recorder : Form
    {
        public static Recorder Instance;
        public MouseHook mouseHook = new MouseHook();
        public KeyboardHook keyboardHook = new KeyboardHook();
        public IntPtr spywindow
        {
            get { return _spyWindow; }
            set { _spyWindow = value; }
        }

        private IntPtr _spyWindow;
        private Point _currentPoint = new Point();

        private bool _recording = false;
       // private bool _playing = false;

        public Recorder()
        {
            InitializeComponent();
        }

        private void Recorder_Load(object sender, EventArgs e)
        {
            mouseHook.MouseMove += new MouseEventHandler(mouseHook_MouseMove);
            mouseHook.MouseDown += new MouseEventHandler(mouseHook_MouseDown);
            mouseHook.MouseUp += new MouseEventHandler(mouseHook_MouseUp);
            mouseHook.MouseWheel += new MouseEventHandler(mouseHook_MouseWheel);
            mouseHook.Click += new MouseEventHandler(mouseHook_Click);
            mouseHook.DoubleClick += new MouseEventHandler(mouseHook_DoubleClick);

            keyboardHook.KeyDown += new KeyEventHandler(keyboardHook_KeyDown);
            keyboardHook.KeyUp += new KeyEventHandler(keyboardHook_KeyUp);
            keyboardHook.KeyPress += new KeyEventHandler(keyboardHook_KeyPress);

            btRecord.Text = "开始";
            btPlay.Text = "播放";
            //btConfig.Text = "播放配置";
            btConfig.Enabled = false;

            /*{
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewCheckBoxCell cbbCell = new DataGridViewCheckBoxCell();
                cbbCell.Value = true;
                row.Cells.Add(cbbCell);

                DataGridViewTextBoxCell tbOpCell = new DataGridViewTextBoxCell();
                tbOpCell.Value = "None";
                row.Cells.Add(tbOpCell);

                DataGridViewTextBoxCell tbNameCell = new DataGridViewTextBoxCell();
                tbNameCell.Value = "Name";
                row.Cells.Add(tbNameCell);

                DataGridViewTextBoxCell tbTextCell = new DataGridViewTextBoxCell();
                tbTextCell.Value = "Text";
                row.Cells.Add(tbTextCell);

                DataGridViewTextBoxCell tbClassCell = new DataGridViewTextBoxCell();
                tbClassCell.Value = "Class";
                row.Cells.Add(tbClassCell);

                dataGrid.Rows.Add(row);
            }*/

            Instance = this;
        }


        void keyboardHook_KeyPress(object sender, KeyEventArgs e)
        {
            AddKeyboardEvent(
                "KeyPress",
                e.KeyCode.ToString(),
                e.KeyData.ToString(),
                e.Shift.ToString(),
                e.Alt.ToString(),
                e.Control.ToString()
                );
        }

        void keyboardHook_KeyUp(object sender, KeyEventArgs e)
        {
            AddKeyboardEvent(
                "KeyUp",
                e.KeyCode.ToString(),
                "",
                e.Shift.ToString(),
                e.Alt.ToString(),
                e.Control.ToString()
                );
        }

        void keyboardHook_KeyDown(object sender, KeyEventArgs e)
        {
            AddKeyboardEvent(
                "KeyDown",
                e.KeyCode.ToString(),
                "",
                e.Shift.ToString(),
                e.Alt.ToString(),
                e.Control.ToString()
                );
        }

        void mouseHook_MouseWheel(object sender, MouseEventArgs e)
        {
            AddMouseEvent(
                MouseHook.MouseEventType.MouseWheel.ToString("f"),
                "",
                "",
                "",
                e.Delta.ToString()
                );
        }

        void mouseHook_MouseUp(object sender, MouseEventArgs e)
        {
            AddMouseEvent(
                MouseHook.MouseEventType.MouseUp.ToString("f"),
                e.Button.ToString(),
                e.X.ToString(),
                e.Y.ToString(),
                ""
                );
        }

        void mouseHook_MouseDown(object sender, MouseEventArgs e)
        {
            AddMouseEvent(
                MouseHook.MouseEventType.MouseDown.ToString("f"),
                e.Button.ToString(),
                e.X.ToString(),
                e.Y.ToString(),
                ""
                );
        }

        void mouseHook_MouseMove(object sender, MouseEventArgs e)
        {
            AddMouseEvent(
                MouseHook.MouseEventType.MouseMove.ToString("f"),
                e.Button.ToString(),
                e.X.ToString(),
                e.Y.ToString(),
                ""
                );
        }

        void mouseHook_Click(object sender, MouseEventArgs e)
        {
            AddMouseEvent(
                MouseHook.MouseEventType.Click.ToString("f"),
                e.Button.ToString(),
                e.X.ToString(),
                e.Y.ToString(),
                ""
                );
        }

        void mouseHook_DoubleClick(object sender, MouseEventArgs e)
        {
            AddMouseEvent(
                MouseHook.MouseEventType.DoubleClick.ToString("f"),
                e.Button.ToString(),
                e.X.ToString(),
                e.Y.ToString(),
                ""
                );
        }


        void AddMouseEvent(string eventType, string button, string x, string y, string delta)
        {
            string str = "";
            if (eventType.Equals(MouseHook.MouseEventType.Click.ToString("f")))
            {
                if (!cbMouseClick.Checked)
                    return;

                //str = "MC," + getCurrentTimeMillis() + "," + button + "," + x + "," + y;
            }
            else if (eventType.Equals(MouseHook.MouseEventType.DoubleClick.ToString("f")))
            {
                if (!cbMouseDoubleClick.Checked)
                    return;

                //str = "MDC," + getCurrentTimeMillis() + "," + button + "," + x + "," + y;
            }
            else if (eventType.Equals(MouseHook.MouseEventType.MouseMove.ToString("f")))
            {
                if (!cbMouseMove.Checked)
                    return;

                //str = "MOV," + getCurrentTimeMillis() + "," + button + "," + x + "," + y;

            }
            else if (eventType.Equals(MouseHook.MouseEventType.MouseDown.ToString("f")))
            {
                if (!cbMouseDown.Checked)
                    return;

                //str = "MD," + getCurrentTimeMillis() + "," + button + "," + x + "," + y;
            }
            else if (eventType.Equals(MouseHook.MouseEventType.MouseUp.ToString("f")))
            {
                if (!cbMouseUp.Checked)
                    return;
               
                //str = "MU," + getCurrentTimeMillis() + "," + button + "," + x + "," + y;

            }
            else if (eventType.Equals(MouseHook.MouseEventType.MouseWheel.ToString("f")))
            {
                if (!cbMouseWheel.Checked)
                    return;

                str = eventType+ "," + getCurrentTimeMillis() + "," + delta;
            }

            if (str.Equals(""))
            {
                str = eventType + "," + getCurrentTimeMillis() + "," + button + "," + x + "," + y;
            }
            displayEventRecord(str);

            object c = findControl(int.Parse(x), int.Parse(y));
            if (c == null)
            {
                lstBox.Items.Add("can not find control from (" + x + "," + y + ")");
            }
            else
            {
                string strFullName = c.GetType().FullName;
                string strObjectName = "";
                string strObjectText = "";
                string location = "";

                //string s = c.GetType().FullName;
                if (c is Control)
                {
                    Control ctl = c as Control;

                    strObjectName = ctl.Name;
                    strObjectText = ctl.Text;
                }
                else 
                {
                    PropertyInfo pi = c.GetType().GetProperty("Name");
                    if (null != pi)
                    {
                        strObjectName = pi.GetValue(c, null).ToString();
                    }

                    pi = c.GetType().GetProperty("Text");
                    if (null != pi)
                    {
                        strObjectText = pi.GetValue(c, null).ToString();
                    }

                    pi = c.GetType().GetProperty("Bounds");
                    if (null != pi)
                    {
                        location = pi.GetValue(c, null).ToString();
                    }
                }

                string s = string.Format("{0}, Name:{1}, Text:{2}", strFullName, strObjectName, strObjectText);

                if (!location.Equals(""))
                {
                    s += location;
                }

                lstBox.Items.Add(s);

                {
                    DataGridViewRow row = new DataGridViewRow();
                    DataGridViewCheckBoxCell cbbCell = new DataGridViewCheckBoxCell();
                    cbbCell.Value = true;
                    row.Cells.Add(cbbCell);

                    DataGridViewTextBoxCell tbOpCell = new DataGridViewTextBoxCell();
                    tbOpCell.Value = eventType;
                    row.Cells.Add(tbOpCell);

                    DataGridViewTextBoxCell tbNameCell = new DataGridViewTextBoxCell();
                    tbNameCell.Value = strObjectName;
                    row.Cells.Add(tbNameCell);

                    DataGridViewTextBoxCell tbTextCell = new DataGridViewTextBoxCell();
                    tbTextCell.Value = strObjectText;
                    row.Cells.Add(tbTextCell);

                    DataGridViewTextBoxCell tbClassCell = new DataGridViewTextBoxCell();
                    tbClassCell.Value = strFullName;
                    row.Cells.Add(tbClassCell);

                    dataGrid.Rows.Add(row);
                }                
            }
            lstBox.SelectedIndex = lstBox.Items.Count - 1;
        }

        void AddKeyboardEvent(string eventType, string keyCode, string keyChar, string shift, string alt, string control)
        {

            string str = "" + getCurrentTimeMillis() + "," + "keyData:" + keyChar + ",keyCode:" + keyCode;

            if (eventType.Equals("KeyDown"))
            {
                if (!cbKeyDown.Checked)
                    return;

                str = "KD," + str;
            }
            else if (eventType.Equals("KeyUp"))
            {

                if (!cbKeyUp.Checked)
                    return;

                str = "KU," + str;
            }
            else if (eventType.Equals("KeyPress"))
            {
                if (!cbKeyPress.Checked)
                    return;

                str = "KP," + str;
            }
            else
            {
                return;
            }
            displayEventRecord(str);
        }

        long getCurrentTimeMillis()
        {
            return DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
        }

        void displayEventRecord(string s)
        {
            lstBox.Items.Add(s);
            lstBox.SelectedIndex = lstBox.Items.Count - 1;
        }

        private void btRecord_Click(object sender, EventArgs e)
        {
            if (_recording)
            {
                mouseHook.Stop();
                keyboardHook.Stop();

                btRecord.Text = "开始";
                btPlay.Enabled = true;
                btConfig.Enabled = true;
                btClear.Enabled = true;
            }
            else
            {
                mouseHook.Start();
                keyboardHook.Start();

                btRecord.Text = "停止";
                btPlay.Enabled = false;
                btConfig.Enabled = false;
                btClear.Enabled = false;
                NativeUtils.SetForegroundWindow(spywindow);
            }
            _recording = !_recording;
        }

        private object findControl(int x, int y)
        {
            //Point newPoint = this.PointToScreen(new Point(x, y));
            //POINT windowPoint = POINT.FromPoint(newPoint);
            POINT windowPoint = new POINT(x ,y);
            IntPtr found = NativeUtils.WindowFromPoint(windowPoint);

            // we have a valid window handle
            if (found != IntPtr.Zero)
            {
                // give it another try, it might be a child window (disabled, hidden .. something else)
                // offset the point to be a client point of the active window
                if (NativeUtils.ScreenToClient(found, ref windowPoint))
                {
                    // check if there is some hidden/disabled child window at this point
                    IntPtr childWindow = NativeUtils.ChildWindowFromPoint(found, windowPoint);
                    if (childWindow != IntPtr.Zero)
                    { // great, we have the inner child
                        found = childWindow;
                    }
                }

                object c = Control.FromHandle(found);

                /*if (c is MenuStrip)//MenuStrip继承自ToolStrip
                {
                    MenuStrip m = c as MenuStrip;
                    c = m.GetItemAt(windowPoint.ToPoint());
                }
                else*/ if (c is ToolStripDropDownMenu)
                {
                    ToolStripDropDownMenu m = c as ToolStripDropDownMenu;
                    c = m.GetItemAt(windowPoint.ToPoint());
                }
                else if (c is ToolStrip)
                {
                    ToolStrip m = c as ToolStrip;
                    c = m.GetItemAt(windowPoint.ToPoint());
                }

                return c;
            }
            else 
            {
                return null;
            }
        }

        private object searchControl(Control fathercontrol, Dictionary<string, string> d)
        {
            foreach (Control c in fathercontrol.Controls)
            {
                if (d["FullName"] == c.GetType().FullName
                    && d["Name"] == c.Name
                    && d["Text"] == c.Text)
                {
                    return c;
                }
                else if (c is ToolStrip)
                {
                    foreach (ToolStripItem item in (c as ToolStrip).Items)
                    {
                        object ob = searchItem(item, d);

                        if (ob != null)
                        {
                            return ob;
                        }

                    }
                }
                else
                {
                    object ob = searchControl(c, d);

                    if (ob != null)
                    {
                        return ob;
                    }
                }
            }
            return null;
        }

        private object searchItem(ToolStripItem item, Dictionary<string, string> d)
        {
            if (d["FullName"] == item.GetType().FullName
                 && d["Name"] == item.Name
                 && d["Text"] == item.Text)
            {
                return item;
            }
            else if (item is ToolStripDropDownItem)
            {
                foreach (ToolStripItem it in (item as ToolStripDropDownItem).DropDownItems)
                {
                    object ob = searchItem(it, d);

                    if (ob != null)
                    {
                        return ob;
                    }
                }
            }
            return null;
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            lstBox.Items.Clear();
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGrid.Rows.Count - 1 <= e.RowIndex//自动添加的一行
                || dataGrid.ColumnCount <= e.ColumnIndex)
            {
                return;
            }

            DataGridViewCheckBoxCell c = dataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewCheckBoxCell;

            if (null != c)
            {
                c.Value = !(Boolean)c.Value;
            }
        }

        private void btPlay_Click(object sender, EventArgs e)
        {
            if (btPlay.Enabled)
            {
                Thread t = new Thread(new ThreadStart(this.playOperation));
                t.Start();
            }
        }

        private void playOperation()
        {
            btRecord.Enabled = false;
            btClear.Enabled = false;
            btConfig.Enabled = false;
            btPlay.Enabled = false;

            NativeUtils.SetForegroundWindow(spywindow);

            _currentPoint = Cursor.Position;

            Dictionary<string, string> dict = new Dictionary<string, string>();
            //Rectangle rect = new Rectangle();
            foreach (DataGridViewRow r in dataGrid.Rows)
            {
                if (Convert.ToBoolean(r.Cells[0].Value))
                {
                    r.Selected = true;
                    string strOpName = r.Cells[1].Value.ToString();
                    string strObName = r.Cells[2].Value.ToString();
                    string strObText = r.Cells[3].Value.ToString();
                    string strClass = r.Cells[4].Value.ToString();

                    dict["FullName"] = strClass;
                    dict["Name"] = strObName;
                    dict["Text"] = strObText;

                    //IntPtr h = locateControl(Control.FromHandle(spywindow), dict, ref rect);

                    object ob = searchControl(Control.FromChildHandle(spywindow), dict);

                    if (ob != null)
                    {
                        IntPtr h = new IntPtr();
                        Rectangle rect = new Rectangle();
                        if (ob is Control)
                        {
                            h = (ob as Control).Handle;
                            rect = (ob as Control).Bounds;
                        }
                        else if (ob is ToolStripItem)
                        {
                            h = (ob as ToolStripItem).Owner.Handle;
                            rect = (ob as ToolStripItem).Bounds;
                        }
                        else 
                        {
                            lstBox.Items.Add("Unsupported type:" + strClass);
                            continue;
                        }

                        playOperation(h, rect, strOpName);
                    }
                    else
                    {
                        lstBox.Items.Add(string.Format("Cannot find {0}:Name:{1}, Text:{2}", strClass, strObName, strObText));
                    }
                }
            }

            btRecord.Enabled = true;
            btClear.Enabled = true;
            btConfig.Enabled = true;
            btPlay.Enabled = true;
        }

        private bool locateItem(ToolStripItem it, Dictionary<string, string> d, ref Rectangle rect, ref IntPtr h)
        {
            if (it is ToolStripMenuItem)
            {
                ToolStripMenuItem item = it as ToolStripMenuItem;

                if (d["FullName"] == item.GetType().FullName
                && d["Name"] == item.Name
                && d["Text"] == item.Text)
                {
                    rect = item.DropDown.Bounds;
                    h = item.DropDown.Handle;    
                    return true;
                }

                foreach (ToolStripItem i in item.DropDownItems)
                {
                    if (locateItem(i, d, ref rect, ref h))
                    {
                        if (h == IntPtr.Zero)
                        {
                            h = item.DropDown.Handle;
                        }
                        return true;
                    }
                }
            }
            else
            {
                if (d["FullName"] == it.GetType().FullName
                && d["Name"] == it.Name
                && d["Text"] == it.Text)
                {
                    rect = it.Bounds;
                    //h = item.DropDown.Handle;//handle由上级决定
                    return true;
                }
            }
            return false;
        }

        private IntPtr locateControl(Control ctl, Dictionary<string, string> d, ref Rectangle rect)
        {
            if (ctl is MenuStrip)
            {
                MenuStrip m = ctl as MenuStrip;
                IntPtr h = new IntPtr();

                foreach (ToolStripItem i in m.Items)
                {
                    if (locateItem(i, d, ref rect, ref h))
                    {
                        if (h == IntPtr.Zero)
                        {
                            h = m.Handle;
                        }
                        return h;
                    }
                }

            }
            else if (ctl is ToolStrip)
            {
                ToolStrip m = ctl as ToolStrip;
                IntPtr h = new IntPtr();

                foreach (ToolStripItem i in m.Items)
                {
                    if (locateItem(i, d, ref rect, ref h))
                    {
                        if (h == IntPtr.Zero)
                        {
                            h = m.Handle;
                        }
                        return h;
                    }
                }
            }
            else
            {
                if (d["FullName"] == ctl.GetType().FullName
                    && d["Name"] == ctl.Name
                    && d["Text"] == ctl.Text)
                {
                    rect = ctl.Bounds;
                    return ctl.Handle;
                }

                foreach (Control c in ctl.Controls)
                {
                    IntPtr h = locateControl(c, d, ref rect);
                    if (h != IntPtr.Zero)
                    {
                        return h;
                    }
                }  

            }
            return IntPtr.Zero;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new ShowControls();
            f.Show();
        }

        private void btClearOps_Click(object sender, EventArgs e)
        {
            dataGrid.Rows.Clear();
        }

        private void playOperation(IntPtr h, Rectangle rect, string op)
        {
            Point p = NativeUtils.NativeClientToScreen(h, rect.Location);
            rect.Location = p;
            
            //从左上角调整到控件中心
            p.X += rect.Width / 2;
            p.Y += rect.Height / 2;

            string s = op + ":" + h.ToString() + rect.ToString();
            lstBox.Items.Add(s);
            lstBox.SelectedIndex = lstBox.Items.Count - 1;

            //画这次的线和框
            drawLine(_currentPoint, p);

            drawRectangle(rect);

            MouseSimulator.Position = p;
            System.Threading.Thread.Sleep(1000);
            MouseSimulator.Click(MouseButton.Left);

            System.Threading.Thread.Sleep(1000);

            //消除这次画的线和框

            drawLine(_currentPoint, p);

            drawRectangle(rect);
            System.Threading.Thread.Sleep(1000);

            _currentPoint = p;
        }

        private void drawLine(Point from, Point to)
        {
            ControlPaint.DrawReversibleLine(from, to, Color.FromArgb(0, 255, 255));
        }

        private void drawRectangle(Rectangle rect)
        {
            ControlPaint.DrawReversibleFrame(rect, Color.FromArgb(0, 255, 255), FrameStyle.Thick);
        }
    }
}