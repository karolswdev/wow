using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;

namespace WoW.Contract.Models
{
    class VersionComment
    {
       public Guid Id { get; set; }
       public string Name { get; set; }
       public Guid? AuthorId { get; set; }
       public string CommentText { get; set; }

       [Write(false)]
       [Computed]
       public bool HasAuthor {
          get { return AuthorId.HasValue; }
       }
    }
}
