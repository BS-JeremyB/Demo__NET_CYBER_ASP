using Demo__NET_CYBER_ASP.Models;

namespace Demo__NET_CYBER_ASP.Data
{
    public class GameData
    {
        private static GameData _instance;
        private List<Game> _gameList;
        private static int GameId = 3;


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


        public Game? GetById(int id)
        {

            return _gameList.FirstOrDefault(g => g.Id == id);
        }


        public void Edit(Game game)
        {
            Game gameToUpdate = GetById(game.Id);

            if(gameToUpdate is not null) 
            {
                gameToUpdate.Title = game.Title;
                gameToUpdate.Release = game.Release;
                gameToUpdate.Category = game.Category;
                gameToUpdate.Description = game.Description;
            }


        }

        public void Add(Game game)
        {
            game.Id = GameId++;
            _gameList.Add(game);
        }


        public void Delete(int id)
        {
            _gameList.Remove(GetById(id));
        }
    }
}
