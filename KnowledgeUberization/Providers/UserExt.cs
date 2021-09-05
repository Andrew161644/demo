using System;
using KnowledgeUberization.Models;

namespace KnowledgeUberization.Providers
{
    public class UserExt : User, IHasIdKey
    {
        public Guid Id { get; set; }
        public short RoleShort => (short) Role;
    }
}