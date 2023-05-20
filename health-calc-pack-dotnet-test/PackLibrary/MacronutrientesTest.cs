using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

using health_calc_pack_dotnet_o3.Interfaces;
using health_calc_pack_dotnet_o3;
using health_calc_pack_dotnet_o3.models;
using health_calc_pack_dotnet_o3.enums;
using health_calc_pack_dotnet_o3.MacronutrientesStrategies;

namespace health_calc_pack_dotnet_test.PackLibrary
{
    public class MacronutrientesTest
    {
      [Theory]
      [InlineData(ObjetivoFisicoEnum.PerdaPeso)]
      [InlineData(ObjetivoFisicoEnum.ManterPeso)]
      [InlineData(ObjetivoFisicoEnum.GanhoMassaMuscular)]
      public void CalcularMacronutrientes_QuandoDadosValidos_EntaoRetornaMacronutrientes(ObjetivoFisicoEnum ObjetivoFisico)
      {
          IMacronutrientes macronutrientes = new Macronutrientes();
          double Weight = 88.8;
          MacronutrientesModel Expected = new MacronutrientesModel();

          if (ObjetivoFisico == ObjetivoFisicoEnum.PerdaPeso) {
            Expected.Carboidratos = 266.4;
            Expected.Proteinas = 355.2;
            Expected.Gorduras = 266.4;
          } else if (ObjetivoFisico == ObjetivoFisicoEnum.ManterPeso) {
            Expected.Carboidratos = 355.2;
            Expected.Proteinas = 355.2;
            Expected.Gorduras = 88.8;
          } else if (ObjetivoFisico == ObjetivoFisicoEnum.GanhoMassaMuscular) {
            Expected.Carboidratos = 355.2;
            Expected.Proteinas = 177.6;
            Expected.Gorduras = 88.8;
          }

          var result = macronutrientes.CalcularMacronutrientes(ObjetivoFisico, Weight);

          Assert.Equivalent(Expected, result);
      }

      [Theory]
      [InlineData(ObjetivoFisicoEnum.PerdaPeso)]
      [InlineData(ObjetivoFisicoEnum.ManterPeso)]
      [InlineData(ObjetivoFisicoEnum.GanhoMassaMuscular)]
      public void CalcularMacronutrientes_QuandoDadosValidos_EntaoRetornaMacronutrientes_Strategy(ObjetivoFisicoEnum ObjetivoFisico)
      {
          MacronutrientesContext context = new();
          double Weight = 88.8;
          MacronutrientesModel Expected = new MacronutrientesModel();

          if (ObjetivoFisico == ObjetivoFisicoEnum.PerdaPeso) {
            context.setStrategy(new PerderPesoStrategy());

            Expected.Carboidratos = 266.4;
            Expected.Proteinas = 355.2;
            Expected.Gorduras = 266.4;
          } else if (ObjetivoFisico == ObjetivoFisicoEnum.ManterPeso) {
            context.setStrategy(new ManterPesoStrategy());

            Expected.Carboidratos = 355.2;
            Expected.Proteinas = 355.2;
            Expected.Gorduras = 88.8;
          } else if (ObjetivoFisico == ObjetivoFisicoEnum.GanhoMassaMuscular) {
            context.setStrategy(new GanharMassaStrategy());

            Expected.Carboidratos = 355.2;
            Expected.Proteinas = 177.6;
            Expected.Gorduras = 88.8;
          }

          var result = context.ExecuteStrategy(Weight);

          Assert.Equivalent(Expected, result);
      }
    }
}