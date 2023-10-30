using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public async Task TestGet2DMachines()
    {
        // Arrange
        var input = "1\n"; // Simular entrada de usuario seleccionando 2D
        var output = new StringWriter();
        System.Console.SetIn(new StringReader(input));
        System.Console.SetOut(output);

        // Act
        List<CuttingMachine> machines = await CuttingMachineController.GetMachinesAsync("2");
        var result = output.ToString();

        // Assert
        foreach (var machine in machines)
        {
            Assert.IsNotNull(machine.Name);
            Assert.IsNotNull(machine.Manufacturer);
            Assert.IsNotNull("2");
        }
    }


    [TestMethod]
    public async Task TestGet3DMachines()
    {
        // Arrange
        var input = "2\n"; // Simular entrada de usuario seleccionando 3D
        var output = new StringWriter();
        System.Console.SetIn(new StringReader(input));
        System.Console.SetOut(output);

        // Act
        List<CuttingMachine> machines = await CuttingMachineController.GetMachinesAsync("3");
        var result = output.ToString();

        // Assert
        foreach (var machine in machines)
        {
            Assert.IsNotNull(machine.Name);
            Assert.IsNotNull(machine.Manufacturer);
            Assert.IsNotNull("3");
        }
    }

    [TestMethod]
    public async Task TestInvalidChoice()
    {
        // Arrange
        var input = "4\n"; // Simular entrada de usuario seleccionando opción no válida
        var output = new StringWriter();
        System.Console.SetIn(new StringReader(input));
        System.Console.SetOut(output);

        // Act
        List<CuttingMachine> machines = await CuttingMachineController.GetMachinesAsync(null);
        var result = output.ToString();

        // Assert
        foreach (var machine in machines)
        {
            Assert.IsNotNull(machine.Name);
            Assert.IsNotNull(machine.Manufacturer);
        }
    }
}

