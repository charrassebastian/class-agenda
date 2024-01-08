using System.ComponentModel.DataAnnotations;

namespace ClassAgendaBackend.Models;

public class PhotoModel {
    [Key]
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public required byte[] Image { get; set; }
    public MaterialModel? Material { get; set; }
}