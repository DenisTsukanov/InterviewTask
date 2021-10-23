using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebLearningProj.Models;

namespace WebLearningProj.DictionaryData
{
    public class NpgSqlDictionaryData : IDictionaryData
    {
        private ApplicationContext _applicationContext;
        public NpgSqlDictionaryData(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }
        public ScienceDegree GetScienceDegree(int id)
        {
            return _applicationContext.ScienceDegrees.Find(id);
        }

        public Subject GetSubject(int id)
        {
            return _applicationContext.Subjects.Find(id);
        }

        public TypeOfStudying GetTypeOfStudying(int id)
        {
            return _applicationContext.TypesOfStudying.Find(id);
        }
    }
}
