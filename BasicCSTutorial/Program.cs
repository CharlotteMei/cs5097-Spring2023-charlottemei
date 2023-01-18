using System;

public class Program
{
    public static void Main()
    {
        // create arrays & collection
        int[] prices = new int[] {5, 7, 16, 10, 12};
        String[] names = "happyLemon,heyTea,chaYan,guMin,naiXue".Split(',');
        
        

        // for loop
        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine($"[id {i}] the boba tea from {names[i]} is priced at RMB {prices[i]} Yuan");
        }
    }
}