using MediatR;
using StarWarsDatabank.Items.FFG.Domain.AggregatesModel.Weapons.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StarWarsDatabank.Items.FFG.Domain.AggregatesModel.Weapons.QueryHandlers
{
    public class SearchWeaponByNameQueryHandler : IRequestHandler<SearchWeaponByNameQuery, List<Weapon>>
    {
        private readonly IWeaponRepository _weaponRepository;

        public SearchWeaponByNameQueryHandler(IWeaponRepository weaponRepository)
        {
            _weaponRepository = weaponRepository;
        }

        public Task<List<Weapon>> Handle(SearchWeaponByNameQuery request, CancellationToken cancellationToken) =>
            new Task<List<Weapon>>(() =>
            {
                return _weaponRepository.SearchByName(request.SearchString);
            });
    }
}
