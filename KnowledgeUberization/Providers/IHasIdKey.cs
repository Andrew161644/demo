using System;

namespace KnowledgeUberization.Providers
{
    public interface IHasIdKey
    {
        Guid Id { get; set; }
    }
}