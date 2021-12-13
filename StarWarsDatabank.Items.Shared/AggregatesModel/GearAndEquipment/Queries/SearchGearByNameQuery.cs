using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsDatabank.Items.FFG.Domain.AggregatesModel.GearAndEquipment.Queries
{
    public class SearchGearByNameQuery : IRequest<List<Gear>>
    {
        public string SearchString { get; set; }
    }
}
