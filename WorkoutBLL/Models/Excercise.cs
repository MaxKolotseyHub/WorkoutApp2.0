using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutBLL.Models
{
    public class Excercise
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual List<Workout> Workouts{ get; set; }
        public Excercise()
        {
            Workouts = new List<Workout>();
        }
    }
}
