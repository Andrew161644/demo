using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Dapper;
using KnowledgeUberization.Models;

namespace KnowledgeUberization.Providers
{
    public class UserProvider : IUserProvider
    {
        private readonly IDbConnector _connector;
        public UserProvider(IDbConnector connector)
        {
            _connector = connector;
        }

        #region _addQuery

        private readonly string _addQuery = @"
insert into users (
                   name,
                   password,
                   roleid,
                   age) 
                   values (
                       :Name,
                       :Password,    
                       :RoleShort,
                       :Age
                   )";

        #endregion
        
        public IList<User> List(UserFilter filter)
        {
            throw new System.NotImplementedException();
        }

        public Task<IList<User>> ListAsync(UserFilter filter)
        {
            throw new System.NotImplementedException();
        }
        public void Add(UserAddExt toAdd)
        {
            if (toAdd.CreatedAt == default)
            {
                throw new ArgumentException($"{nameof(toAdd)} must be defined");
            }

            using var connection = _connector.Connect();
            var parametrs = new DynamicParameters(
                new
                {
                    toAdd.Name,
                    toAdd.Password,
                    toAdd.RoleShort,
                    toAdd.Age
                });
            connection.Execute(_addQuery, parametrs);
            connection.Close();
        }

        public void Update(IList<UserExt> update)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(IEnumerable<UserRemoveExt> toRemove)
        {
            throw new System.NotImplementedException();
        }
    }
}