using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("\nHoş geldiniz!");
        Console.Write("Lütfen adınızı giriniz: ");
        string playerName = Console.ReadLine();
        Console.WriteLine($"Merhaba {playerName}! Hadi seçimlerini yapalım.\n");

        // Sorular ve seçenekler
        var questions = new List<Question>
        {
            new Question("Bir macera mı yaşamak yoksa sakin bir gün mü tercih edersin?", new Dictionary<string, string> { { "A", "Macera" }, { "B", "Sakin bir gün" } }),
            new Question("Bir hayvan dostu seç. Hangisi evinde beslemek isterdin ?", new Dictionary<string, string> { { "A", "Kedi" }, { "B", "Köpek" }, { "C", "Kuş" } }),
            new Question("Bir süper gücün olsaydı, hangisini seçerdin?", new Dictionary<string, string> { { "A", "Uçmak" }, { "B", "Zamanı durdurmak" }, { "C", "Görünmezlik" } }),
            new Question("Tatil için hangisini seçersin?", new Dictionary<string, string> { { "A", "Kamp" }, { "B", "Deniz" }, { "C", "Şehir" } })
        };

        // Oyuncu cevaplarını toplamak
        var answers = new Dictionary<int, string>();

        for (int i = 0; i < questions.Count; i++)
        {
            var question = questions[i];
            Console.WriteLine($"\n{i + 1}. Soru: {question.Text}");

            foreach (var option in question.Options)
            {
                Console.WriteLine($"{option.Key}: {option.Value}");
            }

            string answer;
            while (true)
            {
                Console.Write("Cevabınızı seçin (A, B, C): ");
                answer = Console.ReadLine()?.ToUpper();
                if (question.Options.ContainsKey(answer))
                {
                    answers[i + 1] = answer;
                    break;
                }
                else
                {
                    Console.WriteLine("Lütfen geçerli bir seçenek girin.");
                }
            }
        }

        // Cevaplara göre kişiselleştirilmiş geri bildirim
        Console.WriteLine("\nSonuçlar:\n");
        if (answers[1] == "A")
        {
            Console.WriteLine("Macera dolu bir ruha sahipsin!");
        }
        else
        {
            Console.WriteLine("Sakin ve huzurlu bir günü tercih eden birisin.");
        }

        if (answers[2] == "A")
        {
            Console.WriteLine("Kedilerle arandaki bağ, sofistike ve bağımsız bir ruhun yansıması.");
        }
        else if (answers[2] == "B")
        {
            Console.WriteLine("Köpekler gibi sadık ve neşeli bir yapın var.");
        }
        else
        {
            Console.WriteLine("Kuşlar gibi özgürlüğü seven birisin.");
        }

        if (answers[3] == "A")
        {
            Console.WriteLine("Uçmak isteyen birisi olarak, büyük hayallerin peşinden gidiyorsun.");
        }
        else if (answers[3] == "B")
        {
            Console.WriteLine("Zamanı durdurmayı tercih ederek, her anı dolu dolu yaşamak istiyorsun.");
        }
        else
        {
            Console.WriteLine("Görünmezlik senin için sınırları aşma cesaretini temsil ediyor.");
        }

        if (answers[4] == "A")
        {
            Console.WriteLine("Doğadaki vahşi ve zor hayat sendeki cesareti gösteriyor.");
        }
        else if (answers[4] == "B")
        {
            Console.WriteLine("Deniz seni rahatlatan ve canlandıran bir yer.");
        }
        else
        {
            Console.WriteLine("Şehirdeki enerji ve hareketlilik sana ilham veriyor.");
        }

        Console.WriteLine($"\nTeşekkürler {playerName}, seçimlerinize göre size özel bir yolculuk oluşturduk!");
    }
}

class Question
{
    public string Text { get; set; }
    public Dictionary<string, string> Options { get; set; }

    public Question(string text, Dictionary<string, string> options)
    {
        Text = text;
        Options = options;
    }
}
