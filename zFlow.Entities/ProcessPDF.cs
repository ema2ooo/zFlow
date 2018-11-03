using System;
namespace zFlow.Entities
{
    /// <summary>
    /// Represents a ProcessPDF.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class ProcessPDF : IEntityBase
    {
        public int ID { get; set; }
        public int ProcessDefinitionID { get; set; }
        public byte[] PDFFileContent { get; set; }
        public string PDFFileName { get; set; }
    }
}      
