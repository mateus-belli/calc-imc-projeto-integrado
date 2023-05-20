using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using health_calc_pack_dotnet_o3.enums;
using health_calc_pack_dotnet_o3.Interfaces;
using health_calc_pack_dotnet_o3.models;

namespace health_calc_pack_dotnet_o3.MacronutrientesStrategies
{
  public class GanharMassaStrategy : IMacronutrientesStrategy
  {
    public MacronutrientesModel CalcularMacronutrientes(double Peso)
    {
      return new MacronutrientesModel()
      {
        Carboidratos = 4.0 * Peso,
        Proteinas = 2.0 * Peso,
        Gorduras = 1.0 * Peso
      };
    }
  }
}