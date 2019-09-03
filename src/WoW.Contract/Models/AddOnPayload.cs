using System;
using System.Collections.Generic;
using System.Text;

namespace WoW.Contract.Models
{
    public class AddOnPayload
    {
       public Guid Id { get; set; }
       public string PayloadDownloadUrl { get; set; }
       public int NumberOfDownloads { get; set; }
       public int AddOnVersionId { get; set; }
    }
} 
