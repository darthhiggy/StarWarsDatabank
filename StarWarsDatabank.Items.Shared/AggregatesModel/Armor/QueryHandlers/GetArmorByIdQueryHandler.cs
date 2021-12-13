using MediatR;
using StarWarsDatabank.Items.FFG.Domain.AggregatesModel.Armor.Queries;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace StarWarsDatabank.Items.FFG.Domain.AggregatesModel.Armor.QueryHandlers
{
    public class GetArmorByIdQueryHandler : IRequestHandler<GetArmorByIdQuery, Armor>
    {
        IArmorRepository _armorRepository;

        public GetArmorByIdQueryHandler(IArmorRepository armorRepository)
        {
            _armorRepository = armorRepository;
        }


        public Task<Armor> Handle(GetArmorByIdQuery request, CancellationToken cancellationToken)
        {
            return new Task<Armor>(() =>
            {
                return _armorRepository.GetById(request.AggregateId);
            });
        }
    }
}
