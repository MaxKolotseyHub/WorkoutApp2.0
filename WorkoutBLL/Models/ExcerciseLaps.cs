using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutBLL.Models
{
    public class ExcerciseLaps
    {
        public int Id { get; set; }
        public int Count { get; set; }
        public int Lap { get; set; }
        public int ExcerciseId { get; set; }
        public virtual Excercise Excercise { get; set; }
    }
}
