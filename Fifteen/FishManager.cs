using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifteen
{
    class FishManager
    {
        #region Singleton
        private static FishManager instance;

        public static FishManager GetInstance(Int32 side)
        {
            if (instance == null)
            {
                instance = new FishManager(side);
            }
            return instance;
        }

        private FishManager(Int32 side)
        {
            fishes = new List<Fish>();
            Int32 value = 1;
            for (Int32 j = 0; j < side; j++)
            {
                for (Int32 i = 0; i < side; i++)
                {
                    fishes.Add(new Fish(value, i, j));
                    value++;
                }
            }

            HandleLastFish();
            AppointNeighbors();
        }
        #endregion

        private List<Fish> fishes;

        public List<Fish> Fishes
        {
            get
            {
                return fishes;
            }
        }

        private void HandleLastFish()
        {
            Fish.EmptyField = fishes[fishes.Count - 1];
        }

        public void Move(Coordinates location)
        {
            Fish fish = fishes.Find(x => x.Location.Equals(location));

            if (fish != null)
            {
                switch (fish.EmptyTo)
                {
                    case EmptyFish.Left:
                        fish.Location.X--;
                        Fish.EmptyField.Location.X++;
                        break;
                    case EmptyFish.Right:
                        fish.Location.X++;
                        Fish.EmptyField.Location.X--;
                        break;
                    case EmptyFish.Up:
                        fish.Location.Y--;
                        Fish.EmptyField.Location.Y++;
                        break;
                    case EmptyFish.Down:
                        fish.Location.Y++;
                        Fish.EmptyField.Location.Y--;
                        break;
                    default:
                        //
                        //  ToDo: Logger.Error
                        //
                        break;
                }
            }
            AppointNeighbors();
        }

        private void AppointNeighbors()
        {
            /*
             * Set all neighbor relations to "none".
             * Have chosen this kind of deleting relations because
             * a - you can search by delegate, but it uses more acts
             * b - you can save links to neighbors in each fish, 
             *       but the code becomes difficult to read and edit
             * */
            foreach (Fish f in fishes)
            {
                f.EmptyTo = EmptyFish.none;
            }

            /*
             * But in this case search by delegate is the only way
             * */
            Fish fish;

            fish = fishes.Find(f =>
                            f.Location.X == Fish.EmptyField.Location.X - 1 &&
                            f.Location.Y == Fish.EmptyField.Location.Y);
            if (fish != null)
            {
                fish.EmptyTo = EmptyFish.Right;
                fish = null;
            }

            fish = fishes.Find(f =>
                            f.Location.X == Fish.EmptyField.Location.X + 1 &&
                            f.Location.Y == Fish.EmptyField.Location.Y);
            if (fish != null)
            {
                fish.EmptyTo = EmptyFish.Left;
                fish = null;
            }

            fish = fishes.Find(f =>
                            f.Location.X == Fish.EmptyField.Location.X &&
                            f.Location.Y == Fish.EmptyField.Location.Y - 1);
            if (fish != null)
            {
                fish.EmptyTo = EmptyFish.Down;
                fish = null;
            }

            fish = fishes.Find(f =>
                            f.Location.X == Fish.EmptyField.Location.X&&
                            f.Location.Y == Fish.EmptyField.Location.Y + 1);
            if (fish != null)
            {
                fish.EmptyTo = EmptyFish.Up;
                fish = null;
            }
        }
    }
}
