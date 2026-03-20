using LuckySpin.Models;
namespace LuckySpin.ViewModels
{
    public class PlayersChoice
    {
        //DONE: Add  additional properties needed to pre-fill the PlayersChoice View.
        public Player Player { get; set; } = new Player();
        public int SelectedPlayerId { get; set; }
        public ICollection<Player> Players { get; set; } = new List<Player>();
        public ICollection<Game> Games { get; set; } = new List<Game>();

    }
}