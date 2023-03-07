using CSVtoVCF;
using CSVtoVCF.Models;
using CSVtoVCF.Utilities;

Menu menu = new Menu();

if(menu.Prompt() == "1") {
    CSVHandler csv = new CSVHandler();
    csv.FilePath = menu.GetFilePath();
    csv.Handle();
} else {

}
