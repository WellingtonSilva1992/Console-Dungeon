using System;
using System.IO;
using System.Threading.Channels;

namespace Console_Dungeon
{
    class Program
    {
        static ConsoleTools consoleTools = new ConsoleTools();
        static Texts texts = new Texts();
        static Dungeon dungeon = new Dungeon();
        static Player player = new Player();

        enum Controls
        {
            north,
            south,
            west,
            east,
            quit,
            savegame,
            invalid
        }

        public static void Main(string[] args)
        {            

            ShowGameIntro();

            if (HasSaveGame())
            {
                bool answer = AskAboutLoadSave();

                if (answer)
                {
                    RecoverInfo();
                }
            }

            InitGameMessage();

            RunGame();
        }

        private static void RunGame()
        {
            bool winGame = false;
            Controls optionSelected;

            while (player.life > 0 || winGame == true || consoleTools.ReadKey() == ConsoleKey.Z)
            {                
                //decisão tomada com base no fluxo de jogo, onde o jogador executa a ação e é notificado das consequências
                ShowPlayerOptions();
                optionSelected = translateToOptionSelected(consoleTools.ReadKey());

                if (optionSelected != Controls.invalid || optionSelected != Controls.quit)
                {
                    bool moveIsPossible = CheckIfMoveIsPossible(optionSelected);

                    if (moveIsPossible)
                    {
                        MovePlayerPosition();
                        CheckPlayerEncounter();
                        SearchItensRoom();
                        if (MonsterMustMove())
                        {
                            MoveMonsterPosition();
                        }

                        NotifyGameStatus();
                    }
                    else
                    {
                        NotifyPlayerUnableToMove();
                    }
                }
                              
            }

            if (winGame)
            {
                ShowCongratulationsMessage();
            }
            else
            {
                ShowLoserMessage();
            }
        }

        private static void NotifyPlayerUnableToMove()
        {
            throw new NotImplementedException();
        }

        private static void ShowLoserMessage()
        {
            consoleTools.ShowMessageToUser(texts.loserMessage);
        }

        private static void ShowCongratulationsMessage()
        {
            consoleTools.ShowMessageToUser(texts.congratulationsMessage);
        }

        private static void ShowGameIntro()
        {
            try
            {
                consoleTools.ShowMessageToUser("teste");
            }
            catch (Exception e)
            {
                var erro = e.StackTrace;
                throw;
            }
                        
        }

        private static void NotifyGameStatus()
        {
            throw new NotImplementedException();
        }

        private static void ShowPlayerOptions()
        {
            consoleTools.ShowMessageToUser(texts.options);
        }

        private static bool MonsterMustMove()
        {
            throw new NotImplementedException();
        }

        private static void CheckPlayerEncounter()
        {
            throw new NotImplementedException();
        }

        private static void SearchItensRoom()
        {
            throw new NotImplementedException();
        }

        private static void MoveMonsterPosition()
        {
            throw new NotImplementedException();
        }

        private static void MovePlayerPosition()
        {
        }

        private static Controls translateToOptionSelected(ConsoleKey consoleKey)
        {
            switch (consoleKey)
            {
                case ConsoleKey.Escape:                    
                    SaveGame();
                    consoleTools.Close();
                    return Controls.quit;

                case ConsoleKey.Spacebar:
                    SaveGame();                    
                    return Controls.savegame;

                case ConsoleKey.LeftArrow:
                    return Controls.west;                    

                case ConsoleKey.UpArrow:
                    return Controls.north;
                    
                case ConsoleKey.RightArrow:
                    return Controls.east;
                    
                case ConsoleKey.DownArrow:
                    return Controls.south;
                    
                default:
                    consoleTools.ShowMessageToUser(texts.invalidaCommand);
                    return Controls.invalid;                    
            }
        }

        private static void SaveGame()
        {
            throw new NotImplementedException();
        }

        private static bool CheckIfMoveIsPossible(Controls optionSelected)
        {
            switch (optionSelected)
            {
                case Controls.north:
                    break;
                case Controls.south:
                    break;
                case Controls.west:
                    break;
                case Controls.east:
                    break;
            }

            var nextPlayerPosition = dungeon.playerPosition;
            throw new NotImplementedException();
        }

        private static void InitGameMessage()
        {
            consoleTools.ShowMessageToUser(texts.explaneGame);
        }

        private static void RecoverInfo()
        {
            RestoreSalveGame();
        }

        private static bool AskAboutLoadSave()
        {
            if (consoleTools.ReadKey() == ConsoleKey.Y)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        private static void RestoreSalveGame()
        {
            throw new NotImplementedException();
        }

        private static bool HasSaveGame()
        {
            if (File.Exists(@"C:\consoledungeon.txt"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}