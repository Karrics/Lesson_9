using System;


namespace DZ
{
    internal class Program
    {
        public interface IGame
        {
            void StartTheGame();
        }

        static void Main(string[] args)
        {
            // Команда сб. России
            Person Adel = new Person("Адель", Post.игрок);
            Person Alexei = new Person("Алексей", Post.игрок);
            Person Andrey = new Person("Андрей", Post.игрок);
            Person Sasha = new Person("Саша", Post.игрок);
            Person Alisa = new Person("Алиса", Post.игрок);
            Person Nail = new Person("Наиль", Post.игрок);
            Person Danil = new Person("Данил", Post.игрок);
            Person Vadim = new Person("Вадим", Post.игрок);
            Person Leysan = new Person("Лейсан", Post.игрок);
            Person Julia = new Person("Юля", Post.игрок);
            Person Kirill = new Person("Кирилл", Post.игрок);
            Person Roman = new Person("Рома", Post.игрок);
            Person Sergey  = new Person("Сергей", Post.игрок);
            Person Oleg = new Person("Олег", Post.игрок);
            Person Pasha = new Person("Паша", Post.игрок);
            Team russianTeam = new Team("Россия", Adel, Alexei, Andrey, Sasha, Alisa, Nail, Danil, Vadim, Leysan, Julia, Kirill, Roman, Sergey, Oleg, Pasha);

            // Команда сб. Франции
            Person Mayk = new Person("Майк", Post.игрок);
            Person Dayo = new Person("Дайо", Post.игрок);
            Person Benjamine = new Person("Бенжамен", Post.игрок);
            Person Teo = new Person("Тео", Post.игрок);
            Person Gerard = new Person("Жерар", Post.игрок);
            Person Joseph = new Person("Жозеф", Post.игрок);
            Person Yvon = new Person("Ивон", Post.игрок);
            Person Karim = new Person("Кариm", Post.игрок);
            Person Colette = new Person("Колетт", Post.игрок);
            Person Lambert = new Person("Ламберт", Post.игрок);
            Person Luke = new Person("Люк", Post.игрок);
            Person Mark = new Person("Марк", Post.игрок);
            Person Antuan = new Person("Антуан", Post.игрок);
            Person Kilian = new Person("Килиан", Post.игрок);
            Person Cristofer = new Person("Кристофер", Post.игрок);
            Team frenchTeam = new Team("Франция", Mayk, Dayo, Benjamine, Teo, Gerard, Joseph, Yvon, Karim, Colette, Lambert, Luke, Mark, Antuan, Kilian, Cristofer);

            // Команда сб. Китая
            Person Albedo = new Person("Альбедо", Post.игрок);
            Person Amber = new Person("Эмбер", Post.игрок);
            Person Barbara = new Person("Барбара", Post.игрок);
            Person Beidou = new Person("Бейдоу", Post.игрок);
            Person Bennett = new Person("Беннет", Post.игрок);
            Person Charlotte = new Person("Шарлотта", Post.игрок);
            Person Chongyun = new Person("Чунь-Юнь", Post.игрок);
            Person Collei = new Person("Коллеи", Post.игрок);
            Person Diluc = new Person("Дилюк", Post.игрок);
            Person Fischl = new Person("Фишль", Post.игрок);
            Person Yae_Miko = new Person("Яэ_Мико", Post.игрок);
            Person Xingqiu = new Person("Синцю", Post.игрок);
            Person Tartaglia = new Person("Тарталья", Post.игрок);
            Person Raiden_Shogun = new Person("Сёгун_Райден", Post.игрок);
            Person Hu_Tao = new Person("Ху_Тао", Post.игрок);
            Team chineseTeam = new Team("Китай", Albedo, Amber, Barbara, Beidou, Bennett, Charlotte, Chongyun, Collei, Diluc, Fischl, Yae_Miko, Xingqiu, Tartaglia, Raiden_Shogun, Hu_Tao);

            // Команда сб. Казахстана
            Person Abyz = new Person("Абыз", Post.игрок);
            Person Ademi = new Person("Адеми", Post.игрок);
            Person Aidar = new Person("Айдар", Post.игрок);
            Person Banu = new Person("Бану", Post.игрок);
            Person Bibinur = new Person("Бибинур", Post.игрок);
            Person Daniyar = new Person("Данияр", Post.игрок);
            Person Erden = new Person("Ерден", Post.игрок);
            Person Zhamal = new Person("Жамал", Post.игрок);
            Person Zhupar = new Person("Жупар", Post.игрок);
            Person Zhangir = new Person("Жангир", Post.игрок);
            Person Totty = new Person("Тотты", Post.игрок);
            Person Sulu = new Person("Сулу", Post.игрок);
            Person Gafu = new Person("Гафу", Post.игрок);
            Person Urzhan = new Person("Уржан", Post.игрок);
            Person Hamza = new Person("Хамза", Post.игрок);
            Team kazakhstanTeam = new Team("Казахстан", Abyz, Ademi, Aidar, Banu, Bibinur, Daniyar, Erden, Zhamal, Zhangir, Zhupar, Totty, Sulu, Gafu, Urzhan, Hamza);


            Person OlivierGagnan = new Person("Оливье Ганьян", Post.организатор);
            BigRace bigRace = new BigRace();
            OlivierGagnan.AddingTeamToShow(bigRace, russianTeam, chineseTeam, kazakhstanTeam, frenchTeam);

            Beach beach = new Beach();
            MouseTrap mousetrap = new MouseTrap();
            Sea sea = new Sea();
            Fishing fishing = new Fishing();
            Postman postmen = new Postman();
            Slide slide = new Slide();

            OlivierGagnan.AddingGameToToShow(bigRace, beach, mousetrap, sea, fishing, postmen, slide);

            bigRace.StartShow(beach);
            bigRace.StartShow(mousetrap);
            bigRace.StartShow(sea);
            bigRace.StartShow(fishing);
            bigRace.StartShow(postmen);
            bigRace.StartShow(slide);
            Console.WriteLine();

            Park park = new Park();
            OlivierGagnan.AddingGameToToShow(bigRace, park);
            bigRace.StartShow(park);
            Console.ReadKey();
        }
    }
}
