using System;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Text.Json;
using System.Threading;
using System.Threading.Channels;

namespace Console_Dungeon
{
    class Program
    {
        static ConsoleTools consoleTools = new ConsoleTools();
        static Texts texts = new Texts();
        static Dungeon dungeon = new Dungeon();
        static Player player = new Player();
        static string saveGameLocal = @"c:\Temp\mySaveFile.json";

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
                    RestoreSalveGame();
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

                if (optionSelected != Controls.invalid || optionSelected != Controls.quit || optionSelected != Controls.savegame)
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
            consoleTools.ShowMessageToUser(texts.passBlocked);
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
                consoleTools.ShowMessageToUser(texts.introGame);                        
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
            string jsonString = JsonSerializer.Serialize(player);
            File.WriteAllText(saveGameLocal, jsonString);                   
            consoleTools.ShowMessageToUser(texts.savedGame, ConsoleColor.Green);
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
            consoleTools.ShowMessageToUser(texts.explainGame, ConsoleColor.Yellow);
            Thread.Sleep(2000);
        }                         

        private static bool AskAboutLoadSave()
        {
            do
            {
                consoleTools.ShowMessageToUser(texts.askAboutSaveGame);
                consoleTools.ShowMessageToUser(texts.yesOrNot);
                if (consoleTools.ReadKey() == ConsoleKey.Y)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            } while (consoleTools.ReadKey() != ConsoleKey.Y || consoleTools.ReadKey() != ConsoleKey.N);                        
        }

        private static void RestoreSalveGame()
        {
            string jsonString = File.ReadAllText(@"c:\Temp\mySaveFile.json");
            Player loadPlayer = JsonSerializer.Deserialize<Player>(jsonString);
            player.hasKey = loadPlayer.hasKey;
            player.hasSword = loadPlayer.hasSword;
            player.life = loadPlayer.life;            

            consoleTools.ShowMessageToUser(texts.saveRestored, ConsoleColor.Green);
        }

        private static bool HasSaveGame()
        {
            if (File.Exists(saveGameLocal))
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