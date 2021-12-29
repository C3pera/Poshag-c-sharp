using All_Classes;
using static System.Console;

Random rand = new Random();

char answer = ' ';
int mozg = 0;

//Объекты и статы
//player
CreaturesStats player = new CreaturesStats();
player.hp = 30;
player.attack = 3 + rand.Next(5);
player.strongAttack = 5 + rand.Next(10);
player.fatigue = 100;
//rat
CreaturesStats rat = new CreaturesStats();
rat.hp = 30;
rat.attack = 3;

//Оружие
bool[] isWeaponSearched = new bool[10];
Weapons torch = new Weapons();
torch.WeaponName = "Да не торч я";
torch.WeaponDmg = 9;

//Функции
void Answer()
{
    //Эта функция принимает ответ и проверяет на ошибки, чтобы ничего не вылетело
    try
    {
        answer = char.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.WriteLine("?"); //придумать какой-нибудь ответ
    }
}
void DefaultConsoleSize()
{
    WindowHeight = 50;
    WindowWidth = 125;
    SetWindowSize(Console.WindowWidth, Console.WindowHeight);
    CursorVisible = false;
}

//Main
mainMenu();
actOne();
actAttack();
//Конец Main

//Логика прохождения
void mainMenu()
{
    string mainLogo = @" ________  ________  ________  ___  ___  ________  ________     
|\   __  \|\   __  \|\   ____\|\  \|\  \|\   __  \|\   ____\    
\ \  \|\  \ \  \|\  \ \  \___|\ \  \\\  \ \  \|\  \ \  \___|    
 \ \   ____\ \  \\\  \ \_____  \ \   __  \ \   __  \ \  \  ___  
  \ \  \___|\ \  \\\  \|____|\  \ \  \ \  \ \  \ \  \ \  \|\  \ 
   \ \__\    \ \_______\____\_\  \ \__\ \__\ \__\ \__\ \_______\
    \|__|     \|_______|\_________\|__|\|__|\|__|\|__|\|_______|
                       \|_________|                             ";

    for (; ; )
    {
        Console.Write(mainLogo);
        Console.WriteLine("\n1. Начать пошаг" + "\n2. Правила" + "\n3. Сбросить разрешение" + "\ne. Выход");

        Answer();

        switch (answer)
        {
            case '2':
                Console.Clear();
                Console.WriteLine("Правила таковы:" + "\n1. Все ответы вводяться цифрами" +
                    "\n2. Все ответы только ОДНОЙ цифрой. Если ошиблись - можно стереть и перезаписать" +
                    "\n3. Не пишите буквами" +
                    "\n4. Иногда можно)");
                Console.WriteLine("Нажмите любую клавишу...");
                Console.ReadKey();
                break;
            case '3':
                DefaultConsoleSize();
                break;
            case '4':
                break;
        }
        if (answer == '1')
        {
            break;
        }
        if (answer == 'e')
        {
            Environment.Exit(0);
        }
    }
}

void actOne()
{
    Console.Clear();
    Console.WriteLine("Ваш корабль сломался во время шторма, вас выбросило на берег, где вы нашли пещеру." +
    "\nОставшись на ночёвку, вы развели костёр и мелкий проход, через который вы забрались в пещеру - завалило." +
    "\nОстается идти только вперед через глубины.");
    Console.WriteLine("\nВы смотрите по сторонам. Сзади вас заваленный проход. По бокам только стены и костёр. Спереди - неизвестность.");

    for (; ; )
    {
        Console.WriteLine("\nЧто вы хотите сделать? \n1. Осмотреться \n2. Зажечь костер.");
        Answer();

        switch (answer)
        {
            default:
                Console.WriteLine("Похоже у вас своя дорога. Но нужно выбрать правильный путь");
                break;
            case '1':
                Console.WriteLine("Лицо в крови, вокруг куча поломанных досок, дальше 2 метров ничего не видно.");
                break;
            case '2':
                Console.WriteLine("Собрав обломки досок в кучу, Вы разводите костер. Позади себя Вы замечаете палку, смотав с руки бинт и прявязав к палке несколько щепок, Вы сделали Факел.");
                break;
        }
        if (answer == '2')
            break;
    }


    Console.Clear();
    Console.WriteLine("Костер прорвал мрак своим пламенем, впереди веднеется проход");
    for (; ; )
    {
        Console.WriteLine("\nЧто вы хотите сделать? \n1. Пройти вперед. \n2. Вернуться назад.");
        Answer();

        switch (answer)
        {
            default:
                Console.WriteLine("это тестовый уровень, не пиши такое больше");
                break;
            case '1':
                Console.WriteLine("Проходя через узкий тоннель, Вы видите еще несколько проходов, поворот налево и проход прямо");
                break;
            case '2':
                Console.WriteLine("иди по сюжету балбес, в принципе все");
                break;
        }
        if (answer == '1')
            break;
    }

    Console.Clear();
    Console.WriteLine("Перед Вами поворот налево и проход прямо.");
    for (; ; )
    {
        Console.WriteLine("\nЧто вы хотите сделать? \n1. Идти дальше. \n2. Пройти налево.");
        Answer();

        switch (answer)
        {
            default:
                Console.WriteLine("СВОЛОЧЬ! СВОЛОЧЬ! СВОЛОЧЬ! сука СВОЛОЧЬ!");
                break;
            case '1':
                Console.WriteLine("Пройдя дальше по пещере, Вы видите небольшое каменное сооружение, статуя, в основании которой – пустой слот. Справа виден еще один проход.");
                break;
            case '2':
                Console.WriteLine("Перед Вами предстает неизвестный механизм - 3 колонны в середине которых находятся треугольники, на треугольниках  изображены символы \nНа первом изображены: Месяц, растущая луна, полнолуние. \nНа втором изображены: Меч, щит, лук. \nНа третьем изображены: Дева, небо, башня");
                break; 
        }
    }
    
}

void actAttack()
{
    Console.Clear();

    Console.WriteLine("\nПройдя вперёд вы видите крысу. Люди в этих краях называют их Моргенами. " +
        "\nВас заметили, придётся драться с Моргеном");

    for (; ; )
    {
        Console.WriteLine("\nЧто вы хотите сделать? \n1. Сделать сильный удар\n2. Ударить слабо.");
        Answer();

        Console.WriteLine($"Ваше здоровье = {player.hp}");
        Console.WriteLine($"Здоровье врага = {rat.hp}");

        switch (answer)
        {
            default:
                Console.WriteLine("Да, запрещенные приёмы всё еще под запретом. Выбирайте из того, что у вас есть.");
                player.hp -= rat.attack;
                break;
            case '1':
                Console.WriteLine("Вы сделали ОДИН удар и крыса упала замертво. Неудивительно");
                rat.hp -= rat.hp;
                break;
            case '2':
                Console.WriteLine("Вы, кажется, погладили крысу. Ей понравилось");
                player.hp -= rat.attack;
                rat.hp -= player.attack;
                break;
        }
        if (player.hp <= 0)
        {
            Console.WriteLine("\nДа... Вас победил Морген. И зачем вас взяли на задание?");
            break;
        }
        if (rat.hp <= 0)
        {
            Console.WriteLine("\nЧтож, крыса валяется как таракан. Кажется, она мертва.");
            break;
        }
    }
    player.fatigue = 100;
}
