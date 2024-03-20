namespace Notes;
public partial class NotesPage : ContentPage
{
	// c:Usuario/arquivo.extensao
	// com.whatsapp.media
	// com.meta.intagram.media
	string path = Path.Combine(FileSystem.AppDataDirectory,"arquivonovo.txt");
	string text = "";

	public NotesPage()
	{
		InitializeComponent();
		if (File.Exists(path))
		{
			FileEditor.Text = File.ReadAllText(path);
		}
	}

    private void SaveButton_Clicked(object sender, EventArgs e)
    {
        //Pegar o texto escrito no editor de texto
        //Armazenar esse texto em uma vari�vel
        text = FileEditor.Text;
        //Criar um arquivo com esse conte�do
        File.WriteAllText(path, text);
    }
    private void DeleteButton_Clicked(object sender, EventArgs e)
    {
		
    }
}