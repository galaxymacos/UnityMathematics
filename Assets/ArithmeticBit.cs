using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArithmeticBit : MonoBehaviour
{
    private void Start()
    {
        int a = 10;
        int b = 20;
        Swap(ref a, ref b);
        print($"a = {a}, b = {b}");
    }

    int Add(int a, int b)
    {
        while (b != 0)
        {
            int c = a & b;
            a = a ^ b;
            b = c << 1;
        }

        return a;
    }

    int Subtract(int a, int b)
    {
        while (b != 0) 
        { 
            int borrow = (~a) & b; 
            a = a ^ b; 
            b = borrow << 1; 
        } 
        return a;
    }
    
    int Multiply(int n, int m) 
    {   
        int answer = 0; 
        int count = 0; 
        while (m != 0) 
        { 
            if (m % 2 == 1)               
                answer += n << count; 
            count++; 
            m /= 2; 
        } 
        return answer; 
    } 
    
    int remainder = 0; 
 
    int division(int dividend, int divisor) 
    { 
        int quotient = 1; 
        int neg = 1; 
    
        if ((dividend > 0 && divisor < 0) || (dividend < 0 && divisor > 0)) 
            neg = -1; 
 
        // Convert to positive 
        int tempdividend = Mathf.Abs((dividend < 0) ? -dividend : dividend); 
        int tempdivisor = Mathf.Abs((divisor < 0) ? -divisor : divisor); 
 
        if (tempdivisor == tempdividend) 
        { 
            remainder = 0; 
            return 1 * neg; 
        } 
        else if (tempdividend < tempdivisor) 
        { 
            if (dividend < 0) 
                remainder = tempdividend * neg; 
            else 
                remainder = tempdividend; 
            return 0; 
        } 
    
        while (tempdivisor << 1 <= tempdividend) 
        { 
            tempdivisor = tempdivisor << 1; 
            quotient = quotient << 1; 
        } 
 
        // Call division recursively 
        if (dividend < 0) 
            quotient = quotient * neg + division(-(tempdividend - tempdivisor), divisor); 
        else 
            quotient = quotient * neg + division(tempdividend - tempdivisor, divisor); 
        return quotient; 
    }

    public int FindMax(int x, int y)
    {
        int max = x ^ ((x ^ y) & -((x < y)?1:0));
        return max;
    }

    public int FindMin(int x, int y)
    {
        int min = y ^ ((x ^ y) & -((x < y)?1:0));
        return min;
    }

    public bool SameSign(int x, int y)
    {
        bool haveSameSign = 0 <= (x ^ y);
        return haveSameSign;
    }

    public void Swap(ref int x, ref int y)
    {
        x ^= y;
        y ^= x;
        x ^= y;
    }


    public class Frame
    {
        public int width, height;

        public int getPixel(int x, int y)
        {
            return -1;
        }



        public void SetPixel(int x, int y, int color)
        {
            
        } 
    }
    public void CheckBoundary(Frame frame, Frame screen)
    {
        int widthMask = frame.width - 1;
        int heightMask = frame.height - 1;
 
        for( int x = 0; x < screen.width; x++ )
        {
            for( int y = 0; x < screen.height; y++ )
            {   
                int colour = frame.getPixel( x & widthMask, y & heightMask );
                screen.SetPixel( x, y, colour );
            }
        } 
    }
}
