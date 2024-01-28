class Program
{
    static void Main(string[] args)
    {
        //lee el contenido de fichero_in.txt y lo mete en fichero_out.txt

        string filePath = @"C:\Users\Alumno\Desktop\directorio_in\fichero_in.txt";
        List<string> lineas = new List<string>();
        lineas = File.ReadAllLines(filePath).ToList();

        foreach(string linea in lineas)
        {
            Console.WriteLine(linea);
        }
    
        lineas.Add("Juan,Toledo,jtnemail.com");


        filePath = @"C:\\Users\Alumno\Desktop\directorio_out\fichero_out.txt";

        try
        {
            File.WriteAllLines(filePath, lineas);
        }
        catch (Exception){}
    }
}