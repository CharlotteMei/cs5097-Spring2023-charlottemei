using System;

public class Program
{
    public static void Main()
    {
        // create arrays & collection
        int[] ids = new int[5];
        int[] prices = new int[] {5, 7, 16, 10, 12};
        String[] names = "happyLemon,heyTea,chaYan,guMin,naiXue".Split(',');
        
        

        // for loop
        for (int i = 0; i < ids.Length; i++)
        {
            Console.WriteLine(i);
        }
    }
}