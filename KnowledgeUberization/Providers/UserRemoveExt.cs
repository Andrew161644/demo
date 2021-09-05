using System;

namespace KnowledgeUberization.Providers
{
    public class UserRemoveExt : IHasIdKey
    {
        public Guid Id { get; set; }
        public DateTime DeletedAt { get; set; }
    }
}