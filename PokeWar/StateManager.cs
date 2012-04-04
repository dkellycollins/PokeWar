using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PokeWar
{
    /// <summary>
    /// Controls the order of the UserControls and manages shared UI resources
    /// </summary>
    public class UIManager
    {
        public static UIManager Instance = new UIManager();

        private UIManager() { }

        #region Controls
        public PokeWarControl[] Controls = {
            new TitleControl(),
            new PlayerSelectControl(),
            new BattleControl()
        };

        private enum State
        {
            title = 0,
            player_select = 1,
            battle = 2
        }
        private State curState = State.battle;

        public PokeWarControl GetNextControl()
        {
            switch (curState)
            {
                case State.player_select:
                    Controls[(int)curState].Clean();
                    curState = State.battle;
                    return Controls[(int)curState];
                case State.battle:
                    Controls[(int)curState].Clean();
                    curState = State.title;
                    return Controls[(int)curState];
                case State.title:
                default:
                    Controls[(int)curState].Clean();
                    curState = State.player_select;
                    return Controls[(int)curState];
            }
        }
        #endregion

        #region Game
        public PokeWarEngine.PokeWar Game { get; private set; }

        public PokeWarEngine.PokeWar CreateNewGame(Player user, Player computer)
        {
            Game = new PokeWarEngine.PokeWar(user, computer);
            return Game;
        }
        #endregion
    }
}
