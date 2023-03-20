using System;
using System.Threading;

namespace MazeBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем генератор лабиринта.
            MazeGame game = new MazeGame();

            // Стандартный строитель.
            StandardMazeBuilder builder = new StandardMazeBuilder();

            // Создаем лабиринт из двух комнат используя фабричный метод - CreateMaze().
            Maze maze = game.CreateComplexMaze(builder);

            // Также можно получить лаиринт от строителя напрямую.
            //maze = builder.GetMaze();

            // Генератор псевдослучайных последовательностей.
            Random random = new Random();

            // Попадаем в лабиринт, выбирая комнату случайным образом.
            Room room = maze.RoomNo(random.Next(1, 1001));

            // Выбранная сторона.
            MapSite site = null;

            site = room.GetSide(Direction.North);
            Console.Write("Я в комнате {0}. Делаю шаг вверх ", room.RoomNumber);
            site.Enter();
            if (site is Door) // Если дверь, то перейти в другую комнату.
            {
                Door door = (Door)site;
                // Переход в другую комнату (Получение ссылки на новую комнату).
                room = door.OtherSideFrom(room);
            }

            site = room.GetSide(Direction.East);
            Console.Write("Я в комнате {0}. Делаю шаг вправо ", room.RoomNumber);
            site.Enter();
            if (site is Door) // Если дверь, то перейти в другую комнату.
            {
                Door door = (Door)site;
                // Переход в другую комнату (Получение ссылки на новую комнату).
                room = door.OtherSideFrom(room);
            }

            site = room.GetSide(Direction.South);
            Console.Write("Я в комнате {0}. Делаю шаг вниз ", room.RoomNumber);
            site.Enter();
            if (site is Door) // Если дверь, то перейти в другую комнату.
            {
                Door door = (Door)site;
                // Переход в другую комнату (Получение ссылки на новую комнату).
                room = door.OtherSideFrom(room);
            }

            site = room.GetSide(Direction.West);
            Console.Write("Я в комнате {0}. Делаю шаг влево ", room.RoomNumber);
            site.Enter();
            if (site is Door) // Если дверь, то перейти в другую комнату.
            {
                Door door = (Door)site;
                // Переход в другую комнату (Получение ссылки на новую комнату).
                room = door.OtherSideFrom(room);
            }

            site = room.GetSide(Direction.North);
            Console.Write("Я в комнате {0}. Делаю шаг вверх ", room.RoomNumber);
            site.Enter();
            if (site is Door) // Если дверь, то перейти в другую комнату.
            {
                Door door = (Door)site;
                // Переход в другую комнату (Получение ссылки на новую комнату).
                room = door.OtherSideFrom(room);
            }
        }
    }
}

