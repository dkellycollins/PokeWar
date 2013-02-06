using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using CardLib;

namespace PokeWar.Engine
{
    /// <summary>
    /// Manages the images that are in use for the game.
    /// </summary>
    public class ImageManager
    {
        /*

        //Stores cards that we have already loaded.
        private Dictionary<Card, Image> _cacheImages;

        public Image AceCards { get; internal set; }

        //Player1 info
        public Image Player1AceCard { get; internal set; }
        public string Player1Name { get; internal set; }
        public Image[] Player1Hand { get; internal set; }
        public Image Player1PlayedCard { get; internal set; }

        //Player2 info
        public Image Player2AceCard { get; internal set; }
        public string Player2Name { get; internal set; }
        public Image[] Player2Hand { get; internal set; }
        public Image Player2PlayedCard { get; internal set; }

        //Common info
        public Image CardBackImage { get; internal set; }

        public ImageManager(){}

        /// <summary>
        /// Clears all data.
        /// </summary>
        public void Reset()
        {
            Player1AceCard = null;
            Player1Name = null;
            Player1PlayedCard = null;
            Player2AceCard = null;
            Player2Name = null;
            Player2PlayedCard = null;
            _cacheImages.Clear();
        }

        /// <summary>
        /// If an image has not been loaded, loads the image.
        /// </summary>
        /// <param name="card"></param>
        /// <returns></returns>
        internal Image GetCachedImage(Card card)
        {
            if(!_cacheImages.ContainsKey(card))
                _cacheImages[card] = card.FrontImage;
            return _cacheImages[card];
        }
         * 
         */
    }
}
