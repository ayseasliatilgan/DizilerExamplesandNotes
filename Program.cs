internal class Program
{
    static void Main(string[] args)
    {
        // koseli parantez icerisindeki her virgul boyut sayisini belirler yani bir virgul tek boyut, iki virgul iki boyut seklinde
        double[,] matris = new double[,] { { 1, 2, 3 }, { 2, 3, 4 }, { 3, 4, 5 } };

        // matris icerisindeki elemanlarin degerlerininin toplamini bulmak istiyorsam eger;
        double toplam = 0;

        for (int i = 0; i < matris.GetLength(0); i++)
        {
            for (int j = 0; j < matris.GetLength(1); j++)
            {
                // eger diagonel elemanlari belirli bir sayi vermek istiyorsak orn; -1
                if (i==j)
                {
                    matris[i, j] = -1;
                }

                // ikinin kati olan elemanlari sıfır degerini vermek istiyorsam bir kosul daha eklerim
                if (matris[i,j]%2 == 0)
                    matris[i,j] = 0;

                //toplaö deger isleminin devami buraya gelir
                toplam += matris[i,j];

                Console.Write($"{matris[i, j],5}");


            }
            Console.WriteLine();
        }

        Console.WriteLine($"Toplam: {toplam}");

        Console.ReadKey();
    }

    private static void DizilerExample2()
    {
        Console.WriteLine("Dizi Boyutunu Giriniz: ");
        int boyut = Convert.ToInt32(Console.ReadLine());
        int[] numbers = new int[boyut];

        var r = new Random();

        // for dongusunde eger tek satirdaysa illa süslü parantez kullanmaya gerek yok
        for (int i = 0; i < numbers.Length; i++)
            numbers[i] = r.Next(1, 10);

        // n for the numbers short symbol
        foreach (int n in numbers)
        {
            // eger sade olmasını istersek Console.WriteLine(n);
            // eger 5 e bagli olarak arada bosluk istersek Console.WriteLine($"{n,5};
            Console.WriteLine($"{n,5} {n * n,5}");
        }
    }

    private static void DizilerIntroThirdWay()
    {
        // tanimlama & baslatma & atama
        // int[] numbers = new int[3] { 3, 5, 7 }; yazabilir ya da
        // int[] numbers = new int[] { 3, 5, 7, 8, 10 }; ya da
        int[] numbers = { 3, 5, 7, 8, 10 };

        for (int i = 0; i < numbers.Length; i++)
        {
            // Console.WriteLine(numbers[i]); yazabilir ya da
            // esnek bir kodlama alanı icin ayrica bu da yazilabilir
            Console.WriteLine($"Numbers[{i}] = " +
                $"{numbers[i]}");
        }
    }

    private static void DizilerIntroSecondWay()
    {
        // tanimlama & baslatma
        int[] numbers = new int[3];

        numbers[0] = 3;
        numbers[1] = 5;
        numbers[2] = 7;

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }

    private static void DizilerIntro()
    {
        // tanimlama
        int[] numbers;

        // eger bir ifade refans tipindeyse baslatma gerekir
        // start
        numbers = new int[3];

        numbers[0] = 3;
        numbers[1] = 5;
        numbers[2] = 7;

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}