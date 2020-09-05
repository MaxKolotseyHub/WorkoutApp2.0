using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutBLL.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public virtual List<Workout> Workouts { get; set; }
        public virtual List<CompletedWorkout> CompletedWorkouts{ get; set; }
        public User()
        {
            Workouts = new List<Workout>();
            CompletedWorkouts = new List<CompletedWorkout>();
        }
    }
}
