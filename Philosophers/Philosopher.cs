using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Philosophers
{
    class Philosopher
    {
        int id = 0;
        int meals = 0;
        char state = 'W'; // W = Waiting, E = Eating

        int forkOne, forkTwo;
        Semaphore[] forks;

        //Form attributes
        Label box = null;
        ListBox listBox = null;
        Image forkLeftImg = null, forkRightImg = null;
        PictureBox forkLeft = null, forkRight = null;
        PictureBox plate = null;

        Color waitingColor = Color.FromName("Black");
        Color eatingColor = Color.FromName("Orange");

        public Philosopher(int id,
                            int forkOne,
                            int forkTwo,
                            PictureBox forkLeft,
                            PictureBox forkRight,
                            PictureBox plate,
                            Label box,
                            Semaphore[] forks,
                            ListBox listBox
        )
        {
            this.id = id;
            this.forkOne = forkOne;
            this.forkTwo = forkTwo;
            this.forkLeft = forkLeft;
            this.forkRight = forkRight;
            this.plate = plate;
            this.box = box;
            this.forks = forks;

            this.listBox = listBox;

            changeForksStateUI(false);
            changePhilosopherBoxStateUI(waitingColor);
            changePhilosopherPlateUI(false);
        }

        public int getID()
        {
           return this.id;
        } 
        public int getMeals()
        {
            return this.meals;
        }
        public void addMeal()
        {
            meals = meals + 1;
        }
        public char getState()
        {
            return this.state;
        }
        public void setState(char state)
        {
            this.state = state;
        }

        // Form //
        public void changeState(char state)
        {
            // W = Waiting, E = Eating

            switch (state)
            {
                case 'W':
                    changeForksStateUI(false);
                    changePhilosopherBoxStateUI(waitingColor);
                    changePhilosopherPlateUI(false);
                    break;
                case 'E':
                    changeForksStateUI(true);
                    changePhilosopherBoxStateUI(eatingColor);
                    changePhilosopherPlateUI(true);
                    break;
                default:
                    break;
            }
        }

        private void changeForksStateUI(bool active)
        {

            switch (id)
            {
                case 0:
                    forkLeftImg = active ? Philosophers.Properties.Resources.Fork4A : Philosophers.Properties.Resources.Fork4;
                    forkRightImg = active ? Philosophers.Properties.Resources.Fork0A : Philosophers.Properties.Resources.Fork0;
                    break;
                case 1:
                    forkLeftImg = active ? Philosophers.Properties.Resources.Fork0A : Philosophers.Properties.Resources.Fork0;
                    forkRightImg = active ? Philosophers.Properties.Resources.Fork1A : Philosophers.Properties.Resources.Fork1;
                    break;
                case 2:
                    forkLeftImg = active ? Philosophers.Properties.Resources.Fork1A : Philosophers.Properties.Resources.Fork1;
                    forkRightImg = active ? Philosophers.Properties.Resources.Fork2A : Philosophers.Properties.Resources.Fork2;
                    break;
                case 3:
                    forkLeftImg = active ? Philosophers.Properties.Resources.Fork2A : Philosophers.Properties.Resources.Fork2;
                    forkRightImg = active ? Philosophers.Properties.Resources.Fork3A : Philosophers.Properties.Resources.Fork3;
                    break;
                case 4:
                    forkLeftImg = active ? Philosophers.Properties.Resources.Fork3A : Philosophers.Properties.Resources.Fork3;
                    forkRightImg = active ? Philosophers.Properties.Resources.Fork4A : Philosophers.Properties.Resources.Fork4;
                    break;
            }

            this.forkLeft.Image = forkLeftImg;
            this.forkRight.Image = forkRightImg;
        }

        private void changePhilosopherBoxStateUI(Color color)
        {
            box.ForeColor = color;
        }

        private void changePhilosopherPlateUI(bool isEating)
        {
            plate.Image = isEating ? Philosophers.Properties.Resources.EatingPlate : Philosophers.Properties.Resources.WaitingPlate;
        }


        public void updateMeals()
        {
            listBox.Items[id] = ($"Filósofo {id + 1} Comidas: {meals}");
        }
    }
}
