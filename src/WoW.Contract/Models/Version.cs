using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using Dapper;
using System.ComponentModel.DataAnnotations;
using Dapper.Contrib.Extensions;

namespace WoW.Contract.Models
{
   public class AddOnVersion {
      public Guid Id { get; set; }
      public int MajorVersion { get; set; }
      public int MinorVersion { get; set; }
      public int PatchVersion { get; set; }
      public string ReleaseNotes { get; set; }
      public int AddOnId { get; set; }

      [Write(false)]
      [Computed]
      public string Version {
         get {
            {
               return $"{MajorVersion}.{MinorVersion}";
            }
         }

      }







}
}
