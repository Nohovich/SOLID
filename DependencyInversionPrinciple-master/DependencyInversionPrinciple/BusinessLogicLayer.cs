using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    // while designing the interaction between a high-level module and a low-level one,
    // the interaction should be thought of as an abstract interaction between them.
    class BusinessLogicLayer
    {
        private readonly IRepositoryLayer DAL;

        public BusinessLogicLayer(IRepositoryLayer repositoryLayer)
        {
            DAL = repositoryLayer;
        }

        public void Save(Object details)
        {
            DAL.Save(details);
        }
    }
    public interface IRepositoryLayer
    {
        void Save(Object details);
    }

    public class DataAccessLayer : IRepositoryLayer
    {
        public void Save(Object details)
        {
            //perform save
        }
    }
}
