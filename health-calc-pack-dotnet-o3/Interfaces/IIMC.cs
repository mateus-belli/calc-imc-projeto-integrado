using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace health_calc_pack_dotnet_o3.Interfaces
{
    public interface IIMC
    {
        double Calc(double Height, double Weight);
        string GetIMCCategory(double IMC);
        bool IsValidDate(double Height, double Weight);

    }
}