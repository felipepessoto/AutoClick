using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AutoClick
{
    /// <summary>
    /// Summary description for TestSendKeys.
    /// </summary>
    public class TestSendKeys
    {
        public TestSendKeys()
        {
            //
            // TODO: Add constructor logic here
            //
        }


        public const int INPUT_KEYBOARD = 1;
        public const int KEYEVENTF_KEYUP = 0x0002;

        public struct KEYDBINPUT
        {
            public short wVk;
            public short wScan;
            public int dwFlags;
            public int time;
            public int dwExtraInfo;
            public int __filler1;
            public int __filler2;
        }

        public struct INPUT
        {
            public int type;
            public KEYDBINPUT ki;
        }

        [DllImport("user32")]
        public static extern int SendInput(int cInputs, ref INPUT pInputs, int cbSize);

        public void HoldKey(Keys vk)
        {
            INPUT input = new INPUT();
            input.type = INPUT_KEYBOARD;
            input.ki.dwFlags = 0;
            input.ki.wVk = (short)vk;
            SendInput(1, ref input, Marshal.SizeOf(input));
        }

        public void ReleaseKey(Keys vk)
        {
            INPUT input = new INPUT();
            input.type = INPUT_KEYBOARD;
            input.ki.dwFlags = KEYEVENTF_KEYUP;
            input.ki.wVk = (short)vk;
            SendInput(1, ref input, Marshal.SizeOf(input));
        }

        public void PressKey(Keys vk)
        {
            HoldKey(vk);
            ReleaseKey(vk);
        }

        private void button2_Click(object sender, System.EventArgs e)
        {

            HoldKey(Keys.RControlKey);
            PressKey(Keys.End);
            ReleaseKey(Keys.RControlKey);
        }
    }
}