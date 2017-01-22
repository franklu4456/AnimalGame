using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalGame
{
    public partial class Form1 : Form
    {
        World theWorld;

        Size tileSize;

        Player p1;

        bool canPlayerMove = false;
        bool inBattle = false;

        public Form1()
        {
            InitializeComponent();
            World theWorld = new World();

            p1 = new Player(Direction.Up);
        }

        bool windowOpen = false;
        bool interact = false;
        bool attack1 = false;
        bool attack2 = false;
        bool attack3 = false;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (canPlayerMove == true)
            {
                if (e.KeyCode == Keys.Up)
                {
                    //move forward
                    theWorld.Move(p1);
                }
                else if (e.KeyCode == Keys.Left)
                {
                    //rotate left
                    p1.RotateLeft();
                }
                else if (e.KeyCode == Keys.Right)
                {
                    //rotate right
                    p1.RotateRight();
                }
                else if (e.KeyCode == Keys.O)
                {
                    //open inventory
                    if (canPlayerMove == true)
                    {
                        windowOpen = true;

                    }
                }
                else if (e.KeyCode == Keys.F)
                {
                    if (canPlayerMove == true)
                    {
                        //interact with a tile
                    }
                }
                else if (e.KeyCode == Keys.Q)
                {
                    if (inBattle == true)
                    {
                        //allows the player to pick attack 1 when in battle
                        attack1 = true;
                    }
                }
                else if (e.KeyCode == Keys.W)
                {
                    if (inBattle == true)
                    {
                        //allows the player to pick attack 2 in battle
                        attack2 = true;
                    }
                }
                else if (e.KeyCode == Keys.E)
                {
                    if (inBattle == true)
                    {
                        //allows the player to pick attack 3 in battle
                        attack3 = true;
                    }
                }
                else if (e.KeyCode == Keys.S)
                {
                    //save the game
                    theWorld.SaveGame(p1);
                }
                else if (e.KeyCode == Keys.Escape)
                {
                    //close the current window 

                    
                }
            }
        }

        public void Interact()
        {
            if (theWorld.TileInFront(p1) == MapTile.Enemy) 
            {

            }
            else if (theWorld.TileInFront(p1) == MapTile.Shop)
            {

            }
            else if (theWorld.TileInFront(p1) == MapTile.HealStn)
            {

            }
            else if (theWorld.TileInFront(p1) == MapTile.Animal)
            {

            }
        }
    }

}
