using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PokeWar
{
    public class StateManager
    {
        public static StateManager Instance = new StateManager();

        private enum State
        {
            title,
            player_select,
            battle
        }
        private State curState;

        private StateManager() {}

        public UserControl GetNextState()
        {
            switch (curState)
            {
                case State.title:
                    curState = State.player_select;
                    return new PlayerSelectControl();
                case State.player_select:
                    curState = State.battle;
                    return new BattleControl();
                case State.battle:
                default:
                    curState = State.title;
                    return new TitleControl();
            }
        }

    }
}
