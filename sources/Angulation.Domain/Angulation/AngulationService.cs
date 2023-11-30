namespace Angulation.Domain.Angulation;

public class AngleCalculationSerice : IAngulationService
{
    private const double RightAngleCalculationAccuracy = 0.001;

    public TriangleType GetTriangleType(TriangleModel triangle)
    {
        var maxSide = Math.Max(triangle.SideA, Math.Max(triangle.SideB, triangle.SideC));

        if (maxSide > triangle.SideA + triangle.SideB + triangle.SideC - maxSide)
            throw new Exception("Данные отрезки не могут образовать треугольник");

        var angles = GetAngles(triangle.SideA, triangle.SideB, triangle.SideC);

        if (angles.Any(x => Math.Abs(x - 90.0) < RightAngleCalculationAccuracy))
            return TriangleType.Right;
        if (angles.Any(x => x > 90.0))
            return TriangleType.Obtuse;

        return TriangleType.Acute;
    }

    private IReadOnlyCollection<double> GetAngles(double a, double b, double c)
    {
        var aSquare = a * a;
        var bSquare = b * b;
        var cSquare = c * c;

        var cosA = Math.Acos((bSquare + cSquare - aSquare) / (2 * b * c));
        var cosB = Math.Acos((aSquare + cSquare - bSquare) / (2 * a * c));
        var cosC = Math.Acos((bSquare + aSquare - cSquare) / (2 * b * a));

        var degreesA = (180 / Math.PI) * cosA;
        var degreesB = (180 / Math.PI) * cosB;
        var degreesC = (180 / Math.PI) * cosC;

        double[] result = [degreesA, degreesB, degreesC];

        return result;
    }
}