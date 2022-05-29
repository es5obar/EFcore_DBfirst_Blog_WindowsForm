using System;
using System.Collections.Generic;

namespace EFcore_DBfirst_Blog_WindowsForm.Entities
{
    public partial class Konular
    {
        public Konular()
        {
            Yorumlars = new HashSet<Yorumlar>();
        }

        public int Id { get; set; }
        public string Baslik { get; set; } = null!;
        public string? Aciklama { get; set; }
        public DateTime Tarih { get; set; }

        public virtual ICollection<Yorumlar> Yorumlars { get; set; }
    }
}
