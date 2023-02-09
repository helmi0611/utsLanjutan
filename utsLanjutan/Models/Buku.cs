using System.Reflection.Metadata.Ecma335;

namespace utsLanjutan.Models
{
    public class Buku
    {
        public string genre { get; set; }
        public string judul { get; set; }

        public Buku(string judul1, string genre1)
        {
            judul = judul1;
            genre = genre1;
        }
    }
}
