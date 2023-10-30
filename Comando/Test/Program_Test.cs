//using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Text;
using Prueba_Tecnica;
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
        await Prueba_Tecnica.Program.Main(null);
        var result = output.ToString();

        // Assert
        Assert.IsTrue(result.Contains("Máquinas de corte disponibles (2D):"));
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
        await Prueba_Tecnica.Program.Main(null);
        var result = output.ToString();

        // Assert
        Assert.IsTrue(result.Contains("Máquinas de corte disponibles (3D):"));
    }

    [TestMethod]
    public async Task TestGetAllMachines()
    {
        // Arrange
        var input = "3\n"; // Simular entrada de usuario seleccionando 3D
        var output = new StringWriter();
        System.Console.SetIn(new StringReader(input));
        System.Console.SetOut(output);

        // Act
        await Prueba_Tecnica.Program.Main(null);
        var result = output.ToString();

        // Assert
        Assert.IsTrue(result.Contains("Máquinas de corte disponibles ():"));
    }


    [TestMethod]
    public async Task TestExit()
    {
        // Arrange
        var input = "3\n"; // Simular entrada de usuario seleccionando el exit
        var output = new StringWriter();
        System.Console.SetIn(new StringReader(input));
        System.Console.SetOut(output);

        // Act
        await Prueba_Tecnica.Program.Main(null);
        var result = output.ToString();

        // Assert
        Assert.IsTrue(result.Contains("Opción no válida. Se a producido un error"));
    }

    [TestMethod]
    public async Task TestInvalidChoice()
    {
        // Arrange
        var input = "hola\n"; // Simular entrada de usuario seleccionando opción no válida
        var output = new StringWriter();
        System.Console.SetIn(new StringReader(input));
        System.Console.SetOut(output);

        // Act
        await Prueba_Tecnica.Program.Main(null);
        var result = output.ToString();

        // Assert
        Assert.IsTrue(result.Contains("Opción no válida."));
    }
}


