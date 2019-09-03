using System;
using System.Collections.Generic;
using System.Text;

namespace WoW.Contract.Models
{
    public class AddOn
    {
       public Guid Id { get; set; }
       public string Name { get; set; }
       public string Description { get; set; }
       public string License { get; set; }
       public string GitRepoUrl { get; set; }
       public Guid AuthorId { get; set; }
    }
}
