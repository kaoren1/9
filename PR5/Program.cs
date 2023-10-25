using System.Reflection.Metadata;
using System.Runtime;

namespace PR5
{
    class Order
    {
        public string shape;
        public string size;
        public string taste;
        public string quantity;
        public string glaze;
        public string decor;
        public int shape_price;
        public int size_price;
        public int taste_price;
        public int quantity_price;
        public int glaze_price;
        public int decor_price;
        //Конструктор заказа
        public Order(string shape, string size, string taste, string quantity, string glaze, string decor, int shape_price, int size_price, int taste_price, int quantity_price, int glaze_price, int decor_price)
        { }
    }
    class Sub
    {
        public string atribute;
        public int price;
        //конструктор подпунктов
        public Sub(string atribute, int price)
        {
            this.atribute = atribute;
            this.price = price;
        }
    }
    internal class Program
    {
        //Подпункты форма
        public static Sub round = new("Круглая", 300);
        public static Sub square = new("Квадратная", 400);
        public static Sub octagon = new("Круглая", 300);
        //подпункты размер
        public static Sub small = new("Маленький", 100);
        public static Sub average = new("Средний", 200);
        public static Sub big = new("Большой", 400);
        //подпункты вкус
        public static Sub blackberry = new("Ежевичный", 300);
        public static Sub blueberry = new("Черничный", 300);
        public static Sub strawberry = new("Клубничный", 300);
        //Подпункты количество
        public static Sub few = new("Мало", 100);
        public static Sub medium = new("Средне", 200);
        public static Sub many = new("Много", 400);
        //Подпункты глазурь
        public static Sub chocolate = new("Шоколадная", 300);
        public static Sub yogurt = new("Йогуртовая", 300);
        public static Sub jelly = new("Желейная с ягодками", 350);
        //Подпункты декор
        public static Sub drawings = new("Рисунки шоколадом", 200);
        public static Sub cakes = new("Фигурные пряники", 250);
        public static Sub figurines = new("Сахарные фигурки", 150);
        //месье заказ
        public static Order Order = new("", "", "", "", "", "", 0, 0, 0, 0, 0, 0);
        public static void Main()
        {
            Console.WriteLine(" Выберите параметр торта");
            Console.WriteLine("-------------------------");
            Console.WriteLine("  1. Форма");
            Console.WriteLine("  2. Размер");
            Console.WriteLine("  3. Вкус");
            Console.WriteLine("  4. Количество");
            Console.WriteLine("  5. Глазурь");
            Console.WriteLine("  6. Декор");
            Console.WriteLine("  7. Завершение заказа");

            int s = Order.shape_price + Order.size_price + Order.taste_price + Order.quantity_price + Order.glaze_price + Order.decor_price;
            Console.WriteLine("Итоговая цена: " + s);
            Console.WriteLine($"Текущий заказ:" + "\t" + Order.shape + Order.shape_price + "\t" + Order.size + Order.size_price + "\t" + Order.taste + Order.taste_price + "\t" + Order.quantity + Order.quantity_price + "\t" + Order.glaze + Order.glaze_price + "\t" + Order.decor + Order.decor_price);
            int selected = Menu.Cursor(2, 8);

            switch (selected)
            {
                case 2:
                    Console.Clear();
                    Console.WriteLine("Выберите форму:");
                    Console.WriteLine("  1. Круглая - 300");
                    Console.WriteLine("  2. Квадартная - 400");
                    Console.WriteLine("  3. Восьмиугольник - 500");
                    int sub = Menu.Cursor(1, 3);
                    switch (sub)
                    {
                        case 1:
                            Order.shape = round.atribute;
                            Order.shape_price = round.price;
                            Console.Clear();
                            Main();
                            break;
                        case 2:
                            Order.shape = square.atribute;
                            Order.shape_price = square.price;
                            Console.Clear();
                            Main();
                            break;
                        case 3:
                            Order.shape = octagon.atribute;
                            Order.shape_price = octagon.price;
                            Console.Clear();
                            Main();
                            break;
                    }
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Выберите размер:");
                    Console.WriteLine("  1. Маленький - 100");
                    Console.WriteLine("  2. Средний - 200");
                    Console.WriteLine("  3. Большой - 400");
                    int sub1 = Menu.Cursor(1, 3);
                    switch (sub1)
                    {
                        case 1:
                            Order.size = small.atribute;
                            Order.size_price = small.price;
                            Console.Clear();
                            Main();
                            break;
                        case 2:
                            Order.size = average.atribute;
                            Order.size_price = average.price;
                            Console.Clear();
                            Main();
                            break;
                        case 3:
                            Order.size = big.atribute;
                            Order.size_price = big.price;
                            Console.Clear();
                            Main();
                            break;
                    }
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Выберите вкус");
                    Console.WriteLine("  1. Ежевичный - 300");
                    Console.WriteLine("  2. Черничный - 300");
                    Console.WriteLine("  3. Клубничный - 300");
                    int sub2 = Menu.Cursor(1, 3);
                    switch (sub2)
                    {
                        case 1:
                            Order.taste = blackberry.atribute;
                            Order.taste_price = blackberry.price;
                            Console.Clear();
                            Main();
                            break;
                        case 2:
                            Order.taste = blueberry.atribute;
                            Order.taste_price = blackberry.price;
                            Console.Clear();
                            Main();
                            break;
                        case 3:
                            Order.taste = strawberry.atribute;
                            Order.taste_price = strawberry.price;
                            Console.Clear();
                            Main();
                            break;
                    }
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("Выберите количество");
                    Console.WriteLine("  1. Мало - 100");
                    Console.WriteLine("  2. Средне - 200");
                    Console.WriteLine("  3. Много - 400");
                    int sub3 = Menu.Cursor(1, 3);
                    switch (sub3)
                    {
                        case 1:
                            Order.quantity = few.atribute;
                            Order.quantity_price = few.price;
                            Console.Clear();
                            Main();
                            break;
                        case 2:
                            Order.quantity = medium.atribute;
                            Order.quantity_price = medium.price;
                            Console.Clear();
                            Main();
                            break;
                        case 3:
                            Order.quantity = many.atribute;
                            Order.quantity_price = many.price;
                            Console.Clear();
                            Main();
                            break;
                    }
                    break;
                case 6:
                    Console.Clear();
                    Console.WriteLine("Выберите глазурь:");
                    Console.WriteLine("  1. Шоколадная - 300");
                    Console.WriteLine("  2. Йогуртовая - 300");
                    Console.WriteLine("  3. Желейная с ягодками - 350");
                    int sub4 = Menu.Cursor(1, 3);
                    switch (sub4)
                    {
                        case 1:
                            Order.glaze = chocolate.atribute;
                            Order.glaze_price = chocolate.price;
                            Console.Clear();
                            Main();
                            break;
                        case 2:
                            Order.glaze = yogurt.atribute;
                            Order.glaze_price = yogurt.price;
                            Console.Clear();
                            Main();
                            break;
                        case 3:
                            Order.glaze = jelly.atribute;
                            Order.glaze_price = jelly.price;
                            Console.Clear();
                            Main();
                            break;
                    }
                    break;
                case 7:
                    Console.Clear();
                    Console.WriteLine("Выберите декор:");
                    Console.WriteLine("  1. Рисунки шоколадом - 200");
                    Console.WriteLine("  2. Фигурные пряники - 250");
                    Console.WriteLine("  3. Сахарные фигурки - 150");
                    int sub5 = Menu.Cursor(1, 3);
                    switch (sub5)
                    {
                        case 1:
                            Order.decor = drawings.atribute;
                            Order.decor_price = drawings.price;
                            Console.Clear();
                            Main();
                            break;
                        case 2:
                            Order.decor = cakes.atribute;
                            Order.decor_price = cakes.price;
                            Console.Clear();
                            Main();
                            break;
                        case 3:
                            Order.decor = figurines.atribute;
                            Order.decor_price = figurines.price;
                            Console.Clear();
                            Main();
                            break;
                    }
                    break;
                case 8:
                    Console.Clear();
                    DateTime d = DateTime.Now;
                    string order = ("Составляющие заказа: " + " " + Order.shape + " " + Order.size + " " + Order.taste + " " + Order.quantity + " " + Order.glaze + " " + Order.decor);
                    string path = "История заказов.txt";
                    if (!File.Exists(path))//! = не; то есть если файла нет, создать
                    {
                        File.Create(path).Close();
                    }
                    File.AppendAllText("История заказов.txt", "\n" + "Заказ от: " + d + "\n" + order + "\n" + "Сумма заказа: " + s + "\n");
                    Console.WriteLine("Спасибо за заказ!");
                    Console.WriteLine("Если хотите сделать еще заказ, нажмите Escape");
                    Console.WriteLine("Если хотите выйти из программы, нажмите Enter");
                    ConsoleKeyInfo e = Console.ReadKey();
                    switch (e.Key)
                    {
                        case ConsoleKey.Escape:
                            Console.Clear();
                            //обнуление всего и вся
                            Order.shape = "";
                            Order.shape_price = 0;
                            Order.size = "";
                            Order.size_price = 0;
                            Order.taste = "";
                            Order.taste_price = 0;
                            Order.quantity = "";
                            Order.quantity_price = 0;
                            Order.glaze = "";
                            Order.glaze_price = 0;
                            Order.decor = "";
                            Order.decor_price = 0;
                            Main();
                            break;
                        case ConsoleKey.Enter:
                            Environment.Exit(0);
                            break;
                    }
                    break;
            }
        }
    }
}