using System.ComponentModel.DataAnnotations;

namespace LoginRegDemo
{
    public class Participant
    {
        [Key]
        public int ParticipantsId {get; set;}

        public int UserId {get; set;}

        public User user {get; set;}

        public int EventId {get; set;}

        public Event events {get; set;}

    }
}

