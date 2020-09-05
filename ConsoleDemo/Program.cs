using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkoutBLL;
using WorkoutBLL.Models;

namespace ConsoleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (WorkoutContext db = new WorkoutContext())
            {
                var user = db.Users.First();

                var a = user.Workouts.First();

                var ex = a.Excercises.First();

                ExcerciseLaps el1 = new ExcerciseLaps { Count = 10 , Excercise = ex, Lap =1 , ExcerciseId = ex.Id};
                ExcerciseLaps el2 = new ExcerciseLaps { Count = 8 , Excercise = ex, Lap =2 , ExcerciseId = ex.Id};

                CompletedWorkout completedWorkout = new CompletedWorkout {Date= DateTime.Now, Workout = a, WorkoutId = a.Id };
                completedWorkout.ExcerciseLaps.AddRange(new List<ExcerciseLaps> { el1,el2});

                user.CompletedWorkouts.Add(completedWorkout);
                db.SaveChanges();

                Console.WriteLine($"User: {user.Name}\nCompletedWorkouts: {user.CompletedWorkouts.Count}\n\tExcercise: {user.CompletedWorkouts.First().ExcerciseLaps[0].Excercise.Name}\n\t\tLap 1: {user.CompletedWorkouts.First().ExcerciseLaps[0].Count}\n\t\tLap 2: {user.CompletedWorkouts.First().ExcerciseLaps[1].Count}");
            }
        }
    }
}
