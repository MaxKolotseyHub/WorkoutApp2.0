using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutBLL.Models
{
    public class CompletedWorkout
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int WorkoutId { get; set; }
        public virtual Workout Workout { get; set; }
        public virtual List<ExcerciseLaps> ExcerciseLaps { get; set; }
        public virtual List<User> Users { get; set; }
        public CompletedWorkout()
        {
            ExcerciseLaps = new List<ExcerciseLaps>();
            Users = new List<User>();
        }
    }
}
