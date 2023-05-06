
using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите ip адреса через пробел");
        string? ips = Console.ReadLine();
        Regex ipv6Regex = new Regex(@"^((([0-9a-fA-F]{1,4}:){7}[0-9a-fA-F]{1,4})|(([0-9a-fA-F]]{1,4}:){1,7}:)|(([0-9a-fA-F]{1,4}:){1,2}(:[0-9a-fA-F]{1,4}){1,5})|(([0-9a-fA-F]{1,4}:){1,3}(:[0-9a-fA-F]{1,4}){1,4})|(([0-9a-fA-F]{1,4}:){1,4}(:[0-9a-fA-F]{1,4}){1,3})|(([0-9a-fA-F]{1,4}:){1,5}(:[0-9a-fA-F]{1,4}){1,2})|(:(:([0-9a-fA-F]){1,4}){1,7})|(::))$");
        Regex ipv4 = new Regex(@"^(((([01]?[0-9][0-9]?)|(2[0-4][0-9])|(25[0-5]))\.){3}(([01]?[0-9][0-9]?)|(2[0-4][0-9])|(25[0-5])))$");

        bool wasMatch = false;

        foreach (string item in ips.Split(" "))
        {
            if (ipv4.IsMatch(item))
            {
                wasMatch = true;
                Console.WriteLine(item + " ipv4 адрес");
            }
            if(ipv6Regex.IsMatch(item))
            {
                wasMatch = true;
                Console.WriteLine(item+ " ipv6 адрес");
            }
        }
        if (!wasMatch) Console.WriteLine("Нет корректного ip адреса");
    }
}