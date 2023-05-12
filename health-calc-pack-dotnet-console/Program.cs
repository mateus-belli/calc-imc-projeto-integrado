using health_calc_pack_dotnet_o3;

var imc = new IMC();

var result = imc.Calc(1.85, 70);
var classificacao = imc.GetIMCCategory(result);

Console.WriteLine($"IMC: {result} | Resultado: {classificacao}");