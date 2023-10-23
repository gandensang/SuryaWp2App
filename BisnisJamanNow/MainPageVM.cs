using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BisnisJamanNow.Models;
using CommunityToolkit.Mvvm.ComponentModel;

namespace BisnisJamanNow
{
    public partial class MainPageVM : ObservableObject
    {
        [ObservableProperty]
        CardModel dataBerita;
        public MainPageVM()
        {
            DataBerita = new CardModel
            {
                Gambar = "https://www.suryaguna.com/wp-content/uploads/2021/03/POMPA-JET-1000-SURYAGUNA-085646415014-6-300x300.jpg",
                Artikel = "ini adalah isi artikel",
                Judul = "Ini adalah Judul",
                TanggalPost = "28 Des 1982"
            };
        }
    }
}
