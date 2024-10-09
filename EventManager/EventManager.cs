using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager
{
    public delegate void ParticipantAddedHandler(string recipient, string message);
    public class EventManager
    {
        private Dictionary<Event, List<Participant>> eventParticipants;
        public List<Participant> participantList;
        
        public EventManager()
        {
            eventParticipants = new Dictionary<Event, List<Participant>>();
            participantList = new List<Participant>();
        }

        public event ParticipantAddedHandler ParticipantAdded;

        public void AddParticipant(Event even, Participant participant)
        {
            if (!eventParticipants.ContainsKey(even))
            {
                eventParticipants[even] = new List<Participant>();

            }
            eventParticipants[even].Add(participant);
            OnParticipantAdded(participant.Email, $"Participant added: {participant.Name}");
        }
        protected virtual void OnParticipantAdded(string recipient, string message)
        {
            ParticipantAdded?.Invoke(recipient, message);
            EmailNotifier.Notify(recipient, message);
            
        }
    }
}
