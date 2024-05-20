namespace GameStateHistory
{
    enum GameState
    {
        MainMenu,
        Level1,
        Level2,
        Level3,
        Settings,
        Quit
    }

    class Program
    {
        static TurboLinkedStack<GameState> stateHistory = new TurboLinkedStack<GameState>();
        static TurboLinkedStack<GameState> forwardHistory = new TurboLinkedStack<GameState>();

        static void Main(string[] args)
        {
            stateHistory.Push(GameState.MainMenu);
            while (true)
            {
                var currentState = stateHistory.Peek();
                Console.Clear();
                Console.WriteLine($"You are here: {currentState}");
                switch (currentState)
                {
                    case GameState.MainMenu:
                        ShowMainMenu();
                        break;
                    case GameState.Level1:
                        ShowLevelMenu(1, GameState.Level2);
                        break;
                    case GameState.Level2:
                        ShowLevelMenu(2, GameState.Level3);
                        break;
                    case GameState.Level3:
                        ShowLevelMenu(3, GameState.MainMenu); // Last level, goes back to MainMenu
                        break;
                    case GameState.Settings:
                        ShowSettingsMenu();
                        break;
                    case GameState.Quit:
                        return;
                }
            }
        }

        static void ShowMainMenu()
        {
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("(0): Go to Level 1");
            Console.WriteLine("(1): Go to Settings");
            Console.WriteLine("(q): Quit");
            if (stateHistory.Count > 1) Console.WriteLine("(b): Go back");

            var input = Console.ReadLine();
            HandleInput(input, GameState.Level1, GameState.Settings, GameState.Quit);
        }

        static void ShowLevelMenu(int level, GameState nextLevel)
        {
            Console.WriteLine("What do you want to do?");
            Console.WriteLine($"(0): Go to Level {level + 1}");
            Console.WriteLine("(1): Go to Main Menu");
            if (stateHistory.Count > 1) Console.WriteLine("(b): Go back");

            var input = Console.ReadLine();
            HandleInput(input, nextLevel, GameState.MainMenu, null);
        }

        static void ShowSettingsMenu()
        {
            Console.WriteLine("You are in Settings. Press any key to return to the Main Menu.");
            Console.ReadKey();
            GoBack();
        }

        static void HandleInput(string input, GameState option0, GameState option1, GameState? option2)
        {
            switch (input)
            {
                case "0":
                    ChangeState(option0);
                    break;
                case "1":
                    ChangeState(option1);
                    break;
                case "q":
                    if (option2.HasValue) ChangeState(option2.Value);
                    break;
                case "b":
                    GoBack();
                    break;
                default:
                    Console.WriteLine("Invalid input. Try again.");
                    break;
            }
        }

        static void ChangeState(GameState newState)
        {
            stateHistory.Push(newState);
            forwardHistory.Clear(); // Clear forward history whenever a new state is pushed
        }

        static void GoBack()
        {
            if (stateHistory.Count > 1)
            {
                var currentState = stateHistory.Pop();
                forwardHistory.Push(currentState);
            }
        }
    }
}
