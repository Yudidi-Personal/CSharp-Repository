using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XML
{
    public class Insert
    {
        public static void BasicInsert(string filePath)
        {
            AddAfterSelf(filePath);
            InsertByAdd(filePath);
            InsertAddBeforeSelf(filePath);
            Console.WriteLine("BasicInsert Done!");
        }

        private static void InsertAddBeforeSelf(string filePath)
        {
            XDocument xDoc = XDocument.Load(filePath);
            XElement firttItem = xDoc.Root.Descendants("part").Where(x => x.Attribute("id").Value.Equals("1")).First().Descendants("item").Where(e => e.Value.Equals("1")).First();
            int value = Int32.Parse(firttItem.Value);
            XElement newItem;
            for (int i = 0; i < 10; i++)
            {
                newItem = new XElement("item",
                    new XAttribute("isAdd", "true"),
                    new XText((++value).ToString())
                );
                firttItem.AddBeforeSelf(newItem);
                firttItem = newItem;
            }
            string xmlName = string.Format("{0}-AddBeforeSelf.xml", Path.GetFileNameWithoutExtension(filePath));
            xDoc.Save(xmlName);
        }

        /// <summary>
        /// 相当于Insert
        /// </summary>
        /// <param name="filePath"></param>
        private static void AddAfterSelf(string filePath)
        {
            XDocument xDoc = XDocument.Load(filePath);
            XElement firttItem = xDoc.Root.Descendants("part").Where(x => x.Attribute("id").Value.Equals("1")).First().Descendants("item").Where(e => e.Value.Equals("1")).First();
            int value = Int32.Parse(firttItem.Value);
            XElement newItem;
            for (int i = 0; i < 10; i++)
            {
                newItem = new XElement("item",
                    new XAttribute("isAdd", "true"),
                    new XText((++value).ToString())
                );
                firttItem.AddAfterSelf(newItem);
                firttItem = newItem;
            }
            string xmlName = string.Format("{0}-AddAfterSelf.xml", Path.GetFileNameWithoutExtension(filePath));
            xDoc.Save(xmlName);
        }

        /// <summary>
        /// 添加子节点
        /// </summary>
        /// <param name="filePath"></param>
        private static void InsertByAdd(string filePath)
        {
            XDocument xDoc = XDocument.Load(filePath);
            XElement firttItem = xDoc.Root.Descendants("part").Where(x => x.Attribute("id").Value.Equals("1")).First().Descendants("item").Where(e => e.Value.Equals("1")).First();
            int value = Int32.Parse(firttItem.Value);
            XElement newItem;
            for (int i = 0; i < 10; i++)
            {
                newItem = new XElement("item",
                    new XAttribute("isAdd", "true"),
                    new XText((++value).ToString())
                );
                firttItem.Add(newItem);
                firttItem = newItem;
            }
            string xmlName = string.Format("{0}-Add.xml", Path.GetFileNameWithoutExtension(filePath));
            xDoc.Save(xmlName);
        }


    }
}
