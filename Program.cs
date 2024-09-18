
var pathDesktop = "C:\\Users\\DELL\\Desktop";

string from = "";
string to;
string readedInfo;

var allElements = Directory.GetFileSystemEntries(pathDesktop);

for (int i = 0; i < allElements.Length; i++)
{
    Console.WriteLine($"{i+1}.{allElements[i]}");
}

Console.Write("Enter your choice : ");
int choice = int.Parse( Console.ReadLine()!);

for (int i = 0; i < allElements.Length; i++)
{
    if(i + 1 == choice)
    {
        if (Directory.Exists(allElements[i]))
        {
           var elements =  Directory.GetFiles(Path.GetFullPath(allElements[i]));

            Console.Clear();

            for (int j = 0; j < elements.Length; j++)
            {
                Console.WriteLine($"{j + 1}.{elements[j]}");
            }

            Console.Write("Enter your choice : ");
            int choice3 = int.Parse(Console.ReadLine()!);

            for (int j = 0; j < elements.Length; j++)
            {
                if(j + 1 == choice3)
                {
                    from = Path.GetFullPath(elements[j]);
                }
            }

            readedInfo = File.ReadAllText(from);

            var files = Directory.GetFiles(pathDesktop);

            Console.Clear();

            for (int j = 0; j < files.Length; j++)
            {
                Console.WriteLine($"{j + 1}.{files[j]}");
            }

            Console.Write("Enter your choice : ");
            int choice2 = int.Parse(Console.ReadLine()!);

            Console.Clear();

            for (int k = 0; k < files.Length; k++)
            {
                if (k + 1 == choice2)
                {
                    to = Path.GetFullPath(files[k]);

                    File.WriteAllText(to, readedInfo);

                    Console.Clear();

                    Console.WriteLine("data copied successfully");

                    Thread.Sleep(2000);
                }
            }

        }
        else if (File.Exists(allElements[i])) 
        {
            from = Path.GetFullPath(allElements[i]);

            readedInfo = File.ReadAllText(from);

            var files = Directory.GetFiles(pathDesktop);

            Console.Clear();

            for (int j = 0; j < files.Length; j++)
            {
                Console.WriteLine($"{j + 1}.{files[j]}");
            }

            Console.Write("Enter your choice : ");
            int choice2 = int.Parse( Console.ReadLine()!);

            Console.Clear();
            for (int k = 0; k <files.Length; k++)
            {
                if (k + 1 == choice2) 
                {
                    to = Path.GetFullPath (files[k]);

                    File.WriteAllText(to,readedInfo);

                    Console.Clear() ;

                    Console.WriteLine("data copied successfully");

                    Thread.Sleep(2000);    
                }
            }

        }

    }
}