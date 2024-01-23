using HW3;
using HW3.Interfaces;

IEnumerable<SpaceShip> spaceships = new SpaceShip[]
{
    new SpaceShip { Id = 1, PlayerId = 1, ShipName = "BattleCruiser",IsMoving=true  },
    new SpaceShip { Id = 2, PlayerId = 2, ShipName = "Banshee",IsMoving=true  },
    new SpaceShip { Id = 3, PlayerId = 1, ShipName = "Vicking",IsMoving=false  },
    new SpaceShip { Id = 4, PlayerId = 3, ShipName = "StarHunter",IsMoving=false  }
};

Console.WriteLine("Корабль у которого ID объекта = 1:");
var spaceShipOne = spaceships.GetSpaceShip(1);
Console.WriteLine($"ID: " + spaceShipOne?.Id
                    + ", PlayerId:" + spaceShipOne?.PlayerId
                    + ", ShipName: " + spaceShipOne?.ShipName
                    + ", IsMoving: " + spaceShipOne?.IsMoving);

Console.WriteLine("Список кораблей у игрока 1:");
var spaceShipByPlayer = spaceships.GetPlayerSpaceships(1);
foreach (var spaceShip in spaceShipByPlayer)
{
    Console.WriteLine($"ID: " + spaceShip?.Id
                        + ", PlayerId: " + spaceShip?.PlayerId
                        + ", ShipName: " + spaceShip?.ShipName
                        + ", IsMoving: " + spaceShip?.IsMoving);

}

Console.WriteLine("Список кораблей в движении:");
var MovingSpaceships = spaceships.GetMovingSpaceShips();
foreach (var spaceShip in MovingSpaceships)
{
    Console.WriteLine($"ID: " + spaceShip?.Id
                        + ", PlayerId: " + spaceShip?.PlayerId
                        + ", ShipName: " + spaceShip?.ShipName
                        + ", IsMoving: " + spaceShip?.IsMoving);
}