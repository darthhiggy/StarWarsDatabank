using MediatR;
using StarWarsDatabank.Items.FFG.Domain.AggregatesModel.Armor.Queries;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace StarWarsDatabank.Items.FFG.Domain.AggregatesModel.Armor.QueryHandlers
{
    public class GetArmorByNameQueryHandler : IRequestHandler<GetArmorByNameQuery, List<Armor>>
    {
        IArmorRepository _armorRepository;

        public GetArmorByNameQueryHandler(IArmorRepository armorRepository)
        {
            _armorRepository = armorRepository;
        }

        public Task<List<Armor>> Handle(GetArmorByNameQuery request, CancellationToken cancellationToken)
        {
            return new Task<List<Armor>>(() =>
            {
                return _armorRepository.SearchByName(request.SearchString);
            });
        }
    }
}
