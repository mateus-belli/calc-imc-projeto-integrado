using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using health_calc_pack_dotnet_o3.enums;
using health_calc_pack_dotnet_o3.models;

namespace health_calc_pack_dotnet_o3.Interfaces
{
    public interface IMacronutrientes
    {
        MacronutrientesModel CalcularMacronutrientes(ObjetivoFisicoEnum ObjetivoFisico, double Peso);
    }
}