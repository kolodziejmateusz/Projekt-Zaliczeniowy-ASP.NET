using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class RecordLabelEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Regon { get; set; }
        public string Nip { get; set; }
        public Address? Address { get; set; }
        public string Website { get; set; }
        public ISet<RecordLabelEntity> Albums { get; set; }

    }
}
