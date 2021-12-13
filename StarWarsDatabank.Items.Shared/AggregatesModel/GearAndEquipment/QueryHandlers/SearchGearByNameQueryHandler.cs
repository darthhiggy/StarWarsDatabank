using MediatR;
using StarWarsDatabank.Items.FFG.Domain.AggregatesModel.GearAndEquipment.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StarWarsDatabank.Items.FFG.Domain.AggregatesModel.GearAndEquipment.QueryHandlers
{
    public class SearchGearByNameQueryHandler : IRequestHandler<SearchGearByNameQuery, List<Gear>>
    {
        private readonly IGearRepository _gearRepository;

        public SearchGearByNameQueryHandler(IGearRepository gearRepository)
        {
            _gearRepository = gearRepository;
        }

        public Task<List<Gear>> Handle(SearchGearByNameQuery request, CancellationToken cancellationToken) =>
            new Task<List<Gear>>(() =>
            {
                return _gearRepository.SearchByName(request.SearchString);
            });
    }
}
