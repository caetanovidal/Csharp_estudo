using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpf006_CloneEverNote.Model
{
    public class Notes
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int NotebookId { get; set; }
        public string Title { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public string FileLocation { get; set; }
    }
}
