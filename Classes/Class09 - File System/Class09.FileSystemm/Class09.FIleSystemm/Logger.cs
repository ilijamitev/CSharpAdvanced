namespace Class09.FIleSystemm
{
    internal class Logger
    {
        internal static void Log(int first, int second, Operation op, int result)
        {
            var message = $"{DateTime.Now.ToLongTimeString()}: {first} {op} {second} = {result}";
            Console.WriteLine(Directory.GetCurrentDirectory());
            //"C:\Users\Tijana i Ilija\Desktop\Seavus\VTOR SEMESTAR\CSharpAdvanced\Classes\Class09 - File System\Class09.FileSystemm\Class09.FIleSystemm\bin\Debug\net6.0"
            File.AppendAllLines(@"..\..\..\log.txt", new string[] { message });
            Console.WriteLine("TEXT WRITTEN IN TEXT FILE");
        }
    }
}