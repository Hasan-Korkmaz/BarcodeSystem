using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketBarkod.GlobalComponent.CustomFont
{
    class TitiliumFastFont
    {
        private static TitiliumFastFont Instance;
        private string fontpath = Application.StartupPath + "..\\..\\..\\GlobalComponent\\CustomFont\\";
        private float fontSize = 12;
        private System.Drawing.Color fontColor;


        private TitiliumFastFont() {/*Erişilemez Yapıcı Method*/ }
        public static TitiliumFastFont getInstance
        {/*Singleton Design Pattern*/
            get
            {

                if (Instance == null)
                {
                    Instance = new TitiliumFastFont();
                    return Instance;
                }
                return Instance;
            }
        }


        public float FontSize
        {
            get { return fontSize; }
            set
            {
                fontSize = value;
            }
        }
        public System.Drawing.Color Color
        {
            get { return fontColor; }
            set
            {
                fontColor = value;
            }
        }
        public Font TitiliumWebRegular
        {
            get
            {
                BaseFont customfont = BaseFont.CreateFont(fontpath + "TitilliumWeb-Regular.ttf", "Cp1254", BaseFont.EMBEDDED);
                Font font = new Font(customfont, fontSize, Font.NORMAL, new BaseColor(fontColor));
                return font;
            }

        }
        public Font TitiliumWebSemiBold
        {
            get
            {
                BaseFont customfont = BaseFont.CreateFont(fontpath + "TitilliumWeb-SemiBold.ttf", "Cp1254", BaseFont.EMBEDDED);
                Font font = new Font(customfont, fontSize, Font.ITALIC, new BaseColor(fontColor));
                return font;
            }

        }
        public Font TitiliumWebLight
        {
            get
            {
                BaseFont customfont = BaseFont.CreateFont(fontpath + "TitilliumWeb-Light.ttf", "Cp1254", BaseFont.EMBEDDED);
                Font font = new Font(customfont, fontSize, Font.NORMAL, new BaseColor(fontColor));
                return font;
            }

        }
        public Font TitiliumWebBold
        {
            get
            {
                BaseFont customfont = BaseFont.CreateFont(fontpath + "TitilliumWeb-Bold.ttf", "Cp1254", BaseFont.EMBEDDED);
                Font font = new Font(customfont, fontSize, Font.ITALIC, new BaseColor(fontColor));
                return font;
            }

        }
    }
}
