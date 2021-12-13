using MediatR;
using StarWarsDatabank.Items.FFG.Domain.AggregatesModel.Armor;
using StarWarsDatabank.Items.FFG.Domain.AggregatesModel.Armor.Queries;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace StarWarsDatabank.Items.FFG.Domain.AggregatesModel.Armor.QueryHandlers
{
    public class GetAllArmorQueryHandler : IRequestHandler<GetAllArmorQuery, List<Armor>>
    {
        private readonly IArmorRepository _armorRepository;

        public GetAllArmorQueryHandler(IArmorRepository armorRepository)
        {
            _armorRepository = armorRepository;
        }

        public Task<List<Armor>> Handle(GetAllArmorQuery request, CancellationToken cancellationToken)
        {
            return new Task<List<Armor>>(() =>
            {
                return _armorRepository.GetAll();
            });
        }
    }
}
