using src;

namespace tests;

public class CalculadoraTestes
{
    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(3, 3, 6)]
    [InlineData(5, 5, 10)]
    public void SumTwoNumbersAndReturnResult(int n1, int n2, int result)
    {
        Calculadora calc = new Calculadora();

        int testResult = calc.Somar(n1, n2);

        Assert.Equal(result, testResult);
    }

    [Theory]
    [InlineData(1, 2, -1)]
    [InlineData(3, 3, 0)]
    [InlineData(5, 5, 0)]
    public void SubtractTwoNumbersAndReturnResult(int n1, int n2, int result)
    {
        Calculadora calc = new Calculadora();

        int testResult = calc.Subtrair(n1, n2);

        Assert.Equal(result, testResult);
    }

    [Theory]
    [InlineData(2, 1, 2)]
    [InlineData(3, 3, 1)]
    [InlineData(10, 2, 5)]
    public void DivideTwoNumbersAndReturnResult(int n1, int n2, int result)
    {
        Calculadora calc = new Calculadora();

        int testResult = calc.Dividir(n1, n2);

        Assert.Equal(result, testResult);
    }

    [Theory]
    [InlineData(1, 2, 2)]
    [InlineData(3, 3, 9)]
    [InlineData(5, 5, 25)]
    public void MultiplyTwoNumbersAndReturnResult(int n1, int n2, int result)
    {
        Calculadora calc = new Calculadora();

        int testResult = calc.Multiplicar(n1, n2);

        Assert.Equal(result, testResult);
    }

    [Fact]
    public void DivideByZeroTest()
    {
        Calculadora calc = new Calculadora();

        Assert.Throws<DivideByZeroException>(
            () => calc.Dividir(3, 0)
        );
    }

    [Fact]
    public void HistoryListTest()
    {
        Calculadora calc = new Calculadora();
        calc.Somar(1, 2);
        calc.Somar(1, 2);
        calc.Somar(1, 2);

        var lista = calc.ListarHistorico();

        Assert.NotEmpty(calc.ListarHistorico());
        Assert.Equal(3, lista.Count);
    }
}