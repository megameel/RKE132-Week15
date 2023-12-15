List<Gift> myGifts = new List<Gift>();
string[] giftsFromFile = GetDataFromFile();

foreach (string line in giftsFromFile)
{
    string[] tempArray = line.Split(new char[] {'/'}, StringSplitOptions.RemoveEmptyEntries);
    Gift newGift = new Gift(tempArray[0], tempArray[1]);
    myGifts.Add(newGift);
}
foreach (Gift giftFromList in myGifts)
{
    Console.WriteLine($" {giftFromList.Name} wants {giftFromList.Present} for Christmas.");
}


static string[] GetDataFromFile()
{
    string filePath = @"C:\data\frozen.txt";
    string[] dataFromFile = File.ReadAllLines(filePath);
    return dataFromFile;
}
class Gift
{
    string name;
    string present;
    
    public Gift(string _name, string _present)
    {
        name = _name;
        present = _present;
    }
    public string Name
    {
        get { return name; }
    }
    public string Present
    {
        get { return present; }
    }
}