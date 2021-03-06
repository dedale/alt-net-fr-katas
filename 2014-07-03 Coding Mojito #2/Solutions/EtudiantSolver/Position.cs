namespace EtudiantSolver
{
    public class Position
    {
        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="T:System.Object" />.
        /// </summary>
        public Position(int x, int y, bool intersection)
        {
            this.X = x;
            this.Y = y;
        }

        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="T:System.Object" />.
        /// </summary>
        public Position(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int X { get; private set; }
        public int Y { get; private set; }

        public bool IsEqual(Position position)
        {
            return position != null && (this.X == position.X && this.Y == position.Y);
        }
    }
}