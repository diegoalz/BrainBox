namespace BrainBox.Domain.Common;

public abstract class BaseAutidableModel
{
    // protected BaseAutidableModel()
    // {
        
    // }
    // protected BaseAutidableModel(
    //     BaseId id,
    //     DateTime createdDate,
    //     int createdBy,
    //     DateTime updatedDate,
    //     int updatedBy
    // )
    // {
    //     Id = id;
    //     CreatedDate = createdDate;
    //     CreatedBy = createdBy;
    //     UpdatedDate = updatedDate;
    //     UpdatedBy = updatedBy;
    // }
    public BaseId Id { get; private set; }
    public DateTime? CreatedDate { get; set; }
    public int? CreatedBy { get; set; }
    public DateTime? UpdatedDate { get; set; }
    public int? UpdatedBy { get; set; }
}