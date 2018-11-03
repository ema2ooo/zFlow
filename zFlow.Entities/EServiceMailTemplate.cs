using System;
namespace zFlow.Entities
{
    /// <summary>
    /// Represents a EServiceMailTemplate.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class EServiceMailTemplate : IEntityBase
    {
        public int ID { get; set; }
        public int EServiceMailTemplateID { get; set; }
        public int? DefinitionID { get; set; }
        public string TemplateName { get; set; }
        public string TemplateEn { get; set; }
        public string TemplateAr { get; set; }
    }
}      
