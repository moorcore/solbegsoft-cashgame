using Game.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Game.Services
{
    public interface IQuestionsService
    {
        public List<Question> GetAllQuestions(int amount);
    }
}
