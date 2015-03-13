namespace Starter1
{
    partial class Recorder
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.saveit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.op = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.文本 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playState = new System.Windows.Forms.DataGridViewImageColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lstBox = new System.Windows.Forms.ListBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btClear = new System.Windows.Forms.Button();
            this.btRecord = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btClearOps = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btConfig = new System.Windows.Forms.Button();
            this.btPlay = new System.Windows.Forms.Button();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbMouseDoubleClick = new System.Windows.Forms.CheckBox();
            this.cbMouseClick = new System.Windows.Forms.CheckBox();
            this.cbMouseMove = new System.Windows.Forms.CheckBox();
            this.cbMouseWheel = new System.Windows.Forms.CheckBox();
            this.cbMouseDown = new System.Windows.Forms.CheckBox();
            this.cbMouseUp = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbKeyPress = new System.Windows.Forms.CheckBox();
            this.cbKeyUp = new System.Windows.Forms.CheckBox();
            this.cbKeyDown = new System.Windows.Forms.CheckBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.saveit,
            this.op,
            this.oname,
            this.文本,
            this.cname,
            this.playState});
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid.Location = new System.Drawing.Point(3, 3);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowTemplate.Height = 23;
            this.dataGrid.Size = new System.Drawing.Size(588, 281);
            this.dataGrid.TabIndex = 0;
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentClick);
            // 
            // saveit
            // 
            this.saveit.FalseValue = "";
            this.saveit.HeaderText = "";
            this.saveit.MinimumWidth = 20;
            this.saveit.Name = "saveit";
            this.saveit.ReadOnly = true;
            this.saveit.Width = 20;
            // 
            // op
            // 
            this.op.HeaderText = "操作";
            this.op.Name = "op";
            this.op.ReadOnly = true;
            // 
            // oname
            // 
            this.oname.HeaderText = "对象名";
            this.oname.Name = "oname";
            this.oname.ReadOnly = true;
            // 
            // 文本
            // 
            this.文本.HeaderText = "文本";
            this.文本.Name = "文本";
            this.文本.ReadOnly = true;
            // 
            // cname
            // 
            this.cname.HeaderText = "类名";
            this.cname.Name = "cname";
            this.cname.ReadOnly = true;
            this.cname.Width = 300;
            // 
            // playState
            // 
            this.playState.HeaderText = "";
            this.playState.Name = "playState";
            this.playState.ReadOnly = true;
            this.playState.Width = 20;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.48148F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.51852F));
            this.tableLayoutPanel1.Controls.Add(this.dataGrid, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lstBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer3, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-1, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.42857F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.57143F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(729, 560);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lstBox
            // 
            this.lstBox.FormattingEnabled = true;
            this.lstBox.HorizontalScrollbar = true;
            this.lstBox.ItemHeight = 12;
            this.lstBox.Location = new System.Drawing.Point(3, 290);
            this.lstBox.Name = "lstBox";
            this.lstBox.Size = new System.Drawing.Size(588, 256);
            this.lstBox.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(597, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btClear);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.btConfig);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Size = new System.Drawing.Size(129, 281);
            this.splitContainer1.SplitterDistance = 86;
            this.splitContainer1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btClearOps);
            this.groupBox1.Controls.Add(this.btRecord);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(129, 87);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "录制";
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(24, 76);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(75, 23);
            this.btClear.TabIndex = 1;
            this.btClear.Text = "清除日志";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btRecord
            // 
            this.btRecord.Location = new System.Drawing.Point(24, 20);
            this.btRecord.Name = "btRecord";
            this.btRecord.Size = new System.Drawing.Size(75, 23);
            this.btRecord.TabIndex = 0;
            this.btRecord.Text = "button1";
            this.btRecord.UseVisualStyleBackColor = true;
            this.btRecord.Click += new System.EventHandler(this.btRecord_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btPlay);
            this.groupBox2.Location = new System.Drawing.Point(0, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(129, 57);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "播放";
            // 
            // btClearOps
            // 
            this.btClearOps.Location = new System.Drawing.Point(24, 58);
            this.btClearOps.Name = "btClearOps";
            this.btClearOps.Size = new System.Drawing.Size(75, 23);
            this.btClearOps.TabIndex = 3;
            this.btClearOps.Text = "清除操作";
            this.btClearOps.UseVisualStyleBackColor = true;
            this.btClearOps.Click += new System.EventHandler(this.btClearOps_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "查看控件";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btConfig
            // 
            this.btConfig.Location = new System.Drawing.Point(24, 155);
            this.btConfig.Name = "btConfig";
            this.btConfig.Size = new System.Drawing.Size(75, 23);
            this.btConfig.TabIndex = 1;
            this.btConfig.Text = "选项...";
            this.btConfig.UseVisualStyleBackColor = true;
            // 
            // btPlay
            // 
            this.btPlay.Location = new System.Drawing.Point(24, 20);
            this.btPlay.Name = "btPlay";
            this.btPlay.Size = new System.Drawing.Size(75, 23);
            this.btPlay.TabIndex = 0;
            this.btPlay.Text = "button1";
            this.btPlay.UseVisualStyleBackColor = true;
            this.btPlay.Click += new System.EventHandler(this.btPlay_Click);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(597, 290);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.groupBox3);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.groupBox4);
            this.splitContainer3.Size = new System.Drawing.Size(129, 267);
            this.splitContainer3.SplitterDistance = 162;
            this.splitContainer3.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbMouseDoubleClick);
            this.groupBox3.Controls.Add(this.cbMouseClick);
            this.groupBox3.Controls.Add(this.cbMouseMove);
            this.groupBox3.Controls.Add(this.cbMouseWheel);
            this.groupBox3.Controls.Add(this.cbMouseDown);
            this.groupBox3.Controls.Add(this.cbMouseUp);
            this.groupBox3.Location = new System.Drawing.Point(0, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(129, 156);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "鼠标事件过滤";
            // 
            // cbMouseDoubleClick
            // 
            this.cbMouseDoubleClick.AutoSize = true;
            this.cbMouseDoubleClick.Checked = true;
            this.cbMouseDoubleClick.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMouseDoubleClick.Location = new System.Drawing.Point(7, 133);
            this.cbMouseDoubleClick.Name = "cbMouseDoubleClick";
            this.cbMouseDoubleClick.Size = new System.Drawing.Size(72, 16);
            this.cbMouseDoubleClick.TabIndex = 6;
            this.cbMouseDoubleClick.Text = "鼠标双击";
            this.cbMouseDoubleClick.UseVisualStyleBackColor = true;
            // 
            // cbMouseClick
            // 
            this.cbMouseClick.AutoSize = true;
            this.cbMouseClick.Checked = true;
            this.cbMouseClick.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMouseClick.Location = new System.Drawing.Point(7, 110);
            this.cbMouseClick.Name = "cbMouseClick";
            this.cbMouseClick.Size = new System.Drawing.Size(72, 16);
            this.cbMouseClick.TabIndex = 5;
            this.cbMouseClick.Text = "鼠标单击";
            this.cbMouseClick.UseVisualStyleBackColor = true;
            // 
            // cbMouseMove
            // 
            this.cbMouseMove.AutoSize = true;
            this.cbMouseMove.Location = new System.Drawing.Point(7, 87);
            this.cbMouseMove.Name = "cbMouseMove";
            this.cbMouseMove.Size = new System.Drawing.Size(72, 16);
            this.cbMouseMove.TabIndex = 4;
            this.cbMouseMove.Text = "鼠标移动";
            this.cbMouseMove.UseVisualStyleBackColor = true;
            // 
            // cbMouseWheel
            // 
            this.cbMouseWheel.AutoSize = true;
            this.cbMouseWheel.Location = new System.Drawing.Point(6, 64);
            this.cbMouseWheel.Name = "cbMouseWheel";
            this.cbMouseWheel.Size = new System.Drawing.Size(72, 16);
            this.cbMouseWheel.TabIndex = 3;
            this.cbMouseWheel.Text = "滚轮转动";
            this.cbMouseWheel.UseVisualStyleBackColor = true;
            // 
            // cbMouseDown
            // 
            this.cbMouseDown.AutoSize = true;
            this.cbMouseDown.Location = new System.Drawing.Point(7, 20);
            this.cbMouseDown.Name = "cbMouseDown";
            this.cbMouseDown.Size = new System.Drawing.Size(72, 16);
            this.cbMouseDown.TabIndex = 1;
            this.cbMouseDown.Text = "鼠标按下";
            this.cbMouseDown.UseVisualStyleBackColor = true;
            // 
            // cbMouseUp
            // 
            this.cbMouseUp.AutoSize = true;
            this.cbMouseUp.Location = new System.Drawing.Point(6, 42);
            this.cbMouseUp.Name = "cbMouseUp";
            this.cbMouseUp.Size = new System.Drawing.Size(72, 16);
            this.cbMouseUp.TabIndex = 2;
            this.cbMouseUp.Text = "鼠标弹起";
            this.cbMouseUp.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbKeyPress);
            this.groupBox4.Controls.Add(this.cbKeyUp);
            this.groupBox4.Controls.Add(this.cbKeyDown);
            this.groupBox4.Location = new System.Drawing.Point(0, -1);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(129, 102);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "键盘事件过滤";
            // 
            // cbKeyPress
            // 
            this.cbKeyPress.AutoSize = true;
            this.cbKeyPress.Checked = true;
            this.cbKeyPress.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbKeyPress.Location = new System.Drawing.Point(7, 67);
            this.cbKeyPress.Name = "cbKeyPress";
            this.cbKeyPress.Size = new System.Drawing.Size(48, 16);
            this.cbKeyPress.TabIndex = 2;
            this.cbKeyPress.Text = "按键";
            this.cbKeyPress.UseVisualStyleBackColor = true;
            // 
            // cbKeyUp
            // 
            this.cbKeyUp.AutoSize = true;
            this.cbKeyUp.Location = new System.Drawing.Point(7, 44);
            this.cbKeyUp.Name = "cbKeyUp";
            this.cbKeyUp.Size = new System.Drawing.Size(72, 16);
            this.cbKeyUp.TabIndex = 1;
            this.cbKeyUp.Text = "键盘弹起";
            this.cbKeyUp.UseVisualStyleBackColor = true;
            // 
            // cbKeyDown
            // 
            this.cbKeyDown.AutoSize = true;
            this.cbKeyDown.Location = new System.Drawing.Point(7, 21);
            this.cbKeyDown.Name = "cbKeyDown";
            this.cbKeyDown.Size = new System.Drawing.Size(72, 16);
            this.cbKeyDown.TabIndex = 0;
            this.cbKeyDown.Text = "键盘按下";
            this.cbKeyDown.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Location = new System.Drawing.Point(369, 566);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Size = new System.Drawing.Size(150, 100);
            this.splitContainer2.TabIndex = 2;
            // 
            // Recorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 561);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Recorder";
            this.Text = "Recorder";
            this.Load += new System.EventHandler(this.Recorder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox lstBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btRecord;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btPlay;
        private System.Windows.Forms.Button btConfig;
        private System.Windows.Forms.CheckBox cbMouseWheel;
        private System.Windows.Forms.CheckBox cbMouseUp;
        private System.Windows.Forms.CheckBox cbMouseDown;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cbMouseMove;
        private System.Windows.Forms.CheckBox cbMouseDoubleClick;
        private System.Windows.Forms.CheckBox cbMouseClick;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.CheckBox cbKeyPress;
        private System.Windows.Forms.CheckBox cbKeyUp;
        private System.Windows.Forms.CheckBox cbKeyDown;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.DataGridViewCheckBoxColumn saveit;
        private System.Windows.Forms.DataGridViewTextBoxColumn op;
        private System.Windows.Forms.DataGridViewTextBoxColumn oname;
        private System.Windows.Forms.DataGridViewTextBoxColumn 文本;
        private System.Windows.Forms.DataGridViewTextBoxColumn cname;
        private System.Windows.Forms.DataGridViewImageColumn playState;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btClearOps;
        private System.Windows.Forms.SplitContainer splitContainer2;
    }
}