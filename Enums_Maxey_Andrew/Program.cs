using System.IO;

namespace Enums_Maxey_Andrew
{
    enum Months// makeing a enum list of months
    {
            Jan = 1, // Sets Jan to 1 instead of 0
            Feb, // feb is 2 and so on so fourth
            Mar,
            Apr,
            May,
            Jun,
            Jul,
            Aug,
            Sep,
            Oct,
            Nov,
            Dec
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int myBirthMonth = (int)Months.Dec;
            int myBirthDay = 23;
            int myBirthYear = 1997;
            //makes a new string called birthdate that prints out your day month and year
            string myBirthDate = $"My birthday is on {myBirthMonth}/{myBirthDay}/{myBirthYear}";
            // Makes text file
            File.WriteAllText("myFile.txt", "This is my text file\n");
            Console.WriteLine(File.ReadAllText("myFile.txt"));
            // Adds text to file
            File.AppendAllText("myFile.txt", "WooHoo more text added to file!\n");
            Console.WriteLine(File.ReadAllText("myFile.txt"));

            if (!File.Exists("newFile.txt"))
            {// If not new files exist it copies it and its text
                File.Copy("myFile.txt", "newFile.txt");
            }
            else
            {
                File.Replace("newFile.txt", "myFile.txt", "backupFile.txt");
            }
            //Adds birthdate to all new files
            File.AppendAllText("newFile.txt", myBirthDate);
        }
    }
}