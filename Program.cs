﻿internal class Program
{
    private static void Main(string[] args)
    {
        penjumlahan jumlah = new penjumlahan();
        jumlah.jumlahTigaAngka(13,02,22);
    }
}

public class penjumlahan
{
    public void jumlahTigaAngka<T>(T angka1, T angka2, T angka3)
    {
        dynamic dy1 = angka1;
        dynamic dy2 = angka2;
        dynamic dy3 = angka3;
        dynamic jumlah = dy1+ dy2+ dy3;
        Console.WriteLine(jumlah);
    }
}