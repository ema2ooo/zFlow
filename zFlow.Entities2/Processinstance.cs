using System;
using System.Collections.Generic;
using System.Text;

namespace zFlow.Entities
{
    public class Processinstance : IEntityBase
    {
        public Processinstance()
        {
            ProcessHistories = new List<ProcessHistory>();
            ProcessTasks = new List<ProcessTask>();
        }
        public int ID { get; set; }
        public string ProcessNumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Status { get; set; }
        public string OriginatorID { get; set; }
        public string BeneficiaryID { get; set; }
        public bool IsClosed { get; set; }
        public bool IsDraft { get; set; }
        public byte[] DraftXml { get; set; }
        public bool IsCancelled { get; set; }
        public string AdditionalData { get; set; }
        public Guid WFI { get; set; }
        public string DepartmentID { get; set; }
        public virtual ICollection<ProcessHistory> ProcessHistories { get; set; }
        public virtual ICollection<ProcessTask> ProcessTasks { get; set; }
    }
}
