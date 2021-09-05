using System.Collections;
using System.Collections.Generic;

namespace KnowledgeUberization.Providers
{
    public interface IWriterBase<T1, T2, T3>
    where T2 : IHasIdKey
    where T3 : IHasIdKey
    {
        void Add(T1 toAdd);
        
        void Update(IList<T2> update);
        void Remove(IEnumerable<T3> toRemove);
    }
}