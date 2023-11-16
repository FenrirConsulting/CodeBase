using System.ComponentModel.DataAnnotations;

namespace HeimdallCloud.Infrastructure.Shared.DataAccess
{
    public  class IAMHAuthorizationSettings
    {
        [Key]
        public int Id { get; set; }

        public string ?Type { get; set; }

        public string ?Rule { get; set; }

        public string ?Value { get; set; }

        public string ?ReportsAssignmentGroup { get; set; }
    }
}
