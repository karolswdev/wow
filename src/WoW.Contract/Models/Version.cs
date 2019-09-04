using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace WoW.Contract.Models
{
   public class AddOnVersion {
      public Guid Id { get; set; }
      public int MajorVersion { get; set; }
      public int MinorVersion { get; set; }
      public int PatchVersion { get; set; }
      public string ReleaseNotes { get; set; }
      public int AddOnId { get; set; }

      public string Version {
         get {
            {
               return $"{MajorVersion}.{MinorVersion}";
            }
         }

      }







}
}
