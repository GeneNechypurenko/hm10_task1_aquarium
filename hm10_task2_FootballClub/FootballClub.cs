using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm10_task2_FootballClub
{
    internal class FootballClub : Player, IEnumerable<Player>
    {
        List<Player>players = new List<Player>();
        public void AddNewPlayer(Player player)
        {
            players.Add(player);
        }
        public IEnumerator<Player> GetEnumerator()
        {
           return players.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public override void Info()
        {
            throw new NotImplementedException();
        }
    }
}
