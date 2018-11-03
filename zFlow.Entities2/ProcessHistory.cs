using System;

namespace zFlow.Entities
{
    public class ProcessHistory : IEntityBase
    {
        public int ID { get; set; }
        public string UserID { get; set; }
        public string UserName { get; set; }
        public string UserComment { get; set; }
        public string UserAction { get; set; }
        public DateTime ActionDate { get; set; }
        public bool StepName { get; set; }

    }
}