using System;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        penjumlahan jumlah = new penjumlahan();
        jumlah.jumlahTigaAngka<double>(13.00,02.00,22.00);

        SimpleDataBase<double> db = new SimpleDataBase<double>();
        db.AddNewData(12);
        db.AddNewData(34);
        db.AddNewData(56);
        db.PrintAllData();
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

class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        this.storedData = new List<T>();
        this.inputDates = new List<DateTime>(); 
    }
    public void AddNewData(T data){
        storedData.Add(data);
        inputDates.Add(DateTime.Now);
    }
    public void PrintAllData()
    {
        for (int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine("Data "+ i+1 + " " + storedData.ElementAt(i)+", yang disimpan pada waktu "+inputDates.ElementAt(i));
        }
    }
}