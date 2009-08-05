using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using libSnarlStyles;

namespace mySnarlStyle
{
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.AutoDual)]

    public class StyleInstance : IStyleInstance 
    {

        #region IStyleInstance Members

        public void AdjustPosition(ref int x, ref int y, ref short Alpha, ref bool Done)
        {
            
        }

        public melon.MImage GetContent()
        {
            melon.MImage temp = null;
            return temp;
        }

        public bool Pulse()
        {
            return false;
        }

        public void Show(bool Visible)
        {
            
        }

        public void UpdateContent(ref notification_info NotificationInfo)
        {
            System.Windows.Forms.MessageBox.Show(NotificationInfo.Text, NotificationInfo.Title, System.Windows.Forms.MessageBoxButtons.OK);
        }

        #endregion
    }
}
