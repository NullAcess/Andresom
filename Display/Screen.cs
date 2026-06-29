using Andresom.Enemies;
using Andresom.Entities;
using Andresom.Heroes;
using Andresom.HeroTypes;
using Spectre.Console;
using System.Net.NetworkInformation;

namespace Andresom.Screenes
{
    static class Screen
    {
        public static void LoadingGame()
        {
            var updatePanel = new Panel("- Пофикшено меню\n\n-Добавлен полный выбор героев\n\n-Добавлен экран боя\n\n-Добавлен интерфейс") // создаем панель UPDATES
            .Header("[red]UPDATES 22.06.2026[/]", Justify.Center) // название отображемого мен юи место положения названия
            .Border(BoxBorder.Rounded) // тип обводки панели
            .BorderColor(Color.Gray23); // цвет обводки панели
            updatePanel.Width = 30; // фиксируем ширину панель
            updatePanel.Height = 23; // фиксируем высоту панели

            var topLogoPanel = new Panel(new FigletText("    ANDRESOM").Color(Color.Red)) // создаем логотип "ANDRESOM"
                .BorderColor(Color.Black);

            var bottomDescriptionPanel = new Panel("Всем привет, кто читает это. В общем игра только делается и несет в себе просто обучающий характер, но может кому-то понравиться спустя несколько лет. Игра только делается и на этом все в целом. ❤️\n\n\n\n\n\n\n\n\n\nBy: Ш.А.С ITHUB 1ИТ3 2026")
                .Header("[red]DESCRIPTION[/]", Justify.Center)
                .Border(BoxBorder.Rounded)
                .BorderColor(Color.Gray23);
            bottomDescriptionPanel.Width = 90;
            bottomDescriptionPanel.Height = 15;

            var rightSideContainer = new Rows(topLogoPanel, bottomDescriptionPanel); // объединиям в 1 строку 2 строки: логотипа сверху и описание снизу

            var mainLayout = new Grid() // создаем сетку
                .AddColumn() // добавляем колонку под левую панель ( update )
                .AddColumn() // добавляем колонку под правую панель ( 1 большая панель / строку из 2 панелей / строк )
                .AddRow(updatePanel, rightSideContainer); // собираем все в строку

            AnsiConsole.Write(mainLayout); // выводим весь layout

            TopSpace(topSpaceValue: 27);  // 27 расстоение от верхней границы
            var titleText = new Panel("[bold]Fight and survive. You will be rewarded for it in the end. [/]") // в самом низу добавляем текст ( подсказку )
                .Header("Hint", Justify.Center)
                .BorderColor(Color.Black);
            AnsiConsole.Write(Align.Center(titleText)); // выравниваем через align по центру cmd

            TopSpace(topSpaceValue: 27);
            AnsiConsole.Status() // вызываем загрузку
                .Start("[red]Processing...[/]", // текст загрузки
                ctx => { Thread.Sleep(400); }); // TODO: вернуть таймер в значение с 0 до 4000

            var continueButton = new Panel("Press any key") // текст кнопки о продолжении
                .BorderColor(Color.Green);
            AnsiConsole.Write(Align.Center(continueButton));
            Console.ReadKey(); // считываем любую нажатую клавишу
        }

        public static HeroType ChooseHero()
        {
            AnsiConsole.Clear(); // очищаем консоль от прошлого окна, чтоб не было 2 меню на 1 экране.
            const string leftSpace = "\t\t\t\t\t\t\t"; // создаем константное поле string, которое будет отсутпать от левого края на определнное расстояние ( для отобраежения списка выбора по центру ).
            bool isContinue = true; // делаем для цикла while

            while (isContinue) // из за функционала перевыбора персонажа, можно вернуться обратно и нам нужно чтобы цикл выбора персонажа начинался заново, поэтому тут цикл.
            {
                AnsiConsole.Write(new FigletText("Choose your class:").Color(Color.Red) // создаем огромное по центру лого
                    .Centered() // выравниваем по центру
                    .Color(Color.Red));

                TopSpace(topSpaceValue: 15);
                var choice = AnsiConsole
                    .Prompt(new SelectionPrompt<string>() // собираем список
                    .HighlightStyle(new Style(foreground: Color.Red)) // цвет выбранного пункта списка
                    .AddChoices($"{leftSpace}Knight", $"{leftSpace}Wizzard", $"{leftSpace}Archer")); // варианты списака

                AnsiConsole.Clear(); // очищаем консоль ( переход на новое окно ) для подтверждение выбора героя

                TopSpace(topSpaceValue: 0);
                var selectedClass = new Panel("Press backspace to back") // создае панель вернуться обратно
                    .BorderColor(Color.Gray23);
                AnsiConsole.Write(Align.Left(selectedClass));

                TopSpace(topSpaceValue: 10);
                AnsiConsole.Write(new FigletText($"{choice}")
                    .Centered()
                    .Color(Color.Red));

                TopSpace(topSpaceValue: 25);
                var continueButton = new Panel("Press enter to confirm your choice").BorderColor(Color.Gray23);
                AnsiConsole.Write(Align.Center(continueButton));

                ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true); // создаем ConsoleKeyInfo для считки определенных клавиш
                if (keyInfo.Key == ConsoleKey.Enter) // при нажатии enter
                {
                    switch (choice) // choice это переменная, которая сохраняет в string выбор пользователя
                    {
                        case $"{leftSpace}Knight": return HeroType.Knight; // leftSpace нужен, потому что мы выводили список с отстопом, и сохранил choice вариант с отступами
                        case $"{leftSpace}Wizzard": return HeroType.Wizzard;
                        case $"{leftSpace}Archer": return HeroType.Archer;
                        default: return HeroType.Knight; // защита от дурка ( по умолчанию будет за рыцаря играть ).
                    }
                }

                else
                {
                    AnsiConsole.Clear(); // если захотел назад очищаем консоль и заново весь цикл выбора персонажа
                    continue;
                }
            }

            return HeroType.Knight; // заглушка.
        }


        public static void Fight(Entity enemy, Entity user, ref int countOfWaves)
        {
            Random random = new Random();
            string enemyModel = enemy.Model;
            string userModel = user.Model;
            bool isContinue = true;

            while (isContinue)
            {

                if (user.Health <= 0) Lose();

                AnsiConsole.Clear();
                var arenaRule = new Rule("[red]⚔️ АРЕНА ⚔️[/]");
                arenaRule.Justification = Justify.Center;
                AnsiConsole.Write(arenaRule);

                var barSpacePanel = new Panel(new Text("\t\t\t\t\t"))
                    .BorderColor(Color.Black)
                    .Padding(50, 0, 0, 0);

                var enemyBarsPanel = new Panel($"[white]Enemy HP: [/][green]{enemy.Health}[/][white] | Stamina: [/][yellow]{enemy.Stamina}[/]")
                    .BorderColor(Color.White);

                var userBarsPanel = new Panel($"[white]Hero HP: [/][green]{user.Health}[/][white] | Stamina: [/][yellow]{user.Stamina}[/]")
                    .BorderColor(Color.White);

                var healthBarsScene = new Columns(enemyBarsPanel, barSpacePanel, userBarsPanel);
                TopSpace(topSpaceValue: 2);
                AnsiConsole.Write(healthBarsScene);

                var fightSpacePanel = new Panel(new Text("\t\t\t\t\t"))
                    .BorderColor(Color.Black)
                    .Padding(80, 0, 0, 0);

                var playerPanel = new Panel(new Text(user.Model))
                    .BorderColor(Color.Black)
                    .Padding(0, 0, 0, 0); // Отступы для красоты

                var enemyPanel = new Panel(new Text(enemy.Model))
                    .BorderColor(Color.Black)
                    .Padding(0, 0, 0, 0);

                var battleScene = new Columns(enemyPanel, fightSpacePanel, playerPanel);
                AnsiConsole.Write(battleScene);

                var actionRule = new Rule("[red]⚙️ ACTIONS ⚙️[/]");
                actionRule.Justification = Justify.Center;
                AnsiConsole.Write(actionRule);

                int enemyDialogProcent = random.Next(1, 101);
                if (enemyDialogProcent <= 2) { AnsiConsole.WriteLine("Enemy: 😡 You will regret this!"); Thread.Sleep(2500); Console.WriteLine("\r "); }
                else if (enemyDialogProcent > 2 && enemyDialogProcent <= 4) { AnsiConsole.WriteLine("Enemy: 😡 Watch your back!!!"); Thread.Sleep(2500); Console.WriteLine("\r "); }
                else if (enemyDialogProcent > 4 && enemyDialogProcent <= 6) { AnsiConsole.WriteLine("Enemy: 😡 I'm warning you..."); Thread.Sleep(2500); Console.WriteLine("\r "); }
                else if (enemyDialogProcent > 6 && enemyDialogProcent <= 8) { AnsiConsole.WriteLine("Enemy: 😡 Don't push your luck."); Thread.Sleep(2500); Console.WriteLine("\r "); }
                else { }

                TopSpace(19);
                var choice = AnsiConsole
                        .Prompt(new SelectionPrompt<string>() // собираем список
                        .HighlightStyle(new Style(foreground: Color.Red)) // цвет выбранного пункта списка
                        .AddChoices($"Attack ( -{user.Weapon.RequirementEnergy} energy )       ", "Skip ( +10 energy )", "Inventory", "Exit game")); // варианты списака

                switch (choice)
                {
                    case $"Attack ( -10 energy )       ":
                    case $"Attack ( -15 energy )       ":
                    case $"Attack ( -20 energy )       ": if (!user.AttackTarget(enemy)) Energy(); break;
                    case "Skip ( +10 energy )": user.RestoreStamina(isNewRound: false); break;
                    case "Exit game": GoodBye(); break;
                }

                if (enemy.Health <= 0)
                {
                    Console.WriteLine("Enemy: 💀 Aaaahhhhhhh........");
                    Thread.Sleep(2500);

                    if (countOfWaves == 1) return;

                    NextWave();
                    user.RestoreStamina(isNewRound: true);
                    return;
                }

                int enemyChoiceProcent = random.Next(1, 101);
                if (enemyChoiceProcent < 70) enemy.AttackTarget(user);
                else enemy.RestoreStamina(isNewRound: false);
            }
        }

        private static void Energy()
        {
            AnsiConsole.Clear();
            TopSpace(10);
            var energyTitle = new Panel(new FigletText("           NO ENERGY!").Color(Color.Red))
                .BorderColor(Color.Black);
            AnsiConsole.Write(energyTitle);
            Thread.Sleep(2000);
            return;
        }

        private static void Lose()
        {
            AnsiConsole.Clear();
            TopSpace(10);
            var loseTitle = new Panel(new FigletText("              YOU LOSE...").Color(Color.Red))
                .BorderColor(Color.Black);
            AnsiConsole.Write(loseTitle);
            Thread.Sleep(2000);
            Environment.Exit(0);
        }

        private static void NextWave()
        {
            AnsiConsole.Clear();
            TopSpace(10);
            var loseTitle = new Panel(new FigletText("           NEXT WAVE!").Color(Color.Red))
                .BorderColor(Color.Black);
            AnsiConsole.Write(loseTitle);
            Thread.Sleep(2000);
        }

        internal static void Win()
        {
            AnsiConsole.Clear();
            TopSpace(10);
            var winTitle = new Panel(new FigletText("                 YOU WIN").Color(Color.Red))
                .BorderColor(Color.Black);
            AnsiConsole.Write(winTitle);
            Thread.Sleep(2000);
            Environment.Exit(0);
        }
        private static void GoodBye()
        {
            AnsiConsole.Clear();

            TopSpace(10);
            var goodbyeTitle = new Panel(new FigletText("                 BYE BYE").Color(Color.Red))
                .BorderColor(Color.Black);
            AnsiConsole.Write(goodbyeTitle);
            Thread.Sleep(2000);
            Environment.Exit(0);
        }

        private static void TopSpace(int topSpaceValue = 0)
        {
            Console.SetCursorPosition(0, topSpaceValue);
        }
    }
}