using Angulation.Domain.Angulation;
using FluentAssertions;
using Xunit;

namespace Angulation.Domain.Tests.Angulation.Domain.Tests;

public class AngulationServiceTests
{
    [Fact]
    public void CheckRightAngleTriangle()
    {
        // Arrange
        var angulationService = new AngleCalculationSerice();
        var rightAngleTriangle = new TriangleModel();
        rightAngleTriangle.SideA = 5;
        rightAngleTriangle.SideB = 4;
        rightAngleTriangle.SideC = 3;

        // Act
        var result = angulationService.GetTriangleType(rightAngleTriangle);

        // Assert
        result.Should().Be(TriangleType.Right);
    }

    [Fact]
    public void CheckAcuteTriangle()
    {
        // Arrange
        var angulationService = new AngleCalculationSerice();
        var acuteTriangle = new TriangleModel();
        acuteTriangle.SideA = 5;
        acuteTriangle.SideB = 10;
        acuteTriangle.SideC = 10;

        // Act
        var result = angulationService.GetTriangleType(acuteTriangle);

        // Assert
        result.Should().Be(TriangleType.Acute);
    }

    [Fact]
    public void CheckObtuseTriangle()
    {
        // Arrange
        var angulationService = new AngleCalculationSerice();
        var obtuseTriangle = new TriangleModel();
        obtuseTriangle.SideA = 6;
        obtuseTriangle.SideB = 4;
        obtuseTriangle.SideC = 3;

        // Act
        var result = angulationService.GetTriangleType(obtuseTriangle);

        // Assert
        result.Should().Be(TriangleType.Obtuse);
    }
}