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
        public static string xmlFileTemplate = ConfigurationManager.AppSettings["XmlTemplate"];
        public static string newNodeTemplate = ConfigurationManager.AppSettings["NewNodeTemplate"];

        /// <summary>
        /// Create xml by 2 template files.
        /// 1. if the new nodes to be added are certain.
        /// </summary>
        /// <param name="xmlPath"></param>
        public static void CreateXmlWithTemplate(string xmlPath)
        {
            XDocument xDoc = XDocument.Load(xmlFileTemplate);
            XDocument itemDoc = XDocument.Load(newNodeTemplate);
            // replace 
            XElement titleElement = itemDoc.Root.Descendants("title").First();
        }

        public static void CreateXmlByTree()
        {
            XElement xmlTree = new XElement("TreeRoot",
                new XAttribute("attr", "the value"),
                new XText("This is Text"),
                new XElement("Leave", "The body of leave!"));
            XDocument xDoc = new XDocument();
            xDoc.Add(xmlTree);
            xDoc.Save("tree.xml");
            Process.Start("tree.xml");
            //XElement xmlTree2 = new XElement("Root", new XAttribute("attr", "AttrbuteContent"),
            //    new XElement("SubNode",) );
        }

    }
}
