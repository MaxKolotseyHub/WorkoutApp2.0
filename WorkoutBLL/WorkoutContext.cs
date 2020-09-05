using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkoutBLL.Models;

namespace WorkoutBLL
{
    public class WorkoutContext : DbContext
    {
        static WorkoutContext()
        {
            Database.SetInitializer<WorkoutContext>(new MyInitializer());
        }
        public WorkoutContext():base("Workouts")
        {

        }
        public DbSet<Excercise> Excercises{ get; set; }
        public DbSet<Workout> Workouts{ get; set; }
        public DbSet<User> Users{ get; set; }
        public DbSet<ExcerciseLaps> ExcerciseLaps{ get; set; }
        public DbSet<CompletedWorkout> CompletedWorkouts{ get; set; }
    }

    class MyInitializer : DropCreateDatabaseAlways<WorkoutContext>
    {
        protected override void Seed(WorkoutContext context)
        {
            var user = new User {Name = "Max", Email = "kolotseymax@gmail.com"};
            var pullUp = new Excercise { Description = "Pull yourself up", Name = "Simple pullUp"};
            var workout = new Workout {Name = "Beginner workout" };

            context.Excercises.Add(pullUp);
            context.SaveChanges();

            workout.Excercises.Add(pullUp);
            context.Workouts.Add(workout);
            context.SaveChanges();

            user.Workouts.Add(workout);
            context.Users.Add(user);
            context.SaveChanges();
        }
    }
}
