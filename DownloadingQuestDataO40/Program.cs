using System;
					
public class Program
{
	public static async Task Main()
	{
        string quest = await DownloadQuest(); 

        //I learned trying to call Task DonwloadQuest 
        // right here is like declaring a string that
        // already has the word string on 
        // it earlier in the code
        Console.WriteLine($"New Quest: {quest}");
    }

    static async Task<string> DownloadQuest()
    {
        Console.WriteLine("Downloading quest data");
        await Task.Delay(4600);
        Console.WriteLine("Quest downloaded in 4.6 seconds");
        return "Defeat the Ender Dragon";
 
 
    }

}