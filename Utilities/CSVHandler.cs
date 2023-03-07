namespace CSVtoVCF.Utilities
{
    public class CSVHandler
    {
        public string FilePath { get; set; }
        private StreamReader inFile { get; set; }
        public void Handle() {
            inFile = new StreamReader(FilePath);

            string line = inFile.ReadLine();

            while(line != null) {
                string[] temp = line.Split(",");
                

                line = inFile.ReadLine();
            }

            inFile.Close();
        }
    }
}