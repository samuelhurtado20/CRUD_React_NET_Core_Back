using System.ComponentModel.DataAnnotations;

namespace CRUD_React_NET_Core_Back.Models
{
    public class Managers
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Release { get; set; }
        public string Developer { get; set; }
    }
}
