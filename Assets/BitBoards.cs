using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BitBoards : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    long SetCellState(long bitBoard, int row, int col)
    {
        long newBit = 1L << (row * 8 + col);

        return bitBoard |= newBit;
    }

    bool GetCellState(long bitBoard, int row, int col)
    {
        long mask = 1L << (row * 8 + col);
        return (mask & bitBoard) != 0;
    }

    int CellCount(long bitboard)
    {
        // 101111
        // 101110
        // 101100
        // 101000
        // 100000
        int count = 0;
        long bb = bitboard;

        while (bb != 0)
        {
            bb &= bb - 1;
            count++;
        }

        return count;
    }
}
