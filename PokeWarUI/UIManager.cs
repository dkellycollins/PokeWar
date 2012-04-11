using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PokeWarUI
{
    /// <summary>
    /// Controls the order of the UserControls and manages shared UI resources
    /// </summary>
    public class UIManager
    {
        public static UIManager Instance = new UIManager();

        private UIManager() { }

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
                    curState = State.battle;
                    return new BattleControl();
                case State.battle:
                    curState = State.title;
                    return new TitleControl();
                case State.title:
                default:
                    curState = State.player_select;
                    return new PlayerSelectControl();
            }
        }
    }
}
