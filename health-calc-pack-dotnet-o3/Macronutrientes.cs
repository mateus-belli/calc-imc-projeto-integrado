using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using health_calc_pack_dotnet_o3.enums;
using health_calc_pack_dotnet_o3.Interfaces;
using health_calc_pack_dotnet_o3.models;

namespace health_calc_pack_dotnet_o3
{
  public class Macronutrientes : IMacronutrientes
  {
    public MacronutrientesModel CalcularMacronutrientes(ObjetivoFisicoEnum ObjetivoFisico, double Peso)
    {
      if (ObjetivoFisico == ObjetivoFisicoEnum.PerdaPeso)
      {
        return new MacronutrientesModel()
        {
          Carboidratos = 3.0 * Peso,
          Proteinas = 4.0 * Peso,
          Gorduras = 3.0 * Peso
        };
      }
      else if (ObjetivoFisico == ObjetivoFisicoEnum.ManterPeso)
      {
        return new MacronutrientesModel()
        {
          Carboidratos = 4.0 * Peso,
          Proteinas = 4.0 * Peso,
          Gorduras = 1.0 * Peso
        };
      }
      else if (ObjetivoFisico == ObjetivoFisicoEnum.GanhoMassaMuscular)
      {
        return new MacronutrientesModel()
        {
          Carboidratos = 4.0 * Peso,
          Proteinas = 2.0 * Peso,
          Gorduras = 1.0 * Peso
        };
      }
       else {
        return new MacronutrientesModel();
      }
    }
  }
}