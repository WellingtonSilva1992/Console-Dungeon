using System;

namespace Console_Dungeon
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleTools consoleTools = new ConsoleTools();            
            Dungeon dungeon = new Dungeon();
            Player player = new Player();            
            

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

            RunGame(player, dungeon);
        }

        private static void RunGame(Player player, Dungeon dungeon)
        {
            bool winGame = false;
            while (player.Life > 0 || winGame == true)
            {
                //decisão tomada com base em...
                ShowPlayerOptions();
                MovePlayerPosition(player.Position);
                CheckPlayerEncounter(player.Position, player.enemyPosition);                
                SearchItensRoom(dungeon.keyPosition, dungeon.swordPostion);
                
                if (MonsterMustMove())
                {
                    MoveMonsterPosition(player.enemyPosition);
                }
                
                NotifyGameStatus();
            }
        }

        private static void NotifyGameStatus()
        {
            throw new NotImplementedException();
        }

        private static void ShowPlayerOptions()
        {
            throw new NotImplementedException();
        }

        private static bool MonsterMustMove()
        {
            throw new NotImplementedException();
        }

        private static void CheckPlayerEncounter(int position, int enemyPosition)
        {
            throw new NotImplementedException();
        }

        private static void SearchItensRoom(int keyPosition, int swordPostion)
        {
            throw new NotImplementedException();
        }

        private static void MoveMonsterPosition(int enemyPosition)
        {
            throw new NotImplementedException();
        }

        private static void MovePlayerPosition(int position)
        {
            throw new NotImplementedException();
        }

        private static void InitGameMessage()
        {
            throw new NotImplementedException();
        }

        private static void RecoverInfo()
        {
            
        }

        private static void ShowGameIntro()
        {
            
        }

        private static bool AskAboutLoadSave()
        {
            return false;
        }

        private static bool HasSaveGame()
        {
            return false;
        }
        
    }
}