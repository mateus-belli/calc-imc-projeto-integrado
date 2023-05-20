using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using health_calc_pack_dotnet_o3.Interfaces;
using health_calc_pack_dotnet_o3.models;

namespace health_calc_pack_dotnet_o3
{
  public class MacronutrientesContext
  {
    private IMacronutrientesStrategy? strategy;

    public void setStrategy(IMacronutrientesStrategy strategy)
    {
      this.strategy = strategy;
    }
    
    public MacronutrientesModel ExecuteStrategy(double Peso)
    {
      return strategy!.CalcularMacronutrientes(Peso);
    }
  }
}