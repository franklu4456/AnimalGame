using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalGame
{
    class Player
    {
        private int _row;
        private int _column;
        private bool _inBattle = false;
        private int _money;
        private Direction _facingDirection;
        private List<Animal> _roster;
        private List<Item> _items;
        private int _level;
        

        public Player(Direction direction)
        {
            _facingDirection = direction;
            Money = 1000;
            _column = 1;
            _row = 11;
            _level = 1;
        }
        public int Level
        {
            get
            {
                return _level;
            }
            set
            {
                _level = value;
            }
        }
        public List<Item> Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;
            }
 
        }

        public List<Animal> Roster
        {
            get
            {
                
                return _roster;
            }
            set
            {
                _roster = value;
            }
        }

        public int Row
        {
            get
            {
                return _row;
            }
        }

        public int Column
        {
            get
            {
                return _column;
            }
        }

        public int Money
        {
            get
            
            {
                if (_money < 0)
                {
                    _money = 0;
                }
                return _money;
            }
            set
            {
                _money = value;
            }
        }

        public bool Interact(MapTile tile)
        {
            if (tile == MapTile.Enemy)
            {

                return true;
            }
            else if (tile == MapTile.Shop)
            {

                return true;
            }
            else if (tile == MapTile.HealStn)
            {

                return true;
            }
            else
            {
                return false;
            }
        }

        public Direction FacingDirection
        {
            get
            {
                return _facingDirection;
            }
        }

        public bool Move(MapTile tile)
        {
            if (tile != MapTile.Wall && tile != MapTile.Enemy &&  tile != MapTile.Shop && tile != MapTile.HealStn)
            {
                if (_facingDirection == Direction.Up)
                {
                    _column--;
                }
                else if (_facingDirection == Direction.Down)
                {
                    _column++;
                }
                else if (_facingDirection == Direction.Right)
                {
                    _row++;
                }
                else if (_facingDirection == Direction.Left)
                {
                    _row--;
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        // Missed rotate left and right?
        public void RotateLeft()
        {
            if (_facingDirection == Direction.Up)
            {
                _facingDirection = Direction.Left;
            }
            else if (_facingDirection == Direction.Down)
            {
                _facingDirection = Direction.Right;
            }
            else if (_facingDirection == Direction.Right)
            {
                _facingDirection = Direction.Up;
            }
            else if (_facingDirection == Direction.Left)
            {
                _facingDirection = Direction.Down;
            }
        }

        public void RotateRight()
        {
            if (_facingDirection == Direction.Up)
            {
                _facingDirection = Direction.Right;
            }
            else if (_facingDirection == Direction.Down)
            {
                _facingDirection = Direction.Left;
            }
            else if (_facingDirection == Direction.Right)
            {
                _facingDirection = Direction.Down;
            }
            else if (_facingDirection == Direction.Left)
            {
                _facingDirection = Direction.Up;
            }
        }
    }
}
