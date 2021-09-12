using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Game.Entities
{
    public record Question(
       
        int questionID,

   
        string question,


        string option1,


        string option2,


        string option3,


        string option4,


        string correctAnswer);
}
