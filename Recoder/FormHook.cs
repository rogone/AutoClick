using System;
using System.Collections.Generic;
using System.Text;
using ACorns.Hawkeye.Core;
using System.Windows.Forms;
using MyHook;

namespace Starter1
{
    class FormHook : HawkeyeHook
    {
        public override void OnInstallHook(byte[] data)
        {
            base.OnInstallHook(data);

            IntPtr originalHawkeyeWindow = (IntPtr)BitConverter.ToInt32(data, 0);
            IntPtr spyWindow = (IntPtr)BitConverter.ToInt32(data, 4);

            Recorder recordform = new Recorder();
            recordform.spywindow = spyWindow;
            recordform.Show();
            recordform.Activate();
            NativeUtils.SetForegroundWindow(spyWindow);

                // close original window
            NativeUtils.SendMessage(originalHawkeyeWindow, NativeUtils.WinMsgOption.WM_CLOSE, IntPtr.Zero, IntPtr.Zero); // close
        }
    }
}
