using System.Security.Cryptography.X509Certificates;

namespace NlogFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sum add = new sum();
            add.dosum(4, 6);
            Console.WriteLine("check file");
        }
    }
}