using System;
using System.Collections.Generic;
using System.Text;
using WoW.Contract.Models;

namespace WoW.Contract
{
    interface IAddOnRepository {
       AddOn GetAddOnById(Guid id);
       List<AddOn> GetAddOns();
       AddOn GetAddOnByName(string exactName);
       AddOn GetAddOnBySearch(string searchTerm);
       Version GetLatestVersion(AddOn addon);
       List<Version> GetAllVersions(AddOn addon);
       List<VersionComment> GetAllComments(Version version);
       bool AddComment(Version addonVersion, VersionComment comment);
       bool AddAuthor(Author author);
       bool AddVersion(AddOn addOn, Version version);
       bool Increase(AddOnPayload payload);
    }
}
