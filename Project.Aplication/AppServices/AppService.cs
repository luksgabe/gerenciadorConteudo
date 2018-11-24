using Project.Aplication.Interface;
using ProjetoGerenciadorConteudo.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace Project.Aplication.AppServices
{
    public class AppService<TEntity> : IDisposable, IAppService<TEntity> where TEntity : class
    {

        private readonly IService<TEntity> _service;

        public AppService(IService<TEntity> serviceBase)
        {
            _service = serviceBase;
        }

        public void Add(TEntity obj)
        {
            _service.Add(obj);
        }

        public TEntity GetById(int id)
        {
            return _service.GetById(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _service.GetAll();
        }

        public void Update(TEntity obj)
        {
            _service.Update(obj);
        }

        public void Remove(TEntity obj)
        {
            _service.Remove(obj);
        }

        public void Dispose()
        {
            _service.Dispose();
        }
    }
}
