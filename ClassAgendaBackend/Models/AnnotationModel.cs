using System.ComponentModel.DataAnnotations;

namespace ClassAgendaBackend.Models;

public class AnnotationModel {
    [Key]
    public Guid Id { get; set; }
    public required string Content { get; set; }
    public MaterialModel? Material { get; set; }
}