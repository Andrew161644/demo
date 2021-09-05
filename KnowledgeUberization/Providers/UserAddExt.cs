using System;
using KnowledgeUberization.Models;

namespace KnowledgeUberization.Providers
{
    public class UserAddExt : User
    {
        public DateTime CreatedAt { get; set; }
        public short RoleShort => (short) Role;
    }
}