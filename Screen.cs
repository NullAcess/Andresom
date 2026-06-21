namespace Screen_Namespace
{
    static class Screen
    {
        public static void LoadingGame()
        {

            AnsiConsole.Clear();
            TopSpace(value: 1);
            AnsiConsole.Write(new FigletText(" ANDRESOM    ").RightJustified().Color(Color.Red));

            TopSpace(value: 0);   
            var panel = new Panel("- Add game                            ")
                .Header("[red]UPDATES[/]", Justify.Center)
                .BorderColor(Color.Gray46)
                .Padding(0, 9);
            AnsiConsole.Write(panel);

            TopSpace(27);
            var titleText = new Panel("[bold]Fight and survive. You will be rewarded for it in the end. [/]") // Создаем привествие
                .Header ("Hint", Justify.Center)
                .BorderColor(Color.Gray46)
                .Padding(0, -10);
            AnsiConsole.Write(Align.Center(titleText)); // Вывод привествия

            TopSpace(value: 27); // loading anim
            AnsiConsole.Status()
                .Start("[red]Processing...[/]", ctx => { Thread.Sleep(5500); });


            var continueButton = new Panel("Press any key");
            AnsiConsole.Write(Align.Center(continueButton));
            Console.ReadKey(); AnsiConsole.Clear();
        }

        public static void ChooseHero()
        {
            AnsiConsole.Write(new FigletText("Choose your class:").Centered().Color(Color.Gray78));
        }
        public static void TopSpace(int value)
        {
            int topSpaceDesc = value;
            Console.SetCursorPosition(0, topSpaceDesc);
        }
    }
}
