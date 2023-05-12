namespace health_calc_pack_dotnet_test;

using health_calc_pack_dotnet_o3.Interfaces;
using health_calc_pack_dotnet_o3;

public class UnitTest1
{
    [Fact]
    public void CalculaIMC_QuandoDadosValidos_EntaoRetornaIndice()
    {
      IIMC imc = new IMC();
      double Height = 1.70;
      double Weight = 88.3;
      double ExpectedIMC = 30.55;

      var result = imc.Calc(Height, Weight);

      Assert.Equal(ExpectedIMC, result);
    }

    [Fact]
    public void ValidaDadosIMC_QuandoDadosValidos_EntaoRetornaVerdadeiro()
    {
      IIMC imc = new IMC();
      double Height = 10.00;
      double Weight = 400;
      bool Expected = false;

      var result = imc.IsValidDate(Height, Weight);

      Assert.Equal(Expected, result);
    }

    [Fact]
    public void ValidaDadosIMC_QuandoDadosValidos_EntaoRetornaDescricao()
    {
      IIMC imc = new IMC();
      double ValorIMC = 30.55;
      string Expected = "OBESIDADE";

      var result = imc.GetIMCCategory(ValorIMC);

      Assert.Equal(Expected, result);
    }
}