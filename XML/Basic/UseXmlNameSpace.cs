using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XML
{
    public class UseXmlNameSpace
    {
        public static void Create()
        {
            XNamespace ns1 = "Name sapce one";
            XNamespace ns2 = "Name sapce two";
            XElement root = new XElement(ns1 + "Root",
                new XElement(ns2 + "Childs",
                new XElement("child", 1),
                new XElement("child", 2)));
            new XDocument(root).Save("namespace.xml");
            Process.Start("namespace.xml");
            Console.WriteLine(root);
            Process.Start("namespace.xml");

            Console.WriteLine("=====After set prefixes of namesapce =======");
            // control prefixes
            XDocument xDoc = XDocument.Load("namespace.xml");
            xDoc.Root.SetAttributeValue(XNamespace.Xmlns + "ns1_prefix", ns1);
            xDoc.Root.SetAttributeValue(XNamespace.Xmlns + "ns2_prefix", ns2);
            xDoc.Save("namespace.xml");
            Console.WriteLine(xDoc);

            Process.Start("namespace.xml");
        }

        public static void FindNodeWithNameSpace()
        {
        }

    }
}
