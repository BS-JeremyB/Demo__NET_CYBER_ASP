using Demo__NET_CYBER_ASP.Models;

namespace Demo__NET_CYBER_ASP.Data
{
    public class GameData
    {
        private static GameData _instance;
        private List<Game> _gameList;


        public GameData()
        {
            
            _gameList = new List<Game>
            {
                new Game {Id= 1, Title = "Counter-Strike", Release= 2023, Category = "FPS", Description = "Pan Pan" },
                new Game {Id= 2,Title = "Rocket League", Release = 2015, Category = "Racing", Description = "Vroom Vroom"}
            };
        }

        public static GameData Instance {
            get
            {
                if (_instance == null)
                {
                    _instance = new GameData();
                }
                return _instance;
            }
        }


        public List<Game> Get()
        {
            return _gameList;
        }



    }
}
