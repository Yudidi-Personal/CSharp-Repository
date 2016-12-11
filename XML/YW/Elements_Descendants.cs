using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XML
{
    public class Elements_Descendants
    {
        public static void Elements_Descendants_Diff()
        {
            XElement xe = XElement.Parse(
          @"<foo>
                <sub>content 1</sub>
                <sub>
                  <sub>content 2</sub>
                </sub>
                <sub>content 3</sub>
              </foo>");
            foreach (var sub in xe.Elements("sub"))
            {
                Console.WriteLine("Elements: " + sub.Value);
            }
            Console.WriteLine("=========");
            foreach (var sub in xe.Descendants("sub"))
            {
                Console.WriteLine("Descendants: " + sub.Value);
            }

            Console.WriteLine("=====If sub's father is not a sub, we can see the truth!====");

            ((XElement)(xe.Elements("sub").First().NextNode)).Name = "subsNotSub";

            foreach (var sub in xe.Elements("sub"))
            {
                Console.WriteLine("Elements: " + sub.Value);
            }
            Console.WriteLine("=========");
            foreach (var sub in xe.Descendants("sub"))
            {
                Console.WriteLine("Descendants: " + sub.Value);
            }
        }
    }
}
