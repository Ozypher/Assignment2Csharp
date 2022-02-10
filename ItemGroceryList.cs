using System;

namespace ItemGroceryList
{
    class ItemGroceryList
    {
        static void Main(string[] args)
        {
            String[] GroceryList = new String[30];
            int cursor = 0;
            while (true)
            {
                Console.WriteLine("\nEnter command (+ item, - item, or -- to clear)):");
                String response = Console.ReadLine();
                if (response.StartsWith("+"))
                {
                    GroceryList[cursor] = response.Substring(1, response.Length-1);
                    cursor += 1;
                }
                if (response.StartsWith("-"))
                {
                    for (int i = 0; i < GroceryList.Length; i++)
                    {
                        if (GroceryList[i] == response.Substring(1, response.Length-1))
                        {
                            GroceryList[i] = null;
                        }
                    }
                    cursor -= 1;
                }
                if (response.StartsWith("--"))
                {
                    for (int i = 0; i < GroceryList.Length; i++)
                    {
                        GroceryList[i] = null;
                    }
                    cursor = 0;
                }
                foreach (String item in GroceryList)
                {
                    Console.Write(item + ",");
                }
            }
        }
    }
}
