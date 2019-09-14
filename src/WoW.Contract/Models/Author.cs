using System;
using System.Collections.Generic;
using System.Text;

namespace WoW.Contract.Models
{
    public class Author
    {
       public Guid Id { get; set; }
       public string FirstName { get; set; }
       public string LastName { get; set; }
       public string WebsiteLink { get; set; }
       public string DiscordLink { get; set; }
       public string Email { get; set; }
    }
}