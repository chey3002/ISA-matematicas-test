namespace test_math;

public class UnitTest1
{
    [Theory]
    [InlineData(2, 3, 5)]//Prueba con datos fijos
    [InlineData(4, 3, 7)]//Prueba con datos fijos
    [InlineData(8, 11, 19)]//Prueba con datos fijos
    [InlineData(1, 1, 2)]//Prueba con datos fijos
    [InlineData(212, 35, 247)]//Prueba con datos fijos

    public void Test1(int a, int b, int resultadoEsperado)
    {
        /// AAA
        /// Arange Act Assert

        /// Arange Prepara datos de entrada
        /// 
        int resutCalc;

        /// Act ejecuta
        resutCalc = Class1.suma(a, b);

        /// assert verifica 
        Assert.Equal(resultadoEsperado, resutCalc);

    }
}