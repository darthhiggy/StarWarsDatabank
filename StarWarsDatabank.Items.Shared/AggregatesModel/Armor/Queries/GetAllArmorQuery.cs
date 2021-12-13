using MediatR;
using StarWarsDatabank.Items.FFG.Domain.AggregatesModel.Armor;
using System.Collections.Generic;

namespace StarWarsDatabank.Items.FFG.Domain.AggregatesModel.Armor.Queries
{
    public class GetAllArmorQuery : IRequest<List<Armor>>
    {
    }
}
