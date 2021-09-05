using System;
using System.Collections.Generic;
using KnowledgeUberization.Models;

namespace KnowledgeUberization.Providers
{
    public class UserFilter
    {
        private IList<Guid> Ids { get; set; }
        private IList<string> Names { get; set; }
        private IList<string> Passwords { get; set; }
        private IList<int> Ages { get; set; }
        private IList<RoleEnum> Roles { get; set; }
        private bool IncludeRemoved { get; set; }
    }
}