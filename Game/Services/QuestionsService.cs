using Game.Entities;
using Game.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Game.Services
{
    public class QuestionsService : IQuestionsService
    {
        private IQuestionsRepository _repository;

        public QuestionsService(IQuestionsRepository questionsRepository)
        {
            _repository = questionsRepository;
        }

        public List<Question> GetAllQuestions(int amount)
        {
            List<Question> list = Shuffle(_repository.GetAllQuestions());

            list.Capacity = amount;

            return list;
        }

        private List<T> Shuffle<T>(List<T> list)
        {
            Random rng = new Random();

            int n = list.Count;

            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }

            return list;
        }
    }
}
