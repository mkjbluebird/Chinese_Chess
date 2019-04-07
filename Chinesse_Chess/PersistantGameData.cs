using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinesse_Chess
{
    /// <summary>
    /// 棋手数据
    /// </summary>
    public class PersistantGameData
    {
        public bool JustWon { get; set; }
        public LevelDescription CurrentLevel { get; set; }
        
        public PersistantGameData()
        {
            JustWon = false;
        }
    }
}
