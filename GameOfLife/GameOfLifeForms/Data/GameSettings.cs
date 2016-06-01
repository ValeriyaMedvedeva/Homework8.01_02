using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace GameOfLifeForms.Data
{
    [DataContract]
    public class GameSettings
    {
        [DataMember(Name = "Height")]
        public int height { get; set; }
        [DataMember(Name = "Width")]
        public int width { get; set; }
        [DataMember(Name = "MaxNeighboursDie")]
        public int maxNeighboursDie { get; set; }
        [DataMember(Name = "MinNeighboursReproduce")]
        public int minNeighboursReproduce { get; set; }
        [DataMember(Name = "MaxNeighboursReproduce")]
        public int maxNeighboursReproduce { get; set; }
    }
}
