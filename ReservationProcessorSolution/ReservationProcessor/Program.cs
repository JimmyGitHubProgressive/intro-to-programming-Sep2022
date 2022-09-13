// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Welcome to the Application!");




Console.Write("Enter your name: ");
string? name = Console.ReadLine();



Console.Write("What is your Age?");



string? ageAsString = Console.ReadLine();
int age = 0;
try
{
    age = int.Parse(ageAsString);
}
catch (FormatException)
{



    Console.WriteLine("Enter a number for your age, jerk!");
    throw;
}



if (name == null)
{
    Console.WriteLine("Come on! Tell me your name!");
}
else
{



    Console.WriteLine($"Welcome to the application, {name}! Good to see you! You are {age} years old!");
}


CourseRegistrationResponse reponse
    = courseRegistrationManagager.RegisterForCourse(email, courseId, courseOfferingId);

var courseRegistrationManager = new CourseRegistrationManager();

CourseRegistrationManager courseRegistrationManager = new CourseRegistrationManager();



CourseRegistrationResponse response
    = courseRegistrationManager.RegisterForCourse(email, courseId, courseOfferingId);



if (response.IsRegistered)
{
    Console.WriteLine("Congratulations! You have been registered!");
    Console.WriteLine($"Your Registration Id is {response.Id}");
    Console.WriteLine($"The course starts on {response.courseDate:d}");
}
else
{
    Console.WriteLine("Sorry, you are not registered for the course!");
}

public class CourseRegistrationManager
{
    
    public CourseRegistrationResponse RegisterForCourse(string? email, string? courseId, string? courseOfferingId)
    {
        return new CourseRegistrationResponse(Guid.NewGuid().ToString(), DateTime.Now.AddDays(15), true);
    }



    public CourseRegistrationResponse RegisterForCourse(CourseRegistrationRequest request)
    {
        return RegisterForCourse(request.Email, request.CourseId, request.CourseOfferingId);
    }
}

