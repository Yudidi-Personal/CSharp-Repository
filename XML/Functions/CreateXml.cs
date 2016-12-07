using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Configuration;
using System.Xml.Linq;
using System.IO;
using System.Diagnostics;

namespace XML
{
    public class CreateXml
    {
        public static string xmlTemplate = ConfigurationManager.AppSettings["XmlTemplate"];
        public static string newNodeTemplate = ConfigurationManager.AppSettings["NewNodeTemplate"];

        /// <summary>
        /// Create xml by 2 template files.
        /// 1. if the new nodes to be added are certain.
        /// </summary>
        /// <param name="xmlPath"></param>
        public static void CreateXmlWithTemplate(string xmlPath)
        {
            XDocument xDoc = XDocument.Load(xmlTemplate);
            XDocument itemDoc = XDocument.Load(newNodeTemplate);
            // replace 
            XElement titleElement = itemDoc.Root.Descendants("title").First();
        }

        public static void CreateXmlByTree()
        {
            XElement xmlTree = new XElement("Root",
               new XAttribute("Att1", "AttributeContent"),
               new XElement("Child",
                   new XText("Some text"),
                   new XElement("GrandChild", "element content")
               )
            );
            XDocument xDoc = new XDocument(xmlTree);
            xDoc.Save("tmp.xml");
            Process.Start("tmp.xml");
            //XElement xmlTree2 = new XElement("Root", new XAttribute("attr", "AttrbuteContent"),
            //    new XElement("SubNode",) );
        }

    }
}
