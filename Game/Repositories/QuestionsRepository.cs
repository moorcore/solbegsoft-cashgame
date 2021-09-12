using Game.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Game.Repositories
{
    public class QuestionsRepository : IQuestionsRepository
    {
        public List<Question> GetAllQuestions()
        {
            List<Question> questions = new List<Question>();

            try
            {
                DBConnection.connection.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM CashGame.CashGameTable", DBConnection.connection);

                SqlDataReader dataReader = sqlCommand.ExecuteReader();

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                        questions.Add(new Question(Convert.ToInt32(dataReader.GetValue(0)),
                            dataReader.GetValue(1).ToString(),
                            dataReader.GetValue(2).ToString(),
                            dataReader.GetValue(3).ToString(),
                            dataReader.GetValue(4).ToString(),
                            dataReader.GetValue(5).ToString(),
                            dataReader.GetValue(6).ToString()));
                }

                DBConnection.connection.Close();

                return questions;
            }
            catch (Exception)
            {
                DBConnection.connection.Close();
                return questions;
            }
        }
    }
}
