var path = @"C:\Users\vitor\OneDrive\Área de Trabalho\Aulas Dio C#\Aquivos e Streams em C#\Directory_And_DirectoryInfo\globo";

//LerDiretorio(path);

LerArquivos(path);

Console.WriteLine("Digite [enter] para finalizar....");
Console.ReadLine();



static void LerArquivos(string path)
{
    var arquivos = Directory.GetFiles(path, "*", SearchOption.AllDirectories);

    foreach (var arquivo in arquivos)
    {
        var arqInfo = new FileInfo(arquivo);
        Console.WriteLine($"[Nome]:{arqInfo.Name}");
        Console.WriteLine($"[Tamanho]:{arqInfo.Length}");
        Console.WriteLine($"[Ultimo acesso]:{arqInfo.LastAccessTime}");
        Console.WriteLine($"[Pasta]:{arqInfo.DirectoryName}");
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
