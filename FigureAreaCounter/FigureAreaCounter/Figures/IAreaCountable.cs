namespace FigureAreaCounter.Figures
{
    /// <summary>
    /// Decided to use interface instead of base abstract class
    /// because circle and triangle have only one common method and have no common attributes
    /// </summary>
    public interface IAreaCountable
    {
        public double CountArea();
    }
}
