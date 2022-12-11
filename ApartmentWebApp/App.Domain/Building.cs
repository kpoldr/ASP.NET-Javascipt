﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Base.Domain;

namespace App.Domain;

public class Building : DomainEntityMetaId

{
    [MaxLength(256)]
    [Column(TypeName = "jsonb")]
    [Display(ResourceType = typeof(App.Resources.App.Domain.Building), Name = nameof(Address))]
     public LangStr Address { get; set; } = default!;
    
    public ICollection<Utility>? Utilities { get; set; }
    public ICollection<Apartment>? Apartments { get; set; }

    [Display(ResourceType = typeof(App.Resources.App.Domain.Ids), Name = nameof(AssociationId))]
    public Guid AssociationId { get; set; }
    
    [Display(ResourceType = typeof(App.Resources.App.Domain.EntityNames), Name = nameof(Association))]
    public Association? Association { get; set; }
}