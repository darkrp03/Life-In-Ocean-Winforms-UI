using OceanLogic.Delegates;
using OceanLogic.GameObjects;

namespace OceanLogic.Controllers
{
    public class OceanController
    {
        #region Fields
        private readonly Ocean _ocean;
        private PreyOrPredatorsDiedDelegate preyOrPredadorsDied;

        public event PreyOrPredatorsDiedDelegate OnPreyOrPredatorsDied
        {
            add => preyOrPredadorsDied += value;
            remove => preyOrPredadorsDied -= value;
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

                _ocean[coordinate.X, coordinate.Y] = new Predator(new Coordinate
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

                _ocean[coordinate.X, coordinate.Y] = new Prey(new Coordinate
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
            AddObstacle();
        }

        public void SetSettings(int numPrey, int numPredators, int numObstacles)
        {
            _ocean.NumPrey = numPrey;
            _ocean.NumPredators = numPredators;
            _ocean.NumObstacles = numObstacles;        
        }

        public void SetSettings(int numPrey, int numPredators, int numObstacles, int numIterations)
        {
            _ocean.NumPrey = numPrey;
            _ocean.NumPredators = numPredators;
            _ocean.NumObstacles = numObstacles;
            _ocean.NumIterations = numIterations;
        }

        public void ResetGame() => _ocean.ResetSettings();

        public void Process()
        {
            if (_ocean.NumPrey <= 0 || _ocean.NumPredators <= 0)
            {
                preyOrPredadorsDied?.Invoke();
                return;
            }

            _ocean.Run();
        }
        #endregion
    }
}
