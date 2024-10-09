using EventManager;
using System;
namespace EventManager;
class Program
{
    public static void Main(string[] args)
    {
        EventManager eventManager = new EventManager();

        // create event 
        Console.WriteLine("Input event name:");
        string eventName = Console.ReadLine();

        Console.WriteLine("Input event date:");
        string eventDate = Console.ReadLine();

        Console.WriteLine("Input event location:");
        string eventLocation = Console.ReadLine();

        Event party = new(eventName, eventDate, eventLocation);

        eventManager.ParticipantAdded += (recipient, message) => { Console.WriteLine($"New participant added: {recipient}"); };
        // create participants
        bool finished = false;
        do
        {
            Console.WriteLine("Input 1 for adding participant, input 0 for submitting participants");
            string input = Console.ReadLine();
            switch (input)
            {


                case "1":
                    Console.WriteLine("Input participant name:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Input participant email:");
                    string email = Console.ReadLine();
                    Participant participant = new Participant(name, email);
                    eventManager.AddParticipant(party, participant);
                    break;

                case "0":
                    finished = true;
                    break;

            }
            
        } while (!finished);
    }
}