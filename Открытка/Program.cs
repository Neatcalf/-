namespace pozdravitelnaya_otkritka
{
    class Program
    {
        static void Main(string[] args)
        {
            string data;

            Console.WriteLine("Введите имя получателя: ");

            data = Console.ReadLine();

            Console.WriteLine(data + ", поздравляю тебя с твоим днём рождения, желаю всего наилучшего.");
            Console.WriteLine("Желаю, чтобы каждый день был наполнен яркими эмоциями и впечатлениями.");
            Console.WriteLine("Пусть жизнь радует приятными сюрпризами, новыми открытиями и интересными встречами.");
            Console.WriteLine("Будь здоров и полон сил для новых свершений!");
            Console.WriteLine("Надеюсь, что этот год принесёт тебе массу положительных эмоций и ярких моментов");
            Console.WriteLine("Отметь свой праздник так, как ты мечтаешь!");




            Console.WriteLine("от Имиля, для " + data + "!!");
        }
    }
}
