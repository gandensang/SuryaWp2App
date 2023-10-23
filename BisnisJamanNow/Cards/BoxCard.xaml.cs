namespace BisnisJamanNow.Cards;

public partial class BoxCard : Frame
{
	public BoxCard()
	{
		InitializeComponent();
	}
    public string Judul
    {
        get { return JudulLabel.Text; }
        set { JudulLabel.Text = value; }
    }

    public string Tanggal
    {
        get { return TglPost.Text; }
        set { TglPost.Text = value; }
    }
    public string Deskripsi
    {
        get { return DeskripsiLbl.Text; }
        set { DeskripsiLbl.Text = value; }
    }

    public string ImageSource
    {
        get { return imageLbl.Source as FileImageSource; }
        set { imageLbl.Source = (FileImageSource)value; }
    }

}