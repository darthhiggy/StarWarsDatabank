using MediatR;
using StarWarsDatabank.Items.FFG.Domain.AggregatesModel.Armor;

namespace StarWarsDatabank.Items.FFG.Domain.AggregatesModel.Armor.Queries
{
    public class GetArmorByIdQuery : IRequest<Armor>
    {
        public int AggregateId { get; set; }
    }
}
