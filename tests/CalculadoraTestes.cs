using src;

namespace tests;

public class CalculadoraTestes
{
    private Calculadora _calc;
    public CalculadoraTestes()
    {
        _calc = new Calculadora();
    }

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(3, 3, 6)]
    [InlineData(5, 5, 10)]
    public void SumTwoNumbersAndReturnResult(int n1, int n2, int result)
    {
        int testResult = _calc.Somar(n1, n2);
        Assert.Equal(result, testResult);
    }

    [Theory]
    [InlineData(1, 2, -1)]
    [InlineData(3, 3, 0)]
    [InlineData(5, 5, 0)]
    public void SubtractTwoNumbersAndReturnResult(int n1, int n2, int result)
    {
        int testResult = _calc.Subtrair(n1, n2);
        Assert.Equal(result, testResult);
    }

    [Theory]
    [InlineData(2, 1, 2)]
    [InlineData(3, 3, 1)]
    [InlineData(10, 2, 5)]
    public void DivideTwoNumbersAndReturnResult(int n1, int n2, int result)
    {
        int testResult = _calc.Dividir(n1, n2);
        Assert.Equal(result, testResult);
    }

    [Theory]
    [InlineData(1, 2, 2)]
    [InlineData(3, 3, 9)]
    [InlineData(5, 5, 25)]
    public void MultiplyTwoNumbersAndReturnResult(int n1, int n2, int result)
    {
        int testResult = _calc.Multiplicar(n1, n2);
        Assert.Equal(result, testResult);
    }

    [Fact]
    public void DivideByZeroTest()
    {
        Assert.Throws<DivideByZeroException>(
            () => _calc.Dividir(3, 0)
        );
    }

    [Fact]
    public void HistoryListTest()
    {
        _calc.Somar(1, 2);
        _calc.Somar(1, 2);
        _calc.Somar(1, 2);

        var lista = _calc.ListarHistorico(3);

        Assert.NotEmpty(_calc.ListarHistorico(3));
        Assert.Equal(3, lista.Count);
    }
}