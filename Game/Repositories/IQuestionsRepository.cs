using Game.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Game.Repositories
{
    public interface IQuestionsRepository
    {
        public List<Question> GetAllQuestions();
    }
}
