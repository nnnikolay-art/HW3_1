using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW3.Interfaces;

namespace HW3
{
    public class SpaceShip : ISpaceShip
    {
        public int Id { set; get; }
        public int PlayerId { set; get; }
        public string ShipName { set; get; }
        public bool IsMoving { set; get; }
    }
}
