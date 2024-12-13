using GameStore.Models;

namespace GameStore.ViewModels.Games
{
    public class GameDetailVM
    {
        public string GameId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double SellPrice { get; set; }
        public string CoverImage { get; set; }
    }
}
