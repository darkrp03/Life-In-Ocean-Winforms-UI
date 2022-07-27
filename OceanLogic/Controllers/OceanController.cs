using OceanLogic.Delegates;
using OceanLogic.GameObjects;

namespace OceanLogic.Controllers
{
    public class OceanController
    {
        #region Fields
        private readonly Ocean _ocean; //Object for manage business logic
        private PreyOrPredatorsDiedDelegate _preyOrPredadorsDied; //Delegate for event when prey or predators have died

        public event PreyOrPredatorsDiedDelegate OnPreyOrPredatorsDied //Event
        {
            add => _preyOrPredadorsDied += value;
            remove => _preyOrPredadorsDied -= value;
        }
        #endregion

        #region Ctor
        public OceanController(Ocean ocean)
        {
            _ocean = ocean;
        }
        #endregion

        #region Methods
        private void AddObstacle() //Add obstacles in ocean
        {
            for (int i = 0; i < _ocean.NumObstacles; i++)
            {
                var coordinate = _ocean.Direction.GetNullPosition();

                _ocean[coordinate.X, coordinate.Y] = new Obstacle();
            }
        }

        private void AddPredator() //Add predators in ocean
        {
            for (int i = 0; i < _ocean.NumPredators; i++)
            {
                var coordinate = _ocean.Direction.GetNullPosition();

                _ocean[coordinate.X, coordinate.Y] = new Shark(new Coordinate
                {
                    X = coordinate.X,
                    Y = coordinate.Y
                }, _ocean);
            }
        }

        private void AddPrey() //Add prey in ocean
        {
            for (int i = 0; i < _ocean.NumPrey; i++)
            {
                var coordinate = _ocean.Direction.GetNullPosition();

                _ocean[coordinate.X, coordinate.Y] = new Fish(new Coordinate
                {
                    X = coordinate.X,
                    Y = coordinate.Y
                }, _ocean);
            }
        }

        private void AddKillerWhale() //Add killer whales in ocean
        {
            for (int i = 0; i < _ocean.NumKillerWhales; i++)
            {
                var coordinate = _ocean.Direction.GetNullPosition();

                _ocean[coordinate.X, coordinate.Y] = new KillerWhale(new Coordinate
                {
                    X = coordinate.X,
                    Y = coordinate.Y
                }, _ocean);
            }
        }

        public void GenerateObjects()
        {
            AddPrey();
            AddPredator();
            AddKillerWhale();
            AddObstacle();
        }

        public void SetSettings(int numPrey, int numPredators, int numObstacles)
        {
            _ocean.NumPrey = numPrey;
            _ocean.NumPredators = numPredators;
            _ocean.NumObstacles = numObstacles;        
        }

        public void SetSettings(int numPrey, int numPredators, int numKillerWhales, int numObstacles, int numIterations)
        {
            _ocean.NumPrey = numPrey;
            _ocean.NumPredators = numPredators;
            _ocean.NumKillerWhales = numKillerWhales;
            _ocean.NumObstacles = numObstacles;
            _ocean.NumIterations = numIterations;
        }

        public void ResetGame() => _ocean.ResetSettings();

        public void Process()
        {
            if (_ocean.NumPrey <= 0 || _ocean.NumPredators <= 0)
            {
                _preyOrPredadorsDied?.Invoke();
                return;
            }

            _ocean.Run();
        }
        #endregion
    }
}
