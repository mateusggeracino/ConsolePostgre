using System.ComponentModel.DataAnnotations.Schema;

namespace ConsolePostgre.domain
{
    [Table("public.Client", Schema = "public")]
    public class Client : Entity
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string SocialNumber { get; set; }
        public string Email { get; set; }
    }
}