using System;
using System.IO;
using System.Text.RegularExpressions;
using YamlDotNet.RepresentationModel;

class Program
{
    static void Main(string[] args)
    {
        // Caminho para o arquivo YAML
        string filePath = "C:\\Users\\TiagoNotebook\\Documents\\ContaGuids\\ArquivoConsultar\\guids.yaml";

        // Ler o conteúdo do arquivo YAML
        string yamlContent = File.ReadAllText(filePath);

        // Regex para detectar GUIDs
        Regex guidRegex = new Regex(@"\b[a-fA-F0-9]{8}\b-[a-fA-F0-9]{4}\b-[a-fA-F0-9]{4}\b-[a-fA-F0-9]{4}\b-[a-fA-F0-9]{12}\b");

        // Contar GUIDs no conteúdo YAML
        int guidCount = guidRegex.Matches(yamlContent).Count;

        // Exibir o número de GUIDs encontrados
        Console.WriteLine($"Número de GUIDs encontrados: {guidCount}");
        Console.WriteLine("Aperte qualquer tecla para sair!!");
        Console.ReadKey();
    }
}
