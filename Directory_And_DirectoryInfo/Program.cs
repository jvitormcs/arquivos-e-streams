using static System.Console;

var path = Path.Combine(Environment.CurrentDirectory, "globo");
var dirGlobo = Directory.CreateDirectory(path);
var dirAmNorte =  dirGlobo.CreateSubdirectory("América Do Norte");
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
