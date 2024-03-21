internal class Program
{
    private static void Main(string[] args)
    {
        penjumlahan jumlah = new penjumlahan();
        jumlah.jumlahTigaAngka<double>(13.00,02.00,22.00);
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