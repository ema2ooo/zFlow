using System;
namespace zFlow.Entities
{
    /// <summary>
    /// Represents a ProcessAttachment.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class ProcessAttachment : IEntityBase
    {
        public int ID { get; set; }
        public string FileUploadContext { get; set; }
        public string FileName { get; set; }
        public byte[] FileContent { get; set; }
        public Int64 FileSizeInBytes { get; set; }
    }
}      
