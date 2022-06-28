using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace NET_INIS4_PR2._2_Z4
{
    public class ViewModel
    {
        public XmlDataProvider XmlData { get; set; }

        public ViewModel()
        {
            XmlData = new XmlDataProvider();
            XmlData.Source = new Uri(@"C:\Users\dudekpob\Desktop\Projekty\zadania4_net2\4\NET-INIS4_PR2._2-Z5-main\NET-INIS4_PR2._2-Z5-main\xml\biding.xml");
            XmlData.XPath = "node";
        }
    }
}
