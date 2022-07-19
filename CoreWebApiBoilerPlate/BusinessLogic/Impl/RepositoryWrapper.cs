﻿using CoreWebApiBoilerPlate.BusinessLogic.Repository;
using CoreWebApiBoilerPlate.DataLayer.Context;

namespace CoreWebApiBoilerPlate.BusinessLogic.Impl
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private readonly DefaultDBContext dbContext;
        private readonly IUserRepository _user;
        private readonly ITodoRepository _todo;

        public RepositoryWrapper(DefaultDBContext dbContext)
        {
            this.dbContext = dbContext;
            _user = new UserRepository(dbContext);
            _todo = new TodoRepository(dbContext);
        }


        public IUserRepository UserRepository => _user;
        public ITodoRepository TodoRepository => _todo;

        public async Task<int> SaveAsync()
        {
            return await dbContext.SaveChangesAsync();
        }
    }
}
