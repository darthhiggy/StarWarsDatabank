using MediatR;
using StarWarsDatabank.Items.FFG.Domain.AggregatesModel.Weapons.Queries;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace StarWarsDatabank.Items.FFG.Domain.AggregatesModel.Weapons.QueryHandlers
{
    public class GetAllWeaponsQueryHandler : IRequestHandler<GetAllWeaponsQuery, List<Weapon>>
    {
        private readonly IWeaponRepository _weaponRepository;

        public GetAllWeaponsQueryHandler(IWeaponRepository weaponRepository)
        {
            _weaponRepository = weaponRepository;
        }

        public Task<List<Weapon>> Handle(GetAllWeaponsQuery request, CancellationToken cancellationToken) =>
            new Task<List<Weapon>>(() =>
            {
                return _weaponRepository.GetAll();
            });
    }
}
