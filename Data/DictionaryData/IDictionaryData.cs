using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebLearningProj.Models;

namespace WebLearningProj.DictionaryData
{
    public interface IDictionaryData
    {
        ScienceDegree GetScienceDegree(int id);
        TypeOfStudying GetTypeOfStudying(int id);
        Subject GetSubject(int id);
    }
}
