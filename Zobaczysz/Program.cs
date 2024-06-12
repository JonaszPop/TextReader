namespace zobaczysz;
class Program
{
    static readonly string textfile = @"C:\Users\Popuś\source\repos\PojektProgramista2024\Zobaczysz\Zobaczysz\TextFile1.txt";

    public static void Main(string[] args)
    {
        //napisz funkcję która przyjmie dwa parametry, podzieli je przez siebie i  zwróci wynik
        int x = Function(5,1);
        Console.WriteLine(x);
        CzytajTekst();

    }

    public static int Function(int a, int b)
    {
        try
        {
            int result = a / b;
            return result;
        }
        catch
        {
            Console.WriteLine("nie dzieli się przez 0");
            return 0;
        }
        finally
        {
            Console.WriteLine("Finally some good fucking food");
        }
       
        
    }
    public static void CzytajTekst()
    {       
        try
        {
            string text = "";
            StreamReader streamReader = new StreamReader(textfile);
            text = streamReader.ReadLine();
            while (text != null)
            {
                text = text.Substring(0,3).ToUpper() + text.Substring(3);
                    
                
                if (text.EndsWith(".") || text.EndsWith(",") || text.EndsWith("?") || text.EndsWith("!"))
                {
                    Console.WriteLine(text);
                    
                }
                else
                {
                    Console.WriteLine(text + ".");
                    
                }
                text = streamReader.ReadLine();
            }
            streamReader.Close();
        }
        
        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
       
    }
  
}