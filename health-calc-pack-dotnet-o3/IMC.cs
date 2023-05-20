using System.Text.RegularExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using health_calc_pack_dotnet_o3.Interfaces;
using health_calc_pack_dotnet_o3.enums;

namespace health_calc_pack_dotnet_o3
{
  public class IMC : IIMC
  {
    public double Calc(double Height, double Weight)
    {
      return Math.Round(Weight / (Height * Height), 2);
    }

    public string GetIMCCategory(double IMC)
    {
      if (IMC < 18.5) {
        return "MAGREZA";
      }

      if (IMC < 25) {
        return "NORMAL";
      }

      if (IMC < 30) {
        return "SOBREPESO";
      }

      if (IMC < 40) {
        return "OBESIDADE";
      }

      return "OBESIDADE GRAVE";
    }

    public bool IsValidDate(double Height, double Weight)
    {
      return Height > 0 && Height < 3 && Weight > 0 && Weight < 300;
    }
  }
}