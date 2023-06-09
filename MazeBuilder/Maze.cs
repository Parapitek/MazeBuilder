﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeBuilder
{
    class Maze
    {
        Dictionary<int, Room> rooms = null;

        // Конструктор.
        public Maze()
        {
            // Создание массива комнат в лабиринте.
            this.rooms = new Dictionary<int, Room>();
        }

        // Методы.

        // Добавление комнат в лабиринт.
        public void AddRoom(Room room)
        {
            rooms.Add(room.RoomNumber, room);
        }

        // Возвращает ссылку на комнату.
        public Room RoomNo(int number)
        {
            return rooms[number];
        }
    }
}
