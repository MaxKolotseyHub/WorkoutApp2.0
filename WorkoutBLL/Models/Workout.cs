using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutBLL.Models
{
    public class Workout
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Excercise> Excercises { get; set; }
        public virtual List<User> Users { get; set; }

        public Workout()
        {
            Excercises = new List<Excercise>();
            Users = new List<User>();
        }
    }
}
