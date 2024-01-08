using System.ComponentModel.DataAnnotations;

namespace ClassAgendaBackend.Models;

public class PhotoModel {
    [Key]
    public Guid Id;
    public required string Name { get; set; }
    public required byte[] Image { get; set; }
    public required MaterialModel Material { get; set; }
}