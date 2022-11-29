using Business;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    /// <summary>
    /// 
    /// </summary>
    public class ServicePole
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly DataContext _ctx;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public ServicePole(DataContext context)
        {
            _ctx = context;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Pole> Get()
        {
            return _ctx.Poles.Select(x => new Pole
            {
                Id = x.Id,
                Name = x.Name
            }).ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Pole Get(int id)
        {
            return _ctx.Poles.Where(x => x.Id == id).Select(x => new Pole
            {
                Id = x.Id,
                Name = x.Name
            }).FirstOrDefault();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Pole Add(Pole model)
        {
            var entity = new Data.DAO.Pole
            {
                Id = model.Id,
                Name = model.Name
            };

            _ctx.Poles.Add(entity);
            _ctx.SaveChanges();

            model.Id = entity.Id;
            return model;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        public void Update(Pole model)
        {
            var entity = _ctx.Poles.Where(x => x.Id == model.Id).FirstOrDefault();

            entity.Name = model.Name;

            _ctx.SaveChanges();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            var entity = _ctx.Poles.Where(x => x.Id == id).FirstOrDefault();
            _ctx.Poles.Remove(entity);
            _ctx.SaveChanges();
        }
    }
}
