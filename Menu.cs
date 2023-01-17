namespace CSVtoVCF
{
    public class Menu
    {
        public void DisplayMenu() {
            System.Console.WriteLine("--- CSV to VCF ---");
            System.Console.WriteLine("1. Convert");
            System.Console.WriteLine("0. Exit");
            System.Console.Write("\nInput choice: ");
        }

        public string Prompt() {
            DisplayMenu();
            return Console.ReadLine();
        }

        public string GetFilePath() {
            System.Console.Write("\nInput CSV File Path: ");
            return Console.ReadLine();
        }
    }
}