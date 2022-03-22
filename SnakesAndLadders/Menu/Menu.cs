namespace SnakesAndLadders.Menu
{
    public class Menu
    {
        public Menu(List<Option> options, string text)
        {
            Options = options;
            Options.Add(new Option("Salir", () => Environment.Exit(0)));
            Text = text;
        }
        public List<Option> Options = new();
        public string Text { get; set; }

        private static void ShowDivider()
        {
            string separator = new('-', 75);
            Console.WriteLine(separator);
        }
        private static void ShowAsTittle(string text)
        {
            ShowDivider();
            Console.WriteLine($"\t{text}");
            ShowDivider();
        }
        
        public void WriteMenu(Option selectedOption)
        {
            Console.Clear();
            ShowAsTittle(Text);
            Console.WriteLine("    Selecciona una opción: ");
            foreach (Option option in Options)
            {
                string marker = option == selectedOption ? "> -" : "-";
                Console.WriteLine($"\t\t{marker} {option.Name}");
            }
            ShowDivider();
        }

        public void Run()
        {
            int index = 0;
            bool enterAgain = false;
            WriteMenu(Options[index]);

            ConsoleKeyInfo keyinfo;
            do
            {
                keyinfo = Console.ReadKey();

                if ((keyinfo.Key == ConsoleKey.DownArrow) && (index + 1 < Options.Count))
                {
                    enterAgain = false;
                    WriteMenu(Options[++index]);
                }
                else if ((keyinfo.Key == ConsoleKey.UpArrow) && (index - 1 >= 0))
                {
                    enterAgain = false;
                    WriteMenu(Options[--index]);
                }
                else if (keyinfo.Key == ConsoleKey.Enter && !enterAgain)
                {
                    enterAgain = true;
                    Console.Clear();
                    Console.WriteLine();
                    ShowAsTittle($"Opción seleccionada: '{ Options[index].Name}'");
                    Console.WriteLine();
                    Options[index].Selected.Invoke();
                    ShowDivider();
                    Thread.Sleep(1500);
                    index = 0;
                    Console.WriteLine("Presiona cualquier tecla para continuar...");
                }
                else
                {
                    enterAgain = false;
                    WriteMenu(Options[index]);
                }
            }
            while (keyinfo.Key != ConsoleKey.X);

            Console.ReadKey();

        }
    }
}
