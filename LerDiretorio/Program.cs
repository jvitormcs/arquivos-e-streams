

static void LerDiretorio(string path){
    diretorios = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);
}