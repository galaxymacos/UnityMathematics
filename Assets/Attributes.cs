using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attributes : MonoBehaviour
{
    public static int MAGIC = 16;
    public static int INTELLIGENCE = 8;
    public static int CHARISMA = 4;
    public static int FLY = 2;
    public static int INVISIBLE = 1;

    private void Start()
    { 
        // Initialize
        int attributes = MAGIC | CHARISMA;         // = int attributes = MAGIC + CHARISMA;
        
        // Add a flag
        attributes |= INTELLIGENCE;
        
        // Remove a flag
        attributes &= ~MAGIC;
        
        // To Add multiple flags
        attributes |= (INTELLIGENCE | MAGIC | CHARISMA);
        
        // To Remove Multiple Flags
        attributes &= ~(INTELLIGENCE | MAGIC);
        
        // Bit Masking
        if ((attributes & MAGIC) != 0)
        {
            // We have a match
        }
        
        
        PrintBinary(attributes);
        
        
    }

    private void PrintBinary(int binary)
    {
        List<int> binaryList = new List<int>();
        while (binary > 0)
        {
            int yushu = binary % 2;
            print("loop");
            binaryList.Add(yushu);

            binary = binary / 2;
        }

        string result = "";
        for (int i = binaryList.Count - 1; i >= 0; i--)
        {
            result += binaryList[i].ToString();
        }
        print(result);
        
    }
}
