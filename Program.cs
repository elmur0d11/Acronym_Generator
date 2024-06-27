
try
{
    //get inout from user
    Console.WriteLine("Please enter a phrase to convert to an acronym: ");
    String input = Console.ReadLine();

    //Optional exclusions
    String exclusions = input.Replace("and", "");
    string[] wordArr = exclusions.Split(' ');
    Console.WriteLine(wordArr.Length);

    //Loop through sentence
    string acronym = "";
    for(int i = 0; i < wordArr.Length; i++)
    {
        if (wordArr[i] != "")
        {
            acronym += wordArr[i][0];
        }
    }
    acronym = acronym.ToUpper();
    Console.WriteLine("Your acronym is: " + acronym);
}
catch(Exception e)
{
    Console.WriteLine(e.ToString());
}