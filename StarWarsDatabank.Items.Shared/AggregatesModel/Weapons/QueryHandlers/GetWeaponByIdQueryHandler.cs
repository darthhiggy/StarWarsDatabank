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
    public class GetWeaponByIdQueryHandler : IRequestHandler<GetWeaponByIdQuery, Weapon>
    {
        private readonly IWeaponRepository _weaponRepository;

        public GetWeaponByIdQueryHandler(IWeaponRepository weaponRepository)
        {
            _weaponRepository = weaponRepository;
        }

        public Task<Weapon> Handle(GetWeaponByIdQuery request, CancellationToken cancellationToken) =>
            new Task<Weapon>(() =>
            {
                return _weaponRepository.GetById(request.WeaponId);
            });
    }
}
