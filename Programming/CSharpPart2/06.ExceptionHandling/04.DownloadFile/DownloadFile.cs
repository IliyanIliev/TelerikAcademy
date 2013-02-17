using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

class DownloadFile
{
    static void Main(string[] args)
    {
        WebClient webClient = new WebClient();
        using (webClient)
        {
            Console.Write("Please enter URL address: ");
            string URL = Console.ReadLine();
            Console.Write("Please enter file name:(name.jpg): ");
            string file = Console.ReadLine();

            try
            {
                webClient.DownloadFile(URL, file);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("The address can not be null");
            }
            catch (WebException)
            {
                Console.Error.WriteLine("The address is invalid.");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("This method does not support simultaneous downloads.");
            }
        }
    }
}
