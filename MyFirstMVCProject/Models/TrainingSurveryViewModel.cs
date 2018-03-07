using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFirstMVCProject.Models
{
    public class TrainingSurveryViewModel
    {
        public string SessionId { get; set; }

        public DateTime SessionDateTime { get; set; }
        public string ParticipantName { get; set; }
        public int Question1 { get; set; }
        public int Question2 { get; set; }
        public int Question3 { get; set; }
        public int Question4 { get; set; }
        public int Question5 { get; set; }
        public string Question6 { get; set; }
        public string Question7 { get; set; }
        public string Question8 { get; set; }
        public string Question9 { get; set; }
        public string UserNm { get; set; }
    }
}