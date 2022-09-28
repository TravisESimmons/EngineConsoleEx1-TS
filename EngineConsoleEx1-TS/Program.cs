// See https://aka.ms/new-console-template for more information
using EngineConsoleEx1_TS;

static void DisplayString(string text)
{
    Console.WriteLine(text);
}

static void DisplayPerson(Person person)
{
    DisplayString($"{person.FirstName} {person.LastName}");
    DisplayString(person.Address.ToString());
    foreach (var emp in person.EmploymentPositions)
        DisplayString(emp.ToString()); 
}

Employment Job = CreateJob();
ResidentAddress Address = CreateAddress();

// Create a Person 
Person me = CreatePerson(Job, Address);
    if (me != null)
    DisplayPerson(me);

Person CreatePerson(Employment job, ResidentAddress address)
{
    Person thePerson = null;
    List<Employment> jobs = new List<Employment>();
    try
    {
      
        jobs.Add(new Employment("Worker", SupervisoryLevel.TeamMember, 2.1));
        jobs.Add(new Employment("Leader", SupervisoryLevel.TeamLeader, 7.1));
        jobs.Add(job);
        thePerson = new Person("James Multi Job", "Thompson", jobs, address);

        
        thePerson.ChangeName("Jimmy", "DeckOfCards");

        thePerson.AddEmployment(new Employment("Head IT", SupervisoryLevel.DepartmentHead, 100000000));

        //Exception Testing
        // No first name 
        // thePerson = new Person(null, "Thompson", jobs, address); 

        // No last name 
        // thePerson = new Person(null, "James", jobs, address); 

        ResidentAddress oldAddress = thePerson.Address;
        oldAddress.City = "Vancouver";
        thePerson.Address = oldAddress;
    }
    catch (ArgumentException ex) // Specifies exception message
    {
        DisplayString(ex.Message);
    }
    catch (Exception ex) // General Catch All
    {
        DisplayString("Runtime error:  " + ex.Message);
    }

    return thePerson;
}

Employment CreateJob()
{


    Employment job = null;
    try
    {
        job = new Employment();
        DisplayString($"Good Job {job.ToString()}");


        // checking exceptions
        job = new Employment("Boss", SupervisoryLevel.Supervisor, 5.5);
        DisplayString($"Greed Good Job {job.ToString()}");

        // Bad Data
        // job = new Employment("", SupervisoryLevel.Supervisor, 5.5); // Empty
        // job = new Employment("Boss", 10, 5.5); INVALID SUPERVISORY LEVEL 
        // job = new Employment("Boss", SupervisoryLevel.Supervisor, -5.5); // Negative Year
    }
    catch (ArgumentException ex) // Specifies exception message
    {
        DisplayString(ex.Message);
    }
    catch (Exception ex) // General Catch All
    {
        DisplayString("Runtime error:  " + ex.Message);
    }
    
    return job;
}

ResidentAddress CreateAddress()
{
    ResidentAddress address = new ResidentAddress();
    DisplayString($"Default Address {address.ToString()}");
    address = new ResidentAddress(10767, "106 St Nw", null, null, "Edmonton", "AB");
    DisplayString($"Greedy Address {address.ToString()}");

    return address;
}
