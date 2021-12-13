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
    public class GetGearByIdQueryHandler : IRequestHandler<GetGearByIdQuery, Gear>
    {
        private readonly IGearRepository _gearRepository;

        public GetGearByIdQueryHandler(IGearRepository gearRepository)
        {
            _gearRepository = gearRepository;
        }

        public Task<Gear> Handle(GetGearByIdQuery request, CancellationToken cancellationToken)
        {
            return new Task<Gear>(() =>
            {
                return _gearRepository.GetById(request.AggregateId);
            });
        }
    }
}
