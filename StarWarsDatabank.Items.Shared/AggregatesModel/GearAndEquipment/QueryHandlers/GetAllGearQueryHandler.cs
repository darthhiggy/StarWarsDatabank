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
    public class GetAllGearQueryHandler : IRequestHandler<GetAllGearQuery, List<Gear>>
    {
        private IGearRepository _gearRepository;

        public GetAllGearQueryHandler(IGearRepository gearRepository)
        {
            _gearRepository = gearRepository;
        }

        public Task<List<Gear>> Handle(GetAllGearQuery request, CancellationToken cancellationToken) =>
            new Task<List<Gear>>(() =>
            {
                return _gearRepository.GetAll();
            });
    }
}
