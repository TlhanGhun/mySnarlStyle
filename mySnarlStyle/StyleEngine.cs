using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using libSnarlStyles;

namespace mySnarlStyle
{

    [System.Runtime.InteropServices.ProgId("mySnarlStyle.styleengine")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.AutoDual), System.Runtime.InteropServices.ComSourceInterfaces(typeof(IStyleEngine))]

    public class StyleEngine : IStyleEngine
    {
        #region IStyleEngine Members



        public int CountStyles()
        {
            return 1;
        }

        public IStyleInstance CreateInstance(string StyleName)
        {
            return new StyleInstance();
        }

        public string Date()
        {
            return "2009-07-25";
        }

        public string Description()
        {
            return "This is some descriptive text";
        }

        public int GetConfigWindow(string StyleName)
        {
            throw new NotImplementedException();
        }

        public melon.M_RESULT Initialize()
        {
            return melon.M_RESULT.M_OK;
        }

        public string LastError()
        {
            return "Error";
        }

        public string Name()
        {
            return "mySnarlStyle.styleengine";
        }

        public string Path()
        {
            return System.Reflection.Assembly.GetExecutingAssembly().CodeBase;
        }

        public int Revision()
        {
            return 1;
        }

        void IStyleEngine.StyleAt(int Index, ref style_info Style)
        {
            string pathToIcon = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase) + "\\someImageName.png";
            pathToIcon = pathToIcon.Replace("file:\\", "");
            // we create a windowless one in this example
            Style.Flags = S_STYLE_FLAGS.S_STYLE_IS_WINDOWLESS;
            Style.IconPath = pathToIcon;
            Style.Major = 1;
            Style.Minor = 0;
            Style.Name = "My style";
            Style.Path = System.Reflection.Assembly.GetExecutingAssembly().CodeBase;
            Style.Schemes = "Standard";
            Style.Copyright = "Your anem";
            Style.SupportEmail = "Your.email@example.com";
            Style.URL = "http://example.com/";
            Style.Description = "This my first Snarl style - it just opens a message box";
        }

        public void TidyUp()
        {
           
        }

        public int Version()
        {
            return 39;
        }

        #endregion
         
    }
}
