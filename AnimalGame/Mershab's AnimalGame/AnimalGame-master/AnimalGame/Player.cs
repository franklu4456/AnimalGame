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

        public Player(Direction direction)
        {
            _facingDirection = direction;
        }

        public Item Items
        {
            get
            {

            }
            set
            {

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
                return _money;
            }
            set
            {
                _money = 
            }
        }

        public void OpenInventory()
        {
            // ?something like that
            //pnlInventoy.Visible = true;
        }

        public bool Interact(MapTile tile)
        {
            if (tile == MapTile.Enemy || tile == MapTile.Boss)
            {

            }
            else if (tile == MapTile.Shop)
            {
                // ?
                //pnlShop.Visible = true;
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

        public bool Move(MapTile tile)
        {
            if (tile != MapTile.Wall && tile != MapTile.Enemy && tile != MapTile.Boss && tile != MapTile.Shop && tile != MapTile.HealStn)
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
        public void RotateLeft(Direction facingDirection)
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

        public void RotateRight(Direction facingDirection)
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
