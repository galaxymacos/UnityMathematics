using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attributes : MonoBehaviour
{
    public static int MAGIC = 16; // = 1<<4
    public static int INTELLIGENCE = 8;    // = 1<<3
    public static int CHARISMA = 4;    // = 1<<2
    public static int FLY = 2;    // = 1<<1
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
        
        // Bit shifting
        
        // 00001<<1 = 00010

        BitPacking();
        
        // PrintBinary(attributes);

        attributes = BitToggle(attributes);

    }

    private int BitToggle(int attributes)
    {
        attributes ^= MAGIC;
        return attributes;
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

    private void BitPacking()
    {
        string A = "110111";
        string B = "10001";
        string C = "1101";
        int aBits = Convert.ToInt32(A, 2);
        int bBits = Convert.ToInt32(B, 2);
        int cBits = Convert.ToInt32(C, 2);

        int packed = 0;
        packed = packed | (aBits << 26);
        packed = packed | (bBits << 21);
        packed = packed | (cBits<<17);
        
        // bit unpacking
        // A = (X & MaskA) >> 9
        // B = (X & MaskB) >> 4
        // C = (X & MaskC) 

        Debug.Log(Convert.ToString(packed, 2).PadLeft(32,'0'));
    }
}

public class HitRay : MonoBehaviour
{
    private void Start()
    {
        int layerMask = 1 << 10;
        int layerMask2 = 1 << 9;
        layerMask |= layerMask2;
        // Detect the layer 10
        layerMask = ~layerMask;
        // Detect all the layer instead of layer 10

        layerMask = ~layerMask;
    }
}
