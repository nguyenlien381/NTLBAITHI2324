using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NTLBAITHI2324
{
    [Table("NTL381Person")]
    public class NTL381Person
    {
        [Key]
        public string NTL381PersonId { get; set; }
        public int NTL381PersonAge { get; set; }
        public float NTL381PersonAddress {get; set;}
    }
}