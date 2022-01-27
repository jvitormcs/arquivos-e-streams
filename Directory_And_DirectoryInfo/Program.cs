using static System.Console;

/* CriaDirGlobo();
CriaArquivo();

var origem = Path.Combine(Environment.CurrentDirectory, "Brasil.text");
var destino = Path.Combine(Environment.CurrentDirectory,
    "globo",
    "América do Sul",
    "Brasil",
    "brasil.text");

CopiarArquivo(origem, destinoArgentina);
MoverArquivo(origem, destino); */

LerArquivos(path);

static void LerArquivos(string path)
{
    var arquivos = Directory.GetFiles(path, "*", SearchOption.AllDirectories);

    foreach (var arquivo in arquivos)
    {
        var fileInfo = new fileInfo(arquivo);
        Console.WriteLine($"[Nome]:{fileInfo.Name}");   
        Console.WriteLine($"[Tamanho]:{fileInfo.Length}");   
        Console.WriteLine($"[Ultimo acesso]:{fileInfo.LastAccessTime}");  
        Console.WriteLine($"[Pasta]:{fileInfo.DirectoryName}");  
        Console.WriteLine("----------------------------------"); 
    }
}

static void LerDiretorio(string path)
{

    if(Directory.Exists(path)){
    var diretorios = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);

    foreach (var dir in diretorios)
    {
        var dirInfo = new DirectoryInfo(dir);
        Console.WriteLine($"[Nome:]: {dirInfo.Name}");
        Console.WriteLine($"[Raiz]: {dirInfo.Root}");
        if(dirInfo.Parent != null)
        Console.WriteLine($"[Pai]: {dirInfo.Parent.Name}");

        Console.WriteLine("----------------------------------");
    }}
    else{
        Console.WriteLine($"{path} não existe");
    }
}

static void CopiarArquivo(string pathOrigem, string pathDestino)
{
    File.Copy(pathOrigem, pathDestino);
}


static void MoverArquivo(string pathOrigem, string pathDestino)
{
    if(!File.Exists(pathOrigem)){
        WriteLine("Arquivo de origem não existe");
    }
    if(File.Exists(pathDestino)){
        WriteLine("Arquivo já foi movido");
    }
    File.Move(pathOrigem, pathDestino);

    return;
}

static void CriaArquivo()
{
    WriteLine("Qual País deseja cadastrar?");
    string pais = ReadLine();

    var path = Path.Combine(Environment.CurrentDirectory, $"{pais}.text");
    if (!File.Exists(path))
    {
        WriteLine("Qual é o numero de habitantes?");
        string populacao = ReadLine();

        WriteLine("Qual é o IDH");
        string idh = ReadLine();

        WriteLine("De quando são esses Dados?");
        string dados = ReadLine();
        using var sw = File.CreateText(path);
        sw.WriteLine($"População: {populacao}");
        sw.WriteLine($"IDH: {idh}");
        sw.WriteLine($"Dados atualizados em: {dados}");
    }
    else
    {
        WriteLine("País já cadastrado");
    }

}

static void CriaDirGlobo()
{
    var path = Path.Combine(Environment.CurrentDirectory, "globo");
    if (!Directory.Exists(path))
    {

        var dirGlobo = Directory.CreateDirectory(path);
        var dirAmNorte = dirGlobo.CreateSubdirectory("América Do Norte");
        var dirAmCentral = dirGlobo.CreateSubdirectory("América Central");
        var dirAmSul = dirGlobo.CreateSubdirectory("América Do Sul");

        dirAmNorte.CreateSubdirectory("USA");
        dirAmNorte.CreateSubdirectory("Mexico");
        dirAmNorte.CreateSubdirectory("Canadá");

        dirAmCentral.CreateSubdirectory("Costa Rica");
        dirAmCentral.CreateSubdirectory("Panama");

        dirAmSul.CreateSubdirectory("Brasil");
        dirAmSul.CreateSubdirectory("Argentina");
        dirAmSul.CreateSubdirectory("Paraguai");
    }
}


