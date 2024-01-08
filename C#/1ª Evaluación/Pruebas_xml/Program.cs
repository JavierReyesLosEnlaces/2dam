
using System.Xml;
using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        //1. Acceso al fichero xml y lo muestra por consola
        /*        
        XmlDocument Xdoc = new XmlDocument();
        Xdoc.Load("C:\\Users\\Alumno\\Desktop\\2dam\\C#\\Pruebas_xml\\directorio_xml\\fichero.xml");
        Xdoc.Save(Console.Out);
        */

        //2. Acceso de otra manera
        XmlTextReader xtr = new XmlTextReader("C:\\Users\\Alumno\\Desktop\\2dam\\C#\\Pruebas_xml\\directorio_xml\\fichero.xml");

        // Similar a la manera que se emplea en Java, un objeto reader que permite recorrer

        while (xtr.Read())
        {
            if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "title")
            {
                string s1 = xtr.ReadElementString();
                Console.Write("TITLE: " + s1);
            }
            if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "author")
            {
                string s1 = xtr.ReadElementString();
                Console.Write(", AUTHOR: " + s1 + "\n");
            }

        }

    }
}
