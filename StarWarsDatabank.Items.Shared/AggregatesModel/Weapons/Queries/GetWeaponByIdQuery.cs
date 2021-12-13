﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsDatabank.Items.FFG.Domain.AggregatesModel.Weapons.Queries
{
    public class GetWeaponByIdQuery : IRequest<Weapon>
    {
        public int WeaponId { get; set; }
    }
}
