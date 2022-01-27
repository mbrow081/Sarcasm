using System.Windows;
using System;
using System.Windows.Forms;

public class Program
{
    [STAThread]
    public static void Main(string[] args)
    {
        // Variable Dec
        char[] sarcasmChar;
        string input;
        bool running = true;
        // Get User Input to Format
        Console.WriteLine("Enter Text to be sarcasim-ified (It will automatically be coppied to your clipboard)");
        //Run an infiniate loop
        do{
        input = Console.ReadLine();

        // Change User Input to Character Array to make working with it easier
        sarcasmChar = input.ToCharArray();

        // Flag to track alternating Upper and Lower Casing
        bool change = false;

        //Go through each letter alternating upper and lower case, skip ' '
        for (int i = 0; i < sarcasmChar.Length; i++)
        {
            if (sarcasmChar[i] == ' ')
            {
                // just skip
            }
            else if (change == false)
            {
                sarcasmChar[i] = char.ToLower(sarcasmChar[i]);
                change = true;
            }
            else
            {
                sarcasmChar[i] = char.ToUpper(sarcasmChar[i]);
                change = false;
            }

        }

        string sarcasmString = new string(sarcasmChar);

        Clipboard.SetText(sarcasmString);
        }while(running);
    }
}