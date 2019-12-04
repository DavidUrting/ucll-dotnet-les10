using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureWorks.Web.Models.WebAPI
{
    public class SearchQuery
    {
        [Required]
        [StringLength(int.MaxValue, MinimumLength = 3)]
        public string Keyword { get; set; }

        [Range(1, 500)]
        public int MaxResults { get; set; } = 100;
    }
}
