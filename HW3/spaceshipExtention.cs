using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HW3
{
    public static class SpaceshipsExtensions
    {
        public static IEnumerable<SpaceShip> GetPlayerSpaceships(this IEnumerable<SpaceShip> spaceships, int playerId)
        {
            return spaceships.Where(spaceship => spaceship.PlayerId == playerId);
        }

        public static SpaceShip? GetSpaceShip(this IEnumerable<SpaceShip> spaceShip, int id)
        {
            return spaceShip.Where(spaceShip => spaceShip.Id == id).FirstOrDefault();
        }

        public static IEnumerable<SpaceShip> GetMovingSpaceShips(this IEnumerable<SpaceShip> spaceships)
        {
            return spaceships.Where(spaceShip => spaceShip.IsMoving == true);
        }
    }


}
