using static System.Console;

WriteLine("Digite o nome do arquivo");
var nome = ReadLine();
nome = LimparNome(nome);

var path = Path.Combine(Environment.CurrentDirectory, $"{nome}.text");

CriarArquivo(path);

WriteLine("Digite enter para finilizar...");
ReadLine();

static string LimparNome(string nome){
    foreach (var @char in Path.GetInvalidFileNameChars())
    {   
    nome = nome.Replace(@char, '-');
    }
    return nome;
}

static void CriarArquivo(string path)
{
    try
    {
        using var sw = File.CreateText(path);
        sw.WriteLine("Essa é a linha um do arquivo");
        sw.WriteLine("Essa é a linha dois do arquivo");
        sw.WriteLine("Essa é a linha três do arquivo");

    }
    catch
    {
        WriteLine("O nome do arquivo está invalido");
    }
}
