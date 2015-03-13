using System;
using System.Collections.Generic;
using System.Text;
using MyHook;

namespace Starter1
{
    class MyComboBoxItem
    {
        public MyComboBoxItem():this(IntPtr.Zero)
        {
        }

        public MyComboBoxItem(IntPtr h)
        {
            this._handle = h;
        }
         
        private IntPtr _handle;
        public IntPtr Handle
        {
            get { return this._handle; }
            set { this.Handle = value; }
        }

        public override string ToString()
        {
            return string.Format("[0]:{1}<{2}>", (int)NativeUtils.GetProcessForWindow(this.Handle), NativeUtils.GetWindowText(this._handle), NativeUtils.GetClassName(this._handle));
        }
    }
}
