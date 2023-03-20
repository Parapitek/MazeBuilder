using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeBuilder
{
    class MazeGame
    {
        // Метод CreateMaze - создает лабиринт из двух комнат с одной дверью между комнатами.    

        // Использует Строителя.   (НОВЫЙ ВАРИАНТ)
        // Строитель скрывает внутреннее представление лабиринта, то есть классы комнат, дверей и стен,
        // а так-же скрывает то, как эти части собираются вместе для завершения построения лабиринта.
        // За счет этого становится проще модифицировать способ представления лабиринта, поскольку
        // ниодного из клиентов MazeBuilder изменять не надо.
        // MazeBuilder - можно повторно использовать для построения лабиринтов разных видов.
        public Maze CreateMaze(MazeBuilder builder)
        {
            builder.BuildMaze();
            builder.BuildRoom(1);
            builder.BuildRoom(2);
            builder.BuildDoor(1, 2);

            // Возвращает готовый продукт (Лабиринт)
            return builder.GetMaze();
        }

        public Maze CreateComplexMaze(MazeBuilder builder)
        {
            builder.BuildMaze();
            // Построение 1001-й комнаты.
            for (int i = 0; i < 1001; i++)
            {
                builder.BuildRoom(i + 1);
            }

            
            
            for (int i = 1; i < 1000; i++)
            {
                builder.BuildDoor(i, i + 1);
            }
            

            return builder.GetMaze();
        }
    }
}
