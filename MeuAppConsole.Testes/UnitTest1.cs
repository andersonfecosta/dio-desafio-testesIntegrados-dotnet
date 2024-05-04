using MeuAppConsole;

namespace MeuAppConsole.Testes;

public class UnitTest1
{
    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(4, 5, 9)]
    public void TestSomar(int val1, int val2, int resultado)   
    {
        Calculadora calculadora = new Calculadora(); 

        int resultadoCalculadora = calculadora.Somar(val1,val2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData(2, 1, 1)]
    [InlineData(5, 4, 1)]
    public void TestSubtrair(int val1, int val2, int resultado)   
    {
        Calculadora calculadora = new Calculadora(); 

        int resultadoCalculadora = calculadora.Subtrair(val1,val2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData(1, 2, 2)]
    [InlineData(4, 5, 20)]
    public void TestMultiplicar(int val1, int val2, int resultado)   
    {
        Calculadora calculadora = new Calculadora(); 

        int resultadoCalculadora = calculadora.Multiplicar(val1,val2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData(2, 1, 2)]
    [InlineData(4, 2, 2)]
    public void TestDividir(int val1, int val2, int resultado)   
    {
        Calculadora calculadora = new Calculadora(); 

        int resultadoCalculadora = calculadora.Dividir(val1,val2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Fact]
    public void TestarDivisaoPorZero()
    {
        Calculadora calculadora = new Calculadora();

        Assert.Throws<DivideByZeroException>(
            () => calculadora.Dividir(3,0));
    }

    [Fact]
    public void TestarHistorico()
    {
        Calculadora calculadora = new Calculadora();
        calculadora.Somar(1,2);
        calculadora.Somar(15,42);
        calculadora.Somar(12,42);
        calculadora.Somar(1,20);

        var lista = calculadora.Historico();

        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }
}