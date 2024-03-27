using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Philosophers
{
    public partial class Form1 : Form
    {
        static Semaphore[] forks = new Semaphore[5];
        Philosopher[] philosophers = new Philosopher[5];
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            InitializeSemaphores();
            InitializePhilosophers();

            BW_UpdateForm.RunWorkerAsync();
        }

        private void InitializeSemaphores()
        {
            for (int i = 0; i < 5; i++)
            {
                forks[i] = new Semaphore(1, 1);
            }
        }

        private void InitializePhilosophers()
        {
            philosophers[0] = new Philosopher(0, 4, 0, PB_Fork4, PB_Fork0, PB_Plate0, LBL_Philosopher0, forks, LB_Info);
            philosophers[1] = new Philosopher(1, 0, 1, PB_Fork0, PB_Fork1, PB_Plate1, LBL_Philosopher1, forks, LB_Info);
            philosophers[2] = new Philosopher(2, 1, 2, PB_Fork1, PB_Fork2, PB_Plate2, LBL_Philosopher2, forks, LB_Info);
            philosophers[3] = new Philosopher(3, 2, 3, PB_Fork2, PB_Fork3, PB_Plate3, LBL_Philosopher3, forks, LB_Info);
            philosophers[4] = new Philosopher(4, 3, 4, PB_Fork3, PB_Fork4, PB_Plate4, LBL_Philosopher4, forks, LB_Info);

            this.Refresh();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                new Thread(StartWorking).Start(i);
            }
        }

        private void StartWorking(object index)
        {
            int i = (int)index;

            while (philosophers[i].getMeals() < 6)
            {
                int forkOne = i;
                int forkTwo = (i == 0 ? 4 : i - 1);

                bool isForkOneAvailable = forks[forkOne].WaitOne(2500);
                bool isForkTwoAvailable = forks[forkTwo].WaitOne(2500);

                if (isForkOneAvailable && isForkTwoAvailable)
                {
                    int waitTime = random.Next(1, 2);

                    philosophers[i].changeState('E');
                    Thread.Sleep(waitTime * 2500);
                    philosophers[i].addMeal();
                    BW_UpdateForm.ReportProgress((i * 10) + philosophers[i].getMeals());
                    philosophers[i].changeState('W');
                }

                if (isForkOneAvailable)
                {
                    forks[forkOne].Release();
                }

                if (isForkTwoAvailable)
                {
                    forks[forkTwo].Release();
                }
            }

            //  Salida cuando todos los filósofos hayan comido al menos 6 veces
            if (philosophers.All(p => p.getMeals() >= 6))
            {
                MessageBox.Show("Todos los filósofos han comido al menos 6 veces");
                Application.Exit();
            }


        }

        private void BW_UpdateForm_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int philosopher = (e.ProgressPercentage % 100) / 10;
            philosophers[philosopher].updateMeals();
        }

        private void BW_UpdateForm_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {

            }
        }

    }
}
