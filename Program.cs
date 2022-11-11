 class Program {
  
 static List<bool> TaskIsCompleted = new List<bool>()
            {
                true,
                true,
                true,
                true,
                true,
                true,
                true,
                true,
                true,
                true,
            };

 static List<DateTime> StartTime = new List<DateTime>()
 {
   DateTime.MinValue,
   DateTime.MinValue,
   DateTime.MinValue,
   DateTime.MinValue,
   DateTime.MinValue,
   DateTime.MinValue,
   DateTime.MinValue,
   DateTime.MinValue,
   DateTime.MinValue,
   DateTime.MinValue, 
 };

 static List<DateTime> EndTime = new List<DateTime>()
 {
   DateTime.MinValue,
   DateTime.MinValue,
   DateTime.MinValue,
   DateTime.MinValue,
   DateTime.MinValue,
   DateTime.MinValue,
   DateTime.MinValue,
   DateTime.MinValue,
   DateTime.MinValue,
   DateTime.MinValue, 
 };
 static List<string> Tasks = new List<string>() {
            "Wake up",
            "Have breakfast",
            "Brush your teeth",
            "Go for classes",
            "Take a break",
            "Have lunch",
            "Do homework",
            "Go to the gym",
            "Study",
            "Go to bed"
    };
  
  //prints all task descriptions one on a line, filtering based on their completion state
  static void printTasksByCompletion(bool completed){
    //loop over all the tasks
    for(int i = 0; i < Tasks.Count; i++){
      //if this task's completion flag matches our filter, print it
      if(TaskIsCompleted[i] == completed){
        String msg = Tasks[i];
        //if the task has been completed, print its start and end times too
        if(TaskIsCompleted[i]){
          msg = msg + $"\tStarted {StartTime[i]}, finished {EndTime[i]}";
        }
        Console.WriteLine(msg);
      }
    }
  }
  
  
  
  
static void Main(string[] args)
{

bool exit = false;

Console.WriteLine("Welcome to your to-do board. Here are your tasks for today: ");  


    bool Completed() {
          if(TaskIsCompleted[0] == true)
          Console.WriteLine("Completed");
          return true;
      } 
    foreach(string list in Tasks){
      Console.WriteLine(list);
    }


while(!exit) {

  Console.Write("Please select the task you did already");
  //loop over the data store and print out a menu entry for each task we're tracking
  for(int i = 0; i < Tasks.Count; i++){
    //print the array index and description of each task
    String menuItem = $"{i}: {Tasks[i]}";
    //if the task is already done, denote that
    if(TaskIsCompleted[i]){
      menuItem = menuItem + $" (done at {EndTime[i]})";
    }
    Console.WriteLine(menuItem);
  }  
       
        int opCode = int.Parse(Console.ReadLine());
        Console.WriteLine(); 

        DateTime now = DateTime.Now;
        string time = now.GetDateTimeFormats('t')[0];
        DateTime startTime = DateTime.Now;
        DateTime endTime;
        startTime = DateTime.Now;
        endTime = startTime.AddMinutes(10);
        TimeSpan t = endTime - startTime;

  if (opCode >= 1 && opCode <= 10) 
        { 
  switch(opCode){
    case 1: 
    Console.WriteLine(Completed());
    Console.WriteLine($"Your start time {startTime}");
    Console.WriteLine($"Your end time {endTime}");
    Console.WriteLine(t);
    // Activities.Remove(Activities[0]);
    // Console.WriteLine(result);
    break;
    case 2: 
    Console.WriteLine(Completed());
    Console.WriteLine($"Your start time {startTime}");
    Console.WriteLine($"Your end time {endTime}");
    Console.WriteLine(t);
    break;
    case 3:
    Console.WriteLine(Completed()); 
    Console.WriteLine($"Your start time {startTime}");
    Console.WriteLine($"Your end time {endTime}");
    Console.WriteLine(t);
    break;
    case 4: 
    Console.WriteLine(Completed());
    Console.WriteLine($"Your start time {startTime}");
    Console.WriteLine($"Your end time {endTime}");
    Console.WriteLine(t);
    break;
    case 5: 
    Console.WriteLine(Completed());
    Console.WriteLine($"Your start time {startTime}");
    Console.WriteLine($"Your end time {endTime}");
    Console.WriteLine(t);
    break;
    case 6: 
    Console.WriteLine(Completed());
    Console.WriteLine($"Your start time {startTime}");
    Console.WriteLine($"Your end time {endTime}");
    Console.WriteLine(t);
    break;
    case 7: 
    Console.WriteLine(Completed());
    Console.WriteLine($"Your start time {startTime}");
    Console.WriteLine($"Your end time {endTime}");
    Console.WriteLine(t);
    break;
    case 8: 
    Console.WriteLine(Completed());
    Console.WriteLine($"Your start time {startTime}");
    Console.WriteLine($"Your end time {endTime}");
    Console.WriteLine(t);
    break;
    case 9: 
    Console.WriteLine(Completed());
    Console.WriteLine($"Your start time {startTime}");
    Console.WriteLine($"Your end time {endTime}");
    Console.WriteLine(t);
    break;
    case 10: 
    Console.WriteLine(Completed());
    Console.WriteLine($"Your start time {startTime}");
    Console.WriteLine($"Your end time {endTime}");
    Console.WriteLine(t);
    break;
    case 11: 
    Console.WriteLine("Good bye!"); 
    exit = true; 
    Console.ReadKey();
    Console.Clear();
    break; 
    default:
    Console.WriteLine("Invalid choice. Try again."); 
    break;

        }
       
    }
  }
}
}
  

