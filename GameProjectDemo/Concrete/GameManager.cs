using GameProjectDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.Name + " adlı oyun başarıyla eklendi !");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.Name + " adlı oyun silindi !");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.Name + " adlı oyun başarıyla güncellendi !");
        }
    }
}
