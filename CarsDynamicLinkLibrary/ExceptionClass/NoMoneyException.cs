using System;
using System.Windows.Forms;

namespace CarsDynamicLinkLibrary.ExceptionClass
{
    public class NoMoneyException : Exception
    {
        private readonly string _caption = "No Money";

        public void NoEnoughMoney(string message)
        {
            MessageBox.Show(message, _caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
