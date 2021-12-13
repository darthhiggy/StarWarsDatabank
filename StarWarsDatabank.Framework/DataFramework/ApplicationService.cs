using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsDatabank.Framework.DataFramework
{
    public class ApplicationService<TEntity> : IApplicationService<TEntity> where TEntity : class
    {
        private readonly IRepository<TEntity> _repository;
        private readonly IUnitOfWork _unitOfWork;

        public ApplicationService(IRepository<TEntity> repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        
        //public Task Handle(ICommand command)
        //{
        //    return new Task(() =>
        //    {

        //        //_unitOfWork.BeginTransaction();
        //        //if (command.Execute(_repository))
        //        //{
        //        //    _unitOfWork.Commit();
        //        //}
        //        //else
        //        //{
        //        //    _unitOfWork.Rollback();
        //        //}
        //    });
            
        //}
    }
}
