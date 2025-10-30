namespace Ödev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N girin: ");
            int N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("");

            int[,] matris = new int[N, N];
            Random rnd = new Random();

            Console.WriteLine("Oluşturulan Matris:");

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matris[i, j] = rnd.Next(-9, 10);
                    Console.Write(" " + matris[i, j] + " ");
                }
                Console.WriteLine("");
                Console.WriteLine("");

            }
            int anaToplam = 0;
            for (int i = 0; i < N; i++)
            {
                anaToplam = anaToplam + matris[i, i];
            }
            int carpim = 1;
            for (int i = 0; i < N; i++)
            {
                carpim = carpim * matris[i, N - 1 - i];
            }
            int negatifAdet = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (matris[i, j] < 0)
                    {
                        negatifAdet++;
                    }
                }
            }
            int enCokSayi = matris[0, 0];
            int enSıkAdet = 1;

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    int sayi2 = matris[i, j];
                    int sayac = 0;
                    for (int x = 0; x < N; x++)
                    {
                        for (int y = 0; y < N; y++)
                        {
                            if (matris[x, y] == sayi2)
                                sayac++;
                        }
                    }
                    if (sayac > enSıkAdet || (sayac == enSıkAdet && sayi2 < enCokSayi))
                    {
                        enSıkAdet = sayac;
                        enCokSayi = sayi2;
                    }
                }
            }
            int toplam2 = 0, asal2 = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    toplam2 = toplam2 + matris[i, j];
                    asal2++;
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Ana köşegen toplamı: " + anaToplam);

            Console.WriteLine("");
            Console.WriteLine("Yardımcı köşegen çarpımı: " +carpim);

            Console.WriteLine("");
            Console.WriteLine("Negatif sayı adedi: " + negatifAdet);

            Console.WriteLine("");
            Console.WriteLine("En sık tekrar eden sayı: " + enCokSayi + " (Tekrar: " + enSıkAdet + ")");

            Console.WriteLine("");
            int asalToplam = 0;
            int asalAdet = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    int sayi2 = matris[i, j];
                    bool asal = true;

                    if (sayi2 < 2)
                        asal = false;
                    else
                    {
                        for (int k = 2; k * k <= sayi2; k++)
                        {
                            if (N % k == 0)
                            {
                                asal = false;
                                break;
                            }
                        }
                    }
                    if (asal)
                    {
                        asalToplam += sayi2;
                        asalAdet++;
                    }
                }
            }
            if (asalAdet == 0)
                Console.WriteLine("Asal sayı yok.");
            else
            {
                double ortalama = asalToplam / (double)asalAdet;
                Console.WriteLine("Asal sayıların ortalaması: " + ortalama);
                Console.WriteLine("");
            }
            int[,] yeni = new int[N, N];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    yeni[j, N - 1 - i] = matris[i, j];
                }
            }
            Console.WriteLine("Saat yönünde 90° döndürülmüş:");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(yeni[i, j] + " ");
                }
                Console.WriteLine("");
                Console.WriteLine("");
               
            }
        }
    }
}